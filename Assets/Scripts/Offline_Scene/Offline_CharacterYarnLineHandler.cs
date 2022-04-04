using System.Collections;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.Events;


public class Offline_CharacterYarnLineHandler : MonoBehaviour
{
    public bool launchScene;

    public string characterName;

    private string sceneToLoad;

    public InMemoryVariableStorage yarnInMemoryVariableStorage;

    public AudioSource CharacterAudioSource;

    public AudioClip[] VoiceLine;

    public int VoiceLineCounter = 0;

    public float YarnVoicelineOverride;

    public UnityEvent characterFinishedTalking;


    //public YarnProject myYarnProject;

    //public SpeechManager characterSpeechManager;
    //public YarnCommandController ClassroomSpeechToYarn;
    //public AudioSource characterAudioSource;

    //private List<string> allLinesIDList = new List<string>();
    //private List<string> characterLineIDList = new List<string>();
    //private List<string> characterNegativeLineIDList = new List<string>();
    //private List<string> characterNeutralLineIDList = new List<string>();
    //private List<string> characterPositiveLineIDList = new List<string>();

    //[Header("Stage 1 Line ID's")]
    //private List<string> characterNegativeLineStage1IDList = new List<string>();
    //private List<string> characterNeutralLineStage1IDList = new List<string>();
    //private List<string> characterPositiveLineStage1IDList = new List<string>();

    //[Header("Stage 2 Line ID's")]
    //private List<string> characterNegativeLineStage2IDList = new List<string>();
    //private List<string> characterNeutralLineStage2IDList = new List<string>();
    //private List<string> characterPositiveLineStage2IDList = new List<string>();

    //[Header("Stage 3 Line ID's")]
    //private List<string> characterNegativeLineStage3IDList = new List<string>();
    //private List<string> characterNeutralLineStage3IDList = new List<string>();
    //private List<string> characterPositiveLineStage3IDList = new List<string>();

    //[Header("All Lines")]
    //public List<string> characterTextLineList = new List<string>();
    //public List<string> characterNegativeLineList = new List<string>();
    //public List<string> characterNeutralLineList = new List<string>();
    //public List<string> characterPositiveLineList = new List<string>();

    //[Header("Stage 1 Lines")]
    //public List<string> characterNegativeLineStage1List = new List<string>();
    //public List<string> characterNeutralLineStage1List = new List<string>();
    //public List<string> characterPositiveLineStage1List = new List<string>();

    //[Header("Stage 2 Lines")]
    //public List<string> characterNegativeLineStage2List = new List<string>();
    //public List<string> characterNeutralLineStage2List = new List<string>();
    //public List<string> characterPositiveLineStage2List = new List<string>();

    //[Header("Stage 3 Lines")]
    //public List<string> characterNegativeLineStage3List = new List<string>();
    //public List<string> characterNeutralLineStage3List = new List<string>();
    //public List<string> characterPositiveLineStage3List = new List<string>();

    //public int characterLineCount;

    //public float waitTime;


    //public Text debugText;

    //private void Awake()
    //{
    //    GetLineIDs();
    //    SortLineIDs();
    //    GetLinesFromIDs();
    //}


    //public void GetLineIDs()                                                //finds all of the line IDs in the referenced YARN project and lists
    //{
    //    var lineID = myYarnProject.GetLocalization("En").GetLineIDs();
    //    allLinesIDList = lineID.ToList();
    //}

    //public void SortLineIDs()                                               //sorts all of the IDs based on string segments found in the YARN line ID and lists
    //{
    //    foreach (string tempString in allLinesIDList)
    //    {
    //        if (tempString.Contains(characterName))
    //        {
    //            characterLineIDList.Add(tempString);
    //        }

