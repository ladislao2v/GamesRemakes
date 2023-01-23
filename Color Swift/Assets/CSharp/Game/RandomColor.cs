using NTC.Global.Cache;
using System;
using UnityEngine;

public class RandomColor : MonoCache
{
    protected SpriteRenderer _spriteRenderer;

    [NonSerialized] public Color[] colorNames = new Color[4]
    {
        Color.cyan,
        Color.yellow,
        Color.red,
        Color.magenta
    };

    private void Awake()
    {
        _spriteRenderer = Get<SpriteRenderer>();
        _spriteRenderer.color = SetRandomColor();
    }

    public Color GetPlayerColor()
    {
        foreach (var color in colorNames)
            if (_spriteRenderer.color == color)
                return color;
        return Color.white;
    }

    public Color SetRandomColor()
    {
        return colorNames[UnityEngine.Random.Range(0, 3)];
    }
}
