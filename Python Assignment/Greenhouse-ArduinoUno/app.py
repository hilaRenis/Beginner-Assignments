from flask import Flask
from CustomPymata4 import *
from time import sleep
from datetime import datetime
from flask import render_template
board = CustomPymata4(com_port="COM4", baud_rate=57600)

#show temperature function
def show_Temp():
    board.set_pin_mode_dht(12, sensor_type=11)
    board.set_pin_mode_analog_input(2)
    data = board.dht_read(12)

    temperature = data[0]
    board.displayShow(temperature)
    return temperature

#Show humidity function
def show_Hum():
     board.set_pin_mode_dht(12, sensor_type=11)
     board.set_pin_mode_analog_input(2)
     data = board.dht_read(12)
     humidity = data[1]
     board.displayShow(humidity)
     return humidity
     
#show light function
def show_light():
    board.set_pin_mode_dht(12, sensor_type=11)
    board.set_pin_mode_analog_input(2)

    # read the sensor value and timestamp that are returned  
    sensorValue, timeStamp = board.analog_read(2)     

    #convert to resistance in Kohms         
    resistanceSensor = (1023-sensorValue)*10/sensorValue

    #convert the resitance to Lux
    klux = 325 * pow(resistanceSensor, -1.4) / 1000

    #display on Arduino
    board.displayShow(klux)
    return round(klux,2)

app = Flask(__name__)

@app.route('/')
@app.route('/index')

def index():
    name = 'DAVE'
    now = datetime.now() # current date and time
    date_time = now.strftime("%B/%d/%Y, %H:%M:%S")

    temperature = show_Temp()
    humidity = show_Hum()
    brightness = show_light()

    return render_template('index.html', title='Welcome To My Greenhouse', username=name, nowDateTime = date_time, nowTemperature = temperature, nowHumidity = humidity, nowBrightness = brightness)  




