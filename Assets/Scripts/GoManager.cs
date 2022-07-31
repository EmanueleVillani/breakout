using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoManager : MonoBehaviour
{
     
    public TextMeshProUGUI player1Name;
    public TextMeshProUGUI player1Points;
    public TextMeshProUGUI player2Name;
    public TextMeshProUGUI player2Points;
    public TextMeshProUGUI player3Name;
    public TextMeshProUGUI player3Points;
    public TextMeshProUGUI player4Name;
    public TextMeshProUGUI player4Points;
    public TextMeshProUGUI player5Name;
    public TextMeshProUGUI player5Points;

    // Start is called before the first frame update
    void Start()
    {
        player1Name.text = MenuManager.Instance.names[0];
        player1Points.text = MenuManager.Instance.points[0].ToString();
        player2Name.text = MenuManager.Instance.names[1];
        player2Points.text = MenuManager.Instance.points[1].ToString();
        player3Name.text = MenuManager.Instance.names[2];
        player3Points.text = MenuManager.Instance.points[2].ToString();
        player4Name.text = MenuManager.Instance.names[3];
        player4Points.text = MenuManager.Instance.points[3].ToString();
        player5Name.text = MenuManager.Instance.names[4];
        player5Points.text = MenuManager.Instance.points[4].ToString();
    }
   public void BtnBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
