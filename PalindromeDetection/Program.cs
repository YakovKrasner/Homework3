Console.WriteLine ("Введите число");
string? number = Convert.ToString (Math.Abs ((Convert.ToInt32 (Console.ReadLine ())))); // Вводим число в виде string, переводим его в тип данных int для того, чтобы взять от него модуль (на случай, если пользователь ввел отрицательное число), затем обратно переводим в тип данных string
int leftComparedSymbol = 0;
int rightComparedSymbol = number.Length - 1; // вводим переменную RightComparedSymbol для определения номера символа с правого конца числа или фразы, с которым будем сравнивать символ под номером LeftComparedSymbol с левого конца
bool answer = true; // по умолчанию считаем, что число является палиндромом
    while (leftComparedSymbol < rightComparedSymbol) 
        {
                if (number[leftComparedSymbol] != number[rightComparedSymbol]) // прекращаем цикл в том случае, если на зеркальных (симметричных) позициях разные символы
                    {
                        answer = false; // принимаем значение false для переменной answer, то есть даем отрицательный ответ на вопрос, является ли число палиндромом
                        break; 
                    }
            leftComparedSymbol = leftComparedSymbol +1;
            rightComparedSymbol = rightComparedSymbol -1;
           
        }
    if (answer == true) // переменная answer сохраняет значение true, если в ходе выполнения цикла (см. выше) не были обнаружены разные символы на зеркальных позициях
        {
            Console.WriteLine ("Число - палиндром");
        }
    else 
        {
            Console.WriteLine ("Число - не палиндром");
        }