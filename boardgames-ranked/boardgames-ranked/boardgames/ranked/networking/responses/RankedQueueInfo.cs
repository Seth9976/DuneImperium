using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x0200000F RID: 15
	public class RankedQueueInfo : UpdateRankedQueueInfo
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000045D0 File Offset: 0x000027D0
		// Note: this type is marked as 'beforefieldinit'.
		static RankedQueueInfo()
		{
			Il2CppClassPointerStore<RankedQueueInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "RankedQueueInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedQueueInfo>.NativeClassPtr);
			RankedQueueInfo.NativeFieldInfoPtr_RankedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedQueueInfo>.NativeClassPtr, "RankedData");
			RankedQueueInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueInfo>.NativeClassPtr, 100663321);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004628 File Offset: 0x00002828
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedQueueInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedQueueInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002383 File Offset: 0x00000583
		public RankedQueueInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00004664 File Offset: 0x00002864
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000238C File Offset: 0x0000058C
		public unsafe PlayerRankedData RankedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueInfo.NativeFieldInfoPtr_RankedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerRankedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueInfo.NativeFieldInfoPtr_RankedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_RankedData;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
