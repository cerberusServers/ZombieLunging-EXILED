using Exiled.API.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace ZombieLunging
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;

		public float LungeTime { get; set; } = 10;
		public float SlowdownTime { get; set; } = 3;
		public float PenaltyTime { get; set; } = 8;
		public float SlowdownAmount { get; set; } = 4;
		public string VictimMessage { get; set; } = "<size=35><b> fuiste herido por un zombie, te moveras lento por unos segundos!</b></size>";
		public string PenaltyMessage { get; set; } = "<size=35><i><color=#F6EF07>Estas cansado, te moveras lento por un tiempo</color></i></size>";
		public string LungeMessage { get; set; } = "<size=28><color=red>[</color><color=green>Zombie</color><color=red>]</color> <b>Brains...!!!</b>\n<i>haz recibido un <color=#0770F6>Aumento de velocidad</color></i></size>";
		public float LungeCooldown { get; set; } = 10;
		public string LungeCooldownMessage { get; set; } = "Sigues cansado como para volver a correr, tienes que esperar <color=#ff0000>{time}</color> segundos para volver a correr.";
		public int ColaIntensity { get; set; } = 4;
        public List<string> command { get; set; } = new List<string> {
			"zr", "zombierun"
		};
		
	}
}
