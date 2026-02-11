using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C7 RID: 455
	public class XmlSchemaXPath : XmlSchemaAnnotated
	{
		// Token: 0x06002674 RID: 9844 RVA: 0x000B4440 File Offset: 0x000B2640
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaXPath()
		{
			Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaXPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr);
			XmlSchemaXPath.NativeFieldInfoPtr_xpath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr, "xpath");
			XmlSchemaXPath.NativeMethodInfoPtr_get_XPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr, 100668854);
			XmlSchemaXPath.NativeMethodInfoPtr_set_XPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr, 100668855);
			XmlSchemaXPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr, 100668856);
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x000B44C0 File Offset: 0x000B26C0
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x000B44F8 File Offset: 0x000B26F8
		public unsafe string XPath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaXPath.NativeMethodInfoPtr_get_XPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaXPath.NativeMethodInfoPtr_set_XPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000B453C File Offset: 0x000B273C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaXPath()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaXPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00010544 File Offset: 0x0000E744
		public XmlSchemaXPath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000B4578 File Offset: 0x000B2778
		// (set) Token: 0x0600267A RID: 9850 RVA: 0x0001054D File Offset: 0x0000E74D
		public unsafe string xpath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaXPath.NativeFieldInfoPtr_xpath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaXPath.NativeFieldInfoPtr_xpath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeFieldInfoPtr_xpath;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr_get_XPath_Public_get_String_0;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_set_XPath_Public_set_Void_String_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
