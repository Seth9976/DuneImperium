using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003B RID: 59
	public class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader
	{
		// Token: 0x060003BA RID: 954 RVA: 0x00025744 File Offset: 0x00023944
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAsyncCheckReaderWithNS()
		{
			Il2CppClassPointerStore<XmlAsyncCheckReaderWithNS>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlAsyncCheckReaderWithNS");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAsyncCheckReaderWithNS>.NativeClassPtr);
			XmlAsyncCheckReaderWithNS.NativeFieldInfoPtr_readerAsIXmlNamespaceResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAsyncCheckReaderWithNS>.NativeClassPtr, "readerAsIXmlNamespaceResolver");
			XmlAsyncCheckReaderWithNS.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithNS>.NativeClassPtr, 100663846);
			XmlAsyncCheckReaderWithNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithNS>.NativeClassPtr, 100663847);
			XmlAsyncCheckReaderWithNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithNS>.NativeClassPtr, 100663848);
			XmlAsyncCheckReaderWithNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithNS>.NativeClassPtr, 100663849);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000257D8 File Offset: 0x000239D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365062, XrefRangeEnd = 365072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAsyncCheckReaderWithNS(XmlReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAsyncCheckReaderWithNS>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithNS.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00025824 File Offset: 0x00023A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365072, XrefRangeEnd = 365076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00025870 File Offset: 0x00023A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365076, XrefRangeEnd = 365080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000258B8 File Offset: 0x00023AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365080, XrefRangeEnd = 365084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000340C File Offset: 0x0000160C
		public XmlAsyncCheckReaderWithNS(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00025900 File Offset: 0x00023B00
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003415 File Offset: 0x00001615
		public unsafe IXmlNamespaceResolver readerAsIXmlNamespaceResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithNS.NativeFieldInfoPtr_readerAsIXmlNamespaceResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithNS.NativeFieldInfoPtr_readerAsIXmlNamespaceResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_readerAsIXmlNamespaceResolver;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;
	}
}
