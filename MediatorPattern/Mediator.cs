using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    internal class Mediator
    {
        private List<Light> lights;

        public Mediator()
        {
            lights = new List<Light>();
        }

        public void RegisterLight(Light light)
        {
            lights.Add(light);
        }

        public void TurnOnAllLights()
        {
            foreach (Light light in lights)
            {
                if (!light.IsOn)
                {
                    light.Toggle();
                }
            }
        }

        public void TurnOffAllLights()
        {
            foreach (Light light in lights)
            {
                if (light.IsOn)
                {
                    light.Toggle();
                }
            }
        }
    }
}
