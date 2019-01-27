using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Plot : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCamera;
    public TextMeshProUGUI tmp1;
    public GameObject earth;
    public GameObject earth1;
    public GameObject ice_earth;
    public GameObject newspenal;
    public GameObject board;
    public UI u;
    public GameObject next_button;
    public TextMeshProUGUI option1;
    public TextMeshProUGUI option2;
    public TextMeshProUGUI option3;
    public TextMeshProUGUI poptext;
    public TextMeshProUGUI engtex;
    public TextMeshProUGUI des;
    public Text button1_text;
    public Text button2_text;
    public Text button3_text;
    public Text button4_text;
    public Text button5_text;
    public Text button6_text;


    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    Camera mCamera;
    public GameObject attri;
    public GameObject panel;
    public GameObject galaxy;
    public bool is_turn;
    public float engine_number;
    public float population;
    public float satisfaction;
    public int turn;
    private int oa1;
    private int oa2;
    private int oa3;
    private int cutscene_num;
    private float movement_counter = 0f;
    private string[] q1 = new string[] { "Some media starts questioning the validity of the Project Gypsy, peaching that it is a hoax of our committee. Should we enhance the censorship of press and media, and punish these skeptics?",
        "b", "c", "d", "e", "f", "g", "h"};
    private string[] q2 = new string[] { "We will consume a huge amount of resource in the following travel. The Science Committee of the United Government suggests us increasing the exploitation and collection of combustible materials. While some other scientist organizations assert that it will greatly deteriorate the environment and annihilate many species. " ,
        "b2", "c2", "d2", "e", "f", "g", "h"};
    private string[] q3 = new string[] { "In prediction, tsunamis will attack all coastal area in the world, we need to consider resettle the coastal population. ",
        "b3", "c3", "d3", "e", "f", "g", "h"};
    private string[] d1 = new string[] { "a", "b", "c", "d", "e", "f", "g", "h"};
    private string[] d2 = new string[] { "a", "b", "c" , "d", "e", "f", "g", "h" };
    private string[] d3 = new string[] { "a", "b", "c" , "d", "e", "f", "g", "h" };
    private string[] dialog = new string[] { "da", "db", "dc", "dd", "de", "df", "dg" };
    private string[] news1yes = new string[] { "na", "nb", "nc", "nd", "ne", "nf", "ng" };
    private string[] news1no = new string[] { "na", "nb", "nc", "nd", "ne", "nf", "ng" };
    private string[] news2yes = new string[] { "na", "nb", "nc", "nd", "ne", "nf", "ng" };
    private string[] news2no = new string[] { "na", "nb", "nc", "nd", "ne", "nf", "ng" };
    private string[] news3yes = new string[] { "na", "nb", "nc", "nd", "ne", "nf", "ng" };
    private string[] news3no = new string[] { "na", "nb", "nc", "nd", "ne", "nf", "ng" };
    private string[] begining = new string[] { "ba", "bb", "bc", "bd", "be", "bf", "bg" };
    private string[] q1yes = new string[] { "yes1", "yes2", "yes3", "yes4", "yes", "yes", "yes", "yes" };
    private string[] q2yes = new string[] { "yes1", "yes2", "yes3", "ye4s", "yes", "yes", "yes", "yes" };
    private string[] q3yes = new string[] { "yes1", "yes2", "yes3", "yes", "yes", "yes", "yes", "yes" };
    private string[] q1no = new string[] { "no1", "no2", "no3", "no", "no", "no", "no", "no"};
    private string[] q2no = new string[] { "no1", "no2", "no3", "no", "no", "no", "no", "no" };
    private string[] q3no = new string[] { "no1", "no2", "no3", "no", "no", "no", "no", "no" };
    private int[] q1yes_e = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q1yes_s = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q1yes_p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q1no_e = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q1no_s = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q1no_p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q2yes_e = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q2yes_s = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q2yes_p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q2no_e = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q2no_s = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q2no_p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q3yes_e = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q3yes_s = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q3yes_p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q3no_e = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q3no_s = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private int[] q3no_p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };








    void Start()
    {
        mCamera = mainCamera.GetComponent<Camera>();
        is_turn = true;
        turn = 1;
        tmp1.SetText("");
        next_button.gameObject.SetActive(!is_turn);
        newspenal.SetActive(is_turn);

        engine_number = 911f;
        population = 73f;
        option1.text = q1[0];
        option2.text = q2[0];
        option3.text = q3[0];
        cutscene_num = 1;
        des.text = "";



    }

    void Setbutton()
    {
        button1_text.text = q1yes[turn-1];
        button2_text.text = q1no[turn - 1];
        button3_text.text = q2yes[turn - 1];
        button4_text.text = q2no[turn - 1];
        button5_text.text = q3yes[turn - 1];
        button6_text.text = q3no[turn - 1];
    }
    public void clickapply()
    {
        if (u.a1 != 0 && u.a2 != 0 && u.a3 != 0)
        {
            is_turn = false;
            applynumber();
            turn++;
            if (turn == 9)
            { Wingame(); }

            panel.SetActive(is_turn);
            attri.SetActive(is_turn);
            newspenal.SetActive(is_turn);
            earth.SetActive(is_turn);
            board.SetActive(is_turn);
            earth1.SetActive(is_turn);
            ice_earth.SetActive(is_turn);
            next_button.gameObject.SetActive(!is_turn);
            galaxy.gameObject.SetActive(is_turn);
            galaxy.gameObject.transform.Translate(new Vector3(movement_counter * 2.0f, 0, 0));
            tmp1.SetText(dialog[turn-1]);
            oa1 = u.a1;
            oa2 = u.a2;
            oa3 = u.a3;
        }
    }

    void Wingame()
    {
        SceneManager.LoadScene("survive");
    }

    void applynumber()
    {
            if (u.a1 == 1)
            {
          
                engine_number += q1yes_e[turn-1];
                population += q1yes_p[turn - 1];
                satisfaction += q1yes_s[turn - 1];
            }
            else if (u.a1 == 2)
            {
         
                engine_number += q1no_e[turn - 1];
                population += q1no_p[turn - 1];
                satisfaction += q1no_s[turn - 1];
            }
            if (u.a2 == 1)
            {
                engine_number += q2yes_e[turn - 1];
                population += q2yes_p[turn - 1];
                satisfaction += q2yes_s[turn - 1];
            }
            else if (u.a2 == 2)
            {
                engine_number += q2no_e[turn - 1];
                population += q2no_p[turn - 1];
                satisfaction += q2no_s[turn - 1];
            }
            if (u.a3 == 1)
            {
                engine_number += q3yes_e[turn - 1];
                population += q3yes_p[turn - 1];
                satisfaction += q3yes_s[turn - 1];
            }
            else if (u.a3 == 2)
            {
                engine_number += q3no_e[turn - 1];
                population += q3no_p[turn - 1];
                satisfaction += q3no_s[turn - 1];
            }


    }

        
    public void Cutscene() {
        if (cutscene_num == 1)
        {
            cutscene_num++;
            News(); }
        else if (cutscene_num == 2)
        { cutscene_num++; intro(); }
        else if (cutscene_num == 3)
        { back_to_choice(); }
    }

    public void intro() {
        tmp1.SetText(begining[turn - 1]);
    }

    public void News() {
        string x = "";
        if (oa1 == 1)
        { x += news1yes[turn - 1]; }
        else if (oa1 == 2)
            x += news1no[turn - 1];
        if (oa2 == 1)
        { x += news2yes[turn - 1]; }
        else if (oa2== 2)
            x += news2no[turn - 1];
        if (oa3 == 1)
        { x += news3yes[turn - 1]; }
        else if (oa3 == 2)
            x += news3no[turn - 1];

        tmp1.SetText(x);

    }

    public void back_to_choice()

    {
            is_turn = true;
            panel.SetActive(is_turn);
            attri.SetActive(is_turn);
            earth.SetActive(is_turn);
            earth1.SetActive(is_turn);
            newspenal.SetActive(is_turn);
            ice_earth.SetActive(is_turn);
            board.SetActive(is_turn);
            next_button.gameObject.SetActive(!is_turn);
            galaxy.gameObject.SetActive(is_turn);
            tmp1.SetText("");
            option1.text = q1[turn - 1];
            option2.text = q2[turn - 1];
            option3.text = q3[turn - 1];


            movement_counter = 0f;
            u.a1 = 0;
            u.a2 = 0;
            u.a3 = 0;
            check_earth();

        cutscene_num = 1;
    }

    void check_earth()
    {
        if (turn == 3)
        {
            earth.transform.Translate(new Vector3(600, 0, 0));
            earth1.transform.Translate(new Vector3(0, -300, 0));
        }

        if (turn == 5)
        {
            earth1.transform.Translate(new Vector3(600, 0, 0));
            ice_earth.transform.Translate(new Vector3(0, -300, 0));

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (is_turn)
        {
            Setbutton();
            movement_counter += 1.0f * Time.deltaTime;

            if (box1.GetComponent<mouseover>().is_over && !box2.GetComponent<mouseover>().is_over && !box3.GetComponent<mouseover>().is_over)
            { des.text = d1[turn - 1]; }
            else if (!box1.GetComponent<mouseover>().is_over && box2.GetComponent<mouseover>().is_over && !box3.GetComponent<mouseover>().is_over)
            { des.text = d2[turn - 1]; }
            else if (!box1.GetComponent<mouseover>().is_over && !box2.GetComponent<mouseover>().is_over && box3.GetComponent<mouseover>().is_over)
            { des.text = d3[turn - 1]; }
            else
            { des.text = ""; }

            engtex.text = string.Format("Engine: {0:0}/1225", engine_number);
            poptext.text = string.Format("Population(billions): {0:0.0}", population);


        }


        //Debug.Log(turn);
  
     
      //  Debug.Log(u.a1 + ":" + u.a2 + ": " + u.a3);
    }
}
