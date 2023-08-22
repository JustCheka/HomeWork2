Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine());

if (num < 100) Console.WriteLine("Третьей цифры нет ");
else if (num > 999) {
    while (num > 999) {
        num /= 10;
    }
    Console.WriteLine(num % 10);
}
else Console.WriteLine(num % 10);