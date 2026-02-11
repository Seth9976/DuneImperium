using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000049 RID: 73
	public class CreateDeveloperMetadataRequest : Object
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		// Note: this type is marked as 'beforefieldinit'.
		static CreateDeveloperMetadataRequest()
		{
			Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "CreateDeveloperMetadataRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr);
			CreateDeveloperMetadataRequest.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr, "<DeveloperMetadata>k__BackingField");
			CreateDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr, "<ETag>k__BackingField");
			CreateDeveloperMetadataRequest.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr, 100664211);
			CreateDeveloperMetadataRequest.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr, 100664212);
			CreateDeveloperMetadataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr, 100664213);
			CreateDeveloperMetadataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr, 100664214);
			CreateDeveloperMetadataRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr, 100664215);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00020B94 File Offset: 0x0001ED94
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		public unsafe virtual DeveloperMetadata DeveloperMetadata
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateDeveloperMetadataRequest.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeveloperMetadata>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateDeveloperMetadataRequest.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00020C30 File Offset: 0x0001EE30
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00020C74 File Offset: 0x0001EE74
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateDeveloperMetadataRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateDeveloperMetadataRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00020CC4 File Offset: 0x0001EEC4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateDeveloperMetadataRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateDeveloperMetadataRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateDeveloperMetadataRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00004A77 File Offset: 0x00002C77
		public CreateDeveloperMetadataRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00020D00 File Offset: 0x0001EF00
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00004A80 File Offset: 0x00002C80
		public unsafe DeveloperMetadata _DeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateDeveloperMetadataRequest.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeveloperMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateDeveloperMetadataRequest.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00020D30 File Offset: 0x0001EF30
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00004A9F File Offset: 0x00002C9F
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateDeveloperMetadataRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr__DeveloperMetadata_k__BackingField;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_DeveloperMetadata_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_DeveloperMetadata_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
