using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using scp914 = Exiled.Events.Handlers.Scp914;
using Player = Exiled.Events.Handlers.Player;
using System.Collections.Generic;
using Exiled.CustomRoles.API;
using System;

namespace SCP_217
{
    internal class Plugin : Plugin<Config, Translations>
    {
        public override string Author => "SveloutDevelop";
        public override string Name => "SCP-217";
        public override string Prefix => "217";
        public override Version Version => new(1, 0, 0);

        private List<SCP_217_6> scp = new()
        {
            new SCP_217_6()
        };
        private EventHandlers _eh;
        public static Plugin Instance;

        public override void OnEnabled()
        {
            Instance = this;
            OnRegister();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            OnUnRegister();
            base.OnDisabled();
        }

        public void OnRegister()
        {
            _eh = new EventHandlers();
            scp.Register();
            scp914.UpgradingPlayer += _eh.OnUpdaradingPlayer;
            Player.Died += _eh.OnPlayerDied;
            Player.ChangingRole += _eh.OnChangingRole;
            Player.UsedItem += _eh.OnPlayerUsedItem;
        }

        public void OnUnRegister()
        {
            _eh = null;
            CustomRole.UnregisterRoles();
            scp914.UpgradingPlayer -= _eh.OnUpdaradingPlayer;
            Player.Died -= _eh.OnPlayerDied;
            Player.ChangingRole -= _eh.OnChangingRole;
            Player.UsedItem -= _eh.OnPlayerUsedItem;
        }
    }
}
