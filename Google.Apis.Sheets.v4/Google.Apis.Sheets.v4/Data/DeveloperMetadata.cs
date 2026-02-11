using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000060 RID: 96
	public class DeveloperMetadata : Object
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x00025020 File Offset: 0x00023220
		// Note: this type is marked as 'beforefieldinit'.
		static DeveloperMetadata()
		{
			Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeveloperMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr);
			DeveloperMetadata.NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, "<Location>k__BackingField");
			DeveloperMetadata.NativeFieldInfoPtr__MetadataId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, "<MetadataId>k__BackingField");
			DeveloperMetadata.NativeFieldInfoPtr__MetadataKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, "<MetadataKey>k__BackingField");
			DeveloperMetadata.NativeFieldInfoPtr__MetadataValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, "<MetadataValue>k__BackingField");
			DeveloperMetadata.NativeFieldInfoPtr__Visibility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, "<Visibility>k__BackingField");
			DeveloperMetadata.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, "<ETag>k__BackingField");
			DeveloperMetadata.NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_DeveloperMetadataLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664350);
			DeveloperMetadata.NativeMethodInfoPtr_set_Location_Public_Virtual_New_set_Void_DeveloperMetadataLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664351);
			DeveloperMetadata.NativeMethodInfoPtr_get_MetadataId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664352);
			DeveloperMetadata.NativeMethodInfoPtr_set_MetadataId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664353);
			DeveloperMetadata.NativeMethodInfoPtr_get_MetadataKey_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664354);
			DeveloperMetadata.NativeMethodInfoPtr_set_MetadataKey_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664355);
			DeveloperMetadata.NativeMethodInfoPtr_get_MetadataValue_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664356);
			DeveloperMetadata.NativeMethodInfoPtr_set_MetadataValue_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664357);
			DeveloperMetadata.NativeMethodInfoPtr_get_Visibility_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664358);
			DeveloperMetadata.NativeMethodInfoPtr_set_Visibility_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664359);
			DeveloperMetadata.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664360);
			DeveloperMetadata.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664361);
			DeveloperMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr, 100664362);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000251CC File Offset: 0x000233CC
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00025218 File Offset: 0x00023418
		public unsafe virtual DeveloperMetadataLocation Location
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_DeveloperMetadataLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeveloperMetadataLocation>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_set_Location_Public_Virtual_New_set_Void_DeveloperMetadataLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00025268 File Offset: 0x00023468
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x000252AC File Offset: 0x000234AC
		public unsafe virtual Nullable<int> MetadataId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_get_MetadataId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_set_MetadataId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00025300 File Offset: 0x00023500
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00025344 File Offset: 0x00023544
		public unsafe virtual string MetadataKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_get_MetadataKey_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_set_MetadataKey_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00025394 File Offset: 0x00023594
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x000253D8 File Offset: 0x000235D8
		public unsafe virtual string MetadataValue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_get_MetadataValue_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_set_MetadataValue_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00025428 File Offset: 0x00023628
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0002546C File Offset: 0x0002366C
		public unsafe virtual string Visibility
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_get_Visibility_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_set_Visibility_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000254BC File Offset: 0x000236BC
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00025500 File Offset: 0x00023700
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperMetadata.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00025550 File Offset: 0x00023750
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeveloperMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeveloperMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeveloperMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000052E2 File Offset: 0x000034E2
		public DeveloperMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0002558C File Offset: 0x0002378C
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000052EB File Offset: 0x000034EB
		public unsafe DeveloperMetadataLocation _Location_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__Location_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeveloperMetadataLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__Location_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000255BC File Offset: 0x000237BC
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0000530A File Offset: 0x0000350A
		public Nullable<int> _MetadataId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__MetadataId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__MetadataId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000255EC File Offset: 0x000237EC
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00005338 File Offset: 0x00003538
		public unsafe string _MetadataKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__MetadataKey_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__MetadataKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00025614 File Offset: 0x00023814
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00005357 File Offset: 0x00003557
		public unsafe string _MetadataValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__MetadataValue_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__MetadataValue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0002563C File Offset: 0x0002383C
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00005376 File Offset: 0x00003576
		public unsafe string _Visibility_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__Visibility_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__Visibility_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00025664 File Offset: 0x00023864
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00005395 File Offset: 0x00003595
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperMetadata.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr__Location_k__BackingField;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr__MetadataId_k__BackingField;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr__MetadataKey_k__BackingField;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr__MetadataValue_k__BackingField;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr__Visibility_k__BackingField;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_DeveloperMetadataLocation_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_set_Location_Public_Virtual_New_set_Void_DeveloperMetadataLocation_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_set_MetadataId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataKey_Public_Virtual_New_get_String_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_set_MetadataKey_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataValue_Public_Virtual_New_get_String_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_set_MetadataValue_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_get_Visibility_Public_Virtual_New_get_String_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_set_Visibility_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
