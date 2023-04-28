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
        public string WarningHintMessage { get; set; } = "<size=35%><color=(COLOR)><b>(HINT)</b></color></size>";
    }
}
