using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x02000015 RID: 21
	public class RankedQueueLeft : NetworkMessageEvent
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000025EA File Offset: 0x000007EA
		// Note: this type is marked as 'beforefieldinit'.
		static RankedQueueLeft()
		{
			Il2CppClassPointerStore<RankedQueueLeft>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "RankedQueueLeft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedQueueLeft>.NativeClassPtr);
			RankedQueueLeft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueLeft>.NativeClassPtr, 100663326);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004C8C File Offset: 0x00002E8C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedQueueLeft()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedQueueLeft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueLeft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002623 File Offset: 0x00000823
		public RankedQueueLeft(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
