Console.WriteLine("Напишите цифру от 1 до 7");
int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 7) Console.WriteLine("Something went wrong");
else {
    switch (num) {
        case 6:
            Console.WriteLine("Да");
            break;
        case 7:
            Console.WriteLine("Да");
            break;
        default:
            Console.WriteLine("Нет");
            break;
    }
}