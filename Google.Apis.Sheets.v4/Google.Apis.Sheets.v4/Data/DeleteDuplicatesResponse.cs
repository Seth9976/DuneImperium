using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000059 RID: 89
	public class DeleteDuplicatesResponse : Object
	{
		// Token: 0x0600068A RID: 1674 RVA: 0x00023DCC File Offset: 0x00021FCC
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteDuplicatesResponse()
		{
			Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteDuplicatesResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr);
			DeleteDuplicatesResponse.NativeFieldInfoPtr__DuplicatesRemovedCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr, "<DuplicatesRemovedCount>k__BackingField");
			DeleteDuplicatesResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteDuplicatesResponse.NativeMethodInfoPtr_get_DuplicatesRemovedCount_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr, 100664313);
			DeleteDuplicatesResponse.NativeMethodInfoPtr_set_DuplicatesRemovedCount_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr, 100664314);
			DeleteDuplicatesResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr, 100664315);
			DeleteDuplicatesResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr, 100664316);
			DeleteDuplicatesResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr, 100664317);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00023E88 File Offset: 0x00022088
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00023ECC File Offset: 0x000220CC
		public unsafe virtual Nullable<int> DuplicatesRemovedCount
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesResponse.NativeMethodInfoPtr_get_DuplicatesRemovedCount_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesResponse.NativeMethodInfoPtr_set_DuplicatesRemovedCount_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00023F20 File Offset: 0x00022120
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00023F64 File Offset: 0x00022164
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteDuplicatesResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00023FB4 File Offset: 0x000221B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteDuplicatesResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteDuplicatesResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteDuplicatesResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00005087 File Offset: 0x00003287
		public DeleteDuplicatesResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00023FF0 File Offset: 0x000221F0
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00005090 File Offset: 0x00003290
		public Nullable<int> _DuplicatesRemovedCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesResponse.NativeFieldInfoPtr__DuplicatesRemovedCount_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesResponse.NativeFieldInfoPtr__DuplicatesRemovedCount_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00024020 File Offset: 0x00022220
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x000050BE File Offset: 0x000032BE
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteDuplicatesResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr__DuplicatesRemovedCount_k__BackingField;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_DuplicatesRemovedCount_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_set_DuplicatesRemovedCount_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
