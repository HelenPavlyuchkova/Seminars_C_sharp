// вспомним что такое рекурсия

void SomeRec(int n)//до какого n выводить нашу рекурсию
{
    if(n <= 0) 
        return;
    Console.WriteLine(n);
    
    SomeRec(n-1);
}

SomeRec(10);//10 раз выведем
System.Console.WriteLine("b kgbmkg");
return;
System.Console.WriteLine("bm kfdgj");

static void Main()
{

}


// void SomeRec(int n, string s)//до какого n выводить нашу рекурсию
// {
//     if(n <= 0) 
//         return;
//     s = s + n + " ";
//     System.Console.WriteLine(s);
//     //Console.Write(n);
    
//     SomeRec(n-1, s);
// }

// string str = " ";
// SomeRec(10, str);//10 раз выведем
// System.Console.WriteLine(str);

// void SomeRec(int n, ref string s)//ref-идентификатор, кот нужен когда передаем переменную по ссылке
// {
//     if(n <= 0) 
//         return;
//     s = s + n + " ";
//     // System.Console.WriteLine(s);
//     //Console.Write(n);
    
//     SomeRec(n-1, ref s);
// }

// string str = " ";
// SomeRec(10, ref str);//10 раз выведем
// System.Console.WriteLine(str);