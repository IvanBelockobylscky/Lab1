import math
print("uslovie: b,a>0")
a=float(input("Vvedite pervyiy katet:"))
b=float(input("Vvedite vtoroyiy katet:"))
if(a>0)and(b>0):
    g=math.sqrt(a**2+b**2)
    Pr=a+b+g
    Pl=a*b*0.5
    print("Perimetr:",Pr, "Ploschad':",Pl)
else:
    print("Oshibka.Smotri uslovie")
