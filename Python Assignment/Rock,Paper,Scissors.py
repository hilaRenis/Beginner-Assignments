import random

print('Welcome to Rock-Paper-Scissors Game!')

while True:

 valid_choose = ['rock', 'paper', 'scissors']


 cpu = random.choice(valid_choose)
 player = input('\nWhat do you choose?: ').lower()
 
 while player not in valid_choose:
  player = input('\nPlease put rock, paper or scissors: ').lower()


 def winningCondition(player_hand, cpu_hand):
     
    if player_hand == 'rock' and cpu_hand == 'scissors':
        print('player: ' + player_hand)
        print('computer: ' + cpu_hand)
        print('\nPlayer has won!')
    elif player_hand == 'rock' and cpu_hand == 'paper':
        print('player: ' + player_hand)
        print('computer: ' + cpu_hand)
        print('\nComputer has won!')
    elif player_hand == 'paper' and cpu_hand == 'rock':
        print('player: ' + player_hand)
        print('computer: ' + cpu_hand)
        print('\nPlayer has won!')
    elif player_hand == 'paper' and cpu_hand == 'scissors':
        print('player: ' + player_hand)
        print('computer: ' + cpu_hand)
        print('Computer has won!')
    elif player_hand == 'scissors' and cpu_hand == 'paper':
        print('player: ' + player_hand)
        print('computer: ' + cpu_hand)
        print('\nPlayer has won!')
    elif player_hand == 'scissors' and cpu_hand == 'rock':
        print('player: ' + player_hand)
        print('computer: ' + cpu_hand)
        print('\nComputer has won!')
    else:
        print('player: ' + player_hand)
        print('computer: ' + cpu_hand)
        print('\nIt is a tie!')

 winningCondition(player,cpu)

 player_response = input('\nDo you desire to play again? (yes/no): ').lower()
 
 while True:
  if player_response == 'no' or  player_response == 'yes':
     break
  else:
     print('Please write yes or no')

 if player_response == 'no':
     break


print('\nThank you for playing! Until next time!')

 


