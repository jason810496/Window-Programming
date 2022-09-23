using System;
using System.Collections.Generic;


class Program
{
    public static string RawInput()
    {
        return Console.ReadLine();
    }

    public static int IntInput()
    {
        return int.Parse(RawInput());
    }

    public static int STATUS_ADD = 1;
    public static int STATUS_DELETE = 2;
    public static int STATUS_PRINT = 3;
    public static int STATUS_CALCULATE = 4;
    public static int STATUS_LEAVE = 5;

    public static string WeekDay(int i)
    {
        if (i == 1) return "Mon";
        else if (i == 2) return "Tue";
        else if (i == 3) return "Wed";
        else if (i == 4) return "Thu";
        else if (i == 5) return "Fri";
        else if (i == 6) return "Sat";
        return "Sun";
    }

    public class UI
    {
        public static void StartUp()
        {
            Console.WriteLine("(1)Add Course (2)Delete Course (3)Print class schedule (4)Calculate credits (5)Leave program");
        }
        public static int GetOpt()
        {
            Console.Write("Please enter a number to select a function : ");
            return IntInput();
        }
    }

    public static string[,] COURSE_DB = new string[10, 10];

    public static List<string> COURSE_CHECK = new List<string>();

    public static int TOTAL = 0;


    public static void Main(string[] args)
    {
        int status = UI.GetOpt();
        while(  status != STATUS_LEAVE )
        {
            if (status == STATUS_ADD)
            {

                Console.WriteLine("Please enter the course to add, the format is <course ID Day of the week Start End");
                // input format : ID Day st ed
                string raw = RawInput();
                string[] arr = raw.Split(' ');
                string course_id = arr[0];
                int day = int.Parse(arr[1]);
                int st = int.Parse(arr[2]);
                int ed = int.Parse(arr[3]);


                bool flag = true;

                // check selected
                bool F = COURSE_CHECK.Contains(course_id);
                if (F)
                {
                    flag = false;
                    Console.WriteLine("repeated course!");
                }

                // check covered
                for (int t = st; t <= ed; t++)
                {
                    if( COURSE_DB[day,t]!=null )
                    {
                        flag = false;
                        Console.WriteLine("course conflict!");
                        break;
                    }
                }
                

                // can selected
                if( flag)
                {
                    COURSE_CHECK.Add(course_id);
                    for(int t = st; t <= ed; t++)
                    {
                        COURSE_DB[day, t] = course_id;
                        TOTAL++;
                    }

                    Console.WriteLine("Course added successfully!");
                }
            }
            else if (status == STATUS_DELETE)
            {
                Console.Write("Please enter the course ID to delete ");

                string course_id = RawInput();
                bool F = COURSE_CHECK.Contains(course_id);
                if(F)
                {
                    COURSE_CHECK.Remove(course_id);
                    for(int i = 1; i <= 7; i++)
                    {
                        for(int j = 1; j <= 7; j++)
                        {
                            if(COURSE_DB[i,j] == course_id)
                            {
                                COURSE_DB[i, j]="";
                                TOTAL--;
                            }
                        }
                    }
                    Console.WriteLine("Course {0} deleted successfully", course_id);
                }
                else
                {
                    Console.WriteLine("{0} is not in the schedule", course_id);
                }
                     
            }
            else if( status == STATUS_PRINT)
            {
                for(int i = 0; i <=8; i++)
                {
                    for(int j = 0;j<8; j++)
                    {
                        if (i == 0 && j == 0) Console.Write(String.Format("{0,-6}",""));
                        else if( i==0)
                        {
                            
                            int idx = 0;
                            if (j == 1) idx = 7;
                            else { idx = j - 1; }

                            Console.Write(String.Format("{0,-6}", WeekDay(idx)));
                        }
                        else if( j==0)
                        {
                            Console.Write(String.Format("{0,-6}", i ) );
                        }
                        else
                        {
                            int idx = 0;
                            if (j == 1) idx = 7;
                            else { idx = j - 1; }
                            Console.Write(String.Format("{0,-6}", COURSE_DB[ idx, i] ) );
                        }
                    }
                    Console.Write("\n");
                }
            }
            else if( status == STATUS_CALCULATE )
            {
                Console.WriteLine(TOTAL);
            }
            // restart 
            status = UI.GetOpt();
        }    
    }
}
