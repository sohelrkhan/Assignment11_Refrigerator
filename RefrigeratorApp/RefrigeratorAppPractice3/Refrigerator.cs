using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {
        private int maximumWeight;
        private int noOfItems;
        private int unitOfWeight;
        //Properties
        public int MaximumWeight
        {
            get { return maximumWeight; }
            set { this.maximumWeight = value; }
        }

        public int NoOfItems
        {
            get { return noOfItems; }
            set { this.noOfItems = value; }
        }
        public int UnitOfWeight
        {
            get { return unitOfWeight; }
            set { this.unitOfWeight = value; }
        }
        //Methord
        public int GetRemainingWeight()

        {
            int remainingWeight = maximumWeight - (noOfItems * unitOfWeight);
            return remainingWeight;
        }
        public int GetCurrentWeight()

        {
            int currentWeight = noOfItems * unitOfWeight;
            return currentWeight;

        }

    }
}
