using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200001A RID: 26
	public class AutoResizeDimensionsRequest : Object
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00010294 File Offset: 0x0000E494
		// Note: this type is marked as 'beforefieldinit'.
		static AutoResizeDimensionsRequest()
		{
			Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AutoResizeDimensionsRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr);
			AutoResizeDimensionsRequest.NativeFieldInfoPtr__Dimensions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr, "<Dimensions>k__BackingField");
			AutoResizeDimensionsRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr, "<ETag>k__BackingField");
			AutoResizeDimensionsRequest.NativeMethodInfoPtr_get_Dimensions_Public_Virtual_New_get_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr, 100663684);
			AutoResizeDimensionsRequest.NativeMethodInfoPtr_set_Dimensions_Public_Virtual_New_set_Void_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr, 100663685);
			AutoResizeDimensionsRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr, 100663686);
			AutoResizeDimensionsRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr, 100663687);
			AutoResizeDimensionsRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr, 100663688);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00010350 File Offset: 0x0000E550
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0001039C File Offset: 0x0000E59C
		public unsafe virtual DimensionRange Dimensions
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoResizeDimensionsRequest.NativeMethodInfoPtr_get_Dimensions_Public_Virtual_New_get_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DimensionRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoResizeDimensionsRequest.NativeMethodInfoPtr_set_Dimensions_Public_Virtual_New_set_Void_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000103EC File Offset: 0x0000E5EC
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00010430 File Offset: 0x0000E630
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoResizeDimensionsRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoResizeDimensionsRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00010480 File Offset: 0x0000E680
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoResizeDimensionsRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoResizeDimensionsRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoResizeDimensionsRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000029EF File Offset: 0x00000BEF
		public AutoResizeDimensionsRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000104BC File Offset: 0x0000E6BC
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe DimensionRange _Dimensions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoResizeDimensionsRequest.NativeFieldInfoPtr__Dimensions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DimensionRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoResizeDimensionsRequest.NativeFieldInfoPtr__Dimensions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000104EC File Offset: 0x0000E6EC
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002A17 File Offset: 0x00000C17
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoResizeDimensionsRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoResizeDimensionsRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr__Dimensions_k__BackingField;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_Dimensions_Public_Virtual_New_get_DimensionRange_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_set_Dimensions_Public_Virtual_New_set_Void_DimensionRange_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
