h = int(input("hours: "))
m = int(input("minutes: "))
s = int(input("seconds: "))
if (11>=h>=0)and(59>=m>=0)and(59>=s>=0):
    gr=(h+m/60+s/3600)*30
    print(gr)
else:
    print("Net, smotri uslovie")
