using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xfb7a3ce1 : MonoBehaviour
{
    public int LoadSceneId;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x24245b46.Instance._0x27fae1f7(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x24245b46.Instance._0x27fae1f7(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}