// Вид 1 Метод ничегг не возвращают и ничео не принимают
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }   
// Method1();

//Вид2 Метод ничего не возвращает, но могут принимать каки-то аргументы
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообшения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; // увеличение счетчика на 1 (i++) наз инкриментом, уменьшение на 1 (i--) - декриментом
//         // ctr + C - позволяет исправить зацикливаноие программы
//     }
// }
// Method21("Текст", 4);
// Method21(msg: "Текст", c/ount: 4);
// Method21(count: 4, msg: "Новый текст");

// Вид3 методы, которые что-то возвращают, но ничего не при.н.имают. 
// Если метод что-то возвращает, мы в обязательном порядке должны указать тип данных, значение которого ожидаем

// int Method3()
// {
//     return DataTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// вид4 методы, которые что-то принимают и что-то возвращают.
// string Method4(int count, string text)
// { 
//     int i = 0; 
//     string result = String.Empty;
    
//     while (i < count)
//     { 
//         result = result + text;
//         i++;
//     } 
//     return result; 
// } 
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// string Method4(int count, string text)
// { 
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     { 
//         result = result + text;
//     } 
//     return result; 
// } 
// string res = Method4(10, "z");
// Console.WriteLine(res);

// таблицы умножения 
for (int i = 2; i <= 10; i++)
// { 
//     for (int j = 2; j <= 10; j++)
//     { 
//         Console.WriteLine($"{i} * {j} = {i * j}"); 
//     } 
//     Console.WriteLine(); 
// }

// /=====Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”, 
// а большие “С” маленькими “с”. 
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// / string s = “qwerty” //                      
//               012345
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{ 
    string result = String.Empty;
    int length = text.Length; // Инициализация пустой строки
    for (int i = 0; i < length; i++)
    { 
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    } 
    return result;
} 
string newText = Replace(text, ' ','|'); 

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к','К'); 
Console.WriteLine(newText);


