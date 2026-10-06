using TMPro;
using UnityEngine;
using static _0xb0135da5;

public class _0x517f7391 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x6af67d27;
            if (this.gameObject.TryGetComponent(out _0x6af67d27))
                this.MoneyCountText = _0x6af67d27;
        }

        this._0x330623d1();
    }

    public void _0x330623d1()
    {
        this.MoneyCountText.text = _0x0c1629aa._0x2d6060af.ToString();
    }

    public TMP_Text MoneyCountText;
}