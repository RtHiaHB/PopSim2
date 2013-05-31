using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopSim2
{
    [Serializable()]
    public class Preferences
    {
        private List<int> myHairPrefs;
        private List<int> myEyePrefs;
        private List<int> mySizePrefs;
        private static Random r = new Random((int)DateTime.Now.Ticks);
        public Preferences()
        {
            int t;
            myHairPrefs = new List<int>();
            myEyePrefs = new List<int>();
            mySizePrefs = new List<int>();
            //Hair preferences
            for (int i = 0; i < 4; i++)
            {
                t = r.Next(-5, 6);
                myHairPrefs.Add(t);
            }
            //bonus for blonde preferences
            myHairPrefs[(int)HairColor.Blonde] += 2;
            //Initialize eye preferences
            for (int i = 0; i < 3; i++)
            {
                t = r.Next(-5, 6);
                myEyePrefs.Add(t);
            }
            //bonus for blue eyes preferences
            myEyePrefs[(int)EyeColor.Blue] += 2;

            //Size preferences
            for (int i = 0; i < 3; i++)
            {
                t = r.Next(-5, 6);
                mySizePrefs.Add(t);
            }
        }
        public Preferences(Person ParentOfOppGender)
        {
            int t;
            Person POOG = ParentOfOppGender;
            myEyePrefs = new List<int>();
            myHairPrefs = new List<int>();
            mySizePrefs = new List<int>();
            //Hair prefs
            for (int i = 0; i < 4; i++)
            {
                t = r.Next(-5, 6);
                myHairPrefs.Add(t);

            }
            //bonus for blonde preferences
            myHairPrefs[(int)HairColor.Blonde] += 2;
            //bonus for parentage
            myHairPrefs[(int)POOG.Hair]++;
            //eye preferences
            for (int i = 0; i < 3; i++)
            {
                t = r.Next(-5, 6);
                myEyePrefs.Add(t);
            }
            //bonus for blue eyes preferences
            myEyePrefs[(int)EyeColor.Blue] += 2;
            //bonus for parentage
            myEyePrefs[(int)POOG.Eyes]++;
            //Size preferences
            for (int i = 0; i < 3; i++)
            {
                t = r.Next(-5, 6);
                mySizePrefs.Add(t);
            }
            //bonus for parentage
            mySizePrefs[(int)POOG.Size]++;
        }
        public int Size(PopSim2.Size s)
        {
            return mySizePrefs[(int)s];
        }
        public int Eyes(EyeColor e)
        {
            return myEyePrefs[(int)e];
        }
        public int Hair(HairColor h)
        {
            return myHairPrefs[(int)h];
        }
    }
}
