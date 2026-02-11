using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x0200002C RID: 44
	[Serializable]
	public class TableEntryData : Object
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00013A68 File Offset: 0x00011C68
		// Note: this type is marked as 'beforefieldinit'.
		static TableEntryData()
		{
			Il2CppClassPointerStore<TableEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "TableEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr);
			TableEntryData.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, "m_Id");
			TableEntryData.NativeFieldInfoPtr_m_Localized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, "m_Localized");
			TableEntryData.NativeFieldInfoPtr_m_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, "m_Metadata");
			TableEntryData.NativeMethodInfoPtr_get_Id_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663787);
			TableEntryData.NativeMethodInfoPtr_set_Id_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663788);
			TableEntryData.NativeMethodInfoPtr_get_Localized_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663789);
			TableEntryData.NativeMethodInfoPtr_set_Localized_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663790);
			TableEntryData.NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663791);
			TableEntryData.NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663792);
			TableEntryData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663793);
			TableEntryData.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663794);
			TableEntryData.NativeMethodInfoPtr__ctor_Public_Void_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr, 100663795);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00013B88 File Offset: 0x00011D88
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00013BC4 File Offset: 0x00011DC4
		public unsafe long Id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr_get_Id_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr_set_Id_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00013C04 File Offset: 0x00011E04
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00013C3C File Offset: 0x00011E3C
		public unsafe string Localized
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr_get_Localized_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr_set_Localized_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00013C80 File Offset: 0x00011E80
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00013CC0 File Offset: 0x00011EC0
		public unsafe MetadataCollection Metadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00013D04 File Offset: 0x00011F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067906, XrefRangeEnd = 1067912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TableEntryData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00013D40 File Offset: 0x00011F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067918, RefRangeEnd = 1067919, XrefRangeStart = 1067912, XrefRangeEnd = 1067918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TableEntryData(long id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00013D88 File Offset: 0x00011F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067919, XrefRangeEnd = 1067926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TableEntryData(long id, string localized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableEntryData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryData.NativeMethodInfoPtr__ctor_Public_Void_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002F16 File Offset: 0x00001116
		public TableEntryData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00013DE4 File Offset: 0x00011FE4
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00002F1F File Offset: 0x0000111F
		public unsafe long m_Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryData.NativeFieldInfoPtr_m_Id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryData.NativeFieldInfoPtr_m_Id)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00013E0C File Offset: 0x0001200C
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00002F3A File Offset: 0x0000113A
		public unsafe string m_Localized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryData.NativeFieldInfoPtr_m_Localized);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryData.NativeFieldInfoPtr_m_Localized), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00013E34 File Offset: 0x00012034
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00002F59 File Offset: 0x00001159
		public unsafe MetadataCollection m_Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryData.NativeFieldInfoPtr_m_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryData.NativeFieldInfoPtr_m_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_m_Localized;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_m_Metadata;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int64_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Int64_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_Localized_Public_get_String_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_set_Localized_Public_set_Void_String_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_String_0;
	}
}
