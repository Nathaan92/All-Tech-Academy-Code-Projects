from tkinter import *
import tkinter as tk
from tkinter import messagebox
from tkinter import filedialog

import Gui_Challenge_Functions

class ParentWindow(Frame):
    def __init__(self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        self.master = master
        self.master.minsize(481,172)
        self.master.maxsize(481,172)
        self.master.title("Check Files")
        

        self.btn_abrowse = tk.Button(self.master,width=12,height=1,text='Browse...', command=lambda: Gui_Challenge_Functions.callbacka(self))
        self.btn_abrowse.grid(row=1,column=0,padx=(15,15),pady=(40,5),sticky=W)
        self.btn_bbrowse = tk.Button(self.master,width=12,height=1,text='Browse...', command=lambda: Gui_Challenge_Functions.callbackb(self))
        self.btn_bbrowse.grid(row=2,column=0,padx=(15,15),pady=(5,5),sticky=W)
        self.btn_check = tk.Button(self.master,width=12,height=2,text='Check for files...', command=lambda: Gui_Challenge_Functions.callback(self))
        self.btn_check.grid(row=3,column=0,padx=(15,0),pady=(5,20),sticky=W)

        
        self.txt_abrowse = tk.Entry(self.master,width=53, text='')
        self.txt_abrowse.grid(row=1,column=2,rowspan=1,padx=(15,0),pady=(40,15),sticky=E)
        self.txt_bbrowse = tk.Entry(self.master,width=53, text='')
        self.txt_bbrowse.grid(row=2,column=2,rowspan=1,padx=(15,0),pady=(5,0),sticky=E)
        self.btn_close = tk.Button(self.master,width=12,height=2,text='Close Program', command=lambda: Gui_Challenge_Functions.close(self))
        self.btn_close.grid(row=3,column=2,columnspan=1,padx=(0,0),pady=(0,20),sticky=E)


if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()
