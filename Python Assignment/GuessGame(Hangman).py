import random

print("Welcome to Guess Game")
print("-------------------------------------------")

wordlist = ["sunflower", "house", "diamond", "memes","school","hello", "football"]




def checkletter(verifyletter):
  for rightletter in randomWord:
    if(rightletter==verifyletter):
      return True
  return False

def print_guess_game(wrong):
  if(wrong == 0):
    print("")
    
  elif(wrong == 1): 
    print("💔")
    
  elif(wrong == 2):
    print("💔", "💔")
    
  elif(wrong == 3):
    print("💔", "💔", "💔")
    
  elif(wrong == 4):
    print("💔", "💔", "💔", "💔")
    
  elif(wrong == 5):
    print("💔", "💔", "💔", "💔", "💔")


def printWord(guessedLetters):
  counter=0
  rightLetters=0
  for char in randomWord:
    if (counter==0):
      print(randomWord[counter], end=" ")
      rightLetters+=1
    elif(counter==len(randomWord)-1):
      print(randomWord[counter], end=" ")
      rightLetters+=1
    elif(char in guessedLetters):
      print(randomWord[counter], end=" ")
      rightLetters+=1
    else:
      print(" ", end=" ")
    counter+=1
  return rightLetters

def printLines():
  print("\r")
  for char in randomWord:
    print("\u203E", end=" ")

def checkletterguess(verifyguess):
  if verifyguess:
    return True


while True:

    randomWord = random.choice(wordlist)

    wordlist.remove(randomWord)


    for element in range(0, len(randomWord)):
        if element == 0:
            print(randomWord[element], end=" ")
        elif element == len(randomWord)-1:
            print(randomWord[element], end=" ")
        else:
            print("_", end=" ")



    length_of_word_to_guess = len(randomWord)
    amount_of_times_wrong = 0
    current_guess_index = 0
    current_letters_guessed = []
    current_letters_right = 0



    while(amount_of_times_wrong != 5 and current_letters_right != length_of_word_to_guess):
        print("\nLetters guessed so far: ")
        for letter in current_letters_guessed:
            print(letter, end=" ")
  
        while True:
          letterGuessed = input("\nGuess a letter: ")

          if letterGuessed in current_letters_guessed:
            print("\nYou have already guessed letter: ", letterGuessed)
            print_guess_game(amount_of_times_wrong)
            current_letters_right = printWord(current_letters_guessed)
            printLines()
            print("\nLetters guessed so far: ")
            for letter in current_letters_guessed:
              print(letter, end=" ")
          else:
            break
  
        if(checkletter(letterGuessed)):
            print_guess_game(amount_of_times_wrong)
            current_letters_guessed.append(letterGuessed)
            current_letters_right = printWord(current_letters_guessed)
            printLines()
  
        else:
            amount_of_times_wrong+=1
            current_letters_guessed.append(letterGuessed)
            print_guess_game(amount_of_times_wrong)
            current_letters_right = printWord(current_letters_guessed)
            printLines()

  
    if amount_of_times_wrong == 5:
        print("You Lost!")
        print("The right word is: ", randomWord)

    print("Game is over! Thank you for playing :)")


    while True:
        userresponse = input("Do you want to play again: ").lower()

        if(userresponse == "no" or userresponse == "yes"):
            break
        else:
            print("Please enter 'yes' or 'no'!")


    if userresponse == "no":
        print("Thank you for playing HangMan :)")
        break
    elif userresponse == "yes":
        if len(wordlist)==0:
            print("You have guessed all words in the word list, there are no more word to guess!")
            print("Thank you for playing HangMan :)")
            break
