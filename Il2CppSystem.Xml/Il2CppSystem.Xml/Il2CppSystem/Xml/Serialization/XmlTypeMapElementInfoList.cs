using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F0 RID: 240
	public class XmlTypeMapElementInfoList : ArrayList
	{
		// Token: 0x06001629 RID: 5673 RVA: 0x0000960A File Offset: 0x0000780A
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapElementInfoList()
		{
			Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapElementInfoList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr);
			XmlTypeMapElementInfoList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr, 100666824);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00075FC4 File Offset: 0x000741C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 389672, RefRangeEnd = 389676, XrefRangeStart = 389671, XrefRangeEnd = 389672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfoList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfoList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00009643 File Offset: 0x00007843
		public XmlTypeMapElementInfoList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
