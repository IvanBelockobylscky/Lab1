a=int(input("Vvedite tryohznachnoe chislo:"))
if (999>=a>=100):
    c=a//100
    b=a%10
    a=a//10
    a=a%10
    reverse=(b*10+a)*10+c
    print(reverse)
else:
    print("Nepravil'no, nevpisyevaet'sa v ramki zadachi")
