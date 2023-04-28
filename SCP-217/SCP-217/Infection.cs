using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;
using System.Collections.Generic;
using UnityEngine;
using Player = Exiled.API.Features.Player;

namespace SCP_217
{
    public class Infection : MonoBehaviour
    {
        private double maxhealthpr = Plugin.Instance.Config.healthp;
        private Player player;
        public bool IsStop = false;
        CoroutineHandle[] coroutines = new CoroutineHandle[1];
        private void Awake()
        {
            player = Player.Get(gameObject); 
            coroutines[0] = Timing.RunCoroutine(ShowHint());
        }
        private void OnDisable()
        {
            IsStop = true;
        }

        private IEnumerator<float> ShowHint()
        {
            int seconds = 0;
            int minutes = Plugin.Instance.Config.MinutesToDie;
            for (float sec = minutes * 60; sec > 0; sec--)
            {
                if (IsStop) yield break;
                seconds = (seconds == 60) ? --seconds : seconds;
                player.ShowHint(Plugin.Instance.Translation.WarningHintMessage
                    .Replace("(COLOR)", player.Role.Color.ToHex())
                    .Replace("(HINT)", "Внимание, вас охватил SCP-217\n" +
                    $"Вы начнете умирать через {minutes}:{((seconds < 10) ? $"0{seconds}" : seconds)}"), 1.3f);
                yield return Timing.WaitForSeconds(1f);
                minutes = (seconds == 0) ? --minutes : minutes;
                seconds = (seconds == 0) ? 60 : seconds;
                seconds--;
            }
            coroutines[1] = Timing.RunCoroutine(QuiteDead());
        } 

        private IEnumerator<float> QuiteDead()
        {
            player.ShowHint(Plugin.Instance.Translation.WarningHintMessage
                    .Replace("(COLOR)", player.Role.Color.ToHex())
                    .Replace("(HINT)", "ВЫ УМИРАЕТЕ!!!"), 3.2f);
            for (; ;)
            {
                if (IsStop) break;
                player.EnableEffect(EffectType.Stained,0.3f);
                if (player.Health <= (float)maxhealthpr / 100 * 100 && player.IsAlive)
                {
                    SCP_217_6 e = new();
                    if (player.Role.Side != Side.Scp)
                    {
                        if (player.GameObject.GetComponent<Infection>() != null)
                        {   
                            Destroy(player.GameObject.GetComponent<Infection>());
                            e.AddRole(player);
                            player.GameObject.AddComponent<RoleComponent>();
                        }
                    }
                    yield break;
                }
                else player.Health -= (float)maxhealthpr / 100 * 100;
                player.ShowHint(Plugin.Instance.Translation.WarningHintMessage
                    .Replace("(COLOR)", player.Role.Color.ToHex())
                    .Replace("(HINT)", "ВЫ УМИРАЕТЕ!!!"), 3.2f);
                yield return Timing.WaitForSeconds(3f);
            }
        }
    }
}
