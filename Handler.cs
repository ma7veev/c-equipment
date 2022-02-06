using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    class Handler
    {
        private List<int> StData;
        private List<int> LtData;
        private int[,] condOptValues;
        private int[,] condOptResults;
        private List<int> uncondOpt;
        private int periods;
        private int price;
        private String debug;
        private String output;

        public Handler(List<int> StData, List<int> LtData, int price)
        {
            this.StData = StData;
            this.LtData = LtData;
            this.price = price;
            this.debug = "Результати розрахунку:\n";
        }
        public void process()
        {
            this.condOptimization();
            this.uncondOptimization();
            this.conclude();
        }
        private void condOptimization()
        {
            // Залишкова вартість S(t) по періодам 
            int[] St = this.StData.ToArray();
            // Доход L(t) по періодам
            int[] Lt = this.LtData.ToArray();
            //Кількість періодів
            this.periods = this.LtData.Count();
            this.periods = Lt.Count();
            this.debug += "Кількість періодів: " + this.periods.ToString();
            this.debug += "\n";

            int r0 = Lt[0];//прибуток за базовий (0) період

            this.debug += "Безумовна оптимізація:\n";
            this.condOptValues = new int[this.periods, this.periods];
            this.condOptResults = new int[this.periods, this.periods];
            for (int k = this.periods - 1; k >= 1; k--)
            {
                this.debug += "Крок (k: " + k.ToString() + ")";
                this.debug += "\n";

                for (int t = 1; t <= this.periods - 1; t++)
                {
                    this.debug += "Період (t:" + t.ToString() + ")";
                    this.debug += " - ";
                    int c = 0;
                    for (int i = t; i <= (this.periods - k + t - 1); i++)
                    {
                        if(i <= this.periods - 1)
                        {
                            c += Lt[i];
                        }
                    }
                    int r = 0;
                    for (int i = 0; i < (this.periods - k); i++)
                    {
                        r += Lt[i];
                    }
                    int z = (St[t] - this.price) + r;
                    int v = Math.Max(c, z);

                    this.condOptValues[k, t] = v;
                    this.debug += "  (" + v.ToString() + ")  ";
                    if (c >= z)
                    {
                        // - Зберігаємо
                       this.condOptResults[k, t] = 0;
                        this.debug += "Зберіг.";

                    }
                    else
                    {
                        //Замінюємо
                       this.condOptResults[k, t] = 1;
                        this.debug += "Замін.";
                    }
                    this.debug += ";   ";
                }
                this.debug += "\n\n\n";
            }
        }
        private void uncondOptimization()
        {
            //Безумовна оптимізація
            this.debug += "Безумовна оптимізація:\n";
            this.uncondOpt = new List<int> { };
            int t = 1;
            for (int k = 1; k <= this.periods - 1; k++)
            {
                this.debug += "Крок (k: " + k.ToString() + ")";
                this.debug += "Період (t:" + t.ToString() + ")   ";
                if (this.condOptResults[k, t] == 1)
                {
                    this.debug += "Замін." + k;
                    this.uncondOpt.Add(k);
                    t = 1;
                } else
                {
                    this.debug += "Зберіг." + k;
                }
                this.debug += "\n\n\n";
                t++;
            }

        }

        private void conclude()
        {
            this.output = "Таким чином заміну обладнання за " + this.periods.ToString() 
                + " років експлуатаціі треба проводити на початку " + String.Join("", this.uncondOpt.ToList()) + " року\n";
        }
    

        public String getOutput(bool showDebug)
        {
            String output = "";
            if (showDebug)
            {
                output += this.debug;
            }
            output += this.output;
            return output;
        }

    }
}
