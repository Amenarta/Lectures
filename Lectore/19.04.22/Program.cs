/*
// Метод вид№1:

void medhot1 ()
{
    Console.WriteLine("Автор Ирина М.");
}

medhot1 ();


// Метод вид№2:

void medhot2 (string ms)
{
    Console.WriteLine(ms);
}

medhot2 ("Текст сообщения: ");

void medhot20 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

medhot20(msg: "Текст сообщения: ", count: 3);

// Метод вид№3:

int medhot3()
{
    return DateTime.Now.Year;
}

int year = medhot3();
Console.WriteLine(year);

// Метод вид№4:

string medhot4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = medhot4(3, " повторяем, ");
Console.WriteLine(res);

string medhot4 (int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = medhot4(3, " повторяем, ");
Console.WriteLine(res);

//Цикл в цикле, например таблица умножения

for (int i = 2; i<= 10; i++)
{
    for (int j = 2; i<= 10; i++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

//---Работа с текстом.
// Дан текст. В тексте все пробелы заменить черточками, мал.буквы "к" заменить большими "К", а большие "С" заменить мал."с".

string text = "я думаю, - сказал князь, улыбаясь - что,"
            + "ежели бы Вас послали вместо нашего милого Винценгероде,"
            + "Вы бы взяли приступом согласие прусского короля.";

// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string test, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i<length; i++)
    {
        if (text [i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }    

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

//--Упорядочить массив
// Алгоритм сортировки методом выбора макс или миним

// 68321457 

int [] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int [] array)
{
    int count = array.Length;

    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]} " );
    }
    Console.WriteLine();
}

void SelectionSort (int [] array)
{
    for (int i = 0; i<array.Length -1; i++)
    {
        int minPossition = i;
        for (int j = i+1; j<array.Length ; j++)
        {
            if (array[j] < array[minPossition]) minPossition = j;
        }     
        int temporary = array [i];
        array [i] = array[minPossition];
        array[minPossition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/