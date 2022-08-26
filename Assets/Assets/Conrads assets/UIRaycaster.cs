using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIRaycaster : MonoBehaviour
{
    public GameObject futuristicJewelleryCanvas, futurisitcBowCanvas, futuristicMaceCanvas, futuristicSwordCanvas, oldJewelleryCanvas, oldBowCanvas, oldSowrdCanvas, oldMaceCanvas;
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

                    futuristicJewelleryCanvas.SetActive(true);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "BackButton")
                {
                    futuristicJewelleryCanvas.SetActive(false);
                    // FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
            }
            LayerMask futuristicsword = LayerMask.GetMask("FuturisticSword");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, futuristicsword))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    futuristicSwordCanvas.SetActive(true);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "PlayAudio")
                {
                    FindObjectOfType<AudioManager>().Play("TTS_Future_Sword");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "BackButton")
                {
                    futuristicSwordCanvas.SetActive(false);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
            }
            LayerMask futuristicmace = LayerMask.GetMask("FuturisticMace");
            
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, futuristicmace))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    futuristicMaceCanvas.SetActive(true);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Futuristic mace sounds");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "BackButton")
                {
                    futuristicMaceCanvas.SetActive(false);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
            }
            LayerMask futuristicbow = LayerMask.GetMask("FuturisticBow");
            
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, futuristicbow))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    futurisitcBowCanvas.SetActive(true);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Futuristic Crossbow Audio 1");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "BackButton")
                {
                    futurisitcBowCanvas.SetActive(false);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
            }
            LayerMask oldjewellery = LayerMask.GetMask("OldJewellery");
            LayerMask.GetMask("OldJewellery");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, oldjewellery))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    oldJewelleryCanvas.SetActive(true);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "BackButton")
                {
                    oldJewelleryCanvas.SetActive(false);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
            }
            LayerMask oldsword = LayerMask.GetMask("OldSword");
            LayerMask.GetMask("OldSword");
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, oldsword))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    oldSowrdCanvas.SetActive(true);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "PlayAudio")
                {
                    
                        
                    FindObjectOfType<AudioManager>().Play("TTS_Ancient_Sword");
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "BackButton")
                {
                    oldSowrdCanvas.SetActive(false);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
            }
            LayerMask oldmace = LayerMask.GetMask("OldMace");
            
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, oldmace))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    oldMaceCanvas.SetActive(true);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");

                }
                if (hit.transform.tag == "BackButton")
                {
                    oldMaceCanvas.SetActive(false);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
            }
            LayerMask oldbow = LayerMask.GetMask("OldBow");
            
            // Check if a Wall is hit.
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, oldbow))
            {
                if (hit.transform.tag == "InfoButton")
                {

                    oldBowCanvas.SetActive(true);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "PlayAudio")
                {

                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Old Crossbow Audio");
                    FindObjectOfType<AudioManager>().Play("Click");
                }
                if (hit.transform.tag == "BackButton")
                {
                    oldBowCanvas.SetActive(false);
                    //FindObjectOfType<AudioManager>().Play("Space_Button");
                    FindObjectOfType<AudioManager>().Play("Click");

                }
            }


        }
        else
        {
            print("I'm looking at nothing!");
        }
    }
}

