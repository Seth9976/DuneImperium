using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BC RID: 444
	public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
	{
		// Token: 0x06002617 RID: 9751 RVA: 0x000101E6 File Offset: 0x0000E3E6
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMinInclusiveFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMinInclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMinInclusiveFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMinInclusiveFacet>.NativeClassPtr);
			XmlSchemaMinInclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMinInclusiveFacet>.NativeClassPtr, 100668809);
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x000B3140 File Offset: 0x000B1340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412282, RefRangeEnd = 412283, XrefRangeStart = 412281, XrefRangeEnd = 412282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaMinInclusiveFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMinInclusiveFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMinInclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x0001021F File Offset: 0x0000E41F
		public XmlSchemaMinInclusiveFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
