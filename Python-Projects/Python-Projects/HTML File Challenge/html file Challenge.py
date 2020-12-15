f = open("htmlfile.txt","w")
f.write("<html>\n<body>\nStay tuned for our amazing summer sale!\n</body>\n</html>")
f.close

f = open("htmlfile.txt","r")
print(f.read())
