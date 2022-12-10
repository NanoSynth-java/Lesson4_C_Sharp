// //Первая група методов (ничего не возвращает и не принимает)
// void Method1() 
// {
//     Console.WriteLine("Автор ...");
// }

// Method1();

// //Вторая група методов (ничего не возвращает но принимает)

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Тут должен быть текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21(msg:"TEXT", count: 3);

// //Третья група методов (возвращают но ничего не принимают)

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// //Четвёртая группа методов (которые что то принимают и что то возвращают)

// string Method4(int count, string text)
// {
//     int j = 0;
//     string result = String.Empty;
//     while (j < count)
//     {
//         result = result + text;
//         j++;
//     }
//     return result;
// }

// string res = Method4(10, "New text line ");
// Console.WriteLine(res);


// Задача 1 Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить болишими "К"
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "abcdef"
//             0123
// s[3] // d

string replaceText(string text, char oldStr, char newStr)
{
    string result = string.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
    if (text[i] == oldStr) {
    result = result + newStr;
    }
    else result = result + text[i];
    }
    return result;
 }
 
string newString = replaceText(text, ' ', '_');
Console.WriteLine(newString);

int [] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void printArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {

        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

printArray(array);
selectionSort(array);
printArray(array);