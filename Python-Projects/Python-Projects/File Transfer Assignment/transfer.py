import shutil
import os

#set where the source of the files are
source = "/Users/natha/Desktop/Python/File Transfer Assignment/Folder A/"
#set the destination path to folderB
destination = "/Users/natha/Desktop/Python/File Transfer Assignment/Folder B/"
files = os.listdir(source)

for i in files:
    #we are saying move the files represented by 'i' to their new destination
    shutil.move(source+i, destination)
