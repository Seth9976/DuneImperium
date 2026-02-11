using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F8 RID: 248
	public class XDocumentWrapper : XContainerWrapper
	{
		// Token: 0x060014B8 RID: 5304 RVA: 0x000712BC File Offset: 0x0006F4BC
		// Note: this type is marked as 'beforefieldinit'.
		static XDocumentWrapper()
		{
			Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XDocumentWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr);
			XDocumentWrapper.NativeMethodInfoPtr_get_Document_Private_get_XDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667232);
			XDocumentWrapper.NativeMethodInfoPtr__ctor_Public_Void_XDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667233);
			XDocumentWrapper.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667234);
			XDocumentWrapper.NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667235);
			XDocumentWrapper.NativeMethodInfoPtr_CreateComment_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667236);
			XDocumentWrapper.NativeMethodInfoPtr_CreateTextNode_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667237);
			XDocumentWrapper.NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667238);
			XDocumentWrapper.NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667239);
			XDocumentWrapper.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_Final_New_IXmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667240);
			XDocumentWrapper.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_Final_New_IXmlNode_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667241);
			XDocumentWrapper.NativeMethodInfoPtr_CreateXmlDocumentType_Public_Virtual_Final_New_IXmlNode_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667242);
			XDocumentWrapper.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_Final_New_IXmlNode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667243);
			XDocumentWrapper.NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667244);
			XDocumentWrapper.NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667245);
			XDocumentWrapper.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667246);
			XDocumentWrapper.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667247);
			XDocumentWrapper.NativeMethodInfoPtr_get_DocumentElement_Public_Virtual_Final_New_get_IXmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667248);
			XDocumentWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr, 100667249);
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00071454 File Offset: 0x0006F654
		public unsafe XDocument Document
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 765271, RefRangeEnd = 765275, XrefRangeStart = 765269, XrefRangeEnd = 765271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_get_Document_Private_get_XDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XDocument>(intPtr3) : null;
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00071494 File Offset: 0x0006F694
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XDocumentWrapper(XDocument document)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDocumentWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(document);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr__ctor_Public_Void_XDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x000714E0 File Offset: 0x0006F6E0
		public unsafe override List<IXmlNode> ChildNodes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765275, XrefRangeEnd = 765295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocumentWrapper.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_get_List_1_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0007152C File Offset: 0x0006F72C
		public unsafe override bool HasChildNodes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765295, XrefRangeEnd = 765299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocumentWrapper.NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00071574 File Offset: 0x0006F774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765299, XrefRangeEnd = 765308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateComment_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x000715C4 File Offset: 0x0006F7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765308, XrefRangeEnd = 765317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateTextNode(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateTextNode_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00071614 File Offset: 0x0006F814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765317, XrefRangeEnd = 765326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateCDataSection(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00071664 File Offset: 0x0006F864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765326, XrefRangeEnd = 765335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x000716B4 File Offset: 0x0006F8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765335, XrefRangeEnd = 765344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode CreateSignificantWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_Final_New_IXmlNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00071704 File Offset: 0x0006F904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765344, XrefRangeEnd = 765354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_Final_New_IXmlNode_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00071778 File Offset: 0x0006F978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765354, XrefRangeEnd = 765364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateXmlDocumentType_Public_Virtual_Final_New_IXmlNode_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00071800 File Offset: 0x0006FA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765364, XrefRangeEnd = 765373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_Final_New_IXmlNode_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00071864 File Offset: 0x0006FA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765373, XrefRangeEnd = 765383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlElement CreateElement(string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000718B4 File Offset: 0x0006FAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765383, XrefRangeEnd = 765394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00071918 File Offset: 0x0006FB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765394, XrefRangeEnd = 765404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0007197C File Offset: 0x0006FB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765404, XrefRangeEnd = 765415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000719F0 File Offset: 0x0006FBF0
		public unsafe virtual IXmlElement DocumentElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765415, XrefRangeEnd = 765425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentWrapper.NativeMethodInfoPtr_get_DocumentElement_Public_Virtual_Final_New_get_IXmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00071A30 File Offset: 0x0006FC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765425, XrefRangeEnd = 765430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IXmlNode AppendChild(IXmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocumentWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00008453 File Offset: 0x00006653
		public XDocumentWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Private_get_XDocument_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XDocument_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_get_List_1_IXmlNode_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_get_Boolean_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_CreateComment_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextNode_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_Final_New_IXmlNode_String_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_Final_New_IXmlNode_String_String_String_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlDocumentType_Public_Virtual_Final_New_IXmlNode_String_String_String_String_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_Final_New_IXmlNode_String_String_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_Virtual_Final_New_IXmlElement_String_String_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_Virtual_Final_New_IXmlNode_String_String_String_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentElement_Public_Virtual_Final_New_get_IXmlElement_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_IXmlNode_IXmlNode_0;
	}
}
