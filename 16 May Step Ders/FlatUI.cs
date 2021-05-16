namespace _16_May_Step_Ders
{
    public class FlatUI : UIToolKit_Abstract_Factory
    {
        public override Button CreateButton()
        {
            return new FlatButton();
        }

        public override ICheckBox CreateCheckBox()
        {
            return new FlatCheckBox();           
        }
    }
}


/**/
