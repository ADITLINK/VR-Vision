using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//游戏进程脚本，HUD逻辑也可以写在这里
public class GameState : MonoBehaviour
{
    public List<GameObject> textItem;
    public int interactedNum = 0;
    public int threshold = 3;

    public GameObject generator;

    public GameObject repairItem;

    public int gamerState =0;//0游戏开始-找到发电机 1找到发电机-找到维修零件 2找到维修零件-修复发电机 3发电机修复-游戏结束
    
    
    bool isChoiceUITriggered = false;

    void Start()
    {
        for(int i = 0; i < textItem.Count; i++)
        {
            textItem[i].GetComponent<TextInteract>().OnTextInteracted += TextInteracted;
        }
        generator.GetComponent<generatorInteract>().OnGeneratorInteracted += GeneratorInteracted;
        repairItem.GetComponent<RepairItemInteract>().OnRepairInteracted += GeneratorInteracted;
        //HUD初始化逻辑可以写在这里
    }

    void TextInteracted()
    {
        interactedNum++;
        //文本数量UI更新逻辑可以写在这里
        if (interactedNum >= threshold&&!isChoiceUITriggered)
        {
            if(gamerState == 3)
            {
                isChoiceUITriggered = true;
                //离开还是回去的UI可以写在这里，然后在对应位置放两个触发器出发对应结局，其对应UI写在触发器脚本那里。或者另写脚本
            }

        }
    }
    void GeneratorInteracted()
    {
        gamerState++;
        switch (gamerState)
        {
            case 1:
                //提示找维修零件的HUD逻辑可以写在这里
                break;
            case 2:
                //提示维修发电机的HUD逻辑可以写在这里

                break;
            case 3:
                //提示找剩余文本的HUD逻辑可以写在这里
                break;
        }
    }

}
