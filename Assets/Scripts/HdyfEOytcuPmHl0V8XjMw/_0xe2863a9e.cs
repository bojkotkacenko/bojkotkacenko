using DG.Tweening;
using UnityEngine;

/// Shows and hides ONE node this build created itself. Codegen only reliably drives
/// what it built (rule C.2), so every overlay goes through one of these instead of
/// reaching into a template panel.
public sealed class _0xe2863a9e : MonoBehaviour
{
    private CanvasGroup _0xf83511f9()
    {
        if (this._0xe4ea9b69 != null)
            return this._0xe4ea9b69;
        if (this._content == null)
            return null;
        this._0xe4ea9b69 = this._content.GetComponent<CanvasGroup>();
        if (this._0xe4ea9b69 == null)
            this._0xe4ea9b69 = this._content.AddComponent<CanvasGroup>();
        return this._0xe4ea9b69;
    }

    public void _0xff057f7e()
    {
        if (this._0xd6e88bd9)
            this._0xf5b3e926();
        else
            this._0xf7e30ac2();
    }

    public bool _0xd6e88bd9
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }

    public void _0xf5b3e926()
    {
        if (this._content == null)
            return;
        DOTween.Kill(this._content.transform, true);
        this._content.transform.localScale = Vector3.one;
        this._content.SetActive(false);
    }

    public void _0xd1112b39(GameObject _0x5c7501c2)
    {
        this._content = _0x5c7501c2;
        this._0xe4ea9b69 = null;
        this._0xf5b3e926();
    }

    private CanvasGroup _0xe4ea9b69;
    public void _0xf7e30ac2()
    {
        if (this._content == null)
            return;
        this._content.SetActive(true);
        CanvasGroup _0x863c45b0 = this._0xf83511f9();
        if (_0x863c45b0 != null)
        {
            DOTween.Kill(_0x863c45b0, true);
            _0x863c45b0.alpha = 0f;
            DOTween.To(() => _0x863c45b0.alpha, _0xf7c9b9d0 => _0x863c45b0.alpha = _0xf7c9b9d0, 1f, 0.18f).SetEase(Ease.OutSine);
        }

        Transform _0xd65713a3 = this._content.transform;
        DOTween.Kill(_0xd65713a3, true);
        _0xd65713a3.localScale = new Vector3(0.97f, 0.97f, 1f);
        _0xd65713a3.DOScale(1f, 0.22f).SetEase(Ease.OutBack);
    }

    [SerializeField]
    private GameObject _content;
}