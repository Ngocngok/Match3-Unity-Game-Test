using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemVisual : MonoBehaviour
{
    [SerializeField] private SpriteRenderer m_spriteRenderer;

    public void SetVisual(Sprite sprite)
    {
        m_spriteRenderer.sprite = sprite;
    }
}
