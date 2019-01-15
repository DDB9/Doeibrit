using UnityEngine;
using UnityEngine.Networking;


public class MyNetworkManager : MonoBehaviour {
    
    public bool isAtStartup = true;
	public bool isServer = false;

    public GameObject networkManager;

	public class MyMessageTypes
	{
		public static short str = 1000;
		public static short auth = 1001;
		public static short pose = 1002;
	}
	public class ClientStates
	{
		public static int def = 0;
		public static int control = 1;
		public static int poser = 2;
	}
    
    NetworkClient myClient;
	public int myID = -1;
	public int myClientState = ClientStates.def;
	public int svIDiterator = 0;

	//input loop
    void Update () 
    {
        if (isAtStartup)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SetupServer();
            }
            
            if (Input.GetKeyDown(KeyCode.C))
            {
                SetupClient();
            }
            
            if (Input.GetKeyDown(KeyCode.B))
            {
                SetupServer();
                SetupLocalClient();
            }
        }
		if(Input.GetKeyDown(KeyCode.Space))
		{
			SendMsg("asd");
		}
    }
    
	//networking ui (will disappear when connected)
    void OnGUI()
    {
        if (isAtStartup)
        {
            GUI.Label(new Rect(2, 10, 150, 100), "Press S for server");     
            GUI.Label(new Rect(2, 30, 150, 100), "Press B for both");       
            GUI.Label(new Rect(2, 50, 150, 100), "Press C for client");
        }
    }  

	//bind messages to handlers
	public void RegisterHandlers(bool isServer)
	{
		if(isServer)
		{
			NetworkServer.RegisterHandler (MsgType.Connect, svOnClientConnected);
        	NetworkServer.RegisterHandler (MsgType.Disconnect, svOnClientDisconnected);
        	NetworkServer.RegisterHandler (MyMessageTypes.str, svOnMessageReceived);
			NetworkServer.RegisterHandler(MyMessageTypes.pose, svOnPoseData);
		}
		else
		{
        	myClient.RegisterHandler (MyMessageTypes.str, clOnMessageReceived);
        	myClient.RegisterHandler(MsgType.Connect, clOnClientConnected);
        	myClient.RegisterHandler(MsgType.Disconnect, clOnClientDisconnected);
			myClient.RegisterHandler(MyMessageTypes.auth, clOnAuth);
			myClient.RegisterHandler(MyMessageTypes.pose, clOnPoseData);
		}
	}

	//on connection
	public void svOnClientConnected(NetworkMessage netMessage)
	{
		print("SV: client connected, assigning id: " + svIDiterator);
		AuthMessage authmsg = new AuthMessage();
		authmsg.id = svIDiterator;
		svIDiterator++;
		netMessage.conn.Send(MyMessageTypes.auth, authmsg);
	}
	public void clOnClientConnected(NetworkMessage netMessage)
	{
		print("CL: connected to server");
	}
	//on auth message
	public void clOnAuth(NetworkMessage netMessage)
	{
		var objectMessage = netMessage.ReadMessage<AuthMessage>();
		print("CL: client ID is now " + objectMessage.id);
		myID = objectMessage.id;
		if(objectMessage.id == 0 || objectMessage.id == 1)
		{
			myClientState = ClientStates.control;
		}
		else if(objectMessage.id == 2 || objectMessage.id == 3)
		{
			myClientState = ClientStates.poser;
		}
		else
		{
			myClientState = ClientStates.def;
		}
		//TODO: set up the scene to match the clientstate (control room UI, poser scene, big screen display)
	}
	//on disconnect
	public void svOnClientDisconnected(NetworkMessage netMessage)
	{
		print("SV: client disconnected");
	}
	public void clOnClientDisconnected(NetworkMessage netMessage)
	{
		print("CL: disconnected from server");
	}
	//on string message received
	public void clOnMessageReceived(NetworkMessage netMessage)
    {
        var objectMessage = netMessage.ReadMessage<MyNetworkMessage>();
        print("Message(" + netMessage.msgType + ") received from client (" + objectMessage.id + "): " + objectMessage.message);
    }
	public void svOnMessageReceived(NetworkMessage netMessage)
    {
        var objectMessage = netMessage.ReadMessage<MyNetworkMessage>();
        print("Message(" + netMessage.msgType + ") received from client (" + objectMessage.id + "): " + objectMessage.message);
    }
	//On receiving pose data
	public void svOnPoseData(NetworkMessage netMessage)
    {
        var objectMessage = netMessage.ReadMessage<PoseDataMessage>();
		if(objectMessage.id == 2 || objectMessage.id == 3)
		{
			//forward the message
			NetworkServer.SendToAll(MyMessageTypes.pose, objectMessage);
		}
    }
	public void clOnPoseData(NetworkMessage netMessage)
    {
        var objectMessage = netMessage.ReadMessage<PoseDataMessage>();
		if(objectMessage.id == myID)
		{
			return;
		}
		else
		{
			//TODO: set poses
		}
    }

	// Create a server and listen on a port
    public void SetupServer()
    {
		RegisterHandlers(true);
        NetworkServer.Listen(4444);
        isAtStartup = false;
		isServer = true;
    }
    
    // Create a client and connect to the server port
    public void SetupClient()
    {
        myClient = new NetworkClient();  
		RegisterHandlers(false);
        myClient.Connect(networkManager.GetComponent<Client>().ip, 4444);
        isAtStartup = false;
    }
    
    // Create a local client and connect to the local server
    public void SetupLocalClient()
    {
        myClient = ClientScene.ConnectLocalServer();
		RegisterHandlers(false); 
        isAtStartup = false;
    }

	// client function
    public void OnConnected(NetworkMessage netMsg)
    {
        Debug.Log("Connected to server");
    }

	//sends a string to the server
	public void SendMsg(string message)
	{
		MyNetworkMessage messageContainer = new MyNetworkMessage();
        messageContainer.message = message;
		messageContainer.id = myID;
        myClient.Send(MyMessageTypes.str, messageContainer);
	}

	//send pose data
	public void SendPoseData()
	{
		PoseDataMessage pdm = new PoseDataMessage();
		pdm.id = myID;
		pdm.pd = NetTypes.getPoseData();
		myClient.Send(MyMessageTypes.pose, pdm);
	}
}