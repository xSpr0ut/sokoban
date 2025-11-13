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

    private void ChangeLevel()
    {

        switch(currentGameLevel){

            case 1:
            
                if (isBlueBoxIn && isGreenBoxIn && isRedBoxIn)
                {

                    currentGameLevel++;

                    isBlueBoxIn = false;
                    isGreenBoxIn = false;
                    isRedBoxIn = false;

                    SceneManager.LoadScene("Level2");
                }

                break;

            case 2:

                if (isBlueBoxIn && isGreenBoxIn && isRedBoxIn)
                {

                    currentGameLevel++;

                    isBlueBoxIn = false;
                    isGreenBoxIn = false;
                    isRedBoxIn = false;

                    SceneManager.LoadScene("Level3");
                }

                break;


            case 3:

                Debug.Log("Case 3 running");

                if (isBlueBoxIn && isGreenBoxIn && isRedBoxIn)
                {

                    Debug.Log("Case 3 true");

                    currentGameLevel++;

                    isBlueBoxIn = false;
                    isGreenBoxIn = false;
                    isRedBoxIn = false;

                    SceneManager.LoadScene("End");
                }
                
                Debug.Log("Case 3 false");

                break;
            

        

    }
        
    }

    void Update()
    {

        ChangeLevel();

        // for scene restart !!!

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    
}
