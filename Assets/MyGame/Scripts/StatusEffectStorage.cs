using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectStorage : MonoBehaviour
{
    public bool[] statusEffects;
    public string[] effectNames;
    public string effectText;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public string FetchStatus()
    {
        NoEffectsCheck();
        return effectText;
    }

    public void NoEffectsCheck()
    {
        for (int i = 0; i < statusEffects.Length; i++)
        {
            if (statusEffects[i])
            {
                GetEffects();
                break;
            }
        }
    }

    public void GetEffects()
    {
        for (int i = 0; i < statusEffects.Length; i++)
        {
            if (statusEffects[i])
            {
                AddEffects(effectNames[i]);
            }
        }
    }

    public void AddEffects(string newEffect)
    {
        if (effectText == "/")
        {
            effectText += "," + newEffect;
        }
        else
        {
            effectText = newEffect;
        }
    }

    public void Update()
    {
        //tired
        if (statusEffects[0])
        {

        }

        //hungry
        if (statusEffects[1])
        {

        }


        //late
        if (statusEffects[2])
        {

        }

        //energised
        if (statusEffects[3])
        {

        }
    }

}
