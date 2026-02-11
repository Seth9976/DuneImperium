using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004D RID: 77
	public class XmlTextWriter : XmlWriter
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x00038FEC File Offset: 0x000371EC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextWriter()
		{
			Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr);
			XmlTextWriter.NativeFieldInfoPtr_textWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "textWriter");
			XmlTextWriter.NativeFieldInfoPtr_xmlEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "xmlEncoder");
			XmlTextWriter.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "encoding");
			XmlTextWriter.NativeFieldInfoPtr_formatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "formatting");
			XmlTextWriter.NativeFieldInfoPtr_indented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "indented");
			XmlTextWriter.NativeFieldInfoPtr_indentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "indentation");
			XmlTextWriter.NativeFieldInfoPtr_indentChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "indentChar");
			XmlTextWriter.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stack");
			XmlTextWriter.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "top");
			XmlTextWriter.NativeFieldInfoPtr_stateTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stateTable");
			XmlTextWriter.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "currentState");
			XmlTextWriter.NativeFieldInfoPtr_lastToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "lastToken");
			XmlTextWriter.NativeFieldInfoPtr_base64Encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "base64Encoder");
			XmlTextWriter.NativeFieldInfoPtr_quoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "quoteChar");
			XmlTextWriter.NativeFieldInfoPtr_curQuoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "curQuoteChar");
			XmlTextWriter.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "namespaces");
			XmlTextWriter.NativeFieldInfoPtr_specialAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "specialAttr");
			XmlTextWriter.NativeFieldInfoPtr_prefixForXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "prefixForXmlNs");
			XmlTextWriter.NativeFieldInfoPtr_flush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "flush");
			XmlTextWriter.NativeFieldInfoPtr_nsStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "nsStack");
			XmlTextWriter.NativeFieldInfoPtr_nsTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "nsTop");
			XmlTextWriter.NativeFieldInfoPtr_nsHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "nsHashtable");
			XmlTextWriter.NativeFieldInfoPtr_useNsHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "useNsHashtable");
			XmlTextWriter.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "xmlCharType");
			XmlTextWriter.NativeFieldInfoPtr_stateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stateName");
			XmlTextWriter.NativeFieldInfoPtr_tokenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "tokenName");
			XmlTextWriter.NativeFieldInfoPtr_stateTableDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stateTableDefault");
			XmlTextWriter.NativeFieldInfoPtr_stateTableDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "stateTableDocument");
			XmlTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664646);
			XmlTextWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664647);
			XmlTextWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664648);
			XmlTextWriter.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664649);
			XmlTextWriter.NativeMethodInfoPtr_get_BaseStream_Public_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664650);
			XmlTextWriter.NativeMethodInfoPtr_set_Namespaces_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664651);
			XmlTextWriter.NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664652);
			XmlTextWriter.NativeMethodInfoPtr_set_QuoteChar_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664653);
			XmlTextWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664654);
			XmlTextWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664655);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndDocument_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664656);
			XmlTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664657);
			XmlTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664658);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664659);
			XmlTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664660);
			XmlTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664661);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664662);
			XmlTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664663);
			XmlTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664664);
			XmlTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664665);
			XmlTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664666);
			XmlTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664667);
			XmlTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664668);
			XmlTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664669);
			XmlTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664670);
			XmlTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664671);
			XmlTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664672);
			XmlTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664673);
			XmlTextWriter.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664674);
			XmlTextWriter.NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664675);
			XmlTextWriter.NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664676);
			XmlTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664677);
			XmlTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664678);
			XmlTextWriter.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664679);
			XmlTextWriter.NativeMethodInfoPtr_StartDocument_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664680);
			XmlTextWriter.NativeMethodInfoPtr_AutoComplete_Private_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664681);
			XmlTextWriter.NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664682);
			XmlTextWriter.NativeMethodInfoPtr_InternalWriteEndElement_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664683);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndStartTag_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664684);
			XmlTextWriter.NativeMethodInfoPtr_WriteEndAttributeQuote_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664685);
			XmlTextWriter.NativeMethodInfoPtr_Indent_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664686);
			XmlTextWriter.NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664687);
			XmlTextWriter.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664688);
			XmlTextWriter.NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664689);
			XmlTextWriter.NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664690);
			XmlTextWriter.NativeMethodInfoPtr_GeneratePrefix_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664691);
			XmlTextWriter.NativeMethodInfoPtr_InternalWriteProcessingInstruction_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664692);
			XmlTextWriter.NativeMethodInfoPtr_LookupNamespace_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664693);
			XmlTextWriter.NativeMethodInfoPtr_LookupNamespaceInCurrentScope_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664694);
			XmlTextWriter.NativeMethodInfoPtr_FindPrefix_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664695);
			XmlTextWriter.NativeMethodInfoPtr_ValidateName_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664696);
			XmlTextWriter.NativeMethodInfoPtr_HandleSpecialAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664697);
			XmlTextWriter.NativeMethodInfoPtr_VerifyPrefixXml_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664698);
			XmlTextWriter.NativeMethodInfoPtr_PushStack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664699);
			XmlTextWriter.NativeMethodInfoPtr_FlushEncoders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, 100664700);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00039698 File Offset: 0x00037898
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370300, RefRangeEnd = 370303, XrefRangeStart = 370283, XrefRangeEnd = 370300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000396D4 File Offset: 0x000378D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370317, RefRangeEnd = 370319, XrefRangeStart = 370303, XrefRangeEnd = 370317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextWriter(Stream w, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00039734 File Offset: 0x00037934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370337, RefRangeEnd = 370338, XrefRangeStart = 370319, XrefRangeEnd = 370337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextWriter(string filename, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00039794 File Offset: 0x00037994
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 370346, RefRangeEnd = 370368, XrefRangeStart = 370338, XrefRangeEnd = 370346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextWriter(TextWriter w)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x000397E0 File Offset: 0x000379E0
		public unsafe Stream BaseStream
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 370371, RefRangeEnd = 370374, XrefRangeStart = 370368, XrefRangeEnd = 370371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_get_BaseStream_Public_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x00039820 File Offset: 0x00037A20
		public unsafe bool Namespaces
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 370374, RefRangeEnd = 370376, XrefRangeStart = 370374, XrefRangeEnd = 370374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_set_Namespaces_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000288 RID: 648
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00039860 File Offset: 0x00037A60
		public unsafe Formatting Formatting
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 370376, RefRangeEnd = 370380, XrefRangeStart = 370376, XrefRangeEnd = 370376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000289 RID: 649
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x000398A0 File Offset: 0x00037AA0
		public unsafe char QuoteChar
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 370380, RefRangeEnd = 370381, XrefRangeStart = 370380, XrefRangeEnd = 370380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_set_QuoteChar_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000398E0 File Offset: 0x00037AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370381, XrefRangeEnd = 370382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0003991C File Offset: 0x00037B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370382, XrefRangeEnd = 370384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartDocument(bool standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00039968 File Offset: 0x00037B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370384, XrefRangeEnd = 370393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteEndDocument_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000399A4 File Offset: 0x00037BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370393, XrefRangeEnd = 370420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysid);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00039A28 File Offset: 0x00037C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370420, XrefRangeEnd = 370442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartElement(string prefix, string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00039A9C File Offset: 0x00037C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370442, XrefRangeEnd = 370443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00039AD8 File Offset: 0x00037CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370443, XrefRangeEnd = 370444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteFullEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00039B14 File Offset: 0x00037D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370444, XrefRangeEnd = 370516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00039B88 File Offset: 0x00037D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370516, XrefRangeEnd = 370517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00039BC4 File Offset: 0x00037DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370517, XrefRangeEnd = 370525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00039C14 File Offset: 0x00037E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370525, XrefRangeEnd = 370535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00039C64 File Offset: 0x00037E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370535, XrefRangeEnd = 370547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteProcessingInstruction(string name, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00039CC4 File Offset: 0x00037EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370547, XrefRangeEnd = 370550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00039D14 File Offset: 0x00037F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370550, XrefRangeEnd = 370552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00039D60 File Offset: 0x00037F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370552, XrefRangeEnd = 370557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00039DB0 File Offset: 0x00037FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370557, XrefRangeEnd = 370559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00039E00 File Offset: 0x00038000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370559, XrefRangeEnd = 370561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lowChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00039E58 File Offset: 0x00038058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370561, XrefRangeEnd = 370563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteChars(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00039EC4 File Offset: 0x000380C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370563, XrefRangeEnd = 370565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00039F30 File Offset: 0x00038130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370565, XrefRangeEnd = 370567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00039F80 File Offset: 0x00038180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370567, XrefRangeEnd = 370574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteBase64(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00039FEC File Offset: 0x000381EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370574, XrefRangeEnd = 370576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteBinHex(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0003A058 File Offset: 0x00038258
		public unsafe override WriteState WriteState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0003A0A0 File Offset: 0x000382A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370576, XrefRangeEnd = 370582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0003A0DC File Offset: 0x000382DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370582, XrefRangeEnd = 370583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0003A118 File Offset: 0x00038318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370583, XrefRangeEnd = 370587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupPrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriter.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0003A16C File Offset: 0x0003836C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370626, RefRangeEnd = 370628, XrefRangeStart = 370587, XrefRangeEnd = 370626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDocument(int standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_StartDocument_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0003A1AC File Offset: 0x000383AC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 370653, RefRangeEnd = 370671, XrefRangeStart = 370628, XrefRangeEnd = 370653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoComplete(XmlTextWriter.Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_AutoComplete_Private_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0003A1EC File Offset: 0x000383EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370671, XrefRangeEnd = 370672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoCompleteAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0003A220 File Offset: 0x00038420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370682, RefRangeEnd = 370684, XrefRangeStart = 370672, XrefRangeEnd = 370682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteEndElement(bool longFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref longFormat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_InternalWriteEndElement_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0003A260 File Offset: 0x00038460
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370697, RefRangeEnd = 370700, XrefRangeStart = 370684, XrefRangeEnd = 370697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEndStartTag(bool empty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref empty;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_WriteEndStartTag_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0003A2A0 File Offset: 0x000384A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370703, RefRangeEnd = 370707, XrefRangeStart = 370700, XrefRangeEnd = 370703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEndAttributeQuote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_WriteEndAttributeQuote_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0003A2D4 File Offset: 0x000384D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370707, RefRangeEnd = 370710, XrefRangeStart = 370707, XrefRangeEnd = 370707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Indent(bool beforeEndElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref beforeEndElement;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_Indent_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0003A314 File Offset: 0x00038514
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370715, RefRangeEnd = 370719, XrefRangeStart = 370710, XrefRangeEnd = 370715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushNamespace(string prefix, string ns, bool declared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declared;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0003A378 File Offset: 0x00038578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370719, XrefRangeEnd = 370738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespace(string prefix, string ns, bool declared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declared;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0003A3DC File Offset: 0x000385DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370744, RefRangeEnd = 370745, XrefRangeStart = 370738, XrefRangeEnd = 370744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToNamespaceHashtable(int namespaceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0003A41C File Offset: 0x0003861C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370745, XrefRangeEnd = 370752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopNamespaces(int indexFrom, int indexTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indexFrom;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0003A468 File Offset: 0x00038668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370752, XrefRangeEnd = 370766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GeneratePrefix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_GeneratePrefix_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0003A4A0 File Offset: 0x000386A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370773, RefRangeEnd = 370775, XrefRangeStart = 370766, XrefRangeEnd = 370773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteProcessingInstruction(string name, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_InternalWriteProcessingInstruction_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0003A4F4 File Offset: 0x000386F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370777, RefRangeEnd = 370781, XrefRangeStart = 370775, XrefRangeEnd = 370777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_LookupNamespace_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0003A544 File Offset: 0x00038744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370781, XrefRangeEnd = 370784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaceInCurrentScope(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_LookupNamespaceInCurrentScope_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0003A594 File Offset: 0x00038794
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370786, RefRangeEnd = 370789, XrefRangeStart = 370784, XrefRangeEnd = 370786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FindPrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_FindPrefix_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0003A5DC File Offset: 0x000387DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370793, RefRangeEnd = 370796, XrefRangeStart = 370789, XrefRangeEnd = 370793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateName(string name, bool isNCName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNCName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_ValidateName_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0003A62C File Offset: 0x0003882C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370802, RefRangeEnd = 370803, XrefRangeStart = 370796, XrefRangeEnd = 370802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSpecialAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_HandleSpecialAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0003A660 File Offset: 0x00038860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370812, RefRangeEnd = 370815, XrefRangeStart = 370803, XrefRangeEnd = 370812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyPrefixXml(string prefix, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_VerifyPrefixXml_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0003A6B4 File Offset: 0x000388B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370815, XrefRangeEnd = 370823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_PushStack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0003A6E8 File Offset: 0x000388E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370823, XrefRangeEnd = 370824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushEncoders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.NativeMethodInfoPtr_FlushEncoders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00004874 File Offset: 0x00002A74
		public XmlTextWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x0003A71C File Offset: 0x0003891C
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x0000487D File Offset: 0x00002A7D
		public unsafe TextWriter textWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_textWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_textWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x0003A74C File Offset: 0x0003894C
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x0000489C File Offset: 0x00002A9C
		public unsafe XmlTextEncoder xmlEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_xmlEncoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextEncoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_xmlEncoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0003A77C File Offset: 0x0003897C
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x000048BB File Offset: 0x00002ABB
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0003A7AC File Offset: 0x000389AC
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x000048DA File Offset: 0x00002ADA
		public unsafe Formatting formatting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_formatting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_formatting)) = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x0003A7D4 File Offset: 0x000389D4
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x000048F5 File Offset: 0x00002AF5
		public unsafe bool indented
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indented);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indented)) = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x0003A7FC File Offset: 0x000389FC
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x00004910 File Offset: 0x00002B10
		public unsafe int indentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indentation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indentation)) = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x0003A824 File Offset: 0x00038A24
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x0000492B File Offset: 0x00002B2B
		public unsafe char indentChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indentChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_indentChar)) = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x0003A84C File Offset: 0x00038A4C
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00004946 File Offset: 0x00002B46
		public unsafe Il2CppReferenceArray<XmlTextWriter.TagInfo> stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextWriter.TagInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0003A87C File Offset: 0x00038A7C
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00004965 File Offset: 0x00002B65
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0003A8A4 File Offset: 0x00038AA4
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00004980 File Offset: 0x00002B80
		public unsafe Il2CppStructArray<XmlTextWriter.State> stateTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_stateTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTextWriter.State>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_stateTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0003A8D4 File Offset: 0x00038AD4
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x0000499F File Offset: 0x00002B9F
		public unsafe XmlTextWriter.State currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0003A8FC File Offset: 0x00038AFC
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x000049BA File Offset: 0x00002BBA
		public unsafe XmlTextWriter.Token lastToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_lastToken);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_lastToken)) = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0003A924 File Offset: 0x00038B24
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x000049D5 File Offset: 0x00002BD5
		public unsafe XmlTextWriterBase64Encoder base64Encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_base64Encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextWriterBase64Encoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_base64Encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x0003A954 File Offset: 0x00038B54
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x000049F4 File Offset: 0x00002BF4
		public unsafe char quoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_quoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_quoteChar)) = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0003A97C File Offset: 0x00038B7C
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x00004A0F File Offset: 0x00002C0F
		public unsafe char curQuoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_curQuoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_curQuoteChar)) = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0003A9A4 File Offset: 0x00038BA4
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x00004A2A File Offset: 0x00002C2A
		public unsafe bool namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_namespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_namespaces)) = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x0003A9CC File Offset: 0x00038BCC
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x00004A45 File Offset: 0x00002C45
		public unsafe XmlTextWriter.SpecialAttr specialAttr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_specialAttr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_specialAttr)) = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x0003A9F4 File Offset: 0x00038BF4
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x00004A60 File Offset: 0x00002C60
		public unsafe string prefixForXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_prefixForXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_prefixForXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0003AA1C File Offset: 0x00038C1C
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00004A7F File Offset: 0x00002C7F
		public unsafe bool flush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_flush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_flush)) = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0003AA44 File Offset: 0x00038C44
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00004A9A File Offset: 0x00002C9A
		public unsafe Il2CppReferenceArray<XmlTextWriter.Namespace> nsStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextWriter.Namespace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0003AA74 File Offset: 0x00038C74
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00004AB9 File Offset: 0x00002CB9
		public unsafe int nsTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsTop)) = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0003AA9C File Offset: 0x00038C9C
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00004AD4 File Offset: 0x00002CD4
		public unsafe Dictionary<string, int> nsHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsHashtable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_nsHashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0003AACC File Offset: 0x00038CCC
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00004AF3 File Offset: 0x00002CF3
		public unsafe bool useNsHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_useNsHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_useNsHashtable)) = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0003AAF4 File Offset: 0x00038CF4
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x00004B0E File Offset: 0x00002D0E
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0003AB24 File Offset: 0x00038D24
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00004B3C File Offset: 0x00002D3C
		public unsafe static Il2CppStringArray stateName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlTextWriter.NativeFieldInfoPtr_stateName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlTextWriter.NativeFieldInfoPtr_stateName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0003AB4C File Offset: 0x00038D4C
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00004B4E File Offset: 0x00002D4E
		public unsafe static Il2CppStringArray tokenName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlTextWriter.NativeFieldInfoPtr_tokenName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlTextWriter.NativeFieldInfoPtr_tokenName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0003AB74 File Offset: 0x00038D74
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00004B60 File Offset: 0x00002D60
		public unsafe static Il2CppStructArray<XmlTextWriter.State> stateTableDefault
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlTextWriter.NativeFieldInfoPtr_stateTableDefault, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTextWriter.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlTextWriter.NativeFieldInfoPtr_stateTableDefault, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0003AB9C File Offset: 0x00038D9C
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00004B72 File Offset: 0x00002D72
		public unsafe static Il2CppStructArray<XmlTextWriter.State> stateTableDocument
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlTextWriter.NativeFieldInfoPtr_stateTableDocument, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTextWriter.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlTextWriter.NativeFieldInfoPtr_stateTableDocument, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr_textWriter;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_xmlEncoder;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr_formatting;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_indented;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_indentation;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr_indentChar;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr_stateTable;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr_lastToken;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr_base64Encoder;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr_quoteChar;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr_curQuoteChar;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr_specialAttr;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr_prefixForXmlNs;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr_flush;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_nsStack;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_nsTop;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_nsHashtable;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_useNsHashtable;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_stateName;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_tokenName;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_stateTableDefault;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_stateTableDocument;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_get_Stream_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespaces_Public_set_Void_Boolean_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_set_QuoteChar_Public_set_Void_Char_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_Boolean_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndDocument_Public_Virtual_Void_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_StartDocument_Private_Void_Int32_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_AutoComplete_Private_Void_Token_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteEndElement_Private_Void_Boolean_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndStartTag_Private_Void_Boolean_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttributeQuote_Private_Void_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_Indent_Private_Void_Boolean_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_PushNamespace_Private_Void_String_String_Boolean_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_Boolean_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePrefix_Private_String_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteProcessingInstruction_Private_Void_String_String_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Private_Int32_String_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaceInCurrentScope_Private_Int32_String_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_FindPrefix_Private_String_String_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_ValidateName_Private_Void_String_Boolean_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_HandleSpecialAttribute_Private_Void_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_VerifyPrefixXml_Private_Void_String_String_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_PushStack_Private_Void_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_FlushEncoders_Private_Void_0;

		// Token: 0x02000229 RID: 553
		public enum NamespaceState
		{
			// Token: 0x04002493 RID: 9363
			Uninitialized,
			// Token: 0x04002494 RID: 9364
			NotDeclaredButInScope,
			// Token: 0x04002495 RID: 9365
			DeclaredButNotWrittenOut,
			// Token: 0x04002496 RID: 9366
			DeclaredAndWrittenOut
		}

		// Token: 0x0200022A RID: 554
		public sealed class TagInfo : ValueType
		{
			// Token: 0x06002FE2 RID: 12258 RVA: 0x000D8BE4 File Offset: 0x000D6DE4
			// Note: this type is marked as 'beforefieldinit'.
			static TagInfo()
			{
				Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "TagInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr);
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "name");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "prefix");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "defaultNs");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "defaultNsState");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "xmlSpace");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "xmlLang");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_prevNsTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "prevNsTop");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefixCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "prefixCount");
				XmlTextWriter.TagInfo.NativeFieldInfoPtr_mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, "mixed");
				XmlTextWriter.TagInfo.NativeMethodInfoPtr_Init_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr, 100664702);
			}

			// Token: 0x06002FE3 RID: 12259 RVA: 0x000D8CD8 File Offset: 0x000D6ED8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 370278, RefRangeEnd = 370281, XrefRangeStart = 370273, XrefRangeEnd = 370278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(int nsTop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref nsTop;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.TagInfo.NativeMethodInfoPtr_Init_Internal_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FE4 RID: 12260 RVA: 0x00013F6E File Offset: 0x0001216E
			public TagInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FE5 RID: 12261 RVA: 0x00013F77 File Offset: 0x00012177
			public TagInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter.TagInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17001022 RID: 4130
			// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x000D8D1C File Offset: 0x000D6F1C
			// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x00013F89 File Offset: 0x00012189
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001023 RID: 4131
			// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x000D8D44 File Offset: 0x000D6F44
			// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x00013FA8 File Offset: 0x000121A8
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001024 RID: 4132
			// (get) Token: 0x06002FEA RID: 12266 RVA: 0x000D8D6C File Offset: 0x000D6F6C
			// (set) Token: 0x06002FEB RID: 12267 RVA: 0x00013FC7 File Offset: 0x000121C7
			public unsafe string defaultNs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNs);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNs), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001025 RID: 4133
			// (get) Token: 0x06002FEC RID: 12268 RVA: 0x000D8D94 File Offset: 0x000D6F94
			// (set) Token: 0x06002FED RID: 12269 RVA: 0x00013FE6 File Offset: 0x000121E6
			public unsafe XmlTextWriter.NamespaceState defaultNsState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNsState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_defaultNsState)) = value;
				}
			}

			// Token: 0x17001026 RID: 4134
			// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000D8DBC File Offset: 0x000D6FBC
			// (set) Token: 0x06002FEF RID: 12271 RVA: 0x00014001 File Offset: 0x00012201
			public unsafe XmlSpace xmlSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlSpace)) = value;
				}
			}

			// Token: 0x17001027 RID: 4135
			// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x000D8DE4 File Offset: 0x000D6FE4
			// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x0001401C File Offset: 0x0001221C
			public unsafe string xmlLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlLang);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001028 RID: 4136
			// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x000D8E0C File Offset: 0x000D700C
			// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x0001403B File Offset: 0x0001223B
			public unsafe int prevNsTop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prevNsTop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prevNsTop)) = value;
				}
			}

			// Token: 0x17001029 RID: 4137
			// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x000D8E34 File Offset: 0x000D7034
			// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x00014056 File Offset: 0x00012256
			public unsafe int prefixCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefixCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_prefixCount)) = value;
				}
			}

			// Token: 0x1700102A RID: 4138
			// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000D8E5C File Offset: 0x000D705C
			// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x00014071 File Offset: 0x00012271
			public unsafe bool mixed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_mixed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.TagInfo.NativeFieldInfoPtr_mixed)) = value;
				}
			}

			// Token: 0x04002497 RID: 9367
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002498 RID: 9368
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002499 RID: 9369
			private static readonly IntPtr NativeFieldInfoPtr_defaultNs;

			// Token: 0x0400249A RID: 9370
			private static readonly IntPtr NativeFieldInfoPtr_defaultNsState;

			// Token: 0x0400249B RID: 9371
			private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

			// Token: 0x0400249C RID: 9372
			private static readonly IntPtr NativeFieldInfoPtr_xmlLang;

			// Token: 0x0400249D RID: 9373
			private static readonly IntPtr NativeFieldInfoPtr_prevNsTop;

			// Token: 0x0400249E RID: 9374
			private static readonly IntPtr NativeFieldInfoPtr_prefixCount;

			// Token: 0x0400249F RID: 9375
			private static readonly IntPtr NativeFieldInfoPtr_mixed;

			// Token: 0x040024A0 RID: 9376
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Int32_0;
		}

		// Token: 0x0200022B RID: 555
		public sealed class Namespace : ValueType
		{
			// Token: 0x06002FF8 RID: 12280 RVA: 0x000D8E84 File Offset: 0x000D7084
			// Note: this type is marked as 'beforefieldinit'.
			static Namespace()
			{
				Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextWriter>.NativeClassPtr, "Namespace");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr);
				XmlTextWriter.Namespace.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, "prefix");
				XmlTextWriter.Namespace.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, "ns");
				XmlTextWriter.Namespace.NativeFieldInfoPtr_declared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, "declared");
				XmlTextWriter.Namespace.NativeFieldInfoPtr_prevNsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, "prevNsIndex");
				XmlTextWriter.Namespace.NativeMethodInfoPtr_Set_Internal_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr, 100664703);
			}

			// Token: 0x06002FF9 RID: 12281 RVA: 0x000D8F14 File Offset: 0x000D7114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370281, XrefRangeEnd = 370283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string ns, bool declared)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declared;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriter.Namespace.NativeMethodInfoPtr_Set_Internal_Void_String_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FFA RID: 12282 RVA: 0x0001408C File Offset: 0x0001228C
			public Namespace(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FFB RID: 12283 RVA: 0x00014095 File Offset: 0x00012295
			public Namespace()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriter.Namespace>.NativeClassPtr))
			{
			}

			// Token: 0x1700102B RID: 4139
			// (get) Token: 0x06002FFC RID: 12284 RVA: 0x000D8F7C File Offset: 0x000D717C
			// (set) Token: 0x06002FFD RID: 12285 RVA: 0x000140A7 File Offset: 0x000122A7
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700102C RID: 4140
			// (get) Token: 0x06002FFE RID: 12286 RVA: 0x000D8FA4 File Offset: 0x000D71A4
			// (set) Token: 0x06002FFF RID: 12287 RVA: 0x000140C6 File Offset: 0x000122C6
			public unsafe string ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_ns);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700102D RID: 4141
			// (get) Token: 0x06003000 RID: 12288 RVA: 0x000D8FCC File Offset: 0x000D71CC
			// (set) Token: 0x06003001 RID: 12289 RVA: 0x000140E5 File Offset: 0x000122E5
			public unsafe bool declared
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_declared);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_declared)) = value;
				}
			}

			// Token: 0x1700102E RID: 4142
			// (get) Token: 0x06003002 RID: 12290 RVA: 0x000D8FF4 File Offset: 0x000D71F4
			// (set) Token: 0x06003003 RID: 12291 RVA: 0x00014100 File Offset: 0x00012300
			public unsafe int prevNsIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_prevNsIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriter.Namespace.NativeFieldInfoPtr_prevNsIndex)) = value;
				}
			}

			// Token: 0x040024A1 RID: 9377
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x040024A2 RID: 9378
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x040024A3 RID: 9379
			private static readonly IntPtr NativeFieldInfoPtr_declared;

			// Token: 0x040024A4 RID: 9380
			private static readonly IntPtr NativeFieldInfoPtr_prevNsIndex;

			// Token: 0x040024A5 RID: 9381
			private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_String_String_Boolean_0;
		}

		// Token: 0x0200022C RID: 556
		public enum SpecialAttr
		{
			// Token: 0x040024A7 RID: 9383
			None,
			// Token: 0x040024A8 RID: 9384
			XmlSpace,
			// Token: 0x040024A9 RID: 9385
			XmlLang,
			// Token: 0x040024AA RID: 9386
			XmlNs
		}

		// Token: 0x0200022D RID: 557
		public enum State
		{
			// Token: 0x040024AC RID: 9388
			Start,
			// Token: 0x040024AD RID: 9389
			Prolog,
			// Token: 0x040024AE RID: 9390
			PostDTD,
			// Token: 0x040024AF RID: 9391
			Element,
			// Token: 0x040024B0 RID: 9392
			Attribute,
			// Token: 0x040024B1 RID: 9393
			Content,
			// Token: 0x040024B2 RID: 9394
			AttrOnly,
			// Token: 0x040024B3 RID: 9395
			Epilog,
			// Token: 0x040024B4 RID: 9396
			Error,
			// Token: 0x040024B5 RID: 9397
			Closed
		}

		// Token: 0x0200022E RID: 558
		public enum Token
		{
			// Token: 0x040024B7 RID: 9399
			PI,
			// Token: 0x040024B8 RID: 9400
			Doctype,
			// Token: 0x040024B9 RID: 9401
			Comment,
			// Token: 0x040024BA RID: 9402
			CData,
			// Token: 0x040024BB RID: 9403
			StartElement,
			// Token: 0x040024BC RID: 9404
			EndElement,
			// Token: 0x040024BD RID: 9405
			LongEndElement,
			// Token: 0x040024BE RID: 9406
			StartAttribute,
			// Token: 0x040024BF RID: 9407
			EndAttribute,
			// Token: 0x040024C0 RID: 9408
			Content,
			// Token: 0x040024C1 RID: 9409
			Base64,
			// Token: 0x040024C2 RID: 9410
			RawData,
			// Token: 0x040024C3 RID: 9411
			Whitespace,
			// Token: 0x040024C4 RID: 9412
			Empty
		}
	}
}
