 maxMin();
 maxMinTh();
 evenNumber();
 evenNumberArray();

int maxMin(){
    Console.Write("Первое задание---> Введите первое число: ");
    int max = 0;
    int min = 0;
     int number = Convert.ToInt32(Console.ReadLine());
      Console.Write("Первое задание---> Введите второе число: ");
     int number1 = Convert.ToInt32(Console.ReadLine());
    
    if (number == number1){
        Console.WriteLine("Числа эквивалентны");
    }
     if (number < number1){
 max= number1;
 min = number;
        Console.WriteLine($"Максимальное число {max} минимальное {min}");
    }if (number > number1){
 max = number;
 min = number1;
Console.WriteLine($"Максимальное число {max} минимальное {min}");
    }
return  0;

}

int maxMinTh(){
 int max = 1;
   Console.Write("Второе задание---> Введите первое число: ");
   int a = Convert.ToInt32(Console.ReadLine());
   Console.Write("Второе задание---> Введите второе число: ");
   int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Второе задание---> Введите третье число: ");
   int r = Convert.ToInt32(Console.ReadLine());
   if(max<a){
     max = a;
    }

     if(max<b){
     max = b;
    }

     if(max<r){
     max = r;
    }

  Console.WriteLine($"Максимальное число {max}");
    return 0;
}


int evenNumber (){
    Console.WriteLine($"Третье задание---> Введите число: ");
   int number = Convert.ToInt32(Console.ReadLine());
   if (number % 2==0)
            {
                Console.WriteLine("число четное");
            }else
            Console.WriteLine("число не четное");
                return 0;
}

int evenNumberArray(){
    Console.Write("Четвертое задание---> Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
   
    for (int i = 1; i < number; i++)
{
     if (i % 2==0){
        Console.Write(i+" ");
     }
}
return 0;
}