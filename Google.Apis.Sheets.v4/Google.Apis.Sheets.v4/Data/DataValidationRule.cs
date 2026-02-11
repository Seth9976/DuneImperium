using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200004E RID: 78
	public class DataValidationRule : Object
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x00021D58 File Offset: 0x0001FF58
		// Note: this type is marked as 'beforefieldinit'.
		static DataValidationRule()
		{
			Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DataValidationRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr);
			DataValidationRule.NativeFieldInfoPtr__Condition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, "<Condition>k__BackingField");
			DataValidationRule.NativeFieldInfoPtr__InputMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, "<InputMessage>k__BackingField");
			DataValidationRule.NativeFieldInfoPtr__ShowCustomUi_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, "<ShowCustomUi>k__BackingField");
			DataValidationRule.NativeFieldInfoPtr__Strict_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, "<Strict>k__BackingField");
			DataValidationRule.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, "<ETag>k__BackingField");
			DataValidationRule.NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664248);
			DataValidationRule.NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664249);
			DataValidationRule.NativeMethodInfoPtr_get_InputMessage_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664250);
			DataValidationRule.NativeMethodInfoPtr_set_InputMessage_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664251);
			DataValidationRule.NativeMethodInfoPtr_get_ShowCustomUi_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664252);
			DataValidationRule.NativeMethodInfoPtr_set_ShowCustomUi_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664253);
			DataValidationRule.NativeMethodInfoPtr_get_Strict_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664254);
			DataValidationRule.NativeMethodInfoPtr_set_Strict_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664255);
			DataValidationRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664256);
			DataValidationRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664257);
			DataValidationRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr, 100664258);
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x00021EC8 File Offset: 0x000200C8
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x00021F14 File Offset: 0x00020114
		public unsafe virtual BooleanCondition Condition
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BooleanCondition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00021F64 File Offset: 0x00020164
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00021FA8 File Offset: 0x000201A8
		public unsafe virtual string InputMessage
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_get_InputMessage_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_set_InputMessage_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00021FF8 File Offset: 0x000201F8
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x0002203C File Offset: 0x0002023C
		public unsafe virtual Nullable<bool> ShowCustomUi
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_get_ShowCustomUi_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_set_ShowCustomUi_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00022090 File Offset: 0x00020290
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x000220D4 File Offset: 0x000202D4
		public unsafe virtual Nullable<bool> Strict
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_get_Strict_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_set_Strict_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00022128 File Offset: 0x00020328
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x0002216C File Offset: 0x0002036C
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataValidationRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000221BC File Offset: 0x000203BC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataValidationRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataValidationRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataValidationRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00004C94 File Offset: 0x00002E94
		public DataValidationRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x000221F8 File Offset: 0x000203F8
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00004C9D File Offset: 0x00002E9D
		public unsafe BooleanCondition _Condition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__Condition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BooleanCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__Condition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00022228 File Offset: 0x00020428
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00004CBC File Offset: 0x00002EBC
		public unsafe string _InputMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__InputMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__InputMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00022250 File Offset: 0x00020450
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00004CDB File Offset: 0x00002EDB
		public Nullable<bool> _ShowCustomUi_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__ShowCustomUi_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__ShowCustomUi_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00022280 File Offset: 0x00020480
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00004D09 File Offset: 0x00002F09
		public Nullable<bool> _Strict_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__Strict_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__Strict_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000222B0 File Offset: 0x000204B0
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00004D37 File Offset: 0x00002F37
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataValidationRule.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr__Condition_k__BackingField;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr__InputMessage_k__BackingField;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr__ShowCustomUi_k__BackingField;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr__Strict_k__BackingField;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_get_InputMessage_Public_Virtual_New_get_String_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_set_InputMessage_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowCustomUi_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_set_ShowCustomUi_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_get_Strict_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_set_Strict_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
