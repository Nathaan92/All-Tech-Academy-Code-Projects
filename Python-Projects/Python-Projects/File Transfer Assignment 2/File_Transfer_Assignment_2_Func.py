import shutil
import os
from tkinter import filedialog
import time 

import File_Transfer_Assignment_2_Main

def callbacka(self):
    directorya = filedialog.askdirectory()
    self.txt_abrowse.insert(0,directorya)

def callbackb(self):
    directoryb = filedialog.askdirectory()
    self.txt_bbrowse.insert(0,directoryb)

def updato(self):
    src = self.txt_abrowse.get()
    dest = self.txt_bbrowse.get()
    files = os.listdir(src)
    
    for i in files:
        abspath = os.path.join(src, i)
        mtime = os.path.getmtime(abspath)
        localtime = time.time()
        if mtime > localtime - 86400:
            shutil.copy2(abspath, dest)

def close(self):
    self.master.destroy()
    os._exit(0)


if __name__ == "__main__":
    pass
