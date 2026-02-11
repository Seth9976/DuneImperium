using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EA RID: 234
	public class XmlSerializer : Object
	{
		// Token: 0x060015A8 RID: 5544 RVA: 0x00074290 File Offset: 0x00072490
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializer()
		{
			Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializer");
			XmlSerializer.NativeFieldInfoPtr_generationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "generationThreshold");
			XmlSerializer.NativeFieldInfoPtr_backgroundGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "backgroundGeneration");
			XmlSerializer.NativeFieldInfoPtr_deleteTempFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "deleteTempFiles");
			XmlSerializer.NativeFieldInfoPtr_generatorFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "generatorFallback");
			XmlSerializer.NativeFieldInfoPtr_customSerializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "customSerializer");
			XmlSerializer.NativeFieldInfoPtr_typeMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "typeMapping");
			XmlSerializer.NativeFieldInfoPtr_serializerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "serializerData");
			XmlSerializer.NativeFieldInfoPtr_serializerTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "serializerTypes");
			XmlSerializer.NativeFieldInfoPtr_onUnreferencedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "onUnreferencedObject");
			XmlSerializer.NativeFieldInfoPtr_onUnknownAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "onUnknownAttribute");
			XmlSerializer.NativeFieldInfoPtr_onUnknownElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "onUnknownElement");
			XmlSerializer.NativeFieldInfoPtr_onUnknownNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "onUnknownNode");
			XmlSerializer.NativeMethodInfoPtr__ctor_Public_Void_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666763);
			XmlSerializer.NativeMethodInfoPtr_get_Mapping_Internal_get_XmlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666764);
			XmlSerializer.NativeMethodInfoPtr_OnUnknownAttribute_Internal_Virtual_New_Void_XmlAttributeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666765);
			XmlSerializer.NativeMethodInfoPtr_OnUnknownElement_Internal_Virtual_New_Void_XmlElementEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666766);
			XmlSerializer.NativeMethodInfoPtr_OnUnknownNode_Internal_Virtual_New_Void_XmlNodeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666767);
			XmlSerializer.NativeMethodInfoPtr_OnUnreferencedObject_Internal_Virtual_New_Void_UnreferencedObjectEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666768);
			XmlSerializer.NativeMethodInfoPtr_CreateReader_Protected_Virtual_New_XmlSerializationReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666769);
			XmlSerializer.NativeMethodInfoPtr_CreateWriter_Protected_Virtual_New_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666770);
			XmlSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666771);
			XmlSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666772);
			XmlSerializer.NativeMethodInfoPtr_Deserialize_Protected_Virtual_New_Object_XmlSerializationReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666773);
			XmlSerializer.NativeMethodInfoPtr_Serialize_Protected_Virtual_New_Void_Object_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666774);
			XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666775);
			XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666776);
			XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_XmlSerializerNamespaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666777);
			XmlSerializer.NativeMethodInfoPtr_CreateWriter_Private_XmlSerializationWriter_XmlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666778);
			XmlSerializer.NativeMethodInfoPtr_CreateReader_Private_XmlSerializationReader_XmlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666779);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000744FC File Offset: 0x000726FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389399, XrefRangeEnd = 389420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializer(Type type, XmlAttributeOverrides overrides, Il2CppReferenceArray<Type> extraTypes, XmlRootAttribute root, string defaultNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrides);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr__ctor_Public_Void_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00074594 File Offset: 0x00072794
		public unsafe XmlMapping Mapping
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_get_Mapping_Internal_get_XmlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlMapping>(intPtr3) : null;
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000745D4 File Offset: 0x000727D4
		[CallerCount(0)]
		public unsafe virtual void OnUnknownAttribute(XmlAttributeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_OnUnknownAttribute_Internal_Virtual_New_Void_XmlAttributeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00074624 File Offset: 0x00072824
		[CallerCount(0)]
		public unsafe virtual void OnUnknownElement(XmlElementEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_OnUnknownElement_Internal_Virtual_New_Void_XmlElementEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00074674 File Offset: 0x00072874
		[CallerCount(0)]
		public unsafe virtual void OnUnknownNode(XmlNodeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_OnUnknownNode_Internal_Virtual_New_Void_XmlNodeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000746C4 File Offset: 0x000728C4
		[CallerCount(0)]
		public unsafe virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_OnUnreferencedObject_Internal_Virtual_New_Void_UnreferencedObjectEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00074714 File Offset: 0x00072914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389420, XrefRangeEnd = 389425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSerializationReader CreateReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_CreateReader_Protected_Virtual_New_XmlSerializationReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationReader>(intPtr3) : null;
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00074760 File Offset: 0x00072960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389425, XrefRangeEnd = 389430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSerializationWriter CreateWriter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_CreateWriter_Protected_Virtual_New_XmlSerializationWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr3) : null;
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000747AC File Offset: 0x000729AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389443, RefRangeEnd = 389445, XrefRangeStart = 389430, XrefRangeEnd = 389443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(TextReader textReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000747FC File Offset: 0x000729FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389452, RefRangeEnd = 389454, XrefRangeStart = 389445, XrefRangeEnd = 389452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(XmlReader xmlReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0007484C File Offset: 0x00072A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389454, XrefRangeEnd = 389459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Deserialize(XmlSerializationReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_Deserialize_Protected_Virtual_New_Object_XmlSerializationReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000748A8 File Offset: 0x00072AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389459, XrefRangeEnd = 389463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Serialize(Object o, XmlSerializationWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_Serialize_Protected_Virtual_New_Void_Object_XmlSerializationWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00074908 File Offset: 0x00072B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389469, RefRangeEnd = 389471, XrefRangeStart = 389463, XrefRangeEnd = 389469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(TextWriter textWriter, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0007495C File Offset: 0x00072B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389472, RefRangeEnd = 389474, XrefRangeStart = 389471, XrefRangeEnd = 389472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(XmlWriter xmlWriter, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000749B0 File Offset: 0x00072BB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389499, RefRangeEnd = 389501, XrefRangeStart = 389474, XrefRangeEnd = 389499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(XmlWriter xmlWriter, Object o, XmlSerializerNamespaces namespaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_XmlSerializerNamespaces_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00074A18 File Offset: 0x00072C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389524, RefRangeEnd = 389525, XrefRangeStart = 389501, XrefRangeEnd = 389524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationWriter CreateWriter(XmlMapping typeMapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMapping);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_CreateWriter_Private_XmlSerializationWriter_XmlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr3) : null;
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00074A68 File Offset: 0x00072C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389525, XrefRangeEnd = 389529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationReader CreateReader(XmlMapping typeMapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMapping);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_CreateReader_Private_XmlSerializationReader_XmlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationReader>(intPtr3) : null;
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00009292 File Offset: 0x00007492
		public XmlSerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x00074AB8 File Offset: 0x00072CB8
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x0000929B File Offset: 0x0000749B
		public unsafe static int generationThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_generationThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_generationThreshold, (void*)(&value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00074AD4 File Offset: 0x00072CD4
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x000092A9 File Offset: 0x000074A9
		public unsafe static bool backgroundGeneration
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_backgroundGeneration, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_backgroundGeneration, (void*)(&value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00074AF0 File Offset: 0x00072CF0
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x000092B7 File Offset: 0x000074B7
		public unsafe static bool deleteTempFiles
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_deleteTempFiles, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_deleteTempFiles, (void*)(&value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00074B0C File Offset: 0x00072D0C
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x000092C5 File Offset: 0x000074C5
		public unsafe static bool generatorFallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_generatorFallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_generatorFallback, (void*)(&value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00074B28 File Offset: 0x00072D28
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x000092D3 File Offset: 0x000074D3
		public unsafe bool customSerializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_customSerializer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_customSerializer)) = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00074B50 File Offset: 0x00072D50
		// (set) Token: 0x060015C6 RID: 5574 RVA: 0x000092EE File Offset: 0x000074EE
		public unsafe XmlMapping typeMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_typeMapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_typeMapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00074B80 File Offset: 0x00072D80
		// (set) Token: 0x060015C8 RID: 5576 RVA: 0x0000930D File Offset: 0x0000750D
		public unsafe XmlSerializer.SerializerData serializerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_serializerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializer.SerializerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_serializerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00074BB0 File Offset: 0x00072DB0
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x0000932C File Offset: 0x0000752C
		public unsafe static Hashtable serializerTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_serializerTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_serializerTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00074BD8 File Offset: 0x00072DD8
		// (set) Token: 0x060015CC RID: 5580 RVA: 0x0000933E File Offset: 0x0000753E
		public unsafe UnreferencedObjectEventHandler onUnreferencedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_onUnreferencedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnreferencedObjectEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_onUnreferencedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00074C08 File Offset: 0x00072E08
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x0000935D File Offset: 0x0000755D
		public unsafe XmlAttributeEventHandler onUnknownAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_onUnknownAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttributeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_onUnknownAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x00074C38 File Offset: 0x00072E38
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x0000937C File Offset: 0x0000757C
		public unsafe XmlElementEventHandler onUnknownElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_onUnknownElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlElementEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_onUnknownElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00074C68 File Offset: 0x00072E68
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x0000939B File Offset: 0x0000759B
		public unsafe XmlNodeEventHandler onUnknownNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_onUnknownNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_onUnknownNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeFieldInfoPtr_generationThreshold;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr_backgroundGeneration;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeFieldInfoPtr_deleteTempFiles;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeFieldInfoPtr_generatorFallback;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeFieldInfoPtr_customSerializer;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeFieldInfoPtr_typeMapping;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeFieldInfoPtr_serializerData;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeFieldInfoPtr_serializerTypes;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeFieldInfoPtr_onUnreferencedObject;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeFieldInfoPtr_onUnknownAttribute;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeFieldInfoPtr_onUnknownElement;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeFieldInfoPtr_onUnknownNode;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_get_Mapping_Internal_get_XmlMapping_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_OnUnknownAttribute_Internal_Virtual_New_Void_XmlAttributeEventArgs_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_OnUnknownElement_Internal_Virtual_New_Void_XmlElementEventArgs_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_OnUnknownNode_Internal_Virtual_New_Void_XmlNodeEventArgs_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_OnUnreferencedObject_Internal_Virtual_New_Void_UnreferencedObjectEventArgs_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_CreateReader_Protected_Virtual_New_XmlSerializationReader_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Protected_Virtual_New_XmlSerializationWriter_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Object_TextReader_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Object_XmlReader_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Protected_Virtual_New_Object_XmlSerializationReader_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Protected_Virtual_New_Void_Object_XmlSerializationWriter_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_XmlSerializerNamespaces_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Private_XmlSerializationWriter_XmlMapping_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_CreateReader_Private_XmlSerializationReader_XmlMapping_0;

		// Token: 0x02000252 RID: 594
		public class SerializerData : Object
		{
			// Token: 0x0600312E RID: 12590 RVA: 0x000DC4AC File Offset: 0x000DA6AC
			// Note: this type is marked as 'beforefieldinit'.
			static SerializerData()
			{
				Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "SerializerData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr);
				XmlSerializer.SerializerData.NativeFieldInfoPtr_ReaderMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, "ReaderMethod");
				XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, "WriterType");
				XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, "WriterMethod");
				XmlSerializer.SerializerData.NativeFieldInfoPtr_Implementation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, "Implementation");
				XmlSerializer.SerializerData.NativeMethodInfoPtr_CreateWriter_Public_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, 100666780);
			}

			// Token: 0x0600312F RID: 12591 RVA: 0x000DC53C File Offset: 0x000DA73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389394, XrefRangeEnd = 389399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlSerializationWriter CreateWriter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.SerializerData.NativeMethodInfoPtr_CreateWriter_Public_XmlSerializationWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr3) : null;
			}

			// Token: 0x06003130 RID: 12592 RVA: 0x00014C9A File Offset: 0x00012E9A
			public SerializerData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700108E RID: 4238
			// (get) Token: 0x06003131 RID: 12593 RVA: 0x000DC57C File Offset: 0x000DA77C
			// (set) Token: 0x06003132 RID: 12594 RVA: 0x00014CA3 File Offset: 0x00012EA3
			public unsafe MethodInfo ReaderMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_ReaderMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_ReaderMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108F RID: 4239
			// (get) Token: 0x06003133 RID: 12595 RVA: 0x000DC5AC File Offset: 0x000DA7AC
			// (set) Token: 0x06003134 RID: 12596 RVA: 0x00014CC2 File Offset: 0x00012EC2
			public unsafe Type WriterType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001090 RID: 4240
			// (get) Token: 0x06003135 RID: 12597 RVA: 0x000DC5DC File Offset: 0x000DA7DC
			// (set) Token: 0x06003136 RID: 12598 RVA: 0x00014CE1 File Offset: 0x00012EE1
			public unsafe MethodInfo WriterMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001091 RID: 4241
			// (get) Token: 0x06003137 RID: 12599 RVA: 0x000DC60C File Offset: 0x000DA80C
			// (set) Token: 0x06003138 RID: 12600 RVA: 0x00014D00 File Offset: 0x00012F00
			public unsafe XmlSerializerImplementation Implementation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_Implementation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializerImplementation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_Implementation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002614 RID: 9748
			private static readonly IntPtr NativeFieldInfoPtr_ReaderMethod;

			// Token: 0x04002615 RID: 9749
			private static readonly IntPtr NativeFieldInfoPtr_WriterType;

			// Token: 0x04002616 RID: 9750
			private static readonly IntPtr NativeFieldInfoPtr_WriterMethod;

			// Token: 0x04002617 RID: 9751
			private static readonly IntPtr NativeFieldInfoPtr_Implementation;

			// Token: 0x04002618 RID: 9752
			private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Public_XmlSerializationWriter_0;
		}
	}
}
