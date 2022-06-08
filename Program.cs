
        // Напишите программу, которая принимает на
        //вход три числа и выдаёт максимальное из этих чисел.
        int a = 44;
        int b = 5;
        int c = 78;
        int max = a;
        int min = a;
        if (b > max) max = b;
        if (c > max) max = c;
        if (b < min) min = b;
        if (c < min) min = c;
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
    