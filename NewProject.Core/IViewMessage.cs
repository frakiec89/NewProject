using System;

namespace NewProject.Core
{
    public interface IViewMessage
    {
        event EventHandler StartEvent;
        void Print(string message);
    }
}
