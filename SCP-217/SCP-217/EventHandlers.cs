using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp914;
using UnityEngine;
using Random = System.Random;
using Object = UnityEngine.Object;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System.Collections.Generic;

namespace SCP_217
{
    public class EventHandlers
    {
        public void OnUpdaradingPlayer(UpgradingPlayerEventArgs ev)
        {
            var r = new Random();
            var ran_num = (double)r.NextDouble() * 100;
            if (ran_num <= Plugin.Instance.Config.InfectionChance && ev.Player.Role.Side != Side.Scp && ev.Player.GameObject.GetComponent<Infection>() == null)
            {
                ev.Player.GameObject.AddComponent<Infection>();
                Log.Info("Succesfull added component to " + ev.Player.Nickname);
            }
        }

        public void OnPlayerDied(DiedEventArgs ev)
        {         
            if (ev.Player.GameObject.GetComponent<Infection>() != null)
            {
                Object.Destroy(ev.Player.GameObject.GetComponent<Infection>());
            }
        }

        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            var crole = CustomRole.Get(3);        
            if (ev.Player.Role == crole.Role && ev.Player.GameObject.GetComponent<RoleComponent>() != null)
            {
                Object.Destroy(ev.Player.GameObject.GetComponent<RoleComponent>());
            }
        }

        public void OnPlayerUsedItem(UsedItemEventArgs ev)
        {
            if (ev.Item.Type == ItemType.SCP207 && ev.Player.GameObject.GetComponent<Infection>() != null)
            {
                Object.Destroy(ev.Player.GameObject.GetComponent<Infection>());
                ev.Player.Health = 100;
            }
        }
    }
}
