using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    private Button ContinueB;
    private Button OptionsB;
    private Button QuitB;

    private void Awake()
    {
        ContinueB = transform.GetChild(0).GetComponent<Button>();
        OptionsB = transform.GetChild(1).GetComponent<Button>();
        QuitB = transform.GetChild(2).GetComponent<Button>();
    }

    private void Start()
    {
        ContinueB.onClick.AddListener(Continue);
        OptionsB.onClick.AddListener(Options);
        QuitB.onClick.AddListener(Quit);
    }

    private void Update()
    {
        CheckForEscapeButton();
    }
    private void CheckForEscapeButton()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenOrCloseGameMenu();
        }
    }

    private void OpenOrCloseGameMenu()
    {
        if (transform.localScale.x == 0)
            transform.localScale = Vector2.one;
        else
            transform.localScale = Vector2.zero;

    }

    private void Continue()
    {
        OpenOrCloseGameMenu();
    }
    private void Options()
    {

    }
    private void Quit()
    {
        Application.Quit();
    }
}
