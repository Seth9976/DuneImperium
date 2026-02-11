using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200000D RID: 13
	public class AddFilterViewResponse : Object
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x0000DA14 File Offset: 0x0000BC14
		// Note: this type is marked as 'beforefieldinit'.
		static AddFilterViewResponse()
		{
			Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddFilterViewResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr);
			AddFilterViewResponse.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr, "<Filter>k__BackingField");
			AddFilterViewResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr, "<ETag>k__BackingField");
			AddFilterViewResponse.NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_FilterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr, 100663603);
			AddFilterViewResponse.NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_FilterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr, 100663604);
			AddFilterViewResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr, 100663605);
			AddFilterViewResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr, 100663606);
			AddFilterViewResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr, 100663607);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000DB1C File Offset: 0x0000BD1C
		public unsafe virtual FilterView Filter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFilterViewResponse.NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_FilterView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FilterView>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFilterViewResponse.NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_FilterView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000DB6C File Offset: 0x0000BD6C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFilterViewResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFilterViewResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000DC00 File Offset: 0x0000BE00
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddFilterViewResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFilterViewResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFilterViewResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002520 File Offset: 0x00000720
		public AddFilterViewResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000DC3C File Offset: 0x0000BE3C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002529 File Offset: 0x00000729
		public unsafe FilterView _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFilterViewResponse.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFilterViewResponse.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000DC6C File Offset: 0x0000BE6C
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002548 File Offset: 0x00000748
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFilterViewResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFilterViewResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_FilterView_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_FilterView_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
