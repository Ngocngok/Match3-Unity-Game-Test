using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    protected override string GetPrefabName()
    {
        string prefabname = string.Empty;
        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_ONE;
                break;
            case eNormalType.TYPE_TWO:
                prefabname = Constants.PREFAB_NORMAL_TYPE_TWO;
                break;
            case eNormalType.TYPE_THREE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_THREE;
                break;
            case eNormalType.TYPE_FOUR:
                prefabname = Constants.PREFAB_NORMAL_TYPE_FOUR;
                break;
            case eNormalType.TYPE_FIVE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_FIVE;
                break;
            case eNormalType.TYPE_SIX:
                prefabname = Constants.PREFAB_NORMAL_TYPE_SIX;
                break;
            case eNormalType.TYPE_SEVEN:
                prefabname = Constants.PREFAB_NORMAL_TYPE_SEVEN;
                break;
        }

        return prefabname;
    }

    public override void SetView()
    {
        base.SetView();

        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                itemVisual.SetVisual(currentSkinSet.normalItemSkins[0]);
                break;
            case eNormalType.TYPE_TWO:
                itemVisual.SetVisual(currentSkinSet.normalItemSkins[1]);
                break;
            case eNormalType.TYPE_THREE:
                itemVisual.SetVisual(currentSkinSet.normalItemSkins[2]);
                break;
            case eNormalType.TYPE_FOUR:
                itemVisual.SetVisual(currentSkinSet.normalItemSkins[3]);
                break;
            case eNormalType.TYPE_FIVE:
                itemVisual.SetVisual(currentSkinSet.normalItemSkins[4]);
                break;
            case eNormalType.TYPE_SIX:
                itemVisual.SetVisual(currentSkinSet.normalItemSkins[5]);
                break;
            case eNormalType.TYPE_SEVEN:
                itemVisual.SetVisual(currentSkinSet.normalItemSkins[6]);
                break;
        }

    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}
