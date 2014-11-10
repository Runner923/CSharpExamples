using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
       static void Draw(string[,] tic)
       {
           /* Draws the tic-tac-toe board with each call */
           Console.WriteLine("|" + tic[0,0] + "|" + tic[0,1] + "|" + tic[0,2] + "|");
           Console.WriteLine("|" + tic[1, 0] + "|" + tic[1, 1] + "|" + tic[1, 2] + "|");
           Console.WriteLine("|" + tic[2, 0] + "|" + tic[2, 1] + "|" + tic[2, 2] + "|");
          
       }
       static Boolean CheckStatus(string[,] tic)
       {
           /* Checks current status of the game.  Looks for the following conditions: 
            * 1.) all 9 cells are filled
            * 2.) 3 - X/O's in a row
            * 3.) 3 - X/O's in a column
            * 4.) 3 - X/O's on any diagonal
            * A boolean ck is set to false when a call to CheckStatus is made
            * and set to true on the first occurrence of one of the conditions
            */
           string xocomb;
           Boolean ck;
           ck = false;
   /* check rows */
           for (int i = 0; i <= 2; ++i)
           {

               xocomb = tic[i, 0] + tic[i, 1] + tic[i, 2];
               if (xocomb == "XXX" | xocomb == "OOO")
                   ck = true;
             }


   /* check columns */       
           for (int i = 0; i <= 2; ++i)
           {

               xocomb = tic[0, i] + tic[1, i] + tic[2, i];
               if (xocomb == "XXX" | xocomb == "OOO")
                   ck = true;
           }
   /* check left-right diagonal */
           xocomb = tic[0, 0] + tic[1, 1] + tic[2, 2];
                if (xocomb == "XXX" | xocomb == "OOO")
                   ck = true;
  /* check right-left diagonal */
                xocomb = tic[0, 2] + tic[1, 1] + tic[2, 0];
               if(xocomb=="XXX" | xocomb=="OOO")
                   ck=true;

           return ck;


       }
       static int PlayerRowSelect()
       {
           int rn;
               Console.WriteLine("Input row number to play (0 to 2) ");
               rn = System.Int32.Parse(Console.ReadLine());
               while (rn < 0 | rn> 2)
               {
                   Console.WriteLine(" ** row number must be between 0 and 2 **");
                   rn = System.Int32.Parse(Console.ReadLine());
               }
               return rn;
       }
        static int PlayerColSelect()
        {
            int cn;
               Console.WriteLine("Input column number to play (0 to 2) ");
               cn = System.Int32.Parse(Console.ReadLine());
               while (cn < 0 | cn > 2)
               {
                   Console.WriteLine(" ** column number must be between 0 and 2 **");
                   cn = System.Int32.Parse(Console.ReadLine());
               }
               return cn;                
        }
       static void Main(string[] args)
       {
           string[,] tictac = new string[3, 3];
           /* initialize the board to blanks */
           for (int j=0;j<=2;j++)
           {
               for (int k = 0; k <= 2; k++)
               { tictac[j, k] = " "; }
           }
           string player,testmove;
         int rownumber, colnumber;
           Draw(tictac);
           Console.WriteLine("Returned Status " + CheckStatus(tictac));
           Console.ReadLine();
           for (int k = 0; k <= 8; k++)
           {
               Draw(tictac);
               if(k % 2 ==0)
               { player = "X"; } else
               { player = "O"; }
               Console.WriteLine("Player is " + player);
               /**/
               rownumber = PlayerRowSelect();
               colnumber = PlayerColSelect();
               /* test player selected position to check if it is occupied already */
               testmove=tictac[rownumber,colnumber];
               while (testmove != " ")
               {
                   Console.WriteLine(" ** that position is occupied, select again **");
                   rownumber = PlayerRowSelect();
                   colnumber = PlayerColSelect();                  
                   testmove = tictac[rownumber, colnumber];
               }
               tictac[rownumber, colnumber] = player;
               Draw(tictac);
               if (CheckStatus(tictac))
               {
                   Console.WriteLine("Game over "+ player+ " wins");
                   Console.ReadKey();
                   break;
               }
               Console.ReadKey();
               Console.Clear();
              
           }
           Console.WriteLine("Game over bitches!");
           Console.ReadKey();
       }            
    }
}
