using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A9 RID: 425
	public class XmlSchemaContent : XmlSchemaAnnotated
	{
		// Token: 0x0600251D RID: 9501 RVA: 0x0000FAE9 File Offset: 0x0000DCE9
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaContent()
		{
			Il2CppClassPointerStore<XmlSchemaContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaContent>.NativeClassPtr);
			XmlSchemaContent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaContent>.NativeClassPtr, 100668670);
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000AF340 File Offset: 0x000AD540
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaContent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0000FB22 File Offset: 0x0000DD22
		public XmlSchemaContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
