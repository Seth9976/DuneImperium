using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000CA RID: 202
	public sealed class UInt64Storage : DataStorage
	{
		// Token: 0x0600140A RID: 5130 RVA: 0x0006071C File Offset: 0x0005E91C
		// Note: this type is marked as 'beforefieldinit'.
		static UInt64Storage()
		{
			Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "UInt64Storage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr);
			UInt64Storage.NativeFieldInfoPtr_s_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, "s_defaultValue");
			UInt64Storage.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, "_values");
			UInt64Storage.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666609);
			UInt64Storage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666610);
			UInt64Storage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666611);
			UInt64Storage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666612);
			UInt64Storage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666613);
			UInt64Storage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666614);
			UInt64Storage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666615);
			UInt64Storage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666616);
			UInt64Storage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666617);
			UInt64Storage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666618);
			UInt64Storage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666619);
			UInt64Storage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666620);
			UInt64Storage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666621);
			UInt64Storage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr, 100666622);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0006088C File Offset: 0x0005EA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928883, XrefRangeEnd = 928898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UInt64Storage(DataColumn column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UInt64Storage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x000608D8 File Offset: 0x0005EAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928898, XrefRangeEnd = 928970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00060938 File Offset: 0x0005EB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928970, XrefRangeEnd = 928976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00060990 File Offset: 0x0005EB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928976, XrefRangeEnd = 928980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x000609EC File Offset: 0x0005EBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928980, XrefRangeEnd = 928982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00060A3C File Offset: 0x0005EC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928982, XrefRangeEnd = 928983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00060A88 File Offset: 0x0005EC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928983, XrefRangeEnd = 928988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Get(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00060AD4 File Offset: 0x0005ECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928988, XrefRangeEnd = 929004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00060B24 File Offset: 0x0005ED24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929004, XrefRangeEnd = 929014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00060B64 File Offset: 0x0005ED64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929014, XrefRangeEnd = 929021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertXmlToObject(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00060BB4 File Offset: 0x0005EDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929021, XrefRangeEnd = 929030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertObjectToXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00060BFC File Offset: 0x0005EDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929030, XrefRangeEnd = 929033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEmptyStorage(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00060C48 File Offset: 0x0005EE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929033, XrefRangeEnd = 929044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00060CB8 File Offset: 0x0005EEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929044, XrefRangeEnd = 929054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64Storage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000078CA File Offset: 0x00005ACA
		public UInt64Storage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x00060D0C File Offset: 0x0005EF0C
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x000078D3 File Offset: 0x00005AD3
		public unsafe static ulong s_defaultValue
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(UInt64Storage.NativeFieldInfoPtr_s_defaultValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UInt64Storage.NativeFieldInfoPtr_s_defaultValue, (void*)(&value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x00060D28 File Offset: 0x0005EF28
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x000078E1 File Offset: 0x00005AE1
		public unsafe Il2CppStructArray<ulong> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UInt64Storage.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UInt64Storage.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultValue;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0;
	}
}
