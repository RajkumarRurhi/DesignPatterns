using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    internal class CarRepo : IEnumerable
    {
        private string[] cars;
        private int index;
        IEnumerator enumerator;
        public CarRepo()
        {
            cars = new string[2];
            index = 0;
        }

        public void addCar(string car)
        {
            if(cars.Length == index)
            {
                string[] moreCars = new string[index + 5];
                cars.CopyTo(moreCars, 0);
                cars = moreCars;
            }
            cars[index++] = car;
        }

        public IEnumerator GetEnumerator()
        {
            enumerator = new CarEnumerator(cars);
            return enumerator;
        }

        private class CarEnumerator : IEnumerator
        {
            int currentIndex = 0;
            private readonly string[] cars;

            object IEnumerator.Current => cars[currentIndex];

            public CarEnumerator(string[] cars)
            {
                this.cars = cars;
            }

            public bool MoveNext()
            {
                if(currentIndex < cars.Length && cars[currentIndex] != null)
                {
                    currentIndex++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                currentIndex = 0;
            }
        }
    }
}
