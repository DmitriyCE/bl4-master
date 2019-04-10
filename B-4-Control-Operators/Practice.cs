using System;
using static System.Console;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
           
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            WriteLine("Введите слово содержащее букву 'а'");
            string word = ReadLine();
            int count=0;
            for (int i = 0;i<word.Length; i++)
            {
                if (word[i] == Convert.ToChar("а"))
                {
                    count += 1;
                }
            }
            WriteLine("Количество букв а в слове: " + $"{count}");
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            char a = 'a';
            char z = 'z';
            for (int i = Convert.ToInt32(z); i >= Convert.ToInt32(a); i--)
            {
                WriteLine(Convert.ToChar(i));
            }
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            WriteLine("Введите число");
            int number = Convert.ToInt32(ReadLine());
            WriteLine("Введите степень в которую возведется введенное ранее число");
            int pow = Convert.ToInt32(ReadLine());
            int result = 1;
            int i = 0;
            while (i < pow)
            {
                result *= number;
                i++;
            }
            WriteLine(result);
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void B4_P21_25_While_DiceGameMultiplePlayers()
        {
            int positionPlayer1 = 0;
            int positionPlayer2 = 0;
            while (positionPlayer1<=25||positionPlayer2 <= 25)
            {
                WriteLine("Player1: введите число от 1 до 6");
                int numberPlayer1 = Convert.ToInt32(ReadLine());
                positionPlayer1 += numberPlayer1;
                WriteLine("Позиция Player1: "+Convert.ToString(positionPlayer1));
                if (positionPlayer1 >= 25)
                {
                    WriteLine("Player1 дошел первым!");
                    break;
                }
                WriteLine("Player2: введите число от 1 до 6");
                int numberPlayer2 = Convert.ToInt32(ReadLine());
                positionPlayer2 += numberPlayer2;
                WriteLine("Позиция Player2: " + Convert.ToString(positionPlayer2)); 
                if (positionPlayer2 >= 25)
                {
                    WriteLine("Player2 дошел первым!");
                    break;
                }
            } 
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            WriteLine("Загадайте число от 1 до 100");
            ReadLine();
            int x = 50;
            int a = 1;
            int b = 100;
            string answer=null;
            while (answer != "=")
            {
                WriteLine("Ваше число больше, меньше или равно "+ $"{x}"+ " ?(>/</=)");
                answer = ReadLine();
                if (answer == ">")
                {
                    a = x;
                    x = a + ((b - a) / 2);
                }
                if (answer == "<")
                {
                    b = x;
                    x = a + ((b - a) / 2);
                }
                if (answer == "=")
                {
                    WriteLine("Ваше число"+$"{x}");
                }
            }

        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            WriteLine("Введите слово");
            string word = ReadLine();
            string reverse = null;
            for (int i = word.Length; i > 0; i--)
            {
                reverse += word[i-1];
            }
            WriteLine(reverse);
        }
    }
}
