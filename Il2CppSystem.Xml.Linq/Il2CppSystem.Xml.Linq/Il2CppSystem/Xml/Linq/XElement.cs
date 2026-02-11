using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200000D RID: 13
	public class XElement : XContainer
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000050F8 File Offset: 0x000032F8
		// Note: this type is marked as 'beforefieldinit'.
		static XElement()
		{
			Il2CppClassPointerStore<XElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XElement>.NativeClassPtr);
			XElement.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement>.NativeClassPtr, "name");
			XElement.NativeFieldInfoPtr_lastAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement>.NativeClassPtr, "lastAttr");
			XElement.NativeMethodInfoPtr__ctor_Public_Void_XName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663403);
			XElement.NativeMethodInfoPtr__ctor_Public_Void_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663404);
			XElement.NativeMethodInfoPtr__ctor_Public_Void_XStreamingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663405);
			XElement.NativeMethodInfoPtr_get_HasAttributes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663406);
			XElement.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663407);
			XElement.NativeMethodInfoPtr_get_Name_Public_get_XName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663408);
			XElement.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663409);
			XElement.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663410);
			XElement.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663411);
			XElement.NativeMethodInfoPtr_Attribute_Public_XAttribute_XName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663412);
			XElement.NativeMethodInfoPtr_Attributes_Public_IEnumerable_1_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663413);
			XElement.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_String_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663414);
			XElement.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663415);
			XElement.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663416);
			XElement.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663417);
			XElement.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663418);
			XElement.NativeMethodInfoPtr_AddAttribute_Internal_Virtual_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663419);
			XElement.NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663420);
			XElement.NativeMethodInfoPtr_AppendAttribute_Internal_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663421);
			XElement.NativeMethodInfoPtr_AppendAttributeSkipNotify_Internal_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663422);
			XElement.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663423);
			XElement.NativeMethodInfoPtr_GetAttributes_Private_IEnumerable_1_XAttribute_XName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663424);
			XElement.NativeMethodInfoPtr_GetNamespaceOfPrefixInScope_Private_String_String_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663425);
			XElement.NativeMethodInfoPtr_ReadElementFrom_Private_Void_XmlReader_LoadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663426);
			XElement.NativeMethodInfoPtr_ReadElementFromImpl_Private_Void_XmlReader_LoadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663427);
			XElement.NativeMethodInfoPtr_SetEndElementLineInfo_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663428);
			XElement.NativeMethodInfoPtr_ValidateNode_Internal_Virtual_Void_XNode_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement>.NativeClassPtr, 100663429);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000536C File Offset: 0x0000356C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237691, RefRangeEnd = 1237693, XrefRangeStart = 1237683, XrefRangeEnd = 1237691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XElement(XName name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr__ctor_Public_Void_XName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000053B8 File Offset: 0x000035B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237693, XrefRangeEnd = 1237706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XElement(XElement other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr__ctor_Public_Void_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005404 File Offset: 0x00003604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237706, XrefRangeEnd = 1237715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XElement(XStreamingElement other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr__ctor_Public_Void_XStreamingElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00005450 File Offset: 0x00003650
		public unsafe bool HasAttributes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1193012, RefRangeEnd = 1193014, XrefRangeStart = 1193012, XrefRangeEnd = 1193014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_get_HasAttributes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000548C File Offset: 0x0000368C
		public unsafe bool IsEmpty
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1237715, RefRangeEnd = 1237716, XrefRangeStart = 1237715, XrefRangeEnd = 1237715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000054C8 File Offset: 0x000036C8
		public unsafe XName Name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_get_Name_Public_get_XName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XName>(intPtr3) : null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00005508 File Offset: 0x00003708
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElement.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00005550 File Offset: 0x00003750
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00005588 File Offset: 0x00003788
		public unsafe string Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1237726, RefRangeEnd = 1237727, XrefRangeStart = 1237716, XrefRangeEnd = 1237726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1237735, RefRangeEnd = 1237736, XrefRangeStart = 1237727, XrefRangeEnd = 1237735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000055CC File Offset: 0x000037CC
		[CallerCount(0)]
		public unsafe XAttribute Attribute(XName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_Attribute_Public_XAttribute_XName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000561C File Offset: 0x0000381C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237743, RefRangeEnd = 1237744, XrefRangeStart = 1237736, XrefRangeEnd = 1237743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<XAttribute> Attributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_Attributes_Public_IEnumerable_1_XAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<XAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000565C File Offset: 0x0000385C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1237760, RefRangeEnd = 1237763, XrefRangeStart = 1237744, XrefRangeEnd = 1237760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefixOfNamespace(XNamespace ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_GetPrefixOfNamespace_Public_String_XNamespace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000056A4 File Offset: 0x000038A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237763, XrefRangeEnd = 1237765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteTo(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElement.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000056F4 File Offset: 0x000038F4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005734 File Offset: 0x00003934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237765, XrefRangeEnd = 1237792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005778 File Offset: 0x00003978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283236, RefRangeEnd = 283237, XrefRangeStart = 283236, XrefRangeEnd = 283237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000057BC File Offset: 0x000039BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237792, XrefRangeEnd = 1237812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAttribute(XAttribute a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElement.NativeMethodInfoPtr_AddAttribute_Internal_Virtual_Void_XAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000580C File Offset: 0x00003A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237812, XrefRangeEnd = 1237830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAttributeSkipNotify(XAttribute a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElement.NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_Void_XAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000585C File Offset: 0x00003A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237830, XrefRangeEnd = 1237844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendAttribute(XAttribute a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_AppendAttribute_Internal_Void_XAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000058A0 File Offset: 0x00003AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237844, XrefRangeEnd = 1237850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendAttributeSkipNotify(XAttribute a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_AppendAttributeSkipNotify_Internal_Void_XAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000058E4 File Offset: 0x00003AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237850, XrefRangeEnd = 1237866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XNode CloneNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElement.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr3) : null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005930 File Offset: 0x00003B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237866, XrefRangeEnd = 1237873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<XAttribute> GetAttributes(XName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_GetAttributes_Private_IEnumerable_1_XAttribute_XName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<XAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005980 File Offset: 0x00003B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237880, RefRangeEnd = 1237881, XrefRangeStart = 1237873, XrefRangeEnd = 1237880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outOfScope);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_GetNamespaceOfPrefixInScope_Private_String_String_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000059DC File Offset: 0x00003BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237881, XrefRangeEnd = 1237884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadElementFrom(XmlReader r, LoadOptions o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_ReadElementFrom_Private_Void_XmlReader_LoadOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005A2C File Offset: 0x00003C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237925, RefRangeEnd = 1237927, XrefRangeStart = 1237884, XrefRangeEnd = 1237925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadElementFromImpl(XmlReader r, LoadOptions o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_ReadElementFromImpl_Private_Void_XmlReader_LoadOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005A7C File Offset: 0x00003C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237927, XrefRangeEnd = 1237932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEndElementLineInfo(int lineNumber, int linePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement.NativeMethodInfoPtr_SetEndElementLineInfo_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005AC8 File Offset: 0x00003CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237932, XrefRangeEnd = 1237936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateNode(XNode node, XNode previous)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previous);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XElement.NativeMethodInfoPtr_ValidateNode_Internal_Virtual_Void_XNode_XNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000022D4 File Offset: 0x000004D4
		public XElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005B28 File Offset: 0x00003D28
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000022DD File Offset: 0x000004DD
		public unsafe XName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005B58 File Offset: 0x00003D58
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000022FC File Offset: 0x000004FC
		public unsafe XAttribute lastAttr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement.NativeFieldInfoPtr_lastAttr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement.NativeFieldInfoPtr_lastAttr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_lastAttr;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XName_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XElement_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XStreamingElement_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAttributes_Public_get_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_XName_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_Attribute_Public_XAttribute_XName_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_Attributes_Public_IEnumerable_1_XAttribute_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixOfNamespace_Public_String_XNamespace_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Internal_Virtual_Void_XAttribute_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_Void_XAttribute_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_AppendAttribute_Internal_Void_XAttribute_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_AppendAttributeSkipNotify_Internal_Void_XAttribute_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Private_IEnumerable_1_XAttribute_XName_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespaceOfPrefixInScope_Private_String_String_XElement_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_ReadElementFrom_Private_Void_XmlReader_LoadOptions_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_ReadElementFromImpl_Private_Void_XmlReader_LoadOptions_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_SetEndElementLineInfo_Internal_Void_Int32_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNode_Internal_Virtual_Void_XNode_XNode_0;

		// Token: 0x02000024 RID: 36
		[ObfuscatedName("System.Xml.Linq.XElement+<GetAttributes>d__116")]
		public sealed class _GetAttributes_d__116 : Object
		{
			// Token: 0x060001AF RID: 431 RVA: 0x00009558 File Offset: 0x00007758
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAttributes_d__116()
			{
				Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XElement>.NativeClassPtr, "<GetAttributes>d__116");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr);
				XElement._GetAttributes_d__116.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, "<>1__state");
				XElement._GetAttributes_d__116.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, "<>2__current");
				XElement._GetAttributes_d__116.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, "<>l__initialThreadId");
				XElement._GetAttributes_d__116.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, "<>4__this");
				XElement._GetAttributes_d__116.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, "name");
				XElement._GetAttributes_d__116.NativeFieldInfoPtr___3__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, "<>3__name");
				XElement._GetAttributes_d__116.NativeFieldInfoPtr__a_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, "<a>5__2");
				XElement._GetAttributes_d__116.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, 100663430);
				XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, 100663431);
				XElement._GetAttributes_d__116.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, 100663432);
				XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XAttribute__get_Current_Private_Virtual_Final_New_get_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, 100663433);
				XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, 100663434);
				XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, 100663435);
				XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, 100663436);
				XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr, 100663437);
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x000096B0 File Offset: 0x000078B0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAttributes_d__116(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XElement._GetAttributes_d__116>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement._GetAttributes_d__116.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x000096F8 File Offset: 0x000078F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x0000972C File Offset: 0x0000792C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237668, XrefRangeEnd = 1237669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement._GetAttributes_d__116.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060001B3 RID: 435 RVA: 0x00009768 File Offset: 0x00007968
			public unsafe XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XAttribute__get_Current_Private_Virtual_Final_New_get_XAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x000097A8 File Offset: 0x000079A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237669, XrefRangeEnd = 1237674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060001B5 RID: 437 RVA: 0x000097DC File Offset: 0x000079DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x0000981C File Offset: 0x00007A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237674, XrefRangeEnd = 1237683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<XAttribute> System_Collections_Generic_IEnumerable_System_Xml_Linq_XAttribute__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<XAttribute>>(intPtr3) : null;
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x0000985C File Offset: 0x00007A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XElement._GetAttributes_d__116.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x000029E7 File Offset: 0x00000BE7
			public _GetAttributes_d__116(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000989C File Offset: 0x00007A9C
			// (set) Token: 0x060001BA RID: 442 RVA: 0x000029F0 File Offset: 0x00000BF0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001BB RID: 443 RVA: 0x000098C4 File Offset: 0x00007AC4
			// (set) Token: 0x060001BC RID: 444 RVA: 0x00002A0B File Offset: 0x00000C0B
			public unsafe XAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001BD RID: 445 RVA: 0x000098F4 File Offset: 0x00007AF4
			// (set) Token: 0x060001BE RID: 446 RVA: 0x00002A2A File Offset: 0x00000C2A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001BF RID: 447 RVA: 0x0000991C File Offset: 0x00007B1C
			// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002A45 File Offset: 0x00000C45
			public unsafe XElement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000994C File Offset: 0x00007B4C
			// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002A64 File Offset: 0x00000C64
			public unsafe XName name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr_name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000997C File Offset: 0x00007B7C
			// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002A83 File Offset: 0x00000C83
			public unsafe XName __3__name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___3__name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr___3__name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060001C5 RID: 453 RVA: 0x000099AC File Offset: 0x00007BAC
			// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002AA2 File Offset: 0x00000CA2
			public unsafe XAttribute _a_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr__a_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XElement._GetAttributes_d__116.NativeFieldInfoPtr__a_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000139 RID: 313
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400013A RID: 314
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400013B RID: 315
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400013C RID: 316
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400013D RID: 317
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400013E RID: 318
			private static readonly IntPtr NativeFieldInfoPtr___3__name;

			// Token: 0x0400013F RID: 319
			private static readonly IntPtr NativeFieldInfoPtr__a_5__2;

			// Token: 0x04000140 RID: 320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XAttribute__get_Current_Private_Virtual_Final_New_get_XAttribute_0;

			// Token: 0x04000144 RID: 324
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000145 RID: 325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000146 RID: 326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XAttribute_0;

			// Token: 0x04000147 RID: 327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
