bool IsPolindrome(int num)
{
    int temp = num ; 
    int reverb = 0 ; 
    while(num > 0)
    {
        int grab = num % 10;
        reverb = reverb * 10 + grab ; 
        num = num / 10 ;
    }
    if(temp == reverb) return true ; 
    else return false ; 
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(IsPolindrome(number))
    Console.WriteLine($"Число {number} полиндром");
else 
    Console.WriteLine($"Число {number} не полиндром");
