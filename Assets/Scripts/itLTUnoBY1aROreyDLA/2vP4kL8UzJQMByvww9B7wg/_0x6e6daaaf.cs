using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xb0135da5;

public class _0x6e6daaaf : MonoBehaviour
{
    public float ScaleDuration = 0.4f;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public static _0x6e6daaaf Instance;
    public List<_0x0593ece4> Pops;
    private void _0x7fefd5c1(bool _0xa69552c4 = false)
    {
        for (int _0x7abaf0f2 = 0; _0x7abaf0f2 < this.Pops.Count; ++_0x7abaf0f2)
            if (this.Pops[_0x7abaf0f2] != null && !(_0x7abaf0f2 == this.CurrentPopIndex && _0xa69552c4))
                this.Pops[_0x7abaf0f2]._0xe91c7d3d();
    }

    public void _0xbcc5d291()
    {
        this.LastPopIndexes.RemoveAll(_0x9579cc12 => _0x9579cc12 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x29da2ed9();
        else
            this._0x8717e92b(this.LastPopIndexes.Last());
    }

    public int CurrentPopIndex;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x0593ece4 _0x183adae0 in this.Pops)
            if (_0x183adae0 != null)
                _0x183adae0.gameObject.SetActive(true);
    }

    public void _0x29da2ed9()
    {
        this.LastPopIndexes.Clear();
        this._0x7fefd5c1();
        foreach (GameObject _0x7e6a6f2d in this.GameObjectsToHide)
            if (_0x7e6a6f2d != null)
                _0x7e6a6f2d.SetActive(true);
        this._0x3e5b7677();
    }

    public void _0x8717e92b(int _0xfdc877c7)
    {
        this.CurrentPopIndex = _0xfdc877c7;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x7fefd5c1(true);
        this._0x8ec203df();
        this.Pops[_0xfdc877c7].Show();
        foreach (GameObject _0x77a5d3ed in this.GameObjectsToHide)
            _0x77a5d3ed.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
    private void _0x8ec203df()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void _0x3e5b7677()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x6e6daaaf>();
    }

    public _0x0593ece4 _0xa401efea(int _0xe8f0fe6a)
    {
        return this.Pops[_0xe8f0fe6a];
    }

    public List<GameObject> GameObjectsToHide;
    public GameObject BlurBackground;
}