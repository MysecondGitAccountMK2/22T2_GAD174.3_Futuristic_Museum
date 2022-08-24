using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIRaycaster : MonoBehaviour
{
    public GameObject infoCanvas;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit))
        {
            print("I'm looking at " + hit.transform.name);
            //check for a the layer mask
            LayerMask mask = LayerMask.GetMask("FuturisticJewellery");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    infoCanvas.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "BackButton")
                {
                    infoCanvas.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
            }
            LayerMask.GetMask("FuturisticSword");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    infoCanvas.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "BackButton")
                {
                    infoCanvas.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
            }
            LayerMask.GetMask("FuturisticMace");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    infoCanvas.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "BackButton")
                {
                    infoCanvas.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
            }
            LayerMask.GetMask("FuturisticBow");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    infoCanvas.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "BackButton")
                {
                    infoCanvas.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
            }
            LayerMask.GetMask("OldJewellery");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    infoCanvas.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "BackButton")
                {
                    infoCanvas.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
            }
            LayerMask.GetMask("OldSword");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    infoCanvas.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "BackButton")
                {
                    infoCanvas.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
            }
            LayerMask.GetMask("OldMace");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    infoCanvas.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "BackButton")
                {
                    infoCanvas.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
            }
            LayerMask.GetMask("OldBow");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    infoCanvas.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
                if (hit.transform.tag == "BackButton")
                {
                    infoCanvas.SetActive(false);
                    FindObjectOfType<AudioManager>().Play("Space_Button");
                }
            }


        }
        else
        {
            print("I'm looking at nothing!");
        }
    }
}

