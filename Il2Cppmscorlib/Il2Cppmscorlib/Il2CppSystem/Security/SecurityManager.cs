using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x02000224 RID: 548
	public static class SecurityManager : Object
	{
		// Token: 0x06002463 RID: 9315 RVA: 0x000CB23C File Offset: 0x000C943C
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityManager()
		{
			Il2CppClassPointerStore<SecurityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr);
			SecurityManager.NativeMethodInfoPtr_get_SecurityEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr, 100669434);
			SecurityManager.NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr, 100669435);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000CB294 File Offset: 0x000C9494
		public unsafe static bool SecurityEnabled
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityManager.NativeMethodInfoPtr_get_SecurityEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x000CB2C4 File Offset: 0x000C94C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureElevatedPermissions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityManager.NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0000B9AF File Offset: 0x00009BAF
		public SecurityManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeMethodInfoPtr_get_SecurityEnabled_Public_Static_get_Boolean_0;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0;
	}
}
