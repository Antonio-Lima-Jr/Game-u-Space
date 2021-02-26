using UnityEngine;
public class TouchManager : MonoBehaviour
{
    private Touch _touch;
    public TouchSO KnobLeft;
    public TouchSO KnobRight;


    private void OnEnable()
    {
  
    }
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                _touch = Input.GetTouch(i);

                switch (_touch.phase)
                {
                    case (TouchPhase.Began):
                        if (_touch.position.x < Screen.width/2 && _touch.position.y < Screen.height/2)
                        {
                            KnobLeft.setIDTouch(_touch.fingerId);
                            KnobLeft.setActive(true);
                            KnobLeft.setStartPosition(_touch.position);
                            //Debug.Log("TouchLeft: " + TouchPhase.Began);
                        }
                        if (_touch.position.x > Screen.width / 2 && _touch.position.y < Screen.height / 2)
                        {
                            KnobRight.setIDTouch(_touch.fingerId);
                            KnobRight.setActive(true);
                            KnobRight.setStartPosition(_touch.position);
                           // Debug.Log("TouchRight: " + TouchPhase.Began);
                        }
                        break;
                    case (TouchPhase.Moved):
                        if (KnobLeft.getIDTouch() == _touch.fingerId)
                        {
                            KnobLeft.setDirection(_touch.position);
                            //Debug.Log("TouchLeft: " + TouchPhase.Moved);
                        }
                        if (KnobRight.getIDTouch() == _touch.fingerId)
                        {
                            KnobRight.setDirection(_touch.position);
                            //Debug.Log("TouchRight: " + TouchPhase.Moved);
                        }
                        break;
                    case (TouchPhase.Ended):
                        if (KnobLeft.getIDTouch() == _touch.fingerId)
                        {
                            KnobLeft.setIDTouch(11);
                            KnobLeft.setDirection(Vector2.zero);
                            KnobLeft.setDelta(Vector2.zero);
                            KnobLeft.setStartPosition(Vector2.zero);
                            KnobLeft.setActive(false);
                            //Debug.Log("TouchLeft: " + TouchPhase.Ended);
                        }
                        if (KnobRight.getIDTouch() == _touch.fingerId)
                        {
                            KnobRight.setIDTouch(11);
                            KnobRight.setDirection(Vector2.zero);
                            KnobRight.setDelta(Vector2.zero);
                            KnobRight.setStartPosition(Vector2.zero);
                            KnobRight.setActive(false);
                            //Debug.Log("TouchRight: " + TouchPhase.Ended);
                        }
                        break;
                }
            }
            
        }
        
    }
}
