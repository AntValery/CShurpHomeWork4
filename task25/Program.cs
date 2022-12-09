//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine());
int pow = a;

for(int i = 1; i < b; i++){
    pow *= a;
}

Console.WriteLine(pow);