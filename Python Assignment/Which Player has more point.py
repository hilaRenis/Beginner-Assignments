name1 = input('Write your name: ')
score1 = input('Your score is: ')
name2 = input('Write your name: ')
score2 = input('Your score is: ')

if int(score1) > int(score2):
    print('The winer is ' + str(name1) + ' with the score ' + str(score1))
elif int(score1) < int(score2):
    print('The winer is ' + str(name2) + ' with the score ' + str(score2))
else:
    print('We have a draw!')