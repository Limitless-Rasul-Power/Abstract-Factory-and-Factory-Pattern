namespace _16_May_Step_Ders
{
    public class WindowsDialog : Dialog
    {
        //second implementation
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }

    }
}


/**/