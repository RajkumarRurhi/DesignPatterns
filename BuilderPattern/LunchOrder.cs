using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    internal class LunchOrder
    {
        public class Builder
        {
            private string bread;
            private string condiments;
            private string dressing;
            private string meat;

            public string Bread { get { return bread; } }
            public string Condiments { get { return condiments; } }
            public string Dressing { get { return dressing; } }
            public string Meat { get { return meat; } }
            public Builder() { }

            public LunchOrder Build()
            {
                return new LunchOrder(this);
            }
            
            public Builder AddBread(string bread)
            {
                this.bread = bread;
                return this;
            }

            public Builder AddCondiments(string condiments)
            {
                this.condiments = condiments;
                return this;
            }

            public Builder AddDressing(string dressing)
            {
                this.dressing = dressing;
                return this;
            }

            public Builder AddMeat(string meat)
            {
                this.meat = meat;
                return this;
            }
        }

        private string bread;
        private string condiments;
        private string dressing;
        private string meat;
        public LunchOrder(Builder builder)
        {
            this.bread = builder.Bread;
            this.condiments = builder.Condiments;
            this.dressing = builder.Dressing;
            this.meat = builder.Meat;
        }

        public override string ToString()
        {
            return this.bread + " - " + this.condiments + " - " + this.dressing + " - " + this.meat;
        }
    }
}
