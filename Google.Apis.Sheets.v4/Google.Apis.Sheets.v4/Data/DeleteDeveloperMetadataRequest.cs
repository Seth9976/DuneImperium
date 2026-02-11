using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000053 RID: 83
	public class DeleteDeveloperMetadataRequest : Object
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x00022DC4 File Offset: 0x00020FC4
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteDeveloperMetadataRequest()
		{
			Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteDeveloperMetadataRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr);
			DeleteDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr, "<DataFilter>k__BackingField");
			DeleteDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteDeveloperMetadataRequest.NativeMethodInfoPtr_get_DataFilter_Public_Virtual_New_get_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr, 100664281);
			DeleteDeveloperMetadataRequest.NativeMethodInfoPtr_set_DataFilter_Public_Virtual_New_set_Void_DataFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr, 100664282);
			DeleteDeveloperMetadataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr, 100664283);
			DeleteDeveloperMetadataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr, 100664284);
			DeleteDeveloperMetadataRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr, 100664285);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00022E80 File Offset: 0x00021080
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00022ECC File Offset: 0x000210CC
		public unsafe virtual DataFilter DataFilter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDeveloperMetadataRequest.NativeMethodInfoPtr_get_DataFilter_Public_Virtual_New_get_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataFilter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDeveloperMetadataRequest.NativeMethodInfoPtr_set_DataFilter_Public_Virtual_New_set_Void_DataFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00022F1C File Offset: 0x0002111C
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00022F60 File Offset: 0x00021160
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDeveloperMetadataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDeveloperMetadataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00022FB0 File Offset: 0x000211B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteDeveloperMetadataRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteDeveloperMetadataRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDeveloperMetadataRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00004EBE File Offset: 0x000030BE
		public DeleteDeveloperMetadataRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00022FEC File Offset: 0x000211EC
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00004EC7 File Offset: 0x000030C7
		public unsafe DataFilter _DataFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDeveloperMetadataRequest.NativeFieldInfoPtr__DataFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0002301C File Offset: 0x0002121C
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00004EE6 File Offset: 0x000030E6
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr__DataFilter_k__BackingField;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_get_DataFilter_Public_Virtual_New_get_DataFilter_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_set_DataFilter_Public_Virtual_New_set_Void_DataFilter_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
