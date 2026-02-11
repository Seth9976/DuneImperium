using System;
using dwd.core.data.composition;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.ranked
{
	// Token: 0x02000006 RID: 6
	public class RankedDataUpdatedGameData : DataComponent
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00003C0C File Offset: 0x00001E0C
		// Note: this type is marked as 'beforefieldinit'.
		static RankedDataUpdatedGameData()
		{
			Il2CppClassPointerStore<RankedDataUpdatedGameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked", "RankedDataUpdatedGameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedDataUpdatedGameData>.NativeClassPtr);
			RankedDataUpdatedGameData.NativeFieldInfoPtr__Opponents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedGameData>.NativeClassPtr, "<Opponents>k__BackingField");
			RankedDataUpdatedGameData.NativeFieldInfoPtr__Timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedGameData>.NativeClassPtr, "<Timestamp>k__BackingField");
			RankedDataUpdatedGameData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedGameData>.NativeClassPtr, 100663303);
			RankedDataUpdatedGameData.NativeMethodInfoPtr_get_Opponents_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedGameData>.NativeClassPtr, 100663304);
			RankedDataUpdatedGameData.NativeMethodInfoPtr_get_Timestamp_Public_get_WargTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedGameData>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003CA0 File Offset: 0x00001EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224642, XrefRangeEnd = 1224648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedDataUpdatedGameData(Il2CppStringArray opponents, long timestamp)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedDataUpdatedGameData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(opponents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedGameData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003CFC File Offset: 0x00001EFC
		public unsafe Il2CppStringArray Opponents
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedGameData.NativeMethodInfoPtr_get_Opponents_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003D3C File Offset: 0x00001F3C
		public unsafe WargTime Timestamp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedGameData.NativeMethodInfoPtr_get_Timestamp_Public_get_WargTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new WargTime(intPtr);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020E7 File Offset: 0x000002E7
		public RankedDataUpdatedGameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003D74 File Offset: 0x00001F74
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe Il2CppStringArray _Opponents_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedGameData.NativeFieldInfoPtr__Opponents_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedGameData.NativeFieldInfoPtr__Opponents_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003DA4 File Offset: 0x00001FA4
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000210F File Offset: 0x0000030F
		public WargTime _Timestamp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedGameData.NativeFieldInfoPtr__Timestamp_k__BackingField);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedGameData.NativeFieldInfoPtr__Timestamp_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr__Opponents_k__BackingField;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr__Timestamp_k__BackingField;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Int64_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_Opponents_Public_get_Il2CppStringArray_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_Timestamp_Public_get_WargTime_0;
	}
}
