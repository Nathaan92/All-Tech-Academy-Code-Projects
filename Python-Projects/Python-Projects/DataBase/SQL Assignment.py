#import sqlite3
#connection = sqlite3.connect("test_database.db")   #>>>creation of the database

#c = connection.cursor()    #>>>the cursor is a control structure that enables operations on a database

#c.execute("CREATE TABLE People(FirstName TEXT, LastName TEXT, Age INT)")       #>>>Creates the columns

#c.execute("INSERT INTO People VALUES('Ron', 'Obvious', 42)")   #>>>Inserts data into the relative index locations

#connection.commit()    #>>>commits the data to the database

#connection = sqlite3.connect(':memory:')   #>>>creates a temp database used for storeing code while working

#c.execute("DROP TABLE IF EXISTS People")   #>>>to delete a table


#connection.close() #>>>ends a connection to a database

#with sqlite3.connect("test_database.db") as connection:    #Perform any sql operations using conenction here
    #c = connection.cursor()
    #c.executescript("""DROP TABLE IF EXISTS People; CREATE TABLE Peple(firstName TEST, lastName TEXT, Age INT); INSERT INTO People VALUES('Ron', 'Obvious','42');""")
    #>>>how to insert multiple lines of SQL commands using the execute script method


#peopleValue = (('Luigi', 'Vercotti',43), ('Authur', 'Belling', 28))    #>>>using the execute many method
#c.executemany("INSERT INTO People VALUES(?, ?, ?)",peopleValues


#import sqlite3
#peopleValues = (('Ron', 'Obvious', 42), ('Luigi', 'Vercotti', 43), ('Auhtur', 'Belling', 28))

#with sqlite3.connect('test_database.db') as connection:
    #c = connection.cursor()
    #c.execute("DROP TABLE IF EXISTS People")
    #c.execute("CREATE TABLE People(FirstName TEXT, LastName TEXT, Age INT)")
    #c.executemany("INSERT INTO People VALUES(?, ?, ?)", peopleValues)
    #>>>selects all first and last name form people over the age of 30
    #c.execute("SELECT FirstName, LastName FROM People WHERE Age > 30")
    #for row in c.fetchall():
        #print(row)
#>>>Inset data and query for specific info (poeple over the age of 30)

    #c.execute("SELECT FirstName, LastName FROM People WHERE Age >30")
    #while True:
        #row = c.fetchone()
        #if row is None:
           #break
        #print(row) #queries info using a loop and the breakin said loop if None is found

#!!!test!!!

>>> import sqlite3
>>> connection = sqlite3.connect(':memory:')
>>> c = connection.cursor()
>>> c.execute("CREATE TABLE Roster(Name TEXT, Species TEXT, IQ INT)")
>>> peopleValues = (('Jean-Baptiste Zorg', 'Human', 122), ('Korben Dallas', 'Meat Popsicle', 100), ("Ak'not", 'Mangalore', -5))
>>> c.executemany("INSERT INTO Roster VALUES(?, ?, ?)", peopleValues)
>>> c.execute("UPDATE Roster SET Species = 'Human' WHERE Name = 'Korben Dallas'")
>>> c.execute("SELECT * FROM Roster WHERE Species == 'Human'")
>>> for row in c.fetchall():
	print(row)


>>> for count in(range(0,4)):
	print(count)# counting forwards alonga set range
>>> for count in range(4,0,-1):
	print(count) #counting backwards
>>> for count in (range(0,10,2)):
	print(count)#counting and using the parameter to skip 2
>>> for count in (range(10,0,-2)):
	print(count)#counting backwards and skipping 2





