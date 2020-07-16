using System;
using System.Collections.Generic;
using System.Text;

namespace traffic_light
{
    public class LightMediator
    {
        private IList<Light> lights;

        public LightMediator()
        {
            lights = new List<Light>();
        }

        public void registerLight(Light light)
        {
            lights.Add(light);
        }
        public void unregisterLight(Light light)
        {
            lights.Remove(light);
        }
        public void notifyMediator(Light light)
        {            
            turnOffAllLights(light);
            foreach (var item in lights)
            {
                Console.WriteLine($"The light {item.getLightColor()} is turned {item.getCurrentState()}");
            }
        }
        private void turnOffAllLights(Light light)
        {
            foreach (var otherLight in lights)
            {
                if (otherLight.getLightColor() != light.getLightColor())
                {
                    otherLight.turnOff();
                }
            }
        }
    }
}
