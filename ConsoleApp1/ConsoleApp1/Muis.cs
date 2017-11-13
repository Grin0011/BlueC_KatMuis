using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Muis
    {
        private bool isLevend;

        public Muis()
        {
            this.isLevend = true;
        }

        public void Kill()
        {
            this.isLevend = false;
        }

        public override string ToString()
        {
            if (this.isLevend == true)
            {
                return "Nog steeds levend haha!";
            } else
            {
                return "Harstikke dood";
            }
        }
    }
}
