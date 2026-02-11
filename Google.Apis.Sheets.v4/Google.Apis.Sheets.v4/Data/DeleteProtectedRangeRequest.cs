using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200005D RID: 93
	public class DeleteProtectedRangeRequest : Object
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x000247B0 File Offset: 0x000229B0
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteProtectedRangeRequest()
		{
			Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteProtectedRangeRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr);
			DeleteProtectedRangeRequest.NativeFieldInfoPtr__ProtectedRangeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr, "<ProtectedRangeId>k__BackingField");
			DeleteProtectedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteProtectedRangeRequest.NativeMethodInfoPtr_get_ProtectedRangeId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr, 100664333);
			DeleteProtectedRangeRequest.NativeMethodInfoPtr_set_ProtectedRangeId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr, 100664334);
			DeleteProtectedRangeRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr, 100664335);
			DeleteProtectedRangeRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr, 100664336);
			DeleteProtectedRangeRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr, 100664337);
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0002486C File Offset: 0x00022A6C
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000248B0 File Offset: 0x00022AB0
		public unsafe virtual Nullable<int> ProtectedRangeId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteProtectedRangeRequest.NativeMethodInfoPtr_get_ProtectedRangeId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteProtectedRangeRequest.NativeMethodInfoPtr_set_ProtectedRangeId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00024904 File Offset: 0x00022B04
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00024948 File Offset: 0x00022B48
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteProtectedRangeRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteProtectedRangeRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00024998 File Offset: 0x00022B98
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteProtectedRangeRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteProtectedRangeRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteProtectedRangeRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000051D0 File Offset: 0x000033D0
		public DeleteProtectedRangeRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x000249D4 File Offset: 0x00022BD4
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x000051D9 File Offset: 0x000033D9
		public Nullable<int> _ProtectedRangeId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteProtectedRangeRequest.NativeFieldInfoPtr__ProtectedRangeId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteProtectedRangeRequest.NativeFieldInfoPtr__ProtectedRangeId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00024A04 File Offset: 0x00022C04
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00005207 File Offset: 0x00003407
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteProtectedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteProtectedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr__ProtectedRangeId_k__BackingField;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtectedRangeId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtectedRangeId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
