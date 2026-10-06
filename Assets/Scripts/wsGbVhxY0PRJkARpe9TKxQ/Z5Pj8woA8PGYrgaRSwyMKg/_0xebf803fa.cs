using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xebf803fa : MonoBehaviour
{
    private void Update()
    {
        this._0x1c6a6326();
    }

    private TMP_Text _0xd8598a39;
    private Image _0x8d023d6d;
    private void _0x1c6a6326()
    {
        if (this._0x8d023d6d.canvasRenderer.GetColor() != this._0xd8598a39.canvasRenderer.GetColor())
            this._0xd8598a39.canvasRenderer.SetColor(this._0x8d023d6d.canvasRenderer.GetColor());
    }
}