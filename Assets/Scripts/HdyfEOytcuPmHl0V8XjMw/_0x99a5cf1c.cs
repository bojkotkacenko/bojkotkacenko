using UnityEngine;
using UnityEngine.EventSystems;

/// Turns a tap anywhere on the lawn into a world point for the round to resolve.
/// Pointer events come from the project's own input module, so no legacy input and
/// no name lookup is involved, and it works on any aspect without letterbox maths.
public sealed class _0x99a5cf1c : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private _0x2fae4a14 _game;
    public void OnPointerClick(PointerEventData _0xe4bca3c1)
    {
        if (this._game == null || _0xe4bca3c1 == null)
            return;
        Camera _0x2fb43d1c = this._view != null ? this._view : Camera.main;
        if (_0x2fb43d1c == null)
            return;
        Vector3 _0x82ca4421 = new Vector3(_0xe4bca3c1.position.x, _0xe4bca3c1.position.y, -_0x2fb43d1c.transform.position.z);
        Vector3 _0x7339b797 = _0x2fb43d1c.ScreenToWorldPoint(_0x82ca4421);
        this._game._0x64f57b93(new Vector2(_0x7339b797.x, _0x7339b797.y));
    }

    public void _0xf48bc332(_0x2fae4a14 _0xd66cc2c1, Camera _0xbed4e1a6)
    {
        this._game = _0xd66cc2c1;
        this._view = _0xbed4e1a6;
    }

    [SerializeField]
    private Camera _view;
}