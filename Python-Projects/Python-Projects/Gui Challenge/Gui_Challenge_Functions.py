import os
from tkinter import *
import tkinter as tk
from tkinter import filedialog

import Gui_Challenge

def callbacka(self:
    self.directory = filedialog.askdirectory()
    self.txt_abrowse.insert(0,self.directory)

def callbackb(self):
    self.directory = filedialog.askdirectory()
    self.txt_bbrowse.insert(0,self.directory)

def close(self):
    self.master.destroy()
    os._exit(0)


if __name__ == "__main__":
    pass
