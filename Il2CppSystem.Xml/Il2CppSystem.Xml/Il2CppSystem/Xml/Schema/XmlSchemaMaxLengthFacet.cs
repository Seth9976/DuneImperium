using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B8 RID: 440
	public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
	{
		// Token: 0x0600260B RID: 9739 RVA: 0x000100DE File Offset: 0x0000E2DE
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMaxLengthFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMaxLengthFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMaxLengthFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMaxLengthFacet>.NativeClassPtr);
			XmlSchemaMaxLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMaxLengthFacet>.NativeClassPtr, 100668805);
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x000B3050 File Offset: 0x000B1250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412271, RefRangeEnd = 412272, XrefRangeStart = 412270, XrefRangeEnd = 412271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaMaxLengthFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMaxLengthFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMaxLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00010117 File Offset: 0x0000E317
		public XmlSchemaMaxLengthFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
