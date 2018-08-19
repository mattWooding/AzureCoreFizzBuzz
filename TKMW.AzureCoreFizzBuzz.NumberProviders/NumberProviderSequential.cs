using System;
using TKMW.AzureCoreFizzBuzz.Interfaces;

namespace TKMW.AzureCoreFizzBuzz.NumberProviders
{
    public class NumberProviderSequential : INumberProvider
    {
        public enum countDirections { up, down }

        private countDirections countDirection;
        private int fromNumber;
        private int toNumber;
        private int step;
        private int number;

        public NumberProviderSequential(int from, int to, int step)
        {
            if (from <= to)
            {
                countDirection = countDirections.up;
            }
            else
            {
                countDirection = countDirections.down;
            }

            if (countDirection == countDirections.up)
            {
                this.fromNumber = from - step;
            }
            else
            {
                this.fromNumber = from + step;
            }

            this.toNumber = to;
            this.step = step;
            this.number = fromNumber;

            if (countDirection == countDirections.up && fromNumber > toNumber)
            {
                throw new Exception("NumberProviderSequential from/to/up problem");
            }
            if (countDirection == countDirections.down && fromNumber < toNumber)
            {
                throw new Exception("NumberProviderSequential from/to/down problem");
            }
        }

        public bool Next()
        {
            if (countDirection == countDirections.up)
            {
                number = number + step;
                return !(number > toNumber);
            }
            else
            {
                number = number - step;
                return !(number < toNumber);
            }
        }

        public int TheNumber { get => number; }

        public void Reset()
        {
            number = fromNumber;
        }
    }
}
