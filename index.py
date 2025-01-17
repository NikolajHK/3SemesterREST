from sense_hat import SenseHat
from time import sleep
import time
from socket import socket 
from datatime import datatime
import random

sense = SenseHat()

colorlist = ["Pink","Crimson","Red", "Maroon","Brown","Misty Rose","Salmon","Coral", "Orange-Red","Chocolate","Orange","Gold","Ivory",
"Yellow","Olive","Yellow-Green","Lawn green","Chartreuse","Lime","Green","Spring green","Aquamarine","Turquoise","Azure","Aqua/Cyan",
"Teal","Lavender","Blue","Navy","Blue-Violet","Indigo","Dark Violet","Plum","Magenta","Purple","Red-Violet", 	 	 	 	 	 	 	 	 	 	 	 	 	 	 	 	 	 
"Tan","Beige","Slate gray","Dark Slate Gray","White", "White Smoke","Light Gray","Silver","Dark Gray","Gray","Dim Gray","Black"]
# denne list er hentet fra https://simple.wikipedia.org/wiki/List_of_colors

s = socket(AF_INET, SOCK_DGRAM)
BROADCAST_TO_PORT = 9999
s.setsockopt(SOL_SOCKET, SO_BROADCAST, 1)
TotalCountCar = 1
TotalParking = 0
sense.clear(0,255,0)
while True:
    randomcolor = random.choice(colorlist)
    ISin = 1
    messageToUDP = randomcolor + str(ISin)
    s.sendto(bytes(messageToUDP,"UTF-8"), ('<broadcast>', BROADCAST_TO_PORT))
    
    TotalCountCar + 1
    TotalParking + 1
    if TotalParking == 30:
        sense.clear(255,0,0)
    if TotalCountCar > 30:
        break
    
    print(messageToUDP)   
    sleep(5)   
