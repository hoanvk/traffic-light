using System;
using System.Collections.Generic;
using System.Text;

namespace traffic_light
{
    public enum State
    {
        ON,
        OFF
    }
    public enum LightColor
    {
        Red,
        Yellow,
        Green
    }
    public class Light
    {
        private LightMediator mediator;
        public Light(LightColor _color, LightMediator _mediator)
        {
            this.lightColor = _color;
            this.mediator = _mediator;
            this.currentState = State.OFF;
        }
        private LightColor lightColor;
        public string getLightColor()
        {
            string color = "???";
            switch (lightColor)
            {
                case LightColor.Red:
                    color = "Red";
                    break;
                case LightColor.Yellow:
                    color = "Yellow";
                    break;
                case LightColor.Green:
                    color = "Green";
                    break;
                default:
                    break;
            }
            return color;
        }
        //public State currentState { get; private set; }
        private State currentState;

        public string getCurrentState()
        {
            return currentState== State.ON?"On":"Off";
        }
        public void turnOn()
        {
            this.currentState = State.ON;
            mediator.notifyMediator(this);
        }
        public void turnOff()
        {
            this.currentState = State.OFF;
            //mediator.notifyMediator(this);
        }
    }
}
