# For context, she said once we were done with the Number Guess thing. We had to make a program to get 2 dice rolls and print them
# This is what I did, literally easiest thing I've ever done

import random
print("You rolled a", random.randint(1, 6), "and a", random.randint(1, 6)) # literally no logic, just calling a function twice then printing it


# OKAY AS OF2/14/23 SHE TOLD US TO DO THIS, I'M GOING KEEP UPDATING THIS AS WE GO
import random

# WHY
two = 0
three = 0
four = 0
five = 0
six = 0
seven = 0
eight = 0
nine = 0
ten = 0
eleven = 0
twelve = 0

rolls = []  # All of the rolls made
rollMade = []

# The whole reason this is a thing we are doing is to showcase how number distribution works.
# She told us to do two different ways 100x then 1000x ((1, 6) + (1, 6) and (2, 12))
# bruh
for i in range(1000):  # Loop 1000 times
  # Make 2 fake rolls
  rollMade = [random.randint(2, 12)]
  # rollmade = [random.randint(1, 6) + random.randint(1, 6)]
  rolls += rollMade

  # this hurts
  if rollMade[0] == 2:
    two += 1
  elif rollMade[0] == 3:
    three += 1
  elif rollMade[0] == 4:
    four += 1
  elif rollMade[0] == 5:
    five += 1
  elif rollMade[0] == 6:
    six += 1
  elif rollMade[0] == 7:
    seven += 1
  elif rollMade[0] == 8:
    eight += 1
  elif rollMade[0] == 9:
    nine += 1
  elif rollMade[0] == 10:
    ten += 1
  elif rollMade[0] == 11:
    eleven += 1
  elif rollMade[0] == 12:
    twelve += 1

  rollMade = []
print("All of the rolls you made are", rolls, "\n")
# teacher didn't tell use to use f strings they told us to do what was above
print(f"Two's: {two}\nThree's: {three}\nFour's: {four}\nFive's: {five}\nSix's: {six}\nSeven's: {seven}\nEight's: {eight}\nNine's: {nine}\nTen's: {ten}\nEleven's: {eleven}\nTwelves's: {twelve}")

# WHAT THE HELL IS THIS
