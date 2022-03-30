// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

// 백준-설탕배달
//var s = Console.ReadLine();
//if (s == null)
//    Environment.Exit(0);

//int Nkg = int.Parse(s);

//int cnt5kg, cnt3kg = 0;
//int mod5, mod3 = 0;
//cnt5kg = Math.DivRem(Nkg, 5, out mod5);
//int res = cnt5kg;

//while (true)
//{
//    if (mod5 == 0)
//        break;
//    else if (mod5 > Nkg)
//    {
//        res = -1;
//        break;
//    }
//    else if (mod5 % 3 > 0)
//    {
//        cnt5kg--;
//        mod5 += 5;
//    }
//    else
//    {
//        cnt3kg = Math.DivRem(Nkg - (5 * cnt5kg), 3, out mod3);
//        res = cnt5kg + cnt3kg;
//        break;
//    }
//}

//Console.WriteLine(res);

// 프로그래머스-배달(푸는중)
//int N = 5;
//int[,] road = new int[,] { { 1, 2, 1 },{ 2, 3, 3 },{ 5, 2, 2 },{ 1, 4, 2 },{5, 3, 1},{ 5, 4, 2}}; // 이런식으로 초기화
//List<int> visited = new List<int>();
//int[,] resource = new int[N+1, N+1];

//for (int i = 0; i < road.GetLength(0); i++) {
//    resource[road[i, 0], road[i, 1]] = road[i, 2];
//}

//int startnode = 1;
//int totalCost = 0;

//visited.Add(startnode);


// 백준- 후위표기식2(ver1, 틀렸습니다.)
//var varN = Console.ReadLine();
//string strN = varN == null ? "" : varN;
//int N = int.Parse(strN);
//var read_exp = Console.ReadLine();
//Dictionary<int, double> keyValuePairs = new Dictionary<int, double>();

//for (int j = 0; j < N; j++)
//{
//    var varinputnum = Console.ReadLine();
//    string strinputnum = varinputnum == null ? "" : varinputnum;
//    keyValuePairs[65+j] = int.Parse(strinputnum);
//}

//string exp = read_exp == null ? "" : read_exp;
//char[] regex = { '+', '-', '*', '/' };

//Queue<char> inputregex = new Queue<char>();
//Stack<int> inputChar = new Stack<int>();

//bool isRegexTurn = false;
//double res = 0;

//for (int i = 0; i < exp.Length; i++)
//{
//    if (regex.Contains(exp[i]))
//    {
//        isRegexTurn = true;
//        inputregex.Enqueue(exp[i]);
//    }
//    else
//    {
//        if (isRegexTurn)
//        {
//            while(inputChar.Count > 1)
//            {
//                double tmpres = Operators(inputregex.Dequeue(), keyValuePairs[inputChar.Pop()], keyValuePairs[inputChar.Pop()]);

//                inputChar.Push(0);
//                keyValuePairs[0] = tmpres;
//            }
//            res = keyValuePairs[0];
//            inputChar.Pop(); inputChar.Push(1);
//            keyValuePairs[1] = res;
//            isRegexTurn = false;
//        }
//        inputChar.Push((int) exp[i]);
//    }

//    if(i == exp.Length - 1)
//    {
//        while (inputChar.Count > 1)
//        {
//            double tmpres = Operators(inputregex.Dequeue(), keyValuePairs[inputChar.Pop()], keyValuePairs[inputChar.Pop()]);

//            inputChar.Push(0);
//            keyValuePairs[0] = tmpres;
//        }
//        res = keyValuePairs[0];
//    }

//}

//Console.WriteLine(string.Format("{0:0.##}",res));
//Console.ReadKey();

//static double Operators(char logic, double y, double x) // 와, tab으로 모든걸 자동완성 시켜버리네. 겁나 똑똑하네.
//{
//    switch (logic)
//    {
//        case '+': return x + y;
//        case '-': return x - y;
//        case '*': return x * y;
//        case '/': return x / y;
//        default: throw new Exception("Invalid logic");
//    }
//}


// 백준- 후위표기식2 -- 재시도(다른사람 코드 참고)
//var varN = Console.ReadLine(); int N = varN == null ? 0 : int.Parse(varN);
//var exp = Console.ReadLine(); string strexp = exp == null ? "" : exp;
//int[] numlist = new int[N];

//for(int i = 0; i<N; i++)
//{
//    var num = Console.ReadLine();
//    numlist[i] = num == null ? 0 : int.Parse(num);
//}

//Stack<int> stack = new Stack<int>();

//foreach (char chr in exp)
//{
//    if ('A' <= chr && chr <= 'Z')
//        stack.Push(numlist[chr-'A']);
//    else
//    {
//        int chr1 = stack.Pop();
//        int chr2 = stack.Pop();

//        switch(chr) {
//            case '+': stack.Push(chr1 + chr2); break;
//            case '-': stack.Push(chr1 - chr2); break;
//            case '*': stack.Push(chr1 * chr2); break;
//            case '/': stack.Push(chr1 / chr2); break;
//            default: throw new Exception("Invalid operation");
//        }
//    }
//}

//Console.WriteLine(String.Format("{0:0.00}",stack.Pop()));
//Console.ReadKey();


// 백준-음계 . 2022.3.29 --왜틀린거임 대체
//List<int> listDaJangjo = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8 }; // 이런식으로도 선언할 수 있음
//List<int> listInputMelody = new List<int>();

//var varInput = Console.ReadLine();
//string strInput = varInput == null ? "" : varInput;
//listInputMelody = Array.ConvertAll(strInput.Split(' '), s => int.Parse(s)).ToList(); // Array.ConvertAll(Array, var => parse func(var)) 를 유용하게 사용하자!

//// 배열, 순서까지 같은지 확인하려면, List의 SequenceEqual을 유용하게 사용하자!
//bool compTwoList_ascending = listDaJangjo.SequenceEqual(listInputMelody);
//listInputMelody.Reverse();
//var compTwoList_descending = listDaJangjo.SequenceEqual(listInputMelody);

//if (!compTwoList_ascending)
//{
//    if (!compTwoList_descending)
//        Console.WriteLine("Mixed");
//    else
//        Console.WriteLine("descending");
//}
//else
//    Console.WriteLine("ascending");

//Console.ReadKey();

// 백준-2750 수 정렬하기 (8min 30sec 소요) => O(NlogN). 선택정렬인 O(N^2)보다는 적은시간 소요
//var varN = Console.ReadLine();
//int intN = varN == null ? 0 : int.Parse(varN);
//List<int> intList = new List<int>();

//for (int i = 0; i < intN; i++)
//{
//    var varTmp = Console.ReadLine();
//    int intTmp = varTmp == null ? 0 : int.Parse(varTmp);

//    intList.Add(intTmp);

//}

//intList.Sort();

//Console.WriteLine(string.Join("\n", intList.ToArray()));


// 백준-1427 소트인사이트 (7min 50sec 소요) => O(NlogN)
//var varN = Console.ReadLine();
//string strN = varN == null ? "" : varN;
//List<int> intList = new List<int>();

//foreach (var n in strN)
//{
//    string strn = n.ToString();
//    int intN = int.Parse(strn);
//    intList.Add(intN);
//}

//intList.Sort(); intList.Reverse();
//Console.WriteLine(string.Join("",intList.ToArray()));



