Console.WriteLine("Введите 3 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if ((num1>num2)&&(num1>num3)){
    max = num1 ;
}
else if ((num2>num1)&&(num2>num3)){
    max = num2 ;
}
else if ((num3>num1)&&(num3>num2)){
    max = num3 ;}
Console.WriteLine(max);
Console.WriteLine();