﻿/**************************************************************************************************
 * Copyright : Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.
 *
 * Your use of this SDK or tool is subject to the Oculus SDK License Agreement, available at
 * https://developer.oculus.com/licenses/oculussdk/
 *
 * Unless required by applicable law or agreed to in writing, the Utilities SDK distributed
 * under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 **************************************************************************************************/

using Facebook.WitAi;
using Facebook.WitAi.Lib;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Oculus.Voice.Demo.UIShapesDemo
{
    public class ModifiedInteractionHandler : MonoBehaviour
    {

        //[SerializeField] TMP_Text previouslySpokenListText;

        public List<string> previouslySpokenList = new List<string>();

        public string previouslySpokenString, mostRecentSpoken;

        private int counter;

        public string[] previouslySpokenArray;

        [Header("Default States"), Multiline]
        [SerializeField] private string freshStateText = "Try pressing the Activate button and saying \"Make the cube red\"";

        [Header("UI")]
        [SerializeField] private Text textArea;
        [SerializeField] private bool showJson;

        [Header("Voice")]
        [SerializeField] private AppVoiceExperience appVoiceExperience;

        private string pendingText;

        public bool activate;

        private void OnEnable()
        {
            appVoiceExperience.events.OnRequestCreated.AddListener(OnRequestStarted);
        }

        private void OnDisable()
        {
            appVoiceExperience.events.OnRequestCreated.RemoveListener(OnRequestStarted);
        }

        private void OnRequestStarted(WitRequest r)
        {
            // The raw response comes back on a different thread. We store the
            // message received for display on the next frame.
            if (showJson) r.onRawResponse = (response) => pendingText = response;
        }

        private void Update()
        {
            if (null != pendingText)
            {
                textArea.text = pendingText;
                pendingText = null;
            }

            if (activate)
            {
                ToggleActivation();
            }

        }

        //void DisplayPreviouslySpokenList()
        //{
        //    if (previouslySpokenList == null)
        //    {
        //        previouslySpokenListText.text = "Nothing spoken yet.";
        //    }
        //    else
        //    {
        //        previouslySpokenArray = previouslySpokenList.ToArray();
        //        previouslySpokenString = string.Join("\n", previouslySpokenArray);
        //        previouslySpokenListText.text = previouslySpokenString;
        //        counter++;
        //    }
        //}

        public void OnResponse(WitResponseNode response)
        {
            if (!string.IsNullOrEmpty(response["text"]))
            {
                textArea.text = "I heard: " + response["text"];
                mostRecentSpoken = response["text"];
                previouslySpokenList.Add(counter + ". " + response["text"]);
                //DisplayPreviouslySpokenList();
            }
            else
            {
                textArea.text = freshStateText;
            }
        }

        public void OnError(string error, string message)
        {
            textArea.text = $"<color=\"red\">Error: {error}\n\n{message}</color>";
        }

        public void ToggleActivation()
        {
            //if (appVoiceExperience.Active) appVoiceExperience.Deactivate();
            //else
            //{
                appVoiceExperience.Activate();
            activate = false;
                textArea.text = "I'm listening...";
            //}
        }
    }
}
