using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
public class Jump : MonoBehaviour
{
    public GameObject panel;
    public bool isRun;

    public TextMeshProUGUI score;
    public int scoreInt;
    public AudioSource jump;
    public AudioClip clip;
    public KeyCode key;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
         panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
             
        if(Input.GetKey(key))
        {
            rb.velocity = new Vector2(0,5);
            jump.Play();

        } 
    }


    private void OnCollisionEnter2D(Collision2D other) {

        
        isRun = false;
        panel.SetActive(true);
        Time.timeScale = 0.0f;

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("pipe"))
        {
            scoreInt += 1;
            score.text = scoreInt.ToString();
        }
    }


    public void restart()
    {
        panel.SetActive(false);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("bird");
    }

    public void menu() {
        Time.timeScale = 0.0f;
        SceneManager.LoadScene("menu");
    }
}
//30 -30