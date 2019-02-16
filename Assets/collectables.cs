using UnityEngine.UI;
using UnityEngine;

public class collectableScript : MonoBehaviour
{
    private int count = 0;
    private int delay = 0;
    private bool okPickUp = true;
    public GameObject canvas;

    private void Update()
    {
        delay++;
        if (delay == 15)
        {
            okPickUp = true;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (okPickUp)
        {
            Destroy(collider.gameObject);
            okPickUp = false;
            delay = 0;
            count++;
            
            //update UI element with count
            //canvas.GetComponent<Text>().text = count.ToString();
        }
    }
}
