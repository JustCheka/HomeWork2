Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());

if (num < 100 || num > 999) Console.WriteLine("Число не трехзначное");
else {
    int result = num /= 10;
    result %= 10;
    Console.WriteLine("Ответ " + result);
}