using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//all text is hardcoded bc this is was a prototype
public class GameScript : MonoBehaviour
{
    public string[] places;
    public string[] special_places;

    public string[] dark_forest_events;

    public Text place_text;
    public string place_string;

    public Text enemy_text;
    public string enemy_string;

    public Text text1; public string text10;//1
    public Text text2; public string text20;//2
    public Text text3; public string text30;//3
    public Text text4; public string text40;//4

    public Text event_text;
    public string event_string;

    public Text window_text;
    public string window_string;

    public GameObject window;
    public GameObject window_dead;
    public GameObject side_window;
    public GameObject side_window_empty;

    public Text window_text_dead;
    public string window_string_dead;

    
    
    public int food, sleep,hp;
    public Text food_text,sleep_text,hp_text; 
    public string place;

    
 


    void Start()
    {
        place_text.text = "" + place_string;
        enemy_text.text =  enemy_string + "";
        text1.text = "" + text10;
        text2.text = "" + text20;
        text3.text = "" + text30;
        text4.text = "" + text40;
        event_text.text = "" + event_string;
        window_text.text = "" + window_string;
        //food_text.text = "еда: " + food;
        //sleep_text.text = "уст: " + sleep;
       // hp_text.text = "жзн: " + hp;
    }

    public void side_1() {
        
            side_window.SetActive(true);
    }
    public void side_0()
    {

        side_window.SetActive(false);
    }


    public void  onClick()
    {
        window_string = "The food you found in your pocket distracted the wolf and saved your life (-10 food)";
        food = food - 10;
        window_text.text = "" + window_string;
        window.SetActive(true);
        
    }

    public void onClick2()
    {
        window_string = "A sword strike to the wolf's heart ended his life";
        window_text.text = "" + window_string;
        window.SetActive(true);

    }

    public void onClick3()
    {
        window_string = "Probably the most unfortunate solution in this situation, but it succeeded (+15 fatigue).";
        sleep = sleep - 15;
        window_text.text = "" + window_string;
        window.SetActive(true);

    }

    public void onClick4()
    {
        window_string = "You got down on all fours and growled as a bear. I guess the wolf didn't appreciate your acting skills.";
        hp = hp - 999;
        window_text.text = "" + window_string;
        window.SetActive(true);

    }
    public void windowbutt()

    {
       food_text.text = "" + food;
       sleep_text.text = "" + sleep;
       hp_text.text = "" + hp;
        window.SetActive(false);
        if (hp<= 0) {
            window_string_dead = "You're dead";
            window_text_dead.text = "" + window_string_dead;
            
            window_dead.SetActive(true);
        }
        if (food<=0){
            window_string_dead = "You starved to death";
            window_text_dead.text = "" + window_string_dead;
            window_dead.SetActive(true);
        }
        if(sleep<=0) {
            window_string_dead = "Fainting you fall on your sword. What an ironic death";
            window_text_dead.text = "" + window_string_dead;
            window_dead.SetActive(true);
        }
        start_new_event();

        

    }
    public void windowdead()

    {
        SceneManager.LoadScene(0);

    }
    public void start_new_event()
    {

    }
}

