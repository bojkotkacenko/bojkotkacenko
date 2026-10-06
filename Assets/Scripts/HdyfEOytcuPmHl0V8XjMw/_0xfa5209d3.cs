using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Dresses the menu scene: the loading board, the hero menu and the two overlays.
/// Everything it shows is an object it created itself inside the template's own
/// panel bodies, which is the only content codegen can reliably drive (rule C.2).
public sealed class _0xfa5209d3 : MonoBehaviour
{
    [SerializeField]
    private _0x53858555 _progress;
    // -------- loading board --------
    private void _0xda61e73b()
    {
        Transform _0x16e19b5b = this._0x75747378(_0xb0135da5._0xe76dff38.SPLASH);
        if (_0x16e19b5b == null)
            return;
        List<Transform> _0x4b56273d = new List<Transform>();
        for (int _0x023ab641 = 0; _0x023ab641 < _0x16e19b5b.childCount; _0x023ab641++)
            _0x4b56273d.Add(_0x16e19b5b.GetChild(_0x023ab641));
        Image _0x8c7b27ce = _0xd3e5c9ef.Shade(_0x16e19b5b, _0x1c7b1a01._0x04bda241(new byte[9] { 137, 170, 164, 161, 150, 173, 164, 161, 160 }, 197), _0xe94e3611.WithAlpha(_0xe94e3611.NightGarden, 0.62f), this._roundPlate);
        _0x8c7b27ce.raycastTarget = false;
        RectTransform _0x3df18d3e = _0xd3e5c9ef.Picture(_0x16e19b5b, _0x1c7b1a01._0x04bda241(new byte[8] { 90, 121, 119, 114, 91, 119, 100, 125 }, 22), new Vector2(0f, 240f), new Vector2(460f, 460f), this._emblem, _0xe94e3611.White).rectTransform;
        DOTween.Kill(_0x3df18d3e, true);
        _0x3df18d3e.localScale = new Vector3(0.85f, 0.85f, 1f);
        _0x3df18d3e.DOScale(1f, 0.55f).SetEase(Ease.OutBack);
        _0xd3e5c9ef.Caption(_0x16e19b5b, _0x1c7b1a01._0x04bda241(new byte[8] { 206, 237, 227, 230, 213, 237, 240, 230 }, 130), new Vector2(0f, -887f), new Vector2(700f, 80f), this._font, _0x1c7b1a01._0x04bda241(new byte[7] { 4, 7, 9, 12, 1, 6, 15 }, 72), 40f, _0xe94e3611.CreamSoft, TextAlignmentOptions.Center);
        // The template's own progress bar must stay on top of anything added here.
        for (int _0xd47fd1a1 = 0; _0xd47fd1a1 < _0x4b56273d.Count; _0xd47fd1a1++)
            if (_0x4b56273d[_0xd47fd1a1] != null)
                _0x4b56273d[_0xd47fd1a1].SetAsLastSibling();
    }

    private Transform _0x75747378(int _0xbfcef54b)
    {
        if (_0x3e36db7a.Instance == null || _0x3e36db7a.Instance.Panels == null)
            return null;
        if (_0xbfcef54b < 0 || _0xbfcef54b >= _0x3e36db7a.Instance.Panels.Count)
            return null;
        _0xbb55021e _0x7d9d7b58 = _0x3e36db7a.Instance.Panels[_0xbfcef54b];
        if (_0x7d9d7b58 == null || _0x7d9d7b58.Content == null)
            return null;
        return _0x7d9d7b58.Content.transform;
    }

