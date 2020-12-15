from tkinter import * #imports tkniter
win = Tk() #contructs a window 
b1 = Button(win, text="One") #creates button one
b2 = Button(win, text="Two") #creates button two
b1.pack(side=LEFT, padx=10) #Packs the button into its parents, without location parameters it will be default to top of grid
b2.pack(side=LEFT, padx=10) #pad x provides spacing between the object
b1.grid(row = 0, columm = 0) 
b2.grid(row = 1, column = 1) #Proivdes location of buttons using thedefualt grid layout
l = Label(win, text="This is a label")
l.grid(row=1, column=0)#creates a label

win=Tk()
f = Frame(win)
b1=Button(f,text="one")
b2=Button(f,text="Two")
b3=Button(f, text="Three")
b1.pack(side=LEFT)
b2.pack(side=LEFT)
b3.pack(side=LEFT)
l = Label(win, text="This label is over all buttons")
l.pack()#by calling l first is stakes it on top
f.pack()

b1.configure(text="Uno") #changes button to "uno" this is due to the cllbacl functions

def but1():
    print("Button one was pushed")
b1.configure(command=but1) #Gives a function to the button that results with a print command

win = Tk()
v = StringVar()
e = Entry(win,textvariable = v)
e.pack() #creates a string type box that we can retive data from
v.get() #retrieves the data

v.set("this is set by the program")#this can place data into the text box created above

>>> win = Tk()
>>> lb = Listbox(win,height=3)
>>> lb.pack()
>>> lb.insert(END, "first entry")
>>> lb.insert(END, "second entry")
>>> lb.insert(END, "third entry")
>>> lb.insert(END, "fourth entry") #this list boc will only show three of the inserts due to the height being called as 3

>>> sb.pack(side=LEFT, fill=Y) #creates scroll bar

>>> sb.configure(command=lb.yview)
>>> lb.configure(yscrollcommand=sb.set) #provides function to the scrollbar created above

>>> lb.curselection() #this will provide the index location of the current list item selected

