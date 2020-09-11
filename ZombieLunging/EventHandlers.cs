using System;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Object = UnityEngine.Object;
using UnityEngine;

namespace ZombieLunging
{
	public class EventHandlers
	{
		public Plugin plugin;
		public EventHandlers(Plugin plugin) => this.plugin = plugin;

		public void OnSetClass(ChangingRoleEventArgs ev)
		{
			if (ev.Player.Nickname == "Dedicated Server") return;

            if (ev.NewRole == RoleType.Scp0492) {
                if(ev.Player.GameObject.TryGetComponent(out PlayerSpeeds speed)) {
                    Log.Debug("Tried to add PlayerSpeeds component but player already has it.");
                } else {
                    Log.Debug("Added component to player.");
                    ev.Player.GameObject.AddComponent<PlayerSpeeds>();
                }

                if(ev.Player.GameObject.TryGetComponent(out CustomZombie cz)) {
                    Log.Debug("Tried to add CustomZombie component but player already has it.");
                } else {
                    Log.Debug("Added component to player.");
                    ev.Player.GameObject.AddComponent<CustomZombie>();
                }
            }
		}

		public void OnConsoleCommand(SendingConsoleCommandEventArgs ev)
		{
			if (ev.Player.Role != RoleType.Scp0492) return;

			if (plugin.Config.command.Contains(ev.Name))
			{
				if (ev.Player.ReferenceHub.GetComponent<CustomZombie>().cooldown > 0)
				{
					if (!string.IsNullOrEmpty(Plugin.instance.Config.LungeMessage)) ev.Player.Broadcast(1, Plugin.instance.Config.LungeCooldownMessage.Replace("{time}", Math.Round(ev.Player.ReferenceHub.GetComponent<CustomZombie>().cooldown).ToString()));

					Log.Info(ev.Player.ReferenceHub.GetComponent<CustomZombie>().cooldown > 0);
				}
				else if (!ev.Player.ReferenceHub.GetComponent<CustomZombie>().lunging)
				{
					if (!string.IsNullOrEmpty(Plugin.instance.Config.LungeMessage)) ev.Player.Broadcast(3, Plugin.instance.Config.LungeMessage);
					ev.Player.ReferenceHub.GetComponent<CustomZombie>().ActivateSpeedUp();
					ev.ReturnMessage = !string.IsNullOrEmpty(Plugin.instance.Config.LungeMessage) ? Plugin.instance.Config.LungeMessage : "Has activado tu arremetimiento!";
					ev.Color = "Green";
				}
				else
				{
					ev.ReturnMessage = "Estas listo para arremeter de nuevo!";
					ev.Color = "Red";
				}
			}
		}
	}
}