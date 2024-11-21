
def sum(x, y):
    return x + y

def minus(x, y):
    return x - y

def multiply(x, y):
    return x * y

def divide(x, y):
    return x / y

while True:
 number1 = int(input('Put the first number: '))
 number2 = int(input('Put the second number: '))
 arithmetic_operator = input('Put the operator you want: ')
 
 if arithmetic_operator == '+':
    result = sum(number1, number2)
    print('The result is ' + str(result))
 elif arithmetic_operator == '-':
    result = minus(number1, number2)
    print('The result is ' + str(result))
 elif arithmetic_operator == '*':
    result = multiply(number1, number2)
    print('The result is ' + str(result))
 elif arithmetic_operator == '/':
    result = divide(number1, number2)
    print('The result is ' + str(result))
 else:
    print('Error')
    break

print('Thank you for using my calculator')