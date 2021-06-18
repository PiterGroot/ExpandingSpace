using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TriggerDialogue : MonoBehaviour
{
    private TextMeshProUGUI Conversation;
    private TextMeshProUGUI Name;
    private bool isTalking = false;
    private bool canActivate = true;
    private int currentSentence = -1;
    private string SentenceOrder;
    private bool isDisabled = false;

    [SerializeField]private bool ActivateThisDialogue;
    [Header("Refrences")]
    [SerializeField]private Animator DialogueAnim;
    [SerializeField]private GameObject ObjectToFollow;
    [SerializeField]private GameObject DialogueBox;
    [Header("MultiDialogue")]
    [SerializeField]private bool isMainSpeaker = false;
    [SerializeField]private TriggerDialogue FirstSpeaker;
    [SerializeField]private TriggerDialogue SecondSpeaker;
    [Header("Dialogue modifiers")]
    [SerializeField]private bool IsMultiDialogue = false;
    [SerializeField]private bool canManuallyActivate = false;
    [SerializeField]private bool PlaySound = false;
    [SerializeField]private bool RandomSentence = false;
    [SerializeField]private bool HasMissionSelect = false;
    [SerializeField]private bool ActivateDialogueAfter = false;
    [Header("Dialogue settings")]
    public string DialogueID = "Example";
    [SerializeField]private KeyCode ActivateKey = KeyCode.L;
    [SerializeField]private float TalkingSpeed ;
    [SerializeField]private float PauseTime = 2.3f;
    [SerializeField]private string VoiceSoundEffectName;
    public string NameTag;
    [SerializeField] private Sprite ProfilePicture;
    [TextArea(1, 2)]
    public string[] Sentences;
    [SerializeField]private Vector3 DialogueOffset;
    [SerializeField]private GameObject MissionSelect;
    [SerializeField]private TriggerDialogue NextDialogue;


    private void Start() {
      
        if(DialogueID == string.Empty){
            DialogueID = "NULL";
            Debug.LogError("Please fill in a valid DialogueID to stay organised", this.gameObject);
        }
        Conversation = GameObject.FindGameObjectWithTag("Conversation").GetComponent<TextMeshProUGUI>();
        Name = GameObject.FindGameObjectWithTag("NameTag").GetComponent<TextMeshProUGUI>();
        Conversation.text = string.Empty;
    }

    public IEnumerator ActivateDialogue(){
       if(canActivate && currentSentence != Sentences.Length -1){
            if (ProfilePicture != null){
                GameObject.FindGameObjectWithTag("DialoguePicture").GetComponent<Image>().sprite = ProfilePicture;
            }
            isTalking = true;
            canActivate = false;
            Conversation.text = string.Empty;
            Name.text = NameTag;
            DialogueAnim.SetTrigger("Activate");
            yield return new WaitForSeconds(.4f);
            //normal dialogue
            if (!RandomSentence && !IsMultiDialogue) {
                foreach (string sentence in Sentences)
                {
                    foreach (char letter in sentence)
                    {
                        Conversation.text += letter;
                        if (PlaySound && !char.IsWhiteSpace(letter))
                        {
                            FindObjectOfType<AudioManager>().Play(VoiceSoundEffectName);
                        }
                        yield return new WaitForSeconds(TalkingSpeed);
                    }
                    yield return new WaitForSeconds(PauseTime);
                    Conversation.text = string.Empty;
                }
                DialogueAnim.SetTrigger("DeActivate");
                yield return new WaitForSeconds(.4f);
                isTalking = false;
                canActivate = true;
                if (HasMissionSelect)
                {
                    MissionSelect.SetActive(true);
                }
                else if(ActivateDialogueAfter){
                    NextDialogue.StartCoroutine(NextDialogue.ActivateDialogue());
                }
            }
            //random sentence dialogue
            else if(RandomSentence)
            {
                string ChosenSentence = Sentences[Random.Range(0, Sentences.Length)];
                foreach (char letter in ChosenSentence)
                {
                    Conversation.text += letter;
                    if (PlaySound && !char.IsWhiteSpace(letter))
                    {
                        FindObjectOfType<AudioManager>().Play(VoiceSoundEffectName);
                    }
                    yield return new WaitForSeconds(TalkingSpeed);
                }
                yield return new WaitForSeconds(PauseTime);
                Conversation.text = string.Empty;
                DialogueAnim.SetTrigger("DeActivate");
                yield return new WaitForSeconds(.4f);
                isTalking = false;
                canActivate = true;
            }
            //multi dialogue with another dialogue script
            else if(IsMultiDialogue)
            {  
                try{
                    SentenceOrder = Sentences[currentSentence += 1];
                }
                catch{
                   isDisabled = true;
                }
                if(!isDisabled){
                    foreach (char letter in SentenceOrder)
                    {
                        Conversation.text += letter;
                        if (PlaySound && !char.IsWhiteSpace(letter))
                        {
                            FindObjectOfType<AudioManager>().Play(VoiceSoundEffectName);
                        }
                        yield return new WaitForSeconds(TalkingSpeed);
                    }
                    yield return new WaitForSeconds(PauseTime);
                    Conversation.text = string.Empty;
                    DialogueAnim.SetTrigger("DeActivate");
                    yield return new WaitForSeconds(.4f);
                    isTalking = false;
                    canActivate = true;
                    if(isMainSpeaker && currentSentence < Sentences.Length && !isDisabled){
                        SecondSpeaker.StartCoroutine(SecondSpeaker.ActivateDialogue());
                    }
                    else if(currentSentence < Sentences.Length &&!isMainSpeaker && !isDisabled){
                        FirstSpeaker.StartCoroutine(FirstSpeaker.ActivateDialogue());
                    }
                }
            }
       }
       else{
           Debug.LogWarning("Dialogue is already active please wait when it's done", this.gameObject);
       }
    } 
    private void Update() {
        TalkingSpeed = PlayerPrefs.GetFloat("DialogueSpeed");
        if (Input.GetKeyDown(ActivateKey) && canManuallyActivate)
        {
           StartCoroutine(ActivateDialogue());
        }
        if(ActivateThisDialogue){
            ActivateThisDialogue = false;
           StartCoroutine(ActivateDialogue());
        }
        if(isTalking){
            UpdatePosition();
        }
    }
    private void UpdatePosition(){
        if(ObjectToFollow == null)
        {
            Vector2 FollowPos = new Vector2(0, 0);
            DialogueBox.GetComponent<RectTransform>().position = FollowPos;
        }
        if (ObjectToFollow != null)
        {
            Vector2 FollowPos = ObjectToFollow.transform.position + DialogueOffset;
            DialogueBox.GetComponent<RectTransform>().position = FollowPos;
        }
    }
}
