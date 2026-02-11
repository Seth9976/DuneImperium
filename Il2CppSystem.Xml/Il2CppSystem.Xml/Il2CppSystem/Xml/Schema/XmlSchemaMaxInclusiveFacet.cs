using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BE RID: 446
	public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
	{
		// Token: 0x0600261D RID: 9757 RVA: 0x0001026A File Offset: 0x0000E46A
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMaxInclusiveFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMaxInclusiveFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr);
			XmlSchemaMaxInclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr, 100668811);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000B31B8 File Offset: 0x000B13B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412286, RefRangeEnd = 412287, XrefRangeStart = 412285, XrefRangeEnd = 412286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaMaxInclusiveFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMaxInclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x000102A3 File Offset: 0x0000E4A3
		public XmlSchemaMaxInclusiveFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
