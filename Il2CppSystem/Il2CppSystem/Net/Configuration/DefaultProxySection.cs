using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000273 RID: 627
	public sealed class DefaultProxySection : ConfigurationSection
	{
		// Token: 0x06002965 RID: 10597 RVA: 0x000BBB40 File Offset: 0x000B9D40
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultProxySection()
		{
			Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "DefaultProxySection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr);
			DefaultProxySection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr, 100669449);
			DefaultProxySection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr, 100669450);
			DefaultProxySection.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_ConfigurationElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr, 100669451);
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000BBBAC File Offset: 0x000B9DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494204, XrefRangeEnd = 494207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultProxySection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x000BBBE8 File Offset: 0x000B9DE8
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494207, XrefRangeEnd = 494210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x000BBC28 File Offset: 0x000B9E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494210, XrefRangeEnd = 494213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(ConfigurationElement parentElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySection.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_ConfigurationElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00011CEB File Offset: 0x0000FEEB
		public DefaultProxySection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Virtual_Void_ConfigurationElement_0;
	}
}
