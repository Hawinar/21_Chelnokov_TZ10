using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsView : MonoBehaviour
{
    [SerializeField] private Camera m_Camera;

    [SerializeField] private Button _color1Btn;
    [SerializeField] private Button _color2Btn;
    [SerializeField] private Button _color3Btn;
    void Start()
    {
        _color1Btn.onClick.AddListener(() => ChangeColor(_color1Btn));
        _color2Btn.onClick.AddListener(() => ChangeColor(_color2Btn));
        _color3Btn.onClick.AddListener(() => ChangeColor(_color3Btn));
    }
    private void ChangeColor(Button button)
    {
        m_Camera.backgroundColor = button.image.color;
    }
}
