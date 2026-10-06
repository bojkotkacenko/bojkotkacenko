using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x80dbb4aa : MonoBehaviour
{
    private static UnityEvent _0x5086ba58 = new();
    private static Vector2 _0x8b3837f6 = Vector2.zero;
    private RectTransform _0xd13f11ad;
    private void Update()
    {
        if (_0xeecd3b49[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x4e4e803d)
            OrientationChanged();
        if (Screen.safeArea != _0x109a4d43)
            SafeAreaChanged();
        if (Screen.width != _0x8b3837f6.x || Screen.height != _0x8b3837f6.y)
            ResolutionChanged();
    }

    private RectTransform _0x748a07fb;
    private static readonly List<_0x80dbb4aa> _0xeecd3b49 = new();
    private static void OrientationChanged()
    {
        _0x4e4e803d = Screen.orientation;
        _0x8b3837f6.x = Screen.width;
        _0x8b3837f6.y = Screen.height;
        _0x5086ba58.Invoke();
    }

    private static bool _0x90ccf384;
    private static void SafeAreaChanged()
    {
        _0x109a4d43 = Screen.safeArea;
        for (int _0xaec18531 = 0; _0xaec18531 < _0xeecd3b49.Count; _0xaec18531++)
            _0xeecd3b49[_0xaec18531]._0x792ee42e();
    }

    private static ScreenOrientation _0x4e4e803d = ScreenOrientation.LandscapeLeft;
    private void Awake()
    {
        if (!_0xeecd3b49.Contains(this))
            _0xeecd3b49.Add(this);
        this._0xf86e2183 = this.GetComponent<Canvas>();
        this._0xd13f11ad = this.GetComponent<RectTransform>();
        this._0x748a07fb = this.transform.Find(_0x09d039f3._0xa4766fc3(new byte[8] { 103, 85, 82, 81, 117, 70, 81, 85 }, 52)) as RectTransform;
        if (!_0x90ccf384)
        {
            _0x4e4e803d = Screen.orientation;
            _0x8b3837f6.x = Screen.width;
            _0x8b3837f6.y = Screen.height;
            _0x109a4d43 = Screen.safeArea;
            _0x90ccf384 = true;
        }

        this._0x792ee42e();
    }

    private Canvas _0xf86e2183;
    private static Rect _0x109a4d43 = Rect.zero;
    private static void ResolutionChanged()
    {
        _0x8b3837f6.x = Screen.width;
        _0x8b3837f6.y = Screen.height;
        _0x5086ba58.Invoke();
    }

    private void OnDestroy()
    {
        if (_0xeecd3b49 != null && _0xeecd3b49.Contains(this))
            _0xeecd3b49.Remove(this);
    }

    private void _0x792ee42e()
    {
        if (this._0x748a07fb == null)
            return;
        Rect _0x2a4e5b62 = Screen.safeArea;
        Vector2 _0xa5a90505 = _0x2a4e5b62.position;
        Vector2 _0xfc4fe839 = _0x2a4e5b62.position + _0x2a4e5b62.size;
        _0xa5a90505.x /= this._0xf86e2183.pixelRect.width;
        _0xa5a90505.y /= this._0xf86e2183.pixelRect.height;
        _0xfc4fe839.x /= this._0xf86e2183.pixelRect.width;
        _0xfc4fe839.y /= this._0xf86e2183.pixelRect.height;
        this._0x748a07fb.anchorMin = _0xa5a90505;
        this._0x748a07fb.anchorMax = _0xfc4fe839;
    }
}

internal static class _0x09d039f3
{
    internal static string _0xa4766fc3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}