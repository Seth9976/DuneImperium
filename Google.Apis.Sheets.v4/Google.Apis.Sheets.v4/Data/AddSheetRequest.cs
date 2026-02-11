using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000012 RID: 18
	public class AddSheetRequest : Object
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x0000E694 File Offset: 0x0000C894
		// Note: this type is marked as 'beforefieldinit'.
		static AddSheetRequest()
		{
			Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddSheetRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr);
			AddSheetRequest.NativeFieldInfoPtr__Properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr, "<Properties>k__BackingField");
			AddSheetRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr, "<ETag>k__BackingField");
			AddSheetRequest.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr, 100663628);
			AddSheetRequest.NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr, 100663629);
			AddSheetRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr, 100663630);
			AddSheetRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr, 100663631);
			AddSheetRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr, 100663632);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000E750 File Offset: 0x0000C950
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000E79C File Offset: 0x0000C99C
		public unsafe virtual SheetProperties Properties
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddSheetRequest.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SheetProperties>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddSheetRequest.NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000E830 File Offset: 0x0000CA30
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddSheetRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddSheetRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000E880 File Offset: 0x0000CA80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddSheetRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddSheetRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddSheetRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002683 File Offset: 0x00000883
		public AddSheetRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000E8BC File Offset: 0x0000CABC
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000268C File Offset: 0x0000088C
		public unsafe SheetProperties _Properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddSheetRequest.NativeFieldInfoPtr__Properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetProperties>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddSheetRequest.NativeFieldInfoPtr__Properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000026AB File Offset: 0x000008AB
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddSheetRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddSheetRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr__Properties_k__BackingField;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
