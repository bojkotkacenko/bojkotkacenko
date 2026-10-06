using TMPro;
using UnityEngine;

/// Every TMP label this game builds at runtime goes through here.
/// Stage 5c3 only reads labels serialized into scenes and prefabs, so runtime text
/// owns its own readability: a private material instance with a contrasting outline
/// (rule C.10), word wrap OFF, hand-placed line breaks, autosize ON with the UGUI
/// readability floor as its minimum (rule C.12).
public static class _0xf6b60f03
{
    public static void Apply(TMP_Text _0xea08ba5d, Color _0x4fa81217, float _0x1fd74e4a)
    {
        if (_0xea08ba5d == null)
            return;
        _0xea08ba5d.color = _0x4fa81217;
        _0xea08ba5d.textWrappingMode = TextWrappingModes.NoWrap;
        _0xea08ba5d.overflowMode = TextOverflowModes.Overflow;
        _0xea08ba5d.enableAutoSizing = true;
        _0xea08ba5d.fontSizeMin = FloorSize;
        _0xea08ba5d.fontSizeMax = Mathf.Max(FloorSize, _0x1fd74e4a);
        _0xea08ba5d.fontSize = Mathf.Max(FloorSize, _0x1fd74e4a);
        ApplyOutline(_0xea08ba5d, _0x4fa81217);
    }

    public const float FloorSize = 30f;
    /// Line breaks are placed by hand, never by the engine (rule C.10).
    public static void SetText(TMP_Text _0x88c27bbb, string _0x2ca88dad)
    {
        if (_0x88c27bbb != null)
            _0x88c27bbb.text = _0x2ca88dad;
    }

    /// A light face gets the dark garden outline, a (rare) dark face gets a cream one.
    /// Reading fontMaterial creates an INSTANCE, so the shared font asset is untouched.
    public static void ApplyOutline(TMP_Text _0x49d0031c, Color _0x6940606b)
    {
        if (_0x49d0031c == null)
            return;
        Material _0x66dfa087 = _0x49d0031c.fontMaterial;
        if (_0x66dfa087 == null)
            return;
        float _0xfedaa38a = 0.299f * _0x6940606b.r + 0.587f * _0x6940606b.g + 0.114f * _0x6940606b.b;
        Color _0x0fec6f8b = _0xfedaa38a < 0.5f ? _0xe94e3611.Cream : _0xe94e3611.Outline;
        _0x66dfa087.EnableKeyword(_0xd07a4c16._0xac1cc06a(new byte[10] { 37, 63, 62, 38, 35, 36, 47, 53, 37, 36 }, 106));
        _0x66dfa087.SetColor(ShaderUtilities.ID_OutlineColor, _0x0fec6f8b);
        _0x66dfa087.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.20f);
        _0x66dfa087.SetFloat(ShaderUtilities.ID_FaceDilate, 0.16f);
    }
}

internal static class _0xd07a4c16
{
    internal static string _0xac1cc06a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}