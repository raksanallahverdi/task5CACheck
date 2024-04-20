
//eded tek ve ya cutdur
//Console.WriteLine("Enter any number");
//int number = Convert.ToInt32(Console.ReadLine());
//if(number==0)
//{
//    Console.WriteLine("Eded ne cutdur ne tekdir");
//}
//else if(number % 2 == 0)
//   {
//    Console.WriteLine("Eded cutdur");
//}
//else
//{
//    Console.WriteLine("Eded tekdir");
//}


//task1(5 ededin cemi)
//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());
//int number3 = Convert.ToInt32(Console.ReadLine());
//int number4 = Convert.ToInt32(Console.ReadLine());
//int number5 = Convert.ToInt32(Console.ReadLine());
//int sum = number1 + number2 + number3 + number4 + number5;
//Console.WriteLine(sum);

//task2(ededin kvadratini)
//int number = Convert.ToInt32(Console.ReadLine());
//int square = number*number;
//Console.WriteLine(square);


//task3(3 ededin en bouyuyunu tap)
//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());
//int number3 = Convert.ToInt32(Console.ReadLine());

//if (number1>number2 && number1 > number3)
//{
//    Console.WriteLine(number1 + "en boyukdur");
//}
//else if(number2>number1 && number2 > number3)
//{
//    Console.WriteLine(number2 + "en boyukdur");
//}
//else
//{
//    Console.WriteLine(number3 + "en boyukdur");
//}

//task4(2 ededin kubunun boyuk olub olmamasi)
//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());
//int cube = number1 * number1 * number1;
//if (cube > number2)
//{
//    Console.WriteLine("1-ci ededin kubu boyukdur");
//}
//else
//{
//    Console.WriteLine("1-ci ededin kubu boyuk deyil");
//}

//task5(hem 3 hem 5 )
//int number1 = Convert.ToInt32(Console.ReadLine());
//if (number1%3==0 && number1 % 5 == 0)
//{
//    Console.WriteLine("her iksine bolunur");
//}
//else
//{
//    Console.WriteLine("her iksine bolunmur");
//}


//task6(kartdaki mebleg ve mehsul)
//Console.WriteLine("Kart meblegini daxil edin");
//int kart = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Mehsulun meblegini daxil edin");
//int mehsul = Convert.ToInt32(Console.ReadLine());
//if (kart > mehsul)
//{
//    Console.WriteLine("Mebleginiz yeterlidir");
//}
//else
//{
//    Console.WriteLine("Mebleginiz yeterli deyildir");
//}

//task7(imtahan)
//int bal1 = Convert.ToInt32(Console.ReadLine());
//int bal2 = Convert.ToInt32(Console.ReadLine());
//int bal3 = Convert.ToInt32(Console.ReadLine());
//int bal4 = Convert.ToInt32(Console.ReadLine());
//int bal5 = Convert.ToInt32(Console.ReadLine());
//int average;
//if (bal1 > 0 && bal1 < 100 &&
//    bal2 > 0 && bal2 < 100 &&
//    bal3 > 0 && bal3 < 100 &&
//    bal4 > 0 && bal4 < 100 &&
//    bal5 > 0 && bal5 < 100)
//{
//    average = (bal1 + bal2 + bal3 + bal4 + bal5) / 5;
//    if (average > 65)
//    {
//        Console.WriteLine("Imtahani kechmisiniz");
//    }
//    else
//    {
//        Console.WriteLine("Imtahani kechmemisiniz");
//    }

//}
//else
//{
//    Console.WriteLine("Bali duzgun qeyd etmemisiniz");
//}


//task8(2 ededin boyuyunu tap)
//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());

//if (number1 > number2)
//{
//    Console.WriteLine(number1 + " boyukdur");
//}
//else if (number2 > number1)
//{
//    Console.WriteLine(number2 + " boyukdur");
//}
//else
//{
//    Console.WriteLine("Ededler beraberdir");
//}


//task9(Donma derecesi)
//int temperature = Convert.ToInt32(Console.ReadLine());
//if (temperature > 0)
//{
//    Console.WriteLine("Donma derecesinden boyukdur");
//}
//else if (temperature < 0)
//{
//    Console.WriteLine("Donma derecesinden kichikdir");
//}
//else
//{
//    Console.WriteLine("Donma derecesindedir");
//}

//task1(50 e qeder ededler)
//int number = 50;
//for (int i = 0; i <= number; i++)
//{
//    Console.WriteLine(i);
//}

//task2(40 e qeder 3 e bolunen ededler)
//int count = 0;
//int number = 40;
//for (int i = 0; i <= number; i++)
//{
//    if (i % 3 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//task3(100 e qeder 3 ve 7 e bolunen ededler)
//int count = 0;
//int number = 100;
//for (int i = 0; i <= number; i++)
//{
//    if (i % 3 == 0 && i%7==0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//task4(ededin reqemlerinin sayi)
//int number = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while (number > 0)
//{
//    number=number/10;
//    count++;

//}
//Console.WriteLine(count);


//task5(ededin tersine yazmaq)
//int number = Convert.ToInt32(Console.ReadLine());
//int ters = 0;
//while (number > 0)
//{
//    ters = ters * 10 + number % 10;
//        number = number / 10;
//}
//Console.WriteLine(ters);

//task6(faktorial)
//int number = Convert.ToInt32(Console.ReadLine());
//int factorial = 1;

//while (number > 0)
//{
//    factorial = factorial * number;
//    number--;
//}
//Console.WriteLine(factorial);

//task7(sade or murekkeb)
// int number = Convert.ToInt32(Console.ReadLine());
// int kok = Convert.ToInt32(Math.Sqrt(number));
// bool def=false;

// for (int i = 2; i <= kok; i++)
// {
//    if (number % i == 0)
//    {
//        Console.WriteLine("Eded murekkebdir");
//        def=true;
//        break;
//    }
// }
//  if(def==false)
//    {
//        Console.WriteLine("Eded sadedir");
    
//    }

//task8(ededin reqemlerinin cemi)
//int number = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//while (number > 0)
//{
//    sum += number % 10;
//    number = number / 10;
//}
//Console.WriteLine(sum);

//task9(ededin reqemlerinin en boyuyu)
//int number = Convert.ToInt32(Console.ReadLine());
//int max = 1;
//int dummy;
//while (number > 0)
//{
//    dummy = number % 10;
//    if (max < dummy)
//    {
//        max = dummy;
//    }
//    number = number / 10;
//}
//Console.WriteLine(max);

//task10(70 den kicik cutler azalan sira ile )
//int number = 70;
//for (int i = number; i >= 0; i--)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//}
//task11(Fesiller)
//int month = Convert.ToInt32(Console.ReadLine());
//switch (month)
//{
//    case 1:
//    case 2:
//    case 12:
//        Console.WriteLine("Qish feslidir");
//        break;
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("Yaz feslidir");
//        break;

//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("Yay feslidir");
//        break;
//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine(" Payiz feslidir");
//        break;

//    default:
//        Console.WriteLine("Duzgun fesil qeyd etmemisiniz");
//        break;

//}


//task11
//int n = Convert.ToInt32(Console.ReadLine());
//int m = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= m; j++)
//    {
//            Console.Write("* ");

//    }
//    Console.WriteLine();
//}


//task12(ulduz)
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");

//    }
//    Console.WriteLine("* ");
//}

//task13(ters ulduz)

//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = n; i >= 0; i--)
//{
//    for (int j = i-1; j >= 0; j--)
//    {
//        Console.Write("*");

//    }
//    Console.WriteLine("* ");
//}

//hello000
//n

























