namespace _16_May_Step_Ders
{
    public class FlatCheckBox : ICheckBox
    {
        public FlatCheckBox()
        {
            IsChecked = false;
            Style = "Flat CheckBox";
        }
        public bool IsChecked { get; set; }
        public string Style { get; set; }
    }
}


/**/
