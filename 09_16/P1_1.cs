using System;
using System.Collections.Generic;

class Program {

  public static void StartupUI(){
    Console.WriteLine ("(1)輸入輸出 (2)輸入支出 (3)計算比例 (4)剩餘金額 (5)退出程式");
    Console.Write("輸入數字選擇功能：");
  }
  public static int UserOption(){
    StartupUI();
    Console.Write("輸入數字選擇功能：");
    int op;
    op = Console.Read();
    return op;
  }
  public static int Deposit(){
    Console.WriteLine("輸入金額：");
    int money = Console.Read();
    return money ;
  }
  public static void Main (string[] args) {
    int Money=0;

    int Out=0;
    int[] outArr = new int[5];
    String[] typeArr = new String[5] { "食" , "衣"  , "住" , "行" , "育樂" };
    int opt;

    StartupUI();
    opt = Convert.ToInt32( Console.ReadLine() );
    
    while(  opt != 5 )
    {
        if( opt == 1 ){
            Console.WriteLine("輸入金額：");
            int money = Convert.ToInt32( Console.ReadLine() );
            Money += money;
        }
        else if( opt == 2 ){
            Console.Write("輸入數字選擇功能：");
            int Kind =Convert.ToInt32( Console.ReadLine() );
            Kind -- ;
            Console.Write("輸入金額：");
            int money =Convert.ToInt32( Console.ReadLine() );
            outArr[ Kind ]+= money ;
            Out += money ;
            Money -= money;
        }
        else if( opt == 3 ){
            if( Out == 0 ){
              for(int i=0 ;i<5;i++){
                Console.Write( typeArr[i] );
                Console.WriteLine( "0%" );
              }
              continue;
            }
            double sum = (double)Out;
            for(int i=0;i<5;i++){
                Console.Write( typeArr[i] );
                Console.Write( ((double)outArr[i]*100.0) / sum  );
                Console.WriteLine( "%");
            }
        }
        else if( opt == 4 ){
            Console.Write("剩餘金額為： " );
            Console.WriteLine( Money );
        }
        else if( opt ==5 ){
            break;
        }
      
        StartupUI();
        opt = Convert.ToInt32( Console.ReadLine() );
    }
    
  }
}