void Test2()
{   
    string[,] num1 = new string[,]{{"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","@","@","+","+","+","+"},
                                    {"+","+","@","+","@","+","+","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","@","@","@","@","@","+","+"}};
    string[,] num2 = new string[,]{{"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","@","@","+","+","+","+"},
                                    {"+","+","@","+","+","@","+","+","+"},
                                    {"+","+","+","+","+","@","+","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","@","+","+","+","+","+"},
                                    {"+","+","@","@","@","@","@","+","+"}};
    string[,] num3 = new string[,]{{"+","+","+","+","@","@","+","+","+"},
                                    {"+","+","+","@","+","+","@","+","+"},
                                    {"+","+","+","+","+","+","@","+","+"},
                                    {"+","+","+","+","@","@","+","+","+"},
                                    {"+","+","+","+","+","+","@","+","+"},
                                    {"+","+","+","@","+","+","@","+","+"},
                                    {"+","+","+","+","@","@","+","+","+"}};
    string[,] num4 = new string[,]{{"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","@","@","+","+","+","+"},
                                    {"+","+","@","+","@","+","+","+","+"},
                                    {"+","@","+","+","@","+","+","+","+"},
                                    {"@","@","@","@","@","@","+","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"}};
    string[,] num5 = new string[,]{{"+","+","+","+","@","@","@","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","+","@","@","+","+","+"},
                                    {"+","+","+","+","+","+","@","+","+"},
                                    {"+","+","+","+","+","+","@","+","+"},
                                    {"+","+","+","+","+","+","@","+","+"},
                                    {"+","+","+","+","@","@","+","+","+"}};   
    string[,] num6 = new string[,]{{"+","+","+","+","@","@","+","+","+"},
                                    {"+","+","+","@","+","+","+","+","+"},
                                    {"+","+","@","@","@","@","+","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","+","@","@","@","+","+","+"}};                           
    string[,] num7 = new string[,]{{"+","+","+","+","@","+","+","+","+"},
                                    {"+","@","@","@","@","@","+","+","+"},
                                    {"+","@","+","+","+","@","+","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","+","@","+","+","+","+"},
                                    {"+","+","+","@","+","+","+","+","+"},
                                    {"+","+","+","@","+","+","+","+","+"}};
    string[,] num8 = new string[,]{{"+","+","+","@","@","@","+","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","+","@","@","@","+","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","+","@","@","@","+","+","+"}};
    string[,] num9 = new string[,]{{"+","+","+","@","@","@","+","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","+","@","@","@","@","+","+"},
                                    {"+","+","+","+","+","@","+","+","+"},
                                    {"+","+","+","@","@","+","+","+","+"}};
    string[,] num0 = new string[,]{{"+","+","+","@","@","@","+","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","@","+","+","+","@","+","+"},
                                    {"+","+","+","@","@","@","+","+","+"}};                                                                                                                        
    DateTime checkTime = DateTime.Now;
    int Hour = checkTime.Hour;
    int Min = checkTime.Minute;
    hrs();
    mns();
    
void hrs()
{
    if(Hour / 10 == 1)
   {
    PrintNum(num1);
   }
   else if(Hour / 10 == 2)
   {
    PrintNum(num2);
   }
    else if(Hour / 10 == 0)
   {
    PrintNum(num0);
   }
}
void mns()
{
    if(Hour % 10 == 1)
   {
    PrintNum(num1);
   }
   else if(Hour % 10 == 2)
   {
    PrintNum(num2);
   }
    else if(Hour % 10 == 3)
   {
    PrintNum(num3);
   }
   else if(Hour % 10 == 4)
   {
    PrintNum(num4);
   }
    else if(Hour % 10 == 5)
   {
    PrintNum(num5);
   }
   else if(Hour % 10 == 6)
   {
    PrintNum(num6);
   }
    else if(Hour % 10 == 7)
   {
    PrintNum(num7);
   }
   else if(Hour % 10 == 8)
   {
    PrintNum(num8);
   }
    else if(Hour % 10 == 9)
   {
    PrintNum(num9);
   }
    else if(Hour % 10 == 0)
   {
    PrintNum(num0);
   }


    
}

void PrintNum(string[,] num1)
{
   DateTime checkTime = DateTime.Now;
    int Hour = checkTime.Hour;
    int Min = checkTime.Minute;
    if(Hour / 10 == 1)
    {
        for(int i = 0; i < num1.GetLength(0); i++)
    {
        for(int j = 0; j < num1.GetLength(1); j++)
        {
            Console.Write(num1[i, j]);
        }
        Console.WriteLine();
    };
    }
}
}
Test2();