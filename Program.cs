using System;

namespace traffic_light
{
    class Program
    {
        static void Main(string[] args)
        {
            LightMediator mediator = new LightMediator();
            Light[] lights =
            {
                new Light(LightColor.Red, mediator),
                new Light(LightColor.Yellow, mediator),
                new Light(LightColor.Green, mediator)
            };
            foreach (var light in lights)
            {
                mediator.registerLight(light);
            }
            
            //Console.WriteLine("Hello World!");
            int currentLightIndex = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                lights[currentLightIndex].turnOn();
                currentLightIndex++;
                if (currentLightIndex >= lights.Length)
                {
                    currentLightIndex = 0;
                }
            }
        }
    }
}
