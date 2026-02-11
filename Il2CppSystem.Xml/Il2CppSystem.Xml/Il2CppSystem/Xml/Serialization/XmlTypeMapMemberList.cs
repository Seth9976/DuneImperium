using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F4 RID: 244
	public class XmlTypeMapMemberList : XmlTypeMapMemberElement
	{
		// Token: 0x06001681 RID: 5761 RVA: 0x0000987D File Offset: 0x00007A7D
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberList()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberList>.NativeClassPtr);
			XmlTypeMapMemberList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberList>.NativeClassPtr, 100666868);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x000773D0 File Offset: 0x000755D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 389801, RefRangeEnd = 389807, XrefRangeStart = 389801, XrefRangeEnd = 389807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000098B6 File Offset: 0x00007AB6
		public XmlTypeMapMemberList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
