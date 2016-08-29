using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Iterable : IEnumerable
    {
        private List<string> songs;
        private List<string> singers;



        public Iterable()//constructor
        {

            this.songs = songs = new List<string>() { "Girl on Fire", "Surrender", "Still The Night" };
            this.singers = singers = new List<string>() { "Alicia Keys", "Angels & AirWaves", "BoDeans" };

        }
        public IEnumerator GetEnumerator()
        {

            for (int i = 0; i < songs.Count; i++)
            {

                yield return songs[i];
                yield return " by ";
                yield return singers[i];
                yield return "\n";
            }

        }
        public override string ToString()
        {
            return this.songs + " by " + this.singers;

        }


    }//class
}//namespace
