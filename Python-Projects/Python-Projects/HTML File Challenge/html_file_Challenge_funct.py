import os
from tkinter import *
import tkinter as tk

import html_file_challenge_main

def customhtmlpage(self):
    var_text = self.txt_txt.get()
    f = open("htmlfile.txt","w")
    f.write("<html>\n<body>\n{}\n</body>\n</html>".format(var_text))
    f.close

    f = open("htmlfile.txt","r")
    print(f.read())

if __name__ == "__main__":
    pass
