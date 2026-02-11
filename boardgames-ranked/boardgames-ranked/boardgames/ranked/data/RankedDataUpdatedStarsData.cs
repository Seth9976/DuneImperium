using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.ranked.data
{
	// Token: 0x02000030 RID: 48
	public class RankedDataUpdatedStarsData : DataComponent
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x000083EC File Offset: 0x000065EC
		// Note: this type is marked as 'beforefieldinit'.
		static RankedDataUpdatedStarsData()
		{
			Il2CppClassPointerStore<RankedDataUpdatedStarsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.data", "RankedDataUpdatedStarsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedDataUpdatedStarsData>.NativeClassPtr);
			RankedDataUpdatedStarsData.NativeFieldInfoPtr__NewStars_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedStarsData>.NativeClassPtr, "<NewStars>k__BackingField");
			RankedDataUpdatedStarsData.NativeFieldInfoPtr__StartingStars_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedStarsData>.NativeClassPtr, "<StartingStars>k__BackingField");
			RankedDataUpdatedStarsData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsData>.NativeClassPtr, 100663448);
			RankedDataUpdatedStarsData.NativeMethodInfoPtr_get_NewStars_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsData>.NativeClassPtr, 100663449);
			RankedDataUpdatedStarsData.NativeMethodInfoPtr_get_StartingStars_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsData>.NativeClassPtr, 100663450);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008480 File Offset: 0x00006680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225868, XrefRangeEnd = 1225869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedDataUpdatedStarsData(int startingStars, int newStars)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedDataUpdatedStarsData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingStars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedStarsData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000084D8 File Offset: 0x000066D8
		public unsafe int NewStars
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedStarsData.NativeMethodInfoPtr_get_NewStars_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00008514 File Offset: 0x00006714
		public unsafe int StartingStars
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedStarsData.NativeMethodInfoPtr_get_StartingStars_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002FE2 File Offset: 0x000011E2
		public RankedDataUpdatedStarsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00008550 File Offset: 0x00006750
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002FEB File Offset: 0x000011EB
		public unsafe int _NewStars_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedStarsData.NativeFieldInfoPtr__NewStars_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedStarsData.NativeFieldInfoPtr__NewStars_k__BackingField)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00008578 File Offset: 0x00006778
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00003006 File Offset: 0x00001206
		public unsafe int _StartingStars_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedStarsData.NativeFieldInfoPtr__StartingStars_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedStarsData.NativeFieldInfoPtr__StartingStars_k__BackingField)) = value;
			}
		}

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr__NewStars_k__BackingField;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr__StartingStars_k__BackingField;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_NewStars_Public_get_Int32_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingStars_Public_get_Int32_0;
	}
}
