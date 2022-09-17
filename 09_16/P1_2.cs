using System;
using System.Collections.Generic;




class Program {


  public enum STATUS {
    INCOME = 1,
    EXPENSE = 2,
    ADD_OPTION = 3,
    DELETE_OPTION = 4,
    PERSENTAGE = 5,
    QUERY_EXPENSE = 6,
    QUERY_INCOME =7,
    QUIT= 8
  }

  public enum INCOME_UI {
    ASK , 
    NOT_INT ,
    NEGTIVE 
  }
  public enum EXPENSE_UI {
    ASK , 
    EMPTY ,
    LESS ,
    NOT_FOUND ,
    MONEY 
  }
  public enum ADD_UI {
    ASK , 
    EXISTED ,
    TOO_MUCH 
  }

  public enum DELETE_UI {
    ASK , 
    NOT_FOUND ,
    EMPTY 
  }


  public class OptionType {

    private string _Name ;
    private int _Total;

    public string Name { 
      get { return _Name; }
      set { _Name = value; }
    }
    public int Total {
      get { return _Total; }
      set { _Total = value; }
    }

    public OptionType(string str ,int num){
      _Name = str;
      _Total = num;
    }
    
  }
  public class User {
      public List< OptionType > Options;

      private int _Income;
      private int _Expense;

      public int Income { 
        get { return _Income; }
        set { _Income = value; }
      }
      public int Expense {
        get { return _Expense; }
        set { _Expense = value; }
      }

      public void AddOption(string nm ){
        Options.Add( new OptionType(nm,0) );
      }

      public User(){
        Options = new List<OptionType>();
        _Income = 0;
        _Expense = 0;
      }
  }

  public class UserInterface {
    public void StartupUI(){
      Console.WriteLine ("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
      Console.Write("輸入數字選擇功能：");
    }
    public STATUS GetUserOption(){
      StartupUI();
      int op;
      op = GetNumInput();
      return (STATUS)op;
    }
    public int GetNumInput(){
      return Convert.ToInt32( Console.ReadLine() );
    }
    public string GetRawInput(){
      return Console.ReadLine(); 
    }

    public void Income(INCOME_UI opt){
      switch( opt ){
        case INCOME_UI.ASK :
          Console.Write("輸入金額： ");
          break;
        case INCOME_UI.NOT_INT :
          Console.WriteLine("請輸入數字");
          break;
        case INCOME_UI.NEGTIVE :
          Console.WriteLine("收入不可為負數");
          break;
      }
    }

    public void Expense(EXPENSE_UI opt){
      switch( opt ){
        case EXPENSE_UI.ASK :
          Console.Write("輸入數字選擇支出項目： ");
          break;
        case EXPENSE_UI.MONEY :
          Console.Write("請輸入支出金錢： ");
          break;
        case EXPENSE_UI.EMPTY :
          Console.WriteLine("請輸入支出項目");
          break;
        case EXPENSE_UI.LESS :
          Console.WriteLine("存款不足");
          break;
        case EXPENSE_UI.NOT_FOUND :
          Console.WriteLine("此數字不在範圍內");
          break;
      }
      
    }

    public void Add(ADD_UI opt ){
      switch( opt ){
        case ADD_UI.ASK:
          Console.Write("輸入項目名稱：");
          break;
        case ADD_UI.EXISTED:
          Console.WriteLine("支出項目已存在");
          break; 
        case ADD_UI.TOO_MUCH:
          Console.WriteLine("已無法再新增支出項目");
          break;
      }
    }

    public void Delete(DELETE_UI opt ){
      switch( opt ){
        case DELETE_UI.ASK:
          Console.Write("輸入項目名稱");
          break;
        case DELETE_UI.NOT_FOUND:
          Console.WriteLine("此項目不存在");
          break; 
        case DELETE_UI.EMPTY:
          Console.WriteLine("已無法再刪除支出項目");
          break;
      }
    }

    public void Query_Expense(){
      Console.Write("輸入要查詢的項目：");
    }
  }


  public const int OPTIONS_LIMIT = 6;

