using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000276 RID: 630
	public sealed class Ipv6Element : ConfigurationElement
	{
		// Token: 0x06002972 RID: 10610 RVA: 0x000BBE14 File Offset: 0x000BA014
		// Note: this type is marked as 'beforefieldinit'.
		static Ipv6Element()
		{
			Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "Ipv6Element");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr);
			Ipv6Element.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr, 100669456);
			Ipv6Element.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr, 100669457);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000BBE6C File Offset: 0x000BA06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494225, XrefRangeEnd = 494228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ipv6Element()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ipv6Element.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x000BBEA8 File Offset: 0x000BA0A8
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494228, XrefRangeEnd = 494231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ipv6Element.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00011D06 File Offset: 0x0000FF06
		public Ipv6Element(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
