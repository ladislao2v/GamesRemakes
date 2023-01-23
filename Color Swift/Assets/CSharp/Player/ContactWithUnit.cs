using UnityEngine;
using UnityEngine.SceneManagement;

public class ContactWithUnit : RandomColor
{

    private string[] objectNames = new string[4]
    {
        "BluePart",
        "YellowPart",
        "PinkPart",
        "MagentaPart"
    };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < 4; i++)
            CheckColor(objectNames[i], colorNames[i], collision);
    }

    private void CheckColor(string objectName, Color color, Collider2D collision)
    {
        if (collision.gameObject.name == objectName && GetPlayerColor() != color)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
