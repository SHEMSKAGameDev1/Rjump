using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Messaging;
using System;

public class notifer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Firebase.Messaging.FirebaseMessaging.TokenReceived += TokenReceived;
        Firebase.Messaging.FirebaseMessaging.MessageReceived += MessageReceived;

        subscribe();
    }

    void subscribe()
    {
        Firebase.Messaging.FirebaseMessaging.SubscribeAsync("/topics/FusionPrix");
    }

    private void MessageReceived(object sender, MessageReceivedEventArgs e)
    {
        Debug.Log("notif recived" + e.Message);
    }

    private void TokenReceived(object sender, TokenReceivedEventArgs e)
    {
        Debug.Log("Token Recived" + e.Token);
    }
}
