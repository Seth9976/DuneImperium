using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C0 RID: 448
	public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet
	{
		// Token: 0x06002623 RID: 9763 RVA: 0x000102EE File Offset: 0x0000E4EE
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaFractionDigitsFacet()
		{
			Il2CppClassPointerStore<XmlSchemaFractionDigitsFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaFractionDigitsFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaFractionDigitsFacet>.NativeClassPtr);
			XmlSchemaFractionDigitsFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFractionDigitsFacet>.NativeClassPtr, 100668813);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000B3230 File Offset: 0x000B1430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412290, RefRangeEnd = 412291, XrefRangeStart = 412289, XrefRangeEnd = 412290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaFractionDigitsFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaFractionDigitsFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFractionDigitsFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x00010327 File Offset: 0x0000E527
		public XmlSchemaFractionDigitsFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
