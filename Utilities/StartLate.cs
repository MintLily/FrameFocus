using System.Collections;
using UnityEngine;
using UnityEngine.XR;

namespace FrameFocus.Utilities
{
    class StartLate
    {
        private static bool hasStartedLate;

        public static IEnumerator Init()
        {
            yield return new WaitForSeconds(6);
            hasStartedLate = true;
        }

        public static void OnUpdate()
        {
            if (!hasStartedLate)
                return;
            else
            {
                if (!FrameFocus.allowFrameLimit.Value) // false
                    return; // ends method
                else // true
                {
                    if (XRDevice.isPresent && !FrameFocus.allowVRUse.Value)
                        return;
                    if (Application.isFocused) // isFocused = If you are controlling the game a.k.a. if your mouse has been pressed onto the game
                    {
                        if (FrameFocus.override_emmVRC.Value && ModCompatibility.emmVRC) // ignored emmVRC integration
                            Application.targetFrameRate = (int)FrameFocus.FrameLimit.Value; // Sets game's FrameRate to Given Target FPS
                        else if (ModCompatibility.emmVRC)
                            Application.targetFrameRate = (int)GETemmVRCconfig.ReadConfig().FPSLimit;
                        else if (ModCompatibility.emmVRC && GETemmVRCconfig.ReadConfig().UnlimitedFPSEnabled)
                            Application.targetFrameRate = (int)300;
                        else
                            Application.targetFrameRate = (int)FrameFocus.FrameLimit.Value; // Sets game's FrameRate to Given Target FPS
                    }
                    else
                        Application.targetFrameRate = (int)5; // Sets game's FrameRate to 5 FPS
                }
            }
        }
    }
}
