using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorInteract : MonoBehaviour
{
    public delegate void GeneratorTriggerEvent();
    public event GeneratorTriggerEvent OnGeneratorInteracted;//在发电机进入下一状态时请调用

}
