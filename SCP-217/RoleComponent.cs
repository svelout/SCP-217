using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SCP_217
{
    public class RoleComponent : MonoBehaviour
    {
        private Player player;
        private void Awake()
        {
            player = Player.Get(gameObject);
        }        
    }
}
