//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

void Palindrom(int x)
{
        if (x > 9999 && x <= 99999)
        {
            string y = Convert.ToString(x);
            int firstint =int.Parse(y[0].ToString());
            int lastint =int.Parse(y[4].ToString());
            int secint =int.Parse(y[1].ToString());
            int preint =int.Parse(y[3].ToString());
            if (firstint == lastint && secint == preint)
                {
                    Console.WriteLine($"Введенное число {x} является палиндромом");
                }
            else
                {
                    Console.WriteLine($"Введенное число {x} не является палиндромом");
                }      
        }
        else
        {
        Console.WriteLine("Введенное число не 5-ти значное");
        }
}


Console.WriteLine("Введите 5-ти значное число: " );
int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Palindrom(x);



