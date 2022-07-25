using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Corner
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;

        public int Gradus
        {
            get
            {
                return (gradus);
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    gradus = value % 360;
                }
            }   
        }
        public int Min
        {
            get
            {
                return (min);
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
            }
        }
         public int Sec
        {
            get
            {
                return (sec);
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }
        public Corner(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public double ToRadians()
        {
            return (gradus * 3600 + min * 60 + sec) * Math.PI / (180 * 3600);
        }
    }
}
