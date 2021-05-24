using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class PC
    {
        
        public string SNS { get; set; }
        public string sex { get; set; }

        private double _year_of_graduation;
        public double year_of_graduation
        {
            get
            {
                return _year_of_graduation;
            }
            set
            {
                if (value >= 0)
                    _year_of_graduation = value;
                else
                    throw new Exception("Рік закінчення школи не може бути відємним");
            }
        }


        private double _competitive_score;
        public double competitive_score
        {
            get
            {
                return _competitive_score;
            }
            set
            {
                if (value >= 0)
                    _competitive_score = value;
                else
                    throw new Exception("Конкурсний бал не може бути відємним");
            }
        }

      

        public PC(string SNS, string sex, double year_of_graduation, double competitive_score)
        {
            this.SNS = SNS;
            this.sex = sex;
            this.year_of_graduation = year_of_graduation;
            this.competitive_score = competitive_score;

        }

    }
}
