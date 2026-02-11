using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E6 RID: 230
	public class XmlSerializationReaderInterpreter : XmlSerializationReader
	{
		// Token: 0x0600150E RID: 5390 RVA: 0x00070988 File Offset: 0x0006EB88
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationReaderInterpreter()
		{
			Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationReaderInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr);
			XmlSerializationReaderInterpreter.NativeFieldInfoPtr__typeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, "_typeMap");
			XmlSerializationReaderInterpreter.NativeFieldInfoPtr__format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, "_format");
			XmlSerializationReaderInterpreter.NativeFieldInfoPtr_AnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, "AnyType");
			XmlSerializationReaderInterpreter.NativeFieldInfoPtr_empty_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, "empty_array");
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666638);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666639);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_InitIDs_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666640);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadRoot_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666641);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadEncodedObject_Private_Object_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666642);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadMessage_Protected_Virtual_New_Object_XmlMembersMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666643);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadRoot_Private_Object_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666644);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadObject_Protected_Virtual_New_Object_XmlTypeMapping_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666645);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadClassInstance_Protected_Virtual_New_Object_XmlTypeMapping_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666646);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadClassInstanceMembers_Protected_Virtual_New_Void_XmlTypeMapping_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666647);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadAttributeMembers_Private_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666648);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadMembers_Private_Void_ClassMap_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666649);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_SetListMembersDefaults_Private_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666650);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_FixupMembers_Internal_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666651);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ProcessUnknownAttribute_Protected_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666652);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ProcessUnknownElement_Protected_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666653);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_IsReadOnly_Private_Boolean_XmlTypeMapMember_TypeData_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666654);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_SetMemberValue_Private_Void_XmlTypeMapMember_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666655);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_SetMemberValueFromAttr_Private_Void_XmlTypeMapMember_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666656);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666657);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadObjectElement_Private_Object_XmlTypeMapElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666658);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadPrimitiveValue_Private_Object_XmlTypeMapElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666659);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_GetValueFromXmlString_Private_Object_String_TypeData_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666660);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadListElement_Private_Object_XmlTypeMapping_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666661);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadListString_Private_Object_XmlTypeMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666662);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_AddListValue_Private_Void_TypeData_byref_Object_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666663);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_CreateInstance_Private_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666664);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_CreateInstance_Private_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666665);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_CreateList_Private_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666666);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_InitializeList_Private_Object_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666667);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_FillList_Private_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666668);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_CopyEnumerableList_Private_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666669);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadXmlNodeElement_Private_Object_XmlTypeMapping_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666670);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadXmlNode_Private_Object_TypeData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666671);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadPrimitiveElement_Private_Object_XmlTypeMapping_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666672);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadEnumElement_Private_Object_XmlTypeMapping_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666673);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_GetEnumValue_Private_Object_XmlTypeMapping_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666674);
			XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadXmlSerializableElement_Private_Object_XmlTypeMapping_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, 100666675);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00070D00 File Offset: 0x0006EF00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387797, RefRangeEnd = 387800, XrefRangeStart = 387795, XrefRangeEnd = 387797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationReaderInterpreter(XmlMapping typeMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00070D4C File Offset: 0x0006EF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387800, XrefRangeEnd = 387828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReaderInterpreter.NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00070D88 File Offset: 0x0006EF88
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReaderInterpreter.NativeMethodInfoPtr_InitIDs_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00070DC4 File Offset: 0x0006EFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387834, RefRangeEnd = 387835, XrefRangeStart = 387828, XrefRangeEnd = 387834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadRoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadRoot_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00070E04 File Offset: 0x0006F004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387842, RefRangeEnd = 387843, XrefRangeStart = 387835, XrefRangeEnd = 387842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadEncodedObject(XmlTypeMapping typeMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadEncodedObject_Private_Object_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00070E54 File Offset: 0x0006F054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387843, XrefRangeEnd = 387855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ReadMessage(XmlMembersMapping typeMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadMessage_Protected_Virtual_New_Object_XmlMembersMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00070EB0 File Offset: 0x0006F0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387855, XrefRangeEnd = 387857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadRoot(XmlTypeMapping rootMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadRoot_Private_Object_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00070F00 File Offset: 0x0006F100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387857, XrefRangeEnd = 387868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadObject_Protected_Virtual_New_Object_XmlTypeMapping_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00070F78 File Offset: 0x0006F178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387868, XrefRangeEnd = 387887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadClassInstance_Protected_Virtual_New_Object_XmlTypeMapping_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00070FF0 File Offset: 0x0006F1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387887, XrefRangeEnd = 387890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadClassInstanceMembers_Protected_Virtual_New_Void_XmlTypeMapping_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00071050 File Offset: 0x0006F250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387929, RefRangeEnd = 387930, XrefRangeStart = 387890, XrefRangeEnd = 387929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAttributeMembers(ClassMap map, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadAttributeMembers_Private_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000710B4 File Offset: 0x0006F2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387961, RefRangeEnd = 387963, XrefRangeStart = 387930, XrefRangeEnd = 387961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMembers(ClassMap map, Object ob, bool isValueList, bool readBySoapOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readBySoapOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadMembers_Private_Void_ClassMap_Object_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00071124 File Offset: 0x0006F324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387971, RefRangeEnd = 387972, XrefRangeStart = 387963, XrefRangeEnd = 387971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListMembersDefaults(ClassMap map, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_SetListMembersDefaults_Private_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00071188 File Offset: 0x0006F388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387997, RefRangeEnd = 387998, XrefRangeStart = 387972, XrefRangeEnd = 387997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupMembers(ClassMap map, Object obfixup, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obfixup);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_FixupMembers_Internal_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000711EC File Offset: 0x0006F3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessUnknownAttribute(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ProcessUnknownAttribute_Protected_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0007123C File Offset: 0x0006F43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessUnknownElement(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ProcessUnknownElement_Protected_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0007128C File Offset: 0x0006F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387998, XrefRangeEnd = 388000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadOnly(XmlTypeMapMember member, TypeData memType, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_IsReadOnly_Private_Boolean_XmlTypeMapMember_TypeData_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0007130C File Offset: 0x0006F50C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 388015, RefRangeEnd = 388021, XrefRangeStart = 388000, XrefRangeEnd = 388015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMemberValue(XmlTypeMapMember member, Object ob, Object value, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_SetMemberValue_Private_Void_XmlTypeMapMember_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00071380 File Offset: 0x0006F580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388021, XrefRangeEnd = 388027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMemberValueFromAttr(XmlTypeMapMember member, Object ob, Object value, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_SetMemberValueFromAttr_Private_Void_XmlTypeMapMember_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000713F4 File Offset: 0x0006F5F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388033, RefRangeEnd = 388035, XrefRangeStart = 388027, XrefRangeEnd = 388033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetMemberValue(XmlTypeMapMember member, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00071464 File Offset: 0x0006F664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388035, XrefRangeEnd = 388039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadObjectElement(XmlTypeMapElementInfo elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadObjectElement_Private_Object_XmlTypeMapElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000714B4 File Offset: 0x0006F6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388050, RefRangeEnd = 388051, XrefRangeStart = 388039, XrefRangeEnd = 388050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadPrimitiveValue(XmlTypeMapElementInfo elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadPrimitiveValue_Private_Object_XmlTypeMapElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00071504 File Offset: 0x0006F704
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 388062, RefRangeEnd = 388065, XrefRangeStart = 388051, XrefRangeEnd = 388062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_GetValueFromXmlString_Private_Object_String_TypeData_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00071578 File Offset: 0x0006F778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388071, RefRangeEnd = 388072, XrefRangeStart = 388065, XrefRangeEnd = 388071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadListElement(XmlTypeMapping typeMap, bool isNullable, Object list, bool canCreateInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCreateInstance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadListElement_Private_Object_XmlTypeMapping_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000715F8 File Offset: 0x0006F7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388072, XrefRangeEnd = 388087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadListString(XmlTypeMapping typeMap, string values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadListString_Private_Object_XmlTypeMapping_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0007165C File Offset: 0x0006F85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388109, RefRangeEnd = 388110, XrefRangeStart = 388087, XrefRangeEnd = 388109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListValue(TypeData listType, ref Object list, int index, Object value, bool canCreateInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCreateInstance;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_AddListValue_Private_Void_TypeData_byref_Object_Int32_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			list = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000716F4 File Offset: 0x0006F8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388110, XrefRangeEnd = 388111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, bool nonPublic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonPublic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_CreateInstance_Private_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00071748 File Offset: 0x0006F948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388111, XrefRangeEnd = 388116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstance(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_CreateInstance_Private_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00071798 File Offset: 0x0006F998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388116, XrefRangeEnd = 388122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateList(Type listType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_CreateList_Private_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000717E8 File Offset: 0x0006F9E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388127, RefRangeEnd = 388128, XrefRangeStart = 388122, XrefRangeEnd = 388127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InitializeList(TypeData listType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_InitializeList_Private_Object_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00071838 File Offset: 0x0006FA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388128, XrefRangeEnd = 388129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillList(Object list, Object items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_FillList_Private_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0007188C File Offset: 0x0006FA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388161, RefRangeEnd = 388162, XrefRangeStart = 388129, XrefRangeEnd = 388161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyEnumerableList(Object source, Object dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_CopyEnumerableList_Private_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000718E0 File Offset: 0x0006FAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388162, XrefRangeEnd = 388164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadXmlNodeElement_Private_Object_XmlTypeMapping_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00071940 File Offset: 0x0006FB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388172, RefRangeEnd = 388173, XrefRangeStart = 388164, XrefRangeEnd = 388172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadXmlNode(TypeData type, bool wrapped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadXmlNode_Private_Object_TypeData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000719A0 File Offset: 0x0006FBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388173, XrefRangeEnd = 388183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadPrimitiveElement_Private_Object_XmlTypeMapping_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00071A00 File Offset: 0x0006FC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388183, XrefRangeEnd = 388185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadEnumElement_Private_Object_XmlTypeMapping_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00071A60 File Offset: 0x0006FC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388193, RefRangeEnd = 388195, XrefRangeStart = 388185, XrefRangeEnd = 388193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetEnumValue(XmlTypeMapping typeMap, string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_GetEnumValue_Private_Object_XmlTypeMapping_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00071AC4 File Offset: 0x0006FCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388195, XrefRangeEnd = 388199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.NativeMethodInfoPtr_ReadXmlSerializableElement_Private_Object_XmlTypeMapping_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000090BF File Offset: 0x000072BF
		public XmlSerializationReaderInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x00071B24 File Offset: 0x0006FD24
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x000090C8 File Offset: 0x000072C8
		public unsafe XmlMapping _typeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.NativeFieldInfoPtr__typeMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.NativeFieldInfoPtr__typeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x00071B54 File Offset: 0x0006FD54
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x000090E7 File Offset: 0x000072E7
		public unsafe SerializationFormat _format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.NativeFieldInfoPtr__format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.NativeFieldInfoPtr__format)) = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00071B7C File Offset: 0x0006FD7C
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x00009102 File Offset: 0x00007302
		public unsafe static XmlQualifiedName AnyType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializationReaderInterpreter.NativeFieldInfoPtr_AnyType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializationReaderInterpreter.NativeFieldInfoPtr_AnyType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x00071BA4 File Offset: 0x0006FDA4
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x00009114 File Offset: 0x00007314
		public unsafe static Il2CppReferenceArray<Object> empty_array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializationReaderInterpreter.NativeFieldInfoPtr_empty_array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializationReaderInterpreter.NativeFieldInfoPtr_empty_array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeFieldInfoPtr__typeMap;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeFieldInfoPtr__format;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeFieldInfoPtr_AnyType;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeFieldInfoPtr_empty_array;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_InitIDs_Protected_Virtual_Void_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_ReadRoot_Public_Object_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_ReadEncodedObject_Private_Object_XmlTypeMapping_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_ReadMessage_Protected_Virtual_New_Object_XmlMembersMapping_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_ReadRoot_Private_Object_XmlTypeMapping_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_ReadObject_Protected_Virtual_New_Object_XmlTypeMapping_Boolean_Boolean_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_ReadClassInstance_Protected_Virtual_New_Object_XmlTypeMapping_Boolean_Boolean_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_ReadClassInstanceMembers_Protected_Virtual_New_Void_XmlTypeMapping_Object_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeMembers_Private_Void_ClassMap_Object_Boolean_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_ReadMembers_Private_Void_ClassMap_Object_Boolean_Boolean_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_SetListMembersDefaults_Private_Void_ClassMap_Object_Boolean_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_FixupMembers_Internal_Void_ClassMap_Object_Boolean_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_ProcessUnknownAttribute_Protected_Virtual_New_Void_Object_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_ProcessUnknownElement_Protected_Virtual_New_Void_Object_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_IsReadOnly_Private_Boolean_XmlTypeMapMember_TypeData_Object_Boolean_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_SetMemberValue_Private_Void_XmlTypeMapMember_Object_Object_Boolean_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_SetMemberValueFromAttr_Private_Void_XmlTypeMapMember_Object_Object_Boolean_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectElement_Private_Object_XmlTypeMapElementInfo_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_ReadPrimitiveValue_Private_Object_XmlTypeMapElementInfo_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromXmlString_Private_Object_String_TypeData_XmlTypeMapping_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_ReadListElement_Private_Object_XmlTypeMapping_Boolean_Object_Boolean_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_ReadListString_Private_Object_XmlTypeMapping_String_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_AddListValue_Private_Void_TypeData_byref_Object_Int32_Object_Boolean_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_Object_Type_Boolean_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Object_Type_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_CreateList_Private_Object_Type_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_InitializeList_Private_Object_TypeData_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_FillList_Private_Void_Object_Object_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_CopyEnumerableList_Private_Void_Object_Object_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlNodeElement_Private_Object_XmlTypeMapping_Boolean_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlNode_Private_Object_TypeData_Boolean_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_ReadPrimitiveElement_Private_Object_XmlTypeMapping_Boolean_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_ReadEnumElement_Private_Object_XmlTypeMapping_Boolean_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumValue_Private_Object_XmlTypeMapping_String_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlSerializableElement_Private_Object_XmlTypeMapping_Boolean_0;

		// Token: 0x0200024E RID: 590
		public class FixupCallbackInfo : Object
		{
			// Token: 0x06003108 RID: 12552 RVA: 0x000DBE14 File Offset: 0x000DA014
			// Note: this type is marked as 'beforefieldinit'.
			static FixupCallbackInfo()
			{
				Il2CppClassPointerStore<XmlSerializationReaderInterpreter.FixupCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, "FixupCallbackInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.FixupCallbackInfo>.NativeClassPtr);
				XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__sri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.FixupCallbackInfo>.NativeClassPtr, "_sri");
				XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.FixupCallbackInfo>.NativeClassPtr, "_map");
				XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__isValueList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.FixupCallbackInfo>.NativeClassPtr, "_isValueList");
				XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationReaderInterpreter_ClassMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.FixupCallbackInfo>.NativeClassPtr, 100666677);
				XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeMethodInfoPtr_FixupMembers_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.FixupCallbackInfo>.NativeClassPtr, 100666678);
			}

			// Token: 0x06003109 RID: 12553 RVA: 0x000DBEA4 File Offset: 0x000DA0A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387791, XrefRangeEnd = 387794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FixupCallbackInfo(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.FixupCallbackInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationReaderInterpreter_ClassMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600310A RID: 12554 RVA: 0x000DBF10 File Offset: 0x000DA110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387794, XrefRangeEnd = 387795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FixupMembers(Object fixup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeMethodInfoPtr_FixupMembers_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600310B RID: 12555 RVA: 0x00014B25 File Offset: 0x00012D25
			public FixupCallbackInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001083 RID: 4227
			// (get) Token: 0x0600310C RID: 12556 RVA: 0x000DBF54 File Offset: 0x000DA154
			// (set) Token: 0x0600310D RID: 12557 RVA: 0x00014B2E File Offset: 0x00012D2E
			public unsafe XmlSerializationReaderInterpreter _sri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__sri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializationReaderInterpreter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__sri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001084 RID: 4228
			// (get) Token: 0x0600310E RID: 12558 RVA: 0x000DBF84 File Offset: 0x000DA184
			// (set) Token: 0x0600310F RID: 12559 RVA: 0x00014B4D File Offset: 0x00012D4D
			public unsafe ClassMap _map
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__map);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClassMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__map), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001085 RID: 4229
			// (get) Token: 0x06003110 RID: 12560 RVA: 0x000DBFB4 File Offset: 0x000DA1B4
			// (set) Token: 0x06003111 RID: 12561 RVA: 0x00014B6C File Offset: 0x00012D6C
			public unsafe bool _isValueList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__isValueList);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.FixupCallbackInfo.NativeFieldInfoPtr__isValueList)) = value;
				}
			}

			// Token: 0x04002601 RID: 9729
			private static readonly IntPtr NativeFieldInfoPtr__sri;

			// Token: 0x04002602 RID: 9730
			private static readonly IntPtr NativeFieldInfoPtr__map;

			// Token: 0x04002603 RID: 9731
			private static readonly IntPtr NativeFieldInfoPtr__isValueList;

			// Token: 0x04002604 RID: 9732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationReaderInterpreter_ClassMap_Boolean_0;

			// Token: 0x04002605 RID: 9733
			private static readonly IntPtr NativeMethodInfoPtr_FixupMembers_Public_Void_Object_0;
		}

		// Token: 0x0200024F RID: 591
		public class ReaderCallbackInfo : Object
		{
			// Token: 0x06003112 RID: 12562 RVA: 0x000DBFDC File Offset: 0x000DA1DC
			// Note: this type is marked as 'beforefieldinit'.
			static ReaderCallbackInfo()
			{
				Il2CppClassPointerStore<XmlSerializationReaderInterpreter.ReaderCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationReaderInterpreter>.NativeClassPtr, "ReaderCallbackInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.ReaderCallbackInfo>.NativeClassPtr);
				XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeFieldInfoPtr__sri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.ReaderCallbackInfo>.NativeClassPtr, "_sri");
				XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeFieldInfoPtr__typeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.ReaderCallbackInfo>.NativeClassPtr, "_typeMap");
				XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationReaderInterpreter_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.ReaderCallbackInfo>.NativeClassPtr, 100666679);
				XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeMethodInfoPtr_ReadObject_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.ReaderCallbackInfo>.NativeClassPtr, 100666680);
			}

			// Token: 0x06003113 RID: 12563 RVA: 0x000DC058 File Offset: 0x000DA258
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReaderCallbackInfo(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReaderInterpreter.ReaderCallbackInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationReaderInterpreter_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003114 RID: 12564 RVA: 0x000DC0B8 File Offset: 0x000DA2B8
			[CallerCount(0)]
			public unsafe Object ReadObject()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeMethodInfoPtr_ReadObject_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06003115 RID: 12565 RVA: 0x00014B87 File Offset: 0x00012D87
			public ReaderCallbackInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001086 RID: 4230
			// (get) Token: 0x06003116 RID: 12566 RVA: 0x000DC0F8 File Offset: 0x000DA2F8
			// (set) Token: 0x06003117 RID: 12567 RVA: 0x00014B90 File Offset: 0x00012D90
			public unsafe XmlSerializationReaderInterpreter _sri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeFieldInfoPtr__sri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializationReaderInterpreter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeFieldInfoPtr__sri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001087 RID: 4231
			// (get) Token: 0x06003118 RID: 12568 RVA: 0x000DC128 File Offset: 0x000DA328
			// (set) Token: 0x06003119 RID: 12569 RVA: 0x00014BAF File Offset: 0x00012DAF
			public unsafe XmlTypeMapping _typeMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeFieldInfoPtr__typeMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReaderInterpreter.ReaderCallbackInfo.NativeFieldInfoPtr__typeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002606 RID: 9734
			private static readonly IntPtr NativeFieldInfoPtr__sri;

			// Token: 0x04002607 RID: 9735
			private static readonly IntPtr NativeFieldInfoPtr__typeMap;

			// Token: 0x04002608 RID: 9736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationReaderInterpreter_XmlTypeMapping_0;

			// Token: 0x04002609 RID: 9737
			private static readonly IntPtr NativeMethodInfoPtr_ReadObject_Internal_Object_0;
		}
	}
}
