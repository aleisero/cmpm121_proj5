using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    public GameObject UI;
    private bool UIon;
    
    // Start is called before the first frame update
    void Start()
    {
        UIon = true;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && UIon)
        {
            UIon = false;
            UI.SetActive(false);
        }
        else if (Input.GetKeyDown("space") && UIon == false)
        {
            UIon = true;
            UI.SetActive(true);
        }
    }
}
