using System;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace voodoo.flavors
{
	// Token: 0x0200003F RID: 63
	public class PileFlavors : MonoBehaviour
	{
		// Token: 0x060003FC RID: 1020 RVA: 0x00015EC8 File Offset: 0x000140C8
		// Note: this type is marked as 'beforefieldinit'.
		static PileFlavors()
		{
			Il2CppClassPointerStore<PileFlavors>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.flavors", "PileFlavors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PileFlavors>.NativeClassPtr);
			PileFlavors.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileFlavors>.NativeClassPtr, "metadata");
			PileFlavors.NativeFieldInfoPtr_includeSrcDestFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileFlavors>.NativeClassPtr, "includeSrcDestFlavors");
			PileFlavors.NativeMethodInfoPtr_get_Metadata_Public_Virtual_Final_New_get_PrefabFlavorsMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileFlavors>.NativeClassPtr, 100663750);
			PileFlavors.NativeMethodInfoPtr_get_IncludeSrcDestFlavors_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileFlavors>.NativeClassPtr, 100663751);
			PileFlavors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileFlavors>.NativeClassPtr, 100663752);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00015F5C File Offset: 0x0001415C
		public unsafe virtual PrefabFlavorsMetaData Metadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileFlavors.NativeMethodInfoPtr_get_Metadata_Public_Virtual_Final_New_get_PrefabFlavorsMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new PrefabFlavorsMetaData(intPtr);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00015F94 File Offset: 0x00014194
		public unsafe bool IncludeSrcDestFlavors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileFlavors.NativeMethodInfoPtr_get_IncludeSrcDestFlavors_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00015FD0 File Offset: 0x000141D0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PileFlavors()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PileFlavors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileFlavors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00004127 File Offset: 0x00002327
		public PileFlavors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0001600C File Offset: 0x0001420C
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00004130 File Offset: 0x00002330
		public PrefabFlavorsMetaData metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileFlavors.NativeFieldInfoPtr_metadata);
				return new PrefabFlavorsMetaData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileFlavors.NativeFieldInfoPtr_metadata), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0001603C File Offset: 0x0001423C
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0000415E File Offset: 0x0000235E
		public unsafe bool includeSrcDestFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileFlavors.NativeFieldInfoPtr_includeSrcDestFlavors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileFlavors.NativeFieldInfoPtr_includeSrcDestFlavors)) = value;
			}
		}

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_metadata;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_includeSrcDestFlavors;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_Virtual_Final_New_get_PrefabFlavorsMetaData_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeSrcDestFlavors_Public_get_Boolean_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
