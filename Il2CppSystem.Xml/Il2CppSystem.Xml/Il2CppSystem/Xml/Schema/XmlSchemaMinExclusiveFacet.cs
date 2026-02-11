using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BB RID: 443
	public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
	{
		// Token: 0x06002614 RID: 9748 RVA: 0x000101A4 File Offset: 0x0000E3A4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMinExclusiveFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMinExclusiveFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr);
			XmlSchemaMinExclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr, 100668808);
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x000B3104 File Offset: 0x000B1304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412280, RefRangeEnd = 412281, XrefRangeStart = 412279, XrefRangeEnd = 412280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaMinExclusiveFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMinExclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x000101DD File Offset: 0x0000E3DD
		public XmlSchemaMinExclusiveFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
