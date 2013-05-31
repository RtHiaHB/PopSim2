using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopSim2
{
    [Serializable()]
    public class Person
    {
        private HairColor myHair;
        private EyeColor myEyes;
        private Gender itsGender;
        private PopSim2.Size mySize;
        private Preferences myPrefs;
        private string myThoughtBubble;
        private Name MomsName;
        private Name DadsName;
        private List<Name> myChildrensNames;
        private Name myName;
        private double myAge;
        private bool itsPregnant=false;
        private double PregnancyTerm=0.0;
        private Person itsBabyDaddy;
        private bool itHadABaby = false;
        public bool Dead = false;
        private static Random r = new Random((int)DateTime.Now.Ticks);
        public Person()
        {
            myName = new Name(6);
            myEyes = NewEyes();
            myHair = NewHair();
            itsGender = NewGender();
            mySize = NewSize();
            myPrefs = new Preferences();
            myThoughtBubble = NewThoughts();
            myAge = 18.0;
            MomsName = new Name(3);
            DadsName = new Name(3);
            myChildrensNames = new List<Name>();
        }
        public Person(Person mom, Person dad)
        {
            myName = new Name(mom.Name, dad.Name);
            myEyes = NewEyes(mom.Eyes, dad.Eyes);
            myHair = NewHair(mom.Hair, dad.Hair);
            itsGender = NewGender();
            mySize = NewSize(mom.Size, dad.Size);
            if (itsGender == Gender.Male)
            {
                myPrefs = new Preferences(mom);
            }
            else
            {
                myPrefs = new Preferences(dad);
            }
            myAge = 0.0;
            MomsName = mom.Name;
            DadsName = dad.Name;
            myChildrensNames = new List<PopSim2.Name>();
            mom.NewChild(this);
            dad.NewChild(this);
            myThoughtBubble = NewThoughts(mom, dad);
        }
        public void NewChild(Person child)
        {
            myThoughtBubble+="\nMy new child is " + child.ToString();
            myChildrensNames.Add(child.Name);
        }
        private EyeColor NewEyes()
        {
            int t;
            EyeColor e;
            t = r.Next(0, 100);
            if (t <= 50)
            {
                e = EyeColor.Brown;
            }
            else if (t < 85)
            {
                e = EyeColor.Blue;
            }
            else
            {
                e = EyeColor.Hazel;
            }
            return e;
        }
        private EyeColor NewEyes(EyeColor MomsEyes, EyeColor DadsEyes)
        {
            int t;
            EyeColor e=EyeColor.Brown;
            if (MomsEyes == EyeColor.Blue && DadsEyes == EyeColor.Blue)
            {
                e = EyeColor.Blue;
            }
            else if (MomsEyes == EyeColor.Hazel || DadsEyes == EyeColor.Hazel)
            {
                t = r.Next(0, 2);
                if (t == 0)
                {
                    e = MomsEyes;
                }
                else
                {
                    e = DadsEyes;
                }
            }
            else
            {
                e = EyeColor.Brown;
            }
            return e;
        }
        private HairColor NewHair()
        {
            HairColor h;
            int t;
            t = r.Next(0, 100);
            if (t <= 50)
            {
                h = HairColor.Brown;
            }
            else if (t <= 75)
            {
                h = HairColor.Blonde;
            }
            else if (t <= 90)
            {
                h = HairColor.Black;
            }
            else
            {
                h = HairColor.Red;
            }
            return h;
        }
        private HairColor NewHair(HairColor MomsHair, HairColor DadsHair)
        {
            int t;
            HairColor h = HairColor.Brown;
            if (MomsHair == HairColor.Blonde && DadsHair == HairColor.Blonde)
            {
                h = HairColor.Blonde;
            }
            else if (MomsHair == HairColor.Red || DadsHair == HairColor.Red)
            {
                t = r.Next(0, 2);
                if (t == 0)
                {
                    h = MomsHair;
                }
                else
                {
                    h = DadsHair;
                }
            }
            else if (MomsHair == HairColor.Black || DadsHair == HairColor.Black)
            {
                t = r.Next(0, 2);
                if (t == 0)
                {
                    h = MomsHair;
                }
                else
                {
                    h = DadsHair;
                }

            }
            else
            {
                h = HairColor.Brown;
            }
            return h;
        }
        private Gender NewGender()
        {
            int t;
            t = r.Next(0, 2);
            return (Gender)t;
        }
        private PopSim2.Size NewSize()
        {
            int t;
            Size s;
            t = r.Next(0, 100);
            if (t <= 50)
            {
                s = Size.Medium;
            }
            else if(t<=75)
            {
                s = Size.Large;
            }
            else
            {
                s = Size.Small;
            }
            return s;
        }
        private PopSim2.Size NewSize(PopSim2.Size MomsSize, PopSim2.Size DadsSize)
        {
            PopSim2.Size s;
            int t;
            if (MomsSize == PopSim2.Size.Small && DadsSize == PopSim2.Size.Small)
            {
                s = PopSim2.Size.Small;
            }
            else if (MomsSize == PopSim2.Size.Large || DadsSize == PopSim2.Size.Large)
            {
                t = r.Next(0, 1);
                if (t == 0)
                {
                    s = MomsSize;
                }
                else
                {
                    s = DadsSize;
                }
            }
            else
            {
                s = PopSim2.Size.Medium;
            }
            return s;
        }
        public HairColor Hair
        {
            get
            {
                return myHair;
            }
        }
        public EyeColor Eyes
        {
            get
            {
                return myEyes;
            }
        }
        public PopSim2.Size Size
        {
            get
            {
                return mySize;
            }
        }
        public Name Name
        {
            get
            {
                return myName;
            }
        }
        public Gender GetGender
        {
            get
            {
                return itsGender;
            }
        }
        public Preferences Prefs
        {
            get
            {
                return myPrefs;
            }
        }
        public double Age
        {
            get
            {
                return myAge;
            }
        }
        public string Thoughts
        {
            get
            {
                return myThoughtBubble;
            }
        }
        private string NewThoughts()
        {
            Gender genpref;
            HairColor hairpref=HairColor.Blonde;
            int hairprefbon=-7;
            EyeColor eyepref=EyeColor.Blue;
            int eyeprefbon=-7;
            Size sizepref=PopSim2.Size.Small;
            int sizeprefbon=-7;
            string thought="";
            if (GetGender == Gender.Male)
            {
                genpref = Gender.Female;
            }
            else
            {
                genpref = Gender.Male;
            }
            for (int i = 0; i < (int)HairColor.Red; i++)
            {
                if (myPrefs.Hair((HairColor)i) > hairprefbon)
                {
                    hairpref = (HairColor)i;
                    hairprefbon = myPrefs.Hair((HairColor)i);
                }
            }
            for (int i = 0; i < (int)EyeColor.Hazel; i++)
            {
                if (myPrefs.Eyes((EyeColor)i) > eyeprefbon)
                {
                    eyepref = (EyeColor)i;
                    eyeprefbon = myPrefs.Eyes((EyeColor)i);
                }
            }
            for (int i = 0; i < (int)PopSim2.Size.Large; i++)
            {
                if (myPrefs.Size((PopSim2.Size)i) > sizeprefbon)
                {
                    sizeprefbon = myPrefs.Size((PopSim2.Size)i);
                    sizepref = (PopSim2.Size)i;
                }
            }
            thought += "My Name is " + this.Name.ToString();
            thought += "\nI am a " + this.GetGender.ToString("F");
            thought += "\nI have " + this.Hair.ToString("F") + " hair, " +
                this.Eyes.ToString("F") + " eyes, and I am " + this.Size.ToString("F");
            thought += "\nI like " + genpref.ToString("F") + "s with " + hairpref.ToString("F") +
                " hair, " + eyepref.ToString("F") + " eyes and are " + sizepref.ToString("F");
            return thought;
        }
        private string NewThoughts(Person mom, Person dad)
        {
            string temp = NewThoughts();
            temp += "\nMy mother is " + mom.Name.ToString() + " and my father is " + dad.Name.ToString();
            return temp;
        }
        public void Next(double vDate)
        {
            double DeathChances;
            double x;
            int roll;
            myAge += 0.1;
            if (itsPregnant)
            {
                PregnancyTerm += 0.1;
                if (PregnancyTerm >= 1.0)
                {
                    itHadABaby = true;
                    PregnancyTerm = 0.0;
                    itsPregnant = false;
                }
            }
            x = ((myAge - 36) / 7.0) / Math.E;
            DeathChances = (11.0 - (1 / Math.Pow(Math.E, Math.Pow(x, 2))) * 10.0) * 50;
            roll = r.Next(0, 100000);
            if (roll <= (int)DeathChances)
            {
                this.Dead = true;
            }
            myThoughtBubble += "\n-------------------";
            myThoughtBubble += "\nDate: " + vDate.ToString("F1");
            myThoughtBubble += "\nI am " + this.Age.ToString("F1") + " years old.";
            if (itsPregnant)
            {
                myThoughtBubble += "\nI am " + PregnancyTerm.ToString("F1") + " months pregnant.";

            }
            if (itHadABaby)
            {
                myThoughtBubble += "I just had a baby.";
            }
            if (Dead)
            {
                myThoughtBubble += "I just died.";
            }
        }
        public bool HadABaby
        {
            get
            {
                bool b = itHadABaby;
                itHadABaby = false;
                return b;
            }
        }
        public bool MateableAge()
        {
            bool t;
            if (myAge >= 13.0)
            {
                t = true;
            }
            else
            {
                t = false;
            }
            return t;
        }
        public bool MateableGender(Gender MyGender)
        {
            bool t = false;
            if ((itsGender == Gender.Male && MyGender == Gender.Female) ||
                (itsGender == Gender.Female && MyGender == Gender.Male))
            {
                t = true;
            }
            return t;
        }
        public bool Pregnant
        {
            get
            {
                return itsPregnant;
            }
        }
        public bool DoYouLikeMe(Person PotentialMate)
        {
            int roll;
            int HairBonus;
            int EyesBonus;
            int SizeBonus;
            int total;
            bool temp;
            HairBonus = myPrefs.Hair(PotentialMate.Hair);
            EyesBonus = myPrefs.Eyes(PotentialMate.Eyes);
            SizeBonus = myPrefs.Size(PotentialMate.Size);
            roll = r.Next(1, 21);
            total = roll + HairBonus + EyesBonus + SizeBonus;
            myThoughtBubble += "\nThe like roll was " + total.ToString() + " (" + PotentialMate.Name.ToString() + ")";
            myThoughtBubble += "\nHair bonus: " + HairBonus.ToString();
            myThoughtBubble += "; Eyes bonus: " + EyesBonus.ToString();
            myThoughtBubble += "; Size Bonus: " + SizeBonus.ToString();
            if (total >= 10)
            {
                temp = true;
            }
            else
            {
                temp = false;
            }
            return temp;
        }
        public void Meet(Person OtherPerson)
        {
            //checks for mateable compatibility
            //the potential mate must be of the appropriate age, and they
            //must meet preferential criteria.
            bool comp = false;
            myThoughtBubble += "\nI met " + OtherPerson.Name.ToString();
            //[FIXME]
            if (!OtherPerson.Pregnant && OtherPerson.MateableAge() &&
                this.MateableGender(OtherPerson.GetGender) &&
                !this.Pregnant && this.MateableAge())
            {
                comp = OtherPerson.DoYouLikeMe(this) && this.DoYouLikeMe(OtherPerson);
            }
            else
            {
                comp = false;
            }
            if (comp == true)
            {
                myThoughtBubble += "\nWe liked each other.";
                if (itsGender == Gender.Male)
                {
                    OtherPerson.Impregnate(this);
                }
                else
                {
                    this.Impregnate(OtherPerson);
                }
            }
            else
            {
                myThoughtBubble += "\nWe were not compatible.";
            }


        }
        public void Impregnate(Person vBabyDaddy)
        {
            //if the social criteria are met, there is a 1:10 chance
            //of making a baby.
            myThoughtBubble += "\n" + vBabyDaddy.Name.ToString() + " tried to impregnate me.";
            int b = r.Next(0, 10);
            if (b == 0)
            {
                itsPregnant = true;
                PregnancyTerm = 0.0;
                itsBabyDaddy = vBabyDaddy;
                myThoughtBubble += "\nWe were successful.";
            }
            else
            {
                myThoughtBubble += "\nWe were not successful.";

            }
        }
        public Person BabyDaddy
        {
            get
            {
                Person bd;
                try
                {
                    bd = itsBabyDaddy;
                }
                catch (NullReferenceException exc)
                {
                    return null;
                }
                return itsBabyDaddy;
            }
        }
        public List<Name> Children
        {
            get
            {
                return myChildrensNames;
            }
        }
        public override string ToString()
        {
            string ps = "";
            if (itsPregnant)
            {
                try
                {
                    ps = "* (" + itsBabyDaddy.Name.ToString() + ", " + PregnancyTerm.ToString("F1") + ")";

                }
                catch (NullReferenceException exc)
                {
                    ps = "";
                }
            }
            return myName.ToString() + ", " + itsGender.ToString() + ps + ", " + this.Age.ToString("F1");
        }
        public Name FatherName
        {
            get
            {
                return DadsName;
            }
        }
        public Name MotherName
        {
            get
            {
                return MomsName;
            }
        }
    }
}
