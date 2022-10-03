using UnityEngine;

namespace CodeBase.UI.SkinMenu
{
    public class SkinPlayer : MonoBehaviour
    {
        [SerializeField] private GameObject skinMenu;
        
        public void Play() => 
            Destroy(skinMenu);
    }
}