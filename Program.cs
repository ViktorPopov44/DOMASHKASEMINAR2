
int num, rem, sum = 0, temp;
        Console.Write("Введите пятизначное число: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (Convert.ToBoolean(num))
        {
            rem = num % 10; 
            num = num / 10; 
            sum = sum * 10 + rem; 
          
        }
        Console.WriteLine(sum);
        if (temp == sum) 
        {
            Console.WriteLine("Это полинорм");
        }
        else
        {
            Console.WriteLine("Это не полинорм");
        }
        Console.ReadLine();