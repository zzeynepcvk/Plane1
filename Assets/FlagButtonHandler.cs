using UnityEngine;
using UnityEngine.UI;

public class FlagButtonHandler : MonoBehaviour
{
    public Button franceButton; // Fransa bayrağı butonu
    public Button usaButton;    // Amerika bayrağı butonu

    // Start metodunda butonlara tıklama işlevi ekleniyor
    void Start()
    {
        // Bayrak butonlarına tıklama olayları ekleniyor
        franceButton.onClick.AddListener(OnFranceButtonClick);
        usaButton.onClick.AddListener(OnUSButtonClick);
    }

    // Fransa bayrağına tıklanınca yapılacak işlem
    void OnFranceButtonClick()
    {
        Debug.Log("Fransa bayrağına tıkladınız!");
        // Burada AR sahnesine geçiş yapabilirsiniz
    }

    // Amerika bayrağına tıklanınca yapılacak işlem
    void OnUSButtonClick()
    {
        Debug.Log("Amerika bayrağına tıkladınız!");
        // AR sahnesine geçiş veya başka bir işlem yapılabilir
    }
}
