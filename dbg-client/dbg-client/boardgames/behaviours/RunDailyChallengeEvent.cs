using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002AD RID: 685
	public class RunDailyChallengeEvent : MonoBehaviour
	{
		// Token: 0x0600207B RID: 8315 RVA: 0x00089C98 File Offset: 0x00087E98
		// Note: this type is marked as 'beforefieldinit'.
		static RunDailyChallengeEvent()
		{
			Il2CppClassPointerStore<RunDailyChallengeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "RunDailyChallengeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengeEvent>.NativeClassPtr);
			RunDailyChallengeEvent.NativeMethodInfoPtr_Event_Run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeEvent>.NativeClassPtr, 100668697);
			RunDailyChallengeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeEvent>.NativeClassPtr, 100668698);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00089CF0 File Offset: 0x00087EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542512, XrefRangeEnd = 542522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeEvent.NativeMethodInfoPtr_Event_Run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00089D24 File Offset: 0x00087F24
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDailyChallengeEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengeEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00011063 File Offset: 0x0000F263
		public RunDailyChallengeEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_Event_Run_Public_Void_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
