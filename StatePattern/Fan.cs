using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class Fan
    {
        State offState;
        State onLowState;
        State onMediumState;
        State onHighState;

        State currentState;
        public Fan()
        {
            offState = new TurnOffState(this);
            onLowState = new TurnOnLowState(this);
            onMediumState = new TurnOnMediumState(this);
            onHighState = new TurnOnHighState(this);

            currentState = offState;
        }

        public State OffState { get { return offState; } }
        public State OnLowState { get { return onLowState; } }
        public State OnMediumState { get { return onMediumState; } }
        public State OnHighState { get { return onHighState; } }

        public void PullChain()
        {
            currentState.ExecuteRequest();
        }

        public State CurrentState { set { currentState = value; } }

        public override string ToString()
        {
            return currentState.ToString();
        }
    }
}
