// ВИД 1
// НИЧЕГО НЕ ПРИНИМАЮТ,НИЧЕГО НЕ ВОЗВРАЩАЮТ

void Method1 ()
{
    Console.WriteLine("Автор - БАГАМАЕВ САМИР САЙГИДОВИЧ");
}
Method1();    



//---------------------------------------------------------



// ВИД 2
// ЧТО-ТО ПРИНИМАЮТ,НИЧЕГО НЕ ВОЗВРАЩАЮТ

// string msg - какое-то количество аргументов

void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");      



void Method21(string msg, int count) // метод21 это метод2.1(2 версия 2 метода)
{
    int i = 0;
    while ( i < count)
    {
       Console.WriteLine(msg); 
       i++;
    }
}
Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "НОВЫЙ текст");



//---------------------------------------------------------


// ВИД 3
// НИЧЕГО НЕ ПРИНИМАЮТ, ЧТО-ТО ВОЗВРАЩАЮТ

// если метод что-то возвращает, то должен быть int

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); 



//---------------------------------------------------------



// ВИД 4
// ЧТО-ТО ПРИНИМАЮТ, ЧТО-ТО ВОЗВРАЩАЮТ

string Method4(int count, string text)
{
   int i = 0;
   string result = String.Empty;

    while (i <  count)
   {
    result = result + text;
    i++;
    }
   return result;
}



// для цикла for
string Method4(int count, string text)
{
   
   string result = String.Empty;
   for( int i = 0; i < count; i++ )   
   { 
    result = result + text;
   }
   return result;
}

string result = Method4(10, "z");
Console.WriteLine(result); 



for (int i = 2;i <= 10; i++ ) //таблица умножения
{
    for (int j = 2;j <= 10;j++)
   {
      Console.WriteLine($"{i} x {j} = {i * j}");
   }
   Console.WriteLine();
}    




// РАБОТА С ТЕКСТОМ

// Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.
//Ясна ли задача? 

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого "
+ "Винценгероде, вы бы взяли приступом согласие"
+ "прусского короля. Вы так красноречивы. Вы"
+ "дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3]  // r

// String.Empty - пустая строка
// конктретный символ - char oldValue _newValue старый и новый
string Replace(string text, char oldValue, char newValue )
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|'); // пробелы заменили чёрточками
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText); 




//Упорядочить массив 
int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// подзадача
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


// метод , который будет упорядочевать наш массив
void SelectionSort(int[] array)
{
   for (int i = 0; i < array.Length - 1 ; i++)
   {
      int MinPosition = i;
      for (int j = i + 1; j < array.Length; j++)
      {
        if(array[j] < array[MinPosition]) MinPosition = j;
      }
      // temporary = присвоить 
      int temporary = array[i];
      array[i] = array[MinPosition];
      array[MinPosition] = temporary;
   }
}

PrintArray(arr);
SelectionSort(arr);


PrintArray(arr);