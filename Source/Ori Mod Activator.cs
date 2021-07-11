class GameController
	Start()
		var xNyuObject = new GameObject();
	        xNyuObject.AddComponent<xNyuDebugMenu>();
        	GameObject.DontDestroyOnLoad(xNyuObject);



Change DebugMenuB.ResumeGameplay() to public
Change DebugMenuB.SuspendGameplay() to public
