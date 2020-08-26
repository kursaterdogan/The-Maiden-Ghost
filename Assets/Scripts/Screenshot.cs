using UnityEngine;

public class Screenshot : MonoBehaviour
{
    private int _count;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ScreenCapture.CaptureScreenshot("Screenshot " + _count.ToString() + ".png");
            Debug.Log("Screenshot " + _count.ToString());
            _count++;
        }
    }
}