using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000277 RID: 631
	public sealed class NetSectionGroup : ConfigurationSectionGroup
	{
		// Token: 0x06002976 RID: 10614 RVA: 0x00011D0F File Offset: 0x0000FF0F
		// Note: this type is marked as 'beforefieldinit'.
		static NetSectionGroup()
		{
			Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "NetSectionGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr);
			NetSectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr, 100669458);
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000BBEE8 File Offset: 0x000BA0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494231, XrefRangeEnd = 494234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetSectionGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetSectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00011D48 File Offset: 0x0000FF48
		public NetSectionGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
