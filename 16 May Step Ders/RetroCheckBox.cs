namespace _16_May_Step_Ders
{
    public class RetroCheckBox : ICheckBox
    {
        public RetroCheckBox()
        {
            IsChecked = false;
            Style = "Retro CheckBox";
        }
        public bool IsChecked { get; set; }
        public string Style { get; set; }
    }
}


/**/
