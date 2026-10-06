using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xb0135da5;

public class _0x3e36db7a : MonoBehaviour
{
    public float StaticBlurMaterialInitialValue;
    public bool IsShowSplashOnStart = true;
    private void _0xe041bd92(int _0x9fe93b9c)
    {
        if (_0x9fe93b9c == _0xe76dff38.SPLASH)
            _0x311e8160.Instance._0xffc1a7f1();
        if (_0x24245b46.Instance._0xde0b75d4 == _0x73d482f8.SCENE_0)
        {
        }
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x9b03e8ec(int _0x508505b5)
    {
        this._0x7b4c20e7(_0x508505b5);
        this._0xe041bd92(_0x508505b5);
        this.CurrentPanelIndex = _0x508505b5;
        this.Panels[_0x508505b5]._0x474d95cf();
    }

    private void Start()
    {
        this._0xac3a9394();
    }

    public int CurrentPanelIndex;
    private void _0x6e7ab007(int _0x7e955fc6)
    {
        this.LastPanelIndexes.Add(_0x7e955fc6);
        this.CurrentPanelIndex = _0x7e955fc6;
        for (int _0x27351f6e = 0; _0x27351f6e < this.Panels.Count; _0x27351f6e++)
            if (_0x27351f6e != _0x7e955fc6 && this.Panels[_0x27351f6e] != null)
                this.Panels[_0x27351f6e]._0xab975e0a();
    }

    public List<_0xbb55021e> Panels;
    private void _0xac3a9394()
    {
        this._0x9b03e8ec(_0xe76dff38.SPLASH);
        if (_0x24245b46.Instance._0xde0b75d4 == _0x73d482f8.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x311e8160.Instance.DefaultAnimationTime);
        }
    }

    public void _0x79c57b79()
    {
        this.LastPanelIndexes.RemoveAll(_0x9579cc12 => _0x9579cc12 == this.CurrentPanelIndex);
        int _0x10ba541b = this.LastPanelIndexes.Last();
        this._0xe041bd92(_0x10ba541b);
        this._0x6e7ab007(_0x10ba541b);
        this.CurrentPanelIndex = _0x10ba541b;
        this.Panels[_0x10ba541b].Show();
    }

    private _0xbb55021e _0x301302a6(int _0x12c6b348)
    {
        return this.Panels[_0x12c6b348];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x3e36db7a>();
    }

    public void _0x1ab03d30(int _0x5a14a417)
    {
        if (_0x5a14a417 == _0xe76dff38.SPLASH && _0x24245b46.Instance._0xde0b75d4 != _0x73d482f8.SCENE_0)
            _0x311e8160.Instance._0xe7435fdc();
        if (_0x24245b46.Instance._0xde0b75d4 != _0x73d482f8.SCENE_0)
        {
            if (_0x5a14a417 == _0xe76dff38.SPLASH || _0x5a14a417 == _0xe76dff38.TUTORIAL0)
                _0x24245b46.Instance._0x11e6a30d(false);
            else if (_0x5a14a417 == _0xe76dff38.DEFAULT)
                _0x24245b46.Instance._0x11e6a30d(true);
        }
    }

    private void _0x7b4c20e7(int _0xdccd20ce)
    {
        this.LastPanelIndexes.Add(_0xdccd20ce);
        this.CurrentPanelIndex = _0xdccd20ce;
        for (int _0x668bccd4 = 0; _0x668bccd4 < this.Panels.Count; _0x668bccd4++)
            if (_0x668bccd4 != _0xdccd20ce && this.Panels[_0x668bccd4] != null)
                this.Panels[_0x668bccd4]._0xab975e0a();
    }

    public float ScaleDuration = 0.4f;
    public static _0x3e36db7a Instance;
    public void _0xa72c9de0(int _0x13e95ef1)
    {
        this._0x7b4c20e7(_0x13e95ef1);
        this._0xe041bd92(_0x13e95ef1);
        this.CurrentPanelIndex = _0x13e95ef1;
        this.Panels[_0x13e95ef1].Show();
    }

    private void SwitchSplash()
    {
        if (_0xf58e0432.Instance.IsTutorialEnabled && !_0x24245b46._0x8105d274._0xcd60561f)
            this._0xa72c9de0(_0xe76dff38.TUTORIAL0);
        else
            this._0xa72c9de0(_0xe76dff38.DEFAULT);
    }
}