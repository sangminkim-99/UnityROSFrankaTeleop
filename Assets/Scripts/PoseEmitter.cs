using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SocketIOClient;

public class PoseEmitter : MonoBehaviour
{
    public SocketIOUnity socket;
    public string ip;
    public string port; 
    public Transform TargetTransform;
    public Button buttonInitGripper;

    public Quaternion SavedQuat;
    public Vector3 SavedTrans;

    public bool SendCurrentPose {get; set;}

    public GripperActionMananger triggerManager;

    private Quaternion prevQuat;

    // Start is called before the first frame update
    void Start()
    {
        Uri uri = new Uri($"http://{ip}:{port}");
        
        socket = new SocketIOUnity(uri, new SocketIOOptions
        {
            Query = new Dictionary<string, string>
                {
                    {"token", "UNITY" }
                }
            ,
            EIO = 4
            ,
            Transport = SocketIOClient.Transport.TransportProtocol.WebSocket
        });

        ///// reserved socketio events
        socket.OnConnected += (sender, e) =>
        {
            Debug.Log("socket.OnConnected");
        };
        socket.OnPing += (sender, e) =>
        {
            Debug.Log("Ping");
        };
        socket.OnPong += (sender, e) =>
        {
            Debug.Log("Pong: " + e.TotalMilliseconds);
        };
        socket.OnDisconnected += (sender, e) =>
        {
            Debug.Log("disconnect: " + e);
        };
        socket.OnReconnectAttempt += (sender, e) =>
        {
            Debug.Log($"{DateTime.Now} Reconnecting: attempt = {e}");
        };
        ////

        Debug.Log("Connecting...");
        socket.Connect();

        socket.OnAnyInUnityThread((name, response) =>
        {
            Debug.Log("Received On " + name + " : " + response);
        });

        StartCoroutine(CoEmit());

        SaveCurrentPose();
    }

    private IEnumerator CoEmit() {
        while(true) {
            yield return new WaitForSeconds(0.01f); //wait 1 seconds
            if (SendCurrentPose) EmitTest();
        }
    }

    void OnDestroy()
    {
        socket.Disconnect();
    }

    [ContextMenu("Emit Test")]
    public void EmitTest()
    {
        var px = TargetTransform.position.x;
        var py = TargetTransform.position.y;
        var pz = TargetTransform.position.z;
        
        px = px - SavedTrans.x;
        py = py - SavedTrans.y;
        pz = pz - SavedTrans.z;
        
        var new_quat = Quaternion.Inverse(SavedQuat) * TargetTransform.rotation;
        new_quat = Quaternion.Slerp(prevQuat, new_quat, 0.2f);
        prevQuat = new_quat;

        var qx = new_quat.x;
        var qy = new_quat.y;
        var qz = new_quat.z;
        var qw = new_quat.w;

        var gripperWidth = triggerManager.gripperWidth;

        if (px < 0.0f || px > 0.8f) return;
        if (py < -0.5f || py > 0.5f) return;
        if (pz < -0.2f || pz > 0.8f) return;

        string poseText = $"{{\"position\": [{px},{py},{pz}], \"rotation\": [{qx},{qy},{qz},{qw}], \"gripperWidth\": {gripperWidth}}}";
        socket.Emit("pose", poseText);
    }

    [ContextMenu("Save Test")]
    public void SaveCurrentPose()
    {
        SavedQuat = TargetTransform.rotation;
        SavedTrans = TargetTransform.position;
        prevQuat = Quaternion.identity;
    }

    public void StartAndStopControl()
    {
        if (SendCurrentPose) {
            SendCurrentPose = false;
        }
        else {
            SaveCurrentPose();
            SendCurrentPose = true;
        }
    }
}
