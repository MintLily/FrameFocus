using System.Collections;
using UnityEngine;
using UnityEngine.XR;

namespace FrameFocus.Utilities;

public static class StartLateUtil {
    private static bool _hasStartedLate, _isInVr;
    
    public static IEnumerator Init() {
        yield return new WaitForSeconds(6);
        _hasStartedLate = true;
        _isInVr = XRDevice.isPresent;
    }

    public static void RunOnUpdate() {
        if (_isInVr) return;
        if (!_hasStartedLate) return;
        if (!Main.AllowFrameLimit.Value) return;
        if (QualitySettings.vSyncCount != 0) return; // Very helpful - https://docs.unity3d.com/ScriptReference/QualitySettings-vSyncCount.html
        
        Application.targetFrameRate = Application.isFocused ? Main.FrameLimit.Value : Main.FrameLimitUnfocused.Value;
    }
}
