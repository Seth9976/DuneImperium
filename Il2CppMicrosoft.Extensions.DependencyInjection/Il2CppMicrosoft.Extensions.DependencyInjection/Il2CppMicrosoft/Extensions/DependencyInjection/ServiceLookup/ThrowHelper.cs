using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200002C RID: 44
	public static class ThrowHelper : Object
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x00002AC8 File Offset: 0x00000CC8
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowHelper()
		{
			Il2CppClassPointerStore<Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup.ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ThrowHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup.ThrowHelper>.NativeClassPtr);
			Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup.ThrowHelper.NativeMethodInfoPtr_ThrowObjectDisposedException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup.ThrowHelper>.NativeClassPtr, 100663607);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AFA0 File Offset: 0x000091A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205240, XrefRangeEnd = 1205246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowObjectDisposedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup.ThrowHelper.NativeMethodInfoPtr_ThrowObjectDisposedException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002B01 File Offset: 0x00000D01
		public ThrowHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_ThrowObjectDisposedException_Internal_Static_Void_0;
	}
}
