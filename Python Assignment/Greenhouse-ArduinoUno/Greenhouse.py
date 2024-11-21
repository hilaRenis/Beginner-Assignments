import time
from flask import Flask, jsonify
from multiprocessing import Process, Value
from flask import render_template
from datetime import datetime
from CustomPymata4 import *
from time import sleep


board = CustomPymata4(baud_rate = 57600, com_port="COM3")

LED_RED = 4        
LED_GREEN = 5      
LED_BLUE = 6        
LED_YELLOW = 7     

def TurnOn(LED_PIN):
    board.set_pin_mode_digital_output(LED_PIN)
    board.digital_write(LED_PIN, 1)

def TurnOff(LED_PIN):
    board.set_pin_mode_digital_output(LED_PIN)
    board.digital_write(LED_PIN, 0)


def GetHumidity():
     board.set_pin_mode_dht(12, sensor_type=11)
     data = board.dht_read(12)
     humidity = data[1]
     board.displayShow(humidity)
     return humidity

def GetTemperature():
    board.set_pin_mode_dht(12, sensor_type=11)
    data = board.dht_read(12)
    temperature = data[0]
    board.displayShow(temperature)
    return temperature

def GetLight():
    board.set_pin_mode_analog_input(2)
    sensorValue, timeStamp = board.analog_read(2)                
    if sensorValue == 0:
        sensorValue = 1
    resistanceSensor = (1023-sensorValue)*10/sensorValue           
    klux = sensorValue                                             
    board.displayShow(klux)
    return round(klux,2)    



app = Flask(__name__)

@app.route('/')
@app.route('/index')
def index():

    now = datetime.now()
    time_now_is = now.strftime("%d/%m/%Y, %H:%M:%S")

    name = 4506626
    temp = GetHumidity()
    humid = GetTemperature()
    sun_light = GetLight() 

    if sun_light >= 300 and temp >= 21 and temp <= 26:
        TurnOn(LED_GREEN)
        TurnOn(LED_YELLOW)
        TurnOff(LED_BLUE)
        TurnOff(LED_RED)
    elif sun_light >= 300 and temp < 21:
        TurnOff(LED_GREEN)
        TurnOn(LED_YELLOW)
        TurnOff(LED_BLUE)
        TurnOn(LED_RED)
    elif sun_light >= 300 and temp > 26:
        TurnOff(LED_GREEN)
        TurnOn(LED_YELLOW)
        TurnOn(LED_BLUE)
        TurnOff(LED_RED)
    
    if sun_light >= 300 and humid >= 80 and humid <= 90:
        TurnOn(LED_GREEN)
        TurnOn(LED_YELLOW)
        TurnOff(LED_BLUE)
        TurnOff(LED_RED)
    elif sun_light >= 300 and humid < 80:
        TurnOff(LED_GREEN)
        TurnOn(LED_YELLOW)
        TurnOn(LED_BLUE)
        TurnOff(LED_RED)
    elif sun_light >= 300 and humid > 90:
        TurnOff(LED_GREEN)
        TurnOn(LED_YELLOW)
        TurnOn(LED_BLUE)
        TurnOn(LED_RED)

    if sun_light < 300 and temp >= 15.5 and temp <= 18:
        TurnOn(LED_GREEN)
        TurnOff(LED_YELLOW)
        TurnOff(LED_BLUE)
        TurnOff(LED_RED)
    elif sun_light < 300 and temp < 15.5:
        TurnOff(LED_GREEN)
        TurnOff(LED_YELLOW)
        TurnOff(LED_BLUE)
        TurnOn(LED_RED)
    elif sun_light < 300 and temp > 18:
        TurnOff(LED_GREEN)
        TurnOff(LED_YELLOW)
        TurnOff(LED_BLUE)
        TurnOn(LED_RED)

    if sun_light < 300 and humid >= 65 and humid <= 75:
        TurnOn(LED_GREEN)
        TurnOff(LED_YELLOW)
        TurnOff(LED_BLUE)
        TurnOff(LED_RED)
    elif sun_light < 300 and humid < 65:
        TurnOff(LED_GREEN)
        TurnOff(LED_YELLOW)
        TurnOn(LED_BLUE)
        TurnOff(LED_RED)
    elif sun_light < 300 and humid > 75:
        TurnOff(LED_GREEN)
        TurnOff(LED_YELLOW)
        TurnOn(LED_BLUE)
        TurnOff(LED_RED)

    return render_template('index.html', title = 'Welcome to Greenhouse App', username = name, 
     date = time_now_is, temperature = temp, humidity = humid, light = sun_light)



