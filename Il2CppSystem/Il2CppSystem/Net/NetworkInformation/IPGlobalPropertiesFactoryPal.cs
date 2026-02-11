using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200021C RID: 540
	public static class IPGlobalPropertiesFactoryPal : Object
	{
		// Token: 0x06002467 RID: 9319 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		// Note: this type is marked as 'beforefieldinit'.
		static IPGlobalPropertiesFactoryPal()
		{
			Il2CppClassPointerStore<IPGlobalPropertiesFactoryPal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "IPGlobalPropertiesFactoryPal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPGlobalPropertiesFactoryPal>.NativeClassPtr);
			IPGlobalPropertiesFactoryPal.NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalPropertiesFactoryPal>.NativeClassPtr, 100668733);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000A888C File Offset: 0x000A6A8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 486992, RefRangeEnd = 486994, XrefRangeStart = 486992, XrefRangeEnd = 486994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalPropertiesFactoryPal.NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0000FBD5 File Offset: 0x0000DDD5
		public IPGlobalPropertiesFactoryPal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0;
	}
}
