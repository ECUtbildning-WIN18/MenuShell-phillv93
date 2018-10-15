using System;

namespace MenuShell.Views
{
    abstract class BaseView
    {
        public string Title { get; }

        public virtual void Display()
        {
            Console.Clear();
        }

        protected BaseView(string title)
        {
            Title = title;
            Console.Title = title;
        }
    }
}
