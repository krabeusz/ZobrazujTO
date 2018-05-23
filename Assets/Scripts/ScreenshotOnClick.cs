using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotOnClick : MonoBehaviour {

    public void TakeScreenshot()
    {
        ScreenCapture.CaptureScreenshot("ZdjecieZobrazujTO");
    }
}
