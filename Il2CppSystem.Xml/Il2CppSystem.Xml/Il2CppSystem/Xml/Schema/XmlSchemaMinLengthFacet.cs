using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B7 RID: 439
	public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x0001009C File Offset: 0x0000E29C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMinLengthFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMinLengthFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr);
			XmlSchemaMinLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr, 100668804);
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000B3014 File Offset: 0x000B1214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412269, RefRangeEnd = 412270, XrefRangeStart = 412268, XrefRangeEnd = 412269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaMinLengthFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMinLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000100D5 File Offset: 0x0000E2D5
		public XmlSchemaMinLengthFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
