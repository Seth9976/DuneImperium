using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000271 RID: 625
	[DefaultMember("Item")]
	public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
	{
		// Token: 0x0600295E RID: 10590 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManagementElementCollection()
		{
			Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ConnectionManagementElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr);
			ConnectionManagementElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr, 100669446);
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000BBA30 File Offset: 0x000B9C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494195, XrefRangeEnd = 494198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionManagementElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00011CD9 File Offset: 0x0000FED9
		public ConnectionManagementElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
