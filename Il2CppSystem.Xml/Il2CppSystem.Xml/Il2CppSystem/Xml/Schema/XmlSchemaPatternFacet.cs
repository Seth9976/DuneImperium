using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B9 RID: 441
	public class XmlSchemaPatternFacet : XmlSchemaFacet
	{
		// Token: 0x0600260E RID: 9742 RVA: 0x00010120 File Offset: 0x0000E320
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaPatternFacet()
		{
			Il2CppClassPointerStore<XmlSchemaPatternFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaPatternFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaPatternFacet>.NativeClassPtr);
			XmlSchemaPatternFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaPatternFacet>.NativeClassPtr, 100668806);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x000B308C File Offset: 0x000B128C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 412273, RefRangeEnd = 412275, XrefRangeStart = 412272, XrefRangeEnd = 412273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaPatternFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaPatternFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaPatternFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00010159 File Offset: 0x0000E359
		public XmlSchemaPatternFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
