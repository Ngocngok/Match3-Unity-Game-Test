using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SkinConfig", menuName = "Configs/Skin", order = 1)]
public class SkinConfig : ScriptableObject
{
    [SerializeField] private SkinSet[] skinSet;

    public SkinSet GetSkinSet(int index)
    {
        SkinSet newSkinSet = new SkinSet();

        Sprite[] newSkins = new Sprite[skinSet[index].normalItemSkins.Length];

        for (int i = 0; i < skinSet[index].normalItemSkins.Length; i++)
        {
            newSkins[i] = skinSet[index].normalItemSkins[i];
        }

        newSkinSet.normalItemSkins = newSkins;

        return newSkinSet;
    }
}

[Serializable]
public class SkinSet
{
    public Sprite[] normalItemSkins;
    public Sprite[] bonusItemSkins;
}
