
Console.WriteLine("Введите цифру, обозначающую день недели");

int n =int.Parse(Console.ReadLine());

if (n==6 || n==7){
    Console.WriteLine("Да, выходной");

}
else if (n>0 && n<=5) {

    Console.WriteLine("Нет, рабочий день");

}
else {
    Console.WriteLine("В неделе 7 дней");
}