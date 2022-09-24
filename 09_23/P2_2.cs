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
    public static int[,] CHESS_MAP = new int[9, 9];

    public static void Init()
    {
        // init chess map
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                CHESS_MAP[i, j] = -1;
            }
        }
    }
    public static void Output()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (i == 0 && j == 0) Console.Write("  ");
                else if (i == 0) Console.Write("{0} ", (char)(j + 'A'-1));
                else if (j == 0) Console.Write("{0} ", i);
                else Console.Write((CHESS_MAP[i,j]==-1 ? "_ " : (CHESS_MAP[i,j]==1 ? "O ":"X ")));
            }
            Console.Write("\n");
        }
    }
    public static void Check(int I,int J)
    {
        int[,] vec = { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };
        int posI,posJ;
        for(int k = 0; k < 4; k++)
        {
            bool c = false;
            for (posI = I + vec[k, 0], posJ = J + vec[k, 1]; 1 <= posI && 1 <= posJ && posI <= 8 && posJ <= 8; posI += vec[k, 0], posJ += vec[k,1])
            {
                if (CHESS_MAP[posI, posJ] == -1 )
                {
                    c = false;
                    break;
                }
                else if(CHESS_MAP[posI,posJ] == CHESS_MAP[I, J])
                {
                    c = true;
                    break;
                }
            }
            if(c)
            {
                for(int i = I + vec[k,0], j = J + vec[k,1]; i != posI || j != posJ; i += vec[k, 0], j += vec[k, 1])
                {
                    CHESS_MAP[i, j] = CHESS_MAP[I, J];
                }
            }
        }
    }
    public static int LAST = 64;
    public static bool flag = true;

    public static void Main(string[] args)
    {

        Init();
        while( LAST!=0 )
        {
            Output();
            string player = (flag ? "O" : "X");
            Console.WriteLine("It’s Player {0}’s turn Please enter the spot to place the piece", player);
            string raw = RawInput();
            int J = raw[0] - 'A' + 1;
            int I = raw[1] - '0';

            //Console.WriteLine("Pos : {0} {1} ", I, J);

            while(CHESS_MAP[I,J]!=-1)
            {
                Console.WriteLine("This spot already exists a piece! Press any button to continue.");
                Console.ReadLine();
                // again
                Console.Clear();
                Output();
                Console.WriteLine("It’s Player {0}’s turn Please enter the spot to place the piece", player);
                raw = RawInput();
                J = raw[0] - 'A' + 1;
                I = raw[1] - '0';
            }

            if( flag )
            {
                CHESS_MAP[I, J] = 1;
            }
            else
            {
                CHESS_MAP[I, J] = 0;
            }

            Check(I,J);

            LAST--;
            flag = !flag;
            Console.Clear();
        }
        // winner
        int countO = 0, countX = 0;
        for(int i = 1; i <= 8; i++)
        {
            for(int j = 1; j <= 8; j++)
            {
                if (CHESS_MAP[i, j] == 1)
                {
                    countO++;
                }
                else
                {
                    countX++;
                }
            }
        }

        Console.Write("Game over Player {0} won!", (countO > countX ? "O" : "X"));
    }
}
