using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Button : MonoBehaviour
{
    public InputField inputFieldComponent;
    public Text TextComponent;
    public void OnClic_SetText()
    {
        TextComponent.text = inputFieldComponent.text; // ��ư�� �������� �Լ� ȣ��
    }
   
}
