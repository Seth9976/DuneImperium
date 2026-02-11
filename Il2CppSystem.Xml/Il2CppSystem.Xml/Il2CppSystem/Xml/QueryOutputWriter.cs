using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002E RID: 46
	public class QueryOutputWriter : XmlRawWriter
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x00020DFC File Offset: 0x0001EFFC
		// Note: this type is marked as 'beforefieldinit'.
		static QueryOutputWriter()
		{
			Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "QueryOutputWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr);
			QueryOutputWriter.NativeFieldInfoPtr_wrapped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "wrapped");
			QueryOutputWriter.NativeFieldInfoPtr_inCDataSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "inCDataSection");
			QueryOutputWriter.NativeFieldInfoPtr_lookupCDataElems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "lookupCDataElems");
			QueryOutputWriter.NativeFieldInfoPtr_bitsCData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "bitsCData");
			QueryOutputWriter.NativeFieldInfoPtr_qnameCData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "qnameCData");
			QueryOutputWriter.NativeFieldInfoPtr_outputDocType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "outputDocType");
			QueryOutputWriter.NativeFieldInfoPtr_checkWellFormedDoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "checkWellFormedDoc");
			QueryOutputWriter.NativeFieldInfoPtr_hasDocElem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "hasDocElem");
			QueryOutputWriter.NativeFieldInfoPtr_inAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "inAttr");
			QueryOutputWriter.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "systemId");
			QueryOutputWriter.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "publicId");
			QueryOutputWriter.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, "depth");
			QueryOutputWriter.NativeMethodInfoPtr__ctor_Public_Void_XmlRawWriter_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663679);
			QueryOutputWriter.NativeMethodInfoPtr_set_NamespaceResolver_Internal_Virtual_set_Void_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663680);
			QueryOutputWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663681);
			QueryOutputWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663682);
			QueryOutputWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663683);
			QueryOutputWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663684);
			QueryOutputWriter.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663685);
			QueryOutputWriter.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663686);
			QueryOutputWriter.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663687);
			QueryOutputWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663688);
			QueryOutputWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663689);
			QueryOutputWriter.NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663690);
			QueryOutputWriter.NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663691);
			QueryOutputWriter.NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663692);
			QueryOutputWriter.NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663693);
			QueryOutputWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663694);
			QueryOutputWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663695);
			QueryOutputWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663696);
			QueryOutputWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663697);
			QueryOutputWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663698);
			QueryOutputWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663699);
			QueryOutputWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663700);
			QueryOutputWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663701);
			QueryOutputWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663702);
			QueryOutputWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663703);
			QueryOutputWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663704);
			QueryOutputWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663705);
			QueryOutputWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663706);
			QueryOutputWriter.NativeMethodInfoPtr_StartCDataSection_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663707);
			QueryOutputWriter.NativeMethodInfoPtr_EndCDataSection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr, 100663708);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00021174 File Offset: 0x0001F374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364672, XrefRangeEnd = 364686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueryOutputWriter(XmlRawWriter writer, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryOutputWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryOutputWriter.NativeMethodInfoPtr__ctor_Public_Void_XmlRawWriter_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000DA RID: 218
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000211D4 File Offset: 0x0001F3D4
		public unsafe override IXmlNamespaceResolver NamespaceResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364686, XrefRangeEnd = 364688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_set_NamespaceResolver_Internal_Virtual_set_Void_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00021224 File Offset: 0x0001F424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364688, XrefRangeEnd = 364689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref standalone;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00021270 File Offset: 0x0001F470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364689, XrefRangeEnd = 364690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteXmlDeclaration(string xmldecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmldecl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000212C0 File Offset: 0x0001F4C0
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00021344 File Offset: 0x0001F544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364690, XrefRangeEnd = 364699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000213B8 File Offset: 0x0001F5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364699, XrefRangeEnd = 364700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0002142C File Offset: 0x0001F62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364700, XrefRangeEnd = 364701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000214A0 File Offset: 0x0001F6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364701, XrefRangeEnd = 364702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000214DC File Offset: 0x0001F6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364702, XrefRangeEnd = 364703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00021550 File Offset: 0x0001F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364703, XrefRangeEnd = 364704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0002158C File Offset: 0x0001F78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364704, XrefRangeEnd = 364705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteNamespaceDeclaration(string prefix, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000215EC File Offset: 0x0001F7EC
		public unsafe override bool SupportsNamespaceDeclarationInChunks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364705, XrefRangeEnd = 364706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00021634 File Offset: 0x0001F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364706, XrefRangeEnd = 364707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartNamespaceDeclaration(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00021684 File Offset: 0x0001F884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364707, XrefRangeEnd = 364708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndNamespaceDeclaration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000216C0 File Offset: 0x0001F8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364708, XrefRangeEnd = 364709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00021710 File Offset: 0x0001F910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364709, XrefRangeEnd = 364710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00021760 File Offset: 0x0001F960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364710, XrefRangeEnd = 364711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000217C0 File Offset: 0x0001F9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364711, XrefRangeEnd = 364713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00021810 File Offset: 0x0001FA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364713, XrefRangeEnd = 364715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00021860 File Offset: 0x0001FA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364715, XrefRangeEnd = 364717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000218CC File Offset: 0x0001FACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364717, XrefRangeEnd = 364718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0002191C File Offset: 0x0001FB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364718, XrefRangeEnd = 364719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00021968 File Offset: 0x0001FB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364719, XrefRangeEnd = 364720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000219C0 File Offset: 0x0001FBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364720, XrefRangeEnd = 364722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00021A2C File Offset: 0x0001FC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364722, XrefRangeEnd = 364724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00021A7C File Offset: 0x0001FC7C
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00021AB8 File Offset: 0x0001FCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364724, XrefRangeEnd = 364725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryOutputWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00021AF4 File Offset: 0x0001FCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364725, XrefRangeEnd = 364726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartCDataSection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryOutputWriter.NativeMethodInfoPtr_StartCDataSection_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00021B30 File Offset: 0x0001FD30
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 364726, RefRangeEnd = 364739, XrefRangeStart = 364726, XrefRangeEnd = 364726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCDataSection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryOutputWriter.NativeMethodInfoPtr_EndCDataSection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00003029 File Offset: 0x00001229
		public QueryOutputWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00021B64 File Offset: 0x0001FD64
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00003032 File Offset: 0x00001232
		public unsafe XmlRawWriter wrapped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_wrapped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlRawWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_wrapped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00021B94 File Offset: 0x0001FD94
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00003051 File Offset: 0x00001251
		public unsafe bool inCDataSection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_inCDataSection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_inCDataSection)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00021BBC File Offset: 0x0001FDBC
		// (set) Token: 0x060002EA RID: 746 RVA: 0x0000306C File Offset: 0x0000126C
		public unsafe Dictionary<XmlQualifiedName, int> lookupCDataElems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_lookupCDataElems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_lookupCDataElems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00021BEC File Offset: 0x0001FDEC
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000308B File Offset: 0x0000128B
		public unsafe BitStack bitsCData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_bitsCData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_bitsCData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00021C1C File Offset: 0x0001FE1C
		// (set) Token: 0x060002EE RID: 750 RVA: 0x000030AA File Offset: 0x000012AA
		public unsafe XmlQualifiedName qnameCData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_qnameCData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_qnameCData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00021C4C File Offset: 0x0001FE4C
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000030C9 File Offset: 0x000012C9
		public unsafe bool outputDocType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_outputDocType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_outputDocType)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00021C74 File Offset: 0x0001FE74
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000030E4 File Offset: 0x000012E4
		public unsafe bool checkWellFormedDoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_checkWellFormedDoc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_checkWellFormedDoc)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00021C9C File Offset: 0x0001FE9C
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x000030FF File Offset: 0x000012FF
		public unsafe bool hasDocElem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_hasDocElem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_hasDocElem)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00021CC4 File Offset: 0x0001FEC4
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000311A File Offset: 0x0000131A
		public unsafe bool inAttr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_inAttr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_inAttr)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00021CEC File Offset: 0x0001FEEC
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00003135 File Offset: 0x00001335
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00021D14 File Offset: 0x0001FF14
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00003154 File Offset: 0x00001354
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00021D3C File Offset: 0x0001FF3C
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00003173 File Offset: 0x00001373
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryOutputWriter.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_wrapped;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_inCDataSection;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_lookupCDataElems;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_bitsCData;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_qnameCData;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_outputDocType;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_checkWellFormedDoc;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_hasDocElem;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_inAttr;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlRawWriter_XmlWriterSettings_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_set_NamespaceResolver_Internal_Virtual_set_Void_IXmlNamespaceResolver_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_XmlStandalone_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_WriteXmlDeclaration_Internal_Virtual_Void_String_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAttribute_Public_Virtual_Void_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_WriteNamespaceDeclaration_Internal_Virtual_Void_String_String_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsNamespaceDeclarationInChunks_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartNamespaceDeclaration_Internal_Virtual_Void_String_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndNamespaceDeclaration_Internal_Virtual_Void_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_StartCDataSection_Private_Boolean_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_EndCDataSection_Private_Void_0;
	}
}
