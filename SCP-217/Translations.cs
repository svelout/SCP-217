using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP_217
{
    public class Translations : ITranslation
    {
        [Description("Format of Hint")]
        public string HintMessage { get; set; } = "<size=35%><color=(COLOR)><b>(HINT)</b></color></size>";

        [Description("Format of Broadcast")]
        public string BroadcastMessage { get; set; } = "<color=(COLOR)<b>(BC)</b></color>";
    }
}
