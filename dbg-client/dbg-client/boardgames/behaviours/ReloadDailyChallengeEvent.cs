using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002AA RID: 682
	public class ReloadDailyChallengeEvent : MonoBehaviour
	{
		// Token: 0x06002064 RID: 8292 RVA: 0x00089888 File Offset: 0x00087A88
		// Note: this type is marked as 'beforefieldinit'.
		static ReloadDailyChallengeEvent()
		{
			Il2CppClassPointerStore<ReloadDailyChallengeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "ReloadDailyChallengeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReloadDailyChallengeEvent>.NativeClassPtr);
			ReloadDailyChallengeEvent.NativeMethodInfoPtr_Event_Reload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadDailyChallengeEvent>.NativeClassPtr, 100668682);
			ReloadDailyChallengeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadDailyChallengeEvent>.NativeClassPtr, 100668683);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000898E0 File Offset: 0x00087AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542398, XrefRangeEnd = 542403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReloadDailyChallengeEvent.NativeMethodInfoPtr_Event_Reload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00089914 File Offset: 0x00087B14
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReloadDailyChallengeEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReloadDailyChallengeEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReloadDailyChallengeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00010FAD File Offset: 0x0000F1AD
		public ReloadDailyChallengeEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_Event_Reload_Public_Void_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
