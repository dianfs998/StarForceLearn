﻿using UnityEngine;

namespace UnityGameFramework.Runtime
{
    public partial class DebuggerComponent
    {
		private sealed class InputGyroscopeInformationWindow : ScrollableDebuggerWindowBase
        {
            protected override void OnDrawScrollableWindow()
            {
                GUILayout.Label("<b>Input Gyroscope Information</b>");
                GUILayout.BeginVertical("box");
                {
                    GUILayout.BeginHorizontal();
                    {
                        if (GUILayout.Button("Enable", GUILayout.Height(30f)))
                        {
                            Input.gyro.enabled = true;
                        }
                        if(GUILayout.Button("Disable", GUILayout.Height(30f)))
                        {
                            Input.gyro.enabled = false;
                        }
                    }
                    GUILayout.EndHorizontal();

                    DrawItem("Enable:", Input.gyro.enabled.ToString());
                    DrawItem("Update Interval:", Input.gyro.updateInterval.ToString());
                    DrawItem("Attitude:", Input.gyro.attitude.eulerAngles.ToString());
                    DrawItem("Gravity:", Input.gyro.gravity.ToString());
                    DrawItem("Rotation Rate:", Input.gyro.rotationRate.ToString());
                    DrawItem("Rotation Rate Unbiased:", Input.gyro.rotationRateUnbiased.ToString());
                    DrawItem("User Accelaration:", Input.gyro.userAcceleration.ToString());
                }
                GUILayout.EndVertical();
            }
        }
    }
}
