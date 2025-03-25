using TMPro;
using UnityEngine;

// Loading screen between each level.
public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI loadingText;

    public void SetProgress(float progress)
    {
        loadingText.text = progress < 0.25f ? "Loading" :
                           progress < 0.50f ? "Loading." :
                           progress < 0.75f ? "Loading.." :
                                              "Loading...";
    }
}
