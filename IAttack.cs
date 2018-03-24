using System;

namespace Interfaces
{
    interface IAttack
    {
        int Health
        {
            get;
            set;
        }

        void Attack();
        void Same();
    }
}
