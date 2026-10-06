using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Small factory for every runtime UGUI node in the garden.
/// Draw order inside a canvas is sibling order, so callers build back to front:
/// plate first, then icon, then caption (rules C.13 and E.1).
public static class _0xd3e5c9ef
{
    public static Image Shade(Transform _0xa199b2e6, string _0xb80dd629, Color _0x98294583, Sprite _0xd9c57469)
    {
        RectTransform _0xb9586c89 = Sheet(_0xa199b2e6, _0xb80dd629);
        Image _0xa4995f3f = _0xb9586c89.gameObject.AddComponent<Image>();
        _0xa4995f3f.type = Image.Type.Sliced;
        _0xa4995f3f.sprite = _0xd9c57469;
        _0xa4995f3f.pixelsPerUnitMultiplier = 40f;
        _0xa4995f3f.color = _0x98294583;
        _0xa4995f3f.raycastTarget = true;
        return _0xa4995f3f;
    }

    public static Image Bar(Transform _0xb39a5fa0, string _0xc677c9b4, Vector2 _0x9c51e088, Vector2 _0x2217df19, Color _0xbe9e005b, Color _0xe45817cb, Sprite _0x9aa1f844, out Image _0x5b1e8cb7)
    {
        Image _0xd76998e3 = Plate(_0xb39a5fa0, _0xc677c9b4, _0x9c51e088, _0x2217df19, _0xbe9e005b, _0x9aa1f844);
        RectTransform _0x04e25905 = _0xd76998e3.rectTransform;
        GameObject _0xf08dda3c = new GameObject(_0xc677c9b4 + _0x32a229b8._0xe1a41e40(new byte[4] { 35, 12, 9, 9 }, 101), typeof(RectTransform));
        RectTransform _0x2d2f81ca = _0xf08dda3c.GetComponent<RectTransform>();
        _0x2d2f81ca.SetParent(_0x04e25905, false);
        // The anchor already sits on the track's LEFT edge, so anchoredPosition is
        // measured from there - a centre-anchored offset (-size.x/2) would push the
        // fill half a bar out to the left of its own track.
        _0x2d2f81ca.anchorMin = new Vector2(0f, 0.5f);
        _0x2d2f81ca.anchorMax = new Vector2(0f, 0.5f);
        _0x2d2f81ca.pivot = new Vector2(0f, 0.5f);
        _0x2d2f81ca.anchoredPosition = new Vector2(BarInset, 0f);
        _0x2d2f81ca.sizeDelta = new Vector2(_0x2217df19.x - 2f * BarInset, _0x2217df19.y - 2f * BarInset);
        _0x2d2f81ca.localScale = Vector3.one;
        Image _0x3743aebb = _0xf08dda3c.AddComponent<Image>();
        _0x3743aebb.type = Image.Type.Sliced;
        _0x3743aebb.sprite = _0x9aa1f844;
        _0x3743aebb.pixelsPerUnitMultiplier = PlateRoundness(new Vector2(_0x2217df19.y, _0x2217df19.y));
        _0x3743aebb.color = _0xe45817cb;
        _0x3743aebb.raycastTarget = false;
        _0x5b1e8cb7 = _0x3743aebb;
        return _0xd76998e3;
    }

