using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000100 RID: 256
	public class XmlNodeConverter : JsonConverter
	{
		// Token: 0x06001514 RID: 5396 RVA: 0x00072F8C File Offset: 0x0007118C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeConverter()
		{
			Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XmlNodeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr);
			XmlNodeConverter.NativeFieldInfoPtr_EmptyChildNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "EmptyChildNodes");
			XmlNodeConverter.NativeFieldInfoPtr_TextName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "TextName");
			XmlNodeConverter.NativeFieldInfoPtr_CommentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "CommentName");
			XmlNodeConverter.NativeFieldInfoPtr_CDataName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "CDataName");
			XmlNodeConverter.NativeFieldInfoPtr_WhitespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "WhitespaceName");
			XmlNodeConverter.NativeFieldInfoPtr_SignificantWhitespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "SignificantWhitespaceName");
			XmlNodeConverter.NativeFieldInfoPtr_DeclarationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "DeclarationName");
			XmlNodeConverter.NativeFieldInfoPtr_JsonNamespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "JsonNamespaceUri");
			XmlNodeConverter.NativeFieldInfoPtr__DeserializeRootElementName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "<DeserializeRootElementName>k__BackingField");
			XmlNodeConverter.NativeFieldInfoPtr__WriteArrayAttribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "<WriteArrayAttribute>k__BackingField");
			XmlNodeConverter.NativeFieldInfoPtr__OmitRootObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "<OmitRootObject>k__BackingField");
			XmlNodeConverter.NativeFieldInfoPtr__EncodeSpecialCharacters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, "<EncodeSpecialCharacters>k__BackingField");
			XmlNodeConverter.NativeMethodInfoPtr_get_DeserializeRootElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667302);
			XmlNodeConverter.NativeMethodInfoPtr_set_DeserializeRootElementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667303);
			XmlNodeConverter.NativeMethodInfoPtr_get_WriteArrayAttribute_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667304);
			XmlNodeConverter.NativeMethodInfoPtr_set_WriteArrayAttribute_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667305);
			XmlNodeConverter.NativeMethodInfoPtr_get_OmitRootObject_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667306);
			XmlNodeConverter.NativeMethodInfoPtr_set_OmitRootObject_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667307);
			XmlNodeConverter.NativeMethodInfoPtr_get_EncodeSpecialCharacters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667308);
			XmlNodeConverter.NativeMethodInfoPtr_set_EncodeSpecialCharacters_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667309);
			XmlNodeConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667310);
			XmlNodeConverter.NativeMethodInfoPtr_WrapXml_Private_IXmlNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667311);
			XmlNodeConverter.NativeMethodInfoPtr_PushParentNamespaces_Private_Void_IXmlNode_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667312);
			XmlNodeConverter.NativeMethodInfoPtr_ResolveFullName_Private_String_IXmlNode_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667313);
			XmlNodeConverter.NativeMethodInfoPtr_GetPropertyName_Private_String_IXmlNode_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667314);
			XmlNodeConverter.NativeMethodInfoPtr_IsArray_Private_Boolean_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667315);
			XmlNodeConverter.NativeMethodInfoPtr_SerializeGroupedNodes_Private_Void_JsonWriter_IXmlNode_XmlNamespaceManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667316);
			XmlNodeConverter.NativeMethodInfoPtr_WriteGroupedNodes_Private_Void_JsonWriter_XmlNamespaceManager_Boolean_List_1_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667317);
			XmlNodeConverter.NativeMethodInfoPtr_WriteGroupedNodes_Private_Void_JsonWriter_XmlNamespaceManager_Boolean_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667318);
			XmlNodeConverter.NativeMethodInfoPtr_SerializeNode_Private_Void_JsonWriter_IXmlNode_XmlNamespaceManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667319);
			XmlNodeConverter.NativeMethodInfoPtr_AllSameName_Private_Static_Boolean_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667320);
			XmlNodeConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667321);
			XmlNodeConverter.NativeMethodInfoPtr_DeserializeValue_Private_Void_JsonReader_IXmlDocument_XmlNamespaceManager_String_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667322);
			XmlNodeConverter.NativeMethodInfoPtr_ReadElement_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667323);
			XmlNodeConverter.NativeMethodInfoPtr_CreateElement_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_XmlNamespaceManager_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667324);
			XmlNodeConverter.NativeMethodInfoPtr_AddAttribute_Private_Static_Void_JsonReader_IXmlDocument_IXmlNode_String_String_XmlNamespaceManager_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667325);
			XmlNodeConverter.NativeMethodInfoPtr_ConvertTokenToXmlValue_Private_Static_String_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667326);
			XmlNodeConverter.NativeMethodInfoPtr_ReadArrayElements_Private_Void_JsonReader_IXmlDocument_String_IXmlNode_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667327);
			XmlNodeConverter.NativeMethodInfoPtr_AddJsonArrayAttribute_Private_Void_IXmlElement_IXmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667328);
			XmlNodeConverter.NativeMethodInfoPtr_ShouldReadInto_Private_Boolean_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667329);
			XmlNodeConverter.NativeMethodInfoPtr_ReadAttributeElements_Private_Dictionary_2_String_String_JsonReader_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667330);
			XmlNodeConverter.NativeMethodInfoPtr_CreateInstruction_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667331);
			XmlNodeConverter.NativeMethodInfoPtr_CreateDocumentType_Private_Void_JsonReader_IXmlDocument_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667332);
			XmlNodeConverter.NativeMethodInfoPtr_CreateElement_Private_IXmlElement_String_IXmlDocument_String_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667333);
			XmlNodeConverter.NativeMethodInfoPtr_DeserializeNode_Private_Void_JsonReader_IXmlDocument_XmlNamespaceManager_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667334);
			XmlNodeConverter.NativeMethodInfoPtr_IsNamespaceAttribute_Private_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667335);
			XmlNodeConverter.NativeMethodInfoPtr_ValueAttributes_Private_Boolean_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667336);
			XmlNodeConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667337);
			XmlNodeConverter.NativeMethodInfoPtr_IsXObject_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667338);
			XmlNodeConverter.NativeMethodInfoPtr_IsXmlNode_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667339);
			XmlNodeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr, 100667340);
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x000733B8 File Offset: 0x000715B8
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x000733F0 File Offset: 0x000715F0
		public unsafe string DeserializeRootElementName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_get_DeserializeRootElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_set_DeserializeRootElementName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00073434 File Offset: 0x00071634
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x00073470 File Offset: 0x00071670
		public unsafe bool WriteArrayAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_get_WriteArrayAttribute_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_set_WriteArrayAttribute_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000734B0 File Offset: 0x000716B0
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x000734EC File Offset: 0x000716EC
		public unsafe bool OmitRootObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_get_OmitRootObject_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_set_OmitRootObject_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0007352C File Offset: 0x0007172C
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x00073568 File Offset: 0x00071768
		public unsafe bool EncodeSpecialCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_get_EncodeSpecialCharacters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_set_EncodeSpecialCharacters_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000735A8 File Offset: 0x000717A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765744, XrefRangeEnd = 765761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNodeConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0007361C File Offset: 0x0007181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765761, XrefRangeEnd = 765776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IXmlNode WrapXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_WrapXml_Private_IXmlNode_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0007366C File Offset: 0x0007186C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765836, RefRangeEnd = 765837, XrefRangeStart = 765776, XrefRangeEnd = 765836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_PushParentNamespaces_Private_Void_IXmlNode_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000736C0 File Offset: 0x000718C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 765868, RefRangeEnd = 765870, XrefRangeStart = 765837, XrefRangeEnd = 765868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_ResolveFullName_Private_String_IXmlNode_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0007371C File Offset: 0x0007191C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 765901, RefRangeEnd = 765903, XrefRangeStart = 765870, XrefRangeEnd = 765901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_GetPropertyName_Private_String_IXmlNode_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00073778 File Offset: 0x00071978
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 765932, RefRangeEnd = 765935, XrefRangeStart = 765903, XrefRangeEnd = 765932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsArray(IXmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_IsArray_Private_Boolean_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000737C8 File Offset: 0x000719C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766029, RefRangeEnd = 766030, XrefRangeStart = 765935, XrefRangeEnd = 766029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writePropertyName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_SerializeGroupedNodes_Private_Void_JsonWriter_IXmlNode_XmlNamespaceManager_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0007383C File Offset: 0x00071A3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 766038, RefRangeEnd = 766040, XrefRangeStart = 766030, XrefRangeEnd = 766038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writePropertyName;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groupedNodes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_WriteGroupedNodes_Private_Void_JsonWriter_XmlNamespaceManager_Boolean_List_1_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000738C4 File Offset: 0x00071AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766044, RefRangeEnd = 766045, XrefRangeStart = 766040, XrefRangeEnd = 766044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writePropertyName;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_WriteGroupedNodes_Private_Void_JsonWriter_XmlNamespaceManager_Boolean_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0007394C File Offset: 0x00071B4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 766148, RefRangeEnd = 766153, XrefRangeStart = 766045, XrefRangeEnd = 766148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writePropertyName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_SerializeNode_Private_Void_JsonWriter_IXmlNode_XmlNamespaceManager_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000739C0 File Offset: 0x00071BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766171, RefRangeEnd = 766172, XrefRangeStart = 766153, XrefRangeEnd = 766171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllSameName(IXmlNode node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_AllSameName_Private_Static_Boolean_IXmlNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00073A04 File Offset: 0x00071C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766172, XrefRangeEnd = 766276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ReadJson(JsonReader reader, Type objectType, Object existingValue, JsonSerializer serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNodeConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00073A98 File Offset: 0x00071C98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 766293, RefRangeEnd = 766297, XrefRangeStart = 766276, XrefRangeEnd = 766293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_DeserializeValue_Private_Void_JsonReader_IXmlDocument_XmlNamespaceManager_String_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00073B24 File Offset: 0x00071D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766307, RefRangeEnd = 766308, XrefRangeStart = 766297, XrefRangeEnd = 766307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_ReadElement_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00073BB0 File Offset: 0x00071DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766347, RefRangeEnd = 766348, XrefRangeStart = 766308, XrefRangeEnd = 766347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementPrefix);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeNameValues);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_CreateElement_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_XmlNamespaceManager_String_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00073C64 File Offset: 0x00071E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766348, XrefRangeEnd = 766384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributePrefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_AddAttribute_Private_Static_Void_JsonReader_IXmlDocument_IXmlNode_String_String_XmlNamespaceManager_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00073D0C File Offset: 0x00071F0C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 766402, RefRangeEnd = 766413, XrefRangeStart = 766384, XrefRangeEnd = 766402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConvertTokenToXmlValue(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_ConvertTokenToXmlValue_Private_Static_String_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00073D48 File Offset: 0x00071F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766413, XrefRangeEnd = 766446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_ReadArrayElements_Private_Void_JsonReader_IXmlDocument_String_IXmlNode_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00073DD4 File Offset: 0x00071FD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 766472, RefRangeEnd = 766475, XrefRangeStart = 766446, XrefRangeEnd = 766472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_AddJsonArrayAttribute_Private_Void_IXmlElement_IXmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00073E28 File Offset: 0x00072028
		[CallerCount(0)]
		public unsafe bool ShouldReadInto(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_ShouldReadInto_Private_Boolean_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00073E78 File Offset: 0x00072078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766475, XrefRangeEnd = 766553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_ReadAttributeElements_Private_Dictionary_2_String_String_JsonReader_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00073EDC File Offset: 0x000720DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766553, XrefRangeEnd = 766611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_CreateInstruction_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00073F58 File Offset: 0x00072158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766611, XrefRangeEnd = 766668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_CreateDocumentType_Private_Void_JsonReader_IXmlDocument_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00073FC0 File Offset: 0x000721C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 766681, RefRangeEnd = 766683, XrefRangeStart = 766668, XrefRangeEnd = 766681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementPrefix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_CreateElement_Private_IXmlElement_String_IXmlDocument_String_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00074048 File Offset: 0x00072248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766742, RefRangeEnd = 766743, XrefRangeStart = 766683, XrefRangeEnd = 766742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(document);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_DeserializeNode_Private_Void_JsonReader_IXmlDocument_XmlNamespaceManager_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000740C4 File Offset: 0x000722C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766750, RefRangeEnd = 766751, XrefRangeStart = 766743, XrefRangeEnd = 766750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_IsNamespaceAttribute_Private_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0007412C File Offset: 0x0007232C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766776, RefRangeEnd = 766777, XrefRangeStart = 766751, XrefRangeEnd = 766776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValueAttributes(List<IXmlNode> c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_ValueAttributes_Private_Boolean_List_1_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0007417C File Offset: 0x0007237C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766777, XrefRangeEnd = 766783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type valueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNodeConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000741D4 File Offset: 0x000723D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766783, XrefRangeEnd = 766790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXObject(Type valueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_IsXObject_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00074224 File Offset: 0x00072424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766790, XrefRangeEnd = 766797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXmlNode(Type valueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr_IsXmlNode_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00074274 File Offset: 0x00072474
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x000084F8 File Offset: 0x000066F8
		public XmlNodeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x000742B0 File Offset: 0x000724B0
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x00008501 File Offset: 0x00006701
		public unsafe static List<IXmlNode> EmptyChildNodes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlNodeConverter.NativeFieldInfoPtr_EmptyChildNodes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlNodeConverter.NativeFieldInfoPtr_EmptyChildNodes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000742D8 File Offset: 0x000724D8
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x00008513 File Offset: 0x00006713
		public unsafe static string TextName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlNodeConverter.NativeFieldInfoPtr_TextName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlNodeConverter.NativeFieldInfoPtr_TextName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x000742F8 File Offset: 0x000724F8
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x00008525 File Offset: 0x00006725
		public unsafe static string CommentName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlNodeConverter.NativeFieldInfoPtr_CommentName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlNodeConverter.NativeFieldInfoPtr_CommentName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00074318 File Offset: 0x00072518
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x00008537 File Offset: 0x00006737
		public unsafe static string CDataName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlNodeConverter.NativeFieldInfoPtr_CDataName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlNodeConverter.NativeFieldInfoPtr_CDataName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00074338 File Offset: 0x00072538
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x00008549 File Offset: 0x00006749
		public unsafe static string WhitespaceName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlNodeConverter.NativeFieldInfoPtr_WhitespaceName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlNodeConverter.NativeFieldInfoPtr_WhitespaceName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x00074358 File Offset: 0x00072558
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x0000855B File Offset: 0x0000675B
		public unsafe static string SignificantWhitespaceName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlNodeConverter.NativeFieldInfoPtr_SignificantWhitespaceName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlNodeConverter.NativeFieldInfoPtr_SignificantWhitespaceName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00074378 File Offset: 0x00072578
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x0000856D File Offset: 0x0000676D
		public unsafe static string DeclarationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlNodeConverter.NativeFieldInfoPtr_DeclarationName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlNodeConverter.NativeFieldInfoPtr_DeclarationName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00074398 File Offset: 0x00072598
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x0000857F File Offset: 0x0000677F
		public unsafe static string JsonNamespaceUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlNodeConverter.NativeFieldInfoPtr_JsonNamespaceUri, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlNodeConverter.NativeFieldInfoPtr_JsonNamespaceUri, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x000743B8 File Offset: 0x000725B8
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x00008591 File Offset: 0x00006791
		public unsafe string _DeserializeRootElementName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeConverter.NativeFieldInfoPtr__DeserializeRootElementName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeConverter.NativeFieldInfoPtr__DeserializeRootElementName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x000743E0 File Offset: 0x000725E0
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x000085B0 File Offset: 0x000067B0
		public unsafe bool _WriteArrayAttribute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeConverter.NativeFieldInfoPtr__WriteArrayAttribute_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeConverter.NativeFieldInfoPtr__WriteArrayAttribute_k__BackingField)) = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x00074408 File Offset: 0x00072608
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x000085CB File Offset: 0x000067CB
		public unsafe bool _OmitRootObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeConverter.NativeFieldInfoPtr__OmitRootObject_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeConverter.NativeFieldInfoPtr__OmitRootObject_k__BackingField)) = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x00074430 File Offset: 0x00072630
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x000085E6 File Offset: 0x000067E6
		public unsafe bool _EncodeSpecialCharacters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeConverter.NativeFieldInfoPtr__EncodeSpecialCharacters_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeConverter.NativeFieldInfoPtr__EncodeSpecialCharacters_k__BackingField)) = value;
			}
		}

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeFieldInfoPtr_EmptyChildNodes;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeFieldInfoPtr_TextName;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeFieldInfoPtr_CommentName;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_CDataName;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_WhitespaceName;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_SignificantWhitespaceName;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeFieldInfoPtr_DeclarationName;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeFieldInfoPtr_JsonNamespaceUri;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeFieldInfoPtr__DeserializeRootElementName_k__BackingField;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeFieldInfoPtr__WriteArrayAttribute_k__BackingField;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeFieldInfoPtr__OmitRootObject_k__BackingField;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeFieldInfoPtr__EncodeSpecialCharacters_k__BackingField;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_get_DeserializeRootElementName_Public_get_String_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_set_DeserializeRootElementName_Public_set_Void_String_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteArrayAttribute_Public_get_Boolean_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_set_WriteArrayAttribute_Public_set_Void_Boolean_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_get_OmitRootObject_Public_get_Boolean_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_set_OmitRootObject_Public_set_Void_Boolean_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodeSpecialCharacters_Public_get_Boolean_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_set_EncodeSpecialCharacters_Public_set_Void_Boolean_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_WrapXml_Private_IXmlNode_Object_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_PushParentNamespaces_Private_Void_IXmlNode_XmlNamespaceManager_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_ResolveFullName_Private_String_IXmlNode_XmlNamespaceManager_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyName_Private_String_IXmlNode_XmlNamespaceManager_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_IsArray_Private_Boolean_IXmlNode_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_SerializeGroupedNodes_Private_Void_JsonWriter_IXmlNode_XmlNamespaceManager_Boolean_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_WriteGroupedNodes_Private_Void_JsonWriter_XmlNamespaceManager_Boolean_List_1_IXmlNode_String_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_WriteGroupedNodes_Private_Void_JsonWriter_XmlNamespaceManager_Boolean_IXmlNode_String_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_SerializeNode_Private_Void_JsonWriter_IXmlNode_XmlNamespaceManager_Boolean_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_AllSameName_Private_Static_Boolean_IXmlNode_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeValue_Private_Void_JsonReader_IXmlDocument_XmlNamespaceManager_String_IXmlNode_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_ReadElement_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_XmlNamespaceManager_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_XmlNamespaceManager_String_Dictionary_2_String_String_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_Static_Void_JsonReader_IXmlDocument_IXmlNode_String_String_XmlNamespaceManager_String_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTokenToXmlValue_Private_Static_String_JsonReader_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElements_Private_Void_JsonReader_IXmlDocument_String_IXmlNode_XmlNamespaceManager_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_AddJsonArrayAttribute_Private_Void_IXmlElement_IXmlDocument_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_ShouldReadInto_Private_Boolean_JsonReader_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeElements_Private_Dictionary_2_String_String_JsonReader_XmlNamespaceManager_0;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstruction_Private_Void_JsonReader_IXmlDocument_IXmlNode_String_0;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_CreateDocumentType_Private_Void_JsonReader_IXmlDocument_IXmlNode_0;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Private_IXmlElement_String_IXmlDocument_String_XmlNamespaceManager_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeNode_Private_Void_JsonReader_IXmlDocument_XmlNamespaceManager_IXmlNode_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_IsNamespaceAttribute_Private_Boolean_String_byref_String_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_ValueAttributes_Private_Boolean_List_1_IXmlNode_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_IsXObject_Private_Boolean_Type_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_IsXmlNode_Private_Boolean_Type_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
