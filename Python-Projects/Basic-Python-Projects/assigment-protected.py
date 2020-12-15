# Create a protected class

class protected:
    def __init__(self):
        self._protectedVar =123
        self.__privateVar =321
    def private(self):
        return(self.__privateVar)
obj = protected()
obj.private()
print ("Protected Var: ", obj._protectedVar, "\nPrivate Var: ", obj.private())
        
