using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000AF RID: 175
	public class TextToColumnsRequest : Object
	{
		// Token: 0x06000EE0 RID: 3808 RVA: 0x0004418C File Offset: 0x0004238C
		// Note: this type is marked as 'beforefieldinit'.
		static TextToColumnsRequest()
		{
			Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "TextToColumnsRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr);
			TextToColumnsRequest.NativeFieldInfoPtr__Delimiter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, "<Delimiter>k__BackingField");
			TextToColumnsRequest.NativeFieldInfoPtr__DelimiterType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, "<DelimiterType>k__BackingField");
			TextToColumnsRequest.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, "<Source>k__BackingField");
			TextToColumnsRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, "<ETag>k__BackingField");
			TextToColumnsRequest.NativeMethodInfoPtr_get_Delimiter_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665337);
			TextToColumnsRequest.NativeMethodInfoPtr_set_Delimiter_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665338);
			TextToColumnsRequest.NativeMethodInfoPtr_get_DelimiterType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665339);
			TextToColumnsRequest.NativeMethodInfoPtr_set_DelimiterType_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665340);
			TextToColumnsRequest.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665341);
			TextToColumnsRequest.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665342);
			TextToColumnsRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665343);
			TextToColumnsRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665344);
			TextToColumnsRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr, 100665345);
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x000442C0 File Offset: 0x000424C0
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00044304 File Offset: 0x00042504
		public unsafe virtual string Delimiter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextToColumnsRequest.NativeMethodInfoPtr_get_Delimiter_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextToColumnsRequest.NativeMethodInfoPtr_set_Delimiter_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00044354 File Offset: 0x00042554
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00044398 File Offset: 0x00042598
		public unsafe virtual string DelimiterType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextToColumnsRequest.NativeMethodInfoPtr_get_DelimiterType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextToColumnsRequest.NativeMethodInfoPtr_set_DelimiterType_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x000443E8 File Offset: 0x000425E8
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00044434 File Offset: 0x00042634
		public unsafe virtual GridRange Source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextToColumnsRequest.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextToColumnsRequest.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00044484 File Offset: 0x00042684
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x000444C8 File Offset: 0x000426C8
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextToColumnsRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextToColumnsRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00044518 File Offset: 0x00042718
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextToColumnsRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextToColumnsRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextToColumnsRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0000928E File Offset: 0x0000748E
		public TextToColumnsRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00044554 File Offset: 0x00042754
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00009297 File Offset: 0x00007497
		public unsafe string _Delimiter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextToColumnsRequest.NativeFieldInfoPtr__Delimiter_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextToColumnsRequest.NativeFieldInfoPtr__Delimiter_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x0004457C File Offset: 0x0004277C
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x000092B6 File Offset: 0x000074B6
		public unsafe string _DelimiterType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextToColumnsRequest.NativeFieldInfoPtr__DelimiterType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextToColumnsRequest.NativeFieldInfoPtr__DelimiterType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x000445A4 File Offset: 0x000427A4
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x000092D5 File Offset: 0x000074D5
		public unsafe GridRange _Source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextToColumnsRequest.NativeFieldInfoPtr__Source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextToColumnsRequest.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000445D4 File Offset: 0x000427D4
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000092F4 File Offset: 0x000074F4
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextToColumnsRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextToColumnsRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeFieldInfoPtr__Delimiter_k__BackingField;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeFieldInfoPtr__DelimiterType_k__BackingField;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_get_Delimiter_Public_Virtual_New_get_String_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_set_Delimiter_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_get_DelimiterType_Public_Virtual_New_get_String_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_set_DelimiterType_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