    /// Padding between a bar's track and its fill, on every side.
    private const float BarInset = 4f;
    /// Square icon button (back, pause, close). No caption: the glyph is the label.
    public static Button IconAction(Transform _0x477c49cc, string _0x91983859, Vector2 _0xc991edad, Vector2 _0xba3e1111, Color _0x5c06d164, Color _0x988c519d, Sprite _0x9acae630, Sprite _0x73a30952)
    {
        RectTransform _0xa1c01945 = Node(_0x477c49cc, _0x91983859, _0xc991edad, _0xba3e1111);
        Image _0xef1d0834 = _0xa1c01945.gameObject.AddComponent<Image>();
        _0xef1d0834.type = Image.Type.Sliced;
        _0xef1d0834.sprite = _0x73a30952;
        _0xef1d0834.pixelsPerUnitMultiplier = PlateRoundness(_0xba3e1111);
        _0xef1d0834.color = _0x5c06d164;
        _0xef1d0834.raycastTarget = true;
        Vector2 _0xadd0d1d9 = new Vector2(Mathf.Max(8f, _0xba3e1111.x - 12f), Mathf.Max(8f, _0xba3e1111.y - 12f));
        Image _0x3a950cda = Plate(_0xa1c01945, _0x91983859 + _0x32a229b8._0xe1a41e40(new byte[4] { 218, 247, 252, 225 }, 152), Vector2.zero, _0xadd0d1d9, _0x988c519d, _0x73a30952);
        _0x3a950cda.raycastTarget = false;
        float _0xefbed37a = Mathf.Min(_0xba3e1111.x, _0xba3e1111.y) * 0.52f;
        Picture(_0xa1c01945, _0x91983859 + _0x32a229b8._0xe1a41e40(new byte[5] { 63, 20, 1, 8, 16 }, 120), Vector2.zero, new Vector2(_0xefbed37a, _0xefbed37a), _0x9acae630, _0xe94e3611.Cream);
        Button _0xf168dd98 = _0xa1c01945.gameObject.AddComponent<Button>();
        _0xf168dd98.targetGraphic = _0xef1d0834;
        _0xf168dd98.transition = Selectable.Transition.ColorTint;
        ColorBlock _0xa03c5dd2 = _0xf168dd98.colors;
        _0xa03c5dd2.normalColor = _0xe94e3611.White;
        _0xa03c5dd2.highlightedColor = _0xe94e3611.White;
        _0xa03c5dd2.pressedColor = new Color(0.72f, 0.80f, 0.70f, 1f);
        _0xa03c5dd2.selectedColor = _0xe94e3611.White;
        _0xa03c5dd2.disabledColor = new Color(0.55f, 0.58f, 0.54f, 0.6f);
        _0xa03c5dd2.fadeDuration = 0.08f;
        _0xf168dd98.colors = _0xa03c5dd2;
        return _0xf168dd98;
    }

    public static RectTransform Sheet(Transform _0x3ae8f40b, string _0x02019b69)
    {
        GameObject _0x54ca14fa = new GameObject(_0x02019b69, typeof(RectTransform));
        RectTransform _0xaf0df472 = _0x54ca14fa.GetComponent<RectTransform>();
        _0xaf0df472.SetParent(_0x3ae8f40b, false);
        _0xaf0df472.anchorMin = Vector2.zero;
        _0xaf0df472.anchorMax = Vector2.one;
        _0xaf0df472.pivot = new Vector2(0.5f, 0.5f);
        _0xaf0df472.offsetMin = Vector2.zero;
        _0xaf0df472.offsetMax = Vector2.zero;
        _0xaf0df472.localScale = Vector3.one;
        return _0xaf0df472;
    }

    public static RectTransform Node(Transform _0x61687373, string _0x8200aff3, Vector2 _0xf2c564ae, Vector2 _0x1f357875)
    {
        GameObject _0xda85ef17 = new GameObject(_0x8200aff3, typeof(RectTransform));
        RectTransform _0xd2d00959 = _0xda85ef17.GetComponent<RectTransform>();
        _0xd2d00959.SetParent(_0x61687373, false);
        _0xd2d00959.anchorMin = new Vector2(0.5f, 0.5f);
        _0xd2d00959.anchorMax = new Vector2(0.5f, 0.5f);
        _0xd2d00959.pivot = new Vector2(0.5f, 0.5f);
        _0xd2d00959.sizeDelta = _0x1f357875;
        _0xd2d00959.anchoredPosition = _0xf2c564ae;
        _0xd2d00959.localScale = Vector3.one;
        return _0xd2d00959;
    }

