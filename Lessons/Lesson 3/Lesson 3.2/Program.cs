// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//найти расстояние между любыми двумя точками в 3D-пространстве, которое равно:√ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2.


System.Console.Write("Введите Х координату точки А = ");
int aX = int.Parse(Console.ReadLine());
System.Console.Write("Введите Y координату точки A = ");
int aY = int.Parse(Console.ReadLine());
System.Console.Write("Введите Z координату точки А = ");
int aZ = int.Parse(Console.ReadLine());
System.Console.Write("Введите Х координату точки B = ");
int bX = int.Parse(Console.ReadLine());
System.Console.Write("Введите Y координату точки B = ");
int bY = int.Parse(Console.ReadLine());
System.Console.Write("Введите Z координату точки B = ");
int bZ = int.Parse(Console.ReadLine());

System.Console.WriteLine(Math.Sqrt(bX - aX));

System.Console.WriteLine("Расстояние между двумя точками в 3D пространстве равно = " +
    (Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2) + Math.Pow((bZ - aZ), 2)))
);