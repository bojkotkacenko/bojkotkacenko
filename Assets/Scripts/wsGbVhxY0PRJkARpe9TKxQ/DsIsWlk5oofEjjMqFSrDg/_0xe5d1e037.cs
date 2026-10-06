using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xe5d1e037 : MonoBehaviour
{
    private void Update()
    {
        if (_0x34cc6981.Count == 0 || _0x34cc6981[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xaf5947a0)
            OrientationChanged();
        if (Screen.safeArea != _0xea3bd9d9)
            SafeAreaChanged();
        if (Screen.width != _0xf4eaf4c2.x || Screen.height != _0xf4eaf4c2.y)
            ResolutionChanged();
    }

    private static void SafeAreaChanged()
    {
        _0xea3bd9d9 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static ScreenOrientation _0xaf5947a0 = ScreenOrientation.LandscapeLeft;
    private static Rect _0xea3bd9d9 = Rect.zero;
    private Canvas _0x8160ee7a;
    private CanvasScaler _0xa53a3aa7;
    private RectTransform _0xbc4be70d;
    private Vector2 _0xa6b885ff;
    private static UnityEvent _0x1c603a41 = new();
    private RectTransform _0x8d09c34d;
    private static void OrientationChanged()
    {
        _0xaf5947a0 = Screen.orientation;
        _0xf4eaf4c2.x = Screen.width;
        _0xf4eaf4c2.y = Screen.height;
        _0xea3bd9d9 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x1c603a41.Invoke();
    }

    private void _0x36b03b4c()
    {
        if (this._0xbc4be70d == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xb2650929 = Screen.safeArea;
        Vector2 _0x26607ef9 = _0xb2650929.position;
        Vector2 _0x398b721a = _0xb2650929.position + _0xb2650929.size;
        _0x26607ef9.x /= screenWidth;
        _0x26607ef9.y /= screenHeight;
        _0x398b721a.x /= screenWidth;
        _0x398b721a.y /= screenHeight;
        this._0xbc4be70d.anchorMin = _0x26607ef9;
        this._0xbc4be70d.anchorMax = _0x398b721a;
        this._0xbc4be70d.offsetMin = Vector2.zero;
        this._0xbc4be70d.offsetMax = Vector2.zero;
        if (this._0xa53a3aa7 == null)
            return;
        Vector2 _0x45a1eb8d = _0x398b721a - _0x26607ef9;
        float _0xe5fad863 = 2f - _0x45a1eb8d.x;
        float _0xf82e045e = 2f - _0x45a1eb8d.y;
        this._0xa53a3aa7.referenceResolution = this._0xa6b885ff * new Vector2(_0xe5fad863, _0xf82e045e);
    }

    private static void ResolutionChanged()
    {
        _0xf4eaf4c2.x = Screen.width;
        _0xf4eaf4c2.y = Screen.height;
        _0xea3bd9d9 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x1c603a41.Invoke();
    }

    private static bool _0x2a7a4f60;
    private void OnDestroy()
    {
        if (_0x34cc6981 != null && _0x34cc6981.Contains(this))
            _0x34cc6981.Remove(this);
    }

    private void Start()
    {
    }

    private static Vector2 _0xf4eaf4c2 = Vector2.zero;
    private void Awake()
    {
        if (!_0x34cc6981.Contains(this))
            _0x34cc6981.Add(this);
        this._0x8160ee7a = this.GetComponent<Canvas>();
        this._0xa53a3aa7 = this.GetComponent<CanvasScaler>();
        if (this._0xa53a3aa7 != null)
            this._0xa6b885ff = this._0xa53a3aa7.referenceResolution;
        this._0x8d09c34d = this.GetComponent<RectTransform>();
        this._0xbc4be70d = this.transform.Find(_0xb3b761b8._0xed1fe367(new byte[8] { 180, 134, 129, 130, 166, 149, 130, 134 }, 231)) as RectTransform;
        if (!_0x2a7a4f60)
        {
            _0xaf5947a0 = Screen.orientation;
            _0xf4eaf4c2.x = Screen.width;
            _0xf4eaf4c2.y = Screen.height;
            _0xea3bd9d9 = Screen.safeArea;
            _0x2a7a4f60 = true;
        }

        this._0x36b03b4c();
    }

    private static readonly List<_0xe5d1e037> _0x34cc6981 = new();
    private static void ApplySafeAreaToAll()
    {
        for (int _0xfe890212 = 0; _0xfe890212 < _0x34cc6981.Count; _0xfe890212++)
            _0x34cc6981[_0xfe890212]._0x36b03b4c();
    }
}

internal static class _0xb3b761b8
{
    internal static string _0xed1fe367(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}