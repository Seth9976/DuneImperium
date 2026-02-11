using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace offlineChallenges.events
{
	// Token: 0x02000013 RID: 19
	public class SaveProgressEvent : OfflineChallenges.Event
	{
		// Token: 0x060000CE RID: 206 RVA: 0x000025A4 File Offset: 0x000007A4
		// Note: this type is marked as 'beforefieldinit'.
		static SaveProgressEvent()
		{
			Il2CppClassPointerStore<SaveProgressEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.events", "SaveProgressEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveProgressEvent>.NativeClassPtr);
			SaveProgressEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveProgressEvent>.NativeClassPtr, 100663416);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005524 File Offset: 0x00003724
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveProgressEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveProgressEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveProgressEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000025DD File Offset: 0x000007DD
		public SaveProgressEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
