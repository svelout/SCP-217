using Exiled.API.Features.Attributes;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs.Player;

namespace SCP_217
{
    public class SCP_217_6 : CustomRole
    {
        public override string Name { get; set; } = "SCP-217-6";
        public override string Description { get; set; } = "Victim of SCP-217";
        public override uint Id { get; set; } = 3;
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp0492;
        public override int MaxHealth { get; set; } = 1000;
        public override string CustomInfo { get; set; } = "SCP-217-6";        
    }
}
