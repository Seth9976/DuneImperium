using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200005A RID: 90
	public class DeleteEmbeddedObjectRequest : Object
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x00024048 File Offset: 0x00022248
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteEmbeddedObjectRequest()
		{
			Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteEmbeddedObjectRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr);
			DeleteEmbeddedObjectRequest.NativeFieldInfoPtr__ObjectId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr, "<ObjectId>k__BackingField");
			DeleteEmbeddedObjectRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteEmbeddedObjectRequest.NativeMethodInfoPtr_get_ObjectId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr, 100664318);
			DeleteEmbeddedObjectRequest.NativeMethodInfoPtr_set_ObjectId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr, 100664319);
			DeleteEmbeddedObjectRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr, 100664320);
			DeleteEmbeddedObjectRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr, 100664321);
			DeleteEmbeddedObjectRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr, 100664322);
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00024104 File Offset: 0x00022304
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00024148 File Offset: 0x00022348
		public unsafe virtual Nullable<int> ObjectId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteEmbeddedObjectRequest.NativeMethodInfoPtr_get_ObjectId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteEmbeddedObjectRequest.NativeMethodInfoPtr_set_ObjectId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0002419C File Offset: 0x0002239C
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x000241E0 File Offset: 0x000223E0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteEmbeddedObjectRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteEmbeddedObjectRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00024230 File Offset: 0x00022430
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteEmbeddedObjectRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteEmbeddedObjectRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteEmbeddedObjectRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000050DD File Offset: 0x000032DD
		public DeleteEmbeddedObjectRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0002426C File Offset: 0x0002246C
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x000050E6 File Offset: 0x000032E6
		public Nullable<int> _ObjectId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteEmbeddedObjectRequest.NativeFieldInfoPtr__ObjectId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteEmbeddedObjectRequest.NativeFieldInfoPtr__ObjectId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0002429C File Offset: 0x0002249C
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00005114 File Offset: 0x00003314
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteEmbeddedObjectRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteEmbeddedObjectRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr__ObjectId_k__BackingField;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
