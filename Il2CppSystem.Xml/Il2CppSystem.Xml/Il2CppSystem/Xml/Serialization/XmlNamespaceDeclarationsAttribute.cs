using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000DC RID: 220
	public class XmlNamespaceDeclarationsAttribute : Attribute
	{
		// Token: 0x0600142D RID: 5165 RVA: 0x00008A45 File Offset: 0x00006C45
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNamespaceDeclarationsAttribute()
		{
			Il2CppClassPointerStore<XmlNamespaceDeclarationsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlNamespaceDeclarationsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamespaceDeclarationsAttribute>.NativeClassPtr);
			XmlNamespaceDeclarationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceDeclarationsAttribute>.NativeClassPtr, 100666513);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0006D1C0 File Offset: 0x0006B3C0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceDeclarationsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceDeclarationsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceDeclarationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00008A7E File Offset: 0x00006C7E
		public XmlNamespaceDeclarationsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
