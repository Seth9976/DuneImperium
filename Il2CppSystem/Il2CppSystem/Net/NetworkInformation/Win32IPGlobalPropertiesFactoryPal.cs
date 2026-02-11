using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200021E RID: 542
	public static class Win32IPGlobalPropertiesFactoryPal : Object
	{
		// Token: 0x0600246E RID: 9326 RVA: 0x0000FBE7 File Offset: 0x0000DDE7
		// Note: this type is marked as 'beforefieldinit'.
		static Win32IPGlobalPropertiesFactoryPal()
		{
			Il2CppClassPointerStore<Win32IPGlobalPropertiesFactoryPal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32IPGlobalPropertiesFactoryPal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32IPGlobalPropertiesFactoryPal>.NativeClassPtr);
			Win32IPGlobalPropertiesFactoryPal.NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPGlobalPropertiesFactoryPal>.NativeClassPtr, 100668736);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000A8998 File Offset: 0x000A6B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486995, XrefRangeEnd = 486999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32IPGlobalPropertiesFactoryPal.NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x0000FC20 File Offset: 0x0000DE20
		public Win32IPGlobalPropertiesFactoryPal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0;
	}
}
