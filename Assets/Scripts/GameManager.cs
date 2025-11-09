using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance  { get; private set; }

    public bool isBlueBoxIn = false;
    public bool isGreenBoxIn = false;
    public bool isRedBoxIn = false;

    public int currentGameLevel = 1;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void toLevel2()
    {

        if(currentGameLevel == 1)
        {
            
            if(isBlueBoxIn && isGreenBoxIn && isRedBoxIn)
            {
                SceneManager.LoadScene("Level2");
            }

        }
        
    }

    void Update()
    {

        toLevel2();

    }
    
}
