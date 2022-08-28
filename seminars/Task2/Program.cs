
Console.Clear();

Console.Write (" Введите число от 0 до 99999: ");

int n =  int.Parse(Console.ReadLine());

if(n>0 && n<100)
{
   Console.WriteLine("Третьей цифры нет");
}

else if (n>=100 && n<1000)
{
   int n2= n %10;
   Console.WriteLine(n2);
}
else  if (n>=1000 && n<10000)
{ int n2   =   n/ 10 ;

int f  = n2%10;

   Console.WriteLine(f);

}
else if (n>=10000 && n<100000)
     { int n7   =   n/ 100 ;


int f0 = n7%10;

   Console.WriteLine(f0);
   }

 else
 {Console.WriteLine(" Веедите другое число, отвечающее условиям ");
    
}
/*
Console.Clear();

Console.WriteLine("Введите число ");

int n = int.Parse(Console.ReadLine());

if (n < 100){
    Console.WriteLine($"Третьей цифры нет");

    return ;
}
int numberLength = n.ToString().Length;

int divider =1;
 for (int i =3 ; i < numberLength; i++){
    divider *=10;
 }
 int num = (n / divider);
 Console.WriteLine($"Третья цифра  числа {n} -> { num %10}");

 */