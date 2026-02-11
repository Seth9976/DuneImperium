using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Serialization;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000AB RID: 171
	public class DataStorage : Object
	{
		// Token: 0x06001176 RID: 4470 RVA: 0x00052EAC File Offset: 0x000510AC
		// Note: this type is marked as 'beforefieldinit'.
		static DataStorage()
		{
			Il2CppClassPointerStore<DataStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "DataStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataStorage>.NativeClassPtr);
			DataStorage.NativeFieldInfoPtr_s_storageClassType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "s_storageClassType");
			DataStorage.NativeFieldInfoPtr__column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_column");
			DataStorage.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_table");
			DataStorage.NativeFieldInfoPtr__dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_dataType");
			DataStorage.NativeFieldInfoPtr__storageTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_storageTypeCode");
			DataStorage.NativeFieldInfoPtr__dbNullBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_dbNullBits");
			DataStorage.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_defaultValue");
			DataStorage.NativeFieldInfoPtr__nullValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_nullValue");
			DataStorage.NativeFieldInfoPtr__isCloneable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_isCloneable");
			DataStorage.NativeFieldInfoPtr__isCustomDefinedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_isCustomDefinedType");
			DataStorage.NativeFieldInfoPtr__isStringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_isStringType");
			DataStorage.NativeFieldInfoPtr__isValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "_isValueType");
			DataStorage.NativeFieldInfoPtr_s_inspectTypeForInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "s_inspectTypeForInterfaces");
			DataStorage.NativeFieldInfoPtr_s_typeImplementsInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, "s_typeImplementsInterface");
			DataStorage.NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666108);
			DataStorage.NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_Object_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666109);
			DataStorage.NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_Object_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666110);
			DataStorage.NativeMethodInfoPtr_get_DateTimeMode_Internal_get_DataSetDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666111);
			DataStorage.NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666112);
			DataStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_New_Object_Il2CppStructArray_1_Int32_AggregateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666113);
			DataStorage.NativeMethodInfoPtr_AggregateCount_Public_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666114);
			DataStorage.NativeMethodInfoPtr_CompareBits_Protected_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666115);
			DataStorage.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666116);
			DataStorage.NativeMethodInfoPtr_CompareValueTo_Public_Abstract_Virtual_New_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666117);
			DataStorage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666118);
			DataStorage.NativeMethodInfoPtr_CopyBits_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666119);
			DataStorage.NativeMethodInfoPtr_Copy_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666120);
			DataStorage.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666121);
			DataStorage.NativeMethodInfoPtr_GetBits_Protected_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666122);
			DataStorage.NativeMethodInfoPtr_GetStringLength_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666123);
			DataStorage.NativeMethodInfoPtr_HasValue_Protected_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666124);
			DataStorage.NativeMethodInfoPtr_IsNull_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666125);
			DataStorage.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666126);
			DataStorage.NativeMethodInfoPtr_SetNullBit_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666127);
			DataStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666128);
			DataStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Abstract_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666129);
			DataStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_New_Object_XmlReader_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666130);
			DataStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666131);
			DataStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_New_Void_Object_XmlWriter_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666132);
			DataStorage.NativeMethodInfoPtr_CreateStorage_Public_Static_DataStorage_DataColumn_Type_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666133);
			DataStorage.NativeMethodInfoPtr_GetStorageType_Internal_Static_StorageType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666134);
			DataStorage.NativeMethodInfoPtr_GetTypeStorage_Internal_Static_Type_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666135);
			DataStorage.NativeMethodInfoPtr_IsTypeCustomType_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666136);
			DataStorage.NativeMethodInfoPtr_IsTypeCustomType_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666137);
			DataStorage.NativeMethodInfoPtr_IsSqlType_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666138);
			DataStorage.NativeMethodInfoPtr_IsSqlType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666139);
			DataStorage.NativeMethodInfoPtr_DetermineIfValueType_Private_Static_Boolean_StorageType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666140);
			DataStorage.NativeMethodInfoPtr_ImplementsInterfaces_Internal_Static_Void_StorageType_Type_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666141);
			DataStorage.NativeMethodInfoPtr_InspectTypeForInterfaces_Private_Static_Tuple_4_Boolean_Boolean_Boolean_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666142);
			DataStorage.NativeMethodInfoPtr_ImplementsINullableValue_Internal_Static_Boolean_StorageType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666143);
			DataStorage.NativeMethodInfoPtr_IsObjectNull_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666144);
			DataStorage.NativeMethodInfoPtr_IsObjectSqlNull_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666145);
			DataStorage.NativeMethodInfoPtr_GetEmptyStorageInternal_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666146);
			DataStorage.NativeMethodInfoPtr_CopyValueInternal_Internal_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666147);
			DataStorage.NativeMethodInfoPtr_SetStorageInternal_Internal_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666148);
			DataStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Abstract_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666149);
			DataStorage.NativeMethodInfoPtr_CopyValue_Protected_Abstract_Virtual_New_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666150);
			DataStorage.NativeMethodInfoPtr_SetStorage_Protected_Abstract_Virtual_New_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666151);
			DataStorage.NativeMethodInfoPtr_SetNullStorage_Protected_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666152);
			DataStorage.NativeMethodInfoPtr_GetType_Internal_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666153);
			DataStorage.NativeMethodInfoPtr_GetQualifiedName_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStorage>.NativeClassPtr, 100666154);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x000533A0 File Offset: 0x000515A0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 921946, RefRangeEnd = 921964, XrefRangeStart = 921941, XrefRangeEnd = 921946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataStorage(DataColumn column, Type type, Object defaultValue, StorageType storageType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataStorage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storageType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_StorageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00053420 File Offset: 0x00051620
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 921965, RefRangeEnd = 921974, XrefRangeStart = 921964, XrefRangeEnd = 921965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataStorage(DataColumn column, Type type, Object defaultValue, Object nullValue, StorageType storageType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataStorage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storageType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_Object_StorageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000534B0 File Offset: 0x000516B0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 921990, RefRangeEnd = 922001, XrefRangeStart = 921974, XrefRangeEnd = 921990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataStorage(DataColumn column, Type type, Object defaultValue, Object nullValue, bool isICloneable, StorageType storageType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataStorage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isICloneable;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storageType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_Object_Boolean_StorageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00053550 File Offset: 0x00051750
		public unsafe DataSetDateTime DateTimeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_get_DateTimeMode_Internal_get_DataSetDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0005358C File Offset: 0x0005178C
		public unsafe IFormatProvider FormatProvider
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 922003, RefRangeEnd = 922018, XrefRangeStart = 922001, XrefRangeEnd = 922003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x000535CC File Offset: 0x000517CC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 922018, RefRangeEnd = 922028, XrefRangeStart = 922018, XrefRangeEnd = 922018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Aggregate(Il2CppStructArray<int> recordNos, AggregateType kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recordNos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_New_Object_Il2CppStructArray_1_Int32_AggregateType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00053638 File Offset: 0x00051838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922028, XrefRangeEnd = 922033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object AggregateCount(Il2CppStructArray<int> recordNos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recordNos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_AggregateCount_Public_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00053688 File Offset: 0x00051888
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 922035, RefRangeEnd = 922052, XrefRangeStart = 922033, XrefRangeEnd = 922035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareBits(int recordNo1, int recordNo2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_CompareBits_Protected_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x000536E0 File Offset: 0x000518E0
		[CallerCount(0)]
		public unsafe virtual int Compare(int recordNo1, int recordNo2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00053744 File Offset: 0x00051944
		[CallerCount(0)]
		public unsafe virtual int CompareValueTo(int recordNo1, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_CompareValueTo_Public_Abstract_Virtual_New_Int32_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000537AC File Offset: 0x000519AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ConvertValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00053808 File Offset: 0x00051A08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 922055, RefRangeEnd = 922061, XrefRangeStart = 922052, XrefRangeEnd = 922055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyBits(int srcRecordNo, int dstRecordNo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srcRecordNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstRecordNo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_CopyBits_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00053854 File Offset: 0x00051A54
		[CallerCount(0)]
		public unsafe virtual void Copy(int recordNo1, int recordNo2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_Copy_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000538AC File Offset: 0x00051AAC
		[CallerCount(0)]
		public unsafe virtual Object Get(int recordNo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00053904 File Offset: 0x00051B04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 922062, RefRangeEnd = 922067, XrefRangeStart = 922061, XrefRangeEnd = 922062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetBits(int recordNo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_GetBits_Protected_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00053950 File Offset: 0x00051B50
		[CallerCount(0)]
		public unsafe virtual int GetStringLength(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_GetStringLength_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000539A4 File Offset: 0x00051BA4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 922068, RefRangeEnd = 922091, XrefRangeStart = 922067, XrefRangeEnd = 922068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasValue(int recordNo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_HasValue_Protected_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000539F0 File Offset: 0x00051BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922091, XrefRangeEnd = 922093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsNull(int recordNo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_IsNull_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00053A44 File Offset: 0x00051C44
		[CallerCount(0)]
		public unsafe virtual void Set(int recordNo, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00053AA0 File Offset: 0x00051CA0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 922095, RefRangeEnd = 922101, XrefRangeStart = 922093, XrefRangeEnd = 922095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNullBit(int recordNo, bool flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_SetNullBit_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00053AEC File Offset: 0x00051CEC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 922107, RefRangeEnd = 922125, XrefRangeStart = 922101, XrefRangeEnd = 922107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00053B38 File Offset: 0x00051D38
		[CallerCount(0)]
		public unsafe virtual Object ConvertXmlToObject(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Abstract_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00053B94 File Offset: 0x00051D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922125, XrefRangeEnd = 922126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlReader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlAttrib);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_New_Object_XmlReader_XmlRootAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00053C04 File Offset: 0x00051E04
		[CallerCount(0)]
		public unsafe virtual string ConvertObjectToXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00053C58 File Offset: 0x00051E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922126, XrefRangeEnd = 922127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConvertObjectToXml(Object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlWriter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xmlAttrib);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_New_Void_Object_XmlWriter_XmlRootAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00053CCC File Offset: 0x00051ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 922174, RefRangeEnd = 922175, XrefRangeStart = 922127, XrefRangeEnd = 922174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_CreateStorage_Public_Static_DataStorage_DataColumn_Type_StorageType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataStorage>(intPtr3) : null;
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00053D30 File Offset: 0x00051F30
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 922186, RefRangeEnd = 922219, XrefRangeStart = 922175, XrefRangeEnd = 922186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorageType GetStorageType(Type dataType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_GetStorageType_Internal_Static_StorageType_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00053D74 File Offset: 0x00051F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922219, XrefRangeEnd = 922223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeStorage(StorageType storageType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref storageType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_GetTypeStorage_Internal_Static_Type_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00053DB4 File Offset: 0x00051FB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 922227, RefRangeEnd = 922231, XrefRangeStart = 922223, XrefRangeEnd = 922227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTypeCustomType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_IsTypeCustomType_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00053DF8 File Offset: 0x00051FF8
		[CallerCount(0)]
		public unsafe static bool IsTypeCustomType(StorageType typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_IsTypeCustomType_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00053E38 File Offset: 0x00052038
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 922231, RefRangeEnd = 922234, XrefRangeStart = 922231, XrefRangeEnd = 922231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSqlType(StorageType storageType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref storageType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_IsSqlType_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00053E78 File Offset: 0x00052078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 922245, RefRangeEnd = 922247, XrefRangeStart = 922234, XrefRangeEnd = 922245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSqlType(Type dataType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_IsSqlType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00053EBC File Offset: 0x000520BC
		[CallerCount(0)]
		public unsafe static bool DetermineIfValueType(StorageType typeCode, Type dataType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_DetermineIfValueType_Private_Static_Boolean_StorageType_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00053F0C File Offset: 0x0005210C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 922262, RefRangeEnd = 922263, XrefRangeStart = 922247, XrefRangeEnd = 922262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sqlType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nullable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &xmlSerializable;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &changeTracking;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &revertibleChangeTracking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_ImplementsInterfaces_Internal_Static_Void_StorageType_Type_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00053F9C File Offset: 0x0005219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922263, XrefRangeEnd = 922284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_InspectTypeForInterfaces_Private_Static_Tuple_4_Boolean_Boolean_Boolean_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<bool, bool, bool, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00053FE0 File Offset: 0x000521E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 922291, RefRangeEnd = 922293, XrefRangeStart = 922284, XrefRangeEnd = 922291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ImplementsINullableValue(StorageType typeCode, Type dataType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_ImplementsINullableValue_Internal_Static_Boolean_StorageType_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00054030 File Offset: 0x00052230
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 922303, RefRangeEnd = 922321, XrefRangeStart = 922293, XrefRangeEnd = 922303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsObjectNull(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_IsObjectNull_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00054074 File Offset: 0x00052274
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 922324, RefRangeEnd = 922332, XrefRangeStart = 922321, XrefRangeEnd = 922324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsObjectSqlNull(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_IsObjectSqlNull_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000540B8 File Offset: 0x000522B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 922332, RefRangeEnd = 922333, XrefRangeStart = 922332, XrefRangeEnd = 922332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetEmptyStorageInternal(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_GetEmptyStorageInternal_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00054104 File Offset: 0x00052304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 922333, RefRangeEnd = 922334, XrefRangeStart = 922333, XrefRangeEnd = 922333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyValueInternal(int record, Object store, BitArray nullbits, int storeIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_CopyValueInternal_Internal_Void_Int32_Object_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00054174 File Offset: 0x00052374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 922644, RefRangeEnd = 922645, XrefRangeStart = 922334, XrefRangeEnd = 922644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStorageInternal(Object store, BitArray nullbits)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_SetStorageInternal_Internal_Void_Object_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000541C8 File Offset: 0x000523C8
		[CallerCount(0)]
		public unsafe virtual Object GetEmptyStorage(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Abstract_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00054220 File Offset: 0x00052420
		[CallerCount(0)]
		public unsafe virtual void CopyValue(int record, Object store, BitArray nullbits, int storeIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_CopyValue_Protected_Abstract_Virtual_New_Void_Int32_Object_BitArray_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0005429C File Offset: 0x0005249C
		[CallerCount(0)]
		public unsafe virtual void SetStorage(Object store, BitArray nullbits)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStorage.NativeMethodInfoPtr_SetStorage_Protected_Abstract_Virtual_New_Void_Object_BitArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x000542FC File Offset: 0x000524FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNullStorage(BitArray nullbits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullbits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_SetNullStorage_Protected_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00054340 File Offset: 0x00052540
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 922666, RefRangeEnd = 922670, XrefRangeStart = 922645, XrefRangeEnd = 922666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetType(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_GetType_Internal_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00054384 File Offset: 0x00052584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 922675, RefRangeEnd = 922677, XrefRangeStart = 922670, XrefRangeEnd = 922675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetQualifiedName(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStorage.NativeMethodInfoPtr_GetQualifiedName_Internal_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0000721D File Offset: 0x0000541D
		public DataStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000543C0 File Offset: 0x000525C0
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00007226 File Offset: 0x00005426
		public unsafe static Il2CppReferenceArray<Type> s_storageClassType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataStorage.NativeFieldInfoPtr_s_storageClassType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataStorage.NativeFieldInfoPtr_s_storageClassType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000543E8 File Offset: 0x000525E8
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x00007238 File Offset: 0x00005438
		public unsafe DataColumn _column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__column);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__column), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00054418 File Offset: 0x00052618
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x00007257 File Offset: 0x00005457
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00054448 File Offset: 0x00052648
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x00007276 File Offset: 0x00005476
		public unsafe Type _dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00054478 File Offset: 0x00052678
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00007295 File Offset: 0x00005495
		public unsafe StorageType _storageTypeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__storageTypeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__storageTypeCode)) = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000544A0 File Offset: 0x000526A0
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x000072B0 File Offset: 0x000054B0
		public unsafe BitArray _dbNullBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__dbNullBits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__dbNullBits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000544D0 File Offset: 0x000526D0
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x000072CF File Offset: 0x000054CF
		public unsafe Object _defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00054500 File Offset: 0x00052700
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x000072EE File Offset: 0x000054EE
		public unsafe Object _nullValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__nullValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__nullValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00054530 File Offset: 0x00052730
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x0000730D File Offset: 0x0000550D
		public unsafe bool _isCloneable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__isCloneable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__isCloneable)) = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00054558 File Offset: 0x00052758
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x00007328 File Offset: 0x00005528
		public unsafe bool _isCustomDefinedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__isCustomDefinedType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__isCustomDefinedType)) = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00054580 File Offset: 0x00052780
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x00007343 File Offset: 0x00005543
		public unsafe bool _isStringType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__isStringType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__isStringType)) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x000545A8 File Offset: 0x000527A8
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0000735E File Offset: 0x0000555E
		public unsafe bool _isValueType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__isValueType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStorage.NativeFieldInfoPtr__isValueType)) = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x000545D0 File Offset: 0x000527D0
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x00007379 File Offset: 0x00005579
		public unsafe static Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataStorage.NativeFieldInfoPtr_s_inspectTypeForInterfaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, Tuple<bool, bool, bool, bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataStorage.NativeFieldInfoPtr_s_inspectTypeForInterfaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x000545F8 File Offset: 0x000527F8
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x0000738B File Offset: 0x0000558B
		public unsafe static ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataStorage.NativeFieldInfoPtr_s_typeImplementsInterface, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataStorage.NativeFieldInfoPtr_s_typeImplementsInterface, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeFieldInfoPtr_s_storageClassType;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr__column;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeFieldInfoPtr__dataType;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeFieldInfoPtr__storageTypeCode;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeFieldInfoPtr__dbNullBits;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeFieldInfoPtr__nullValue;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeFieldInfoPtr__isCloneable;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeFieldInfoPtr__isCustomDefinedType;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeFieldInfoPtr__isStringType;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeFieldInfoPtr__isValueType;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeFieldInfoPtr_s_inspectTypeForInterfaces;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_s_typeImplementsInterface;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_StorageType_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_Object_StorageType_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DataColumn_Type_Object_Object_Boolean_StorageType_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeMode_Internal_get_DataSetDateTime_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Virtual_New_Object_Il2CppStructArray_1_Int32_AggregateType_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_AggregateCount_Public_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_CompareBits_Protected_Int32_Int32_Int32_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Public_Abstract_Virtual_New_Int32_Int32_Object_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValue_Public_Virtual_New_Object_Object_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_CopyBits_Protected_Void_Int32_Int32_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_Int32_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_GetBits_Protected_Object_Int32_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_GetStringLength_Public_Virtual_New_Int32_Int32_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_HasValue_Protected_Boolean_Int32_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_Int32_Object_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_SetNullBit_Protected_Void_Int32_Boolean_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Abstract_Virtual_New_Object_String_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_New_Object_XmlReader_XmlRootAttribute_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Abstract_Virtual_New_String_Object_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_New_Void_Object_XmlWriter_XmlRootAttribute_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_CreateStorage_Public_Static_DataStorage_DataColumn_Type_StorageType_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_GetStorageType_Internal_Static_StorageType_Type_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeStorage_Internal_Static_Type_StorageType_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCustomType_Internal_Static_Boolean_Type_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCustomType_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_IsSqlType_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_IsSqlType_Public_Static_Boolean_Type_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_DetermineIfValueType_Private_Static_Boolean_StorageType_Type_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_ImplementsInterfaces_Internal_Static_Void_StorageType_Type_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_InspectTypeForInterfaces_Private_Static_Tuple_4_Boolean_Boolean_Boolean_Boolean_Type_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_ImplementsINullableValue_Internal_Static_Boolean_StorageType_Type_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectNull_Public_Static_Boolean_Object_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectSqlNull_Public_Static_Boolean_Object_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyStorageInternal_Internal_Object_Int32_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_CopyValueInternal_Internal_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_SetStorageInternal_Internal_Void_Object_BitArray_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyStorage_Protected_Abstract_Virtual_New_Object_Int32_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_CopyValue_Protected_Abstract_Virtual_New_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_SetStorage_Protected_Abstract_Virtual_New_Void_Object_BitArray_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_SetNullStorage_Protected_Void_BitArray_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Static_Type_String_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_GetQualifiedName_Internal_Static_String_Type_0;
	}
}
