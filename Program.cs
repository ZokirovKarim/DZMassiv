using System;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
           // Максимальное 

 
             Console.WriteLine("Введите число:"); 
             int number = int.Parse(Console.ReadLine()); 
             int [] arr = new int[number]; 
             for(int i = 0;i<number;i++) 
             { 
                 Console.WriteLine($"Введите {i+1}:"); 
                 arr[i] = int.Parse(Console.ReadLine()); 
             } 
             foreach (var z in arr) 
             { 
                 Console.Write(z+" "); 
             } 
                Console.WriteLine(); 
             int max = arr[0]; 
             for(int i=0; i < arr.Length; i++){ 
                 if(max < arr[i]){ 
                     max = arr[i]; 
                 } 
             } 
             Console.WriteLine($"Максимальное число = {max}"); 
              
         
 
 
             /// минимальное
 
 
             Console.WriteLine("Введите число :"); 
             int number = int.Parse(Console.ReadLine()); 
             int [] arr = new int[number]; 
             for(int i = 0;i<number;i++) 
             { 
                 Console.WriteLine($"Введите число {i+1} :"); 
                 arr[i] = int.Parse(Console.ReadLine()); 
             } 
             foreach (var z in arr) 
             { 
                 Console.Write(z+" "); 
             } 
             int min = arr[0]; 
             for(int i=0; i < arr.Length; i++){ 
                 if(min > arr[i]){ 
                     min = arr[i]; 
                 } 
             } 
             Console.WriteLine($"Минимальное = {min}"); 
 

            
 
            // Общую сумму всех элементов 
 
 
              Console.WriteLine("Введите число:"); 
             int number = int.Parse(Console.ReadLine()); 
             int sum=0; 
             int [] arr = new int[number]; 
             for(int i = 0;i<number;i++) 
             { 
                 Console.WriteLine($"Введите число {i+1}:"); 
                 arr[i] = int.Parse(Console.ReadLine()); 
             } 
             foreach (var z in arr) 
             { 
                 Console.Write(z+" "); 
             } 
             for(int i=0; i < arr.Length; i++){ 
                  
                 sum = sum + arr[i]; 
             } 
             Console.WriteLine($"Сумма = {sum}"); 
 
 
            // Среднее арифметическое всех элементов
             
            
 
 
             Console.WriteLine("Введите число:"); 
             int number = int.Parse(Console.ReadLine()); 
             int sum=0; 
             int arifValue = 0; 
             int [] arr = new int[number]; 
             for(int i = 0;i<number;i++) 
           { 
                 Console.WriteLine($"Введите {i+1}:"); 
                 arr[i] = int.Parse(Console.ReadLine()); 
             } 
             foreach (var z in arr) 
             { 
                 Console.Write(z+" "); 
             } 
             for(int i=0; i < arr.Length; i++){ 
                  
                 sum = sum + arr[i]; 
                 arifValue = sum/arr.Length; 
             } 
             Console.WriteLine($"Среднее число = {arifValue}"); 
 
 
            
 
 
           // Вывести все нечетные значения
 
 
              Console.WriteLine("Введите число :"); 
             int number = int.Parse(Console.ReadLine()); 
             int n=0; 
              
             int [] arr = new int[number]; 
              for(int i = 0;i<number;i++) 
             { 
                 Console.WriteLine($"Введите число{i+1}:"); 
                 arr[i] = int.Parse(Console.ReadLine()); 
             } 
             foreach (var z in arr) 
             { 
                 Console.Write(z+" "); 
             } 
             for(int i=0; i < arr.Length; i++){ 
                  
                 if(arr[i] % 2 != 0){ 
                     n = arr[i]; 
                     Console.WriteLine($"не чотные = {n}"); 
                 } 
             } 
              
 
 
           // задача 3 
 
 
             int [] arr =  new int [] {2,3,4,5,6}; 
          
             for(int i = arr.Length - 1; i >=0; i-- ){ 
               Console.WriteLine(arr[i]); 
             } 
              
         // Задача 4 
 
 
 
 
             Console.Write("Write length of array:"); 
             int num = int.Parse(Console.ReadLine()); 
             int[] array = new int[num]; 
             for (int i = 0; i < num; i++) 
             { 
                 int Random = new Random().Next(1, 100); 
                 array[i] = Random; 
             } 
             foreach (var item in array) 
             { 
                 Console.WriteLine(item); 
             } 
             Console.Write("index:"); 
             int index = int.Parse(Console.ReadLine()); 
             Console.Write("count:"); 
             int count = int.Parse(Console.ReadLine()); 
             int[] array2 = new int[count]; 
             int count2 = 0; 
 
 
             for (int i = index; i < count + index; i++) 
             { 
                 if (i <= array.Length-1) 
                 { 
                     array2[count2] = array[i]; 
                     count2++; 
                 } 
                 else 
                 { 
                     array2[count2] = 1; 
                 } 
             } 
             foreach (var item in array2) 
             { 
                 System.Console.WriteLine(item); 
             } 




        }
    }
}
