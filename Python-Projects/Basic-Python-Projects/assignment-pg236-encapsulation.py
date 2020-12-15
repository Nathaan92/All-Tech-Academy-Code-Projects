# Create a class that uses encapsulation.
#
# 1. This class should make use of a private attribute or function.
#
# 2. This class should make use of a protected attribute or function.
#
# 3. Create an object that makes use of protected and private.

class protected:
    def __init__(self):
        self._protectedVar =123
        self.__privateVar =321
    def private(self):
        return(self.__privateVar)
obj = protected()
obj.private()
print ("Protected Var: ", obj._protectedVar, "\nPrivate Var: ", obj.private())
        
