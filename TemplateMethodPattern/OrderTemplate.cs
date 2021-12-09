using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    internal abstract class OrderTemplate
    {
        public bool IsGift { get; set; }

        public abstract void CheckOut();
        public abstract void Payment();
        public abstract void Receipt();
        public abstract void Delivery();

        public void WrapGift()
        {
            Console.WriteLine("Gift wraped.");
        }

        public void ProcessOrder()
        {
            CheckOut();
            Payment();
            if (IsGift)
            {
                WrapGift();
            }
            else
            {
                Receipt();
            }
            Delivery();
        }
    }
}
