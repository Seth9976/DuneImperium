using System;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace voodoo.flavors
{
	// Token: 0x0200003E RID: 62
	public class MultiPileFlavors : MonoBehaviour
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x00015BF0 File Offset: 0x00013DF0
		// Note: this type is marked as 'beforefieldinit'.
		static MultiPileFlavors()
		{
			Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.flavors", "MultiPileFlavors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr);
			MultiPileFlavors.NativeFieldInfoPtr_flavorSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, "flavorSets");
			MultiPileFlavors.NativeFieldInfoPtr_flavorsByKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, "flavorsByKey");
			MultiPileFlavors.NativeFieldInfoPtr_updateManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, "updateManager");
			MultiPileFlavors.NativeFieldInfoPtr__Metadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, "<Metadata>k__BackingField");
			MultiPileFlavors.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, 100663745);
			MultiPileFlavors.NativeMethodInfoPtr_Event_SetFlavorSet_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, 100663746);
			MultiPileFlavors.NativeMethodInfoPtr_get_Metadata_Public_Virtual_Final_New_get_PrefabFlavorsMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, 100663747);
			MultiPileFlavors.NativeMethodInfoPtr_set_Metadata_Private_set_Void_PrefabFlavorsMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, 100663748);
			MultiPileFlavors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, 100663749);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00015CD4 File Offset: 0x00013ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109574, XrefRangeEnd = 1109582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiPileFlavors.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00015D08 File Offset: 0x00013F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109582, XrefRangeEnd = 1109587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetFlavorSet(string setName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(setName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiPileFlavors.NativeMethodInfoPtr_Event_SetFlavorSet_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00015D4C File Offset: 0x00013F4C
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00015D84 File Offset: 0x00013F84
		public unsafe virtual PrefabFlavorsMetaData Metadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiPileFlavors.NativeMethodInfoPtr_get_Metadata_Public_Virtual_Final_New_get_PrefabFlavorsMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new PrefabFlavorsMetaData(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109587, XrefRangeEnd = 1109588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiPileFlavors.NativeMethodInfoPtr_set_Metadata_Private_set_Void_PrefabFlavorsMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00015DCC File Offset: 0x00013FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109588, XrefRangeEnd = 1109596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiPileFlavors()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiPileFlavors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00004093 File Offset: 0x00002293
		public MultiPileFlavors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00015E08 File Offset: 0x00014008
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0000409C File Offset: 0x0000229C
		public unsafe Il2CppReferenceArray<MultiPileFlavors.FlavorSet> flavorSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.NativeFieldInfoPtr_flavorSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MultiPileFlavors.FlavorSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.NativeFieldInfoPtr_flavorSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00015E38 File Offset: 0x00014038
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000040BB File Offset: 0x000022BB
		public unsafe Dictionary<string, PrefabFlavorsMetaData> flavorsByKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.NativeFieldInfoPtr_flavorsByKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PrefabFlavorsMetaData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.NativeFieldInfoPtr_flavorsByKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00015E68 File Offset: 0x00014068
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000040DA File Offset: 0x000022DA
		public unsafe UpdateManager updateManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.NativeFieldInfoPtr_updateManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.NativeFieldInfoPtr_updateManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00015E98 File Offset: 0x00014098
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x000040F9 File Offset: 0x000022F9
		public PrefabFlavorsMetaData _Metadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.NativeFieldInfoPtr__Metadata_k__BackingField);
				return new PrefabFlavorsMetaData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.NativeFieldInfoPtr__Metadata_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_flavorSets;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_flavorsByKey;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_updateManager;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr__Metadata_k__BackingField;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetFlavorSet_Public_Void_String_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_Virtual_Final_New_get_PrefabFlavorsMetaData_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_set_Metadata_Private_set_Void_PrefabFlavorsMetaData_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000CC RID: 204
		[Serializable]
		public sealed class FlavorSet : ValueType
		{
			// Token: 0x06000ACA RID: 2762 RVA: 0x0002CC38 File Offset: 0x0002AE38
			// Note: this type is marked as 'beforefieldinit'.
			static FlavorSet()
			{
				Il2CppClassPointerStore<MultiPileFlavors.FlavorSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiPileFlavors>.NativeClassPtr, "FlavorSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiPileFlavors.FlavorSet>.NativeClassPtr);
				MultiPileFlavors.FlavorSet.NativeFieldInfoPtr_setName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiPileFlavors.FlavorSet>.NativeClassPtr, "setName");
				MultiPileFlavors.FlavorSet.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiPileFlavors.FlavorSet>.NativeClassPtr, "metadata");
			}

			// Token: 0x06000ACB RID: 2763 RVA: 0x000074C3 File Offset: 0x000056C3
			public FlavorSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000ACC RID: 2764 RVA: 0x000074CC File Offset: 0x000056CC
			public FlavorSet()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiPileFlavors.FlavorSet>.NativeClassPtr))
			{
			}

			// Token: 0x1700031C RID: 796
			// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0002CC8C File Offset: 0x0002AE8C
			// (set) Token: 0x06000ACE RID: 2766 RVA: 0x000074DE File Offset: 0x000056DE
			public unsafe string setName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.FlavorSet.NativeFieldInfoPtr_setName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.FlavorSet.NativeFieldInfoPtr_setName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700031D RID: 797
			// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0002CCB4 File Offset: 0x0002AEB4
			// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x000074FD File Offset: 0x000056FD
			public PrefabFlavorsMetaData metadata
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.FlavorSet.NativeFieldInfoPtr_metadata);
					return new PrefabFlavorsMetaData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiPileFlavors.FlavorSet.NativeFieldInfoPtr_metadata), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040006BC RID: 1724
			private static readonly IntPtr NativeFieldInfoPtr_setName;

			// Token: 0x040006BD RID: 1725
			private static readonly IntPtr NativeFieldInfoPtr_metadata;
		}
	}
}
