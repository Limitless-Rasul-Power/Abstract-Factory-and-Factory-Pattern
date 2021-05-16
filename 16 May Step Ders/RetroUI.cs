namespace _16_May_Step_Ders
{
    public class RetroUI : UIToolKit_Abstract_Factory
    {
        public override Button CreateButton()
        {
            return new RetroButton();
        }

        public override ICheckBox CreateCheckBox()
        {
            return new RetroCheckBox();
        }
    }
}


/**/
