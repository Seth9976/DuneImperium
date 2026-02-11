using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000223 RID: 547
	public static class UnixIPGlobalPropertiesFactoryPal : Object
	{
		// Token: 0x060024B0 RID: 9392 RVA: 0x0000FF34 File Offset: 0x0000E134
		// Note: this type is marked as 'beforefieldinit'.
		static UnixIPGlobalPropertiesFactoryPal()
		{
			Il2CppClassPointerStore<UnixIPGlobalPropertiesFactoryPal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "UnixIPGlobalPropertiesFactoryPal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixIPGlobalPropertiesFactoryPal>.NativeClassPtr);
			UnixIPGlobalPropertiesFactoryPal.NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixIPGlobalPropertiesFactoryPal>.NativeClassPtr, 100668741);
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000A91C8 File Offset: 0x000A73C8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixIPGlobalPropertiesFactoryPal.NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x0000FF6D File Offset: 0x0000E16D
		public UnixIPGlobalPropertiesFactoryPal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0;
	}
}
