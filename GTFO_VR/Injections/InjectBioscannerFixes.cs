﻿using Gear;
using GTFO_VR.Core.VR_Input;
using HarmonyLib;
using UnityEngine;

namespace GTFO_VR.Injections
{

    /// <summary>
    /// Makes Bioscanner render camera work off of gun pos/rot instead of player pos/rot
    /// </summary>
    [HarmonyPatch(typeof(EnemyScannerGraphics), nameof(EnemyScannerGraphics.UpdateCameraOrientation))]
    class InjectRenderBioScannerOffAimDir
    {
        static void Prefix(ref Vector3 position, ref Vector3 forward)
        {
            position = Controllers.GetAimFromPos();
            forward = Controllers.GetAimForward();
        }
    }

}
