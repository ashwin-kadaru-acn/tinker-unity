using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebRequest : MonoBehaviour
{

    private const string URL = "https://i.dailymail.co.uk/i/pix/2015/09/01/18/2BE1E88B00000578-3218613-image-m-5_1441127035222.jpg";

    public void Request() 
    {
        //Dont check in the same frame for the response
        WWW request = new WWW(URL);
        StartCoroutine(OnResponse(request));


    }

    private IEnumerator OnResponse(WWW req) 
    {
        yield return req;
        Debug.Log("Result: " + req.text);
        this.GetComponent<Renderer>().material.mainTexture = req.texture;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) {
            Request();
        }
    }
}
