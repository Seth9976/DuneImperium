using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000066 RID: 102
	public class DuplicateFilterViewRequest : Object
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x000273F8 File Offset: 0x000255F8
		// Note: this type is marked as 'beforefieldinit'.
		static DuplicateFilterViewRequest()
		{
			Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DuplicateFilterViewRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr);
			DuplicateFilterViewRequest.NativeFieldInfoPtr__FilterId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr, "<FilterId>k__BackingField");
			DuplicateFilterViewRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr, "<ETag>k__BackingField");
			DuplicateFilterViewRequest.NativeMethodInfoPtr_get_FilterId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr, 100664422);
			DuplicateFilterViewRequest.NativeMethodInfoPtr_set_FilterId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr, 100664423);
			DuplicateFilterViewRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr, 100664424);
			DuplicateFilterViewRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr, 100664425);
			DuplicateFilterViewRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr, 100664426);
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000274B4 File Offset: 0x000256B4
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x000274F8 File Offset: 0x000256F8
		public unsafe virtual Nullable<int> FilterId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateFilterViewRequest.NativeMethodInfoPtr_get_FilterId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateFilterViewRequest.NativeMethodInfoPtr_set_FilterId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0002754C File Offset: 0x0002574C
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00027590 File Offset: 0x00025790
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateFilterViewRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuplicateFilterViewRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000275E0 File Offset: 0x000257E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuplicateFilterViewRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuplicateFilterViewRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateFilterViewRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000057CB File Offset: 0x000039CB
		public DuplicateFilterViewRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0002761C File Offset: 0x0002581C
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x000057D4 File Offset: 0x000039D4
		public Nullable<int> _FilterId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateFilterViewRequest.NativeFieldInfoPtr__FilterId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateFilterViewRequest.NativeFieldInfoPtr__FilterId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0002764C File Offset: 0x0002584C
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00005802 File Offset: 0x00003A02
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateFilterViewRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateFilterViewRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeFieldInfoPtr__FilterId_k__BackingField;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_set_FilterId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
