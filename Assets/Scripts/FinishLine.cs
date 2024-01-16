using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            Invoke("ReloadScene", reloadDelay);            
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
