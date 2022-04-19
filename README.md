# Virtual Reality Soft Skills Template 

  [<img src="https://github.com/virtualosus/SoftSkillsTemplate/blob/master/Assets/GithubImages/YoutubePic.png" width="1000" height="" />](https://www.youtube.com/watch?v=Aq8hGkx1nEk)


This template Virtual Reality project is a demonstration of a number of Artificial Interlligence elements brought together in Unity for the purpose of training and developement focusing on Soft Skills.

Set up for use on the Meta/Oculus Quest 2, this project can be used as a template for any training application in VR. Follow the below guidance on how to amend the project to your needs.

### Artifical Intelligence Elements

* [Microsoft Azure Text to Speech](#microsoft-azure-text-to-speech).
* [Meta/Oculus Voice Recognition (Wit.ai)](#metaoculus-voice-recognition-witai)


### NPC and Dialogue

* [Yarn Spinner 2.0](#yarn=spinner-20)
* [Meta/Oculus Lip Sync](#metaoculus-lip-sync)
* [Rocketbox](#rocketbox)


## Microsoft Azure Text to Speech

The Microsoft TTS setup is based on [Active Nick's Unity-Test-To-Speech project](https://github.com/ActiveNick/Unity-Text-to-Speech). By adapting his Speech Manager script, it is possible to call realtime TTS from the Microsoft Azure Cognitive Services.

To implement this in your project, you will need to set up (at least) a [free account with the Azure services](https://azure.microsoft.com/en-us/free/cognitive-services/) which will permit up to 5000 requests per month.

Once your account has been set up, you will then find your 'Speech Service API Key' and 'Speech Service Region' in the Keys and Endpoint section of your account portal.

<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/speechServices.PNG" width="600" height="" />


This will then need to be added to each Speech Manager script in the Inspector window.

<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/speechManager.PNG" width="600" height="" />
  
You will find that a number of the voices referenced by the script are no longer available since Microsoft have upgraded the voices to 'Nueral' *(this will be tidied up at a later time)*. A number of availabe voices have been added at the top of the list, but should you wish to add others from [the non-preview voices](https://azure.microsoft.com/en-us/services/cognitive-services/text-to-speech/#features), open the script 'TTSClient', add a new reference to the enum 'VoiceName' in the format shown below and a new case to the public string 'ConvertVoiceNametoString', as shown below. 

If we wanted to add the South African English voice Luke to the app...

<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/TTSvoices.PNG" width="600" height="" />
  
...we would add the new entry to the enum formatted as shown here...

<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/enum.PNG" width="300" height="" />
  
...and add a new case as show here.

<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/convertVoice.PNG" width="600" height="" />
  
The new voice is then available to select on the Speech Manager in the Inspector window.

<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/SALuke.PNG" width="600" height="" />
  

## Meta/Oculus Voice Recognition (Wit.ai)

The voice recognition is handled by [Wit.ai](https://wit.ai/), which is part of the [Meta/Oculus Integration Package](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022). There is thorough documentation on their website on how to use the system, but in short, you will need to log in either via your Facebook account.

You then would need to create a new app, and retrieve your Service Access token, which is to be put into Unity to link the two projects.
  
Retrive the Wit.ai Service Token from your app settings on their website here...
  
<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/witAccessToken.PNG" width="600" height="" />
  
...and add it here within Unity.
  
<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/witUnitySettings.PNG" width="600" height="" />
  
You are then able to train the Wit.ai system to recognise key words and perform custom functions within Unity, though in this application we are only taking the string and using a string comparison algorithm to select our desired option.
  
## Yarn Spinner 2.0
  
[Yarn Spinner](https://yarnspinner.dev/) is the pulse of the app, waiting for options, holding the voicelines for the characters, calling the voice recogition and the order of the flow. There is [excellent documentaion](https://docs.yarnspinner.dev/) on their website as well as great help on their [Discord](https://discord.com/invite/yarnspinner).

Any amendments to the script need to be made to the Yarn script which is attached to the current Yarn Project selected in the Dialogue Runner.
  
<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/yarnInspector.PNG" width="1000" height="" />
  
If being used for your own individual project, create a new Yarn project and Yarn script within the Project window.
  
When adding the line ending to the script, ensure to add the character name to the line ending, and make sure this matches exactly with the character name on the NPC prefab scripts, 'Character Yarn Line Handler' and 'Speech Manager'. Be sure to create a tag with the name as well. 
  
<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/npcPrefab.PNG" width="600" height="" />
  
This will link the script lines to the correct NPC, and send them to the correct TTS and Audio Source. Also ensure that the 'characterToTalk' variable within the Yarn script is set to the NPC's name.
  
<p align = "center">
  <img src="https://github.com/2030428/Soft_Skills_Trainer/blob/master/Assets/READMEImages/yarnScript.PNG" width="600" height="" />
    
## Meta/Oculus Lip Sync
  
The Meta/Oculus Lip Sync is also now included with the [Oculus Integration](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022) package. Your character models will need to include blend shapes for the facial expressions of letter pronunciations. The Rocket Box collection now includes facial blend shapes, and can be used for free.
  
Be sure to drag the Skinned Mesh Renderer for your desired model on to the 'OVR Lip Sync Contect Morph Target'.
  
<p align = "center">
  <img src="https://github.com/virtualosus/SoftSkillsTemplate/blob/master/Assets/GithubImages/lipSync.PNG" width="600" height="" />

## Rocketbox

The [Microsoft Rocketbox Avatar Library](https://github.com/microsoft/Microsoft-Rocketbox) is a collection of avatars which are provided for free use for research and academic puproses. The full library can be dowloaded by .zip with through the link, and now includes a great selection of animations as well as the blend shapes required for the Lip Sync.
  
Simply find your desired model from the collection, and drag and drop the whole folder into your project.
  
<p align = "center">
  <img src="https://github.com/virtualosus/SoftSkillsTemplate/blob/master/Assets/GithubImages/rocketbox1.PNG" width="600" height="" />

Once that has imported, drag the 'facial blends' version of the .fbx to the NPC_Prefab object in the hierarchy. (You will need to unpack the prefab to complete this step.)
  
<p align = "center">
  <img src="https://github.com/virtualosus/SoftSkillsTemplate/blob/master/Assets/GithubImages/rocketbox2.PNG" width="600" height="" />
  
And then remove the example model. Remeber to add the new skinned mesh renderer of the model to the Lip Sync setup, as shown in the Lip Sync section.
  
<p align = "center">
  <img src="https://github.com/virtualosus/SoftSkillsTemplate/blob/master/Assets/GithubImages/rocketbox3.PNG" width="600" height="" />
