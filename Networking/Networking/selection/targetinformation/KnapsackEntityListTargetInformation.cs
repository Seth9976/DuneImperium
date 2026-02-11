using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000073 RID: 115
	public class KnapsackEntityListTargetInformation : TargetInformation
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		// Note: this type is marked as 'beforefieldinit'.
		static KnapsackEntityListTargetInformation()
		{
			Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "KnapsackEntityListTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr);
			KnapsackEntityListTargetInformation.NativeFieldInfoPtr_ValidTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr, "ValidTargets");
			KnapsackEntityListTargetInformation.NativeFieldInfoPtr_TargetWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr, "TargetWeight");
			KnapsackEntityListTargetInformation.NativeFieldInfoPtr_knapsackSelectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr, "knapsackSelectionMode");
			KnapsackEntityListTargetInformation.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr, "Forced");
			KnapsackEntityListTargetInformation.NativeFieldInfoPtr_HintTargetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr, "HintTargetMap");
			KnapsackEntityListTargetInformation.NativeMethodInfoPtr_Clone_Public_KnapsackEntityListTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr, 100663535);
			KnapsackEntityListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr, 100663536);
			KnapsackEntityListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr, 100663537);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000100BC File Offset: 0x0000E2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194394, XrefRangeEnd = 1194397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KnapsackEntityListTargetInformation Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetInformation.NativeMethodInfoPtr_Clone_Public_KnapsackEntityListTargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<KnapsackEntityListTargetInformation>(intPtr3) : null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000100FC File Offset: 0x0000E2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194397, XrefRangeEnd = 1194406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackEntityListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00010140 File Offset: 0x0000E340
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KnapsackEntityListTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnapsackEntityListTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00004621 File Offset: 0x00002821
		public KnapsackEntityListTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0001017C File Offset: 0x0000E37C
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0000462A File Offset: 0x0000282A
		public unsafe Dictionary<EntityID, int> ValidTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_ValidTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_ValidTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x000101AC File Offset: 0x0000E3AC
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00004649 File Offset: 0x00002849
		public unsafe int TargetWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_TargetWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_TargetWeight)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000101D4 File Offset: 0x0000E3D4
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00004664 File Offset: 0x00002864
		public unsafe KnapsackSelectionMode knapsackSelectionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_knapsackSelectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_knapsackSelectionMode)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003DB RID: 987 RVA: 0x000101FC File Offset: 0x0000E3FC
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0000467F File Offset: 0x0000287F
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00010224 File Offset: 0x0000E424
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000469A File Offset: 0x0000289A
		public unsafe Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>> HintTargetMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_HintTargetMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetInformation.NativeFieldInfoPtr_HintTargetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_ValidTargets;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_TargetWeight;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_knapsackSelectionMode;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_HintTargetMap;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_KnapsackEntityListTargetInformation_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
