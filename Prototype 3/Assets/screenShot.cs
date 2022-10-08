using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class screenShot : MonoBehaviour
{
    public icon cameraIcon;
    public string imageName;
    public GameObject imageManager;
    private void Start()
    {
        cameraIcon.screenShot.AddListener(GenerateImage);
    }
    private void OnMouseEnter()
    {
        if(cameraIcon.isDrag == true)
        {
            cameraIcon.isIn = true;
        }
    }

    private void OnMouseExit()
    {
        cameraIcon.isIn = false; 
    }

    private void GenerateImage()
    {
        GameObject NewObj = new GameObject(); //Create the GameObject
        Image NewImage = NewObj.AddComponent<Image>(); //Add the Image Component script
        NewImage.sprite = Resources.Load<Sprite>(imageName);
        NewObj.GetComponent<RectTransform>().SetParent(imageManager.transform); //Assign the newly created Image GameObject as a Child of the Parent Panel.
        NewObj.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        NewObj.SetActive(true); //Activate the GameObject
    }


}
