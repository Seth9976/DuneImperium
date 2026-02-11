using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E9 RID: 233
	public class XmlSerializationWriterInterpreter : XmlSerializationWriter
	{
		// Token: 0x06001589 RID: 5513 RVA: 0x0007351C File Offset: 0x0007171C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationWriterInterpreter()
		{
			Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationWriterInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr);
			XmlSerializationWriterInterpreter.NativeFieldInfoPtr__typeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, "_typeMap");
			XmlSerializationWriterInterpreter.NativeFieldInfoPtr__format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, "_format");
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666734);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666735);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteRoot_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666736);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObject_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666737);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMessage_Protected_Virtual_New_Void_XmlMembersMapping_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666738);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666739);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElementAttributes_Protected_Virtual_New_Void_XmlTypeMapping_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666740);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElementElements_Protected_Virtual_New_Void_XmlTypeMapping_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666741);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMembers_Private_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666742);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteAttributeMembers_Private_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666743);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteElementMembers_Private_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666744);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666745);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_MemberHasValue_Private_Boolean_XmlTypeMapMember_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666746);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMemberElement_Private_Void_XmlTypeMapElementInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666747);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_ImplicitConvert_Internal_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666748);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveValueLiteral_Private_Void_Object_String_String_XmlTypeMapping_TypeData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666749);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveValueEncoded_Private_Void_Object_String_String_XmlQualifiedName_XmlTypeMapping_TypeData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666750);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteListElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666751);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteListContent_Private_Void_Object_TypeData_ListMap_Object_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666752);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetListCount_Private_Int32_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666753);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteAnyElementContent_Private_Void_XmlTypeMapMemberAnyElement_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666754);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666755);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteEnumElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666756);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetStringValue_Private_String_XmlTypeMapping_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666757);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetEnumXmlValue_Private_String_XmlTypeMapping_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666758);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00073768 File Offset: 0x00071968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388785, XrefRangeEnd = 388787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationWriterInterpreter(XmlMapping typeMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x000737B4 File Offset: 0x000719B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388787, XrefRangeEnd = 388821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x000737F0 File Offset: 0x000719F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388844, RefRangeEnd = 388845, XrefRangeStart = 388821, XrefRangeEnd = 388844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRoot(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteRoot_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00073834 File Offset: 0x00071A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388845, XrefRangeEnd = 388918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteObject(XmlTypeMapping typeMap, Object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeWrappingElem;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObject_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000738E4 File Offset: 0x00071AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388918, XrefRangeEnd = 388941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteMessage(XmlMembersMapping membersMap, Il2CppReferenceArray<Object> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(membersMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMessage_Protected_Virtual_New_Void_XmlMembersMapping_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00073944 File Offset: 0x00071B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388941, XrefRangeEnd = 388950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteObjectElement(XmlTypeMapping typeMap, Object ob, string element, string namesp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000739C8 File Offset: 0x00071BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388950, XrefRangeEnd = 388953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, Object ob)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElementAttributes_Protected_Virtual_New_Void_XmlTypeMapping_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00073A28 File Offset: 0x00071C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388953, XrefRangeEnd = 388956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteObjectElementElements(XmlTypeMapping typeMap, Object ob)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElementElements_Protected_Virtual_New_Void_XmlTypeMapping_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00073A88 File Offset: 0x00071C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388956, XrefRangeEnd = 388958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMembers(ClassMap map, Object ob, bool isValueList)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMembers_Private_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00073AEC File Offset: 0x00071CEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389007, RefRangeEnd = 389010, XrefRangeStart = 388958, XrefRangeEnd = 389007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAttributeMembers(ClassMap map, Object ob, bool isValueList)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteAttributeMembers_Private_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00073B50 File Offset: 0x00071D50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389077, RefRangeEnd = 389080, XrefRangeStart = 389010, XrefRangeEnd = 389077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementMembers(ClassMap map, Object ob, bool isValueList)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteElementMembers_Private_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00073BB4 File Offset: 0x00071DB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389086, RefRangeEnd = 389089, XrefRangeStart = 389080, XrefRangeEnd = 389086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00073C24 File Offset: 0x00071E24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389097, RefRangeEnd = 389100, XrefRangeStart = 389089, XrefRangeEnd = 389097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MemberHasValue(XmlTypeMapMember member, Object ob, bool isValueList)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_MemberHasValue_Private_Boolean_XmlTypeMapMember_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00073C94 File Offset: 0x00071E94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 389123, RefRangeEnd = 389128, XrefRangeStart = 389100, XrefRangeEnd = 389123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberElement(XmlTypeMapElementInfo elem, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMemberElement_Private_Void_XmlTypeMapElementInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00073CE8 File Offset: 0x00071EE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389169, RefRangeEnd = 389171, XrefRangeStart = 389128, XrefRangeEnd = 389169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ImplicitConvert(Object obj, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_ImplicitConvert_Internal_Static_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00073D40 File Offset: 0x00071F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389181, RefRangeEnd = 389182, XrefRangeStart = 389171, XrefRangeEnd = 389181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WritePrimitiveValueLiteral(Object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mappedType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapped;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveValueLiteral_Private_Void_Object_String_String_XmlTypeMapping_TypeData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00073DE8 File Offset: 0x00071FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389192, RefRangeEnd = 389193, XrefRangeStart = 389182, XrefRangeEnd = 389192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WritePrimitiveValueEncoded(Object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsiType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mappedType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapped;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveValueEncoded_Private_Void_Object_String_String_XmlQualifiedName_XmlTypeMapping_TypeData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00073EA4 File Offset: 0x000720A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389193, XrefRangeEnd = 389224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteListElement(XmlTypeMapping typeMap, Object ob, string element, string namesp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteListElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00073F28 File Offset: 0x00072128
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389300, RefRangeEnd = 389303, XrefRangeStart = 389224, XrefRangeEnd = 389300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteListContent(Object container, TypeData listType, ListMap map, Object ob, StringBuilder targetString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteListContent_Private_Void_Object_TypeData_ListMap_Object_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00073FB4 File Offset: 0x000721B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389303, XrefRangeEnd = 389311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetListCount(TypeData listType, Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetListCount_Private_Int32_TypeData_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00074014 File Offset: 0x00072214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389361, RefRangeEnd = 389362, XrefRangeStart = 389311, XrefRangeEnd = 389361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteAnyElementContent_Private_Void_XmlTypeMapMemberAnyElement_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00074068 File Offset: 0x00072268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389362, XrefRangeEnd = 389364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WritePrimitiveElement(XmlTypeMapping typeMap, Object ob, string element, string namesp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000740EC File Offset: 0x000722EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389364, XrefRangeEnd = 389370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteEnumElement(XmlTypeMapping typeMap, Object ob, string element, string namesp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteEnumElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00074170 File Offset: 0x00072370
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 389384, RefRangeEnd = 389391, XrefRangeStart = 389370, XrefRangeEnd = 389384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringValue(XmlTypeMapping typeMap, TypeData type, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetStringValue_Private_String_XmlTypeMapping_TypeData_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x000741DC File Offset: 0x000723DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389391, XrefRangeEnd = 389394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEnumXmlValue(XmlTypeMapping typeMap, Object ob)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetEnumXmlValue_Private_String_XmlTypeMapping_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0000924F File Offset: 0x0000744F
		public XmlSerializationWriterInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00074238 File Offset: 0x00072438
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x00009258 File Offset: 0x00007458
		public unsafe XmlMapping _typeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.NativeFieldInfoPtr__typeMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.NativeFieldInfoPtr__typeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00074268 File Offset: 0x00072468
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x00009277 File Offset: 0x00007477
		public unsafe SerializationFormat _format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.NativeFieldInfoPtr__format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.NativeFieldInfoPtr__format)) = value;
			}
		}

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeFieldInfoPtr__typeMap;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeFieldInfoPtr__format;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_WriteRoot_Public_Void_Object_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_WriteObject_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_Boolean_Boolean_Boolean_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Protected_Virtual_New_Void_XmlMembersMapping_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectElementAttributes_Protected_Virtual_New_Void_XmlTypeMapping_Object_0;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectElementElements_Protected_Virtual_New_Void_XmlTypeMapping_Object_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr_WriteMembers_Private_Void_ClassMap_Object_Boolean_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_WriteAttributeMembers_Private_Void_ClassMap_Object_Boolean_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementMembers_Private_Void_ClassMap_Object_Boolean_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_MemberHasValue_Private_Boolean_XmlTypeMapMember_Object_Boolean_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberElement_Private_Void_XmlTypeMapElementInfo_Object_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr_ImplicitConvert_Internal_Static_Object_Object_Type_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_WritePrimitiveValueLiteral_Private_Void_Object_String_String_XmlTypeMapping_TypeData_Boolean_Boolean_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_WritePrimitiveValueEncoded_Private_Void_Object_String_String_XmlQualifiedName_XmlTypeMapping_TypeData_Boolean_Boolean_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_WriteListElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_WriteListContent_Private_Void_Object_TypeData_ListMap_Object_StringBuilder_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_GetListCount_Private_Int32_TypeData_Object_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_WriteAnyElementContent_Private_Void_XmlTypeMapMemberAnyElement_Object_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_WritePrimitiveElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_WriteEnumElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Private_String_XmlTypeMapping_TypeData_Object_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumXmlValue_Private_String_XmlTypeMapping_Object_0;

		// Token: 0x02000251 RID: 593
		public class CallbackInfo : Object
		{
			// Token: 0x06003125 RID: 12581 RVA: 0x000DC2D4 File Offset: 0x000DA4D4
			// Note: this type is marked as 'beforefieldinit'.
			static CallbackInfo()
			{
				Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, "CallbackInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr);
				XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__swi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, "_swi");
				XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__typeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, "_typeMap");
				XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationWriterInterpreter_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, 100666759);
				XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr_WriteObject_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, 100666760);
				XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr_WriteEnum_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, 100666761);
			}

			// Token: 0x06003126 RID: 12582 RVA: 0x000DC364 File Offset: 0x000DA564
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallbackInfo(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(swi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationWriterInterpreter_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003127 RID: 12583 RVA: 0x000DC3C4 File Offset: 0x000DA5C4
			[CallerCount(0)]
			public unsafe void WriteObject(Object ob)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr_WriteObject_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003128 RID: 12584 RVA: 0x000DC408 File Offset: 0x000DA608
			[CallerCount(0)]
			public unsafe void WriteEnum(Object ob)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr_WriteEnum_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003129 RID: 12585 RVA: 0x00014C53 File Offset: 0x00012E53
			public CallbackInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700108C RID: 4236
			// (get) Token: 0x0600312A RID: 12586 RVA: 0x000DC44C File Offset: 0x000DA64C
			// (set) Token: 0x0600312B RID: 12587 RVA: 0x00014C5C File Offset: 0x00012E5C
			public unsafe XmlSerializationWriterInterpreter _swi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__swi);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriterInterpreter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__swi), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108D RID: 4237
			// (get) Token: 0x0600312C RID: 12588 RVA: 0x000DC47C File Offset: 0x000DA67C
			// (set) Token: 0x0600312D RID: 12589 RVA: 0x00014C7B File Offset: 0x00012E7B
			public unsafe XmlTypeMapping _typeMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__typeMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__typeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400260F RID: 9743
			private static readonly IntPtr NativeFieldInfoPtr__swi;

			// Token: 0x04002610 RID: 9744
			private static readonly IntPtr NativeFieldInfoPtr__typeMap;

			// Token: 0x04002611 RID: 9745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationWriterInterpreter_XmlTypeMapping_0;

			// Token: 0x04002612 RID: 9746
			private static readonly IntPtr NativeMethodInfoPtr_WriteObject_Internal_Void_Object_0;

			// Token: 0x04002613 RID: 9747
			private static readonly IntPtr NativeMethodInfoPtr_WriteEnum_Internal_Void_Object_0;
		}
	}
}