    //        if (tempString.Contains(characterName + "Negative"))
    //        {
    //            characterNegativeLineIDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "Neutral"))
    //        {
    //            characterNeutralLineIDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "Positive"))
    //        {
    //            characterPositiveLineIDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "NegativeStage1"))
    //        {
    //            characterNegativeLineStage1IDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "NeutralStage1"))
    //        {
    //            characterNeutralLineStage1IDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "PositiveStage1"))
    //        {
    //            characterPositiveLineStage1IDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "NegativeStage2"))
    //        {
    //            characterNegativeLineStage2IDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "NeutralStage2"))
    //        {
    //            characterNeutralLineStage2IDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "PositiveStage2"))
    //        {
    //            characterPositiveLineStage2IDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "NegativeStage3"))
    //        {
    //            characterNegativeLineStage3IDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "NeutralStage3"))
    //        {
    //            characterNeutralLineStage3IDList.Add(tempString);
    //        }
    //        if (tempString.Contains(characterName + "PositiveStage3"))
    //        {
    //            characterPositiveLineStage3IDList.Add(tempString);
    //        }

    //    }
    //}

    //public void GetLinesFromIDs()                                           //pulls all of the text for each line ID out of YARN project and lists
    //{
    //    foreach (string tempString in characterLineIDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterTextLineList.Add(text);
    //    }

    //    foreach (string tempString in characterNegativeLineIDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterNegativeLineList.Add(text);
    //    }

    //    foreach (string tempString in characterNeutralLineIDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterNeutralLineList.Add(text);
    //    }

    //    foreach (string tempString in characterPositiveLineIDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterPositiveLineList.Add(text);
    //    }

    //    foreach (string tempString in characterNegativeLineStage1IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterNegativeLineStage1List.Add(text);
    //    }

    //    foreach (string tempString in characterNeutralLineStage1IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterNeutralLineStage1List.Add(text);
    //    }

    //    foreach (string tempString in characterPositiveLineStage1IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterPositiveLineStage1List.Add(text);
    //    }

    //    foreach (string tempString in characterNegativeLineStage2IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterNegativeLineStage2List.Add(text);
    //    }

    //    foreach (string tempString in characterNeutralLineStage2IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterNeutralLineStage2List.Add(text);
    //    }

    //    foreach (string tempString in characterPositiveLineStage2IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterPositiveLineStage2List.Add(text);
    //    }

    //    foreach (string tempString in characterNegativeLineStage3IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterNegativeLineStage3List.Add(text);
    //    }

    //    foreach (string tempString in characterNeutralLineStage3IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterNeutralLineStage3List.Add(text);
    //    }

    //    foreach (string tempString in characterPositiveLineStage3IDList)
    //    {
    //        var text = myYarnProject.GetLocalization("En").GetLocalizedString(tempString);
    //        characterPositiveLineStage3List.Add(text);
    //    }

    //    //var text = myYarnProject.GetLocalization("En").GetLocalizedString("line:01c1039");
    //    //lineTextString = text;
    //    //Debug.LogError(text);
    //}

    public void CharacterSpeechPlayback()                                   //sets the line to be sent to the TTS from the line list and sends
    {
        if (launchScene)
        {
            yarnInMemoryVariableStorage.TryGetValue("$sceneRecommend", out YarnVoicelineOverride);

            if (YarnVoicelineOverride == 1)
            {
                VoiceLineCounter = 2;
            }

            if (YarnVoicelineOverride == 2)
            {
                VoiceLineCounter = 3;
            }

            if (YarnVoicelineOverride == 3)
            {
                VoiceLineCounter = 5;
            }
        }

        Debug.LogError("Audio source triggered...");

        CharacterAudioSource.clip = VoiceLine[VoiceLineCounter];
        CharacterAudioSource.Play();
        VoiceLineCounter++;
        StartCoroutine(CharacterWaitForLineToFinish());
    }

    public IEnumerator CharacterWaitForLineToFinish()                       //coroutine set to complete once the NPCs audio clip has completed
    {
        Debug.LogError("wait function triggered");

        yield return new WaitUntil(() => CharacterAudioSource.isPlaying);
        yield return new WaitUntil(() => !CharacterAudioSource.isPlaying);
        characterFinishedTalking.Invoke();
        Debug.LogError(characterName + "finished talking...");

        //Debug.LogError(characterName + " finished talking");
    }
}
