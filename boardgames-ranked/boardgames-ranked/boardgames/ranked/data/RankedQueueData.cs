using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.ranked.data
{
	// Token: 0x02000034 RID: 52
	public class RankedQueueData : DataComponent
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00008914 File Offset: 0x00006B14
		// Note: this type is marked as 'beforefieldinit'.
		static RankedQueueData()
		{
			Il2CppClassPointerStore<RankedQueueData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.data", "RankedQueueData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedQueueData>.NativeClassPtr);
			RankedQueueData.NativeFieldInfoPtr__GameStartTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedQueueData>.NativeClassPtr, "<GameStartTime>k__BackingField");
			RankedQueueData.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueData>.NativeClassPtr, 100663457);
			RankedQueueData.NativeMethodInfoPtr_get_GameStartTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueData>.NativeClassPtr, 100663458);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008980 File Offset: 0x00006B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225870, XrefRangeEnd = 1225880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedQueueData(long waitTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedQueueData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref waitTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueData.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000089C8 File Offset: 0x00006BC8
		public unsafe DateTime GameStartTime
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueData.NativeMethodInfoPtr_get_GameStartTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000030A8 File Offset: 0x000012A8
		public RankedQueueData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00008A04 File Offset: 0x00006C04
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000030B1 File Offset: 0x000012B1
		public unsafe DateTime _GameStartTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueData.NativeFieldInfoPtr__GameStartTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueData.NativeFieldInfoPtr__GameStartTime_k__BackingField)) = value;
			}
		}

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr__GameStartTime_k__BackingField;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_get_GameStartTime_Public_get_DateTime_0;
	}
}
