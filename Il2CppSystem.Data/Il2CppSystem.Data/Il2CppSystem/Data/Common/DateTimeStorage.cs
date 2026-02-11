using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000AD RID: 173
	public sealed class DateTimeStorage : DataStorage
	{
		// Token: 0x060011D7 RID: 4567 RVA: 0x00054C5C File Offset: 0x00052E5C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeStorage()
		{
			Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "DateTimeStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr);
			DateTimeStorage.NativeFieldInfoPtr_s_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, "s_defaultValue");
			DateTimeStorage.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, "_values");
			DateTimeStorage.NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666171);
			DateTimeStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666172);
			DateTimeStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666173);
			DateTimeStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666174);
			DateTimeStorage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666175);
			DateTimeStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666176);
			DateTimeStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666177);
			DateTimeStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666178);
			DateTimeStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666179);
			DateTimeStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666180);
			DateTimeStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666181);
			DateTimeStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666182);
			DateTimeStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666183);
			DateTimeStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr, 100666184);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00054DCC File Offset: 0x00052FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922833, XrefRangeEnd = 922850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeStorage(DataColumn column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00054E18 File Offset: 0x00053018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922850, XrefRangeEnd = 922884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Aggregate(Il2CppStructArray<int> records, AggregateType kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(records);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00054E78 File Offset: 0x00053078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922884, XrefRangeEnd = 922902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(int recordNo1, int recordNo2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordNo2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00054ED0 File Offset: 0x000530D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922902, XrefRangeEnd = 922911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CompareValueTo(int recordNo, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00054F2C File Offset: 0x0005312C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922911, XrefRangeEnd = 922913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00054F7C File Offset: 0x0005317C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922913, XrefRangeEnd = 922915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Copy(int recordNo1, int recordNo2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordNo2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00054FC8 File Offset: 0x000531C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922915, XrefRangeEnd = 922924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Get(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00055014 File Offset: 0x00053214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922924, XrefRangeEnd = 922965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Set(int record, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00055064 File Offset: 0x00053264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922965, XrefRangeEnd = 922975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x000550A4 File Offset: 0x000532A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922975, XrefRangeEnd = 922984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertXmlToObject(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x000550F4 File Offset: 0x000532F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922984, XrefRangeEnd = 922995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertObjectToXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0005513C File Offset: 0x0005333C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922995, XrefRangeEnd = 922998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEmptyStorage(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00055188 File Offset: 0x00053388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922998, XrefRangeEnd = 923012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyValue(int record, Object store, BitArray nullbits, int storeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullbits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000551F8 File Offset: 0x000533F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923012, XrefRangeEnd = 923032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetStorage(Object store, BitArray nullbits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullbits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000073D3 File Offset: 0x000055D3
		public DateTimeStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0005524C File Offset: 0x0005344C
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x000073DC File Offset: 0x000055DC
		public unsafe static DateTime s_defaultValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(DateTimeStorage.NativeFieldInfoPtr_s_defaultValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeStorage.NativeFieldInfoPtr_s_defaultValue, (void*)(&value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x00055268 File Offset: 0x00053468
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x000073EA File Offset: 0x000055EA
		public unsafe Il2CppStructArray<DateTime> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeStorage.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DateTime>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeStorage.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultValue;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0;
	}
}
