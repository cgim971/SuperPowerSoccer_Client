using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class UDPClient : MonoBehaviour
{
    //private readonly string IP = "127.0.0.1";
    //private readonly int PORT = 5000;

    //private UdpClient _udpClient;
    //private IPEndPoint _serverEndPoint;

    //private void Start()
    //{
    //    _udpClient = new UdpClient();
    //    _serverEndPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
    //}

    //public void SendData(string message)
    //{
    //    byte[] messageBytes = Encoding.UTF8.GetBytes(message);
    //    _udpClient.Send(messageBytes, messageBytes.Length, _serverEndPoint);
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        SendData("Hello, Server");
    //    }
    //}
}