  public static void Main (string[] args) {

    UserInterface UI = new UserInterface();
    User usr = new User();

    STATUS OPTION = UI.GetUserOption();
    
    while(  OPTION != STATUS.QUIT )
    {
        switch( OPTION )
        {
          case STATUS.INCOME : 
          {
            UI.Income( INCOME_UI.ASK );

            string RawInput = UI.GetRawInput();
            int money;
            bool isInt = int.TryParse( RawInput , out money);

            if( isInt ){

              if( money < 0){
                UI.Income( INCOME_UI.NEGTIVE );
              }
              else{
                usr.Income += money;
              }
            }
            else{
              UI.Income( INCOME_UI.NOT_INT );
            }
            break;
          }
            
          case STATUS.EXPENSE :
          {
            if( usr.Options.Count == 0 ){
              UI.Expense( EXPENSE_UI.EMPTY );
            }
            else{
              for(int i=0;i<usr.Options.Count ;i++ ){
                Console.WriteLine( "({0}) {1}" ,i+1 ,usr.Options[i].Name);
              }
              UI.Expense( EXPENSE_UI.ASK );

              int opt = UI.GetNumInput();

              if( opt > usr.Options.Count ){
                UI.Expense( EXPENSE_UI.NOT_FOUND );
              }
              else{
                UI.Expense( EXPENSE_UI.MONEY );
                int exp = UI.GetNumInput();

                if( usr.Income-exp < 0 ){
                  UI.Expense( EXPENSE_UI.LESS );
                }
                else{
                  usr.Options[ opt-1 ].Total += exp;
                  usr.Income -= exp ;
                  usr.Expense += exp;
                }
              }
            }
            break;
          }

          case STATUS.ADD_OPTION :
          {
            UI.Add( ADD_UI.ASK );

            bool InList = false;
            string NewOpt= UI.GetRawInput();

            foreach (OptionType i in usr.Options ){
              if( i.Name == NewOpt ){
                InList = true;
                break;
              }
            }

            if( InList ){
              UI.Add( ADD_UI.EXISTED );
            }
            else{
              if( usr.Options.Count < OPTIONS_LIMIT ){
                usr.AddOption( NewOpt );
              }
              else{
                UI.Add( ADD_UI.TOO_MUCH );
              }
            }
            break;
          }

          case STATUS.DELETE_OPTION :
          {
            UI.Add( ADD_UI.ASK );

            bool InList = false;
            int Idx=0;
            string NewOpt= UI.GetRawInput();

            foreach (OptionType i in usr.Options ){
              if( i.Name == NewOpt ){
                InList = true;
                break;
              }
              Idx++;
            }

            if( usr.Options.Count == 0 ){
              UI.Delete( DELETE_UI.EMPTY );
            }
            else{
              if( InList ){
                usr.Options.RemoveAt( Idx );
              }
              else{
                UI.Delete( DELETE_UI.NOT_FOUND );
              }
            }
            break;
          }

          case STATUS.PERSENTAGE :
          {
            for(int i=0;i<usr.Options.Count ; i++ ){
              double result;
              if( usr.Expense == 0){
                result = 0;
              }
              else result = (double)usr.Options[i].Total*100.0/(double)usr.Expense ;
              Console.WriteLine( "({0}) {1}: {2} %",i+1,usr.Options[i].Name,result );
            }
            break;
          }

          case STATUS.QUERY_EXPENSE :
          {
            Console.WriteLine( $"目前總支出： {usr.Expense}");
            UI.Query_Expense();
            string opt = UI.GetRawInput();
            
            bool InList = false;
            int Idx=0;

            foreach (OptionType i in usr.Options ){
              if( i.Name == opt ){
                InList = true;
                break;
              }
              Idx++;
            }

            if( InList ){
              Console.WriteLine($"{usr.Options[Idx].Name} : {usr.Options[Idx].Total}");
            }
            else{
              Console.WriteLine("此項目不存在");
            }
            break;
          }

          case STATUS.QUERY_INCOME :
          {
            Console.WriteLine( $"剩餘金額為：{usr.Income}");
            break;
          }

          case STATUS.QUIT :
              return ;
        }
      // new status 
      OPTION = UI.GetUserOption();
    }
    
  }
}