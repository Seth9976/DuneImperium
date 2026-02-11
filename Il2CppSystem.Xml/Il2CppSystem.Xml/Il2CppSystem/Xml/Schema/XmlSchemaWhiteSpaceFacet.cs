using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C1 RID: 449
	public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x00010330 File Offset: 0x0000E530
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaWhiteSpaceFacet()
		{
			Il2CppClassPointerStore<XmlSchemaWhiteSpaceFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaWhiteSpaceFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaWhiteSpaceFacet>.NativeClassPtr);
			XmlSchemaWhiteSpaceFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaWhiteSpaceFacet>.NativeClassPtr, 100668814);
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000B326C File Offset: 0x000B146C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412292, RefRangeEnd = 412293, XrefRangeStart = 412291, XrefRangeEnd = 412292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaWhiteSpaceFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaWhiteSpaceFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaWhiteSpaceFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x00010369 File Offset: 0x0000E569
		public XmlSchemaWhiteSpaceFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
