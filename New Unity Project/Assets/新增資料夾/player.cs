
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject final;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("touched");
        final.SetActive(true);
    }
}
