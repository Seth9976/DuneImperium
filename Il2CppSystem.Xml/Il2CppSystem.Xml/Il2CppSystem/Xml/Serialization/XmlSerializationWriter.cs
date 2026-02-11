using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E8 RID: 232
	public class XmlSerializationWriter : XmlSerializationGeneratedCode
	{
		// Token: 0x06001545 RID: 5445 RVA: 0x00071CBC File Offset: 0x0006FEBC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationWriter()
		{
			Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr);
			XmlSerializationWriter.NativeFieldInfoPtr_idGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "idGenerator");
			XmlSerializationWriter.NativeFieldInfoPtr_qnameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "qnameCount");
			XmlSerializationWriter.NativeFieldInfoPtr_topLevelElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "topLevelElement");
			XmlSerializationWriter.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "namespaces");
			XmlSerializationWriter.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "writer");
			XmlSerializationWriter.NativeFieldInfoPtr_referencedElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "referencedElements");
			XmlSerializationWriter.NativeFieldInfoPtr_callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "callbacks");
			XmlSerializationWriter.NativeFieldInfoPtr_serializedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "serializedObjects");
			XmlSerializationWriter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666683);
			XmlSerializationWriter.NativeMethodInfoPtr_Initialize_Internal_Void_XmlWriter_XmlSerializerNamespaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666684);
			XmlSerializationWriter.NativeMethodInfoPtr_get_Writer_Protected_get_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666685);
			XmlSerializationWriter.NativeMethodInfoPtr_AddWriteCallback_Protected_Void_Type_String_String_XmlSerializationWriteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666686);
			XmlSerializationWriter.NativeMethodInfoPtr_CreateUnknownAnyElementException_Protected_Exception_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666687);
			XmlSerializationWriter.NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666688);
			XmlSerializationWriter.NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666689);
			XmlSerializationWriter.NativeMethodInfoPtr_FromXmlQualifiedName_Protected_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666690);
			XmlSerializationWriter.NativeMethodInfoPtr_GetId_Private_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666691);
			XmlSerializationWriter.NativeMethodInfoPtr_AlreadyQueued_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666692);
			XmlSerializationWriter.NativeMethodInfoPtr_GetNamespacePrefix_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666693);
			XmlSerializationWriter.NativeMethodInfoPtr_GetQualifiedName_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666694);
			XmlSerializationWriter.NativeMethodInfoPtr_InitCallbacks_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666695);
			XmlSerializationWriter.NativeMethodInfoPtr_TopLevelElement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666696);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteAttribute_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666697);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteAttribute_Protected_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666698);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteXmlNode_Private_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666699);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteElementEncoded_Protected_Void_XmlNode_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666700);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteElementLiteral_Protected_Void_XmlNode_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666701);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteElementQualifiedName_Protected_Void_String_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666702);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteElementQualifiedName_Protected_Void_String_String_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666703);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteElementString_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666704);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteElementString_Protected_Void_String_String_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666705);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteEndElement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666706);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteEndElement_Protected_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666707);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteNamespaceDeclarations_Protected_Void_XmlSerializerNamespaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666708);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteNullableQualifiedNameEncoded_Protected_Void_String_String_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666709);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteNullableQualifiedNameLiteral_Protected_Void_String_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666710);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteNullableStringEncoded_Protected_Void_String_String_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666711);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteNullableStringLiteral_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666712);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteNullTagEncoded_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666713);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteNullTagLiteral_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666714);
			XmlSerializationWriter.NativeMethodInfoPtr_WritePotentiallyReferencingElement_Protected_Void_String_String_Object_Type_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666715);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteReferencedElements_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666716);
			XmlSerializationWriter.NativeMethodInfoPtr_IsPrimitiveArray_Private_Boolean_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666717);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteArray_Private_Void_Object_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666718);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteReferencingElement_Protected_Void_String_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666719);
			XmlSerializationWriter.NativeMethodInfoPtr_CheckReferenceQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666720);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteSerializable_Protected_Void_IXmlSerializable_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666721);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteSerializable_Protected_Void_IXmlSerializable_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666722);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteStartDocument_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666723);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666724);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666725);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666726);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666727);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Private_Void_String_String_Object_Boolean_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666728);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteTypedPrimitive_Protected_Void_String_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666729);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteValue_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666730);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteXmlAttribute_Protected_Void_XmlNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666731);
			XmlSerializationWriter.NativeMethodInfoPtr_WriteXsiType_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, 100666732);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00072174 File Offset: 0x00070374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388205, RefRangeEnd = 388207, XrefRangeStart = 388199, XrefRangeEnd = 388205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000721B0 File Offset: 0x000703B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388220, RefRangeEnd = 388221, XrefRangeStart = 388207, XrefRangeEnd = 388220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(XmlWriter writer, XmlSerializerNamespaces nss)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nss);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_Initialize_Internal_Void_XmlWriter_XmlSerializerNamespaces_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x00072204 File Offset: 0x00070404
		public unsafe XmlWriter Writer
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_get_Writer_Protected_get_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr3) : null;
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00072244 File Offset: 0x00070444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388235, RefRangeEnd = 388236, XrefRangeStart = 388221, XrefRangeEnd = 388235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeNs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_AddWriteCallback_Protected_Void_Type_String_String_XmlSerializationWriteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000722C0 File Offset: 0x000704C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388236, XrefRangeEnd = 388243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateUnknownAnyElementException(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_CreateUnknownAnyElementException_Protected_Exception_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00072324 File Offset: 0x00070524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388251, RefRangeEnd = 388252, XrefRangeStart = 388243, XrefRangeEnd = 388251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateUnknownTypeException(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00072374 File Offset: 0x00070574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388252, XrefRangeEnd = 388259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateUnknownTypeException(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x000723C4 File Offset: 0x000705C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388268, RefRangeEnd = 388270, XrefRangeStart = 388259, XrefRangeEnd = 388268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlQualifiedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_FromXmlQualifiedName_Protected_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0007240C File Offset: 0x0007060C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 388285, RefRangeEnd = 388290, XrefRangeStart = 388270, XrefRangeEnd = 388285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetId(Object o, bool addToReferencesList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addToReferencesList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_GetId_Private_String_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00072464 File Offset: 0x00070664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388290, RefRangeEnd = 388291, XrefRangeStart = 388290, XrefRangeEnd = 388290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AlreadyQueued(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_AlreadyQueued_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000724B4 File Offset: 0x000706B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388291, XrefRangeEnd = 388304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNamespacePrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_GetNamespacePrefix_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000724FC File Offset: 0x000706FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 388326, RefRangeEnd = 388331, XrefRangeStart = 388304, XrefRangeEnd = 388326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQualifiedName(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_GetQualifiedName_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00072558 File Offset: 0x00070758
		[CallerCount(0)]
		public unsafe virtual void InitCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriter.NativeMethodInfoPtr_InitCallbacks_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00072594 File Offset: 0x00070794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388331, RefRangeEnd = 388333, XrefRangeStart = 388331, XrefRangeEnd = 388331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TopLevelElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_TopLevelElement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x000725C8 File Offset: 0x000707C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388334, RefRangeEnd = 388336, XrefRangeStart = 388333, XrefRangeEnd = 388334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAttribute(string localName, string ns, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteAttribute_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00072630 File Offset: 0x00070830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388337, RefRangeEnd = 388339, XrefRangeStart = 388336, XrefRangeEnd = 388337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAttribute(string prefix, string localName, string ns, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteAttribute_Protected_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000726AC File Offset: 0x000708AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388344, RefRangeEnd = 388348, XrefRangeStart = 388339, XrefRangeEnd = 388344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteXmlNode(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteXmlNode_Private_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000726F0 File Offset: 0x000708F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388357, RefRangeEnd = 388359, XrefRangeStart = 388348, XrefRangeEnd = 388357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref any;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteElementEncoded_Protected_Void_XmlNode_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00072774 File Offset: 0x00070974
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388368, RefRangeEnd = 388370, XrefRangeStart = 388359, XrefRangeEnd = 388368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref any;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteElementLiteral_Protected_Void_XmlNode_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000727F8 File Offset: 0x000709F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388370, XrefRangeEnd = 388371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteElementQualifiedName_Protected_Void_String_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00072860 File Offset: 0x00070A60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 388394, RefRangeEnd = 388397, XrefRangeStart = 388371, XrefRangeEnd = 388394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsiType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteElementQualifiedName_Protected_Void_String_String_XmlQualifiedName_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000728DC File Offset: 0x00070ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388398, RefRangeEnd = 388399, XrefRangeStart = 388397, XrefRangeEnd = 388398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementString(string localName, string ns, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteElementString_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00072944 File Offset: 0x00070B44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388405, RefRangeEnd = 388409, XrefRangeStart = 388399, XrefRangeEnd = 388405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsiType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteElementString_Protected_Void_String_String_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000729C0 File Offset: 0x00070BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388410, RefRangeEnd = 388411, XrefRangeStart = 388409, XrefRangeEnd = 388410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteEndElement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000729F4 File Offset: 0x00070BF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388412, RefRangeEnd = 388414, XrefRangeStart = 388411, XrefRangeEnd = 388412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEndElement(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteEndElement_Protected_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00072A38 File Offset: 0x00070C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388444, RefRangeEnd = 388445, XrefRangeStart = 388414, XrefRangeEnd = 388444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteNamespaceDeclarations_Protected_Void_XmlSerializerNamespaces_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00072A7C File Offset: 0x00070C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388445, XrefRangeEnd = 388452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsiType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteNullableQualifiedNameEncoded_Protected_Void_String_String_XmlQualifiedName_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00072AF8 File Offset: 0x00070CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388452, XrefRangeEnd = 388459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteNullableQualifiedNameLiteral_Protected_Void_String_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00072B60 File Offset: 0x00070D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388459, XrefRangeEnd = 388460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsiType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteNullableStringEncoded_Protected_Void_String_String_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00072BDC File Offset: 0x00070DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388460, XrefRangeEnd = 388462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullableStringLiteral(string name, string ns, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteNullableStringLiteral_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00072C44 File Offset: 0x00070E44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388471, RefRangeEnd = 388475, XrefRangeStart = 388462, XrefRangeEnd = 388471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullTagEncoded(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteNullTagEncoded_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00072C98 File Offset: 0x00070E98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 388484, RefRangeEnd = 388490, XrefRangeStart = 388475, XrefRangeEnd = 388484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullTagLiteral(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteNullTagLiteral_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00072CEC File Offset: 0x00070EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388532, RefRangeEnd = 388534, XrefRangeStart = 388490, XrefRangeEnd = 388532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WritePotentiallyReferencingElement(string n, string ns, Object o, Type ambientType, bool suppressReference, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ambientType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressReference;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WritePotentiallyReferencingElement_Protected_Void_String_String_Object_Type_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00072D84 File Offset: 0x00070F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388552, RefRangeEnd = 388553, XrefRangeStart = 388534, XrefRangeEnd = 388552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteReferencedElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteReferencedElements_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00072DB8 File Offset: 0x00070FB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388555, RefRangeEnd = 388557, XrefRangeStart = 388553, XrefRangeEnd = 388555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrimitiveArray(TypeData td)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(td);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_IsPrimitiveArray_Private_Boolean_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00072E08 File Offset: 0x00071008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388593, RefRangeEnd = 388594, XrefRangeStart = 388557, XrefRangeEnd = 388593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArray(Object o, TypeData td)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(td);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteArray_Private_Void_Object_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00072E5C File Offset: 0x0007105C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388605, RefRangeEnd = 388606, XrefRangeStart = 388594, XrefRangeEnd = 388605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteReferencingElement(string n, string ns, Object o, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteReferencingElement_Protected_Void_String_String_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00072ED0 File Offset: 0x000710D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388611, RefRangeEnd = 388613, XrefRangeStart = 388606, XrefRangeEnd = 388611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckReferenceQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_CheckReferenceQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00072F04 File Offset: 0x00071104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388613, XrefRangeEnd = 388620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteSerializable_Protected_Void_IXmlSerializable_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00072F78 File Offset: 0x00071178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388627, RefRangeEnd = 388628, XrefRangeStart = 388620, XrefRangeEnd = 388627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteSerializable_Protected_Void_IXmlSerializable_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00072FFC File Offset: 0x000711FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388628, RefRangeEnd = 388629, XrefRangeStart = 388628, XrefRangeEnd = 388628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteStartDocument_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00073030 File Offset: 0x00071230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388629, XrefRangeEnd = 388630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartElement(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00073084 File Offset: 0x00071284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388631, RefRangeEnd = 388632, XrefRangeStart = 388630, XrefRangeEnd = 388631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartElement(string name, string ns, bool writePrefixed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writePrefixed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000730E8 File Offset: 0x000712E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388633, RefRangeEnd = 388635, XrefRangeStart = 388632, XrefRangeEnd = 388633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartElement(string name, string ns, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00073150 File Offset: 0x00071350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388635, XrefRangeEnd = 388636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartElement(string name, string ns, Object o, bool writePrefixed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writePrefixed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000731C4 File Offset: 0x000713C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 388691, RefRangeEnd = 388700, XrefRangeStart = 388636, XrefRangeEnd = 388691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartElement(string name, string ns, Object o, bool writePrefixed, ICollection namespaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writePrefixed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteStartElement_Private_Void_String_String_Object_Boolean_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0007324C File Offset: 0x0007144C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388752, RefRangeEnd = 388753, XrefRangeStart = 388700, XrefRangeEnd = 388752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTypedPrimitive(string name, string ns, Object o, bool xsiType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xsiType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteTypedPrimitive_Protected_Void_String_String_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000732C0 File Offset: 0x000714C0
		[CallerCount(0)]
		public unsafe void WriteValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteValue_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00073304 File Offset: 0x00071504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388769, RefRangeEnd = 388770, XrefRangeStart = 388753, XrefRangeEnd = 388769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteXmlAttribute(XmlNode node, Object container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteXmlAttribute_Protected_Void_XmlNode_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00073358 File Offset: 0x00071558
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 388779, RefRangeEnd = 388785, XrefRangeStart = 388770, XrefRangeEnd = 388779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteXsiType(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.NativeMethodInfoPtr_WriteXsiType_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00009156 File Offset: 0x00007356
		public XmlSerializationWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x000733AC File Offset: 0x000715AC
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x0000915F File Offset: 0x0000735F
		public unsafe ObjectIDGenerator idGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_idGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectIDGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_idGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x000733DC File Offset: 0x000715DC
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0000917E File Offset: 0x0000737E
		public unsafe int qnameCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_qnameCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_qnameCount)) = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00073404 File Offset: 0x00071604
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x00009199 File Offset: 0x00007399
		public unsafe bool topLevelElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_topLevelElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_topLevelElement)) = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x0007342C File Offset: 0x0007162C
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x000091B4 File Offset: 0x000073B4
		public unsafe ArrayList namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_namespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_namespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0007345C File Offset: 0x0007165C
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x000091D3 File Offset: 0x000073D3
		public unsafe XmlWriter writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0007348C File Offset: 0x0007168C
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x000091F2 File Offset: 0x000073F2
		public unsafe Queue referencedElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_referencedElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_referencedElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x000734BC File Offset: 0x000716BC
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x00009211 File Offset: 0x00007411
		public unsafe Hashtable callbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_callbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_callbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x000734EC File Offset: 0x000716EC
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00009230 File Offset: 0x00007430
		public unsafe Hashtable serializedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_serializedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.NativeFieldInfoPtr_serializedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeFieldInfoPtr_idGenerator;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeFieldInfoPtr_qnameCount;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeFieldInfoPtr_topLevelElement;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeFieldInfoPtr_writer;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_referencedElements;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_callbacks;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_serializedObjects;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_XmlWriter_XmlSerializerNamespaces_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_get_Writer_Protected_get_XmlWriter_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_AddWriteCallback_Protected_Void_Type_String_String_XmlSerializationWriteCallback_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnknownAnyElementException_Protected_Exception_String_String_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_Object_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnknownTypeException_Protected_Exception_Type_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlQualifiedName_Protected_String_XmlQualifiedName_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Private_String_Object_Boolean_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_AlreadyQueued_Private_Boolean_Object_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacePrefix_Private_String_String_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_GetQualifiedName_Private_String_String_String_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_InitCallbacks_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_TopLevelElement_Protected_Void_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_WriteAttribute_Protected_Void_String_String_String_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_WriteAttribute_Protected_Void_String_String_String_String_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlNode_Private_Void_XmlNode_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementEncoded_Protected_Void_XmlNode_String_String_Boolean_Boolean_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementLiteral_Protected_Void_XmlNode_String_String_Boolean_Boolean_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementQualifiedName_Protected_Void_String_String_XmlQualifiedName_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementQualifiedName_Protected_Void_String_String_XmlQualifiedName_XmlQualifiedName_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementString_Protected_Void_String_String_String_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementString_Protected_Void_String_String_String_XmlQualifiedName_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Protected_Void_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Protected_Void_Object_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_WriteNamespaceDeclarations_Protected_Void_XmlSerializerNamespaces_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullableQualifiedNameEncoded_Protected_Void_String_String_XmlQualifiedName_XmlQualifiedName_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullableQualifiedNameLiteral_Protected_Void_String_String_XmlQualifiedName_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullableStringEncoded_Protected_Void_String_String_String_XmlQualifiedName_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullableStringLiteral_Protected_Void_String_String_String_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullTagEncoded_Protected_Void_String_String_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullTagLiteral_Protected_Void_String_String_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_WritePotentiallyReferencingElement_Protected_Void_String_String_Object_Type_Boolean_Boolean_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_WriteReferencedElements_Protected_Void_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveArray_Private_Boolean_TypeData_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_WriteArray_Private_Void_Object_TypeData_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_WriteReferencingElement_Protected_Void_String_String_Object_Boolean_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_CheckReferenceQueue_Private_Void_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializable_Protected_Void_IXmlSerializable_String_String_Boolean_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializable_Protected_Void_IXmlSerializable_String_String_Boolean_Boolean_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocument_Protected_Void_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Boolean_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Object_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Protected_Void_String_String_Object_Boolean_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Private_Void_String_String_Object_Boolean_ICollection_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_WriteTypedPrimitive_Protected_Void_String_String_Object_Boolean_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Protected_Void_String_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlAttribute_Protected_Void_XmlNode_Object_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_WriteXsiType_Protected_Void_String_String_0;

		// Token: 0x02000250 RID: 592
		public class WriteCallbackInfo : Object
		{
			// Token: 0x0600311A RID: 12570 RVA: 0x000DC158 File Offset: 0x000DA358
			// Note: this type is marked as 'beforefieldinit'.
			static WriteCallbackInfo()
			{
				Il2CppClassPointerStore<XmlSerializationWriter.WriteCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationWriter>.NativeClassPtr, "WriteCallbackInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationWriter.WriteCallbackInfo>.NativeClassPtr);
				XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter.WriteCallbackInfo>.NativeClassPtr, "Type");
				XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_TypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter.WriteCallbackInfo>.NativeClassPtr, "TypeName");
				XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_TypeNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter.WriteCallbackInfo>.NativeClassPtr, "TypeNs");
				XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriter.WriteCallbackInfo>.NativeClassPtr, "Callback");
				XmlSerializationWriter.WriteCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriter.WriteCallbackInfo>.NativeClassPtr, 100666733);
			}

			// Token: 0x0600311B RID: 12571 RVA: 0x000DC1E8 File Offset: 0x000DA3E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WriteCallbackInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationWriter.WriteCallbackInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriter.WriteCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600311C RID: 12572 RVA: 0x00014BCE File Offset: 0x00012DCE
			public WriteCallbackInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001088 RID: 4232
			// (get) Token: 0x0600311D RID: 12573 RVA: 0x000DC224 File Offset: 0x000DA424
			// (set) Token: 0x0600311E RID: 12574 RVA: 0x00014BD7 File Offset: 0x00012DD7
			public unsafe Type Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_Type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001089 RID: 4233
			// (get) Token: 0x0600311F RID: 12575 RVA: 0x000DC254 File Offset: 0x000DA454
			// (set) Token: 0x06003120 RID: 12576 RVA: 0x00014BF6 File Offset: 0x00012DF6
			public unsafe string TypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_TypeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_TypeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700108A RID: 4234
			// (get) Token: 0x06003121 RID: 12577 RVA: 0x000DC27C File Offset: 0x000DA47C
			// (set) Token: 0x06003122 RID: 12578 RVA: 0x00014C15 File Offset: 0x00012E15
			public unsafe string TypeNs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_TypeNs);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_TypeNs), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700108B RID: 4235
			// (get) Token: 0x06003123 RID: 12579 RVA: 0x000DC2A4 File Offset: 0x000DA4A4
			// (set) Token: 0x06003124 RID: 12580 RVA: 0x00014C34 File Offset: 0x00012E34
			public unsafe XmlSerializationWriteCallback Callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_Callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriteCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriter.WriteCallbackInfo.NativeFieldInfoPtr_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400260A RID: 9738
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x0400260B RID: 9739
			private static readonly IntPtr NativeFieldInfoPtr_TypeName;

			// Token: 0x0400260C RID: 9740
			private static readonly IntPtr NativeFieldInfoPtr_TypeNs;

			// Token: 0x0400260D RID: 9741
			private static readonly IntPtr NativeFieldInfoPtr_Callback;

			// Token: 0x0400260E RID: 9742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
