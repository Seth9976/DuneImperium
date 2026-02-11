using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D5 RID: 213
	public class XmlIgnoreAttribute : Attribute
	{
		// Token: 0x060013FD RID: 5117 RVA: 0x0000884A File Offset: 0x00006A4A
		// Note: this type is marked as 'beforefieldinit'.
		static XmlIgnoreAttribute()
		{
			Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlIgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr);
			XmlIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr, 100666497);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0006C990 File Offset: 0x0006AB90
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlIgnoreAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00008883 File Offset: 0x00006A83
		public XmlIgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
