using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment7_Lottery_week12
{
    public class Lottery
    {
        int max_value;
        int wanted_numbers;

        int drawn_number_index;

        int[] all_numbers;
        int[] drawn_numbers;

        bool lottery_finished;
        public Lottery(int mval, int wnumbers)
        {
            this.max_value = mval;
            this.wanted_numbers = wnumbers;

            all_numbers = new int[mval];
            drawn_numbers = new int[wnumbers];

            for (int i = 0; i < mval; i++)
            {
                all_numbers[i] = i+1;
            }

            for (int i = 0; i < wnumbers; i++)
            {
                drawn_numbers[i] = 0;
            }

            Random r = new Random();
            int left_balls = max_value;

            for (int i = 0; i < wanted_numbers; i++)
            {
                int randomball_index = r.Next(0, (left_balls - 1));
                int randomball = all_numbers[randomball_index];

                all_numbers = all_numbers.Where(val => val != randomball).ToArray();
                drawn_numbers[i] = randomball;
                left_balls = left_balls - 1;
            }

            drawn_number_index = 0;
        }

        public int[] DrawAllNumbers()
        {
            lottery_finished = true;
            return drawn_numbers;
        }

        public int DrawNextNumber()
        {
            drawn_number_index = drawn_number_index + 1;
            return drawn_numbers[drawn_number_index-1];
        }

        public bool IsLotteryFinished()
        {
            if (lottery_finished)
            {
                return true;
            }
            else if (drawn_number_index < wanted_numbers)
            {
                return false;
            }
            else if (drawn_number_index >= wanted_numbers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
