using System;
using UnityEngine;

public class CaptureScreen : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log(Application.persistentDataPath);
            ScreenCapture.CaptureScreenshot($"Screenshot-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}.png");
            Debug.Log("Captured");
        }
    }
}