    /// Content artwork: keeps the PNG's own proportions (rule F.2a).
    public static Image Picture(Transform _0x5c3b716d, string _0x3f5bf180, Vector2 _0xb0efb3e7, Vector2 _0x92896888, Sprite _0xf795b4c4, Color _0xc0f01642)
    {
        RectTransform _0x528dcddb = Node(_0x5c3b716d, _0x3f5bf180, _0xb0efb3e7, _0x92896888);
        Image _0x96cd3625 = _0x528dcddb.gameObject.AddComponent<Image>();
        _0x96cd3625.sprite = _0xf795b4c4;
        _0x96cd3625.preserveAspect = true;
        _0x96cd3625.type = Image.Type.Simple;
        _0x96cd3625.color = _0xc0f01642;
        _0x96cd3625.raycastTarget = false;
        return _0x96cd3625;
    }

    public static TextMeshProUGUI Caption(Transform _0x17521ef0, string _0xd3e4d60c, Vector2 _0x7fdda35b, Vector2 _0x286d27bf, TMP_FontAsset _0x8493bcb2, string _0xc1a3b47c, float _0x090e2d47, Color _0xb4931a80, TextAlignmentOptions _0x276376b5)
    {
        RectTransform _0xd5c33ca8 = Node(_0x17521ef0, _0xd3e4d60c, _0x7fdda35b, _0x286d27bf);
        TextMeshProUGUI _0xa3830764 = _0xd5c33ca8.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x8493bcb2 != null)
            _0xa3830764.font = _0x8493bcb2;
        _0xa3830764.alignment = _0x276376b5;
        _0xa3830764.raycastTarget = false;
        _0xf6b60f03.Apply(_0xa3830764, _0xb4931a80, _0x090e2d47);
        _0xf6b60f03.SetText(_0xa3830764, _0xc1a3b47c);
        return _0xa3830764;
    }

    /// Framed action button: accent plate, inset dark body, light caption.
    /// Light letters on a dark body keep the shared dark outline readable (rule C.14).
    public static Button Action(Transform _0x9b20c1bb, string _0x23be7df3, Vector2 _0x8596bbd9, Vector2 _0x4b37cf94, Color _0xac45d437, Color _0x4aa9b6a6, Color _0xdf458a27, TMP_FontAsset _0x636a7e9e, string _0x30c543fe, float _0xccbbbf77, Sprite _0xb6274e6a)
    {
        RectTransform _0x36947290 = Node(_0x9b20c1bb, _0x23be7df3, _0x8596bbd9, _0x4b37cf94);
        Image _0xb6f43dc4 = _0x36947290.gameObject.AddComponent<Image>();
        _0xb6f43dc4.type = Image.Type.Sliced;
        _0xb6f43dc4.sprite = _0xb6274e6a;
        _0xb6f43dc4.pixelsPerUnitMultiplier = PlateRoundness(_0x4b37cf94);
        _0xb6f43dc4.color = _0xac45d437;
        _0xb6f43dc4.raycastTarget = true;
        Vector2 _0x91368161 = new Vector2(Mathf.Max(8f, _0x4b37cf94.x - 14f), Mathf.Max(8f, _0x4b37cf94.y - 14f));
        Image _0x599a4c30 = Plate(_0x36947290, _0x23be7df3 + _0x32a229b8._0xe1a41e40(new byte[4] { 186, 151, 156, 129 }, 248), Vector2.zero, _0x91368161, _0x4aa9b6a6, _0xb6274e6a);
        _0x599a4c30.raycastTarget = false;
        Caption(_0x36947290, _0x23be7df3 + _0x32a229b8._0xe1a41e40(new byte[5] { 78, 99, 96, 103, 110 }, 2), Vector2.zero, new Vector2(_0x4b37cf94.x - 48f, _0x4b37cf94.y - 26f), _0x636a7e9e, _0x30c543fe, _0xccbbbf77, _0xdf458a27, TextAlignmentOptions.Center);
        Button _0x4cb744f3 = _0x36947290.gameObject.AddComponent<Button>();
        _0x4cb744f3.targetGraphic = _0xb6f43dc4;
        _0x4cb744f3.transition = Selectable.Transition.ColorTint;
        ColorBlock _0xe59f9ee6 = _0x4cb744f3.colors;
        _0xe59f9ee6.normalColor = _0xe94e3611.White;
        _0xe59f9ee6.highlightedColor = _0xe94e3611.White;
        _0xe59f9ee6.pressedColor = new Color(0.72f, 0.80f, 0.70f, 1f);
        _0xe59f9ee6.selectedColor = _0xe94e3611.White;
        _0xe59f9ee6.disabledColor = new Color(0.55f, 0.58f, 0.54f, 0.6f);
        _0xe59f9ee6.fadeDuration = 0.08f;
        _0x4cb744f3.colors = _0xe59f9ee6;
        return _0x4cb744f3;
    }

    /// Corner radius of the template's 9-slice plate is 127 px divided by this
    /// multiplier, so it has to be derived from the rect or the border swallows a
    /// small box whole (the 9-slice trap).
    public static float PlateRoundness(Vector2 _0x0cce9606)
    {
        float _0xf94212fe = Mathf.Max(1f, Mathf.Min(_0x0cce9606.x, _0x0cce9606.y));
        return Mathf.Max(1.3f, 260f / _0xf94212fe);
    }

    /// Solid rounded plate built on the template's own 9-slice sprite: a built-in
    /// asset can never dangle into a white rectangle (rule B.1).
    public static Image Plate(Transform _0x34c658f4, string _0x36d4897c, Vector2 _0x6f557518, Vector2 _0x4c8aec66, Color _0x588f99e6, Sprite _0xf20505ca)
    {
        RectTransform _0x2d1a8b48 = Node(_0x34c658f4, _0x36d4897c, _0x6f557518, _0x4c8aec66);
        Image _0xceb39f01 = _0x2d1a8b48.gameObject.AddComponent<Image>();
        _0xceb39f01.type = Image.Type.Sliced;
        _0xceb39f01.sprite = _0xf20505ca;
        _0xceb39f01.pixelsPerUnitMultiplier = PlateRoundness(_0x4c8aec66);
        _0xceb39f01.color = _0x588f99e6;
        _0xceb39f01.raycastTarget = false;
        return _0xceb39f01;
    }

    /// Nearly invisible surface that still receives taps: a fully transparent image
    /// is culled by the raycaster, so it carries a trace of alpha instead.
    public static Image HitLayer(Transform _0xee7199fa, string _0xb0ba6f01)
    {
        RectTransform _0x0da74f4f = Sheet(_0xee7199fa, _0xb0ba6f01);
        Image _0xab4a3bf8 = _0x0da74f4f.gameObject.AddComponent<Image>();
        _0xab4a3bf8.color = new Color(0f, 0f, 0f, 0.004f);
        _0xab4a3bf8.raycastTarget = true;
        if (_0xab4a3bf8.canvasRenderer != null)
            _0xab4a3bf8.canvasRenderer.cullTransparentMesh = false;
        return _0xab4a3bf8;
    }

    public static void SetBarFill(Image _0x61a54b85, float _0x4582d72e)
    {
        if (_0x61a54b85 == null)
            return;
        RectTransform _0xd3050749 = _0x61a54b85.rectTransform;
        RectTransform _0x1e98f64b = _0xd3050749.parent as RectTransform;
        if (_0x1e98f64b == null)
            return;
        float _0xd717a821 = Mathf.Max(2f * BarInset, _0x1e98f64b.sizeDelta.x - 2f * BarInset);
        _0xd3050749.anchoredPosition = new Vector2(BarInset, _0xd3050749.anchoredPosition.y);
        _0xd3050749.sizeDelta = new Vector2(Mathf.Max(6f, _0xd717a821 * Mathf.Clamp01(_0x4582d72e)), _0xd3050749.sizeDelta.y);
    }
}

internal static class _0x32a229b8
{
    internal static string _0xe1a41e40(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}