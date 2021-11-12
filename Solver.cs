using System;

namespace GUICalculator
{
    public class Solver : ISolve
    {
        public string input = "";

        public Solver()
        {
        }

        public void Accumulate(string s)
        {
            this.input += s;
        }
        public void Clear()
        {
            input = "";
        }
        public double Solve()
        {
            string left = "";
            int leftEnd = 0;
            int rightEnd = 0;
            string right = "";
            string current = "";
            double tally = 0;
            string previous = "";

            current = this.input;

            for(int x = 0; x < current.Length; x++)
            {
                if (current[x] == '-' && x == 0)
                    x++;
                if(current[x] == '*')
                {
                    //track the left side of the multiplication
                    for(int l = x-1; l > 0 && current[l] != '/' && current[l] != '+' && current[l] != '%'; l--)
                    {
                        if (current[l] == '-')
                        {
                            if (current[l-1] == '-')
                            {
                                leftEnd = l;
                                for (int i = leftEnd; i < x; i++)
                                {
                                    left += current[i];
                                }
                            }
                            else
                            {
                                leftEnd = l + 1;
                                for (int i = leftEnd; i < x; i++)
                                {
                                    left += current[i];
                                }
                            }
                            for (int r = x + 1; r < current.Length && current[r] != '/' && current[r] != '+' && current[r] != '%' && current[r] != '-' && current[r] != '*'; r++)
                            {
                                right += current[r];
                                rightEnd = r;
                            }

                            tally = Convert.ToDouble(left) * Convert.ToDouble(right);

                            previous = current;
                            current = "";

                            for (int i = 0; i < leftEnd; i++)
                            {
                                current += previous[i];
                            }

                            current += tally.ToString();

                            for (int i = rightEnd; i < previous.Length; i++)
                            {
                                current += previous[i];
                            }

                            leftEnd = 0;
                            rightEnd = 0;
                            left = "";
                            right = "";

                        }
                        else if (current[l - 1] == '/' || current[l - 1] == '+' || current[l - 1] == '%'|| l == 0)
                        {
                            leftEnd = l;
                            for (int i = leftEnd; i < x; i++)
                            {
                                left += current[i];
                            }
                            for (int r = x + 1; r < current.Length && current[r] != '/' && current[r] != '+' && current[r] != '%' && current[r] != '-' && current[r] != '*'; r++)
                            {
                                right += current[r];
                                rightEnd = r;
                            }

                            tally = Convert.ToDouble(left) * Convert.ToDouble(right);

                            previous = current;
                            current = "";

                            for (int i = 0; i < leftEnd && leftEnd != 0; i++)
                            {
                                current += previous[i];
                            }

                            Console.WriteLine(tally);
                            current += tally.ToString();

                            for (int i = rightEnd; i < previous.Length && rightEnd != previous.Length - 1; i++)
                            {
                                current += previous[i];
                            }

                            leftEnd = 0;
                            rightEnd = 0;
                            left = "";
                            right = "";

                        }
                    }
                }
            }
            return Convert.ToDouble(current);
        }
    }
}
