"""ABSTRACTION ASSIGNMENT
Create a class that utilizes the concept of abstraction.

1. Your class should contain at least one abstract method and one regular method.

2. Create a child class that defines the implementation of its parents abstract method.

3. Create an object that utilizes both the parent and child methods.
"""

from abc import ABC, abstractmethod
class food(ABC):
    def receipt(self, total):
        print("The total of your purchase is : ", total)
    def payment(self, amount):
        pass

class cash(food):
    def payment(self, amount):
        print("You have choosen to pay in cash, please insert {} into the machine.".format(amount))

obj = cash()
obj.receipt ("$150.02")
obj.payment ("$150.02")

