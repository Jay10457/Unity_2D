using UnityEngine.UI;
using UnityEngine;

public class player : MonoBehaviour
{

    public GameObject final;
    public Text textcount;
    int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "teleport") 
        {
            final.SetActive(true);
        }
        if (collision.tag == "gem")
        {
            Destroy(collision.gameObject);

            count++;
            textcount.text = "寶石:" + count;
        }



    }
}
