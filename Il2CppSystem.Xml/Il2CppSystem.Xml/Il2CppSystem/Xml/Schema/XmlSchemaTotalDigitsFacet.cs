using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BF RID: 447
	public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x000102AC File Offset: 0x0000E4AC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaTotalDigitsFacet()
		{
			Il2CppClassPointerStore<XmlSchemaTotalDigitsFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaTotalDigitsFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaTotalDigitsFacet>.NativeClassPtr);
			XmlSchemaTotalDigitsFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaTotalDigitsFacet>.NativeClassPtr, 100668812);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000B31F4 File Offset: 0x000B13F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412288, RefRangeEnd = 412289, XrefRangeStart = 412287, XrefRangeEnd = 412288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaTotalDigitsFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaTotalDigitsFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaTotalDigitsFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000102E5 File Offset: 0x0000E4E5
		public XmlSchemaTotalDigitsFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
