﻿using Player;
using System;

namespace GTFO_VR.Events
{
    /// <summary>
    /// Add event calls for locomotion events
    /// This currently only needs to describe the player entering the ladder but might be expanded later depending on the game's needs.
    /// </summary>
    public static class PlayerLocomotionEvents
    {
        public static event Action<LG_Ladder> OnPlayerEnterLadder;

        public static void LadderEntered(PlayerAgent owner)
        {
            if (OnPlayerEnterLadder != null && owner.IsLocallyOwned)
            {
                OnPlayerEnterLadder.Invoke(owner.Locomotion.CurrentLadder);
            }
        }
    }
}