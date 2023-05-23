using lb12;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;

IComparer<string> mycomp=Comparer<string>.Create((s1,s2)=>s1.Length-s2.Length);
IComparer<string> mycomp1 = Comparer<string>.Create((s1, s2) => s1.Length - s2.Length);

try
{
    #region z1
    #region test1
    //var stack = new MyStack<string>();
    //string s;
    //var f = new StreamReader(@"..\..\..\laba12.txt");
    //while ((s = f.ReadLine()) != null)
    //{
    //    stack.Push(s);
    //}
    //f.Close();
    //while (!stack.Voidless())
    //{
    //    Console.WriteLine(stack.Pop());
    //}
    //f = new StreamReader(@"..\..\..\laba12.txt");
    //var stck1 = new MyStack<string>();
    //int tp = 0;
    //while ((s = f.ReadLine()) != null)
    //{
    //    stack.Push(s);
    //    if (stck1.Voidless())
    //    {
    //        stck1.Push(s);
    //        tp = 0;
    //    }
    //    else
    //    {
    //        if (stack.Peek().Length < stck1.Peek().Length)
    //        {
    //            stck1.Push(s);
    //            tp += 1;
    //        }
    //        else
    //        {
    //            stck1.Push(stck1.Peek());
    //        }
    //    }
    //}
    //f.Close();
    //Console.WriteLine("мин:" + stck1.Peek() + " номер:" + tp + " длина:" + stck1.Peek().Length);

    ////Задание 1.в
    //var stck2 = new MyStack<string>();
    //int tmp = 0;
    //while (!stack.Voidless())
    //{
    //    if (stck2.Voidless())
    //    {
    //        stck2.Push(stack.Pop());
    //        tp = 0;
    //        tmp = 0;
    //    }
    //    else
    //    {
    //        if (stack.Peek().Length > stck2.Peek().Length)
    //        {
    //            stck2.Push(stack.Pop());

    //        }
    //        else
    //        {
    //            tp = tmp;
    //            stack.Pop();
    //            stck2.Push(stck2.Peek());
    //        }
    //        tmp += 1;
    //    }
    //}
    //Console.WriteLine("max:" + stck2.Peek() + " номер:" + tp + " длина:" + stck2.Peek().Length);
    ////Задание 1.г
    //var nw = new Stack<string>();
    //f = new StreamReader(@"..\..\..\laba12.txt");
    //while ((s = f.ReadLine()) != null)
    //{
    //    nw.Push(s);
    //}
    //f.Close();
    //var nw1 = new Stack<string>();
    //tp = 0;
    //while (nw.Count != 0)
    //{
    //    if (nw1.Count == 0)
    //    {
    //        nw1.Push(nw.Pop());
    //        tp = 0;
    //        tmp = 0;
    //    }
    //    else
    //    {
    //        if (nw.Peek().Length < nw1.Peek().Length)
    //        {
    //            nw1.Push(nw.Pop());
    //            tp++;
    //        }
    //        else
    //        {
    //            nw.Pop();
    //            nw1.Push(nw1.Peek());
    //        }
    //    }
    //}
    //Console.WriteLine("мин:" + nw1.Peek() + " номер:" + tp + " длина:" + nw1.Peek().Length);

    //f = new StreamReader(@"..\..\..\laba12.txt");
    //while ((s = f.ReadLine()) != null)
    //{
    //    nw.Push(s);
    //}
    //f.Close();
    //var nw2 = new Stack<string>();
    //while (nw.Count != 0)
    //{
    //    if (nw2.Count == 0)
    //    {
    //        nw2.Push(nw.Pop());
    //        tp = 0;
    //        tmp = 0;
    //    }
    //    else
    //    {
    //        if (nw.Peek().Length > nw2.Peek().Length)
    //        {
    //            nw2.Push(nw.Pop());

    //        }
    //        else
    //        {
    //            tp = tmp;
    //            nw.Pop();
    //            nw2.Push(nw2.Peek());
    //        }
    //        tmp += 1;
    //    }
    //}
    //Console.WriteLine("max:" + nw2.Peek() + " номер:" + tp + " длина:" + nw2.Peek().Length);
    #endregion
    #region test2
    //var stack = new MyStack<string>();
    //string s;
    //var f = new StreamReader(@"..\..\..\laba12.txt");
    //while ((s = f.ReadLine()) != null)
    //{
    //    stack.Push(s);
    //}
    //f.Close();
    //while (!stack.Voidless())
    //{
    //    Console.WriteLine(stack.Pop());
    //}
    //var stk1 = new MyStackMaxMin<string, IComparer<string>, IComparer<string>>(mycomp, mycomp1);
    //f = new StreamReader(@"..\..\..\laba12.txt");
    //while ((s = f.ReadLine()) != null)
    //{
    //    stk1.Push(s);
    //}
    //if (stk1.GetMax() is string) { Console.WriteLine("max:" + stk1.GetMax() + " length:" + stk1.GetMax().Length); } else { Console.WriteLine("max:" + stk1.GetMax()); };
    //if (stk1.GetMin() is string) { Console.WriteLine("min:" + stk1.GetMin() + " length:" + stk1.GetMin().Length); } else { Console.WriteLine("min:" + stk1.GetMin()); };
    //f.Close();
    #endregion
    #endregion
    #region z2
    //Console.WriteLine("Введите строку:");
    //string str = Console.ReadLine();
    //var S1 = new MyStack<string>(str.Length);
    //var S2 = new MyStack<int>(str.Length);
    //var S3 = new MyStack<string>(str.Length);
    //var S4 = new MyStack<int>(str.Length);
    //for (int i = str.Length - 1; i >= 0; i--)
    //{
    //    if (str[i].ToString() == "]" || str[i].ToString() == ")" || str[i].ToString() == "}")
    //    {
    //        S1.Push(str[i].ToString());
    //        S2.Push(i);
    //    }
    //    else if (str[i].ToString() == "[")
    //    {
    //        if (!S1.Voidless())
    //        {
    //            if (S1.Peek() == "]")
    //            {
    //                S1.Pop();
    //                S2.Pop();
    //            }
    //        }
    //        else
    //        {
    //            S3.Push(str[i].ToString());
    //            S4.Push(i);
    //        }
    //    }
    //    else if (str[i].ToString() == "(")
    //    {
    //        if (!S1.Voidless())
    //        {
    //            if (S1.Peek() == ")")
    //            {
    //                S1.Pop();
    //                S2.Pop();
    //            }
    //        }
    //        else
    //        {
    //            S3.Push(str[i].ToString());
    //            S4.Push(i);
    //        }
    //    }
    //    else if (str[i].ToString() == "{")
    //    {
    //        if (!S1.Voidless())
    //        {
    //            if (S1.Peek() == "}")
    //            {
    //                S1.Pop();
    //                S2.Pop();
    //            }
    //        }
    //        else
    //        {
    //            S3.Push(str[i].ToString());
    //            S4.Push(i);
    //        }
    //    }
    //}

    //if (S1.Voidless() && S3.Voidless())
    //{
    //    Console.WriteLine("YES");
    //}
    //else if(!S1.Voidless())
    //{
    //    Console.WriteLine(S2.Pop() + 1);
    //}
    //else
    //{
    //    Console.WriteLine(S4.Pop() + 1);
    //}
    #endregion
    #region z3
    //Console.WriteLine("Введите строку:");
    //string str=Console.ReadLine();
    //var at=new ATD<string>();
    //Regex rg = new Regex("[A-Z]");
    //for (int i = 0; i < str.Length; i++)
    //{
    //    if (rg.IsMatch(str[i].ToString()))
    //    {
    //        at.Add(str[i].ToString());
    //    }
    //    else
    //    {
    //        if (at.Voidless())
    //        {
    //            continue;
    //        }
    //        else
    //        {
    //            if (str[i].ToString() == "*")
    //            {
    //                Console.WriteLine(at.Pop());
    //            }
    //        }
    //    }
    //}
    //Задание 3.а2
    //Console.WriteLine("Введите строку:");
    //string str = Console.ReadLine();
    //var at = new ATD<string>();
    //Regex rg = new Regex("[A-Z]");
    //Queue<string> q = new Queue<string>();
    //for (int i = 0; i < str.Length; i++)
    //{
    //    if (rg.IsMatch(str[i].ToString()))
    //    {
    //        q.Enqueue(str[i].ToString());
    //        //Console.WriteLine("!"+str[i]);
    //    }
    //    else
    //    {
    //        if (q.Count==0)
    //        {
    //            continue;
    //        }
    //        else
    //        {
    //            if (str[i].ToString() == "*")
    //            {
    //                Console.WriteLine(q.Dequeue());
    //            }
    //        }
    //    }
    //}

    //Задание 3.b1
    var q1 = new Queue<string>();
    var f = new StreamReader(@"..\..\..\lb12_1.txt");
    string s;
    while ((s = f.ReadLine()) != null)
    {
        q1.Enqueue(s);
    }
    var temp = "";
    int max = 0;
    for(int i = 0; i < q1.Count; i++)
    {
        temp= q1.Dequeue();
        if (temp.Length > max) max = temp.Length;
        q1.Enqueue(temp);
    }
    temp = "";
    while (true)
    {
        temp = q1.Dequeue();
        if (temp.Length != max)
        {
            q1.Enqueue(temp);
        }
        else
        {
            break;
        }
    }
    Console.WriteLine(temp);
    f.Close();
    #endregion
}
catch (Exception e) { Console.WriteLine(e.Message); }
