using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BA RID: 442
	public class XmlSchemaEnumerationFacet : XmlSchemaFacet
	{
		// Token: 0x06002611 RID: 9745 RVA: 0x00010162 File Offset: 0x0000E362
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaEnumerationFacet()
		{
			Il2CppClassPointerStore<XmlSchemaEnumerationFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaEnumerationFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaEnumerationFacet>.NativeClassPtr);
			XmlSchemaEnumerationFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaEnumerationFacet>.NativeClassPtr, 100668807);
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x000B30C8 File Offset: 0x000B12C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 412276, RefRangeEnd = 412279, XrefRangeStart = 412275, XrefRangeEnd = 412276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaEnumerationFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaEnumerationFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaEnumerationFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x0001019B File Offset: 0x0000E39B
		public XmlSchemaEnumerationFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
