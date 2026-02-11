using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class ClusterInput
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public static float GetAxis(string name)
		{
			return ClusterInput.GetAxisDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002062 File Offset: 0x00000262
		public static bool GetButton(string name)
		{
			return ClusterInput.GetButtonDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002204 File Offset: 0x00000404
		public static Vector3 GetTrackerPosition(string name)
		{
			Vector3 vector;
			ClusterInput.GetTrackerPosition_Injected(name, out vector);
			return vector;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000221C File Offset: 0x0000041C
		public static Quaternion GetTrackerRotation(string name)
		{
			Quaternion quaternion;
			ClusterInput.GetTrackerRotation_Injected(name, out quaternion);
			return quaternion;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002074 File Offset: 0x00000274
		public static void SetAxis(string name, float value)
		{
			ClusterInput.SetAxisDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002087 File Offset: 0x00000287
		public static void SetButton(string name, bool value)
		{
			ClusterInput.SetButtonDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000209A File Offset: 0x0000029A
		public static void SetTrackerPosition(string name, Vector3 value)
		{
			ClusterInput.SetTrackerPosition_Injected(name, ref value);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020A4 File Offset: 0x000002A4
		public static void SetTrackerRotation(string name, Quaternion value)
		{
			ClusterInput.SetTrackerRotation_Injected(name, ref value);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020AE File Offset: 0x000002AE
		public static bool AddInput(string name, string deviceName, string serverUrl, int index, ClusterInputType type)
		{
			return ClusterInput.AddInputDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.ManagedStringToIl2Cpp(deviceName), IL2CPP.ManagedStringToIl2Cpp(serverUrl), index, type);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020CF File Offset: 0x000002CF
		public static bool EditInput(string name, string deviceName, string serverUrl, int index, ClusterInputType type)
		{
			return ClusterInput.EditInputDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.ManagedStringToIl2Cpp(deviceName), IL2CPP.ManagedStringToIl2Cpp(serverUrl), index, type);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020F0 File Offset: 0x000002F0
		public static bool CheckConnectionToServer(string name)
		{
			return ClusterInput.CheckConnectionToServerDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002102 File Offset: 0x00000302
		public static void GetTrackerPosition_Injected(string name, out Vector3 ret)
		{
			ClusterInput.GetTrackerPosition_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002115 File Offset: 0x00000315
		public static void GetTrackerRotation_Injected(string name, out Quaternion ret)
		{
			ClusterInput.GetTrackerRotation_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002128 File Offset: 0x00000328
		public static void SetTrackerPosition_Injected(string name, ref Vector3 value)
		{
			ClusterInput.SetTrackerPosition_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), ref value);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000213B File Offset: 0x0000033B
		public static void SetTrackerRotation_Injected(string name, ref Quaternion value)
		{
			ClusterInput.SetTrackerRotation_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), ref value);
		}

		// Token: 0x04000006 RID: 6
		private static readonly ClusterInput.GetAxisDelegate GetAxisDelegateField = IL2CPP.ResolveICall<ClusterInput.GetAxisDelegate>("UnityEngine.ClusterInput::GetAxis");

		// Token: 0x04000007 RID: 7
		private static readonly ClusterInput.GetButtonDelegate GetButtonDelegateField = IL2CPP.ResolveICall<ClusterInput.GetButtonDelegate>("UnityEngine.ClusterInput::GetButton");

		// Token: 0x04000008 RID: 8
		private static readonly ClusterInput.SetAxisDelegate SetAxisDelegateField = IL2CPP.ResolveICall<ClusterInput.SetAxisDelegate>("UnityEngine.ClusterInput::SetAxis");

		// Token: 0x04000009 RID: 9
		private static readonly ClusterInput.SetButtonDelegate SetButtonDelegateField = IL2CPP.ResolveICall<ClusterInput.SetButtonDelegate>("UnityEngine.ClusterInput::SetButton");

		// Token: 0x0400000A RID: 10
		private static readonly ClusterInput.AddInputDelegate AddInputDelegateField = IL2CPP.ResolveICall<ClusterInput.AddInputDelegate>("UnityEngine.ClusterInput::AddInput");

		// Token: 0x0400000B RID: 11
		private static readonly ClusterInput.EditInputDelegate EditInputDelegateField = IL2CPP.ResolveICall<ClusterInput.EditInputDelegate>("UnityEngine.ClusterInput::EditInput");

		// Token: 0x0400000C RID: 12
		private static readonly ClusterInput.CheckConnectionToServerDelegate CheckConnectionToServerDelegateField = IL2CPP.ResolveICall<ClusterInput.CheckConnectionToServerDelegate>("UnityEngine.ClusterInput::CheckConnectionToServer");

		// Token: 0x0400000D RID: 13
		private static readonly ClusterInput.GetTrackerPosition_InjectedDelegate GetTrackerPosition_InjectedDelegateField = IL2CPP.ResolveICall<ClusterInput.GetTrackerPosition_InjectedDelegate>("UnityEngine.ClusterInput::GetTrackerPosition_Injected");

		// Token: 0x0400000E RID: 14
		private static readonly ClusterInput.GetTrackerRotation_InjectedDelegate GetTrackerRotation_InjectedDelegateField = IL2CPP.ResolveICall<ClusterInput.GetTrackerRotation_InjectedDelegate>("UnityEngine.ClusterInput::GetTrackerRotation_Injected");

		// Token: 0x0400000F RID: 15
		private static readonly ClusterInput.SetTrackerPosition_InjectedDelegate SetTrackerPosition_InjectedDelegateField = IL2CPP.ResolveICall<ClusterInput.SetTrackerPosition_InjectedDelegate>("UnityEngine.ClusterInput::SetTrackerPosition_Injected");

		// Token: 0x04000010 RID: 16
		private static readonly ClusterInput.SetTrackerRotation_InjectedDelegate SetTrackerRotation_InjectedDelegateField = IL2CPP.ResolveICall<ClusterInput.SetTrackerRotation_InjectedDelegate>("UnityEngine.ClusterInput::SetTrackerRotation_Injected");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000012 RID: 18
		private delegate float GetAxisDelegate(IntPtr name);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000014 RID: 20
		private delegate bool GetButtonDelegate(IntPtr name);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000016 RID: 22
		private delegate void SetAxisDelegate(IntPtr name, float value);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000018 RID: 24
		private delegate void SetButtonDelegate(IntPtr name, bool value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001A RID: 26
		private delegate bool AddInputDelegate(IntPtr name, IntPtr deviceName, IntPtr serverUrl, int index, ClusterInputType type);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600001C RID: 28
		private delegate bool EditInputDelegate(IntPtr name, IntPtr deviceName, IntPtr serverUrl, int index, ClusterInputType type);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600001E RID: 30
		private delegate bool CheckConnectionToServerDelegate(IntPtr name);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate void GetTrackerPosition_InjectedDelegate(IntPtr name, [Out] IntPtr ret);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate void GetTrackerRotation_InjectedDelegate(IntPtr name, [Out] IntPtr ret);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate void SetTrackerPosition_InjectedDelegate(IntPtr name, IntPtr value);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate void SetTrackerRotation_InjectedDelegate(IntPtr name, IntPtr value);
	}
}
