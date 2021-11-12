a=int(input("Vvedite chetyirehznachnoe chislo: "))
if (9999>=a>=1000):
    b=a//1000
    c=(a%1000)//100
    d=(a%1000%100)//10
    e=a%1000%100%10
    P=b*c*d*e
    print(P)
else:
    print("Nepravil'no, nevpisyevaet'sa v ramki zadachi")
     

