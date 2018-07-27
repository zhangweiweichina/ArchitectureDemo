using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pls.State.Contract;

namespace Pls.State.Implementation
{
    public class Person : IPerson
    {
        private static Dictionary<PersonState, IPerson> _states = new Dictionary<PersonState, IPerson>()
        {
            {PersonState.Work, new WorkState()},
            {PersonState.Sleep, new SleepState()},
            {PersonState.Drink, new DrinkState()}
        };

        public Person()
        {
            _currentState = _states[PersonState.Sleep];
        }

        private IPerson _currentState = null;

        private PersonState _state = PersonState.Sleep;
        public PersonState State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    _currentState = _states[_state];
                }
            }
        }

        public void Drive()
        {
            _currentState.Drive();
        }

        public void Eat()
        {
            _currentState.Eat();
        }

        public void Look()
        {
            _currentState.Look();
        }

        public void Talk()
        {
            _currentState.Talk();
        }

        public void Test()
        {
            Drive();
            Eat();
            Look();
            Talk();
        }
    }
}
