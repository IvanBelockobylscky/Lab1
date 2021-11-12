print("Uslovie: o=a1*b2*c3 +b1*c2*a3+c1*a2*b3-a3*b2*c1-b3*c2*a1-c3*a2*b1, o!=0")
a1=float(input("Vvedite a1:"))
a2=float(input("Vvedite a2:"))
a3=float(input("Vvedite a3:"))
b1=float(input("Vvedite b1:"))
b2=float(input("Vvedite b2:"))
b3=float(input("Vvedite b3:"))
c1=float(input("Vvedite c1:"))
c2=float(input("Vvedite c2:"))
c3=float(input("Vvedite c3:"))
d1=float(input("Vvedite d1:"))
d2=float(input("Vvedite d2:"))
d3=float(input("Vvedite d3:"))
o=a1*b2*c3 +b1*c2*a3+c1*a2*b3-a3*b2*c1-b3*c2*a1-c3*a2*b1
if o!=0:
    o1=d1*b2*c3+b1*c2*d3+c1*d2*b3-d3*b2*c1-b3*c2*d1-c3*d2*b1
    o2=a1*d2*c3+d1*c2*a3+c1*a2*d3-a3*d2*c1-d3*c2*a1-c3*a2*d1
    o3=a1*b2*d3+b1*d2*a3+d1*a2*b3-a3*b2*d1-b3*d2*a1-d3*a2*b1
    x=o1/o
    y=o2/o
    z=o3/o
    print("x=",x,"y=",y,"z=",z)
else:
    print("Nepravil’no, ne vpisiyvaetsya v ramki zadachi.")
