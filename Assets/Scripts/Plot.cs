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
    public GameObject mars;
    public GameObject newspenal;
    public GameObject board;
    public GameObject jup;
    public GameObject hai;
    public GameObject tu;
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
        "The Science Department of the United Government decided to modify the body of residents in primary cities to enable them to accommodate to the harsh situation during the travel. But due to the lack of resources, the committee can only achieve one of the two modifications below.",
        "According to a report of security department, a rebellion group of modified soldiers plans to destroy the engine of the planetary. We need further order from the committee.",
        "Stratify the population",
        "Mandatory labor for lower class. We need to exploit the workforce of lower class. The committee asserts the existence of these population will only consume resources, so they should dedicate their everything to Project Gypsy. " };
    private string[] q2 = new string[] { "We will consume a huge amount of resource in the following travel. The Science Committee of the United Government suggests us increasing the exploitation and collection of combustible materials. While some other scientist organizations assert that it will greatly deteriorate the environment and annihilate many species. " ,
        "One proposal from the United Government Committee suggests updating current robot workers to X-445 type to substitute the use of human power. While another proposal suggests extending human workers’ working hour to 15 hrs from 8 hrs to reduce the usage of robots, to save more energy for the interplanetary traveling engine.",
        "The Science Committee of the United Government estimated that the temperature on the Earth will plunge while the travel distance increases. We might need to use some resource for the construction of the underground cities so that all population on the planet could avoid the cold.",
        "The science department of the Unity Government will start the backup energy storage in the polar area, and now we need the committee to allocate the energy for future plan.",
        "Since the start of Project Gypsy, the ancient Olympics games have been stopped for centuries. The committee suggests having the last Olympics before all human move into the underground cities. However, such an event certainly will consume extra energy.",
        "The science department plan to open the clone to offset the shortage in population in the third phase of Project Gypsy.",
        "The long-term drifting still needs a large sum of food supplies, the Science Committee urges to pass the proposal of recycling corpses to make more food. ",
        "Prohibit religion. A fresh religion emerged in each asylum. They advocate that only the true God can lead human to the real destination. Although we have enforced the censorship, we cannot stop the spread of this religion. The only solution is to execute the “Great Purge”." };
    private string[] q3 = new string[] { "In prediction, tsunamis will attack all coastal area in the world, we need to consider resettle the coastal population. ",
        "The Science Department of the United Government submitted two research proposal, but we can select one of them to execute because of the limitation in resources. ",
        "The committee adviced us to monitor power usage to control consumption. Every individual could only use power for 10 hrs within a certain limit per day.",
        "The Space Administration detected a meteorite approaching the Earth. According to the  prediction, even if an n-bomb is shot to intercept the meteorite, the fragment will land on the Earth and cause possible death. The only way to avoid disaster is to turn off partial engines to avoid most fragments.",
        "All residents will move to the underground cities, the committee advice us enforce the monitor and security of the underground cities. The stability of the underground cities is crucial to the success of Project Gypsy. ",
        "For the upcoming third phase, the committee plan to shut all entertainment programs to constrain the usage of energy.",
        "Exile felons to the space by small spacecraft to control the population",
        "Even the elimination of felons and disables could not revert the shortage in food, maybe now it is the time to make the most cruel choice..." };
    private string[] d1 = new string[] { "Allowed: The United Government decided to block all wemedia and social media. All news needs to be reviewed before being released to the public. All rumor makers will be convicted of disturbing stability."+"\n"+" Senator Suggestion: Censorship of media could benefit the productivity of the United Government, but is potential to cause violent protests against the government."+"\n"+ "Not Allowed: The United Government should allow free speech of media and ensure the freedom of each individuals."+"\n"+ "Senator Suggestion: A certain quantity of rumors can seriously damage the stability of the society.",
        "Allowed:The United Government will establish a strict limit on food production and supply."+"\n"+"Senator Suggestion: Limiting supplies will enforce the power of the United Government, and resources saved will be used for the interplanetary traveling engine. But this policy may cause new protest against the government among the public. "+"\n"+"Not Allowed: The United Government denies the proposal of food limitation."+"\n"+"Senator Suggestion: If we deny this proposal, then enough food supplies will ensure the increase in population.",
        "Revoke: Revoke Mars colony to absorb population and resources on Mars."+"\n"+"Senator Suggestion: Revoking Mars colony will bring us more human and natural resource, but this may meet with violent opposition from Mars colony Army."+"\n"+"Not Revoke:Don’t revoke the Mars colony."+"\n"+"Senator Suggestion:We don’t have extra energy to control the Mars Colony. If they would wait to get killed then let them go.",
        "Yes:Decrease the birth rate by policy."+"\n"+"Senator Suggestion: We should put the population under control immediately. Otherwise, the energy we possess currently is not enough for us to escape the attraction field created by Jupiter."+"\n"+"No: Don’t limit the birth rate."+"Senator Suggestion: We shouldn’t deprive the right of generational freedom so we can ensure to have enough population for future traveling.",
        "Biology: Prolong the lives of most scientists and engine mechanics. "+"\n"+"Secure: We could put cameras into the crystalline lens of each resident to monitor their views to prevent some rebellion from happening.",
        "Send Army: Dispatch a army to eliminate the revolters and sweep out related organizations."+"\n"+"Senator Suggestion: Stabilizing the society globally may bring a serie of skirmish, but we cannot ignore the warning from the secret service department."+"\n"+"Not Send: Ignore the warning from the secret service department."+"\n"+"Senator Suggestion: We don’t need to worry about their flaunting. They will be frozen before reaching the engine, which is in the cold terrain surface.",
        "Yes: We will have to distribute supplies according to the class one belongs to."+"\n"+"Senator Suggestions: Our resources are not enough for everyone, so the bottom of the society should stew in their own juice. "+"\n"+"No: Reject to stratify. We should cohere as a unity and get through all challenges."+"\n"+"Senator Suggestion: We could lower the resource for engines to produce more supplies.",
        "Allowed: We need the mandatory work from the lower class to acquire more resources for the project. "+"\n"+"Senator Suggetion: Their sacrifice will fulfill the survive of humankind. We have no choice, for the destination."+"\n"+"Not allowed: We shouldn’t exploit the lower class cruely at this moment."+"\n"+"Senator Suggestion: Our food supply cannot support so many heavy workers, so we shouldn’t give them such extra work." };
    private string[] d2 = new string[] { "Yes:The United Government will dispatch workers to exploit mineral and gas hydrate around the world. Most trees in the conservation areas will be collected as subsidiary fuel. Whale oil will become industrial resource again."+"\n"+ "Senator Suggestion: We should be prepared to use more resource to confront all possibilities in the future. Our scientists are capable of backup DNAs of all species. This is just a tempory sacrifice. But the massive industrial production certainly will cause the loss of workers. "+"\n"+ "No:Currently, the saving of resources on this planet and other planets that we could reach is enough for Project Gypsy, so there is no need to exploit more resources."+"\n"+ "Senator Suggestion: We shouldn’t consume extra worker power and adopt an out-dated approach to get spare resources. ",
        "Yes:Extend the working hour to decrease usage of robots."+"\n"+"Senator Suggestion: Prolonging working hours may cause the frustration of workers, but updating and using robots must cause tremendous energy consumption in energy. We maintain the operation of the traveling engine first."+"\n"+"No:Updating robots to substitute for human workers."+"\n"+"Senator Suggestion: We don’t have to exhaust primitive human power. Although updating robots will diverge partial energy from the engine, this amount is not large enough to affect our traveling plan.",
        "Build: We decide to turn off some engine and use the resource for underground cities."+"\n"+"Senator Suggestion: The only selection we have is to protect our people from the upcoming Ice age, or all human beings will be destroyed by the climate. "+"\n"+"Not build: We decide not to turn off the engine and not to build the underground cities." +"\n"+"Senator Suggestion:We don’t have to build underground cities since the temperature controlling system we have now is good enough.",
        "Hospitals: We choose to use the backup energy in medical facilities."+"\n"+"Engine: We choose to use the backup energy to restart inactive engines.",
        "Yes: We will hold this Olympics."+"\n"+"Senator Suggestion: All human beings will be coherent together for the largest and oldest sport contest, if we choose to hold the Olympics. In long term, it will benefit the domination of the government and greatly encourage the population. "+"No: We won’t hold the Olympics."+"\n"+"Senator Suggestion: We shouldn’t waste extra resources on unnecessary Olympics. The primary task now is to ensure the normal operation of the underground cities and the engines.",
        "Allowed: The science department will give citizens the right to clone themselves."+"\n"+"Senator Suggestion: Lifting the ban in clone will increase available human power for the industrial development, but this policy might bring potential policy threat."+"\n"+"Not allowed: Reject to lift the ban of clone technology."+"\n"+"Senator Suggestion: Since the emerge of clone technology, it has never been accepted by ethics, even at the harshest time in the history of human beings.",
        "Recycle: We will collect corpses to make more food."+"\n"+"Senator Suggestiton:All kind of resources including the organic parts of bodies should serve for Project Gypsy, and this plan should be kept as a secret from the residents. "+"\n"+"Not Recycle: We reject such inhumane proposal."+"Senator Suggestion: We are not so despair. There will be another way, for sure. ",
        "Prohibit: We will search every home and annihilate every individual related with this religion."+"\n"+"Senator Suggestion: We should stop this ridiculous thought, which instigates our people to give up the hope we have now, at all cost."+"\n"+"Not prohibit: We will not interfere the propagation of this new religion."+"\n"+"Despair people need a sustenance. Such a religion could help us keep the society stable. " };
    private string[] d3 = new string[] { "City: A great quantity of coastal population stampede into inland cities. All local governments will set placement for refugees. "+"\n"+"Senator Suggestion: The large-scale immigration may cause chaos in inland cities. "+"\n"+"Mountains: Move the population to inland mountain areas."+"\n" + "Senaotr Suggestion: We could move the coastal population to inland mountain areas, but building new residences in under such severe condition certainly will lead to the decreasing in population, to some degree.",
        "Secure:Equip the security group with new remote stun guns to efficiently suppress protesters."+"\n"+"Agriculture: The agriculture department invented crops that can grow in constant sunshine which could offer more food supplies if grown on a large scale.",
        "Allowed: All energy should first ensure the usage for the interplanetary traveling engine."+"\n"+"Senator Suggestion: Limiting power usage will cause unsatisfaction in public. In the darkness lasting for 11 months, only lights can comfort our citizens. But the energy we saved with this policy could be used for the interplanetary travel in the future."+"\n"+"Not Allowed: We won’t interfere citizens’ rights of using electricity. "+"\n"+"Senator Suggestion: We shouldn’t limit electricity usage because our resources could afford the usage of the public.",
        "Keep on: If we turn off some engines and decrease the thrust, Project Gypsy might fail because the leak of speed. History will remember the sacrifice we made."+"\n"+"Turn off: We should console our residents and pause some engines to avoid most casualties.",
        "Yes: Form more security groups and execute strict rules."+"\n"+"Senator Suggestion: We will make up more army and strict policies, but it certainly will cause the unsatisfaction of some citizens."+"\n"+"No: There is no need for us to enforce the security group."+"\n"+"Senator Suggestio: We should first comfort our people after entering the underground cities.",
        "Yes: The committee passed the proposal of shut all kinds of entertainment industry."+"\n"+"Senator Suggestion: Our focus should be how to survive, so we don’t have spare energy to support useless entertainment industry. "+"\n"+"No: The committee will maintain entertainment industry and offer reasonable power supply."+"\n"+"Senator Suggestion: We shouldn’t reduce the entertainment rights of our people. In the time of darkness, we need to keep our optimism.",
        "Allowed: We will exile all felons to space."+"\n"+"Senator Suggestion: These sinners are not valuable to keep alive since they seriously harmed others."+"\n"+"Not Allowed: We will not send felons to the space."+"\n"+"Senator Suggestion: We will not give up our people, no matter who they are and what they did.",
        "Annihilation: We will sweep out approximately the population of five asylums. The bodies of these victims will be recycled as food for the rest of the population. Everything worthwhile on the way to the livable galaxy. "+"\n"+"Senator Suggestion: The greatest behavior of human is sacrifice. Their sacrifice is a step of human on the way to survival."+"\n"+"Refuse: We will try to lower energy for the engine again to offer extra supplies to our people."+"\n"+"Senator Suggestion: We might cannot arrive the destination forever, if we turn off too many engines." };
    private string[] dialog = new string[] { "“Those commanders are liars. The whole damn project is a bullshit. They made a lie that the Sun will die out to exploit us. They just wanna suck our blood on their sinecures.” ",
        "“We’ve never thought the sun would rise from the west, but now even the sunrise becomes the wonder that can be seen every 6 months.”",
        "“Built the massive engine, dug the underground hollow, now they continue to construct cities under the surface. They are crazy. The whole world is crazy. ”",
        "“Mummy! So many meteors! Let’s make a wish moving to a new home quickly! ”",
        "“Life originates from the sea, thrives on the ground, but now crouches below the surface.”",
        "“Death is a wall that extanded to infinety.”",
        "“The conflicts in the jail indicated how much they hate the government. We can’t repair it, then we should no longer repair it.” ", "" };
    private string[] news1yes = new string[] { "5 death in the violence protests while representative visiting at the central square of New London. This is the 25th vicious attack since the start of censorship in social media.", "Food allocation is announced by the United Government. Citizens can claim their distributions at the city center before next month.",
        "The Mars colony Army is defeated in 3 hrs in the battle with the United Government Army at Resource Site - J56.",
        "Residents of Community-xxx get sterilization under the monitor of United Government.",
        "The United Government prolongs the lives of scientists, and assert that this technology will be used to every resident in the future.",
        "On the ice surface at the south pole, brave United Army had fierce battle with the revolters. The government claims that they will extirpate all stronghold of the rebel organization.",
        "Battle for supplies in Underground Site-043 and Site-102 [Only Permitted to View By UG Members]" , "" };
    private string[] news1no = new string[] { "Around 2000 people participated in the second protest against “Project Gypsy” this week in New London. ", "The 10,000,000th newborn since the start of Project Gypsy is born in the hospital yesterday night. The next generation is our hope, and the legend of Project Gypsy will be engraved in the mind of our offsprings. ",
        "",
        "Engine-544 is turned off to assure the energy needed for the boom in population.",
        "The United Government will offer lens improvement surgery to every resident of the underground cities to make your vision better in dark environment. It’s free. Please go to the nearest hospital and get your vision better!",
        "",
        "The Space Administration of United Government reports that the energy used for producing supplies will approximately delay our arrival by 5.2%. [Only Permitted to View By UG Members]" , ""};
    private string[] news2yes = new string[] { "45 miners trapped underground in a mine in South Africa when it sudden collapsed.", "Police of UG arrested the organizer of the worker strike in Engine-0377.",
        "The underground shutters will be completed in Exodus Era 115 to ensure all people to move to relatively warm underground before the ice age.",
        "The committee decided to support all hospitals with backup energy. The effectiveness of hospitals increased to 45%.",
        "The Olympics is held on the large ice surface on Hawaii Island. This Olympics is the first sport meeting since the Project Gypsy started. Citizens from different cities participated traditional sports in winter Olympics.",
        "A homicide in Underground Site-101 attracted the attention of the security department. The victim and suspect have the same DNA. The security department plans to mark each clone individuals to make a distinction.",
        "Someone leaks the secret plan, the public was terrified and starts to condemn the inhumane government.[Only Permitted to View By UG Members]" , ""};
    private string[] news2no = new string[] { "", "R2B2 security robot has served 50% work of the maintenance and protection of engines. Engine-0377 is turned off, but UG claims that it will be restarted when needed. ",
        "",
        "Engine-0922 is active with the backup energy supplies, accelerating the speed of our travel.",
        "",
        "",
        "The Science Department estimates that 237,586 people will be seriously influenced by the lack of food. [Only Permitted to View By UG Members]" , ""};
    private string[] news3yes = new string[] { "Police confirmed that the suspects of recent serial robbery are all from the coastal refugee camp.", "The security group of the United Government equipped xxx stun guns which could paralyze the object for 10 mins.",
        "The manager of the residency which illegally uses power is executed by shooting by the Security Department of the United Government.",
        "Multiple cities in the American continent and Eurasian continent are attacked by meteorite fragments. Detailed casualties need further statistics to be determined. ",
        "Underground Site-74 executes 110 revolters against the United Government in public.",
        "Famous former rapper Skr Wu is arrested for causing public disturbance while holding private concert at a club.",
        "The third aircraft with 500 felons is launched towards Sagittarius B-25. [Only Permitted to View By UG Members]" , ""};
    private string[] news3no = new string[] { "The refugee camp near Mount Annulii lost connection. Investigator reported the camp is covered by ice. Further analysis shows that the shutdown of power caused the loss of control of the temperature controlling system. ", "The 6-month night in the western hemisphere will end soon, new crop is already planted in the area to welcome the coming daytime.",
        "Retrospect: In 2006 Old Caleder, there was no light in the night in North Korea, but now under the leading of the United Government, NK could keep lights open for the 11-month nighttime.",
        "Engines-0332 is paused because of the meteorite attack. The speed will reach previous speed in xxx days. Five cities encountered fragments in small scale.",
        "Burglary happened in several underground cities. The government suggest residents to protect their belongings. ",
        "Electricity shortage while Famous rapper Skr Wu singing Bad Girl in his 36th concert this year.",
        "Clash between jailers and prisoners in the jail in Site-54 is suppressed by the Security Department.  [Only Permitted to View By UG Members]" , ""};
    private string[] begining = new string[] { "Deceleration Era, 055"+"\n"+"The autorotation of the Earth is nearly stopped. The United Government claims the second phase of Project Gypsy will begin after 15 years. By that time, the Earth will gradually escape from the attractions of other planets and eventually leave the solar system. ", "Exodus Era 005"+"\n"+"The second phase of Project Gypsy starts. Now the Earth is under the attraction of Mars. The temperature will decrease while we generally escape the solar system and get further from the Sun, in the future.",
        "Exodus Era 098"+"\n"+"The Underground Cities are almost completed, to keep us warm in the Ice age. Now the Earth is under the attraction of Jupiter, which has the biggest mass in the solar system. To escape the huge attraction, the science department plans to start using temporary resource reserves in the polar area. ",
        "Exodus Era 0120"+"\n"+"The Earth is now on the track affected by Saturn. The underground cities are completed. Residents are moving into underground cities. The freezing climate can no longer support any crops. The United Government will discuss energy allocation and technology upgrading for the late stage of the second phase of Project Gypsy. ",
        "Exodus Era 0174"+"\n"+"The Earth now is on the track affected by Neptune. All residents moved to underground cities. Ice covers the whole surface of the Earth. Now, the committee has to be prepared for the third phase. ",
        "Wandering Era 020"+"\n"+"Our Earth successfully drove out of the solar system, now we are in the third phase of Project Gypsy. In the endless drifting in the universe, we need to make more constructive and decisive choices to find a livable galaxy.",
        "Wandering Era 120"+"\n"+"We have already finished ¾ of the travel, but the resource consumed greatly exceed our previous estimation. Die, or survive, just in one mind.", "" };
    private string[] q1yes = new string[] { "Allowed", "Allowed", "Revoke", "Yes", "Biology", "Send Army", "Yes", "Allowed" };
    private string[] q2yes = new string[] { "Yes", "Yes", "Build", "Hospitals", "Hold", "Allowed", "Recycle", "Prohibit" };
    private string[] q3yes = new string[] { "City", "Secure", "Allowed", "Keep On", "Yes", "Yes", "Allowed", "Annihilation" };
    private string[] q1no = new string[] { "Not Allowed", "Not Allowed", "Not Revoke", "No", "Secure", "Not Send", "No", "Not Allowed" };
    private string[] q2no = new string[] { "No", "No", "Not Build", "Engine", "Not Hold", "Not Allowed", "Not Recycle", "Not Prohibit" };
    private string[] q3no = new string[] { "Mountains", "Agriculture", "Not Allowed", "Turn Off", "No", "No", "Not Allowed", "Refuse" };
    private int[] q1yes_e = new int[] { 0, 50, 100, 0, 150, 0, 0, 0 };
    private int[] q1yes_s = new int[] { 5, -5, -10, 0, 0, 0, -5, 0};
    private int[] q1yes_p = new int[] { -1, 0, 1, -2, 0, -2, -2, -2 };
    private int[] q1no_e = new int[] { 0, 0, 0, -50, 0, 0, -100, -100 };
    private int[] q1no_s = new int[] { -10, 0, 0, 0, 0, 0, 0, 0 };
    private int[] q1no_p = new int[] { 0, 1, 0, 0, 0, 0, 0, 0 };
    private int[] q2yes_e = new int[] { 50, 0, -300, 0, 0, 0, 0, 0 };
    private int[] q2yes_s = new int[] { 0, -3, 0, 0, 5, -5, -5, 0 };
    private int[] q2yes_p = new int[] { -1, 0, 0, 1, 0, 3, 0, -2 };
    private int[] q2no_e = new int[] { 0, -50, 0, 50, -150, 0, 7, 0 };
    private int[] q2no_s = new int[] { 0, 0, 0, 0, 0, 0, 0, -5 };
    private int[] q2no_p = new int[] { 0, 0, 0, 0, 0, 0, -1, 0 };
    private int[] q3yes_e = new int[] { 0, 0, 50, 0, 0, 0, 0, 0 };
    private int[] q3yes_s = new int[] { -10, 10, 10, 0, -5, -5, 0, 0 };
    private int[] q3yes_p = new int[] { 0, 0, 0, -5, 0, 0, -1, -3 };
    private int[] q3no_e = new int[] { 0, 0, -50, -100, -100, -100, -100, -200 };
    private int[] q3no_s = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
    private int[] q3no_p = new int[] { -1, 2, 0, -1, 0, 0, 0, 0 };








    void Start()
    {
        mCamera = mainCamera.GetComponent<Camera>();
        is_turn = true;
        turn = 1;
        tmp1.SetText("");
        next_button.gameObject.SetActive(!is_turn);
        newspenal.SetActive(is_turn);

        engine_number = 800f;
        population = 11f;
        satisfaction = 75f;
        option1.text = q1[0];
        option2.text = q2[0];
        option3.text = q3[0];
        cutscene_num = 1;
        des.text = "";



    }

    void planetmove()
    {
       
            mars.SetActive(turn == 3&& is_turn);
        if (turn == 3)
            mars.transform.Translate(new Vector3(-15f * Time.deltaTime, 0, 0));
            jup.SetActive(turn == 4 && is_turn);
        if (turn == 4)
            jup.transform.Translate(new Vector3(-10f * Time.deltaTime, 0, 0));
            hai.SetActive(turn == 6 && is_turn);
        if (turn == 5)
            hai.transform.Translate(new Vector3(-10f * Time.deltaTime, 0, 0));
            tu.SetActive(turn == 5 && is_turn);
        if (turn == 6)
            tu.transform.Translate(new Vector3(-10f * Time.deltaTime, 0, 0));

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
            checkend();
            
            applynumber();
            tmp1.SetText(dialog[turn - 1]);
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
    public void checkend()
    {
        if (turn == 3)
        {
            if (u.a2 == 2)
            SceneManager.LoadScene("dead1");

        }
        if (turn == 6)
        {
            if(u.a1 == 2)
            SceneManager.LoadScene("dead2");
        }
        if (turn == 8)
        {
            if(u.a2 == 2)
            SceneManager.LoadScene("dead3");
        }
        if (population <= 2f)
            SceneManager.LoadScene("dead4");
        if (engine_number<= 450f)
            SceneManager.LoadScene("dead5");
        if (satisfaction <= 30f)
            SceneManager.LoadScene("dead6");
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
        tmp1.SetText(begining[turn - 2]);
    }

    public void News() {
        string x = "News: \n\n";
        if (oa1 == 1)
        {
            x += news1yes[turn - 2];
            x += "\n\n";
        }
        else if (oa1 == 2)
        { x += news1no[turn - 2];
            x += "\n\n";
        }
        if (oa2 == 1)
        { x += news2yes[turn - 2];
            x += "\n\n";
        }
        else if (oa2 == 2)
        { x += news2no[turn - 2];
            x += "\n\n";
        }
        if (oa3 == 1)
        { x += news3yes[turn - 2];
      
        }
        else if (oa3 == 2)
        { x += news3no[turn - 2];
   
        }

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
        planetmove();
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
