import math
print("uslovie1:(x>-a);uslovie2:(x+a)>=0,(x+ math.sqrt(math.fabs(x-b)))>0")
a=float(input('a='))
b=float(input('b='))
x=float(input('x='))
c=float(input('c='))
znam=(x+math.sqrt(math.fabs(x-b)))
if(x>-a):
        f=(math.log(a+x**2))+(math.sin(x/b)**2)
        print(f)
else:
        print("Net,smotri uslovie. A poka - kak naschet partejki v Gwent?")
if((x+a)>=0)and(znam>0):
        z=math.exp(c*x)*(x+math.sqrt(x+a))/znam
        print(z)
else:
        print("Net,smotri uslovie vnimatel'nee, please.")
