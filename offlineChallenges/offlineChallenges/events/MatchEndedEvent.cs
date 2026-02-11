using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace offlineChallenges.events
{
	// Token: 0x0200000F RID: 15
	public class MatchEndedEvent : OfflineChallenges.Event
	{
		// Token: 0x060000BC RID: 188 RVA: 0x000024D8 File Offset: 0x000006D8
		// Note: this type is marked as 'beforefieldinit'.
		static MatchEndedEvent()
		{
			Il2CppClassPointerStore<MatchEndedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.events", "MatchEndedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchEndedEvent>.NativeClassPtr);
			MatchEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEndedEvent>.NativeClassPtr, 100663410);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000051CC File Offset: 0x000033CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchEndedEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchEndedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEndedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002511 File Offset: 0x00000711
		public MatchEndedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
