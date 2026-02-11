using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace offlineChallenges.events
{
	// Token: 0x02000012 RID: 18
	public class RevertProgressEvent : OfflineChallenges.Event
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00002562 File Offset: 0x00000762
		// Note: this type is marked as 'beforefieldinit'.
		static RevertProgressEvent()
		{
			Il2CppClassPointerStore<RevertProgressEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.events", "RevertProgressEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevertProgressEvent>.NativeClassPtr);
			RevertProgressEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevertProgressEvent>.NativeClassPtr, 100663415);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000054E8 File Offset: 0x000036E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevertProgressEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevertProgressEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevertProgressEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000259B File Offset: 0x0000079B
		public RevertProgressEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
