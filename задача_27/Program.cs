int SumInNum ()
{
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
// int A = num%100;
// int B = A/10;
// int C = (num - A)/100;
// int D = num%10;

while (num >0)
{
    result = result + num%10;
    num = num/10;

}
return result;
}
Console.WriteLine (SumInNum ());


