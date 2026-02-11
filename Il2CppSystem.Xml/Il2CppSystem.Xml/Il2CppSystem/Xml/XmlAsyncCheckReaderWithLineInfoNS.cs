using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003D RID: 61
	public class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo
	{
		// Token: 0x060003CA RID: 970 RVA: 0x00025B18 File Offset: 0x00023D18
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAsyncCheckReaderWithLineInfoNS()
		{
			Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNS>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlAsyncCheckReaderWithLineInfoNS");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNS>.NativeClassPtr);
			XmlAsyncCheckReaderWithLineInfoNS.NativeFieldInfoPtr_readerAsIXmlNamespaceResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNS>.NativeClassPtr, "readerAsIXmlNamespaceResolver");
			XmlAsyncCheckReaderWithLineInfoNS.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNS>.NativeClassPtr, 100663854);
			XmlAsyncCheckReaderWithLineInfoNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNS>.NativeClassPtr, 100663855);
			XmlAsyncCheckReaderWithLineInfoNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNS>.NativeClassPtr, 100663856);
			XmlAsyncCheckReaderWithLineInfoNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNS>.NativeClassPtr, 100663857);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00025BAC File Offset: 0x00023DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365117, RefRangeEnd = 365118, XrefRangeStart = 365107, XrefRangeEnd = 365117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAsyncCheckReaderWithLineInfoNS(XmlReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNS>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNS.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00025BF8 File Offset: 0x00023DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365118, XrefRangeEnd = 365122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00025C44 File Offset: 0x00023E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365122, XrefRangeEnd = 365126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00025C8C File Offset: 0x00023E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365126, XrefRangeEnd = 365130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfoNS.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000345C File Offset: 0x0000165C
		public XmlAsyncCheckReaderWithLineInfoNS(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00025CD4 File Offset: 0x00023ED4
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003465 File Offset: 0x00001665
		public unsafe IXmlNamespaceResolver readerAsIXmlNamespaceResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithLineInfoNS.NativeFieldInfoPtr_readerAsIXmlNamespaceResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithLineInfoNS.NativeFieldInfoPtr_readerAsIXmlNamespaceResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr_readerAsIXmlNamespaceResolver;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;
	}
}
