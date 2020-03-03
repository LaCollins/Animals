using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    internal class Alligator //"internal" means only accessable within project. "public" means accessable to anyone. "private" means only usable within class.
    {
        public bool IsAquatic { get; set; }
        private int _stepGoal;
        private int _stepCount;

        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
        }
        public void Grunt()
        {
            if (IsAquatic)
            {
                Console.WriteLine("Bubble bubble bubble");
            }
            else
            {
                Console.WriteLine("GRRRRRR!");
            }
        }
        public void Run(int steps) //Method signature
        {
            _stepCount += steps;

            Console.WriteLine($"You ran {steps} steps.");

            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine("Congratulations, you met your goal!");
            }
        }
    }
}
