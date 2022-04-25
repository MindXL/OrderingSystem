using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal sealed class Character
    {
        private static Character _c = null;

        public readonly int id;
        public readonly string account;
        public readonly string name;

        public Character(int id, string account, string name)
        {
            if (_c == null)
            {
                _c = this;

                this.id = id;
                this.account = account;
                this.name = name;
            }
            else
            {
                throw new Exception("Coder's fault");
            }
        }
    }
}