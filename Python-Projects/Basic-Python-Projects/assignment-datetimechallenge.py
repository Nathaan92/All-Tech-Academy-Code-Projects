# using pytz create an app that displays the time at various company locations and display if the are open or closed

from datetime import datetime
import pytz

def NY():
    location = "America/New_York"
    timezone = pytz.timezone(location)
    time = datetime.now(timezone)
    hTime = time.hour
    if hTime in range(9,17):
        print("It is" + time .strftime(" %H:%M") + " at the New York Office which is currently open.")
    else:
        print("It is" + time .strftime(" %H:%M") + " at the New York Office which is currently closed.")

def LN():
    location = "Europe/London"
    timezone = pytz.timezone(location)
    time = datetime.now(timezone)
    hTime = time.hour
    if hTime in range(9,17):
        print("It is" + time .strftime(" %H:%M") + " at the London Office which is currently open.")
    else:
        print("It is" + time .strftime(" %H:%M") + " at the London Office which is currently closed.")

def PT():
    location = "America/Los_Angeles"
    timezone = pytz.timezone(location)
    time = datetime.now(timezone)
    hTime = time.hour
    if hTime in range(9,17):
        print("It is" + time .strftime(" %H:%M") + " at the Portland Office which is currently open.")
    else:
        print("It is" + time .strftime(" %H:%M") + " at the Portland Office which is currently closed.")

if __name__ == "__main__":
    print(PT(), LN(), NY())
