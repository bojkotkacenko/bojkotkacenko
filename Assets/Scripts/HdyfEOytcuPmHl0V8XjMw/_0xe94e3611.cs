using UnityEngine;

/// Colour table for the whole garden build. Values are the TROPICAL preset with the
/// brief's own accents. Every colour that can ever become TEXT is light on purpose:
/// one font material means one shared dark outline, so a dark face would merge into
/// its own outline (rule C.14).
public static class _0xe94e3611
{
    public static readonly Color Moss = new Color(0.1176f, 0.2392f, 0.1647f, 1f);
    public static readonly Color Cream = new Color(1f, 0.9647f, 0.8980f, 1f);
    public static Color WithAlpha(Color _0xa02ecdbc, float _0xc5177822)
    {
        return new Color(_0xa02ecdbc.r, _0xa02ecdbc.g, _0xa02ecdbc.b, _0xc5177822);
    }

    public static readonly Color Leaf = new Color(0.4863f, 0.7961f, 0.3569f, 1f);
    public static readonly Color NightGarden = new Color(0.0510f, 0.1569f, 0.0941f, 1f);
    public static Color Mix(Color _0xbf74aea2, Color _0x33737989, float _0xa8b9511d)
    {
        return Color.Lerp(_0xbf74aea2, _0x33737989, Mathf.Clamp01(_0xa8b9511d));
    }

    public static readonly Color Shadow = new Color(0.0235f, 0.0745f, 0.0353f, 1f);
    public static readonly Color Forest = new Color(0.0902f, 0.1882f, 0.1255f, 1f);
    public static readonly Color Coral = new Color(0.9333f, 0.4196f, 0.3333f, 1f);
    public static readonly Color White = new Color(1f, 1f, 1f, 1f);
    public static readonly Color CreamSoft = new Color(0.7882f, 0.8627f, 0.7529f, 1f);
    public static readonly Color Sun = new Color(0.9608f, 0.7686f, 0.3176f, 1f);
    public static readonly Color Outline = new Color(0.0627f, 0.1490f, 0.1020f, 1f);
    public static readonly Color LeafDeep = new Color(0.3059f, 0.6196f, 0.2627f, 1f);
    public static readonly Color Lilac = new Color(0.5529f, 0.4039f, 0.7804f, 1f);
}