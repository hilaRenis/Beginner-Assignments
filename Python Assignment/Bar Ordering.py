alchol_drink = ['Beer','Coctail','Tequila','Vodka','Wine']
non_alchol_drink = ['Coke','Fanta','Water','Red Bull','Monster']

print('Welcome in our bar dear customer!')
drink = input('Please put what kind of drink would you like to order: ')
age = int(input('Please put you age here: '))

if drink in alchol_drink and age >= 18:
    print('Your order is taken! It will arrive shortly.')
elif drink in non_alchol_drink and age >= 18:
    print('Your order is taken! It will arrive shortly.')
elif drink in alchol_drink and age < 18:
    print('Sorry but you are not in the age where you can drink alcohol.')
else:
    print('Your order is taken! It will arrive shortly.')

