using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Data.SqlTypes;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000C1 RID: 193
	public sealed class SqlSingleStorage : DataStorage
	{
		// Token: 0x06001350 RID: 4944 RVA: 0x0005CA74 File Offset: 0x0005AC74
		// Note: this type is marked as 'beforefieldinit'.
		static SqlSingleStorage()
		{
			Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "SqlSingleStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr);
			SqlSingleStorage.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, "_values");
			SqlSingleStorage.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666467);
			SqlSingleStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666468);
			SqlSingleStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666469);
			SqlSingleStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666470);
			SqlSingleStorage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666471);
			SqlSingleStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666472);
			SqlSingleStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666473);
			SqlSingleStorage.NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666474);
			SqlSingleStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666475);
			SqlSingleStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666476);
			SqlSingleStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666477);
			SqlSingleStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666478);
			SqlSingleStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666479);
			SqlSingleStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666480);
			SqlSingleStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr, 100666481);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0005CBE4 File Offset: 0x0005ADE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927266, XrefRangeEnd = 927283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlSingleStorage(DataColumn column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlSingleStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0005CC30 File Offset: 0x0005AE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927283, XrefRangeEnd = 927417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0005CC90 File Offset: 0x0005AE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927417, XrefRangeEnd = 927423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0005CCE8 File Offset: 0x0005AEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927423, XrefRangeEnd = 927432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0005CD44 File Offset: 0x0005AF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927432, XrefRangeEnd = 927433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0005CD94 File Offset: 0x0005AF94
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0005CDE0 File Offset: 0x0005AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927433, XrefRangeEnd = 927436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Get(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0005CE2C File Offset: 0x0005B02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927436, XrefRangeEnd = 927442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsNull(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0005CE78 File Offset: 0x0005B078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927442, XrefRangeEnd = 927443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0005CEC8 File Offset: 0x0005B0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927443, XrefRangeEnd = 927452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0005CF08 File Offset: 0x0005B108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927452, XrefRangeEnd = 927482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertXmlToObject(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0005CF58 File Offset: 0x0005B158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927482, XrefRangeEnd = 927504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertObjectToXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0005CFA0 File Offset: 0x0005B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927504, XrefRangeEnd = 927507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEmptyStorage(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0005CFEC File Offset: 0x0005B1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927507, XrefRangeEnd = 927517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0005D05C File Offset: 0x0005B25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927517, XrefRangeEnd = 927526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlSingleStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000076F0 File Offset: 0x000058F0
		public SqlSingleStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0005D0B0 File Offset: 0x0005B2B0
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x000076F9 File Offset: 0x000058F9
		public unsafe Il2CppStructArray<SqlSingle> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlSingleStorage.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SqlSingle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlSingleStorage.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0;
	}
}
