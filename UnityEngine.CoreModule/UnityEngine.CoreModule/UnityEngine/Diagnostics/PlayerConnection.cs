using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.Diagnostics
{
	// Token: 0x0200035F RID: 863
	public static class PlayerConnection
	{
		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x000B58B4 File Offset: 0x000B3AB4
		public static bool connected
		{
			get
			{
				return UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.isConnected;
			}
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00012A16 File Offset: 0x00010C16
		public static void SendFile(string remoteFilePath, Il2CppStructArray<byte> data)
		{
		}
	}
}
