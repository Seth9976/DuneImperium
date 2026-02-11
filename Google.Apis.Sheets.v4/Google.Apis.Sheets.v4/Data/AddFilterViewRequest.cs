using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200000C RID: 12
	public class AddFilterViewRequest : Object
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x0000D794 File Offset: 0x0000B994
		// Note: this type is marked as 'beforefieldinit'.
		static AddFilterViewRequest()
		{
			Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddFilterViewRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr);
			AddFilterViewRequest.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr, "<Filter>k__BackingField");
			AddFilterViewRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr, "<ETag>k__BackingField");
			AddFilterViewRequest.NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_FilterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr, 100663598);
			AddFilterViewRequest.NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_FilterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr, 100663599);
			AddFilterViewRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr, 100663600);
			AddFilterViewRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr, 100663601);
			AddFilterViewRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr, 100663602);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000D850 File Offset: 0x0000BA50
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000D89C File Offset: 0x0000BA9C
		public unsafe virtual FilterView Filter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFilterViewRequest.NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_FilterView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFilterViewRequest.NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_FilterView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000D8EC File Offset: 0x0000BAEC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000D930 File Offset: 0x0000BB30
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFilterViewRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFilterViewRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000D980 File Offset: 0x0000BB80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddFilterViewRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFilterViewRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFilterViewRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000024D9 File Offset: 0x000006D9
		public AddFilterViewRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000024E2 File Offset: 0x000006E2
		public unsafe FilterView _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFilterViewRequest.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFilterViewRequest.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002501 File Offset: 0x00000701
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFilterViewRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFilterViewRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_FilterView_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_FilterView_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
