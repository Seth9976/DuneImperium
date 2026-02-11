using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B6 RID: 438
	public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
	{
		// Token: 0x06002605 RID: 9733 RVA: 0x0001005A File Offset: 0x0000E25A
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaLengthFacet()
		{
			Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaLengthFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr);
			XmlSchemaLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr, 100668803);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x000B2FD8 File Offset: 0x000B11D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412267, RefRangeEnd = 412268, XrefRangeStart = 412266, XrefRangeEnd = 412267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaLengthFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00010093 File Offset: 0x0000E293
		public XmlSchemaLengthFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
