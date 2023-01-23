using UnityEngine;

public class ContactWithSwitcher : RandomColor
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ColorSwitcher")
        {
            _spriteRenderer.color = SetRandomColor();
            collision.gameObject.SetActive(false);
        }
    }
}
