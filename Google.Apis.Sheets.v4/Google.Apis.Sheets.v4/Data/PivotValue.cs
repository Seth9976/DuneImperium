using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000095 RID: 149
	public class PivotValue : Object
	{
		// Token: 0x06000B4A RID: 2890 RVA: 0x00035F64 File Offset: 0x00034164
		// Note: this type is marked as 'beforefieldinit'.
		static PivotValue()
		{
			Il2CppClassPointerStore<PivotValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "PivotValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotValue>.NativeClassPtr);
			PivotValue.NativeFieldInfoPtr__CalculatedDisplayType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, "<CalculatedDisplayType>k__BackingField");
			PivotValue.NativeFieldInfoPtr__Formula_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, "<Formula>k__BackingField");
			PivotValue.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, "<Name>k__BackingField");
			PivotValue.NativeFieldInfoPtr__SourceColumnOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, "<SourceColumnOffset>k__BackingField");
			PivotValue.NativeFieldInfoPtr__SummarizeFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, "<SummarizeFunction>k__BackingField");
			PivotValue.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, "<ETag>k__BackingField");
			PivotValue.NativeMethodInfoPtr_get_CalculatedDisplayType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664891);
			PivotValue.NativeMethodInfoPtr_set_CalculatedDisplayType_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664892);
			PivotValue.NativeMethodInfoPtr_get_Formula_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664893);
			PivotValue.NativeMethodInfoPtr_set_Formula_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664894);
			PivotValue.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664895);
			PivotValue.NativeMethodInfoPtr_set_Name_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664896);
			PivotValue.NativeMethodInfoPtr_get_SourceColumnOffset_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664897);
			PivotValue.NativeMethodInfoPtr_set_SourceColumnOffset_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664898);
			PivotValue.NativeMethodInfoPtr_get_SummarizeFunction_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664899);
			PivotValue.NativeMethodInfoPtr_set_SummarizeFunction_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664900);
			PivotValue.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664901);
			PivotValue.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664902);
			PivotValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotValue>.NativeClassPtr, 100664903);
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00036110 File Offset: 0x00034310
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00036154 File Offset: 0x00034354
		public unsafe virtual string CalculatedDisplayType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_get_CalculatedDisplayType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_set_CalculatedDisplayType_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x000361A4 File Offset: 0x000343A4
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x000361E8 File Offset: 0x000343E8
		public unsafe virtual string Formula
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_get_Formula_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_set_Formula_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00036238 File Offset: 0x00034438
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0003627C File Offset: 0x0003447C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_set_Name_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000362CC File Offset: 0x000344CC
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00036310 File Offset: 0x00034510
		public unsafe virtual Nullable<int> SourceColumnOffset
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_get_SourceColumnOffset_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_set_SourceColumnOffset_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00036364 File Offset: 0x00034564
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000363A8 File Offset: 0x000345A8
		public unsafe virtual string SummarizeFunction
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_get_SummarizeFunction_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_set_SummarizeFunction_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000363F8 File Offset: 0x000345F8
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0003643C File Offset: 0x0003463C
		public unsafe virtual string ETag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotValue.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0003648C File Offset: 0x0003468C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000076EC File Offset: 0x000058EC
		public PivotValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000364C8 File Offset: 0x000346C8
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x000076F5 File Offset: 0x000058F5
		public unsafe string _CalculatedDisplayType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__CalculatedDisplayType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__CalculatedDisplayType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000364F0 File Offset: 0x000346F0
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00007714 File Offset: 0x00005914
		public unsafe string _Formula_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__Formula_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__Formula_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00036518 File Offset: 0x00034718
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00007733 File Offset: 0x00005933
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00036540 File Offset: 0x00034740
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00007752 File Offset: 0x00005952
		public Nullable<int> _SourceColumnOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__SourceColumnOffset_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__SourceColumnOffset_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00036570 File Offset: 0x00034770
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00007780 File Offset: 0x00005980
		public unsafe string _SummarizeFunction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__SummarizeFunction_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__SummarizeFunction_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00036598 File Offset: 0x00034798
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x0000779F File Offset: 0x0000599F
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotValue.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr__CalculatedDisplayType_k__BackingField;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr__Formula_k__BackingField;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr__SourceColumnOffset_k__BackingField;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr__SummarizeFunction_k__BackingField;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_get_CalculatedDisplayType_Public_Virtual_New_get_String_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_set_CalculatedDisplayType_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_get_Formula_Public_Virtual_New_get_String_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_set_Formula_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceColumnOffset_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceColumnOffset_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_get_SummarizeFunction_Public_Virtual_New_get_String_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_set_SummarizeFunction_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
