using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.LowLevel
{
	// Token: 0x0200032D RID: 813
	public class PlayerLoop
	{
		// Token: 0x06002E23 RID: 11811 RVA: 0x000B4A98 File Offset: 0x000B2C98
		public static PlayerLoopSystem GetDefaultPlayerLoop()
		{
			Il2CppReferenceArray<PlayerLoopSystemInternal> defaultPlayerLoopInternal = PlayerLoop.GetDefaultPlayerLoopInternal();
			int num = 0;
			return PlayerLoop.InternalToPlayerLoopSystem(defaultPlayerLoopInternal, ref num);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000B4ABC File Offset: 0x000B2CBC
		public static PlayerLoopSystem GetCurrentPlayerLoop()
		{
			Il2CppReferenceArray<PlayerLoopSystemInternal> currentPlayerLoopInternal = PlayerLoop.GetCurrentPlayerLoopInternal();
			int num = 0;
			return PlayerLoop.InternalToPlayerLoopSystem(currentPlayerLoopInternal, ref num);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x000B4AE0 File Offset: 0x000B2CE0
		public static void SetPlayerLoop(PlayerLoopSystem loop)
		{
			List<PlayerLoopSystemInternal> list = new List<PlayerLoopSystemInternal>();
			PlayerLoop.PlayerLoopSystemToInternal(loop, ref list);
			PlayerLoop.SetPlayerLoopInternal(list.ToArray());
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00012768 File Offset: 0x00010968
		public static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00012775 File Offset: 0x00010975
		public static PlayerLoopSystem InternalToPlayerLoopSystem(Il2CppReferenceArray<PlayerLoopSystemInternal> internalSys, ref int offset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x000B4B0C File Offset: 0x000B2D0C
		public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetDefaultPlayerLoopInternal()
		{
			IntPtr intPtr = PlayerLoop.GetDefaultPlayerLoopInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr2) : null;
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000B4B34 File Offset: 0x000B2D34
		public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetCurrentPlayerLoopInternal()
		{
			IntPtr intPtr = PlayerLoop.GetCurrentPlayerLoopInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr2) : null;
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00012782 File Offset: 0x00010982
		public static void SetPlayerLoopInternal(Il2CppReferenceArray<PlayerLoopSystemInternal> loop)
		{
			PlayerLoop.SetPlayerLoopInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(loop));
		}

		// Token: 0x040029AB RID: 10667
		private static readonly PlayerLoop.GetDefaultPlayerLoopInternalDelegate GetDefaultPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.GetDefaultPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetDefaultPlayerLoopInternal");

		// Token: 0x040029AC RID: 10668
		private static readonly PlayerLoop.GetCurrentPlayerLoopInternalDelegate GetCurrentPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.GetCurrentPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetCurrentPlayerLoopInternal");

		// Token: 0x040029AD RID: 10669
		private static readonly PlayerLoop.SetPlayerLoopInternalDelegate SetPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.SetPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::SetPlayerLoopInternal");

		// Token: 0x02000B81 RID: 2945
		// (Invoke) Token: 0x06003FF5 RID: 16373
		private delegate IntPtr GetDefaultPlayerLoopInternalDelegate();

		// Token: 0x02000B82 RID: 2946
		// (Invoke) Token: 0x06003FF7 RID: 16375
		private delegate IntPtr GetCurrentPlayerLoopInternalDelegate();

		// Token: 0x02000B83 RID: 2947
		// (Invoke) Token: 0x06003FF9 RID: 16377
		private delegate void SetPlayerLoopInternalDelegate(IntPtr loop);
	}
}
