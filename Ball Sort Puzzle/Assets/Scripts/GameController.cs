using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameController Instance;
    public Text coin;
    public GameObject Cavas;
    public GameObject btplay;
    int addcoin=000;
    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(Cavas);
        coin.text = addcoin.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void BtplayClick()
    {
        btplay.SetActive(false);
        SceneManager.LoadScene(1);
    } 
  public  void AddCoin()
   {
        addcoin += 200;
        coin.text = addcoin.ToString();
    }
}
