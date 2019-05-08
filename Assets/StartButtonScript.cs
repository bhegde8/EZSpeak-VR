using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour {

    AudioClip myAudioClip;

    bool prompterEnabled = true;
    bool randomScriptMode = false;

    string currentText = "";

    public string[] presScripts =
    {
        "I trust when Parliament meets again this part of my task will be completed and that the administration will be complete in all respects. I considered it in the public interest to suggest to the Speaker that the House should be summoned today.At the end of today's proceedings, the adjournment of the House will be proposed until May 21 with provision for earlier meeting if need be. Business for that will be notified to MPs at the earliest opportunity. I now invite the House by a resolution to record its approval of the steps taken and declare its confidence in the new government. The resolution: That this House welcomes the formation of a government representing the united and inflexible resolve of the nation to prosecute the war with Germany to a victorious conclusion. To form an administration of this scale and complexity is a serious undertaking in itself.But we are in the preliminary phase of one of the greatest battles in history.We are in action at many other points-in Norway and in Holland-and we have to be prepared in the Mediterranean. The air battle is continuing, and many preparations have to be made here at home. In this crisis I think I may be pardoned if 1 do not address the House at any length today, and I hope that any of my friends and colleagues or former colleagues who are affected by the political reconstruction will make all allowances for any lack of ceremony with which it has been necessary to act. I say to the House as I said to ministers who have joined this government, I have nothing to offer but blood, toil, tears, and sweat. We have before us an ordeal of the most grievous kind.We have before us many, many months of struggle and suffering. You ask, what is our policy? I say it is to wage war by land, sea, and air. War with all our might and with all the strength God has given us, and to wage war against a monstrous tyranny never surpassed in the dark and lamentable catalogue of human crime. That is our policy. You ask, what is our aim? I can answer in one word. It is victory.Victory at all costs - Victory in spite of all terrors - Victory, however long and hard the road may be, for without victory there is no survival. Let that be realized. No survival for the British Empire, no survival for all that the British Empire has stood for, no survival for the urge, the impulse of the ages, that mankind shall move forward toward his goal. I take up my task in buoyancy and hope.I feel sure that our cause will not be suffered to fail among men. I feel entitled at this juncture, at this time, to claim the aid of all and to say, Come then, let us go forward together with our united strength.",
        "Over the past eighteen months I have been coming to terms with and seeking to cope with a drink problem. And I've come to learn through that process that any drink problem is a serious problem indeed— for yourself and for those around about you. I've sought professional help and I believe today that this issue is essentially resolved. People close to me know that this has been a struggle and for extended periods I have consumed no alcohol at all. As a matter of fact I haven't had a drink for the past two months— and I don't intend to in the future. I've learnt the hard way of the need to face up to this medical problem— one that is dealt with successfully by many others on a daily basis. I have chosen not to acknowledge it publicly in this way before because, if at all possible, I wanted to overcome it privately. In a sense, this admission today comes as something of a personal relief. I should have been willing to talk about it more openly before. I wish I had. This issue has—understandably—been of concern of several of my parliamentary colleagues. They have been both understanding and supportive. I am extremely grateful to them for that. It also lies beneath much of the current leadership speculation within the parliamentary party. Therefore, let me be clear. I consider myself capable and in good health— and I remain politically determined as leader of the party. This party's members have shown me tremendous support over the years and overwhelmingly in recent weeks and days. It is a privilege to serve as their leader. I want to continue doing so, not least because the prospects in front of us in this parliament are so great. Given my statement today I believe it is only fair now to give our party members their say over the continuing leadership. It is open to any colleague who believes that they can better represent the longer-term interests of the party to stand against me in such a leadership election. I am requesting that the party puts in place the necessary steps to enable this election to take place immediately. Given the extremely personal nature of this statement I trust that you will understand that I do not propose to make further comments.",
        "Gentlemen of the Jury: The best friend a man has in the world may turn against him and become his enemy. His son or daughter that he has reared with loving care may prove ungrateful. Those who are nearest and dearest to us, those whom we trust with our happiness and our good name may become traitors to their faith. The money that a man has, he may lose. It flies away from him, perhaps when he needs it most. A man's reputation may be sacrificed in a moment of ill-considered action. The people who are prone to fall on their knees to do us honor when success is with us, may be the first to throw the stone of malice when failure settles its cloud upon our heads.",
        "Through one of the marvels of modern Science, I am enabled, this Christmas Day, to speak to all my peoples throughout the Empire. I take it as a good omen that Wireless should have reached its present perfection at a time when the Empire has been linked in closer union. For it offers us immense possibilities to make that union closer still. It may be that our future may lay upon us more than one stern test. Our past will have taught us how to meet it unshaken. For the present, the work to which we are all equally bound is to arrive at a reasoned tranquillity within our borders; to regain prosperity without self-seeking; and to carry with us those whom the burden of past years has disheartened or overborne. My life's aim has been to serve as I might, towards those ends. Your loyalty, your confidence in me has been my abundant reward. I speak now from my home and from my heart to you all. To men and women so cut off by the snows, the desert or the sea, that only voices out of the air can reach them; to those cut off from fuller life by blindness, sickness, or infirmity; and to those who are celebrating this day with their children and grand-children. To all - to each - I wish a Happy Christmas. God Bless You!.",
        "The Conflict is viewed too tragically, and presented too tragically in the press; the regime does not seek war. If the crisis can be ended with honor, the regime will gladly do so. The great independence of the individual makes it difficult in Prussia to rule under the Constitution. In France it is otherwise; there, individual independence is lacking. The constitutional crisis, however, is no shame, but rather an honor. We are perhaps too educated to put up with a constitution - we are too critical. Public opinion wavers; the press is not public opinion; we know how that arises. There are too many Catilines, who have revolution at heart. The members [of the House], however, have the task of standing over public sentiment, and of guiding it.Our blood is too hot, we prefer armor too great for our small body to carry, but we should put it to service.Germany does not look to Prussia's liberalism, but to its power. Bavaria, Wurttemberg, and Baden would like to turn to liberalism, but they shall not assume Prussia's role. Prussia must collect its forces for the favorable occasion, which has several times been neglected; Prussia's borders are not favorable to a healthy national life. Not by speeches and decisions of majorities will the greatest problems of the time be decided - that was the mistake of 1848-49 - but by iron and blood. This olive branch (he drew it from his memorandum book) I picked up in Avignon, to offer, as a symbol of peace, to the popular party: I see, however, that it is still not the time for it.",
        "I have spent my life fighting for the kind of people I grew up with. For two decades, I stood with kids and families against big HMOs and big insurance companies. When I got to the Senate, I fought those same fights against the Washington lobbyists and for causes like the Patients' Bill of Rights. I stand here tonight ready to work with you and John [Kerry] to make America stronger. And we have much work to do, because the truth is, we still live in a country where there are two different Americas... [applause] one, for all of those people who have lived the American dream and don't have to worry, and another for most Americans, everybody else who struggle to make ends meet every single day. It doesn't have to be that way... We can build one America where we no longer have two health care systems: one for families who get the best health care money can buy, and then one for everybody else rationed out by insurance companies, drug companies, HMOs. Millions of Americans have no health coverage at all. It doesn't have to be that way. We have a plan... We shouldn't have two public school systems in this country: one for the most affluent communities, and one for everybody else. None of us believe that the quality of a child's education should be controlled by where they live or the affluence of the community they live in. It doesn't have to be that way. We can build one school system that works for all our kids, gives them a chance to do what they're capable of doing... John Kerry and I believe that we shouldn't have two different economies in America: one for people who are set for life, they know their kids and their grand-kids are going to be just fine; and then one for most Americans, people who live paycheck to paycheck... So let me give you some specifics. First, we can create good-paying jobs in this country again. We're going to get rid of tax cuts for companies who are outsourcing your jobs... [applause] and, instead, we're going to give tax breaks to American companies that are keeping jobs right here in America... Well, let me tell you how we're going to pay for it. And I want to be very clear about this. We are going to keep and protect the tax cuts for 98 percent of Americans -- 98 percent. We're going to roll back -- we're going to roll back the tax cuts for the wealthiest Americans. And we're going to close corporate loopholes..."
    };
    
    public string defaultScript = "hello my name is _________________ and my presentation is on the Malaysian exploding ant. \n\nIts classification is Camponotus saundersi and is nicknamed the exploding ant.\n\nI will explain where it gets this name later on.\n\nIt is an endangered species because of loss of habitat and their self-destructive defense mechanism.\n\nIt is a subspecies of the carpenter ant.  Its lifespan is 2 months and is omnivorous. \n\nIt has the standard lifecycle of an ant which goes from, eggs, larvae, pupae and then one of 3 specific roles. \n\nThe queen produces eggs while the male ants protect the colony.  \n\nFemales can also explode and are the workers on the colony who build the underground network and find food. \n\nThank you for listening to my presentation!";
    public void onClick()
    {
        if(GameObject.Find("Text_StartStop").GetComponent<Text>().text.Equals("Start"))
        {
            if(randomScriptMode)
            {
                System.Random rnd = new System.Random();
                int scriptID = rnd.Next(6);

                currentText = presScripts[scriptID];
            }
            else
            {
                currentText = defaultScript;
            }
           
            
            GameObject.Find("Teleprompter").GetComponent<Text>().text = currentText;
            GameObject.Find("Text_StartStop").GetComponent<Text>().text = "Stop";
            myAudioClip = Microphone.Start(null, false, 10, 44100);

        }
        else 
        {
            GameObject.Find("Teleprompter").GetComponent<Text>().text = "[TELEPROMPTER]";
            GameObject.Find("Text_StartStop").GetComponent<Text>().text = "Start";
            Microphone.End(null);
            AudioSource.PlayClipAtPoint(myAudioClip, transform.position);
        }

    }

    public void scrollUp()
    {
        Text teleprompter = GameObject.Find("Teleprompter").GetComponent<Text>();
        float x = teleprompter.transform.position.x;
        float y = teleprompter.transform.position.y;
        float z = teleprompter.transform.position.z;

        teleprompter.transform.position = new Vector3(x, y + 0.05f, z);
    }

    public void toggleRandomScript()
    {
        if(randomScriptMode)
        {
            randomScriptMode = false;
            currentText = defaultScript;
        }
        else
        {
            randomScriptMode = true;
            System.Random rnd = new System.Random();
            int scriptID = rnd.Next(6);

            currentText = poopScripts[scriptID];

        }
        GameObject.Find("Teleprompter").GetComponent<Text>().text = currentText;
    }

    public void scrollDown()
    {
        Text teleprompter = GameObject.Find("Teleprompter").GetComponent<Text>();
        float x = teleprompter.transform.position.x;
        float y = teleprompter.transform.position.y;
        float z = teleprompter.transform.position.z;

        teleprompter.transform.position = new Vector3(x, y - 0.05f, z);
    }

    public void nextSlide()
    {
        Debug.Log("Current Slide: " + GameObject.Find("Slides").GetComponent<Image>().sprite.texture.name);
        string curSlideName = GameObject.Find("Slides").GetComponent<Image>().sprite.texture.name;
        int slideID = Convert.ToInt32(curSlideName.Substring(curSlideName.Length - 1, 1));
        Debug.Log(slideID);

        string newSlideName = "slide" + (slideID + 1);

        Debug.Log("New Slide: " + newSlideName);

      

        GameObject.Find("Slides").GetComponent<Image>().sprite = Resources.Load<Sprite>(newSlideName);

    }

    public void lastSlide()
    {
        Debug.Log("Current Slide: " + GameObject.Find("Slides").GetComponent<Image>().sprite.texture.name);
        string curSlideName = GameObject.Find("Slides").GetComponent<Image>().sprite.texture.name;
        int slideID = Convert.ToInt32(curSlideName.Substring(curSlideName.Length - 1, 1));
        Debug.Log(slideID);

        string newSlideName = "slide" + (slideID - 1);

        Debug.Log("New Slide: " + newSlideName);



        GameObject.Find("Slides").GetComponent<Image>().sprite = Resources.Load<Sprite>(newSlideName);
    }

    public void toggleTeleprompter()
    {
        if(prompterEnabled)
        {
            GameObject.Find("Teleprompter").GetComponent<Text>().text = "";
            GameObject.Find("TeleprompterBG").GetComponent<MeshRenderer>().enabled = false;
            prompterEnabled = false;
        }
        else
        {
            GameObject.Find("Teleprompter").GetComponent<Text>().text = currentText;
            GameObject.Find("TeleprompterBG").GetComponent<MeshRenderer>().enabled = true;
            prompterEnabled = true;
        }
            
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
