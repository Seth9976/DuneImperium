using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F9 RID: 249
	public class XmlTypeMapMemberNamespaces : XmlTypeMapMember
	{
		// Token: 0x0600169A RID: 5786 RVA: 0x00009956 File Offset: 0x00007B56
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberNamespaces()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberNamespaces>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberNamespaces");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberNamespaces>.NativeClassPtr);
			XmlTypeMapMemberNamespaces.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberNamespaces>.NativeClassPtr, 100666879);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0007785C File Offset: 0x00075A5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 389801, RefRangeEnd = 389807, XrefRangeStart = 389801, XrefRangeEnd = 389807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberNamespaces()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberNamespaces>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberNamespaces.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0000998F File Offset: 0x00007B8F
		public XmlTypeMapMemberNamespaces(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
