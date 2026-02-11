using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001DB RID: 475
	public class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated
	{
		// Token: 0x060027E5 RID: 10213 RVA: 0x00010E2B File Offset: 0x0000F02B
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeContent()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr);
			XmlSchemaSimpleTypeContent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr, 100669069);
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x000B9D70 File Offset: 0x000B7F70
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeContent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00010E64 File Offset: 0x0000F064
		public XmlSchemaSimpleTypeContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
