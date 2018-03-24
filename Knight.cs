using System;

namespace Interfaces
{
    // Any class that implements the interface must implement the members defined in the interface.
    // When a class derives from a base type and interfaces, the base class must come first.
    class Knight : IAttack, IMove
    {
        public int Health
        {
            get;
            set;
        }

        public void Attack()
        {
            this.Health += 100;
        }

        public void Move()
        {
        }

        // If a class implements multiple interface that contains the same signature
        // interfaces can be implemented explicitly.
        // Otherwise the implementation is used for both interfaces.
        void IAttack.Same()
        { 
        }

        void IMove.Same()
        { 
        }

        public void Base()
        { 
        }
    }
}
