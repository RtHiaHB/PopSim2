using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopSim2
{
    [Serializable()]
    public class Name
    {
        private string itsValue;
        private string itsDadsSurname;
        private static Random r = new Random((int)DateTime.Now.Ticks);
        public string Value
        {
            get
            {
                return itsValue;
            }
            set
            {
                itsValue = value;
            }
        }
        public Name(int Length)
        {
            char a;
            int t;
            for (int i = 0; i < Length; i++)
            {
                t = r.Next(0, 26);
                a = Convert.ToChar(t + 65);
                itsValue = itsValue + a;

            }
        }
        public Name(Name momsName, Name dadsName)
        {
            Name firstname = new Name(5);
            
            itsValue = firstname.ToString();
            if (momsName.DadsSurname==string.Empty || momsName.DadsSurname==null)
            {
                itsValue = itsValue + " " + momsName.ToString();
            }
            else
            {
                itsValue = itsValue + " " + momsName.DadsSurname;
            }
            if (dadsName.DadsSurname ==string.Empty || dadsName.DadsSurname==null)
            {
                itsValue = itsValue + "-" + dadsName.ToString();
                itsDadsSurname = dadsName.ToString();
            }
            else
            {
                itsValue = itsValue + "-" + dadsName.DadsSurname;
                itsDadsSurname = dadsName.DadsSurname;
            }
            
        }
        public string DadsSurname
        {
            get
            {
                return itsDadsSurname;
            }
        }
        public override string ToString()
        {

            return itsValue;
        }
    }

}
