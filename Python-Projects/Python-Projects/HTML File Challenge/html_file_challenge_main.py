import os
from tkinter import *
import tkinter as tk

import html_file_Challenge_funct

class ParentWindow(Frame):
    def __init__(self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        self.master = master
        self.master.minsize(500,200)
        self.master.maxsize(500,200)
        self.master.title("Web Page Text")

        self.txt_info = tk.Label(self.master,text='In the text box bellow please write what you would like your webpage to say!')
        self.txt_info.grid(row=0,column=0,padx=(27,0),pady=(10,0),sticky=N+W)
        self.txt_txt = tk.Entry(self.master,text='')
        self.txt_txt.grid(row=2,column=0,padx=(27,0),pady=(10,0),sticky=N+W)
        self.btn_create = tk.Button(self.master,width=12,height=2,text='Create', command=lambda: html_file_Challenge_funct.customhtmlpage(self),)
        self.btn_create.grid(row=4,column=0,padx=(27,0),pady=(10,0),sticky=N+W)


if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()
