using System;
using UnityEngine;
using UnityEngine.UI;

public class Knobs : MonoBehaviour
{
    private RawImage KnobRaw;
    public Color colorKnobActive;
    public Color colorKnobInactive;
    public TouchSO Knob;
    private RectTransform _rectTransform;

    void Start()
    {
        KnobRaw = GetComponent<RawImage>();
        _rectTransform = GetComponent<RectTransform>();
        
    }
    private void Update()
    {
        if (Knob.getActive())
        {
            knobPositionShader(Knob.getDelta());
            MudaCor(Knob.getActive());
        }
        else
        {
            MudaCor(Knob.getActive());
            knobPositionShader(Knob.getDelta());
        }
        
    }

    private void knobPositionShader(Vector2 delta)
    {
        Vector2 normalizedShaderPosition = delta / 70 * -1;
        if (normalizedShaderPosition.x > 1.2f || normalizedShaderPosition.x < -1.2f || normalizedShaderPosition.y > 1.2f || normalizedShaderPosition.y < -1.2f)
        {
            _rectTransform.pivot = normalizedShaderPosition.normalized * 1.2f;
        }
        else
        {
            _rectTransform.pivot = normalizedShaderPosition;
        }
    }

    public void MudaCor(bool knobBool)
    {
        if (knobBool)
        {
            KnobRaw.color = colorKnobActive;
        }
        else
        {
            KnobRaw.color = colorKnobInactive;
        }
    }
}
