using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Character
    {
        public readonly int id;
        public readonly string account;
        public readonly string name;

        public Character(int id, string account, string name)
        {
            this.id = id;
            this.account = account;
            this.name = name;
        }
    }
}