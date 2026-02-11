using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000052 RID: 82
	public class XmlWellFormedWriter : XmlWriter
	{
		// Token: 0x0600096F RID: 2415 RVA: 0x0003F2DC File Offset: 0x0003D4DC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlWellFormedWriter()
		{
			Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlWellFormedWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr);
			XmlWellFormedWriter.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "writer");
			XmlWellFormedWriter.NativeFieldInfoPtr_rawWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "rawWriter");
			XmlWellFormedWriter.NativeFieldInfoPtr_predefinedNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "predefinedNamespaces");
			XmlWellFormedWriter.NativeFieldInfoPtr_nsStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "nsStack");
			XmlWellFormedWriter.NativeFieldInfoPtr_nsTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "nsTop");
			XmlWellFormedWriter.NativeFieldInfoPtr_nsHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "nsHashtable");
			XmlWellFormedWriter.NativeFieldInfoPtr_useNsHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "useNsHashtable");
			XmlWellFormedWriter.NativeFieldInfoPtr_elemScopeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "elemScopeStack");
			XmlWellFormedWriter.NativeFieldInfoPtr_elemTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "elemTop");
			XmlWellFormedWriter.NativeFieldInfoPtr_attrStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "attrStack");
			XmlWellFormedWriter.NativeFieldInfoPtr_attrCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "attrCount");
			XmlWellFormedWriter.NativeFieldInfoPtr_attrHashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "attrHashTable");
			XmlWellFormedWriter.NativeFieldInfoPtr_specAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "specAttr");
			XmlWellFormedWriter.NativeFieldInfoPtr_attrValueCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "attrValueCache");
			XmlWellFormedWriter.NativeFieldInfoPtr_curDeclPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "curDeclPrefix");
			XmlWellFormedWriter.NativeFieldInfoPtr_stateTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "stateTable");
			XmlWellFormedWriter.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "currentState");
			XmlWellFormedWriter.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "checkCharacters");
			XmlWellFormedWriter.NativeFieldInfoPtr_omitDuplNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "omitDuplNamespaces");
			XmlWellFormedWriter.NativeFieldInfoPtr_writeEndDocumentOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "writeEndDocumentOnClose");
			XmlWellFormedWriter.NativeFieldInfoPtr_conformanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "conformanceLevel");
			XmlWellFormedWriter.NativeFieldInfoPtr_dtdWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "dtdWritten");
			XmlWellFormedWriter.NativeFieldInfoPtr_xmlDeclFollows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "xmlDeclFollows");
			XmlWellFormedWriter.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "xmlCharType");
			XmlWellFormedWriter.NativeFieldInfoPtr_hasher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "hasher");
			XmlWellFormedWriter.NativeFieldInfoPtr_stateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "stateName");
			XmlWellFormedWriter.NativeFieldInfoPtr_tokenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "tokenName");
			XmlWellFormedWriter.NativeFieldInfoPtr_state2WriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "state2WriteState");
			XmlWellFormedWriter.NativeFieldInfoPtr_StateTableDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "StateTableDocument");
			XmlWellFormedWriter.NativeFieldInfoPtr_StateTableAuto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "StateTableAuto");
			XmlWellFormedWriter.NativeMethodInfoPtr__ctor_Internal_Void_XmlWriter_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664871);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664872);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664873);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664874);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndDocument_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664875);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664876);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664877);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664878);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664879);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664880);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664881);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664882);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664883);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664884);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664885);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664886);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664887);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664888);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664889);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664890);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664891);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664892);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664893);
			XmlWellFormedWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664894);
			XmlWellFormedWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664895);
			XmlWellFormedWriter.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664896);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664897);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664898);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_RawWriter_Internal_get_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664899);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_SaveAttrValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664900);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_InBase64_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664901);
			XmlWellFormedWriter.NativeMethodInfoPtr_SetSpecialAttribute_Private_Void_SpecialAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664902);
			XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocumentImpl_Private_Void_XmlStandalone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664903);
			XmlWellFormedWriter.NativeMethodInfoPtr_StartFragment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664904);
			XmlWellFormedWriter.NativeMethodInfoPtr_PushNamespaceImplicit_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664905);
			XmlWellFormedWriter.NativeMethodInfoPtr_PushNamespaceExplicit_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664906);
			XmlWellFormedWriter.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NamespaceKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664907);
			XmlWellFormedWriter.NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664908);
			XmlWellFormedWriter.NativeMethodInfoPtr_LookupNamespaceIndex_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664909);
			XmlWellFormedWriter.NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664910);
			XmlWellFormedWriter.NativeMethodInfoPtr_DupAttrException_Private_Static_XmlException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664911);
			XmlWellFormedWriter.NativeMethodInfoPtr_AdvanceState_Private_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664912);
			XmlWellFormedWriter.NativeMethodInfoPtr_StartElementContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664913);
			XmlWellFormedWriter.NativeMethodInfoPtr_GetStateName_Private_Static_String_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664914);
			XmlWellFormedWriter.NativeMethodInfoPtr_LookupNamespace_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664915);
			XmlWellFormedWriter.NativeMethodInfoPtr_LookupLocalNamespace_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664916);
			XmlWellFormedWriter.NativeMethodInfoPtr_GeneratePrefix_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664917);
			XmlWellFormedWriter.NativeMethodInfoPtr_CheckNCName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664918);
			XmlWellFormedWriter.NativeMethodInfoPtr_InvalidCharsException_Private_Static_Exception_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664919);
			XmlWellFormedWriter.NativeMethodInfoPtr_ThrowInvalidStateTransition_Private_Void_Token_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664920);
			XmlWellFormedWriter.NativeMethodInfoPtr_get_IsClosedOrErrorState_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664921);
			XmlWellFormedWriter.NativeMethodInfoPtr_AddAttribute_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664922);
			XmlWellFormedWriter.NativeMethodInfoPtr_AddToAttrHashTable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, 100664923);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0003F988 File Offset: 0x0003DB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371874, XrefRangeEnd = 371950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr__ctor_Internal_Void_XmlWriter_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0003F9E8 File Offset: 0x0003DBE8
		public unsafe override WriteState WriteState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371950, XrefRangeEnd = 371951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0003FA30 File Offset: 0x0003DC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371951, XrefRangeEnd = 371952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0003FA6C File Offset: 0x0003DC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371952, XrefRangeEnd = 371954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartDocument(bool standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0003FAB8 File Offset: 0x0003DCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371954, XrefRangeEnd = 371956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndDocument_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0003FAF4 File Offset: 0x0003DCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371956, XrefRangeEnd = 371970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0003FB78 File Offset: 0x0003DD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371970, XrefRangeEnd = 371989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0003FBEC File Offset: 0x0003DDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371989, XrefRangeEnd = 371992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0003FC28 File Offset: 0x0003DE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371992, XrefRangeEnd = 371995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteFullEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0003FC64 File Offset: 0x0003DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371995, XrefRangeEnd = 372055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartAttribute(string prefix, string localName, string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0003FCD8 File Offset: 0x0003DED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372055, XrefRangeEnd = 372117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0003FD14 File Offset: 0x0003DF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372117, XrefRangeEnd = 372120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0003FD64 File Offset: 0x0003DF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372120, XrefRangeEnd = 372123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0003FDB4 File Offset: 0x0003DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372123, XrefRangeEnd = 372133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0003FE14 File Offset: 0x0003E014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372133, XrefRangeEnd = 372137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0003FE64 File Offset: 0x0003E064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372137, XrefRangeEnd = 372144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0003FEB0 File Offset: 0x0003E0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372144, XrefRangeEnd = 372151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0003FF08 File Offset: 0x0003E108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372151, XrefRangeEnd = 372158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0003FF58 File Offset: 0x0003E158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372158, XrefRangeEnd = 372162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0003FFA8 File Offset: 0x0003E1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372162, XrefRangeEnd = 372166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00040014 File Offset: 0x0003E214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372166, XrefRangeEnd = 372170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00040080 File Offset: 0x0003E280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372170, XrefRangeEnd = 372174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000400D0 File Offset: 0x0003E2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372174, XrefRangeEnd = 372176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0004013C File Offset: 0x0003E33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372176, XrefRangeEnd = 372181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00040178 File Offset: 0x0003E378
		[CallerCount(0)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000401B4 File Offset: 0x0003E3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372181, XrefRangeEnd = 372189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupPrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00040208 File Offset: 0x0003E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372189, XrefRangeEnd = 372194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00040258 File Offset: 0x0003E458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372194, XrefRangeEnd = 372196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlWellFormedWriter.NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x000402C4 File Offset: 0x0003E4C4
		public unsafe XmlRawWriter RawWriter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_get_RawWriter_Internal_get_XmlRawWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlRawWriter>(intPtr3) : null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00040304 File Offset: 0x0003E504
		public unsafe bool SaveAttrValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_get_SaveAttrValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00040340 File Offset: 0x0003E540
		public unsafe bool InBase64
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_get_InBase64_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0004037C File Offset: 0x0003E57C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 372202, RefRangeEnd = 372206, XrefRangeStart = 372196, XrefRangeEnd = 372202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref special;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_SetSpecialAttribute_Private_Void_SpecialAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000403BC File Offset: 0x0003E5BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372215, RefRangeEnd = 372217, XrefRangeStart = 372206, XrefRangeEnd = 372215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartDocumentImpl(XmlStandalone standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_WriteStartDocumentImpl_Private_Void_XmlStandalone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000403FC File Offset: 0x0003E5FC
		[CallerCount(0)]
		public unsafe void StartFragment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_StartFragment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00040430 File Offset: 0x0003E630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372242, RefRangeEnd = 372244, XrefRangeStart = 372217, XrefRangeEnd = 372242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushNamespaceImplicit(string prefix, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_PushNamespaceImplicit_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00040484 File Offset: 0x0003E684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372272, RefRangeEnd = 372274, XrefRangeStart = 372244, XrefRangeEnd = 372272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PushNamespaceExplicit(string prefix, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_PushNamespaceExplicit_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000404E4 File Offset: 0x0003E6E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372289, RefRangeEnd = 372291, XrefRangeStart = 372274, XrefRangeEnd = 372289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NamespaceKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00040548 File Offset: 0x0003E748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372297, RefRangeEnd = 372298, XrefRangeStart = 372291, XrefRangeEnd = 372297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToNamespaceHashtable(int namespaceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00040588 File Offset: 0x0003E788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372300, RefRangeEnd = 372302, XrefRangeStart = 372298, XrefRangeEnd = 372300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaceIndex(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_LookupNamespaceIndex_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000405D8 File Offset: 0x0003E7D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372309, RefRangeEnd = 372311, XrefRangeStart = 372302, XrefRangeEnd = 372309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00040624 File Offset: 0x0003E824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372311, XrefRangeEnd = 372324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlException DupAttrException(string prefix, string localName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_DupAttrException_Private_Static_XmlException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlException>(intPtr3) : null;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0004067C File Offset: 0x0003E87C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 372328, RefRangeEnd = 372353, XrefRangeStart = 372324, XrefRangeEnd = 372328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceState(XmlWellFormedWriter.Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AdvanceState_Private_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000406BC File Offset: 0x0003E8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372363, RefRangeEnd = 372364, XrefRangeStart = 372353, XrefRangeEnd = 372363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_StartElementContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000406F0 File Offset: 0x0003E8F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372369, RefRangeEnd = 372370, XrefRangeStart = 372364, XrefRangeEnd = 372369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStateName(XmlWellFormedWriter.State state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_GetStateName_Private_Static_String_State_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00040728 File Offset: 0x0003E928
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 372374, RefRangeEnd = 372380, XrefRangeStart = 372370, XrefRangeEnd = 372374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_LookupNamespace_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00040770 File Offset: 0x0003E970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372380, XrefRangeEnd = 372382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupLocalNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_LookupLocalNamespace_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000407B8 File Offset: 0x0003E9B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372399, RefRangeEnd = 372401, XrefRangeStart = 372382, XrefRangeEnd = 372399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GeneratePrefix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_GeneratePrefix_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000407F0 File Offset: 0x0003E9F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 372403, RefRangeEnd = 372409, XrefRangeStart = 372401, XrefRangeEnd = 372403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNCName(string ncname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ncname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_CheckNCName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00040834 File Offset: 0x0003EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372409, XrefRangeEnd = 372423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidCharsException(string name, int badCharIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badCharIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_InvalidCharsException_Private_Static_Exception_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00040888 File Offset: 0x0003EA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372423, XrefRangeEnd = 372455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_ThrowInvalidStateTransition_Private_Void_Token_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x000408D4 File Offset: 0x0003EAD4
		public unsafe bool IsClosedOrErrorState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_get_IsClosedOrErrorState_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00040910 File Offset: 0x0003EB10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372471, RefRangeEnd = 372472, XrefRangeStart = 372455, XrefRangeEnd = 372471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(string prefix, string localName, string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AddAttribute_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00040978 File Offset: 0x0003EB78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372481, RefRangeEnd = 372483, XrefRangeStart = 372472, XrefRangeEnd = 372481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToAttrHashTable(int attributeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NativeMethodInfoPtr_AddToAttrHashTable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0000507B File Offset: 0x0000327B
		public XmlWellFormedWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x000409B8 File Offset: 0x0003EBB8
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00005084 File Offset: 0x00003284
		public unsafe XmlWriter writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x000409E8 File Offset: 0x0003EBE8
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x000050A3 File Offset: 0x000032A3
		public unsafe XmlRawWriter rawWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_rawWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlRawWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_rawWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00040A18 File Offset: 0x0003EC18
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x000050C2 File Offset: 0x000032C2
		public unsafe IXmlNamespaceResolver predefinedNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_predefinedNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_predefinedNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00040A48 File Offset: 0x0003EC48
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x000050E1 File Offset: 0x000032E1
		public unsafe Il2CppReferenceArray<XmlWellFormedWriter.Namespace> nsStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlWellFormedWriter.Namespace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00040A78 File Offset: 0x0003EC78
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00005100 File Offset: 0x00003300
		public unsafe int nsTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsTop)) = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00040AA0 File Offset: 0x0003ECA0
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0000511B File Offset: 0x0000331B
		public unsafe Dictionary<string, int> nsHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsHashtable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_nsHashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x00040AD0 File Offset: 0x0003ECD0
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x0000513A File Offset: 0x0000333A
		public unsafe bool useNsHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_useNsHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_useNsHashtable)) = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00040AF8 File Offset: 0x0003ECF8
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x00005155 File Offset: 0x00003355
		public unsafe Il2CppReferenceArray<XmlWellFormedWriter.ElementScope> elemScopeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_elemScopeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlWellFormedWriter.ElementScope>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_elemScopeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00040B28 File Offset: 0x0003ED28
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x00005174 File Offset: 0x00003374
		public unsafe int elemTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_elemTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_elemTop)) = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00040B50 File Offset: 0x0003ED50
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x0000518F File Offset: 0x0000338F
		public unsafe Il2CppReferenceArray<XmlWellFormedWriter.AttrName> attrStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlWellFormedWriter.AttrName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00040B80 File Offset: 0x0003ED80
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x000051AE File Offset: 0x000033AE
		public unsafe int attrCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrCount)) = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00040BA8 File Offset: 0x0003EDA8
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x000051C9 File Offset: 0x000033C9
		public unsafe Dictionary<string, int> attrHashTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrHashTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrHashTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00040BD8 File Offset: 0x0003EDD8
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x000051E8 File Offset: 0x000033E8
		public unsafe XmlWellFormedWriter.SpecialAttribute specAttr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_specAttr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_specAttr)) = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00040C00 File Offset: 0x0003EE00
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x00005203 File Offset: 0x00003403
		public unsafe XmlWellFormedWriter.AttributeValueCache attrValueCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrValueCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWellFormedWriter.AttributeValueCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_attrValueCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00040C30 File Offset: 0x0003EE30
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00005222 File Offset: 0x00003422
		public unsafe string curDeclPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_curDeclPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_curDeclPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00040C58 File Offset: 0x0003EE58
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00005241 File Offset: 0x00003441
		public unsafe Il2CppStructArray<XmlWellFormedWriter.State> stateTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_stateTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlWellFormedWriter.State>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_stateTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00040C88 File Offset: 0x0003EE88
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00005260 File Offset: 0x00003460
		public unsafe XmlWellFormedWriter.State currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00040CB0 File Offset: 0x0003EEB0
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0000527B File Offset: 0x0000347B
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00040CD8 File Offset: 0x0003EED8
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00005296 File Offset: 0x00003496
		public unsafe bool omitDuplNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_omitDuplNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_omitDuplNamespaces)) = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00040D00 File Offset: 0x0003EF00
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x000052B1 File Offset: 0x000034B1
		public unsafe bool writeEndDocumentOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_writeEndDocumentOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_writeEndDocumentOnClose)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00040D28 File Offset: 0x0003EF28
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x000052CC File Offset: 0x000034CC
		public unsafe ConformanceLevel conformanceLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_conformanceLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_conformanceLevel)) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00040D50 File Offset: 0x0003EF50
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x000052E7 File Offset: 0x000034E7
		public unsafe bool dtdWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_dtdWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_dtdWritten)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00040D78 File Offset: 0x0003EF78
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00005302 File Offset: 0x00003502
		public unsafe bool xmlDeclFollows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_xmlDeclFollows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_xmlDeclFollows)) = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00040DA0 File Offset: 0x0003EFA0
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x0000531D File Offset: 0x0000351D
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00040DD0 File Offset: 0x0003EFD0
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0000534B File Offset: 0x0000354B
		public unsafe SecureStringHasher hasher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_hasher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecureStringHasher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NativeFieldInfoPtr_hasher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00040E00 File Offset: 0x0003F000
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x0000536A File Offset: 0x0000356A
		public unsafe static Il2CppStringArray stateName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_stateName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_stateName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00040E28 File Offset: 0x0003F028
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x0000537C File Offset: 0x0000357C
		public unsafe static Il2CppStringArray tokenName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_tokenName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_tokenName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00040E50 File Offset: 0x0003F050
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x0000538E File Offset: 0x0000358E
		public unsafe static Il2CppStructArray<WriteState> state2WriteState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_state2WriteState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WriteState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_state2WriteState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00040E78 File Offset: 0x0003F078
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x000053A0 File Offset: 0x000035A0
		public unsafe static Il2CppStructArray<XmlWellFormedWriter.State> StateTableDocument
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_StateTableDocument, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlWellFormedWriter.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_StateTableDocument, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00040EA0 File Offset: 0x0003F0A0
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x000053B2 File Offset: 0x000035B2
		public unsafe static Il2CppStructArray<XmlWellFormedWriter.State> StateTableAuto
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlWellFormedWriter.NativeFieldInfoPtr_StateTableAuto, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlWellFormedWriter.State>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlWellFormedWriter.NativeFieldInfoPtr_StateTableAuto, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_writer;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr_rawWriter;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr_predefinedNamespaces;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_nsStack;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_nsTop;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr_nsHashtable;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr_useNsHashtable;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr_elemScopeStack;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr_elemTop;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_attrStack;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_attrCount;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_attrHashTable;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr_specAttr;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr_attrValueCache;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr_curDeclPrefix;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr_stateTable;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeFieldInfoPtr_omitDuplNamespaces;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeFieldInfoPtr_writeEndDocumentOnClose;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr_conformanceLevel;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeFieldInfoPtr_dtdWritten;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeFieldInfoPtr_xmlDeclFollows;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr_hasher;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeFieldInfoPtr_stateName;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeFieldInfoPtr_tokenName;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeFieldInfoPtr_state2WriteState;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeFieldInfoPtr_StateTableDocument;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeFieldInfoPtr_StateTableAuto;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlWriter_XmlWriterSettings_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteState_Public_Virtual_get_WriteState_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocument_Public_Virtual_Void_Boolean_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndDocument_Public_Virtual_Void_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Public_Virtual_Void_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Public_Virtual_Void_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_String_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_WriteBinHex_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_get_RawWriter_Internal_get_XmlRawWriter_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveAttrValue_Private_get_Boolean_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_get_InBase64_Private_get_Boolean_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialAttribute_Private_Void_SpecialAttribute_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartDocumentImpl_Private_Void_XmlStandalone_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_StartFragment_Private_Void_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_PushNamespaceImplicit_Private_Void_String_String_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_PushNamespaceExplicit_Private_Boolean_String_String_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NamespaceKind_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_AddToNamespaceHashtable_Private_Void_Int32_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaceIndex_Private_Int32_String_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_PopNamespaces_Private_Void_Int32_Int32_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_DupAttrException_Private_Static_XmlException_String_String_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceState_Private_Void_Token_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Private_Void_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_GetStateName_Private_Static_String_State_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Internal_String_String_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_LookupLocalNamespace_Private_String_String_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePrefix_Private_String_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_CheckNCName_Private_Void_String_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_InvalidCharsException_Private_Static_Exception_String_Int32_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidStateTransition_Private_Void_Token_State_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClosedOrErrorState_Private_get_Boolean_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_Void_String_String_String_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_AddToAttrHashTable_Private_Void_Int32_0;

		// Token: 0x02000231 RID: 561
		public enum State
		{
			// Token: 0x040024D5 RID: 9429
			Start,
			// Token: 0x040024D6 RID: 9430
			TopLevel,
			// Token: 0x040024D7 RID: 9431
			Document,
			// Token: 0x040024D8 RID: 9432
			Element,
			// Token: 0x040024D9 RID: 9433
			Content,
			// Token: 0x040024DA RID: 9434
			B64Content,
			// Token: 0x040024DB RID: 9435
			B64Attribute,
			// Token: 0x040024DC RID: 9436
			AfterRootEle,
			// Token: 0x040024DD RID: 9437
			Attribute,
			// Token: 0x040024DE RID: 9438
			SpecialAttr,
			// Token: 0x040024DF RID: 9439
			EndDocument,
			// Token: 0x040024E0 RID: 9440
			RootLevelAttr,
			// Token: 0x040024E1 RID: 9441
			RootLevelSpecAttr,
			// Token: 0x040024E2 RID: 9442
			RootLevelB64Attr,
			// Token: 0x040024E3 RID: 9443
			AfterRootLevelAttr,
			// Token: 0x040024E4 RID: 9444
			Closed,
			// Token: 0x040024E5 RID: 9445
			Error,
			// Token: 0x040024E6 RID: 9446
			StartContent = 101,
			// Token: 0x040024E7 RID: 9447
			StartContentEle,
			// Token: 0x040024E8 RID: 9448
			StartContentB64,
			// Token: 0x040024E9 RID: 9449
			StartDoc,
			// Token: 0x040024EA RID: 9450
			StartDocEle = 106,
			// Token: 0x040024EB RID: 9451
			EndAttrSEle,
			// Token: 0x040024EC RID: 9452
			EndAttrEEle,
			// Token: 0x040024ED RID: 9453
			EndAttrSCont,
			// Token: 0x040024EE RID: 9454
			EndAttrSAttr = 111,
			// Token: 0x040024EF RID: 9455
			PostB64Cont,
			// Token: 0x040024F0 RID: 9456
			PostB64Attr,
			// Token: 0x040024F1 RID: 9457
			PostB64RootAttr,
			// Token: 0x040024F2 RID: 9458
			StartFragEle,
			// Token: 0x040024F3 RID: 9459
			StartFragCont,
			// Token: 0x040024F4 RID: 9460
			StartFragB64,
			// Token: 0x040024F5 RID: 9461
			StartRootLevelAttr
		}

		// Token: 0x02000232 RID: 562
		public enum Token
		{
			// Token: 0x040024F7 RID: 9463
			StartDocument,
			// Token: 0x040024F8 RID: 9464
			EndDocument,
			// Token: 0x040024F9 RID: 9465
			PI,
			// Token: 0x040024FA RID: 9466
			Comment,
			// Token: 0x040024FB RID: 9467
			Dtd,
			// Token: 0x040024FC RID: 9468
			StartElement,
			// Token: 0x040024FD RID: 9469
			EndElement,
			// Token: 0x040024FE RID: 9470
			StartAttribute,
			// Token: 0x040024FF RID: 9471
			EndAttribute,
			// Token: 0x04002500 RID: 9472
			Text,
			// Token: 0x04002501 RID: 9473
			CData,
			// Token: 0x04002502 RID: 9474
			AtomicValue,
			// Token: 0x04002503 RID: 9475
			Base64,
			// Token: 0x04002504 RID: 9476
			RawData,
			// Token: 0x04002505 RID: 9477
			Whitespace
		}

		// Token: 0x02000233 RID: 563
		public class NamespaceResolverProxy : Object
		{
			// Token: 0x0600300E RID: 12302 RVA: 0x000D9240 File Offset: 0x000D7440
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceResolverProxy()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "NamespaceResolverProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr);
				XmlWellFormedWriter.NamespaceResolverProxy.NativeFieldInfoPtr_wfWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, "wfWriter");
				XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlWellFormedWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, 100664925);
				XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, 100664926);
				XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, 100664927);
				XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr, 100664928);
			}

			// Token: 0x0600300F RID: 12303 RVA: 0x000D92D0 File Offset: 0x000D74D0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespaceResolverProxy(XmlWellFormedWriter wfWriter)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.NamespaceResolverProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wfWriter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlWellFormedWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003010 RID: 12304 RVA: 0x000D931C File Offset: 0x000D751C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371621, XrefRangeEnd = 371626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref scope;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x06003011 RID: 12305 RVA: 0x000D9368 File Offset: 0x000D7568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371626, XrefRangeEnd = 371628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003012 RID: 12306 RVA: 0x000D93B0 File Offset: 0x000D75B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371628, XrefRangeEnd = 371629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.NamespaceResolverProxy.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003013 RID: 12307 RVA: 0x00014162 File Offset: 0x00012362
			public NamespaceResolverProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001032 RID: 4146
			// (get) Token: 0x06003014 RID: 12308 RVA: 0x000D93F8 File Offset: 0x000D75F8
			// (set) Token: 0x06003015 RID: 12309 RVA: 0x0001416B File Offset: 0x0001236B
			public unsafe XmlWellFormedWriter wfWriter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NamespaceResolverProxy.NativeFieldInfoPtr_wfWriter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWellFormedWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.NamespaceResolverProxy.NativeFieldInfoPtr_wfWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002506 RID: 9478
			private static readonly IntPtr NativeFieldInfoPtr_wfWriter;

			// Token: 0x04002507 RID: 9479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlWellFormedWriter_0;

			// Token: 0x04002508 RID: 9480
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

			// Token: 0x04002509 RID: 9481
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

			// Token: 0x0400250A RID: 9482
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;
		}

		// Token: 0x02000234 RID: 564
		public sealed class ElementScope : ValueType
		{
			// Token: 0x06003016 RID: 12310 RVA: 0x000D9428 File Offset: 0x000D7628
			// Note: this type is marked as 'beforefieldinit'.
			static ElementScope()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "ElementScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr);
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prevNSTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "prevNSTop");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "prefix");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "localName");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "namespaceUri");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "xmlSpace");
				XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, "xmlLang");
				XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_Set_Internal_Void_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, 100664929);
				XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_WriteEndElement_Internal_Void_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, 100664930);
				XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_WriteFullEndElement_Internal_Void_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr, 100664931);
			}

			// Token: 0x06003017 RID: 12311 RVA: 0x000D9508 File Offset: 0x000D7708
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371633, RefRangeEnd = 371634, XrefRangeStart = 371629, XrefRangeEnd = 371633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string localName, string namespaceUri, int prevNSTop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevNSTop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_Set_Internal_Void_String_String_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003018 RID: 12312 RVA: 0x000D9584 File Offset: 0x000D7784
			[CallerCount(0)]
			public unsafe void WriteEndElement(XmlRawWriter rawWriter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawWriter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_WriteEndElement_Internal_Void_XmlRawWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003019 RID: 12313 RVA: 0x000D95CC File Offset: 0x000D77CC
			[CallerCount(0)]
			public unsafe void WriteFullEndElement(XmlRawWriter rawWriter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawWriter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.ElementScope.NativeMethodInfoPtr_WriteFullEndElement_Internal_Void_XmlRawWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600301A RID: 12314 RVA: 0x0001418A File Offset: 0x0001238A
			public ElementScope(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600301B RID: 12315 RVA: 0x00014193 File Offset: 0x00012393
			public ElementScope()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.ElementScope>.NativeClassPtr))
			{
			}

			// Token: 0x17001033 RID: 4147
			// (get) Token: 0x0600301C RID: 12316 RVA: 0x000D9614 File Offset: 0x000D7814
			// (set) Token: 0x0600301D RID: 12317 RVA: 0x000141A5 File Offset: 0x000123A5
			public unsafe int prevNSTop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prevNSTop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prevNSTop)) = value;
				}
			}

			// Token: 0x17001034 RID: 4148
			// (get) Token: 0x0600301E RID: 12318 RVA: 0x000D963C File Offset: 0x000D783C
			// (set) Token: 0x0600301F RID: 12319 RVA: 0x000141C0 File Offset: 0x000123C0
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001035 RID: 4149
			// (get) Token: 0x06003020 RID: 12320 RVA: 0x000D9664 File Offset: 0x000D7864
			// (set) Token: 0x06003021 RID: 12321 RVA: 0x000141DF File Offset: 0x000123DF
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001036 RID: 4150
			// (get) Token: 0x06003022 RID: 12322 RVA: 0x000D968C File Offset: 0x000D788C
			// (set) Token: 0x06003023 RID: 12323 RVA: 0x000141FE File Offset: 0x000123FE
			public unsafe string namespaceUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_namespaceUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001037 RID: 4151
			// (get) Token: 0x06003024 RID: 12324 RVA: 0x000D96B4 File Offset: 0x000D78B4
			// (set) Token: 0x06003025 RID: 12325 RVA: 0x0001421D File Offset: 0x0001241D
			public unsafe XmlSpace xmlSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlSpace)) = value;
				}
			}

			// Token: 0x17001038 RID: 4152
			// (get) Token: 0x06003026 RID: 12326 RVA: 0x000D96DC File Offset: 0x000D78DC
			// (set) Token: 0x06003027 RID: 12327 RVA: 0x00014238 File Offset: 0x00012438
			public unsafe string xmlLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlLang);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.ElementScope.NativeFieldInfoPtr_xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400250B RID: 9483
			private static readonly IntPtr NativeFieldInfoPtr_prevNSTop;

			// Token: 0x0400250C RID: 9484
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x0400250D RID: 9485
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x0400250E RID: 9486
			private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

			// Token: 0x0400250F RID: 9487
			private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

			// Token: 0x04002510 RID: 9488
			private static readonly IntPtr NativeFieldInfoPtr_xmlLang;

			// Token: 0x04002511 RID: 9489
			private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_String_String_String_Int32_0;

			// Token: 0x04002512 RID: 9490
			private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Void_XmlRawWriter_0;

			// Token: 0x04002513 RID: 9491
			private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Internal_Void_XmlRawWriter_0;
		}

		// Token: 0x02000235 RID: 565
		public enum NamespaceKind
		{
			// Token: 0x04002515 RID: 9493
			Written,
			// Token: 0x04002516 RID: 9494
			NeedToWrite,
			// Token: 0x04002517 RID: 9495
			Implied,
			// Token: 0x04002518 RID: 9496
			Special
		}

		// Token: 0x02000236 RID: 566
		public sealed class Namespace : ValueType
		{
			// Token: 0x06003028 RID: 12328 RVA: 0x000D9704 File Offset: 0x000D7904
			// Note: this type is marked as 'beforefieldinit'.
			static Namespace()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "Namespace");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr);
				XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, "prefix");
				XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, "namespaceUri");
				XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, "kind");
				XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prevNsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, "prevNsIndex");
				XmlWellFormedWriter.Namespace.NativeMethodInfoPtr_Set_Internal_Void_String_String_NamespaceKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, 100664932);
				XmlWellFormedWriter.Namespace.NativeMethodInfoPtr_WriteDecl_Internal_Void_XmlWriter_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr, 100664933);
			}

			// Token: 0x06003029 RID: 12329 RVA: 0x000D97A8 File Offset: 0x000D79A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371634, XrefRangeEnd = 371636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.Namespace.NativeMethodInfoPtr_Set_Internal_Void_String_String_NamespaceKind_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600302A RID: 12330 RVA: 0x000D9810 File Offset: 0x000D7A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371636, XrefRangeEnd = 371645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.Namespace.NativeMethodInfoPtr_WriteDecl_Internal_Void_XmlWriter_XmlRawWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600302B RID: 12331 RVA: 0x00014257 File Offset: 0x00012457
			public Namespace(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600302C RID: 12332 RVA: 0x00014260 File Offset: 0x00012460
			public Namespace()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.Namespace>.NativeClassPtr))
			{
			}

			// Token: 0x17001039 RID: 4153
			// (get) Token: 0x0600302D RID: 12333 RVA: 0x000D986C File Offset: 0x000D7A6C
			// (set) Token: 0x0600302E RID: 12334 RVA: 0x00014272 File Offset: 0x00012472
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700103A RID: 4154
			// (get) Token: 0x0600302F RID: 12335 RVA: 0x000D9894 File Offset: 0x000D7A94
			// (set) Token: 0x06003030 RID: 12336 RVA: 0x00014291 File Offset: 0x00012491
			public unsafe string namespaceUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_namespaceUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700103B RID: 4155
			// (get) Token: 0x06003031 RID: 12337 RVA: 0x000D98BC File Offset: 0x000D7ABC
			// (set) Token: 0x06003032 RID: 12338 RVA: 0x000142B0 File Offset: 0x000124B0
			public unsafe XmlWellFormedWriter.NamespaceKind kind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_kind);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_kind)) = value;
				}
			}

			// Token: 0x1700103C RID: 4156
			// (get) Token: 0x06003033 RID: 12339 RVA: 0x000D98E4 File Offset: 0x000D7AE4
			// (set) Token: 0x06003034 RID: 12340 RVA: 0x000142CB File Offset: 0x000124CB
			public unsafe int prevNsIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prevNsIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.Namespace.NativeFieldInfoPtr_prevNsIndex)) = value;
				}
			}

			// Token: 0x04002519 RID: 9497
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x0400251A RID: 9498
			private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

			// Token: 0x0400251B RID: 9499
			private static readonly IntPtr NativeFieldInfoPtr_kind;

			// Token: 0x0400251C RID: 9500
			private static readonly IntPtr NativeFieldInfoPtr_prevNsIndex;

			// Token: 0x0400251D RID: 9501
			private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_String_String_NamespaceKind_0;

			// Token: 0x0400251E RID: 9502
			private static readonly IntPtr NativeMethodInfoPtr_WriteDecl_Internal_Void_XmlWriter_XmlRawWriter_0;
		}

		// Token: 0x02000237 RID: 567
		public sealed class AttrName : ValueType
		{
			// Token: 0x06003035 RID: 12341 RVA: 0x000D990C File Offset: 0x000D7B0C
			// Note: this type is marked as 'beforefieldinit'.
			static AttrName()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "AttrName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr);
				XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, "prefix");
				XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, "namespaceUri");
				XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, "localName");
				XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, "prev");
				XmlWellFormedWriter.AttrName.NativeMethodInfoPtr_Set_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, 100664934);
				XmlWellFormedWriter.AttrName.NativeMethodInfoPtr_IsDuplicate_Internal_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr, 100664935);
			}

			// Token: 0x06003036 RID: 12342 RVA: 0x000D99B0 File Offset: 0x000D7BB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371648, RefRangeEnd = 371649, XrefRangeStart = 371645, XrefRangeEnd = 371648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string localName, string namespaceUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttrName.NativeMethodInfoPtr_Set_Internal_Void_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003037 RID: 12343 RVA: 0x000D9A1C File Offset: 0x000D7C1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371650, RefRangeEnd = 371651, XrefRangeStart = 371649, XrefRangeEnd = 371650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsDuplicate(string prefix, string localName, string namespaceUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttrName.NativeMethodInfoPtr_IsDuplicate_Internal_Boolean_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003038 RID: 12344 RVA: 0x000142E6 File Offset: 0x000124E6
			public AttrName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003039 RID: 12345 RVA: 0x000142EF File Offset: 0x000124EF
			public AttrName()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.AttrName>.NativeClassPtr))
			{
			}

			// Token: 0x1700103D RID: 4157
			// (get) Token: 0x0600303A RID: 12346 RVA: 0x000D9A94 File Offset: 0x000D7C94
			// (set) Token: 0x0600303B RID: 12347 RVA: 0x00014301 File Offset: 0x00012501
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700103E RID: 4158
			// (get) Token: 0x0600303C RID: 12348 RVA: 0x000D9ABC File Offset: 0x000D7CBC
			// (set) Token: 0x0600303D RID: 12349 RVA: 0x00014320 File Offset: 0x00012520
			public unsafe string namespaceUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_namespaceUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700103F RID: 4159
			// (get) Token: 0x0600303E RID: 12350 RVA: 0x000D9AE4 File Offset: 0x000D7CE4
			// (set) Token: 0x0600303F RID: 12351 RVA: 0x0001433F File Offset: 0x0001253F
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001040 RID: 4160
			// (get) Token: 0x06003040 RID: 12352 RVA: 0x000D9B0C File Offset: 0x000D7D0C
			// (set) Token: 0x06003041 RID: 12353 RVA: 0x0001435E File Offset: 0x0001255E
			public unsafe int prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prev);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttrName.NativeFieldInfoPtr_prev)) = value;
				}
			}

			// Token: 0x0400251F RID: 9503
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002520 RID: 9504
			private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

			// Token: 0x04002521 RID: 9505
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x04002522 RID: 9506
			private static readonly IntPtr NativeFieldInfoPtr_prev;

			// Token: 0x04002523 RID: 9507
			private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_String_String_String_0;

			// Token: 0x04002524 RID: 9508
			private static readonly IntPtr NativeMethodInfoPtr_IsDuplicate_Internal_Boolean_String_String_String_0;
		}

		// Token: 0x02000238 RID: 568
		public enum SpecialAttribute
		{
			// Token: 0x04002526 RID: 9510
			No,
			// Token: 0x04002527 RID: 9511
			DefaultXmlns,
			// Token: 0x04002528 RID: 9512
			PrefixedXmlns,
			// Token: 0x04002529 RID: 9513
			XmlSpace,
			// Token: 0x0400252A RID: 9514
			XmlLang
		}

		// Token: 0x02000239 RID: 569
		public class AttributeValueCache : Object
		{
			// Token: 0x06003042 RID: 12354 RVA: 0x000D9B34 File Offset: 0x000D7D34
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeValueCache()
			{
				Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter>.NativeClassPtr, "AttributeValueCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr);
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "stringValue");
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_singleStringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "singleStringValue");
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "items");
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_firstItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "firstItem");
				XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_lastItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "lastItem");
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664936);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664937);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664938);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664939);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteWhitespace_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664940);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664941);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664942);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664943);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteRaw_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664944);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteValue_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664945);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Replay_Internal_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664946);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Trim_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664947);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664948);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_StartComplexValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664949);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_AddItem_Private_Void_ItemType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664950);
				XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, 100664951);
			}

			// Token: 0x17001046 RID: 4166
			// (get) Token: 0x06003043 RID: 12355 RVA: 0x000D9D04 File Offset: 0x000D7F04
			public unsafe string StringValue
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 371654, RefRangeEnd = 371658, XrefRangeStart = 371654, XrefRangeEnd = 371654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003044 RID: 12356 RVA: 0x000D9D3C File Offset: 0x000D7F3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371686, RefRangeEnd = 371687, XrefRangeStart = 371658, XrefRangeEnd = 371686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteEntityRef(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003045 RID: 12357 RVA: 0x000D9D80 File Offset: 0x000D7F80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371695, RefRangeEnd = 371696, XrefRangeStart = 371687, XrefRangeEnd = 371695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteCharEntity(char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003046 RID: 12358 RVA: 0x000D9DC0 File Offset: 0x000D7FC0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371707, RefRangeEnd = 371708, XrefRangeStart = 371696, XrefRangeEnd = 371707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteSurrogateCharEntity(char lowChar, char highChar)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003047 RID: 12359 RVA: 0x000D9E0C File Offset: 0x000D800C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371714, RefRangeEnd = 371715, XrefRangeStart = 371708, XrefRangeEnd = 371714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteWhitespace(string ws)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteWhitespace_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003048 RID: 12360 RVA: 0x000D9E50 File Offset: 0x000D8050
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371722, RefRangeEnd = 371723, XrefRangeStart = 371715, XrefRangeEnd = 371722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteString(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003049 RID: 12361 RVA: 0x000D9E94 File Offset: 0x000D8094
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371734, RefRangeEnd = 371735, XrefRangeStart = 371723, XrefRangeEnd = 371734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteChars(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600304A RID: 12362 RVA: 0x000D9EF4 File Offset: 0x000D80F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371746, RefRangeEnd = 371747, XrefRangeStart = 371735, XrefRangeEnd = 371746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteRaw(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600304B RID: 12363 RVA: 0x000D9F54 File Offset: 0x000D8154
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371753, RefRangeEnd = 371754, XrefRangeStart = 371747, XrefRangeEnd = 371753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteRaw(string data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteRaw_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600304C RID: 12364 RVA: 0x000D9F98 File Offset: 0x000D8198
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371760, RefRangeEnd = 371761, XrefRangeStart = 371754, XrefRangeEnd = 371760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteValue(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_WriteValue_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600304D RID: 12365 RVA: 0x000D9FDC File Offset: 0x000D81DC
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 371785, RefRangeEnd = 371791, XrefRangeStart = 371761, XrefRangeEnd = 371785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Replay(XmlWriter writer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Replay_Internal_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600304E RID: 12366 RVA: 0x000DA020 File Offset: 0x000D8220
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371824, RefRangeEnd = 371825, XrefRangeStart = 371791, XrefRangeEnd = 371824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Trim()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Trim_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600304F RID: 12367 RVA: 0x000DA054 File Offset: 0x000D8254
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371828, RefRangeEnd = 371829, XrefRangeStart = 371825, XrefRangeEnd = 371828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003050 RID: 12368 RVA: 0x000DA088 File Offset: 0x000D8288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371829, XrefRangeEnd = 371833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StartComplexValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_StartComplexValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003051 RID: 12369 RVA: 0x000DA0BC File Offset: 0x000D82BC
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 371848, RefRangeEnd = 371867, XrefRangeStart = 371833, XrefRangeEnd = 371848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, Object data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr_AddItem_Private_Void_ItemType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003052 RID: 12370 RVA: 0x000DA10C File Offset: 0x000D830C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 371873, RefRangeEnd = 371874, XrefRangeStart = 371867, XrefRangeEnd = 371873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeValueCache()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003053 RID: 12371 RVA: 0x00014379 File Offset: 0x00012579
			public AttributeValueCache(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001041 RID: 4161
			// (get) Token: 0x06003054 RID: 12372 RVA: 0x000DA148 File Offset: 0x000D8348
			// (set) Token: 0x06003055 RID: 12373 RVA: 0x00014382 File Offset: 0x00012582
			public unsafe StringBuilder stringValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_stringValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_stringValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001042 RID: 4162
			// (get) Token: 0x06003056 RID: 12374 RVA: 0x000DA178 File Offset: 0x000D8378
			// (set) Token: 0x06003057 RID: 12375 RVA: 0x000143A1 File Offset: 0x000125A1
			public unsafe string singleStringValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_singleStringValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_singleStringValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001043 RID: 4163
			// (get) Token: 0x06003058 RID: 12376 RVA: 0x000DA1A0 File Offset: 0x000D83A0
			// (set) Token: 0x06003059 RID: 12377 RVA: 0x000143C0 File Offset: 0x000125C0
			public unsafe Il2CppReferenceArray<XmlWellFormedWriter.AttributeValueCache.Item> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlWellFormedWriter.AttributeValueCache.Item>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001044 RID: 4164
			// (get) Token: 0x0600305A RID: 12378 RVA: 0x000DA1D0 File Offset: 0x000D83D0
			// (set) Token: 0x0600305B RID: 12379 RVA: 0x000143DF File Offset: 0x000125DF
			public unsafe int firstItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_firstItem);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_firstItem)) = value;
				}
			}

			// Token: 0x17001045 RID: 4165
			// (get) Token: 0x0600305C RID: 12380 RVA: 0x000DA1F8 File Offset: 0x000D83F8
			// (set) Token: 0x0600305D RID: 12381 RVA: 0x000143FA File Offset: 0x000125FA
			public unsafe int lastItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_lastItem);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.NativeFieldInfoPtr_lastItem)) = value;
				}
			}

			// Token: 0x0400252B RID: 9515
			private static readonly IntPtr NativeFieldInfoPtr_stringValue;

			// Token: 0x0400252C RID: 9516
			private static readonly IntPtr NativeFieldInfoPtr_singleStringValue;

			// Token: 0x0400252D RID: 9517
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x0400252E RID: 9518
			private static readonly IntPtr NativeFieldInfoPtr_firstItem;

			// Token: 0x0400252F RID: 9519
			private static readonly IntPtr NativeFieldInfoPtr_lastItem;

			// Token: 0x04002530 RID: 9520
			private static readonly IntPtr NativeMethodInfoPtr_get_StringValue_Internal_get_String_0;

			// Token: 0x04002531 RID: 9521
			private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0;

			// Token: 0x04002532 RID: 9522
			private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0;

			// Token: 0x04002533 RID: 9523
			private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0;

			// Token: 0x04002534 RID: 9524
			private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Internal_Void_String_0;

			// Token: 0x04002535 RID: 9525
			private static readonly IntPtr NativeMethodInfoPtr_WriteString_Internal_Void_String_0;

			// Token: 0x04002536 RID: 9526
			private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04002537 RID: 9527
			private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04002538 RID: 9528
			private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Internal_Void_String_0;

			// Token: 0x04002539 RID: 9529
			private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Internal_Void_String_0;

			// Token: 0x0400253A RID: 9530
			private static readonly IntPtr NativeMethodInfoPtr_Replay_Internal_Void_XmlWriter_0;

			// Token: 0x0400253B RID: 9531
			private static readonly IntPtr NativeMethodInfoPtr_Trim_Internal_Void_0;

			// Token: 0x0400253C RID: 9532
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

			// Token: 0x0400253D RID: 9533
			private static readonly IntPtr NativeMethodInfoPtr_StartComplexValue_Private_Void_0;

			// Token: 0x0400253E RID: 9534
			private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_Void_ItemType_Object_0;

			// Token: 0x0400253F RID: 9535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200029A RID: 666
			public enum ItemType
			{
				// Token: 0x04002855 RID: 10325
				EntityRef,
				// Token: 0x04002856 RID: 10326
				CharEntity,
				// Token: 0x04002857 RID: 10327
				SurrogateCharEntity,
				// Token: 0x04002858 RID: 10328
				Whitespace,
				// Token: 0x04002859 RID: 10329
				String,
				// Token: 0x0400285A RID: 10330
				StringChars,
				// Token: 0x0400285B RID: 10331
				Raw,
				// Token: 0x0400285C RID: 10332
				RawChars,
				// Token: 0x0400285D RID: 10333
				ValueString
			}

			// Token: 0x0200029B RID: 667
			public class Item : Object
			{
				// Token: 0x06003312 RID: 13074 RVA: 0x000E1098 File Offset: 0x000DF298
				// Note: this type is marked as 'beforefieldinit'.
				static Item()
				{
					Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "Item");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr);
					XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr, "type");
					XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr, "data");
					XmlWellFormedWriter.AttributeValueCache.Item.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr, 100664952);
					XmlWellFormedWriter.AttributeValueCache.Item.NativeMethodInfoPtr_Set_Internal_Void_ItemType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr, 100664953);
				}

				// Token: 0x06003313 RID: 13075 RVA: 0x000E1114 File Offset: 0x000DF314
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Item()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.Item>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.Item.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003314 RID: 13076 RVA: 0x000E1150 File Offset: 0x000DF350
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371651, XrefRangeEnd = 371652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, Object data)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref type;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.Item.NativeMethodInfoPtr_Set_Internal_Void_ItemType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003315 RID: 13077 RVA: 0x000161DC File Offset: 0x000143DC
				public Item(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700111D RID: 4381
				// (get) Token: 0x06003316 RID: 13078 RVA: 0x000E11A0 File Offset: 0x000DF3A0
				// (set) Token: 0x06003317 RID: 13079 RVA: 0x000161E5 File Offset: 0x000143E5
				public unsafe XmlWellFormedWriter.AttributeValueCache.ItemType type
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_type);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_type)) = value;
					}
				}

				// Token: 0x1700111E RID: 4382
				// (get) Token: 0x06003318 RID: 13080 RVA: 0x000E11C8 File Offset: 0x000DF3C8
				// (set) Token: 0x06003319 RID: 13081 RVA: 0x00016200 File Offset: 0x00014400
				public unsafe Object data
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_data);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.Item.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400285E RID: 10334
				private static readonly IntPtr NativeFieldInfoPtr_type;

				// Token: 0x0400285F RID: 10335
				private static readonly IntPtr NativeFieldInfoPtr_data;

				// Token: 0x04002860 RID: 10336
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

				// Token: 0x04002861 RID: 10337
				private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_ItemType_Object_0;
			}

			// Token: 0x0200029C RID: 668
			public class BufferChunk : Object
			{
				// Token: 0x0600331A RID: 13082 RVA: 0x000E11F8 File Offset: 0x000DF3F8
				// Note: this type is marked as 'beforefieldinit'.
				static BufferChunk()
				{
					Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache>.NativeClassPtr, "BufferChunk");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr);
					XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr, "buffer");
					XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr, "index");
					XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr, "count");
					XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr, 100664954);
				}

				// Token: 0x0600331B RID: 13083 RVA: 0x000E1274 File Offset: 0x000DF474
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371652, XrefRangeEnd = 371654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BufferChunk(Il2CppStructArray<char> buffer, int index, int count)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWellFormedWriter.AttributeValueCache.BufferChunk>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600331C RID: 13084 RVA: 0x0001621F File Offset: 0x0001441F
				public BufferChunk(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700111F RID: 4383
				// (get) Token: 0x0600331D RID: 13085 RVA: 0x000E12DC File Offset: 0x000DF4DC
				// (set) Token: 0x0600331E RID: 13086 RVA: 0x00016228 File Offset: 0x00014428
				public unsafe Il2CppStructArray<char> buffer
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_buffer);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001120 RID: 4384
				// (get) Token: 0x0600331F RID: 13087 RVA: 0x000E130C File Offset: 0x000DF50C
				// (set) Token: 0x06003320 RID: 13088 RVA: 0x00016247 File Offset: 0x00014447
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x17001121 RID: 4385
				// (get) Token: 0x06003321 RID: 13089 RVA: 0x000E1334 File Offset: 0x000DF534
				// (set) Token: 0x06003322 RID: 13090 RVA: 0x00016262 File Offset: 0x00014462
				public unsafe int count
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_count);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWellFormedWriter.AttributeValueCache.BufferChunk.NativeFieldInfoPtr_count)) = value;
					}
				}

				// Token: 0x04002862 RID: 10338
				private static readonly IntPtr NativeFieldInfoPtr_buffer;

				// Token: 0x04002863 RID: 10339
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x04002864 RID: 10340
				private static readonly IntPtr NativeFieldInfoPtr_count;

				// Token: 0x04002865 RID: 10341
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;
			}
		}
	}
}
