using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004E RID: 78
	public class XmlUtf8RawTextWriter : XmlRawWriter
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x0003ABC4 File Offset: 0x00038DC4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUtf8RawTextWriter()
		{
			Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlUtf8RawTextWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr);
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "useAsync");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "bufBytes");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "stream");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "encoding");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "xmlCharType");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "bufPos");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_textPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "textPos");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_contentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "contentPos");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_cdataPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "cdataPos");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_attrEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "attrEndPos");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "bufLen");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_writeToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "writeToNull");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_hadDoubleBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "hadDoubleBracket");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_inAttributeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "inAttributeValue");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_newLineHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "newLineHandling");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_closeOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "closeOutput");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "omitXmlDeclaration");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_newLineChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "newLineChars");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "checkCharacters");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "standalone");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_outputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "outputMethod");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "autoXmlDeclaration");
			XmlUtf8RawTextWriter.NativeFieldInfoPtr_mergeCDataSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, "mergeCDataSections");
			XmlUtf8RawTextWriter.NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664704);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664705);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664706);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664707);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664708);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664709);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664710);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664711);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664712);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664713);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664714);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664715);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664716);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664717);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664718);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664719);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664720);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664721);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664722);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664723);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664724);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664725);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664726);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664727);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664728);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664729);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664730);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664731);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664732);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_FlushEncoder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664733);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664734);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664735);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664736);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664737);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664738);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664739);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664740);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_IsSurrogateByte_Private_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664741);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Byte_ptr_Char_ptr_Char_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664742);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Byte_Int32_ptr_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664743);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664744);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_EncodeMultibyteUTF8_Internal_Static_ptr_Byte_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664745);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_CharToUTF8_Internal_Static_Void_byref_ptr_Char_ptr_Char_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664746);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664747);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664748);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664749);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664750);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664751);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664752);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664753);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664754);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Byte_ptr_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664755);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664756);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664757);
			XmlUtf8RawTextWriter.NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr, 100664758);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0003B20C File Offset: 0x0003940C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370824, XrefRangeEnd = 370831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUtf8RawTextWriter(XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0003B258 File Offset: 0x00039458
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370845, RefRangeEnd = 370848, XrefRangeStart = 370831, XrefRangeEnd = 370845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUtf8RawTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0003B2B8 File Offset: 0x000394B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370848, XrefRangeEnd = 370876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0003B304 File Offset: 0x00039504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370876, XrefRangeEnd = 370878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteXmlDeclaration(string xmldecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmldecl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0003B354 File Offset: 0x00039554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370904, RefRangeEnd = 370905, XrefRangeStart = 370878, XrefRangeEnd = 370904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0003B3D8 File Offset: 0x000395D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370909, RefRangeEnd = 370910, XrefRangeStart = 370905, XrefRangeEnd = 370909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0003B44C File Offset: 0x0003964C
		[CallerCount(0)]
		public unsafe override void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0003B488 File Offset: 0x00039688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370915, RefRangeEnd = 370917, XrefRangeStart = 370910, XrefRangeEnd = 370915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndElement(string prefix, string localName, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0003B4FC File Offset: 0x000396FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370921, RefRangeEnd = 370922, XrefRangeStart = 370917, XrefRangeEnd = 370921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteFullEndElement(string prefix, string localName, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0003B570 File Offset: 0x00039770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370926, RefRangeEnd = 370927, XrefRangeStart = 370922, XrefRangeEnd = 370926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0003B5E4 File Offset: 0x000397E4
		[CallerCount(0)]
		public unsafe override void WriteEndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0003B620 File Offset: 0x00039820
		[CallerCount(0)]
		public unsafe override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0003B680 File Offset: 0x00039880
		public unsafe override bool SupportsNamespaceDeclarationInChunks
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0003B6C8 File Offset: 0x000398C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370927, XrefRangeEnd = 370938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartNamespaceDeclaration(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0003B718 File Offset: 0x00039918
		[CallerCount(0)]
		public unsafe override void WriteEndNamespaceDeclaration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0003B754 File Offset: 0x00039954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370940, RefRangeEnd = 370941, XrefRangeStart = 370938, XrefRangeEnd = 370940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0003B7A4 File Offset: 0x000399A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370942, RefRangeEnd = 370943, XrefRangeStart = 370941, XrefRangeEnd = 370942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0003B7F4 File Offset: 0x000399F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370943, XrefRangeEnd = 370946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0003B854 File Offset: 0x00039A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370946, XrefRangeEnd = 370948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0003B8A4 File Offset: 0x00039AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370955, RefRangeEnd = 370956, XrefRangeStart = 370948, XrefRangeEnd = 370955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0003B8F0 File Offset: 0x00039AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370956, XrefRangeEnd = 370960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0003B940 File Offset: 0x00039B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0003B990 File Offset: 0x00039B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370960, XrefRangeEnd = 370967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0003B9E8 File Offset: 0x00039BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0003BA54 File Offset: 0x00039C54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370968, RefRangeEnd = 370970, XrefRangeStart = 370967, XrefRangeEnd = 370968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0003BAC0 File Offset: 0x00039CC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370972, RefRangeEnd = 370976, XrefRangeStart = 370970, XrefRangeEnd = 370972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0003BB10 File Offset: 0x00039D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370976, XrefRangeEnd = 370979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0003BB4C File Offset: 0x00039D4C
		[CallerCount(0)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0003BB88 File Offset: 0x00039D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370982, RefRangeEnd = 370983, XrefRangeStart = 370979, XrefRangeEnd = 370982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriter.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0003BBC4 File Offset: 0x00039DC4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_FlushEncoder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0003BBF8 File Offset: 0x00039DF8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 371001, RefRangeEnd = 371009, XrefRangeStart = 370983, XrefRangeEnd = 371001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0003BC44 File Offset: 0x00039E44
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 371028, RefRangeEnd = 371036, XrefRangeStart = 371009, XrefRangeEnd = 371028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0003BC90 File Offset: 0x00039E90
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 371039, RefRangeEnd = 371075, XrefRangeStart = 371036, XrefRangeEnd = 371039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RawText(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0003BCD4 File Offset: 0x00039ED4
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 371085, RefRangeEnd = 371133, XrefRangeStart = 371075, XrefRangeEnd = 371085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrcBegin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0003BD20 File Offset: 0x00039F20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 371149, RefRangeEnd = 371153, XrefRangeStart = 371133, XrefRangeEnd = 371149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrcBegin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0003BD6C File Offset: 0x00039F6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 371172, RefRangeEnd = 371176, XrefRangeStart = 371153, XrefRangeEnd = 371172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCommentOrPi(string text, int stopChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0003BDBC File Offset: 0x00039FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371194, RefRangeEnd = 371195, XrefRangeStart = 371176, XrefRangeEnd = 371194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCDataSection(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0003BE00 File Offset: 0x0003A000
		[CallerCount(0)]
		public unsafe static bool IsSurrogateByte(byte b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_IsSurrogateByte_Private_Static_Boolean_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0003BE40 File Offset: 0x0003A040
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 371198, RefRangeEnd = 371206, XrefRangeStart = 371195, XrefRangeEnd = 371198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Byte_ptr_Char_ptr_Char_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0003BE8C File Offset: 0x0003A08C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371206, RefRangeEnd = 371209, XrefRangeStart = 371206, XrefRangeEnd = 371206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte* InvalidXmlChar(int ch, byte* pDst, bool entitize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pDst;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entitize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Byte_Int32_ptr_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0003BEE8 File Offset: 0x0003A0E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371215, RefRangeEnd = 371216, XrefRangeStart = 371209, XrefRangeEnd = 371215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pSrc);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(pDst);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			pSrc = ((intPtr5 == 0) ? null : new char*(intPtr5));
			IntPtr intPtr6 = intPtr2;
			pDst = ((intPtr6 == 0) ? null : new byte*(intPtr6));
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0003BF78 File Offset: 0x0003A178
		[CallerCount(0)]
		public unsafe static byte* EncodeMultibyteUTF8(int ch, byte* pDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_EncodeMultibyteUTF8_Internal_Static_ptr_Byte_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0003BFB8 File Offset: 0x0003A1B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371221, RefRangeEnd = 371223, XrefRangeStart = 371216, XrefRangeEnd = 371221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pSrc);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pSrcEnd;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(pDst);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_CharToUTF8_Internal_Static_Void_byref_ptr_Char_ptr_Char_byref_ptr_Byte_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			pSrc = ((intPtr5 == 0) ? null : new char*(intPtr5));
			IntPtr intPtr6 = intPtr2;
			pDst = ((intPtr6 == 0) ? null : new byte*(intPtr6));
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0003C03C File Offset: 0x0003A23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371223, XrefRangeEnd = 371226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte* WriteNewLine(byte* pDst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Byte_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0003C07C File Offset: 0x0003A27C
		[CallerCount(0)]
		public unsafe static byte* LtEntity(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0003C0B0 File Offset: 0x0003A2B0
		[CallerCount(0)]
		public unsafe static byte* GtEntity(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371226, RefRangeEnd = 371228, XrefRangeStart = 371226, XrefRangeEnd = 371226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* AmpEntity(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0003C118 File Offset: 0x0003A318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371228, RefRangeEnd = 371230, XrefRangeStart = 371228, XrefRangeEnd = 371228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* QuoteEntity(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0003C14C File Offset: 0x0003A34C
		[CallerCount(0)]
		public unsafe static byte* TabEntity(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0003C180 File Offset: 0x0003A380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371230, RefRangeEnd = 371232, XrefRangeStart = 371230, XrefRangeEnd = 371230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* LineFeedEntity(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0003C1B4 File Offset: 0x0003A3B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371232, RefRangeEnd = 371234, XrefRangeStart = 371232, XrefRangeEnd = 371232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* CarriageReturnEntity(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371234, XrefRangeEnd = 371239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* CharEntity(byte* pDst, char ch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Byte_ptr_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0003C228 File Offset: 0x0003A428
		[CallerCount(0)]
		public unsafe static byte* RawStartCData(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0003C25C File Offset: 0x0003A45C
		[CallerCount(0)]
		public unsafe static byte* RawEndCData(byte* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0003C290 File Offset: 0x0003A490
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 371266, RefRangeEnd = 371272, XrefRangeStart = 371239, XrefRangeEnd = 371266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOnlyWhitespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriter.NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00004B84 File Offset: 0x00002D84
		public XmlUtf8RawTextWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0003C2F4 File Offset: 0x0003A4F4
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00004B8D File Offset: 0x00002D8D
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0003C31C File Offset: 0x0003A51C
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00004BA8 File Offset: 0x00002DA8
		public unsafe Il2CppStructArray<byte> bufBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0003C34C File Offset: 0x0003A54C
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00004BC7 File Offset: 0x00002DC7
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0003C37C File Offset: 0x0003A57C
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00004BE6 File Offset: 0x00002DE6
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x0003C3AC File Offset: 0x0003A5AC
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00004C05 File Offset: 0x00002E05
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0003C3DC File Offset: 0x0003A5DC
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00004C33 File Offset: 0x00002E33
		public unsafe int bufPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufPos)) = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0003C404 File Offset: 0x0003A604
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00004C4E File Offset: 0x00002E4E
		public unsafe int textPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_textPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_textPos)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0003C42C File Offset: 0x0003A62C
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00004C69 File Offset: 0x00002E69
		public unsafe int contentPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_contentPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_contentPos)) = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0003C454 File Offset: 0x0003A654
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00004C84 File Offset: 0x00002E84
		public unsafe int cdataPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_cdataPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_cdataPos)) = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0003C47C File Offset: 0x0003A67C
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00004C9F File Offset: 0x00002E9F
		public unsafe int attrEndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_attrEndPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_attrEndPos)) = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0003C4A4 File Offset: 0x0003A6A4
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00004CBA File Offset: 0x00002EBA
		public unsafe int bufLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_bufLen)) = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0003C4CC File Offset: 0x0003A6CC
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00004CD5 File Offset: 0x00002ED5
		public unsafe bool writeToNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_writeToNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_writeToNull)) = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0003C4F4 File Offset: 0x0003A6F4
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public unsafe bool hadDoubleBracket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_hadDoubleBracket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_hadDoubleBracket)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0003C51C File Offset: 0x0003A71C
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00004D0B File Offset: 0x00002F0B
		public unsafe bool inAttributeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_inAttributeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_inAttributeValue)) = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0003C544 File Offset: 0x0003A744
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00004D26 File Offset: 0x00002F26
		public unsafe NewLineHandling newLineHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_newLineHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_newLineHandling)) = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0003C56C File Offset: 0x0003A76C
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00004D41 File Offset: 0x00002F41
		public unsafe bool closeOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_closeOutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_closeOutput)) = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0003C594 File Offset: 0x0003A794
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00004D5C File Offset: 0x00002F5C
		public unsafe bool omitXmlDeclaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration)) = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0003C5BC File Offset: 0x0003A7BC
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00004D77 File Offset: 0x00002F77
		public unsafe string newLineChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_newLineChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_newLineChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0003C5E4 File Offset: 0x0003A7E4
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00004D96 File Offset: 0x00002F96
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0003C60C File Offset: 0x0003A80C
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00004DB1 File Offset: 0x00002FB1
		public unsafe XmlStandalone standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_standalone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_standalone)) = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0003C634 File Offset: 0x0003A834
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00004DCC File Offset: 0x00002FCC
		public unsafe XmlOutputMethod outputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_outputMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_outputMethod)) = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0003C65C File Offset: 0x0003A85C
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00004DE7 File Offset: 0x00002FE7
		public unsafe bool autoXmlDeclaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration)) = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0003C684 File Offset: 0x0003A884
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00004E02 File Offset: 0x00003002
		public unsafe bool mergeCDataSections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_mergeCDataSections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriter.NativeFieldInfoPtr_mergeCDataSections)) = value;
			}
		}

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr_bufBytes;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_bufPos;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_textPos;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_contentPos;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_cdataPos;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeFieldInfoPtr_attrEndPos;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeFieldInfoPtr_bufLen;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_writeToNull;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_hadDoubleBracket;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_inAttributeValue;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_newLineHandling;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_closeOutput;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeFieldInfoPtr_omitXmlDeclaration;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeFieldInfoPtr_newLineChars;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_outputMethod;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_autoXmlDeclaration;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_mergeCDataSections;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_FlushEncoder_Private_Void_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_RawText_Protected_Void_String_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogateByte_Private_Static_Boolean_Byte_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Byte_ptr_Char_ptr_Char_ptr_Byte_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Byte_Int32_ptr_Byte_Boolean_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Byte_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_EncodeMultibyteUTF8_Internal_Static_ptr_Byte_Int32_ptr_Byte_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_CharToUTF8_Internal_Static_Void_byref_ptr_Char_ptr_Char_byref_ptr_Byte_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Byte_ptr_Byte_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Byte_ptr_Byte_Char_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Byte_ptr_Byte_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0;
	}
}
