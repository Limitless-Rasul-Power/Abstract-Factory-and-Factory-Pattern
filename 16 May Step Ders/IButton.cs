using System;

namespace _16_May_Step_Ders
{
    //second implementation
    public interface IButton
    {
        void Render();
        event Action OnClick;
    }
}


/**/