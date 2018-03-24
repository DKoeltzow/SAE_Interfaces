using System;

namespace Interfaces
{
    // Interfaces can inherit from one or more interfaces
    interface IMove : IBase
    {
        void Move();
        void Same();
    }
}
