using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque
{
    class BiblioTab : Bibliotheque
    {
        private List<Ouvrage> ouvrageList;
        public BiblioTab(List<Ouvrage> ouvrageList)
        {
            this.ouvrageList = ouvrageList; 
        }
        public override List<Ouvrage> getOuvrageList()
        {
            return ouvrageList;
        }

        public override void setOuvrageList(List<Ouvrage> ouvrageList)
        {
            this.ouvrageList = ouvrageList;
        }

        public override Boolean addOuvrage(Ouvrage o)
        {
            ouvrageList.Add(o);
            return true;
        }


        public override Boolean delOuvrage(Ouvrage o)
        {
            if (ouvrageList.Contains(o))
            {
                ouvrageList.Remove(o);
                return true;
            }
            return false;
        }

        public override String ToString()
        {
            String s = "";
            int i = 0;
            foreach (Ouvrage o in ouvrageList)
            {
                s += "\t " + i++ + " - " + o.ToString();
            }
            return s;
        }

    }
}
