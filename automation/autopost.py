import os
from pathlib import Path
from datetime import datetime
import shutil
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
from srtools import cyrillic_to_latin
import ssl
import glob
import time
import csv

ssl._create_default_https_context = ssl._create_unverified_context

def copy_rename_board(source_dir):
    dest_dir = Path(os.path.dirname(os.path.realpath(__file__)))
    dest_dir = dest_dir.parent.absolute()
    date = datetime.today().strftime('%m.%d.%Y')
    dest_dir = dest_dir.joinpath(f'table/{date}.pdf')
    shutil.copy(source_dir, dest_dir)

def petlja_sign_in(driver, creds):
    user, password = creds
    
    sign_in_button = driver.find_element(By.XPATH, "//*[contains(text(), 'Uloguj se')]")
    sign_in_button.click()
    
    user_input = driver.find_element(By.ID, "username")
    user_input.click()
    user_input.send_keys(user + Keys.ENTER)
    
    pwd_input = driver.find_element(By.ID, "password")
    pwd_input.send_keys(password)

    finish_bt = driver.find_element(By.ID, "login-finish")
    finish_bt.click()

def get_driver():
    download_dir = Path(os.path.dirname(os.path.realpath(__file__)))
    download_dir = download_dir.joinpath('temp_downloads')
    chromeOptions = webdriver.ChromeOptions()
    prefs = {"download.default_directory" : str(download_dir)}
    chromeOptions.add_experimental_option("prefs",prefs)
    driver = webdriver.Chrome(options=chromeOptions)
    driver.implicitly_wait(5)
    return driver

def move_source_from_temp(dest_dir):
    download_dir = Path(os.path.dirname(os.path.realpath(__file__)))
    download_dir = download_dir.joinpath('temp_downloads')
    os.chdir(download_dir)
    file = glob.glob('*.cs')[0]
    shutil.move(file, dest_dir)

def petlja_get_source(driver, url, creds):
    driver.get(url)
    problem_name_simple = url.split('/')[-1]

    submission_rows = driver.find_elements(By.CLASS_NAME, "centerrows")
    download_col = submission_rows[1].find_element(By.XPATH, ".//td[4]")
    download_url = download_col.find_element(By.XPATH,".//a[1]").get_attribute('href')

    dest_dir = Path(os.path.dirname(os.path.realpath(__file__)))
    dest_dir = dest_dir.parent.absolute()
    date = datetime.today().strftime('%m.%d.%Y')
    dest_dir = dest_dir.joinpath(f'kodovi/{date}/')
    dest_dir.mkdir(parents=True, exist_ok=True)
    dest_dir = dest_dir.joinpath(f'{problem_name_simple}.cs')
    
    driver.get(download_url)
    time.sleep(3)
    move_source_from_temp(dest_dir)

def petlja_get_creds(dir):
    creds_file = open(dir,'r')
    lines = creds_file.readlines()
    return lines[0].split()[0], lines[1].split()[0]

def petlja_get_sources(sources, creds):
    driver = get_driver()
    driver.get(sources[0])
    
    petlja_sign_in(driver, creds)
    for src in sources:
        petlja_get_source(driver, src, creds)

def index_create_new_post():
    index_dir = Path(os.path.dirname(os.path.realpath(__file__)))
    index_dir = index_dir.parent.absolute()
    index_dir = index_dir.joinpath('index.md')

    date = datetime.today().strftime('%m.%d.%Y')
    whiteboard_link = f'https://github.com/oneskovic/kurs_2022/blob/gh-pages/table/{date}.pdf'
    
    index_file = open(index_dir,'a')
    index_file.write(f'## {date}.\n')
    index_file.write(f'  * [Tabla]({whiteboard_link})\n')
    index_file.write(f'  * Zadaci:\n')
    index_file.close()

def index_add_problems(solved_urls, homework_urls):
    index_dir = Path(os.path.dirname(os.path.realpath(__file__)))
    index_dir = index_dir.parent.absolute()
    index_dir = index_dir.joinpath('index.md')
    index_file = open(index_dir,'a', encoding='utf-8')
    date = datetime.today().strftime('%m.%d.%Y')

    driver = get_driver()
    for i in range(len(solved_urls)):
        driver.get(solved_urls[i])
        problem_name_cyrillic =  driver.find_element(By.CLASS_NAME, "problemtitle").find_element(By.XPATH, ".//h2").text
        problem_name_latin = cyrillic_to_latin(problem_name_cyrillic)
        problem_name_simple = solved_urls[i].split('/')[-1]
        solution_link = f'https://github.com/oneskovic/kurs_2022/blob/gh-pages/kodovi/{date}/{problem_name_simple}.cs'
        index_file.write(f'  {i+1}. [{problem_name_latin}]({solved_urls[i]}) ([Rešenje]({solution_link}))\n')

    for i in range(len(homework_urls)):
        driver.get(homework_urls[i])
        problem_name_cyrillic =  driver.find_element(By.CLASS_NAME, "problemtitle").find_element(By.XPATH, ".//h2").text
        problem_name_latin = cyrillic_to_latin(problem_name_cyrillic)
        index_file.write(f'  {len(solved_urls)+i+1}. **Domaći:** [{problem_name_latin}]({homework_urls[i]})\n')

    index_file.write("\n\n")
    index_file.close()


creds = None
solved_problems_to_get = []
homework_problems_to_get = []

task_file_dir = Path(os.path.dirname(os.path.realpath(__file__))).joinpath('task.csv')
task_file = open(task_file_dir, 'r')
for row in csv.reader(task_file):
    task_type = row[0]
    directory = row[1].split()[0]
    if task_type == 'c':    # Creds
        creds = petlja_get_creds(directory)
    elif task_type == 't':  # Whiteboard
        copy_rename_board(directory)
    elif task_type == 'z':  # Problem solved in class
        solved_problems_to_get.append(directory)
    elif task_type == 'd':  # Homework problem
        homework_problems_to_get.append(directory)

petlja_get_sources(solved_problems_to_get, creds)
index_create_new_post()
index_add_problems(solved_problems_to_get, homework_problems_to_get)