    [SerializeField]
    private Sprite[] _basketArt = new Sprite[3];
    // -------- menu board --------
    private void _0x02a4e394()
    {
        Transform _0xb636d436 = this._0x75747378(_0xb0135da5._0xe76dff38.DEFAULT);
        if (_0xb636d436 == null)
            return;
        int _0x92ed1cfc = this._gardens != null ? this._gardens.Length : 0;
        int _0x90518fc1 = this._progress != null ? this._progress._0x0b16c68d(_0x92ed1cfc) : 0;
        _0xd3e5c9ef.Plate(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[11] { 49, 25, 18, 9, 40, 19, 12, 43, 29, 15, 20 }, 124), new Vector2(0f, 1150f), new Vector2(1160f, 140f), _0xe94e3611.WithAlpha(_0xe94e3611.NightGarden, 0.45f), this._roundPlate);
        this._0xd6e0e81b(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[12] { 14, 38, 45, 54, 1, 38, 48, 55, 0, 43, 42, 51 }, 67), new Vector2(-350f, 1150f), new Vector2(420f, 104f), _0x90518fc1 > 0 ? _0x1c7b1a01._0x04bda241(new byte[5] { 181, 178, 164, 163, 215 }, 247) + _0x90518fc1 : _0x1c7b1a01._0x04bda241(new byte[6] { 15, 8, 30, 25, 109, 125 }, 77), _0xe94e3611.Sun);
        this._0xd6e0e81b(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[13] { 138, 162, 169, 178, 151, 178, 181, 180, 162, 132, 175, 174, 183 }, 199), new Vector2(350f, 1150f), new Vector2(420f, 104f), _0xb0135da5._0x0c1629aa._0x2d6060af + _0x1c7b1a01._0x04bda241(new byte[6] { 61, 94, 82, 84, 83, 78 }, 29), _0xe94e3611.Cream);
        RectTransform _0xc049719a = _0xd3e5c9ef.Picture(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[8] { 78, 102, 109, 118, 78, 98, 113, 104 }, 3), new Vector2(0f, 800f), new Vector2(440f, 440f), this._emblem, _0xe94e3611.White).rectTransform;
        _0x8c8dd86b _0xf4fc5693 = this.gameObject.AddComponent<_0x8c8dd86b>();
        _0xf4fc5693._0x951bc792(_0xc049719a, 14f, 3f);
        _0xd3e5c9ef.Picture(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[13] { 34, 10, 1, 26, 45, 10, 29, 29, 22, 35, 10, 9, 27 }, 111), new Vector2(-520f, 560f), new Vector2(92f, 92f), this._goldenArt, _0xe94e3611.White);
        _0xd3e5c9ef.Picture(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[14] { 107, 67, 72, 83, 100, 67, 84, 84, 95, 116, 79, 65, 78, 82 }, 38), new Vector2(520f, 560f), new Vector2(92f, 92f), this._goldenArt, _0xe94e3611.White);
        RectTransform _0xab06d69d = _0xd3e5c9ef.Node(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[12] { 109, 69, 78, 85, 105, 78, 70, 79, 99, 65, 82, 68 }, 32), new Vector2(0f, 330f), new Vector2(900f, 330f));
        Image _0xc8477156 = _0xab06d69d.gameObject.AddComponent<Image>();
        _0xc8477156.type = Image.Type.Sliced;
        _0xc8477156.sprite = this._roundPlate;
        _0xc8477156.pixelsPerUnitMultiplier = _0xd3e5c9ef.PlateRoundness(new Vector2(900f, 330f));
        _0xc8477156.color = _0xe94e3611.LeafDeep;
        _0xc8477156.raycastTarget = false;
        Image _0x3c48a391 = _0xd3e5c9ef.Plate(_0xab06d69d, _0x1c7b1a01._0x04bda241(new byte[12] { 173, 133, 142, 149, 169, 142, 134, 143, 162, 143, 132, 153 }, 224), Vector2.zero, new Vector2(886f, 316f), _0xe94e3611.Forest, this._roundPlate);
        _0x3c48a391.raycastTarget = false;
        _0xd3e5c9ef.Caption(_0xab06d69d, _0x1c7b1a01._0x04bda241(new byte[13] { 206, 230, 237, 246, 202, 237, 229, 236, 207, 234, 237, 230, 178 }, 131), new Vector2(0f, 96f), new Vector2(820f, 70f), this._font, _0x1c7b1a01._0x04bda241(new byte[14] { 80, 76, 81, 87, 35, 87, 75, 70, 35, 69, 81, 86, 74, 87 }, 3), 48f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
        _0xd3e5c9ef.Caption(_0xab06d69d, _0x1c7b1a01._0x04bda241(new byte[13] { 138, 162, 169, 178, 142, 169, 161, 168, 139, 174, 169, 162, 245 }, 199), new Vector2(0f, 14f), new Vector2(820f, 64f), this._font, _0x1c7b1a01._0x04bda241(new byte[17] { 224, 239, 234, 234, 134, 227, 240, 227, 244, 255, 134, 228, 231, 245, 237, 227, 242 }, 166), 40f, _0xe94e3611.Leaf, TextAlignmentOptions.Center);
        _0xd3e5c9ef.Caption(_0xab06d69d, _0x1c7b1a01._0x04bda241(new byte[13] { 13, 37, 46, 53, 9, 46, 38, 47, 12, 41, 46, 37, 115 }, 64), new Vector2(0f, -76f), new Vector2(820f, 60f), this._font, _0x92ed1cfc + _0x1c7b1a01._0x04bda241(new byte[16] { 54, 81, 87, 68, 82, 83, 88, 69, 54, 66, 89, 54, 89, 70, 83, 88 }, 22), 36f, _0xe94e3611.Sun, TextAlignmentOptions.Center);
        this._0x8810506a(_0xb636d436);
        Button _0x2e967e1c = _0xd3e5c9ef.Action(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[11] { 69, 109, 102, 125, 79, 105, 122, 108, 109, 102, 123 }, 8), new Vector2(0f, -360f), new Vector2(560f, 136f), _0xe94e3611.Sun, _0xe94e3611.Forest, _0xe94e3611.Sun, this._font, _0x1c7b1a01._0x04bda241(new byte[7] { 9, 15, 28, 10, 11, 0, 29 }, 78), 42f, this._roundPlate);
        Button _0x0b0790ef = _0xd3e5c9ef.Action(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[9] { 124, 84, 95, 68, 121, 94, 70, 101, 94 }, 49), new Vector2(0f, -560f), new Vector2(560f, 136f), _0xe94e3611.Moss, _0xe94e3611.Forest, _0xe94e3611.CreamSoft, this._font, _0x1c7b1a01._0x04bda241(new byte[11] { 187, 188, 164, 211, 167, 188, 211, 160, 188, 161, 167 }, 243), 40f, this._roundPlate);
        _0xd3e5c9ef.Caption(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[8] { 253, 213, 222, 197, 248, 217, 222, 196 }, 176), new Vector2(0f, -740f), new Vector2(960f, 64f), this._font, _0x1c7b1a01._0x04bda241(new byte[33] { 117, 116, 127, 26, 110, 123, 106, 26, 105, 127, 116, 126, 105, 26, 123, 26, 124, 104, 111, 115, 110, 26, 110, 117, 26, 123, 26, 120, 123, 105, 113, 127, 110 }, 58), 34f, _0xe94e3611.CreamSoft, TextAlignmentOptions.Center);
        for (int _0x0f787cc7 = 0; _0x0f787cc7 < 3; _0x0f787cc7++)
        {
            Sprite _0x8322cb31 = this._basketArt != null && _0x0f787cc7 < this._basketArt.Length ? this._basketArt[_0x0f787cc7] : null;
            _0xd3e5c9ef.Picture(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[15] { 120, 80, 91, 64, 119, 84, 70, 94, 80, 65, 113, 80, 86, 90, 71 }, 53), new Vector2((_0x0f787cc7 - 1) * 300f, -1070f), new Vector2(240f, 240f), _0x8322cb31, _0xe94e3611.White);
        }

        // -------- overlays, built last so they draw above the board --------
        RectTransform _0xb8da7c18 = _0xd3e5c9ef.Sheet(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[13] { 62, 24, 11, 29, 28, 23, 54, 15, 28, 11, 21, 24, 0 }, 121));
        this._0xd85c96dc = this.gameObject.AddComponent<_0xe2863a9e>();
        _0xc7e38e61 _0x1105a86e = this.gameObject.AddComponent<_0xc7e38e61>();
        _0x1105a86e._0x94e1c93a(_0xb8da7c18, this._gardens, this._progress, this._font, this._roundPlate, this._closeIcon, this._pip, this._0xd85c96dc);
        this._0xd85c96dc._0xd1112b39(_0xb8da7c18.gameObject);
        RectTransform _0x9d145a30 = _0xd3e5c9ef.Sheet(_0xb636d436, _0x1c7b1a01._0x04bda241(new byte[12] { 77, 106, 114, 81, 106, 74, 115, 96, 119, 105, 100, 124 }, 5));
        this._0x3ee390e4 = this.gameObject.AddComponent<_0xe2863a9e>();
        this._0x148ebbb4 = this.gameObject.AddComponent<_0x4ae2c94f>();
        this._0x148ebbb4._0xb9a46556(_0x9d145a30, this._font, this._roundPlate, this._closeIcon, this._pip, this._trayArt, this._tagArt, this._appleArt, this._0x3ee390e4, this._0xd85c96dc);
        this._0x3ee390e4._0xd1112b39(_0x9d145a30.gameObject);
        _0xb979e81f _0xab7e48af = _0x2e967e1c.gameObject.AddComponent<_0xb979e81f>();
        _0xab7e48af._0x85ee218d(_0x2e967e1c, this._0xd85c96dc, this._0x3ee390e4, false);
        _0xb979e81f _0x296acc2e = _0x0b0790ef.gameObject.AddComponent<_0xb979e81f>();
        _0x296acc2e._0x85ee218d(_0x0b0790ef, this._0x3ee390e4, this._0xd85c96dc, false);
        this._0x863f8519(_0xab06d69d, 0.06f);
        this._0x863f8519(_0x2e967e1c.transform as RectTransform, 0.12f);
        this._0x863f8519(_0x0b0790ef.transform as RectTransform, 0.18f);
    }

    [SerializeField]
    private Sprite _trayArt;
    [SerializeField]
    private Sprite _roundPlate;
    [SerializeField]
    private Sprite _goldenArt;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private _0xbff45879[] _gardens = new _0xbff45879[0];
    [SerializeField]
    private RectTransform _playButtonRect;
    private _0x4ae2c94f _0x148ebbb4;
    private void Start()
    {
        this._0xda61e73b();
        this._0x02a4e394();
    }

    [SerializeField]
    private Sprite _tagArt;
    [SerializeField]
    private Sprite _emblem;
    private _0xe2863a9e _0x3ee390e4;
    [SerializeField]
    private Sprite _pip;
    /// The template's Play button is a bare hit rect whose own layers never render,
    /// so the visible face is built as its child. UGUI bubbles the press up to the
    /// Button, and the LoadSceneButton driver already on it loads the garden scene.
    private void _0x8810506a(Transform _0x6f38395a)
    {
        RectTransform _0xd8a5dee2 = this._playButtonRect;
        if (_0xd8a5dee2 == null)
            return;
        Vector2 _0x1aebc5b7 = new Vector2(760f, 176f);
        Image _0x5e673e44 = _0xd3e5c9ef.Plate(_0xd8a5dee2, _0x1c7b1a01._0x04bda241(new byte[8] { 68, 120, 117, 109, 82, 117, 119, 113 }, 20), Vector2.zero, _0x1aebc5b7, _0xe94e3611.Leaf, this._roundPlate);
        _0x5e673e44.raycastTarget = true;
        Image _0xd71fdb52 = _0xd3e5c9ef.Plate(_0xd8a5dee2, _0x1c7b1a01._0x04bda241(new byte[12] { 104, 84, 89, 65, 126, 89, 91, 93, 122, 87, 92, 65 }, 56), Vector2.zero, new Vector2(_0x1aebc5b7.x - 16f, _0x1aebc5b7.y - 16f), _0xe94e3611.LeafDeep, this._roundPlate);
        _0xd71fdb52.raycastTarget = false;
        _0xd3e5c9ef.Caption(_0xd8a5dee2, _0x1c7b1a01._0x04bda241(new byte[13] { 89, 101, 104, 112, 79, 104, 106, 108, 69, 104, 107, 108, 101 }, 9), Vector2.zero, new Vector2(_0x1aebc5b7.x - 60f, _0x1aebc5b7.y - 40f), this._font, _0x1c7b1a01._0x04bda241(new byte[4] { 223, 195, 206, 214 }, 143), 58f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
        RectTransform _0xe55eb794 = _0xd3e5c9ef.Node(_0x6f38395a, _0x1c7b1a01._0x04bda241(new byte[8] { 86, 106, 103, 127, 65, 106, 105, 113 }, 6), new Vector2(0f, PlayY - 10f), new Vector2(_0x1aebc5b7.x + 26f, _0x1aebc5b7.y + 20f));
        _0xe55eb794.SetAsFirstSibling();
        Image _0x4884c48a = _0xe55eb794.gameObject.AddComponent<Image>();
        _0x4884c48a.type = Image.Type.Sliced;
        _0x4884c48a.sprite = this._roundPlate;
        _0x4884c48a.pixelsPerUnitMultiplier = _0xd3e5c9ef.PlateRoundness(_0x1aebc5b7);
        _0x4884c48a.color = _0xe94e3611.WithAlpha(_0xe94e3611.Shadow, 0.5f);
        _0x4884c48a.raycastTarget = false;
        DOTween.Kill(_0xd8a5dee2, true);
        _0xd8a5dee2.localScale = Vector3.one;
        _0xd8a5dee2.DOScale(1.03f, 0.9f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private const float PanelHalfWidth = 621f;
    private _0xe2863a9e _0xd85c96dc;
    private void _0x863f8519(RectTransform _0xf3cf7917, float _0xc0953a70)
    {
        if (_0xf3cf7917 == null)
            return;
        float _0x0312ee30 = _0xf3cf7917.anchoredPosition.y;
        _0xf3cf7917.anchoredPosition = new Vector2(_0xf3cf7917.anchoredPosition.x, _0x0312ee30 - 60f);
        _0xf3cf7917.DOAnchorPosY(_0x0312ee30, 0.35f).SetEase(Ease.OutCubic).SetDelay(_0xc0953a70);
    }

    [SerializeField]
    private Sprite _appleArt;
    private void _0xd6e0e81b(Transform _0xe00168df, string _0xf5809758, Vector2 _0xdbc4d914, Vector2 _0x80a28fff, string _0xd4a50185, Color _0x42f162a1)
    {
        Image _0xbfbc576d = _0xd3e5c9ef.Plate(_0xe00168df, _0xf5809758, _0xdbc4d914, _0x80a28fff, _0xe94e3611.WithAlpha(_0xe94e3611.Forest, 0.92f), this._roundPlate);
        _0xd3e5c9ef.Caption(_0xbfbc576d.rectTransform, _0xf5809758 + _0x1c7b1a01._0x04bda241(new byte[4] { 179, 130, 159, 147 }, 231), Vector2.zero, new Vector2(_0x80a28fff.x - 36f, _0x80a28fff.y - 24f), this._font, _0xd4a50185, 36f, _0x42f162a1, TextAlignmentOptions.Center);
    }

    [SerializeField]
    private Sprite _closeIcon;
    private const float PlayY = -120f;
}

internal static class _0x1c7b1a01
{
    internal static string _0x04bda241(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}