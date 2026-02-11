using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000002 RID: 2
	public static class System
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000208E File Offset: 0x0000028E
		public static bool enabled
		{
			get
			{
				return UnityEngine.Rendering.VirtualTexturing.System.get_enabledDelegateField();
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000209A File Offset: 0x0000029A
		public static void Update()
		{
			UnityEngine.Rendering.VirtualTexturing.System.UpdateDelegateField();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020A6 File Offset: 0x000002A6
		public static void SetDebugFlag(Guid guid, bool enabled)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagInteger(guid.ToByteArray(), enabled ? 1L : 0L);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020BE File Offset: 0x000002BE
		public static void SetDebugFlagInteger(Guid guid, long value)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagInteger(guid.ToByteArray(), value);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020CF File Offset: 0x000002CF
		public static void SetDebugFlagDouble(Guid guid, double value)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagDouble(guid.ToByteArray(), value);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020E0 File Offset: 0x000002E0
		public static void SetDebugFlagInteger(Il2CppStructArray<byte> guid, long value)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagIntegerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(guid), value);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020F3 File Offset: 0x000002F3
		public static void SetDebugFlagDouble(Il2CppStructArray<byte> guid, double value)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagDoubleDelegateField(IL2CPP.Il2CppObjectBaseToPtr(guid), value);
		}

		// Token: 0x04000001 RID: 1
		public const int AllMips = 2147483647;

		// Token: 0x04000002 RID: 2
		private static readonly UnityEngine.Rendering.VirtualTexturing.System.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<UnityEngine.Rendering.VirtualTexturing.System.get_enabledDelegate>("UnityEngine.Rendering.VirtualTexturing.System::get_enabled");

		// Token: 0x04000003 RID: 3
		private static readonly UnityEngine.Rendering.VirtualTexturing.System.UpdateDelegate UpdateDelegateField = IL2CPP.ResolveICall<UnityEngine.Rendering.VirtualTexturing.System.UpdateDelegate>("UnityEngine.Rendering.VirtualTexturing.System::Update");

		// Token: 0x04000004 RID: 4
		private static readonly UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagIntegerDelegate SetDebugFlagIntegerDelegateField = IL2CPP.ResolveICall<UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagIntegerDelegate>("UnityEngine.Rendering.VirtualTexturing.System::SetDebugFlagInteger");

		// Token: 0x04000005 RID: 5
		private static readonly UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagDoubleDelegate SetDebugFlagDoubleDelegateField = IL2CPP.ResolveICall<UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagDoubleDelegate>("UnityEngine.Rendering.VirtualTexturing.System::SetDebugFlagDouble");

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate bool get_enabledDelegate();

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000037 RID: 55
		private delegate void UpdateDelegate();

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000039 RID: 57
		private delegate void SetDebugFlagIntegerDelegate(IntPtr guid, long value);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600003B RID: 59
		private delegate void SetDebugFlagDoubleDelegate(IntPtr guid, double value);
	}
}
