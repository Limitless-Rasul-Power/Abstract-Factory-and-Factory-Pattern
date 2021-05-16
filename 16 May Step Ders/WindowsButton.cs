using System;

namespace _16_May_Step_Ders
{
    //second implementation
    public class WindowsButton : IButton
    {
        public event Action OnClick;

        public void Render()
        {
            Console.WriteLine("Windows Button Rendered.");
        }
    }
}


/**/