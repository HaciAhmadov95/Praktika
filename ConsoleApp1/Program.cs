

//task1

//static void Test(int number)
//{
//    Console.WriteLine("Hello World"+ number);
//}

//Test(50);





//  task2


//static void Test(int number = 100)
//{
//    Console.WriteLine("Hello World ---" + number);
//}

//Test();


// task3

//static void Test (int number, string name, int num = 100)
//{

//    Console.WriteLine("Hello World---" + num);

//}

//Test(40, "Haci");


//Task4

//static void ArrTest(int[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}

//int[] arr = {2,4,5,6};

//ArrTest(arr);


//Task5

//static void ArrTest(params int[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}



//ArrTest(2, 4, 5, 6);


//Task6


//int a = 100;
//int b = a;

//b = 200;

//Console.WriteLine(a);
//Console.WriteLine(b);


//Task7

//string name = "Haci";

//string surname = name;

//surname = "salamlar";

//Console.WriteLine(name);
//Console.WriteLine(surname);

//Task8

//int [] arr1 = {1,2,3};

////int[] arr2 = arr1;
//arr2[0] = 300;



//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);


//Task9

//int[] nums = {2, 3, 4, 5 };

//Console.WriteLine(nums[0]);


//Test(nums);

//Console.WriteLine(nums[0]);



//static void Test(int[] arr)
//{

//    //arr[0] = 5;
//    Console.WriteLine(arr[0]+10);


//}



//Task10

//int b= 20;

//Console.WriteLine(b);

//Test(b);

//Console.WriteLine(b);



//static void Test(int a)
//{
//    a = 200;
//    Console.WriteLine(a);
//}




////Task11

//int b = 2;

//Console.WriteLine(b);

//Test(ref b);

//Console.WriteLine(b);




//static void Test (ref int a)
//{
//     a = 200;
//    Console.WriteLine(a);
//}


//Task12


//int a = 5;
//int b = a++;

//Console.WriteLine(a);
//Console.WriteLine(b);   


//Task13



//int a = 5;

//int c = a;

//int b = ++a;

//a++;

//c = --a;

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);




//Task14


//string name = "test";

//Console.WriteLine(name.Length);





////Task15

//string name = "Haci";

//Console.WriteLine(name.ToLower());


//Task16



//string name = "Haci";

//Console.WriteLine(name.ToUpper());



//Task17


//string name1 = "Haci";
//string name2 = "haci";

//Console.WriteLine(name1.ToLower() == name2.ToLower());


//Task18


//string name1 = "  Haci";

//String name2 = "haci  ";

//Console.WriteLine(name1.ToLower().Trim() == name2.ToLower().Trim());



//Task19


//int a = 14;

//Console.WriteLine(a.ToString().GetType());


////Task20


//string str = "Azerbaycan";

//Console.WriteLine(str.Replace("A","a"));


//Task21



//string str = "Azerbaycan";

//var data = str.ToCharArray();

//Console.WriteLine(data[0]);



//Task22


// string str = "Azerbaycan";

//var data = str.ToCharArray();


//for (int i = 0; i < str.Length; i++)
//{

//    Console.WriteLine(str[i]);

//}


//Task23




//string str = "Azerbaycan";

//Console.WriteLine(str.Contains("a"));




//Task24


//string str1 = "Azerbaycan";
//string str2 = "Respublikasi";

//string result = string.Concat(str1, " ",str2);

//Console.WriteLine(result);


//Task25


//string str = "Test";

//Console.WriteLine(str.StartsWith("t"));


//Task26


//////*/Console.WriteLine*/("Add string :");

//////string str =/*/*/*/* Console.ReadLine()*/*/*/*/;


////string[] words = { "test", "Test2", "Sagol" };


//int count = GetCountStrWithCondition(str,words);


//Console.WriteLine(count);






//static int GetCountStrWithCondition(string str, string[] words)
//{int count = 0;

//    foreach (var word in words )
//        if (word.ToLower().StartsWith(str.ToLower()))
//        {

//            count++;
//        }
//    return count;
//}






//Task27



