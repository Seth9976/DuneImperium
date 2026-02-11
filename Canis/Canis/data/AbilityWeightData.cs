using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x0200014B RID: 331
	[Serializable]
	public class AbilityWeightData : Object
	{
		// Token: 0x06000EAA RID: 3754 RVA: 0x0005759C File Offset: 0x0005579C
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityWeightData()
		{
			Il2CppClassPointerStore<AbilityWeightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "AbilityWeightData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityWeightData>.NativeClassPtr);
			AbilityWeightData.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityWeightData>.NativeClassPtr, "ability");
			AbilityWeightData.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityWeightData>.NativeClassPtr, "weight");
			AbilityWeightData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityWeightData>.NativeClassPtr, 100666455);
			AbilityWeightData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityWeightData>.NativeClassPtr, 100666456);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0005761C File Offset: 0x0005581C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577500, XrefRangeEnd = 577518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityWeightData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00057660 File Offset: 0x00055860
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityWeightData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityWeightData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityWeightData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000075FF File Offset: 0x000057FF
		public AbilityWeightData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0005769C File Offset: 0x0005589C
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x00007608 File Offset: 0x00005808
		public unsafe string ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityWeightData.NativeFieldInfoPtr_ability);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityWeightData.NativeFieldInfoPtr_ability), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x000576C4 File Offset: 0x000558C4
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x00007627 File Offset: 0x00005827
		public unsafe int weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityWeightData.NativeFieldInfoPtr_weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityWeightData.NativeFieldInfoPtr_weight)) = value;
			}
		}

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_ability;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_weight;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
