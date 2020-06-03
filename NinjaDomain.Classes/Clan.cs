using System;
using System.Collections.Generic;

namespace EntityFramework
{
    public class Clan
    {
        public int Id { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninjas { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
