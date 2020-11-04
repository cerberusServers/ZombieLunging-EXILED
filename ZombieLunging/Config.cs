using Exiled.API.Interfaces;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZombieLunging
{
	public class Config : IConfig
	{
		[Description("Si el plugin esta activado o no")]
		public bool IsEnabled { get; set; } = true;
		[Description("Debug Mode is enable ?")]
		public bool IsDebug { get; set; } = false;
		[Description("Duracion del buffo al SCP-049-2")]
		public float LungeTime { get; set; } = 10;
		[Description("Por cuanto tiempo aplica slow el SCP-049-2")]
		public float SlowdownTime { get; set; } = 3;
		[Description("Por cuanto tiempo el SCP-049-2 estara cansado")]
		public float PenaltyTime { get; set; } = 8;
		[Description("Cantidad de Slow de la penalidad")]
		public float SlowdownAmount { get; set; } = 4;
		[Description("Mensaje del objetivo al ser golepeado por el SCP-049-2 al estar con el buffo")]
		public string VictimMessage { get; set; } = "<size=35><b> fuiste herido por un zombie, te moveras lento por unos segundos!</b></size>";
		[Description("Mensaje que le saldra al Zombie despues de acabar la habilidad")]
		public string PenaltyMessage { get; set; } = "<size=35><i><color=#F6EF07>Estas cansado, te moveras lento por un tiempo</color></i></size>";
		[Description("Mensaje que le dice al Zombie cuando activa la habilidad.")]
		public string LungeMessage { get; set; } = "<size=28><color=red>[</color><color=green>Zombie</color><color=red>]</color> <b>Brains...!!!</b>\n<i>haz recibido un <color=#0770F6>Aumento de velocidad</color></i></size>";
		[Description("Cuanto tiempo tarda en volver a tener la habilidad, despues de que termino el slow")]
		public float LungeCooldown { get; set; } = 10;
		[Description("Mensaje cuando intenta usar la habilidad en CD")]
		public string LungeCooldownMessage { get; set; } = "<size=25><color=red>[</color><color=green>Zombie</color><color=red>]</color><i>Sigues cansado como para volver a correr, tienes que descansar por <color=red><b>{time}</b></color> segundos, para poder volver a hacerlo.</i></size>";
		[Description("Intensidad de la cocacola que tiene la habilidad, ni idea como es esto")]
		public int ColaIntensity { get; set; } = 4;
		[Description("Comandos que activan la habilidad")]
        public List<string> command { get; set; } = new List<string> {
			"zr", "zombierun"
		};
		
	}
}
