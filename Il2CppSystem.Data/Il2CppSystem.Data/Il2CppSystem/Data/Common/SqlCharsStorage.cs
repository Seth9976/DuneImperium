using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Data.SqlTypes;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000B8 RID: 184
	public sealed class SqlCharsStorage : DataStorage
	{
		// Token: 0x060012A6 RID: 4774 RVA: 0x0005910C File Offset: 0x0005730C
		// Note: this type is marked as 'beforefieldinit'.
		static SqlCharsStorage()
		{
			Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "SqlCharsStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr);
			SqlCharsStorage.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, "_values");
			SqlCharsStorage.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666333);
			SqlCharsStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666334);
			SqlCharsStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666335);
			SqlCharsStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666336);
			SqlCharsStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666337);
			SqlCharsStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666338);
			SqlCharsStorage.NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666339);
			SqlCharsStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666340);
			SqlCharsStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666341);
			SqlCharsStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666342);
			SqlCharsStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666343);
			SqlCharsStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666344);
			SqlCharsStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666345);
			SqlCharsStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr, 100666346);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00059268 File Offset: 0x00057468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925325, XrefRangeEnd = 925337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlCharsStorage(DataColumn column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlCharsStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000592B4 File Offset: 0x000574B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925337, XrefRangeEnd = 925343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00059314 File Offset: 0x00057514
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0005936C File Offset: 0x0005756C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000593C8 File Offset: 0x000575C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00059414 File Offset: 0x00057614
		[CallerCount(0)]
		public unsafe override Object Get(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00059460 File Offset: 0x00057660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsNull(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000594AC File Offset: 0x000576AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925343, XrefRangeEnd = 925355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000594FC File Offset: 0x000576FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925355, XrefRangeEnd = 925364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0005953C File Offset: 0x0005773C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925364, XrefRangeEnd = 925395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertXmlToObject(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0005958C File Offset: 0x0005778C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925395, XrefRangeEnd = 925417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertObjectToXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000595D4 File Offset: 0x000577D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925417, XrefRangeEnd = 925420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEmptyStorage(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00059620 File Offset: 0x00057820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925420, XrefRangeEnd = 925431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00059690 File Offset: 0x00057890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925431, XrefRangeEnd = 925440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlCharsStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00007588 File Offset: 0x00005788
		public SqlCharsStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x000596E4 File Offset: 0x000578E4
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x00007591 File Offset: 0x00005791
		public unsafe Il2CppReferenceArray<SqlChars> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlCharsStorage.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SqlChars>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SqlCharsStorage.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0;
	}
}
