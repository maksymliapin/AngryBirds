using System;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI.SkinMenu
{
    public class ChoiceSkinController : MonoBehaviour
    {
        [SerializeField] private GameObject skin;
        [SerializeField] private SkinBird bird;
        [SerializeField] private GameObject textHeader;
        [SerializeField] private GameObject blockText;
        [SerializeField] private string header;
        [SerializeField] private string text;


       public void Click()
        {
            Debug.Log("here");
            if (bird.CurrentSkin != null)
            {
                bird.CurrentSkin.SetActive(false);
            }
            bird.CurrentSkin = skin;
            bird.CurrentSkin.SetActive(true);
            textHeader.GetComponent<Text>().text = header;
            blockText.GetComponent<Text>().text = text;
        }
        
    }
}