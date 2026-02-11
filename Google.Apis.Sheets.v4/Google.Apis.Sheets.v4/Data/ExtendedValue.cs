using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200006E RID: 110
	public class ExtendedValue : Object
	{
		// Token: 0x060007F1 RID: 2033 RVA: 0x000291F8 File Offset: 0x000273F8
		// Note: this type is marked as 'beforefieldinit'.
		static ExtendedValue()
		{
			Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ExtendedValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr);
			ExtendedValue.NativeFieldInfoPtr__BoolValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, "<BoolValue>k__BackingField");
			ExtendedValue.NativeFieldInfoPtr__ErrorValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, "<ErrorValue>k__BackingField");
			ExtendedValue.NativeFieldInfoPtr__FormulaValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, "<FormulaValue>k__BackingField");
			ExtendedValue.NativeFieldInfoPtr__NumberValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, "<NumberValue>k__BackingField");
			ExtendedValue.NativeFieldInfoPtr__StringValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, "<StringValue>k__BackingField");
			ExtendedValue.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, "<ETag>k__BackingField");
			ExtendedValue.NativeMethodInfoPtr_get_BoolValue_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664482);
			ExtendedValue.NativeMethodInfoPtr_set_BoolValue_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664483);
			ExtendedValue.NativeMethodInfoPtr_get_ErrorValue_Public_Virtual_New_get_ErrorValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664484);
			ExtendedValue.NativeMethodInfoPtr_set_ErrorValue_Public_Virtual_New_set_Void_ErrorValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664485);
			ExtendedValue.NativeMethodInfoPtr_get_FormulaValue_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664486);
			ExtendedValue.NativeMethodInfoPtr_set_FormulaValue_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664487);
			ExtendedValue.NativeMethodInfoPtr_get_NumberValue_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664488);
			ExtendedValue.NativeMethodInfoPtr_set_NumberValue_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664489);
			ExtendedValue.NativeMethodInfoPtr_get_StringValue_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664490);
			ExtendedValue.NativeMethodInfoPtr_set_StringValue_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664491);
			ExtendedValue.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664492);
			ExtendedValue.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664493);
			ExtendedValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr, 100664494);
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000293A4 File Offset: 0x000275A4
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x000293E8 File Offset: 0x000275E8
		public unsafe virtual Nullable<bool> BoolValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_get_BoolValue_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_set_BoolValue_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0002943C File Offset: 0x0002763C
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00029488 File Offset: 0x00027688
		public unsafe virtual ErrorValue ErrorValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_get_ErrorValue_Public_Virtual_New_get_ErrorValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ErrorValue>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_set_ErrorValue_Public_Virtual_New_set_Void_ErrorValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x000294D8 File Offset: 0x000276D8
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0002951C File Offset: 0x0002771C
		public unsafe virtual string FormulaValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_get_FormulaValue_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_set_FormulaValue_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002956C File Offset: 0x0002776C
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x000295B0 File Offset: 0x000277B0
		public unsafe virtual Nullable<double> NumberValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_get_NumberValue_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 755145, RefRangeEnd = 755149, XrefRangeStart = 755145, XrefRangeEnd = 755149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_set_NumberValue_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00029604 File Offset: 0x00027804
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00029648 File Offset: 0x00027848
		public unsafe virtual string StringValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_get_StringValue_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_set_StringValue_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00029698 File Offset: 0x00027898
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x000296DC File Offset: 0x000278DC
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedValue.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0002972C File Offset: 0x0002792C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtendedValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00005BB1 File Offset: 0x00003DB1
		public ExtendedValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00029768 File Offset: 0x00027968
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00005BBA File Offset: 0x00003DBA
		public Nullable<bool> _BoolValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__BoolValue_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__BoolValue_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00029798 File Offset: 0x00027998
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public unsafe ErrorValue _ErrorValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__ErrorValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ErrorValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__ErrorValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000297C8 File Offset: 0x000279C8
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00005C07 File Offset: 0x00003E07
		public unsafe string _FormulaValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__FormulaValue_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__FormulaValue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x000297F0 File Offset: 0x000279F0
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00005C26 File Offset: 0x00003E26
		public Nullable<double> _NumberValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__NumberValue_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__NumberValue_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00029820 File Offset: 0x00027A20
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00005C54 File Offset: 0x00003E54
		public unsafe string _StringValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__StringValue_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__StringValue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00029848 File Offset: 0x00027A48
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00005C73 File Offset: 0x00003E73
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedValue.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr__BoolValue_k__BackingField;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr__ErrorValue_k__BackingField;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr__FormulaValue_k__BackingField;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr__NumberValue_k__BackingField;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr__StringValue_k__BackingField;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_get_BoolValue_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_set_BoolValue_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorValue_Public_Virtual_New_get_ErrorValue_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorValue_Public_Virtual_New_set_Void_ErrorValue_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_get_FormulaValue_Public_Virtual_New_get_String_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_set_FormulaValue_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberValue_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_set_NumberValue_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_get_StringValue_Public_Virtual_New_get_String_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_set_StringValue_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
