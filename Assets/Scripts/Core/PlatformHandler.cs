using UnityEngine;
using UnityEngine.UI;
using System;


public class PlatformHandler : MonoBehaviour 
{
	public Text comment;

	public bool displayPlatformComment = false;
	public bool logInfo = false;

	public string CurrentVersion;
	public string NT10Info = "While this game will run on Windows 10/11, it is not ideal and you could run into issues. For the best experience downgrade to f. ex. Windows 7";
	public string NT5Info = "Oh, you're using a Windows from the golden age";
	// /*
	void Start () 
	{
		if (logInfo) 
		{
			ConsoleLogging ();
		}

		if (displayPlatformComment) 
		{
			var str = GetCurrentPlatform(); //Just to chop of the "Microsoft Windows NT" and remove the points in it
			var charsToRemove = new string[] {"Microsoft Windows NT ", "."};
			foreach (var c in charsToRemove)
			{
				str = str.Replace(c, string.Empty);
			}
			CurrentVersion = str.ToString();
			//Debug.Log(CurrentVersion);
			int i = Int32.Parse(CurrentVersion);
			//Debug.Log(i);
			if(i >= 6400000)
			{
				comment.text = NT10Info;
			}

			if(i >= 5000000 && i <= 5999999)
			{
				comment.text = NT5Info;
			}
		}
	}
	// */

	//Uncomment if you want to completely remove the Platform Comment

	//Just to get system info comments in the console
	private void ConsoleLogging()
	{
		GetCurrentPlatform();
		GetInstalledRam();
		GetInstalledGPU();
		GetInstalledVram();
		GetInstalledCPU();
		GetInstalledCPUCores();
		GetInstalledCPUThreads();
		GetUsedNetworkConnection();
	}


	//These methods are determening system infos

	//Returns platform info
	public string GetCurrentPlatform() //Returns the current platform
	{
		Debug.Log("Platform: " + System.Environment.OSVersion);
		return System.Environment.OSVersion.ToString();
	}

	//Returns installed RAM
	public int GetInstalledRam()
	{
		Debug.Log("Installed RAM: " + SystemInfo.systemMemorySize + "MB");
		return SystemInfo.systemMemorySize;
	}

	//Returns GPU type
	public string GetInstalledGPU()
	{
		Debug.Log("Graphics card:" + SystemInfo.graphicsDeviceName);
		return SystemInfo.graphicsDeviceName;
	}

	//Returns installled vRAM
	public int GetInstalledVram()
	{
		Debug.Log("Installed vRAM: " + SystemInfo.graphicsMemorySize + "MB");
		return SystemInfo.graphicsMemorySize;
	}

	//Returns CPU type
	public string GetInstalledCPU()
	{
		Debug.Log("Processor:" + SystemInfo.processorType);
		return SystemInfo.processorType;
	}

	//Returns CPU cores
	public int GetInstalledCPUCores()
	{
		Debug.Log("Processor Cores: " + SystemInfo.processorCount);
		return SystemInfo.processorCount;
	}

	//Returns CPU threads
	public int GetInstalledCPUThreads()
	{
		Debug.Log("Processor Threads: " + SystemInfo.processorCount * 2);
		return SystemInfo.processorCount * 2;
	}

	public string GetUsedNetworkConnection()
	{
		Debug.Log("Network Connection: " + Application.internetReachability);
		return Application.internetReachability.ToString();
	}
}
