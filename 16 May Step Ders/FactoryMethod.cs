namespace _16_May_Step_Ders
{
    public static class FactoryMethod
    {
        public static Soldier GetSoldier(string soldierType)
        {
            if (soldierType == "S")
            {
                return new Swordsman();
            }
            else if (soldierType == "A")
            {
                return new Archery();
            }
            else if (soldierType == "C")
            {
                return new Cannon();
            }
            return null;
            
        }
    }
}
