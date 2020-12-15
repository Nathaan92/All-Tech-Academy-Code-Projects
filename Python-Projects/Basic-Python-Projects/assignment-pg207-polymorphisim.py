# Create two classes that inherit from another class.
#
# 1. Each child should have at least two of their own attributes.
#
# 2. The parent class should have at least one method (function).
#
# 3. Both child classes should utilize polymorphism on the parent class method.



# Multiple Authentication Methods
# Primary Class User

class User:
    name = 'Nate'
    email ='Nate@gmail.com'
    password = '1235'

    def getLoginInfo(self):
        entry_name = input("Enter your name: ")
        entry_email = input("Enter your email: ")
        entry_password = input("Enter your password: ")
        if(entry_email == self.email and entry_password == self.password):
            return("Welcome back, {}!".format(entry_name))
        else:
            return("The password or email is inccorect.")
  

#Child Class Manager
            
class Manager(User):
    store_number = '1234'
    manager_number = '1234'
    pin_number = '1234'

    
    def getLoginInfo(self):
        entry_name = input("Enter your name: ")
        entry_email = input("Enter your email: ")
        entry_password = input("Enter your password: ")

        if(entry_email == self.email and entry_password == self.password):
            print("Welcome back, {}. Please complete secondary authentication".format(entry_name))
            entry_manager_number = input("Enter your managers number: ")
            entry_pin_number = input("Enter your pin number: ")
            if(entry_manager_number == Manager.manager_number and entry_pin_number == Manager.pin_number):
                return("You have been authorized.")
            else:
                return("Your information is incorrect. You are not authorized for this webpage.")
        else:
            return("The password or email is inccorect.")


#Chid Class Customer
            
class Customer(User):
    user_name = 'Nathaan'
    shipping_address = '12345 ABC Rd Sky City NY, 12345'
    phone_number = '12345678910'
    card_on_file = "N/A"

    def getLoginInfo(self):
        entry_user_name = input("Enter your User name: ")
        entry_email = input("Enter your email: ")
        entry_password = input("Enter your password: ")
        if(entry_user_name == Customer.user_name and entry_email == Customer.email and entry_password == Customer.password):
            return("Welcome back, {}!".format(entry_user_name))
        else:
            return("The password or email is inccorect.")
        

if __name__ == "__main__":
    query = input("Welcome! Are you a Manager or Customer: ")
    if query == "Manager":
        manager = Manager()
        print(Manager.getLoginInfo(User))
    if query == "Customer":
        customer = Customer()
        print(Customer.getLoginInfo(User))
    else:
        print("Invaild Entry.")
   
