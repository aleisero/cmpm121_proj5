using UnityEngine;

public class collectableScript : MonoBehaviour
{
    //public bool isGot = false;

    public GameObject door;

    private int delay = 0;
    private bool okPickUp = true;
    

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
            okPickUp = false;
            delay = 0;

            //isGot = true;
            door.GetComponent<doorMove>().Unlock();

            gameObject.SetActive(false);   
        }
    }
}
