using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//挂在维修道具上
public class RepairItemInteract : MonoBehaviour
{
    public delegate void RepairTriggerEvent();
    public event RepairTriggerEvent OnRepairInteracted;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnRepairInteracted();
        }
    }

}
