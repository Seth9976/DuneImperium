using System;
using boardgames.ranked.networking.responses;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.ranked.data
{
	// Token: 0x0200002F RID: 47
	public class RankedDataUpdatedRankData : DataComponent
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00008238 File Offset: 0x00006438
		// Note: this type is marked as 'beforefieldinit'.
		static RankedDataUpdatedRankData()
		{
			Il2CppClassPointerStore<RankedDataUpdatedRankData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.data", "RankedDataUpdatedRankData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedDataUpdatedRankData>.NativeClassPtr);
			RankedDataUpdatedRankData.NativeFieldInfoPtr__NewRank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedRankData>.NativeClassPtr, "<NewRank>k__BackingField");
			RankedDataUpdatedRankData.NativeFieldInfoPtr__StartingRank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedRankData>.NativeClassPtr, "<StartingRank>k__BackingField");
			RankedDataUpdatedRankData.NativeMethodInfoPtr__ctor_Public_Void_RankName_RankName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedRankData>.NativeClassPtr, 100663445);
			RankedDataUpdatedRankData.NativeMethodInfoPtr_get_NewRank_Public_get_RankName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedRankData>.NativeClassPtr, 100663446);
			RankedDataUpdatedRankData.NativeMethodInfoPtr_get_StartingRank_Public_get_RankName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedRankData>.NativeClassPtr, 100663447);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000082CC File Offset: 0x000064CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225867, XrefRangeEnd = 1225868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedDataUpdatedRankData(RankName startingRank, RankName newRank)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedDataUpdatedRankData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingRank;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedRankData.NativeMethodInfoPtr__ctor_Public_Void_RankName_RankName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00008324 File Offset: 0x00006524
		public unsafe RankName NewRank
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedRankData.NativeMethodInfoPtr_get_NewRank_Public_get_RankName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00008360 File Offset: 0x00006560
		public unsafe RankName StartingRank
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedRankData.NativeMethodInfoPtr_get_StartingRank_Public_get_RankName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002FA3 File Offset: 0x000011A3
		public RankedDataUpdatedRankData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000839C File Offset: 0x0000659C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002FAC File Offset: 0x000011AC
		public unsafe RankName _NewRank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedRankData.NativeFieldInfoPtr__NewRank_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedRankData.NativeFieldInfoPtr__NewRank_k__BackingField)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000083C4 File Offset: 0x000065C4
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002FC7 File Offset: 0x000011C7
		public unsafe RankName _StartingRank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedRankData.NativeFieldInfoPtr__StartingRank_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedRankData.NativeFieldInfoPtr__StartingRank_k__BackingField)) = value;
			}
		}

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr__NewRank_k__BackingField;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr__StartingRank_k__BackingField;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RankName_RankName_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_NewRank_Public_get_RankName_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingRank_Public_get_RankName_0;
	}
}
