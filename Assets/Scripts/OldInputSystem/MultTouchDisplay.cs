using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MultTouchDisplay : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private int maxTapCount = 0;
    private string multTouchInfo;
    private Touch Touch;
    // Update is called once per frame
    void Update()
    {
        multTouchInfo = string.Format("Max tap count : {0}\n", maxTapCount);

        if (Input.touchCount > 0)
        {
           for (int i = 0; i < Input.touchCount; i++)
            {
                Touch = Input.GetTouch(i);

                multTouchInfo += string.Format("Touch {0} - Position {1} - Tap Count : {2} - Finger ID: {3}\nRadius: {4} ({5}%)\n",
                i , Touch.position, Touch.tapCount, Touch.fingerId, Touch.radius, ((Touch.radius/(Touch.radius + Touch.radiusVariance)) *100f ).ToString("F!"));
            if (Touch.tapCount > maxTapCount)
                {
                    maxTapCount = Touch.tapCount;
                }
            }
        }
        Text.text = multTouchInfo;
    }
}
