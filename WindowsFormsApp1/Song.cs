using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoInterface
{
    public abstract class Song
    {
        private string _name;

        public Song (string name)
        {
            _name = name;
        }

        public abstract void PlaySong();

        public string Name
        {
            get {
                return _name;
            }
            set {
                _name = value;
            }
           
        }
    }
}
