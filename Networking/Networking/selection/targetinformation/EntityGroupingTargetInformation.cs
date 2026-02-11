using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000069 RID: 105
	public class EntityGroupingTargetInformation : TargetInformation
	{
		// Token: 0x0600036B RID: 875 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		// Note: this type is marked as 'beforefieldinit'.
		static EntityGroupingTargetInformation()
		{
			Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "EntityGroupingTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr);
			EntityGroupingTargetInformation.NativeFieldInfoPtr_ValidTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr, "ValidTargets");
			EntityGroupingTargetInformation.NativeFieldInfoPtr_NumberToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr, "NumberToSelect");
			EntityGroupingTargetInformation.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr, "Forced");
			EntityGroupingTargetInformation.NativeFieldInfoPtr_MinimumToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr, "MinimumToSelect");
			EntityGroupingTargetInformation.NativeFieldInfoPtr_HintTargetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr, "HintTargetMap");
			EntityGroupingTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr, 100663486);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000EC60 File Offset: 0x0000CE60
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityGroupingTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00004338 File Offset: 0x00002538
		public EntityGroupingTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000EC9C File Offset: 0x0000CE9C
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00004341 File Offset: 0x00002541
		public unsafe Il2CppReferenceArray<EntityGroupingTargetInformation.Grouping> ValidTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_ValidTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityGroupingTargetInformation.Grouping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_ValidTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000ECCC File Offset: 0x0000CECC
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00004360 File Offset: 0x00002560
		public unsafe int NumberToSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_NumberToSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_NumberToSelect)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000437B File Offset: 0x0000257B
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000ED1C File Offset: 0x0000CF1C
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00004396 File Offset: 0x00002596
		public unsafe int MinimumToSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_MinimumToSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_MinimumToSelect)) = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000ED44 File Offset: 0x0000CF44
		// (set) Token: 0x06000377 RID: 887 RVA: 0x000043B1 File Offset: 0x000025B1
		public unsafe Dictionary<TargetStrength, List<EntityID>> HintTargetMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_HintTargetMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TargetStrength, List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.NativeFieldInfoPtr_HintTargetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_ValidTargets;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_NumberToSelect;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_MinimumToSelect;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_HintTargetMap;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C5 RID: 197
		public class Grouping : Object
		{
			// Token: 0x06000669 RID: 1641 RVA: 0x00016BC4 File Offset: 0x00014DC4
			// Note: this type is marked as 'beforefieldinit'.
			static Grouping()
			{
				Il2CppClassPointerStore<EntityGroupingTargetInformation.Grouping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityGroupingTargetInformation>.NativeClassPtr, "Grouping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGroupingTargetInformation.Grouping>.NativeClassPtr);
				EntityGroupingTargetInformation.Grouping.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetInformation.Grouping>.NativeClassPtr, "Items");
				EntityGroupingTargetInformation.Grouping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetInformation.Grouping>.NativeClassPtr, 100663487);
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x00016C18 File Offset: 0x00014E18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Grouping()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetInformation.Grouping>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetInformation.Grouping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600066B RID: 1643 RVA: 0x00005FFD File Offset: 0x000041FD
			public Grouping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x0600066C RID: 1644 RVA: 0x00016C54 File Offset: 0x00014E54
			// (set) Token: 0x0600066D RID: 1645 RVA: 0x00006006 File Offset: 0x00004206
			public unsafe Il2CppReferenceArray<EntityID> Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.Grouping.NativeFieldInfoPtr_Items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetInformation.Grouping.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000355 RID: 853
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04000356 RID: 854
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
