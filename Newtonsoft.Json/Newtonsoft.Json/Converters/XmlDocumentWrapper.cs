using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000EC RID: 236
	public class XmlDocumentWrapper : XmlNodeWrapper
	{
		// Token: 0x06001431 RID: 5169 RVA: 0x0006EB38 File Offset: 0x0006CD38
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDocumentWrapper()
		{
			Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XmlDocumentWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr);
			XmlDocumentWrapper.NativeFieldInfoPtr__document = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, "_document");
			XmlDocumentWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667139);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateComment_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667140);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateTextNode_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667141);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667142);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667143);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667144);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_Final_New_IXmlNode_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667145);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateXmlDocumentType_Public_Virtual_Final_New_IXmlNode_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667146);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_Final_New_IXmlNode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667147);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667148);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667149);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667150);
			XmlDocumentWrapper.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667151);
			XmlDocumentWrapper.NativeMethodInfoPtr_get_DocumentElement_Public_Virtual_Final_New_get_IXmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr, 100667152);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0006EC94 File Offset: 0x0006CE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765056, XrefRangeEnd = 765059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocumentWrapper(XmlDocument document)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocumentWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(document);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0006ECE0 File Offset: 0x0006CEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765059, XrefRangeEnd = 765064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateComment(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateComment_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0006ED30 File Offset: 0x0006CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765064, XrefRangeEnd = 765069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateTextNode(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateTextNode_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0006ED80 File Offset: 0x0006CF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765069, XrefRangeEnd = 765074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateCDataSection(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0006EDD0 File Offset: 0x0006CFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765074, XrefRangeEnd = 765079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0006EE20 File Offset: 0x0006D020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765079, XrefRangeEnd = 765084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateSignificantWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0006EE70 File Offset: 0x0006D070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765084, XrefRangeEnd = 765090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standalone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_Final_New_IXmlNode_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0006EEE4 File Offset: 0x0006D0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765090, XrefRangeEnd = 765096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateXmlDocumentType_Public_Virtual_Final_New_IXmlNode_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0006EF6C File Offset: 0x0006D16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765096, XrefRangeEnd = 765101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateProcessingInstruction(string target, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_Final_New_IXmlNode_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0006EFD0 File Offset: 0x0006D1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765101, XrefRangeEnd = 765108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlElement CreateElement(string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0006F020 File Offset: 0x0006D220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765108, XrefRangeEnd = 765115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0006F084 File Offset: 0x0006D284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765115, XrefRangeEnd = 765121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateAttribute(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0006F0E8 File Offset: 0x0006D2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765121, XrefRangeEnd = 765127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0006F15C File Offset: 0x0006D35C
		public unsafe virtual IXmlElement DocumentElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765127, XrefRangeEnd = 765135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentWrapper.NativeMethodInfoPtr_get_DocumentElement_Public_Virtual_Final_New_get_IXmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000082D0 File Offset: 0x000064D0
		public XmlDocumentWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0006F19C File Offset: 0x0006D39C
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x000082D9 File Offset: 0x000064D9
		public unsafe XmlDocument _document
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentWrapper.NativeFieldInfoPtr__document);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentWrapper.NativeFieldInfoPtr__document), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr__document;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_CreateComment_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextNode_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_Final_New_IXmlNode_String_String_String_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlDocumentType_Public_Virtual_Final_New_IXmlNode_String_String_String_String_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_Final_New_IXmlNode_String_String_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_String_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_String_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentElement_Public_Virtual_Final_New_get_IXmlElement_0;
	}
}
