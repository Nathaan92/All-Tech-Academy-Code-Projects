# Create two classes that inherit from another class.
#
# Each child should have at least two of their own attributes.

class vehicle:
    direction_control = ' '
    acceleration_control = ' '
    transportation_medium = ' '
    fuel = ' '
    number_of_passengers = ' '
    color = ' '
    name = ' '
    powerplant = ' '

class surface_transportation(vehicle):
    number_of_doors = ' '
    number_of_wheels = ' '
    towing_capacity = ' '
    bed_capacity = ' '
    
class air_transportation(vehicle):
    lift_mechanism = ' '
    counterbalance_mechanism = ' '
    medium_for_landing = ' '
    max_weight = ' '
    flight_range = ' '
