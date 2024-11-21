


from cmath import pi


radius = input('Put the radius of the circle: ')

area = round(pi * int(radius) * int(radius))

circum = round(2 * pi * int(radius))

print('The area of the circle is ' + str(area) + ' and the circum of the circle is ' + str(circum))