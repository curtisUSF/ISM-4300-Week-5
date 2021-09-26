using System;

namespace UnlockPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // PATHS connections that are possible
            // Brute Force approach
            int[,] paths = new int[,] { //ALL connections possible from 1
                                        { 1, 2 }, { 1, 4 }, { 1, 5 }, { 1, 6 }, { 1, 8 },
                                        //ALL connections possible from 2
                                        { 2, 1 }, { 2, 3 }, { 2, 4 }, { 2, 5 }, { 2, 6 }, { 2, 7 }, { 2, 9 },
                                        //ALL connections possible from 3
                                        { 3, 2 }, { 3, 4 }, { 3, 5 }, { 3, 6 },  { 3, 8 },
                                        //ALL connections possible from 4
                                        { 4, 1 }, { 4, 2 }, { 4, 3 }, { 4, 5 }, { 4, 7 }, { 4, 8 }, { 4, 9 },
                                        //ALL connections possible from 5
                                        { 5, 1 }, { 5, 2 }, { 5, 3 }, { 5, 4 }, { 5, 6 }, { 5, 7 }, { 5, 8 }, { 5, 9 },
                                        //ALL connections possible from 6
                                        { 6, 1 }, { 6, 2 }, { 6, 3 }, { 6, 5 }, { 6, 7 }, { 6, 8 }, { 6, 9 },
                                        //ALL connections possible from 7
                                        { 7, 2 }, { 7, 4 }, { 7, 5 }, { 7, 6 },  { 7, 8 },
                                        //ALL connections possible from 8
                                        { 8, 1 }, { 8, 3 }, { 8, 4 }, { 8, 5 }, { 8, 6 }, { 8, 7 }, { 8, 9 },
                                        //ALL connections possible from 9
                                        { 9, 2 }, { 9, 4 }, { 9, 5 }, { 9, 6 },  { 9, 8 },
            };


            //read in data from user
            string input = Console.ReadLine();

            //array to hold data from user
            char[] d = new char[input.Length];

            //loop the input into the array
            for (int i = 0; i < input.Length; i++)
            {
                d[i] = input[i];
            }


            
            /* 
            Sudo Code


                Nested loop idea:
                    For length of d
	                    # of ways to go left
	                    loop
		                    # of ways to go right
		                    loop

            
            Determining if going right(R) or left(L)

            if dir "L"
            move(x1,x2,y1,y2,dir)

            if (y2<y1 && x1 == x2)
            x3=x2-1
            y3 = y2
            return

            if(x2<x1 && y1==y2)
            y3=y2+1
            x3=x2
            return

            if(x2>x1 && y1==y2
            y3 = y2+1
            x3 = x1
            return

            if(x2>y1 && x2==x1
            x3 = x2+1
            y3 = y2
            return
             
            
             
             */





        }
    }
}
