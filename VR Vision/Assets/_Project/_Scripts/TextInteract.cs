using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//文本交互脚本
public class TextInteract : MonoBehaviour
{

    public delegate void TextTriggerEvent();
    public event TextTriggerEvent OnTextInteracted;//在文本被交互时请调用


}
