using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets.Scripts
{
    class InfoPanel : MonoBehaviour
    {
        [SerializeField] private Slider _helthBar;
        [SerializeField] private Image _weaponIcon;
        [SerializeField] private TMP_Text _money;
    }
}
