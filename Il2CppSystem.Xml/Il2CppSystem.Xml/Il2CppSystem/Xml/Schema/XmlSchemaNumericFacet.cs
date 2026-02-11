using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B5 RID: 437
	public class XmlSchemaNumericFacet : XmlSchemaFacet
	{
		// Token: 0x06002602 RID: 9730 RVA: 0x00010018 File Offset: 0x0000E218
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaNumericFacet()
		{
			Il2CppClassPointerStore<XmlSchemaNumericFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaNumericFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaNumericFacet>.NativeClassPtr);
			XmlSchemaNumericFacet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNumericFacet>.NativeClassPtr, 100668802);
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x000B2F9C File Offset: 0x000B119C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaNumericFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaNumericFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNumericFacet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00010051 File Offset: 0x0000E251
		public XmlSchemaNumericFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
