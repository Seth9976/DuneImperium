using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.ranked.networking
{
	// Token: 0x0200000A RID: 10
	public class LeaveQueueForRankedMatch : NetworkMessageEvent
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000021F8 File Offset: 0x000003F8
		// Note: this type is marked as 'beforefieldinit'.
		static LeaveQueueForRankedMatch()
		{
			Il2CppClassPointerStore<LeaveQueueForRankedMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking", "LeaveQueueForRankedMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaveQueueForRankedMatch>.NativeClassPtr);
			LeaveQueueForRankedMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveQueueForRankedMatch>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000041E0 File Offset: 0x000023E0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaveQueueForRankedMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaveQueueForRankedMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveQueueForRankedMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002231 File Offset: 0x00000431
		public LeaveQueueForRankedMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
