using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E5 RID: 229
	public class XmlSerializationReader : XmlSerializationGeneratedCode
	{
		// Token: 0x060014A7 RID: 5287 RVA: 0x0006EF1C File Offset: 0x0006D11C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationReader()
		{
			Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr);
			XmlSerializationReader.NativeFieldInfoPtr_document = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "document");
			XmlSerializationReader.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "reader");
			XmlSerializationReader.NativeFieldInfoPtr_fixups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "fixups");
			XmlSerializationReader.NativeFieldInfoPtr_collFixups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "collFixups");
			XmlSerializationReader.NativeFieldInfoPtr_collItemFixups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "collItemFixups");
			XmlSerializationReader.NativeFieldInfoPtr_typesCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "typesCallbacks");
			XmlSerializationReader.NativeFieldInfoPtr_noIDTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "noIDTargets");
			XmlSerializationReader.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "targets");
			XmlSerializationReader.NativeFieldInfoPtr_delayedListFixups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "delayedListFixups");
			XmlSerializationReader.NativeFieldInfoPtr_eventSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "eventSource");
			XmlSerializationReader.NativeFieldInfoPtr_delayedFixupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "delayedFixupId");
			XmlSerializationReader.NativeFieldInfoPtr_referencedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "referencedObjects");
			XmlSerializationReader.NativeFieldInfoPtr_readCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "readCount");
			XmlSerializationReader.NativeFieldInfoPtr_whileIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "whileIterationCount");
			XmlSerializationReader.NativeFieldInfoPtr_w3SchemaNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "w3SchemaNS");
			XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "w3InstanceNS");
			XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS2000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "w3InstanceNS2000");
			XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS1999 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "w3InstanceNS1999");
			XmlSerializationReader.NativeFieldInfoPtr_soapNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "soapNS");
			XmlSerializationReader.NativeFieldInfoPtr_wsdlNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "wsdlNS");
			XmlSerializationReader.NativeFieldInfoPtr_nullX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "nullX");
			XmlSerializationReader.NativeFieldInfoPtr_nil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "nil");
			XmlSerializationReader.NativeFieldInfoPtr_typeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "typeX");
			XmlSerializationReader.NativeFieldInfoPtr_arrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "arrayType");
			XmlSerializationReader.NativeFieldInfoPtr_arrayQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "arrayQName");
			XmlSerializationReader.NativeMethodInfoPtr_Initialize_Internal_Void_XmlReader_XmlSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666572);
			XmlSerializationReader.NativeMethodInfoPtr_EnsureArrayList_Private_ArrayList_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666573);
			XmlSerializationReader.NativeMethodInfoPtr_EnsureHashtable_Private_Hashtable_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666574);
			XmlSerializationReader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666575);
			XmlSerializationReader.NativeMethodInfoPtr_get_Document_Protected_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666576);
			XmlSerializationReader.NativeMethodInfoPtr_get_Reader_Protected_get_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666577);
			XmlSerializationReader.NativeMethodInfoPtr_AddFixup_Protected_Void_CollectionFixup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666578);
			XmlSerializationReader.NativeMethodInfoPtr_AddFixup_Protected_Void_Fixup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666579);
			XmlSerializationReader.NativeMethodInfoPtr_AddFixup_Private_Void_CollectionItemFixup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666580);
			XmlSerializationReader.NativeMethodInfoPtr_AddReadCallback_Protected_Void_String_String_Type_XmlSerializationReadCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666581);
			XmlSerializationReader.NativeMethodInfoPtr_AddTarget_Protected_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666582);
			XmlSerializationReader.NativeMethodInfoPtr_CurrentTag_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666583);
			XmlSerializationReader.NativeMethodInfoPtr_CreateReadOnlyCollectionException_Protected_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666584);
			XmlSerializationReader.NativeMethodInfoPtr_CreateUnknownConstantException_Protected_Exception_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666585);
			XmlSerializationReader.NativeMethodInfoPtr_CreateUnknownNodeException_Protected_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666586);
			XmlSerializationReader.NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666587);
			XmlSerializationReader.NativeMethodInfoPtr_EnsureArrayIndex_Protected_Array_Array_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666588);
			XmlSerializationReader.NativeMethodInfoPtr_GetNullAttr_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666589);
			XmlSerializationReader.NativeMethodInfoPtr_GetTarget_Protected_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666590);
			XmlSerializationReader.NativeMethodInfoPtr_TargetReady_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666591);
			XmlSerializationReader.NativeMethodInfoPtr_GetXsiType_Protected_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666592);
			XmlSerializationReader.NativeMethodInfoPtr_InitCallbacks_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666593);
			XmlSerializationReader.NativeMethodInfoPtr_InitIDs_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666594);
			XmlSerializationReader.NativeMethodInfoPtr_IsXmlnsAttribute_Protected_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666595);
			XmlSerializationReader.NativeMethodInfoPtr_ParseWsdlArrayType_Protected_Void_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666596);
			XmlSerializationReader.NativeMethodInfoPtr_ReadElementQualifiedName_Protected_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666597);
			XmlSerializationReader.NativeMethodInfoPtr_ReadEndElement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666598);
			XmlSerializationReader.NativeMethodInfoPtr_ReadNull_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666599);
			XmlSerializationReader.NativeMethodInfoPtr_ReadNullableQualifiedName_Protected_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666600);
			XmlSerializationReader.NativeMethodInfoPtr_ReadNullableString_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666601);
			XmlSerializationReader.NativeMethodInfoPtr_ReadReferencedElement_Protected_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666602);
			XmlSerializationReader.NativeMethodInfoPtr_GetCallbackInfo_Private_WriteCallbackInfo_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666603);
			XmlSerializationReader.NativeMethodInfoPtr_ReadReferencedElement_Protected_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666604);
			XmlSerializationReader.NativeMethodInfoPtr_ReadList_Private_Boolean_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666605);
			XmlSerializationReader.NativeMethodInfoPtr_ReadReferencedElements_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666606);
			XmlSerializationReader.NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666607);
			XmlSerializationReader.NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666608);
			XmlSerializationReader.NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_String_String_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666609);
			XmlSerializationReader.NativeMethodInfoPtr_ReadSerializable_Protected_IXmlSerializable_IXmlSerializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666610);
			XmlSerializationReader.NativeMethodInfoPtr_ReadTypedPrimitive_Protected_Object_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666611);
			XmlSerializationReader.NativeMethodInfoPtr_ReadTypedPrimitive_Private_Object_XmlQualifiedName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666612);
			XmlSerializationReader.NativeMethodInfoPtr_ReadXmlNode_Protected_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666613);
			XmlSerializationReader.NativeMethodInfoPtr_ReadXmlDocument_Protected_XmlDocument_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666614);
			XmlSerializationReader.NativeMethodInfoPtr_ShrinkArray_Protected_Array_Array_Int32_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666615);
			XmlSerializationReader.NativeMethodInfoPtr_ToXmlQualifiedName_Protected_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666616);
			XmlSerializationReader.NativeMethodInfoPtr_UnknownAttribute_Protected_Void_Object_XmlAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666617);
			XmlSerializationReader.NativeMethodInfoPtr_UnknownElement_Protected_Void_Object_XmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666618);
			XmlSerializationReader.NativeMethodInfoPtr_UnknownNode_Protected_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666619);
			XmlSerializationReader.NativeMethodInfoPtr_UnknownNode_Protected_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666620);
			XmlSerializationReader.NativeMethodInfoPtr_OnUnknownNode_Private_Void_XmlNode_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666621);
			XmlSerializationReader.NativeMethodInfoPtr_UnreferencedObject_Protected_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, 100666622);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0006F53C File Offset: 0x0006D73C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387236, RefRangeEnd = 387238, XrefRangeStart = 387196, XrefRangeEnd = 387236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(XmlReader reader, XmlSerializer eventSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_Initialize_Internal_Void_XmlReader_XmlSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0006F590 File Offset: 0x0006D790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387238, XrefRangeEnd = 387242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList EnsureArrayList(ArrayList list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_EnsureArrayList_Private_ArrayList_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0006F5E0 File Offset: 0x0006D7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387242, XrefRangeEnd = 387246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable EnsureHashtable(Hashtable hash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hash);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_EnsureHashtable_Private_Hashtable_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0006F630 File Offset: 0x0006D830
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0006F66C File Offset: 0x0006D86C
		public unsafe XmlDocument Document
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 387251, RefRangeEnd = 387261, XrefRangeStart = 387246, XrefRangeEnd = 387251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_get_Document_Protected_get_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0006F6AC File Offset: 0x0006D8AC
		public unsafe XmlReader Reader
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_get_Reader_Protected_get_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0006F6EC File Offset: 0x0006D8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387261, XrefRangeEnd = 387267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFixup(XmlSerializationReader.CollectionFixup fixup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_AddFixup_Protected_Void_CollectionFixup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0006F730 File Offset: 0x0006D930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387267, XrefRangeEnd = 387273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFixup(XmlSerializationReader.Fixup fixup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_AddFixup_Protected_Void_Fixup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0006F774 File Offset: 0x0006D974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387279, RefRangeEnd = 387280, XrefRangeStart = 387273, XrefRangeEnd = 387279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFixup(XmlSerializationReader.CollectionItemFixup fixup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_AddFixup_Private_Void_CollectionItemFixup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0006F7B8 File Offset: 0x0006D9B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387298, RefRangeEnd = 387299, XrefRangeStart = 387280, XrefRangeEnd = 387298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(read);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_AddReadCallback_Protected_Void_String_String_Type_XmlSerializationReadCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0006F834 File Offset: 0x0006DA34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387304, RefRangeEnd = 387305, XrefRangeStart = 387299, XrefRangeEnd = 387304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTarget(string id, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_AddTarget_Protected_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0006F888 File Offset: 0x0006DA88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387314, RefRangeEnd = 387316, XrefRangeStart = 387305, XrefRangeEnd = 387314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CurrentTag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_CurrentTag_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0006F8C0 File Offset: 0x0006DAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387316, XrefRangeEnd = 387323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateReadOnlyCollectionException(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_CreateReadOnlyCollectionException_Protected_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0006F910 File Offset: 0x0006DB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387323, XrefRangeEnd = 387330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateUnknownConstantException(string value, Type enumType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_CreateUnknownConstantException_Protected_Exception_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0006F974 File Offset: 0x0006DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387330, XrefRangeEnd = 387338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateUnknownNodeException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_CreateUnknownNodeException_Protected_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0006F9B4 File Offset: 0x0006DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387338, XrefRangeEnd = 387359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateUnknownTypeException(XmlQualifiedName type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0006FA04 File Offset: 0x0006DC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387359, XrefRangeEnd = 387363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array EnsureArrayIndex(Array a, int index, Type elementType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_EnsureArrayIndex_Protected_Array_Array_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0006FA74 File Offset: 0x0006DC74
		[CallerCount(0)]
		public unsafe bool GetNullAttr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_GetNullAttr_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0006FAB0 File Offset: 0x0006DCB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387368, RefRangeEnd = 387371, XrefRangeStart = 387363, XrefRangeEnd = 387368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetTarget(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_GetTarget_Protected_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0006FB00 File Offset: 0x0006DD00
		[CallerCount(0)]
		public unsafe bool TargetReady(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_TargetReady_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0006FB50 File Offset: 0x0006DD50
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 387390, RefRangeEnd = 387395, XrefRangeStart = 387371, XrefRangeEnd = 387390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName GetXsiType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_GetXsiType_Protected_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0006FB90 File Offset: 0x0006DD90
		[CallerCount(0)]
		public unsafe virtual void InitCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReader.NativeMethodInfoPtr_InitCallbacks_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0006FBCC File Offset: 0x0006DDCC
		[CallerCount(0)]
		public unsafe virtual void InitIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationReader.NativeMethodInfoPtr_InitIDs_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0006FC08 File Offset: 0x0006DE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387401, RefRangeEnd = 387402, XrefRangeStart = 387395, XrefRangeEnd = 387401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXmlnsAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_IsXmlnsAttribute_Protected_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0006FC58 File Offset: 0x0006DE58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387417, RefRangeEnd = 387418, XrefRangeStart = 387402, XrefRangeEnd = 387417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseWsdlArrayType(XmlAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ParseWsdlArrayType_Protected_Void_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0006FC9C File Offset: 0x0006DE9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387420, RefRangeEnd = 387422, XrefRangeStart = 387418, XrefRangeEnd = 387420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName ReadElementQualifiedName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadElementQualifiedName_Protected_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0006FCDC File Offset: 0x0006DEDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387424, RefRangeEnd = 387427, XrefRangeStart = 387422, XrefRangeEnd = 387424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadEndElement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0006FD10 File Offset: 0x0006DF10
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 387431, RefRangeEnd = 387439, XrefRangeStart = 387427, XrefRangeEnd = 387431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadNull_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0006FD4C File Offset: 0x0006DF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387439, XrefRangeEnd = 387441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName ReadNullableQualifiedName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadNullableQualifiedName_Protected_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0006FD8C File Offset: 0x0006DF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387441, XrefRangeEnd = 387442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadNullableString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadNullableString_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0006FDC4 File Offset: 0x0006DFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387444, RefRangeEnd = 387445, XrefRangeStart = 387442, XrefRangeEnd = 387444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadReferencedElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadReferencedElement_Protected_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0006FE04 File Offset: 0x0006E004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387452, RefRangeEnd = 387454, XrefRangeStart = 387445, XrefRangeEnd = 387452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_GetCallbackInfo_Private_WriteCallbackInfo_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationReader.WriteCallbackInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0006FE54 File Offset: 0x0006E054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387483, RefRangeEnd = 387485, XrefRangeStart = 387454, XrefRangeEnd = 387483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadReferencedElement(string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadReferencedElement_Protected_Object_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0006FEB8 File Offset: 0x0006E0B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387533, RefRangeEnd = 387535, XrefRangeStart = 387485, XrefRangeEnd = 387533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadList(out Object resultList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadList_Private_Boolean_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				resultList = ((intPtr4 == 0) ? null : new Object(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0006FF18 File Offset: 0x0006E118
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387637, RefRangeEnd = 387639, XrefRangeStart = 387535, XrefRangeEnd = 387637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadReferencedElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadReferencedElements_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0006FF4C File Offset: 0x0006E14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387639, XrefRangeEnd = 387640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadReferencingElement(out string fixupReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				fixupReference = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0006FFA8 File Offset: 0x0006E1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387640, XrefRangeEnd = 387641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadReferencingElement(string name, string ns, out string fixupReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			fixupReference = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00070028 File Offset: 0x0006E228
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 387658, RefRangeEnd = 387661, XrefRangeStart = 387641, XrefRangeEnd = 387658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementCanBeType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_String_String_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			fixupReference = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000700B4 File Offset: 0x0006E2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387661, XrefRangeEnd = 387667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IXmlSerializable ReadSerializable(IXmlSerializable serializable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadSerializable_Protected_IXmlSerializable_IXmlSerializable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSerializable>(intPtr3) : null;
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00070104 File Offset: 0x0006E304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387667, XrefRangeEnd = 387668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadTypedPrimitive(XmlQualifiedName type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadTypedPrimitive_Protected_Object_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00070154 File Offset: 0x0006E354
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 387703, RefRangeEnd = 387708, XrefRangeStart = 387668, XrefRangeEnd = 387703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reportUnknown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadTypedPrimitive_Private_Object_XmlQualifiedName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000701B4 File Offset: 0x0006E3B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387709, RefRangeEnd = 387710, XrefRangeStart = 387708, XrefRangeEnd = 387709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode ReadXmlNode(bool wrapped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wrapped;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadXmlNode_Protected_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00070200 File Offset: 0x0006E400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387710, XrefRangeEnd = 387714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocument ReadXmlDocument(bool wrapped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wrapped;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ReadXmlDocument_Protected_XmlDocument_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0007024C File Offset: 0x0006E44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387714, XrefRangeEnd = 387717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array ShrinkArray(Array a, int length, Type elementType, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ShrinkArray_Protected_Array_Array_Int32_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000702CC File Offset: 0x0006E4CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 387731, RefRangeEnd = 387733, XrefRangeStart = 387717, XrefRangeEnd = 387731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName ToXmlQualifiedName(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_ToXmlQualifiedName_Protected_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0007031C File Offset: 0x0006E51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387733, XrefRangeEnd = 387743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnknownAttribute(Object o, XmlAttribute attr, string qnames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(qnames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_UnknownAttribute_Protected_Void_Object_XmlAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00070384 File Offset: 0x0006E584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387743, XrefRangeEnd = 387753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnknownElement(Object o, XmlElement elem, string qnames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elem);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(qnames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_UnknownElement_Protected_Void_Object_XmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000703EC File Offset: 0x0006E5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387753, XrefRangeEnd = 387755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnknownNode(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_UnknownNode_Protected_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00070430 File Offset: 0x0006E630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387755, XrefRangeEnd = 387757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnknownNode(Object o, string qnames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(qnames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_UnknownNode_Protected_Void_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00070484 File Offset: 0x0006E684
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 387778, RefRangeEnd = 387786, XrefRangeStart = 387757, XrefRangeEnd = 387778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUnknownNode(XmlNode node, Object o, string qnames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(qnames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_OnUnknownNode_Private_Void_XmlNode_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000704EC File Offset: 0x0006E6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387790, RefRangeEnd = 387791, XrefRangeStart = 387786, XrefRangeEnd = 387790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnreferencedObject(string id, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.NativeMethodInfoPtr_UnreferencedObject_Protected_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00008DBB File Offset: 0x00006FBB
		public XmlSerializationReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x00070540 File Offset: 0x0006E740
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x00008DC4 File Offset: 0x00006FC4
		public unsafe XmlDocument document
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_document);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_document), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x00070570 File Offset: 0x0006E770
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x00008DE3 File Offset: 0x00006FE3
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x000705A0 File Offset: 0x0006E7A0
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x00008E02 File Offset: 0x00007002
		public unsafe ArrayList fixups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_fixups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_fixups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x000705D0 File Offset: 0x0006E7D0
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x00008E21 File Offset: 0x00007021
		public unsafe Hashtable collFixups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_collFixups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_collFixups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x00070600 File Offset: 0x0006E800
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x00008E40 File Offset: 0x00007040
		public unsafe ArrayList collItemFixups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_collItemFixups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_collItemFixups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00070630 File Offset: 0x0006E830
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00008E5F File Offset: 0x0000705F
		public unsafe Hashtable typesCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_typesCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_typesCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x00070660 File Offset: 0x0006E860
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00008E7E File Offset: 0x0000707E
		public unsafe ArrayList noIDTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_noIDTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_noIDTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00070690 File Offset: 0x0006E890
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x00008E9D File Offset: 0x0000709D
		public unsafe Hashtable targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000706C0 File Offset: 0x0006E8C0
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x00008EBC File Offset: 0x000070BC
		public unsafe Hashtable delayedListFixups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_delayedListFixups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_delayedListFixups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x000706F0 File Offset: 0x0006E8F0
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x00008EDB File Offset: 0x000070DB
		public unsafe XmlSerializer eventSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_eventSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_eventSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00070720 File Offset: 0x0006E920
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x00008EFA File Offset: 0x000070FA
		public unsafe int delayedFixupId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_delayedFixupId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_delayedFixupId)) = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00070748 File Offset: 0x0006E948
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x00008F15 File Offset: 0x00007115
		public unsafe Hashtable referencedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_referencedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_referencedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00070778 File Offset: 0x0006E978
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x00008F34 File Offset: 0x00007134
		public unsafe int readCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_readCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_readCount)) = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x000707A0 File Offset: 0x0006E9A0
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00008F4F File Offset: 0x0000714F
		public unsafe int whileIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_whileIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_whileIterationCount)) = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000707C8 File Offset: 0x0006E9C8
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00008F6A File Offset: 0x0000716A
		public unsafe string w3SchemaNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_w3SchemaNS);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_w3SchemaNS), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x000707F0 File Offset: 0x0006E9F0
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x00008F89 File Offset: 0x00007189
		public unsafe string w3InstanceNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00070818 File Offset: 0x0006EA18
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x00008FA8 File Offset: 0x000071A8
		public unsafe string w3InstanceNS2000
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS2000);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS2000), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00070840 File Offset: 0x0006EA40
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x00008FC7 File Offset: 0x000071C7
		public unsafe string w3InstanceNS1999
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS1999);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_w3InstanceNS1999), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00070868 File Offset: 0x0006EA68
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x00008FE6 File Offset: 0x000071E6
		public unsafe string soapNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_soapNS);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_soapNS), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00070890 File Offset: 0x0006EA90
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x00009005 File Offset: 0x00007205
		public unsafe string wsdlNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_wsdlNS);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_wsdlNS), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000708B8 File Offset: 0x0006EAB8
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x00009024 File Offset: 0x00007224
		public unsafe string nullX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_nullX);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_nullX), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000708E0 File Offset: 0x0006EAE0
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x00009043 File Offset: 0x00007243
		public unsafe string nil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_nil);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_nil), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00070908 File Offset: 0x0006EB08
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x00009062 File Offset: 0x00007262
		public unsafe string typeX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_typeX);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_typeX), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x00070930 File Offset: 0x0006EB30
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x00009081 File Offset: 0x00007281
		public unsafe string arrayType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_arrayType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_arrayType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x00070958 File Offset: 0x0006EB58
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x000090A0 File Offset: 0x000072A0
		public unsafe XmlQualifiedName arrayQName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_arrayQName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.NativeFieldInfoPtr_arrayQName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeFieldInfoPtr_document;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeFieldInfoPtr_fixups;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr_collFixups;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_collItemFixups;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_typesCallbacks;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeFieldInfoPtr_noIDTargets;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr_targets;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr_delayedListFixups;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr_eventSource;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeFieldInfoPtr_delayedFixupId;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeFieldInfoPtr_referencedObjects;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr_readCount;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeFieldInfoPtr_whileIterationCount;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeFieldInfoPtr_w3SchemaNS;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeFieldInfoPtr_w3InstanceNS;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeFieldInfoPtr_w3InstanceNS2000;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeFieldInfoPtr_w3InstanceNS1999;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeFieldInfoPtr_soapNS;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_wsdlNS;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeFieldInfoPtr_nullX;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeFieldInfoPtr_nil;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeFieldInfoPtr_typeX;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeFieldInfoPtr_arrayType;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeFieldInfoPtr_arrayQName;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_XmlReader_XmlSerializer_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_EnsureArrayList_Private_ArrayList_ArrayList_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_EnsureHashtable_Private_Hashtable_Hashtable_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Protected_get_XmlDocument_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_get_Reader_Protected_get_XmlReader_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_AddFixup_Protected_Void_CollectionFixup_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_AddFixup_Protected_Void_Fixup_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_AddFixup_Private_Void_CollectionItemFixup_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_AddReadCallback_Protected_Void_String_String_Type_XmlSerializationReadCallback_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_AddTarget_Protected_Void_String_Object_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_CurrentTag_Private_String_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadOnlyCollectionException_Protected_Exception_String_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnknownConstantException_Protected_Exception_String_Type_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnknownNodeException_Protected_Exception_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_XmlQualifiedName_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_EnsureArrayIndex_Protected_Array_Array_Int32_Type_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_GetNullAttr_Protected_Boolean_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_GetTarget_Protected_Object_String_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_TargetReady_Private_Boolean_String_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_GetXsiType_Protected_XmlQualifiedName_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_InitCallbacks_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_InitIDs_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_IsXmlnsAttribute_Protected_Boolean_String_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_ParseWsdlArrayType_Protected_Void_XmlAttribute_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_ReadElementQualifiedName_Protected_XmlQualifiedName_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_ReadEndElement_Protected_Void_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_ReadNull_Protected_Boolean_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_ReadNullableQualifiedName_Protected_XmlQualifiedName_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_ReadNullableString_Protected_String_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_ReadReferencedElement_Protected_Object_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackInfo_Private_WriteCallbackInfo_XmlQualifiedName_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_ReadReferencedElement_Protected_Object_String_String_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_ReadList_Private_Boolean_byref_Object_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_ReadReferencedElements_Protected_Void_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_byref_String_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_String_String_byref_String_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_ReadReferencingElement_Protected_Object_String_String_Boolean_byref_String_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_ReadSerializable_Protected_IXmlSerializable_IXmlSerializable_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_ReadTypedPrimitive_Protected_Object_XmlQualifiedName_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_ReadTypedPrimitive_Private_Object_XmlQualifiedName_Boolean_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlNode_Protected_XmlNode_Boolean_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_ReadXmlDocument_Protected_XmlDocument_Boolean_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_ShrinkArray_Protected_Array_Array_Int32_Type_Boolean_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlQualifiedName_Protected_XmlQualifiedName_String_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_UnknownAttribute_Protected_Void_Object_XmlAttribute_String_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_UnknownElement_Protected_Void_Object_XmlElement_String_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_UnknownNode_Protected_Void_Object_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_UnknownNode_Protected_Void_Object_String_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_OnUnknownNode_Private_Void_XmlNode_Object_String_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_UnreferencedObject_Protected_Void_String_Object_0;

		// Token: 0x0200024A RID: 586
		public class WriteCallbackInfo : Object
		{
			// Token: 0x060030D5 RID: 12501 RVA: 0x000DB46C File Offset: 0x000D966C
			// Note: this type is marked as 'beforefieldinit'.
			static WriteCallbackInfo()
			{
				Il2CppClassPointerStore<XmlSerializationReader.WriteCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "WriteCallbackInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationReader.WriteCallbackInfo>.NativeClassPtr);
				XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.WriteCallbackInfo>.NativeClassPtr, "Type");
				XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_TypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.WriteCallbackInfo>.NativeClassPtr, "TypeName");
				XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_TypeNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.WriteCallbackInfo>.NativeClassPtr, "TypeNs");
				XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.WriteCallbackInfo>.NativeClassPtr, "Callback");
				XmlSerializationReader.WriteCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.WriteCallbackInfo>.NativeClassPtr, 100666623);
			}

			// Token: 0x060030D6 RID: 12502 RVA: 0x000DB4FC File Offset: 0x000D96FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WriteCallbackInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReader.WriteCallbackInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.WriteCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030D7 RID: 12503 RVA: 0x00014953 File Offset: 0x00012B53
			public WriteCallbackInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700106B RID: 4203
			// (get) Token: 0x060030D8 RID: 12504 RVA: 0x000DB538 File Offset: 0x000D9738
			// (set) Token: 0x060030D9 RID: 12505 RVA: 0x0001495C File Offset: 0x00012B5C
			public unsafe Type Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_Type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700106C RID: 4204
			// (get) Token: 0x060030DA RID: 12506 RVA: 0x000DB568 File Offset: 0x000D9768
			// (set) Token: 0x060030DB RID: 12507 RVA: 0x0001497B File Offset: 0x00012B7B
			public unsafe string TypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_TypeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_TypeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700106D RID: 4205
			// (get) Token: 0x060030DC RID: 12508 RVA: 0x000DB590 File Offset: 0x000D9790
			// (set) Token: 0x060030DD RID: 12509 RVA: 0x0001499A File Offset: 0x00012B9A
			public unsafe string TypeNs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_TypeNs);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_TypeNs), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700106E RID: 4206
			// (get) Token: 0x060030DE RID: 12510 RVA: 0x000DB5B8 File Offset: 0x000D97B8
			// (set) Token: 0x060030DF RID: 12511 RVA: 0x000149B9 File Offset: 0x00012BB9
			public unsafe XmlSerializationReadCallback Callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_Callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializationReadCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.WriteCallbackInfo.NativeFieldInfoPtr_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040025E4 RID: 9700
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x040025E5 RID: 9701
			private static readonly IntPtr NativeFieldInfoPtr_TypeName;

			// Token: 0x040025E6 RID: 9702
			private static readonly IntPtr NativeFieldInfoPtr_TypeNs;

			// Token: 0x040025E7 RID: 9703
			private static readonly IntPtr NativeFieldInfoPtr_Callback;

			// Token: 0x040025E8 RID: 9704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200024B RID: 587
		public class CollectionFixup : Object
		{
			// Token: 0x060030E0 RID: 12512 RVA: 0x000DB5E8 File Offset: 0x000D97E8
			// Note: this type is marked as 'beforefieldinit'.
			static CollectionFixup()
			{
				Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "CollectionFixup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr);
				XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, "callback");
				XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, "collection");
				XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_collectionItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, "collectionItems");
				XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, "id");
				XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr__ctor_Internal_Void_Object_XmlSerializationCollectionFixupCallback_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, 100666624);
				XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_get_Callback_Public_get_XmlSerializationCollectionFixupCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, 100666625);
				XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_get_Collection_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, 100666626);
				XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_get_Id_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, 100666627);
				XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_get_CollectionItems_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, 100666628);
				XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_set_CollectionItems_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr, 100666629);
			}

			// Token: 0x060030E1 RID: 12513 RVA: 0x000DB6DC File Offset: 0x000D98DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387185, XrefRangeEnd = 387189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CollectionFixup(Object collection, XmlSerializationCollectionFixupCallback callback, string id)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReader.CollectionFixup>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr__ctor_Internal_Void_Object_XmlSerializationCollectionFixupCallback_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001073 RID: 4211
			// (get) Token: 0x060030E2 RID: 12514 RVA: 0x000DB74C File Offset: 0x000D994C
			public unsafe XmlSerializationCollectionFixupCallback Callback
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_get_Callback_Public_get_XmlSerializationCollectionFixupCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationCollectionFixupCallback>(intPtr3) : null;
				}
			}

			// Token: 0x17001074 RID: 4212
			// (get) Token: 0x060030E3 RID: 12515 RVA: 0x000DB78C File Offset: 0x000D998C
			public unsafe Object Collection
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_get_Collection_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001075 RID: 4213
			// (get) Token: 0x060030E4 RID: 12516 RVA: 0x000DB7CC File Offset: 0x000D99CC
			public unsafe Object Id
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_get_Id_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001076 RID: 4214
			// (get) Token: 0x060030E5 RID: 12517 RVA: 0x000DB80C File Offset: 0x000D9A0C
			// (set) Token: 0x060030E6 RID: 12518 RVA: 0x000DB84C File Offset: 0x000D9A4C
			public unsafe Object CollectionItems
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_get_CollectionItems_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionFixup.NativeMethodInfoPtr_set_CollectionItems_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060030E7 RID: 12519 RVA: 0x000149D8 File Offset: 0x00012BD8
			public CollectionFixup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700106F RID: 4207
			// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000DB890 File Offset: 0x000D9A90
			// (set) Token: 0x060030E9 RID: 12521 RVA: 0x000149E1 File Offset: 0x00012BE1
			public unsafe XmlSerializationCollectionFixupCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializationCollectionFixupCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001070 RID: 4208
			// (get) Token: 0x060030EA RID: 12522 RVA: 0x000DB8C0 File Offset: 0x000D9AC0
			// (set) Token: 0x060030EB RID: 12523 RVA: 0x00014A00 File Offset: 0x00012C00
			public unsafe Object collection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_collection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001071 RID: 4209
			// (get) Token: 0x060030EC RID: 12524 RVA: 0x000DB8F0 File Offset: 0x000D9AF0
			// (set) Token: 0x060030ED RID: 12525 RVA: 0x00014A1F File Offset: 0x00012C1F
			public unsafe Object collectionItems
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_collectionItems);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_collectionItems), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001072 RID: 4210
			// (get) Token: 0x060030EE RID: 12526 RVA: 0x000DB920 File Offset: 0x000D9B20
			// (set) Token: 0x060030EF RID: 12527 RVA: 0x00014A3E File Offset: 0x00012C3E
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionFixup.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040025E9 RID: 9705
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040025EA RID: 9706
			private static readonly IntPtr NativeFieldInfoPtr_collection;

			// Token: 0x040025EB RID: 9707
			private static readonly IntPtr NativeFieldInfoPtr_collectionItems;

			// Token: 0x040025EC RID: 9708
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040025ED RID: 9709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_XmlSerializationCollectionFixupCallback_String_0;

			// Token: 0x040025EE RID: 9710
			private static readonly IntPtr NativeMethodInfoPtr_get_Callback_Public_get_XmlSerializationCollectionFixupCallback_0;

			// Token: 0x040025EF RID: 9711
			private static readonly IntPtr NativeMethodInfoPtr_get_Collection_Public_get_Object_0;

			// Token: 0x040025F0 RID: 9712
			private static readonly IntPtr NativeMethodInfoPtr_get_Id_Internal_get_Object_0;

			// Token: 0x040025F1 RID: 9713
			private static readonly IntPtr NativeMethodInfoPtr_get_CollectionItems_Public_get_Object_0;

			// Token: 0x040025F2 RID: 9714
			private static readonly IntPtr NativeMethodInfoPtr_set_CollectionItems_Internal_set_Void_Object_0;
		}

		// Token: 0x0200024C RID: 588
		public class Fixup : Object
		{
			// Token: 0x060030F0 RID: 12528 RVA: 0x000DB948 File Offset: 0x000D9B48
			// Note: this type is marked as 'beforefieldinit'.
			static Fixup()
			{
				Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "Fixup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr);
				XmlSerializationReader.Fixup.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr, "source");
				XmlSerializationReader.Fixup.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr, "ids");
				XmlSerializationReader.Fixup.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr, "callback");
				XmlSerializationReader.Fixup.NativeMethodInfoPtr__ctor_Public_Void_Object_XmlSerializationFixupCallback_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr, 100666630);
				XmlSerializationReader.Fixup.NativeMethodInfoPtr_get_Callback_Public_get_XmlSerializationFixupCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr, 100666631);
				XmlSerializationReader.Fixup.NativeMethodInfoPtr_get_Ids_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr, 100666632);
				XmlSerializationReader.Fixup.NativeMethodInfoPtr_get_Source_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr, 100666633);
			}

			// Token: 0x060030F1 RID: 12529 RVA: 0x000DBA00 File Offset: 0x000D9C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387189, XrefRangeEnd = 387196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Fixup(Object o, XmlSerializationFixupCallback callback, int count)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReader.Fixup>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.Fixup.NativeMethodInfoPtr__ctor_Public_Void_Object_XmlSerializationFixupCallback_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700107A RID: 4218
			// (get) Token: 0x060030F2 RID: 12530 RVA: 0x000DBA6C File Offset: 0x000D9C6C
			public unsafe XmlSerializationFixupCallback Callback
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.Fixup.NativeMethodInfoPtr_get_Callback_Public_get_XmlSerializationFixupCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationFixupCallback>(intPtr3) : null;
				}
			}

			// Token: 0x1700107B RID: 4219
			// (get) Token: 0x060030F3 RID: 12531 RVA: 0x000DBAAC File Offset: 0x000D9CAC
			public unsafe Il2CppStringArray Ids
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.Fixup.NativeMethodInfoPtr_get_Ids_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x1700107C RID: 4220
			// (get) Token: 0x060030F4 RID: 12532 RVA: 0x000DBAEC File Offset: 0x000D9CEC
			public unsafe Object Source
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.Fixup.NativeMethodInfoPtr_get_Source_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030F5 RID: 12533 RVA: 0x00014A5D File Offset: 0x00012C5D
			public Fixup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001077 RID: 4215
			// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000DBB2C File Offset: 0x000D9D2C
			// (set) Token: 0x060030F7 RID: 12535 RVA: 0x00014A66 File Offset: 0x00012C66
			public unsafe Object source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.Fixup.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.Fixup.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001078 RID: 4216
			// (get) Token: 0x060030F8 RID: 12536 RVA: 0x000DBB5C File Offset: 0x000D9D5C
			// (set) Token: 0x060030F9 RID: 12537 RVA: 0x00014A85 File Offset: 0x00012C85
			public unsafe Il2CppStringArray ids
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.Fixup.NativeFieldInfoPtr_ids);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.Fixup.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001079 RID: 4217
			// (get) Token: 0x060030FA RID: 12538 RVA: 0x000DBB8C File Offset: 0x000D9D8C
			// (set) Token: 0x060030FB RID: 12539 RVA: 0x00014AA4 File Offset: 0x00012CA4
			public unsafe XmlSerializationFixupCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.Fixup.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializationFixupCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.Fixup.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040025F3 RID: 9715
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040025F4 RID: 9716
			private static readonly IntPtr NativeFieldInfoPtr_ids;

			// Token: 0x040025F5 RID: 9717
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040025F6 RID: 9718
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_XmlSerializationFixupCallback_Int32_0;

			// Token: 0x040025F7 RID: 9719
			private static readonly IntPtr NativeMethodInfoPtr_get_Callback_Public_get_XmlSerializationFixupCallback_0;

			// Token: 0x040025F8 RID: 9720
			private static readonly IntPtr NativeMethodInfoPtr_get_Ids_Public_get_Il2CppStringArray_0;

			// Token: 0x040025F9 RID: 9721
			private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_get_Object_0;
		}

		// Token: 0x0200024D RID: 589
		public class CollectionItemFixup : Object
		{
			// Token: 0x060030FC RID: 12540 RVA: 0x000DBBBC File Offset: 0x000D9DBC
			// Note: this type is marked as 'beforefieldinit'.
			static CollectionItemFixup()
			{
				Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationReader>.NativeClassPtr, "CollectionItemFixup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr);
				XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr, "list");
				XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr, "index");
				XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr, "id");
				XmlSerializationReader.CollectionItemFixup.NativeMethodInfoPtr__ctor_Public_Void_Array_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr, 100666634);
				XmlSerializationReader.CollectionItemFixup.NativeMethodInfoPtr_get_Collection_Public_get_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr, 100666635);
				XmlSerializationReader.CollectionItemFixup.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr, 100666636);
				XmlSerializationReader.CollectionItemFixup.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr, 100666637);
			}

			// Token: 0x060030FD RID: 12541 RVA: 0x000DBC74 File Offset: 0x000D9E74
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 376295, RefRangeEnd = 376296, XrefRangeStart = 376295, XrefRangeEnd = 376296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CollectionItemFixup(Array list, int index, string id)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReader.CollectionItemFixup>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionItemFixup.NativeMethodInfoPtr__ctor_Public_Void_Array_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001080 RID: 4224
			// (get) Token: 0x060030FE RID: 12542 RVA: 0x000DBCE0 File Offset: 0x000D9EE0
			public unsafe Array Collection
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionItemFixup.NativeMethodInfoPtr_get_Collection_Public_get_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
				}
			}

			// Token: 0x17001081 RID: 4225
			// (get) Token: 0x060030FF RID: 12543 RVA: 0x000DBD20 File Offset: 0x000D9F20
			public unsafe int Index
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionItemFixup.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001082 RID: 4226
			// (get) Token: 0x06003100 RID: 12544 RVA: 0x000DBD5C File Offset: 0x000D9F5C
			public unsafe string Id
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReader.CollectionItemFixup.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003101 RID: 12545 RVA: 0x00014AC3 File Offset: 0x00012CC3
			public CollectionItemFixup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700107D RID: 4221
			// (get) Token: 0x06003102 RID: 12546 RVA: 0x000DBD94 File Offset: 0x000D9F94
			// (set) Token: 0x06003103 RID: 12547 RVA: 0x00014ACC File Offset: 0x00012CCC
			public unsafe Array list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107E RID: 4222
			// (get) Token: 0x06003104 RID: 12548 RVA: 0x000DBDC4 File Offset: 0x000D9FC4
			// (set) Token: 0x06003105 RID: 12549 RVA: 0x00014AEB File Offset: 0x00012CEB
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700107F RID: 4223
			// (get) Token: 0x06003106 RID: 12550 RVA: 0x000DBDEC File Offset: 0x000D9FEC
			// (set) Token: 0x06003107 RID: 12551 RVA: 0x00014B06 File Offset: 0x00012D06
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationReader.CollectionItemFixup.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040025FA RID: 9722
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040025FB RID: 9723
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040025FC RID: 9724
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040025FD RID: 9725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Array_Int32_String_0;

			// Token: 0x040025FE RID: 9726
			private static readonly IntPtr NativeMethodInfoPtr_get_Collection_Public_get_Array_0;

			// Token: 0x040025FF RID: 9727
			private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

			// Token: 0x04002600 RID: 9728
			private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;
		}
	}
}
