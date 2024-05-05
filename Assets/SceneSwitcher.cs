using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public Button continueButton;

    void Start()
    {
        //Button btn = continueButton.GetComponent<Button>();
        continueButton.onClick.AddListener(ContinueTaskOnClick);
    }

    void ContinueTaskOnClick()
    {
        SwitchToScene("SampleScene");
    }

    public void SwitchToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
