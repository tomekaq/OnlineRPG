using OnlineRPG.Items;
using System;

namespace OnlineRPG.BodyParts
{
    public class Body : BodyPart
    {
        public Body()
        {
            health = 1;
        }

        public override void PutOn(Item item)
        {
            Type t = item.GetType();
            if (t == typeof(Armour))
            {
                Clothes = (Clothes)item;
            }
        }
    }
}
