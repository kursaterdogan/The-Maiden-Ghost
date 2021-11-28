using UnityEngine;

public class ScreenshotController : MonoBehaviour
{
    private int _counter;

    void Update()
    {
        TakeScreenshot();
    }

    private void TakeScreenshot()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ScreenCapture.CaptureScreenshot("Screenshot " + _counter + ".png");
            Debug.Log("Screenshot " + _counter);
            _counter++;
        }
    }
}