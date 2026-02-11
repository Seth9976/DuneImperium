using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F8 RID: 248
	public class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00009914 File Offset: 0x00007B14
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberAnyAttribute()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberAnyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr);
			XmlTypeMapMemberAnyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr, 100666878);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00077820 File Offset: 0x00075A20
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 389801, RefRangeEnd = 389807, XrefRangeStart = 389801, XrefRangeEnd = 389807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberAnyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAnyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0000994D File Offset: 0x00007B4D
		public XmlTypeMapMemberAnyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
