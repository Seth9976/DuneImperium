using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Serialization;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000A4 RID: 164
	public sealed class ObjectStorage : DataStorage
	{
		// Token: 0x060010E2 RID: 4322 RVA: 0x000502FC File Offset: 0x0004E4FC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectStorage()
		{
			Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "ObjectStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr);
			ObjectStorage.NativeFieldInfoPtr_s_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, "s_defaultValue");
			ObjectStorage.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, "_values");
			ObjectStorage.NativeFieldInfoPtr__implementsIXmlSerializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, "_implementsIXmlSerializable");
			ObjectStorage.NativeFieldInfoPtr_s_tempAssemblyCacheLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, "s_tempAssemblyCacheLock");
			ObjectStorage.NativeFieldInfoPtr_s_tempAssemblyCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, "s_tempAssemblyCache");
			ObjectStorage.NativeFieldInfoPtr_s_serializerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, "s_serializerFactory");
			ObjectStorage.NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666006);
			ObjectStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666007);
			ObjectStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666008);
			ObjectStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666009);
			ObjectStorage.NativeMethodInfoPtr_CompareTo_Private_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666010);
			ObjectStorage.NativeMethodInfoPtr_CompareWithFamilies_Private_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666011);
			ObjectStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666012);
			ObjectStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666013);
			ObjectStorage.NativeMethodInfoPtr_GetFamily_Private_Families_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666014);
			ObjectStorage.NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666015);
			ObjectStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666016);
			ObjectStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666017);
			ObjectStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666018);
			ObjectStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_XmlReader_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666019);
			ObjectStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666020);
			ObjectStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_Void_Object_XmlWriter_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666021);
			ObjectStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666022);
			ObjectStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666023);
			ObjectStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666024);
			ObjectStorage.NativeMethodInfoPtr_VerifyIDynamicMetaObjectProvider_Internal_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666025);
			ObjectStorage.NativeMethodInfoPtr_GetXmlSerializer_Internal_Static_XmlSerializer_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666026);
			ObjectStorage.NativeMethodInfoPtr_GetXmlSerializer_Internal_Static_XmlSerializer_Type_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, 100666027);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0005055C File Offset: 0x0004E75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 920424, RefRangeEnd = 920425, XrefRangeStart = 920402, XrefRangeEnd = 920424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectStorage(DataColumn column, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x000505BC File Offset: 0x0004E7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920425, XrefRangeEnd = 920428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0005061C File Offset: 0x0004E81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920428, XrefRangeEnd = 920433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00050674 File Offset: 0x0004E874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920433, XrefRangeEnd = 920453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CompareValueTo(int recordNo1, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x000506D0 File Offset: 0x0004E8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 920462, RefRangeEnd = 920463, XrefRangeStart = 920453, XrefRangeEnd = 920462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object valueNo1, Object valueNo2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueNo1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueNo2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_CompareTo_Private_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00050730 File Offset: 0x0004E930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 920483, RefRangeEnd = 920484, XrefRangeStart = 920463, XrefRangeEnd = 920483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareWithFamilies(Object valueNo1, Object valueNo2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueNo1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueNo2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_CompareWithFamilies_Private_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00050790 File Offset: 0x0004E990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920484, XrefRangeEnd = 920490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x000507DC File Offset: 0x0004E9DC
		[CallerCount(0)]
		public unsafe override Object Get(int recordNo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00050828 File Offset: 0x0004EA28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 920495, RefRangeEnd = 920497, XrefRangeStart = 920490, XrefRangeEnd = 920495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectStorage.Families GetFamily(Type dataType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_GetFamily_Private_Families_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00050878 File Offset: 0x0004EA78
		[CallerCount(0)]
		public unsafe override bool IsNull(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x000508C4 File Offset: 0x0004EAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920497, XrefRangeEnd = 920653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Set(int recordNo, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00050914 File Offset: 0x0004EB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920653, XrefRangeEnd = 920662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00050954 File Offset: 0x0004EB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920662, XrefRangeEnd = 920704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertXmlToObject(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000509A4 File Offset: 0x0004EBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920704, XrefRangeEnd = 920801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_XmlReader_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00050A08 File Offset: 0x0004EC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920801, XrefRangeEnd = 920870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertObjectToXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00050A50 File Offset: 0x0004EC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920870, XrefRangeEnd = 920886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConvertObjectToXml(Object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_Void_Object_XmlWriter_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00050AB8 File Offset: 0x0004ECB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920886, XrefRangeEnd = 920889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEmptyStorage(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00050B04 File Offset: 0x0004ED04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920889, XrefRangeEnd = 920910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00050B74 File Offset: 0x0004ED74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920910, XrefRangeEnd = 920932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00050BC8 File Offset: 0x0004EDC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 920943, RefRangeEnd = 920947, XrefRangeStart = 920932, XrefRangeEnd = 920943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VerifyIDynamicMetaObjectProvider(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_VerifyIDynamicMetaObjectProvider_Internal_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00050C00 File Offset: 0x0004EE00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 920954, RefRangeEnd = 920958, XrefRangeStart = 920947, XrefRangeEnd = 920954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSerializer GetXmlSerializer(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_GetXmlSerializer_Internal_Static_XmlSerializer_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializer>(intPtr3) : null;
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00050C44 File Offset: 0x0004EE44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 921045, RefRangeEnd = 921049, XrefRangeStart = 920958, XrefRangeEnd = 921045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.NativeMethodInfoPtr_GetXmlSerializer_Internal_Static_XmlSerializer_Type_XmlRootAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializer>(intPtr3) : null;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0000703D File Offset: 0x0000523D
		public ObjectStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x00050C9C File Offset: 0x0004EE9C
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x00007046 File Offset: 0x00005246
		public unsafe static Object s_defaultValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectStorage.NativeFieldInfoPtr_s_defaultValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectStorage.NativeFieldInfoPtr_s_defaultValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00050CC4 File Offset: 0x0004EEC4
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x00007058 File Offset: 0x00005258
		public unsafe Il2CppReferenceArray<Object> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectStorage.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectStorage.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x00007077 File Offset: 0x00005277
		public unsafe bool _implementsIXmlSerializable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectStorage.NativeFieldInfoPtr__implementsIXmlSerializable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectStorage.NativeFieldInfoPtr__implementsIXmlSerializable)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00050D1C File Offset: 0x0004EF1C
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00007092 File Offset: 0x00005292
		public unsafe static Object s_tempAssemblyCacheLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectStorage.NativeFieldInfoPtr_s_tempAssemblyCacheLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectStorage.NativeFieldInfoPtr_s_tempAssemblyCacheLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00050D44 File Offset: 0x0004EF44
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x000070A4 File Offset: 0x000052A4
		public unsafe static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectStorage.NativeFieldInfoPtr_s_tempAssemblyCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectStorage.NativeFieldInfoPtr_s_tempAssemblyCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00050D6C File Offset: 0x0004EF6C
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x000070B6 File Offset: 0x000052B6
		public unsafe static XmlSerializerFactory s_serializerFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectStorage.NativeFieldInfoPtr_s_serializerFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializerFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectStorage.NativeFieldInfoPtr_s_serializerFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultValue;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeFieldInfoPtr__implementsIXmlSerializable;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeFieldInfoPtr_s_tempAssemblyCacheLock;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeFieldInfoPtr_s_tempAssemblyCache;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeFieldInfoPtr_s_serializerFactory;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_Type_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Private_Int32_Object_Object_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_CompareWithFamilies_Private_Int32_Object_Object_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_GetFamily_Private_Families_Type_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_XmlReader_XmlRootAttribute_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_Void_Object_XmlWriter_XmlRootAttribute_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_VerifyIDynamicMetaObjectProvider_Internal_Static_Void_Type_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlSerializer_Internal_Static_XmlSerializer_Type_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlSerializer_Internal_Static_XmlSerializer_Type_XmlRootAttribute_0;

		// Token: 0x020000F4 RID: 244
		public enum Families
		{
			// Token: 0x04001196 RID: 4502
			DATETIME,
			// Token: 0x04001197 RID: 4503
			NUMBER,
			// Token: 0x04001198 RID: 4504
			STRING,
			// Token: 0x04001199 RID: 4505
			BOOLEAN,
			// Token: 0x0400119A RID: 4506
			ARRAY
		}

		// Token: 0x020000F5 RID: 245
		public class TempAssemblyComparer : Object
		{
			// Token: 0x0600153F RID: 5439 RVA: 0x00064898 File Offset: 0x00062A98
			// Note: this type is marked as 'beforefieldinit'.
			static TempAssemblyComparer()
			{
				Il2CppClassPointerStore<ObjectStorage.TempAssemblyComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectStorage>.NativeClassPtr, "TempAssemblyComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectStorage.TempAssemblyComparer>.NativeClassPtr);
				ObjectStorage.TempAssemblyComparer.NativeFieldInfoPtr_s_default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectStorage.TempAssemblyComparer>.NativeClassPtr, "s_default");
				ObjectStorage.TempAssemblyComparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage.TempAssemblyComparer>.NativeClassPtr, 100666029);
				ObjectStorage.TempAssemblyComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Type_XmlRootAttribute_KeyValuePair_2_Type_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage.TempAssemblyComparer>.NativeClassPtr, 100666030);
				ObjectStorage.TempAssemblyComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_KeyValuePair_2_Type_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectStorage.TempAssemblyComparer>.NativeClassPtr, 100666031);
			}

			// Token: 0x06001540 RID: 5440 RVA: 0x00064914 File Offset: 0x00062B14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TempAssemblyComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectStorage.TempAssemblyComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.TempAssemblyComparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001541 RID: 5441 RVA: 0x00064950 File Offset: 0x00062B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920393, XrefRangeEnd = 920399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.TempAssemblyComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Type_XmlRootAttribute_KeyValuePair_2_Type_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001542 RID: 5442 RVA: 0x000649BC File Offset: 0x00062BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920399, XrefRangeEnd = 920402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectStorage.TempAssemblyComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_KeyValuePair_2_Type_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001543 RID: 5443 RVA: 0x00008130 File Offset: 0x00006330
			public TempAssemblyComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x06001544 RID: 5444 RVA: 0x00064A10 File Offset: 0x00062C10
			// (set) Token: 0x06001545 RID: 5445 RVA: 0x00008139 File Offset: 0x00006339
			public unsafe static IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectStorage.TempAssemblyComparer.NativeFieldInfoPtr_s_default, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectStorage.TempAssemblyComparer.NativeFieldInfoPtr_s_default, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400119B RID: 4507
			private static readonly IntPtr NativeFieldInfoPtr_s_default;

			// Token: 0x0400119C RID: 4508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x0400119D RID: 4509
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Type_XmlRootAttribute_KeyValuePair_2_Type_XmlRootAttribute_0;

			// Token: 0x0400119E RID: 4510
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_KeyValuePair_2_Type_XmlRootAttribute_0;
		}
	}
}
