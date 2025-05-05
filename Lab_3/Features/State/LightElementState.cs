using System;

namespace LightHTML.Features.State
{
    public class LightElementState : IState
    {
        private string stateName;

        public LightElementState(string stateName)
        {
            this.stateName = stateName;
        }

        public void Render()
        {
            Console.WriteLine($"Rendering element in {stateName} state.");
        }
    }
}
