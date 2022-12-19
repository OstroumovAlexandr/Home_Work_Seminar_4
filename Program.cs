/* Определение болльшго и меньшего из двух чисел


Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if(num2 > num1){
Console.WriteLine($"Из чисел {num1} {num2}: число {num2} большее, а число {num1}  меньшее.");
}
*/






/* Определение максимального числа из трех

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);

int max = num1;

if(num2 > max){
    max = num2;
    }
if(num3 > max){
        max = num3;
    }
Console.WriteLine($"Из чисел {num1} {num2} {num3} максимальным является число {max}!");
*/






/* Определение четности числа

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if( num % 2 == 0){
Console.Write($"Число {num}: ЧЕТНОЕ");
}
else{Console.Write($"Число {num}: НЕЧЕТНОЕ");}

*/







/* Выводит все четные числа от 1 до N

Console.Clear();
Console.WriteLine("Введи число ");
int num = int.Parse(Console.ReadLine()!);
int num1 = 1;
while (num1 <= num){
    if(num1 % 2 == 0){
    Console.Write($"{num1} ");}
num1 ++;    
}
*/
