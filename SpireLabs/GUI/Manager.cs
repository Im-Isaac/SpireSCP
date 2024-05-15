﻿using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using SpireLabs.GUI;

namespace SpireSCP.GUI.API.Features
{
    public partial class Manager
    {
        /// <summary>
        /// Sends a global message for either joining or leaving.
        /// </summary>
        /// <param name="Player">The Player who joined or left.</param>
        /// <param name="LeaveOrJoin">Use "l" to specify a leave event and "j" to specify a join event</param>
        public static void SendJoinLeave(Player Player, char LeaveOrJoin)
        {
            if (char.ToLower(LeaveOrJoin) == 'l')
            {
                Timing.RunCoroutine(guiHandler.sendJoinLeave(Player, 'l'));
            }
            else if (char.ToLower(LeaveOrJoin) == 'j')
            {
                Timing.RunCoroutine(guiHandler.sendJoinLeave(Player, 'j'));
            }
        }
        /// <summary>
        /// Sends a specific player a hint.
        /// </summary>
        /// <param name="Player">The Player to send a hint to.</param>
        /// <param name="Hint">The text to display to that player.</param>
        /// <param name="Time">The amount of time that hint should be displayed for.</param>
        public static void SendHint(Player Player, string Hint, float Time)
        {
            Timing.RunCoroutine(guiHandler.sendHint(Player, Hint, Time));
        }


        /// <summary>
        /// Sets a global modifier for all players.
        /// </summary>
        /// <param name="pos">Which modifier to set (0-6)</param>
        /// <param name="text">The text to display for that modifier.</param>
        public static void setModifier(int pos, string text)
        {
            guiHandler.modifiers[pos] = text;
        }
    }
}
