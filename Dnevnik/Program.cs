Console.WriteLine("Выбрана дата 01.10.2023");
ConsoleKeyInfo txt = Console.ReadKey();
string[,] dela = new string[5, 2] { { "Купить хлеб", "Выпить кофе" }, { "Получить пятерку", "Забрать сестру" }, { "Купить бургер", "Встретиться с подругой" }, { "Помочь отцу", "Сходить в кино" }, { "Получить справку", "Сдать кровь" } };
do
{
    if (txt.Key == ConsoleKey.RightArrow)
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine("                                        ");
        Console.WriteLine("                                        ");
        Console.WriteLine("                                        ");
        Console.WriteLine("                                        ");
        Console.WriteLine("                                        ");
        Console.WriteLine("                                        ");
        Console.WriteLine("                                        ");
        Console.WriteLine("                                        ");
        Console.SetCursorPosition(0, 1);
        int chislo = Dat(1);
        Inf(chislo);
        int posit = Strelka(1);
        Console.SetCursorPosition(0, 4);
        Console.Write("Дата создания заметки: 0");
        Console.Write(chislo);
        Console.WriteLine(".10.2023");
        Console.Write("Описание заметки: ");
        Console.WriteLine(dela[chislo - 1, posit - 1]);
        Console.Write("Срок выполнения: ");
        Console.Write(chislo);
        Console.WriteLine(" ч.");
        Console.WriteLine("Для завершения - кнопка Enter");
    }
    txt = Console.ReadKey();
}
while (txt.Key != ConsoleKey.Enter);

static int Dat(int chislo)
{
    ConsoleKeyInfo tt = Console.ReadKey();
    do
    {
        if (tt.Key == ConsoleKey.LeftArrow)
        {
            Console.SetCursorPosition(14, 0);
            chislo = chislo - 1;
            if (chislo == 0)
            {
                chislo = 1;
            }
            Console.WriteLine(chislo);
            Console.WriteLine("                    ");
            Console.WriteLine("                    ");
            Console.SetCursorPosition(0, 1);
        }
        else if (tt.Key == ConsoleKey.RightArrow)
        {
            Console.SetCursorPosition(14, 0);
            chislo = chislo + 1;
            if (chislo == 10)
            {
                chislo = 9;
            }
            Console.WriteLine(chislo);
            Console.WriteLine("                    ");
            Console.WriteLine("                    ");
            Console.SetCursorPosition(0, 1);
        }
        tt = Console.ReadKey();
    }
    while (tt.Key != ConsoleKey.Enter);
    return chislo;
}

static void Inf(int data)
{
    switch (data)
    {
        case 1:
            {

                Console.SetCursorPosition(2, 1);
                Console.WriteLine("1. В магазин");
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("2. В кафе");
                break;
            }
        case 2:
            {
                Console.SetCursorPosition(2, 1);
                Console.WriteLine("1. В теху");
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("2. В школу");
                break;
            }
        case 3:
            {
                Console.SetCursorPosition(2, 1);
                Console.WriteLine("1. В макдак");
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("2. В KFC");
                break;
            }
        case 4:
            {
                Console.SetCursorPosition(2, 1);
                Console.WriteLine("1. В гараж");
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("2. В ТЦ");
                break;
            }
        case 5:
            {
                Console.SetCursorPosition(2, 1);
                Console.WriteLine("1. В банк");
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("2. В больницу");
                break;
            }
    }
    Console.SetCursorPosition(0, 1);
}
static int Strelka(int posit)
{
    Console.SetCursorPosition(0, 1);
    Console.Write("->");
    ConsoleKeyInfo key = Console.ReadKey();
    while (key.Key != ConsoleKey.Enter)
    {
        Console.SetCursorPosition(0, posit);
        Console.Write("  ");
        if (key.Key == ConsoleKey.UpArrow)
        {
            posit--;
            if (posit == 0)
            {
                posit = 2;
            }
        }
        else if (key.Key == ConsoleKey.DownArrow)
        {
            posit++;
            if (posit == 3)
            {
                posit = 1;
            }
        }
        Console.SetCursorPosition(0, posit);
        Console.Write("->");
        key = Console.ReadKey();
    }
    return posit;
}