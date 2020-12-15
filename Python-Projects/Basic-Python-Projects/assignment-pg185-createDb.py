# REQUIREMENTS:
#
# Your script will need to use Python 3 and the sqlite3 module.
#
# Your database will require 2 fields: an auto-increment primary integer field and a field with the data type "string".
#
# Your script will need to read from the supplied list of file names at the bottom of this page and determine only the files from the list which end with a “.txt” file extension.
#
# Next, your script should add those file names from the list ending with “.txt” file extension within your database.
#
# Finally, your script should legibly print the qualifying text files to the console.
import sqlite3

conn = sqlite3.connect('assignment-pg185-createDb.db')

with conn:
    cur = conn.cursor()
    cur.execute("CREATE TABLE IF NOT EXISTS tbl_files( \
        ID INTEGER PRIMARY KEY AUTOINCREMENT, \
        col_file_name TEXT \
        )")
    conn.commit()
conn.close()

fileList = ('information.dox', 'Hello.txt', 'myImage.png', \
            'myMovie.mpg', 'World.txt', 'data.pdf', 'myPhoto.jpg')


conn = sqlite3.connect("assign2.db")
with conn:
    cur = conn.cursor()
    for fileName in fileList:
        if fileName.endswith(".txt"):
            cur.execute("INSERT INTO tbl_files(col_file_name) VALUES(?)",(fileName,))
    conn.commit()
conn.close()

conn = sqlite3.connect("assign2.db")
with conn:
    cur = conn.cursor()
    cur.execute("select * from tbl_files")
    results = cur.fetchall()
    print(results)
conn.close()
