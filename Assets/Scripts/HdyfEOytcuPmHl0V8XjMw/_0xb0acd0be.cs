using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xb0acd0be : MonoBehaviour
{
    private const float MinRatio = 4.5f;
    private const float MinOutlineWidth = 0.01f;
    private static void Fix(TMP_Text _0x179b8c4a)
    {
        if (_0x179b8c4a == null || !_0x179b8c4a.isActiveAndEnabled)
            return;
        Material _0x38bc39bb = _0x179b8c4a.fontSharedMaterial;
        if (_0x38bc39bb == null || !_0x38bc39bb.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x38bc39bb.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x38bc39bb.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x08fd76c2 = _0x179b8c4a.color;
        if (_0x08fd76c2.a <= 0f)
            return;
        Color _0xd3a890c1 = _0x38bc39bb.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x08fd76c2, _0xd3a890c1) >= MinRatio)
            return;
        Color _0x9f816533 = Luminance(_0xd3a890c1) < 0.5f ? Color.white : Color.black;
        Color _0xd13c26f8;
        if (Ratio(_0x9f816533, _0xd3a890c1) < TargetRatio)
        {
            _0xd13c26f8 = _0x9f816533;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x28d92574 = 0f;
            float _0x416dc5ae = 1f;
            for (int _0x54eea3f4 = 0; _0x54eea3f4 < 20; _0x54eea3f4++)
            {
                float _0xd5afc992 = (_0x28d92574 + _0x416dc5ae) * 0.5f;
                if (Ratio(Color.Lerp(_0x08fd76c2, _0x9f816533, _0xd5afc992), _0xd3a890c1) >= TargetRatio)
                    _0x416dc5ae = _0xd5afc992;
                else
                    _0x28d92574 = _0xd5afc992;
            }

            _0xd13c26f8 = Color.Lerp(_0x08fd76c2, _0x9f816533, _0x416dc5ae);
        }

        _0xd13c26f8.a = _0x08fd76c2.a;
        _0x179b8c4a.color = _0xd13c26f8;
    }

    private void OnEnable()
    {
        if (this._0xe703e848 == null)
            this._0xe703e848 = _0x7e0cef9e => this._0xce282abb(_0x7e0cef9e);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xe703e848);
    }

    private readonly List<TMP_Text> _0xededaf65 = new List<TMP_Text>();
    private readonly HashSet<TMP_Text> _0x8514816b = new HashSet<TMP_Text>();
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xdc0abe8d)
    {
        return 0.2126f * Linear(_0xdc0abe8d.r) + 0.7152f * Linear(_0xdc0abe8d.g) + 0.0722f * Linear(_0xdc0abe8d.b);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xce282abb(Object _0xf9bfd662)
    {
        TMP_Text _0x681eb488 = _0xf9bfd662 as TMP_Text;
        if (_0x681eb488 != null)
            this._0x8514816b.Add(_0x681eb488);
    }

    private void LateUpdate()
    {
        if (this._0x8514816b.Count == 0)
            return;
        this._0xededaf65.Clear();
        this._0xededaf65.AddRange(this._0x8514816b);
        this._0x8514816b.Clear();
        for (int _0x74a588a5 = 0; _0x74a588a5 < this._0xededaf65.Count; _0x74a588a5++)
            Fix(this._0xededaf65[_0x74a588a5]);
    }

    private static float Linear(float _0x1e7f9f12)
    {
        _0x1e7f9f12 = Mathf.Clamp01(_0x1e7f9f12);
        return _0x1e7f9f12 <= 0.03928f ? _0x1e7f9f12 / 12.92f : Mathf.Pow((_0x1e7f9f12 + 0.055f) / 1.055f, 2.4f);
    }

    private static float Ratio(Color _0x10082b78, Color _0x33574214)
    {
        float _0x1e9af9b2 = Luminance(_0x10082b78);
        float _0x58576a58 = Luminance(_0x33574214);
        return (Mathf.Max(_0x1e9af9b2, _0x58576a58) + 0.05f) / (Mathf.Min(_0x1e9af9b2, _0x58576a58) + 0.05f);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xe703e848;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xbef0aa81 != null)
            return;
        GameObject _0xa4a0c4d0 = new GameObject(_0xb3c8db6c._0xfd0d806c(new byte[16] { 61, 4, 25, 42, 6, 7, 29, 27, 8, 26, 29, 46, 28, 8, 27, 13 }, 105));
        _0xa4a0c4d0.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xa4a0c4d0);
        _0xbef0aa81 = _0xa4a0c4d0.AddComponent<_0xb0acd0be>();
    }

    private static _0xb0acd0be _0xbef0aa81;
    private void OnDisable()
    {
        if (this._0xe703e848 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xe703e848);
    }

    private const float TargetRatio = 7f;
}

internal static class _0xb3c8db6c
{
    internal static string _0xfd0d806c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}