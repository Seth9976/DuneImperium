using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BD RID: 445
	public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
	{
		// Token: 0x0600261A RID: 9754 RVA: 0x00010228 File Offset: 0x0000E428
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMaxExclusiveFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMaxExclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMaxExclusiveFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMaxExclusiveFacet>.NativeClassPtr);
			XmlSchemaMaxExclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMaxExclusiveFacet>.NativeClassPtr, 100668810);
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x000B317C File Offset: 0x000B137C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412284, RefRangeEnd = 412285, XrefRangeStart = 412283, XrefRangeEnd = 412284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaMaxExclusiveFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMaxExclusiveFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMaxExclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00010261 File Offset: 0x0000E461
		public XmlSchemaMaxExclusiveFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
