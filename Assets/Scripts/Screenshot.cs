using UnityEngine;


public class Screenshot : MonoBehaviour
{
    private int count;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ScreenCapture.CaptureScreenshot("Screenshot " + count.ToString() + ".png");
            Debug.Log("Screenshot " + count.ToString());
            count++;
        }
    }
}