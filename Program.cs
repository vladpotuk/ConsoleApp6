using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть довжину лінії: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть символ заповнювач: ");
        char fillChar = Convert.ToChar(Console.ReadLine());

        Console.Write("Введіть напрямок лінії (г - горизонтальна, в - вертикальна): ");
        char direction = Convert.ToChar(Console.ReadLine());

        
        if (direction == 'г')
        {
            
            for (int i = 0; i < length; i++)
            {
                Console.Write(fillChar);
            }
            Console.WriteLine(); 
        }
        else if (direction == 'в')
        {
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(fillChar);
            }
        }
        else
        {
            Console.WriteLine("Неправильно введений напрямок лінії.");
        }
    }
}

