using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000041 RID: 65
	public class XmlEncodedRawTextWriter : XmlRawWriter
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x00027EC4 File Offset: 0x000260C4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlEncodedRawTextWriter()
		{
			Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlEncodedRawTextWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr);
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "useAsync");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufBytes");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "stream");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "encoding");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "xmlCharType");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_textPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "textPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_contentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "contentPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_cdataPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "cdataPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_attrEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "attrEndPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufLen");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_writeToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "writeToNull");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_hadDoubleBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "hadDoubleBracket");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_inAttributeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "inAttributeValue");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufBytesUsed");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "bufChars");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "encoder");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "writer");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_trackTextContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "trackTextContent");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_inTextContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "inTextContent");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_lastMarkPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "lastMarkPos");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_textContentMarks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "textContentMarks");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_charEntityFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "charEntityFallback");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "newLineHandling");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_closeOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "closeOutput");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "omitXmlDeclaration");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "newLineChars");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "checkCharacters");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "standalone");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_outputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "outputMethod");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "autoXmlDeclaration");
			XmlEncodedRawTextWriter.NativeFieldInfoPtr_mergeCDataSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, "mergeCDataSections");
			XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663935);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663936);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663937);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663938);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663939);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663940);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663941);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663942);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663943);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663944);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663945);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663946);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663947);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663948);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663949);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663950);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663951);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663952);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663953);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663954);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663955);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663956);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663957);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663958);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663959);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663960);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663961);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663962);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663963);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663964);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeChars_Private_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663965);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_FlushEncoder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663966);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663967);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663968);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663969);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663970);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663971);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663972);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663973);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663974);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Char_Int32_ptr_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663975);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663976);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_ChangeTextContentMark_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663977);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_GrowTextContentMarks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663978);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663979);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663980);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663981);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663982);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663983);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663984);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663985);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663986);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Char_ptr_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663987);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663988);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663989);
			XmlEncodedRawTextWriter.NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr, 100663990);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000285D4 File Offset: 0x000267D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365399, RefRangeEnd = 365401, XrefRangeStart = 365392, XrefRangeEnd = 365399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEncodedRawTextWriter(XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00028620 File Offset: 0x00026820
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 365408, RefRangeEnd = 365412, XrefRangeStart = 365401, XrefRangeEnd = 365408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00028680 File Offset: 0x00026880
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 365439, RefRangeEnd = 365444, XrefRangeStart = 365412, XrefRangeEnd = 365439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEncodedRawTextWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000286E0 File Offset: 0x000268E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365444, XrefRangeEnd = 365473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0002872C File Offset: 0x0002692C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365473, XrefRangeEnd = 365475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteXmlDeclaration(string xmldecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmldecl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0002877C File Offset: 0x0002697C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365502, RefRangeEnd = 365503, XrefRangeStart = 365475, XrefRangeEnd = 365502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00028800 File Offset: 0x00026A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365508, RefRangeEnd = 365509, XrefRangeStart = 365503, XrefRangeEnd = 365508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00028874 File Offset: 0x00026A74
		[CallerCount(0)]
		public unsafe override void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000288B0 File Offset: 0x00026AB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 365515, RefRangeEnd = 365518, XrefRangeStart = 365509, XrefRangeEnd = 365515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00028924 File Offset: 0x00026B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365523, RefRangeEnd = 365524, XrefRangeStart = 365518, XrefRangeEnd = 365523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00028998 File Offset: 0x00026B98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365529, RefRangeEnd = 365531, XrefRangeStart = 365524, XrefRangeEnd = 365529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00028A0C File Offset: 0x00026C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365531, XrefRangeEnd = 365532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00028A48 File Offset: 0x00026C48
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00028AA8 File Offset: 0x00026CA8
		public unsafe override bool SupportsNamespaceDeclarationInChunks
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00028AF0 File Offset: 0x00026CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365532, XrefRangeEnd = 365545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartNamespaceDeclaration(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00028B40 File Offset: 0x00026D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365545, XrefRangeEnd = 365546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndNamespaceDeclaration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00028B7C File Offset: 0x00026D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365549, RefRangeEnd = 365550, XrefRangeStart = 365546, XrefRangeEnd = 365549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00028BCC File Offset: 0x00026DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365552, RefRangeEnd = 365553, XrefRangeStart = 365550, XrefRangeEnd = 365552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00028C1C File Offset: 0x00026E1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365557, RefRangeEnd = 365558, XrefRangeStart = 365553, XrefRangeEnd = 365557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00028C7C File Offset: 0x00026E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365558, XrefRangeEnd = 365561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00028CCC File Offset: 0x00026ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365569, RefRangeEnd = 365570, XrefRangeStart = 365561, XrefRangeEnd = 365569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00028D18 File Offset: 0x00026F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365570, XrefRangeEnd = 365575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00028D68 File Offset: 0x00026F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365575, XrefRangeEnd = 365580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00028DB8 File Offset: 0x00026FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365588, RefRangeEnd = 365589, XrefRangeStart = 365580, XrefRangeEnd = 365588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00028E10 File Offset: 0x00027010
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00028E7C File Offset: 0x0002707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365589, XrefRangeEnd = 365591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00028EE8 File Offset: 0x000270E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00028F38 File Offset: 0x00027138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365591, XrefRangeEnd = 365595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00028F74 File Offset: 0x00027174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365595, XrefRangeEnd = 365596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00028FB0 File Offset: 0x000271B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365604, RefRangeEnd = 365605, XrefRangeStart = 365596, XrefRangeEnd = 365604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEncodedRawTextWriter.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00028FEC File Offset: 0x000271EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365605, XrefRangeEnd = 365606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EncodeChars(int startOffset, int endOffset, bool writeAllToStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeAllToStream;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeChars_Private_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00029048 File Offset: 0x00027248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365606, RefRangeEnd = 365608, XrefRangeStart = 365606, XrefRangeEnd = 365606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_FlushEncoder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0002907C File Offset: 0x0002727C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 365625, RefRangeEnd = 365630, XrefRangeStart = 365608, XrefRangeEnd = 365625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000290C8 File Offset: 0x000272C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 365648, RefRangeEnd = 365656, XrefRangeStart = 365630, XrefRangeEnd = 365648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00029114 File Offset: 0x00027314
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 365659, RefRangeEnd = 365688, XrefRangeStart = 365656, XrefRangeEnd = 365659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RawText(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00029158 File Offset: 0x00027358
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 365695, RefRangeEnd = 365739, XrefRangeStart = 365688, XrefRangeEnd = 365695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000291A4 File Offset: 0x000273A4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 365752, RefRangeEnd = 365762, XrefRangeStart = 365739, XrefRangeEnd = 365752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000291F0 File Offset: 0x000273F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 365778, RefRangeEnd = 365781, XrefRangeStart = 365762, XrefRangeEnd = 365778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00029240 File Offset: 0x00027440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365796, RefRangeEnd = 365797, XrefRangeStart = 365781, XrefRangeEnd = 365796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCDataSection(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00029284 File Offset: 0x00027484
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 365799, RefRangeEnd = 365806, XrefRangeStart = 365797, XrefRangeEnd = 365799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000292D0 File Offset: 0x000274D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365806, RefRangeEnd = 365808, XrefRangeStart = 365806, XrefRangeEnd = 365806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char* InvalidXmlChar(int ch, char* pDst, bool entitize)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Char_Int32_ptr_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0002932C File Offset: 0x0002752C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365812, RefRangeEnd = 365813, XrefRangeStart = 365808, XrefRangeEnd = 365812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			pSrc = ((intPtr5 == 0) ? null : new char*(intPtr5));
			IntPtr intPtr6 = intPtr2;
			pDst = ((intPtr6 == 0) ? null : new char*(intPtr6));
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000293BC File Offset: 0x000275BC
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 365818, RefRangeEnd = 365863, XrefRangeStart = 365813, XrefRangeEnd = 365818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeTextContentMark(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_ChangeTextContentMark_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000293FC File Offset: 0x000275FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365863, XrefRangeEnd = 365869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowTextContentMarks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_GrowTextContentMarks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00029430 File Offset: 0x00027630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365869, XrefRangeEnd = 365872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char* WriteNewLine(char* pDst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Char_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00029470 File Offset: 0x00027670
		[CallerCount(0)]
		public unsafe static char* LtEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000294A4 File Offset: 0x000276A4
		[CallerCount(0)]
		public unsafe static char* GtEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000294D8 File Offset: 0x000276D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365872, RefRangeEnd = 365874, XrefRangeStart = 365872, XrefRangeEnd = 365872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* AmpEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0002950C File Offset: 0x0002770C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365874, RefRangeEnd = 365876, XrefRangeStart = 365874, XrefRangeEnd = 365874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* QuoteEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00029540 File Offset: 0x00027740
		[CallerCount(0)]
		public unsafe static char* TabEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00029574 File Offset: 0x00027774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365876, RefRangeEnd = 365878, XrefRangeStart = 365876, XrefRangeEnd = 365876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* LineFeedEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000295A8 File Offset: 0x000277A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365878, RefRangeEnd = 365880, XrefRangeStart = 365878, XrefRangeEnd = 365878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* CarriageReturnEntity(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000295DC File Offset: 0x000277DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365880, XrefRangeEnd = 365885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* CharEntity(char* pDst, char ch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Char_ptr_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0002961C File Offset: 0x0002781C
		[CallerCount(0)]
		public unsafe static char* RawStartCData(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00029650 File Offset: 0x00027850
		[CallerCount(0)]
		public unsafe static char* RawEndCData(char* pDst)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00029684 File Offset: 0x00027884
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 365912, RefRangeEnd = 365915, XrefRangeStart = 365885, XrefRangeEnd = 365912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEncodedRawTextWriter.NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000035B6 File Offset: 0x000017B6
		public XmlEncodedRawTextWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000296E8 File Offset: 0x000278E8
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x000035BF File Offset: 0x000017BF
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00029710 File Offset: 0x00027910
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x000035DA File Offset: 0x000017DA
		public unsafe Il2CppStructArray<byte> bufBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00029740 File Offset: 0x00027940
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000035F9 File Offset: 0x000017F9
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00029770 File Offset: 0x00027970
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00003618 File Offset: 0x00001818
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000297A0 File Offset: 0x000279A0
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00003637 File Offset: 0x00001837
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000297D0 File Offset: 0x000279D0
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00003665 File Offset: 0x00001865
		public unsafe int bufPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufPos)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000297F8 File Offset: 0x000279F8
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00003680 File Offset: 0x00001880
		public unsafe int textPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_textPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_textPos)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00029820 File Offset: 0x00027A20
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x0000369B File Offset: 0x0000189B
		public unsafe int contentPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_contentPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_contentPos)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00029848 File Offset: 0x00027A48
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x000036B6 File Offset: 0x000018B6
		public unsafe int cdataPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_cdataPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_cdataPos)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00029870 File Offset: 0x00027A70
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x000036D1 File Offset: 0x000018D1
		public unsafe int attrEndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_attrEndPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_attrEndPos)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00029898 File Offset: 0x00027A98
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x000036EC File Offset: 0x000018EC
		public unsafe int bufLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufLen)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x000298C0 File Offset: 0x00027AC0
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00003707 File Offset: 0x00001907
		public unsafe bool writeToNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_writeToNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_writeToNull)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000298E8 File Offset: 0x00027AE8
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00003722 File Offset: 0x00001922
		public unsafe bool hadDoubleBracket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_hadDoubleBracket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_hadDoubleBracket)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00029910 File Offset: 0x00027B10
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x0000373D File Offset: 0x0000193D
		public unsafe bool inAttributeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_inAttributeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_inAttributeValue)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00029938 File Offset: 0x00027B38
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00003758 File Offset: 0x00001958
		public unsafe int bufBytesUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytesUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufBytesUsed)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00029960 File Offset: 0x00027B60
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00003773 File Offset: 0x00001973
		public unsafe Il2CppStructArray<char> bufChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_bufChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00029990 File Offset: 0x00027B90
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00003792 File Offset: 0x00001992
		public unsafe Encoder encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x000299C0 File Offset: 0x00027BC0
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x000037B1 File Offset: 0x000019B1
		public unsafe TextWriter writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000299F0 File Offset: 0x00027BF0
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x000037D0 File Offset: 0x000019D0
		public unsafe bool trackTextContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_trackTextContent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_trackTextContent)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00029A18 File Offset: 0x00027C18
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x000037EB File Offset: 0x000019EB
		public unsafe bool inTextContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_inTextContent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_inTextContent)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00029A40 File Offset: 0x00027C40
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003806 File Offset: 0x00001A06
		public unsafe int lastMarkPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_lastMarkPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_lastMarkPos)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00029A68 File Offset: 0x00027C68
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00003821 File Offset: 0x00001A21
		public unsafe Il2CppStructArray<int> textContentMarks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_textContentMarks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_textContentMarks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00029A98 File Offset: 0x00027C98
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00003840 File Offset: 0x00001A40
		public unsafe CharEntityEncoderFallback charEntityFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_charEntityFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharEntityEncoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_charEntityFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00029AC8 File Offset: 0x00027CC8
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0000385F File Offset: 0x00001A5F
		public unsafe NewLineHandling newLineHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineHandling)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00029AF0 File Offset: 0x00027CF0
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x0000387A File Offset: 0x00001A7A
		public unsafe bool closeOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_closeOutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_closeOutput)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00029B18 File Offset: 0x00027D18
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00003895 File Offset: 0x00001A95
		public unsafe bool omitXmlDeclaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_omitXmlDeclaration)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00029B40 File Offset: 0x00027D40
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x000038B0 File Offset: 0x00001AB0
		public unsafe string newLineChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_newLineChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00029B68 File Offset: 0x00027D68
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x000038CF File Offset: 0x00001ACF
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00029B90 File Offset: 0x00027D90
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x000038EA File Offset: 0x00001AEA
		public unsafe XmlStandalone standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_standalone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_standalone)) = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00029BB8 File Offset: 0x00027DB8
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00003905 File Offset: 0x00001B05
		public unsafe XmlOutputMethod outputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_outputMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_outputMethod)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00029BE0 File Offset: 0x00027DE0
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00003920 File Offset: 0x00001B20
		public unsafe bool autoXmlDeclaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_autoXmlDeclaration)) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00029C08 File Offset: 0x00027E08
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x0000393B File Offset: 0x00001B3B
		public unsafe bool mergeCDataSections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_mergeCDataSections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEncodedRawTextWriter.NativeFieldInfoPtr_mergeCDataSections)) = value;
			}
		}

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr_bufBytes;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_bufPos;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_textPos;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_contentPos;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_cdataPos;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_attrEndPos;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_bufLen;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_writeToNull;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_hadDoubleBracket;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_inAttributeValue;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_bufBytesUsed;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_bufChars;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_encoder;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_writer;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_trackTextContent;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_inTextContent;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_lastMarkPos;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_textContentMarks;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_charEntityFallback;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_newLineHandling;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_closeOutput;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_omitXmlDeclaration;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_newLineChars;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_outputMethod;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_autoXmlDeclaration;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_mergeCDataSections;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlWriterSettings_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_New_Void_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_EncodeChars_Private_Void_Int32_Int32_Boolean_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_FlushEncoder_Private_Void_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_WriteAttributeTextBlock_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementTextBlock_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_RawText_Protected_Void_String_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_RawText_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_WriteRawWithCharChecking_Protected_Void_ptr_Char_ptr_Char_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_WriteCommentOrPi_Protected_Void_String_Int32_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_WriteCDataSection_Protected_Void_String_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_EncodeSurrogate_Private_Static_ptr_Char_ptr_Char_ptr_Char_ptr_Char_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_InvalidXmlChar_Private_ptr_Char_Int32_ptr_Char_Boolean_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_EncodeChar_Internal_Void_byref_ptr_Char_ptr_Char_byref_ptr_Char_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTextContentMark_Protected_Void_Boolean_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_GrowTextContentMarks_Private_Void_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_WriteNewLine_Protected_ptr_Char_ptr_Char_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_LtEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_GtEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_AmpEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_QuoteEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_TabEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_LineFeedEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_CarriageReturnEntity_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_CharEntity_Private_Static_ptr_Char_ptr_Char_Char_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_RawStartCData_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_RawEndCData_Protected_Static_ptr_Char_ptr_Char_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_ValidateContentChars_Protected_Void_String_String_Boolean_0;
	}
}
