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
        "To ensure the plenty of food and energy, the United Government committee suggests us to limit the food supplies to the population. All families will receive a certain amount of food according to the allocation plan monthly.",
        "The Space Administration of United Government suggests enforcedly revoking the colony on Mars.",
        "A proposal about population control is put forward to the committee. ",
        "e", "f", "g", "h"};
    private string[] q2 = new string[] { "We will consume a huge amount of resource in the following travel. The Science Committee of the United Government suggests us increasing the exploitation and collection of combustible materials. While some other scientist organizations assert that it will greatly deteriorate the environment and annihilate many species. " ,
        "One proposal from the United Government Committee suggests updating current robot workers to X-445 type to substitute the use of human power. While another proposal suggests extending human workers’ working hour to 15 hrs from 8 hrs to reduce the usage of robots, to save more energy for the interplanetary traveling engine.",
        "The Science Committee of the United Government estimated that the temperature on the Earth will plunge while the travel distance increases. We might need to use some resource for the construction of the underground cities so that all population on the planet could avoid the cold.",
        "The science department of the Unity Government will start the backup energy storage in the polar area, and now we need the committee to allocate the energy for future plan.",
        "e", "f", "g", "h"};
    private string[] q3 = new string[] { "In prediction, tsunamis will attack all coastal area in the world, we need to consider resettle the coastal population. ",
     "The Science Department of the United Government submitted two research proposal, but we can select one of them to execute because of the limitation in resources. ",
        "The committee adviced us to monitor power usage to control consumption. Every individual could only use power for 10 hrs within a certain limit per day.",
        "The Space Administration detected a meteorite approaching the Earth. According to the  prediction, even if an n-bomb is shot to intercept the meteorite, the fragment will land on the Earth and cause possible death. The only way to avoid disaster is to turn off partial engines to avoid most fragments.",
        "e", "f", "g", "h"};
    private string[] d1 = new string[] { "Allowed: The United Government decided to block all wemedia and social media. All news needs to be reviewed before being released to the public. All rumor makers will be convicted of disturbing stability."+"\n"+" Senator Suggestion: Censorship of media could benefit the productivity of the United Government, but is potential to cause violent protests against the government."+"\n"+ "Not Allowed: The United Government should allow free speech of media and ensure the freedom of each individuals."+"\n"+ "Senator Suggestion: A certain quantity of rumors can seriously damage the stability of the society.",
        "Allowed:The United Government will establish a strict limit on food production and supply."+"\n"+"Senator Suggestion: Limiting supplies will enforce the power of the United Government, and resources saved will be used for the interplanetary traveling engine. But this policy may cause new protest against the government among the public. "+"\n"+"Not Allowed: The United Government denies the proposal of food limitation."+"\n"+"Senator Suggestion: If we deny this proposal, then enough food supplies will ensure the increase in population.",
        "Revoke: Revoke Mars colony to absorb population and resources on Mars."+"\n"+"Senator Suggestion: Revoking Mars colony will bring us more human and natural resource, but this may meet with violent opposition from Mars colony Army."+"\n"+"Not Revoke:Don’t revoke the Mars colony."+"\n"+"Senator Suggestion:We don’t have extra energy to control the Mars Colony. If they would wait to get killed then let them go.",
        "Yes:Decrease the birth rate by policy."+"\n"+"Senator Suggestion: We should put the population under control immediately. Otherwise, the energy we possess currently is not enough for us to escape the attraction field created by Jupiter."+"\n"+"No: Don’t limit the birth rate."+"Senator Suggestion: We shouldn’t deprive the right of generational freedom so we can ensure to have enough population for future traveling.",
        "e", "f", "g", "h"};
    private string[] d2 = new string[] { "Yes:The United Government will dispatch workers to exploit mineral and gas hydrate around the world. Most trees in the conservation areas will be collected as subsidiary fuel. Whale oil will become industrial resource again."+"\n"+ "Senator Suggestion: We should be prepared to use more resource to confront all possibilities in the future. Our scientists are capable of backup DNAs of all species. This is just a tempory sacrifice. But the massive industrial production certainly will cause the loss of workers. "+"\n"+ "No:Currently, the saving of resources on this planet and other planets that we could reach is enough for Project Gypsy, so there is no need to exploit more resources."+"\n"+ "Senator Suggestion: We shouldn’t consume extra worker power and adopt an out-dated approach to get spare resources. ",
        "Yes:Extend the working hour to decrease usage of robots."+"\n"+"Senator Suggestion: Prolonging working hours may cause the frustration of workers, but updating and using robots must cause tremendous energy consumption in energy. We maintain the operation of the traveling engine first."+"\n"+"No:Updating robots to substitute for human workers."+"\n"+"Senator Suggestion: We don’t have to exhaust primitive human power. Although updating robots will diverge partial energy from the engine, this amount is not large enough to affect our traveling plan.",
        "Build: We decide to turn off some engine and use the resource for underground cities."+"\n"+"Senator Suggestion: The only selection we have is to protect our people from the upcoming Ice age, or all human beings will be destroyed by the climate. "+"\n"+"Not build: We decide not to turn off the engine and not to build the underground cities." +"\n"+"Senator Suggestion:We don’t have to build underground cities since the temperature controlling system we have now is good enough.",
        "Hospitals: We choose to use the backup energy in medical facilities."+"\n"+"Engine: We choose to use the backup energy to restart inactive engines.",
        "e", "f", "g", "h" };
    private string[] d3 = new string[] { "City: A great quantity of coastal population stampede into inland cities. All local governments will set placement for refugees. "+"\n"+"Senator Suggestion: The large-scale immigration may cause chaos in inland cities. "+"\n"+"Mountains: Move the population to inland mountain areas."+"\n" + "Senaotr Suggestion: We could move the coastal population to inland mountain areas, but building new residences in under such severe condition certainly will lead to the decreasing in population, to some degree.",
        "Secure:Equip the security group with new remote stun guns to efficiently suppress protesters."+"\n"+"Agriculture: The agriculture department invented crops that can grow in constant sunshine which could offer more food supplies if grown on a large scale.",
        "Allowed: All energy should first ensure the usage for the interplanetary traveling engine."+"\n"+"Senator Suggestion: Limiting power usage will cause unsatisfaction in public. In the darkness lasting for 11 months, only lights can comfort our citizens. But the energy we saved with this policy could be used for the interplanetary travel in the future."+"\n"+"Not Allowed: We won’t interfere citizens’ rights of using electricity. "+"\n"+"Senator Suggestion: We shouldn’t limit electricity usage because our resources could afford the usage of the public.",
        "d", "e", "f", "g", "h" };
    private string[] dialog = new string[] { "“Those commanders are liars. The whole damn project is a bullshit. They made a lie that the Sun will die out to exploit us. They just wanna suck our blood on their sinecures.” ",
        "“We’ve never thought the sun would rise from the west, but now even the sunrise becomes the wonder that can be seen every 6 months.”",
        "“Built the massive engine, dug the underground hollow, now they continue to construct cities under the surface. They are crazy. The whole world is crazy. ”",
        "dd", "de", "df", "dg" };
    private string[] news1yes = new string[] { "5 death in the violence protests while representative visiting at the central square of New London. This is the 25th vicious attack since the start of censorship in social media.", "Food allocation is announced by the United Government. Citizens can claim their distributions at the city center before next month.",
        "The Mars colony Army is defeated in 3 hrs in the battle with the United Government Army at Resource Site - J56.",
        "Residents of Community-xxx get sterilization under the monitor of United Government.",
        "ne", "nf", "ng" };
    private string[] news1no = new string[] { "Around 2000 people participated in the second protest against “Project Gypsy” this week in New London. ", "The 10,000,000th newborn since the start of Project Gypsy is born in the hospital yesterday night. The next generation is our hope, and the legend of Project Gypsy will be engraved in the mind of our offsprings. ",
        "",
        "Engine-544 is turned off to assure the energy needed for the boom in population.",
        "ne", "nf", "ng" };
    private string[] news2yes = new string[] { "45 miners trapped underground in a mine in South Africa when it sudden collapsed.", "Police of UG arrested the organizer of the worker strike in Engine-0377.",
        "The underground cities will be completed in Exodus Era 115 to ensure all people to move to relatively warm underground before the ice age.",
        "The committee decided to support all hospitals with backup energy. The effectiveness of hospitals increased to 45%.",
        "ne", "nf", "ng" };
    private string[] news2no = new string[] { "", "R2B2 security robot has served 50% work of the maintenance and protection of engines. Engine-0377 is turned off, but UG claims that it will be restarted when needed. ",
        "",
        "Engine-0922 is active with the backup energy supplies, accelerating the speed of our travel.",
        "ne", "nf", "ng" };
    private string[] news3yes = new string[] { "Police confirmed that the suspects of recent serial robbery are all from the coastal refugee camp.", "The security group of the United Government equipped xxx stun guns which could paralyze the object for 10 mins.",
        "The manager of the residency which illegally uses power is executed by shooting by the Security Department of the United Government.",
        "nd", "ne", "nf", "ng" };
    private string[] news3no = new string[] { "The refugee camp near Mount Annulii lost connection. Investigator reported the camp is covered by ice. Further analysis shows that the shutdown of power caused the loss of control of the temperature controlling system. ", "The 6-month night in the western hemisphere will end soon, new crop is already planted in the area to welcome the coming daytime.",
        "Retrospect: In xxxx, there was no light in the night in North Korea, but now under the leading of the United Government, NK could keep lights open for the 11-month nighttime.",
        "nd", "ne", "nf", "ng" };
    private string[] begining = new string[] { "Deceleration Era, 055"+"\n"+"The autorotation of the Earth is nearly stopped. The United Government claims the second phase of Project Gypsy will begin after 15 years. By that time, the Earth will gradually escape from the attractions of other planets and eventually leave the solar system. ", "Exodus Era 005"+"\n"+"The second phase of Project Gypsy starts. Now the Earth is under the attraction of Mars. The temperature will decrease while we generally escape the solar system and get further from the Sun, in the future.",
        "Exodus Era 0110"+"\n"+"The Underground Cities are almost completed, to keep us warm in the Ice age. Now the Earth is under the attraction of Jupiter, which has the biggest mass in the solar system. To escape the huge attraction, the science department plans to start using temporary resource reserves in the polar area. ",
        "bd", "be", "bf", "bg" };
    private string[] q1yes = new string[] { "Allowed", "Allowed", "Revoke", "Yes", "yes5", "yes6", "yes7", "yes8" };
    private string[] q2yes = new string[] { "Yes", "Yes", "Build", "Hospitals", "yes5", "yes6", "yes7", "yes8" };
    private string[] q3yes = new string[] { "City", "Secure", "Allowed", "yes4", "yes5", "yes6", "yes7", "yes8" };
    private string[] q1no = new string[] { "Not Allowed", "Not Allowed", "Not revoke", "No", "no5", "no6", "no7", "no8"};
    private string[] q2no = new string[] { "No", "No", "Not Build", "Engine", "no5", "no6", "no7", "no8" };
    private string[] q3no = new string[] { "Mountains", "Agriculture", "Not Allowed", "no4", "no5", "no6", "no7", "no8" };
    [SerializeField] private int t1_q1_e;
    [SerializeField] private int t1_q1_p;
    [SerializeField] private int t1_q1_s;
    [SerializeField] private int t1_q2_e;
    [SerializeField] private int t1_q2_p;
    [SerializeField] private int t1_q2_s;
    [SerializeField] private int t1_q3_e;
    [SerializeField] private int t1_q3_p;
    [SerializeField] private int t1_q3_s;
    [SerializeField] private int t2_q1_e;
    [SerializeField] private int t2_q1_p;
    [SerializeField] private int t2_q1_s;
    [SerializeField] private int t2_q2_e;
    [SerializeField] private int t2_q2_p;
    [SerializeField] private int t2_q2_s;
    [SerializeField] private int t2_q3_e;
    [SerializeField] private int t2_q3_p;
    [SerializeField] private int t2_q3_s;
    [SerializeField] private int t3_q1_e;
    [SerializeField] private int t3_q1_p;
    [SerializeField] private int t3_q1_s;
    [SerializeField] private int t3_q2_e;
    [SerializeField] private int t3_q2_p;
    [SerializeField] private int t3_q2_s;
    [SerializeField] private int t3_q3_e;
    [SerializeField] private int t3_q3_p;
    [SerializeField] private int t3_q3_s;
    [SerializeField] private int t4_q1_e;
    [SerializeField] private int t4_q1_p;
    [SerializeField] private int t4_q1_s;
    [SerializeField] private int t4_q2_e;
    [SerializeField] private int t4_q2_p;
    [SerializeField] private int t4_q2_s;
    [SerializeField] private int t4_q3_e;
    [SerializeField] private int t4_q3_p;
    [SerializeField] private int t4_q3_s;
    [SerializeField] private int t5_q1_e;
    [SerializeField] private int t5_q1_p;
    [SerializeField] private int t5_q1_s;
    [SerializeField] private int t5_q2_e;
    [SerializeField] private int t5_q2_p;
    [SerializeField] private int t5_q2_s;
    [SerializeField] private int t5_q3_e;
    [SerializeField] private int t5_q3_p;
    [SerializeField] private int t5_q3_s;
    [SerializeField] private int t6_q1_e;
    [SerializeField] private int t6_q1_p;
    [SerializeField] private int t6_q1_s;
    [SerializeField] private int t6_q2_e;
    [SerializeField] private int t6_q2_p;
    [SerializeField] private int t6_q2_s;
    [SerializeField] private int t6_q3_e;
    [SerializeField] private int t6_q3_p;
    [SerializeField] private int t6_q3_s;
    [SerializeField] private int t7_q1_e;
    [SerializeField] private int t7_q1_p;
    [SerializeField] private int t7_q1_s;
    [SerializeField] private int t7_q2_e;
    [SerializeField] private int t7_q2_p;
    [SerializeField] private int t7_q2_s;
    [SerializeField] private int t7_q3_e;
    [SerializeField] private int t7_q3_p;
    [SerializeField] private int t7_q3_s;
    [SerializeField] private int t8_q1_e;
    [SerializeField] private int t8_q1_p;
    [SerializeField] private int t8_q1_s;
    [SerializeField] private int t8_q2_e;
    [SerializeField] private int t8_q2_p;
    [SerializeField] private int t8_q2_s;
    [SerializeField] private int t8_q3_e;
    [SerializeField] private int t8_q3_p;
    [SerializeField] private int t8_q3_s;





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
