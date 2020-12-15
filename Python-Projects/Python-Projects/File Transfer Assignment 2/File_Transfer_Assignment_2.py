import shutil
import os


src = "/Users/natha/Desktop/Python/File Transfer Assignment 2/The Office/"

dest = "/Users/natha/Desktop/Python/File Transfer Assignment 2/The House/"
files = os.listdir(src)
if os.stat(src).st_mtime - os.stat(dest).st_mtime > 0:
    for i in files:
        shutil.copy2(src+i, dest)
