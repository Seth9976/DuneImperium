using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C7 RID: 199
	public class XmlAnyAttributeAttribute : Attribute
	{
		// Token: 0x06001330 RID: 4912 RVA: 0x00008246 File Offset: 0x00006446
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyAttributeAttribute()
		{
			Il2CppClassPointerStore<XmlAnyAttributeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAnyAttributeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyAttributeAttribute>.NativeClassPtr);
			XmlAnyAttributeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyAttributeAttribute>.NativeClassPtr, 100666411);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00069F68 File Offset: 0x00068168
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyAttributeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyAttributeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyAttributeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0000827F File Offset: 0x0000647F
		public XmlAnyAttributeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
