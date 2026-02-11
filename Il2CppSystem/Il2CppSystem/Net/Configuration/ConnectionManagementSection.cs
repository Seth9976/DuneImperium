using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000272 RID: 626
	public sealed class ConnectionManagementSection : ConfigurationSection
	{
		// Token: 0x06002961 RID: 10593 RVA: 0x000BBA6C File Offset: 0x000B9C6C
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManagementSection()
		{
			Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ConnectionManagementSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr);
			ConnectionManagementSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr, 100669447);
			ConnectionManagementSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr, 100669448);
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000BBAC4 File Offset: 0x000B9CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494198, XrefRangeEnd = 494201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionManagementSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002963 RID: 10595 RVA: 0x000BBB00 File Offset: 0x000B9D00
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494201, XrefRangeEnd = 494204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00011CE2 File Offset: 0x0000FEE2
		public ConnectionManagementSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
