using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity
{
	// Token: 0x02000556 RID: 1366
	public sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x06005545 RID: 21829 RVA: 0x0001E482 File Offset: 0x0001C682
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowStub()
		{
			Il2CppClassPointerStore<ThrowStub>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Unity", "ThrowStub");
			ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowStub>.NativeClassPtr, 100676256);
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00189CA4 File Offset: 0x00187EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435357, XrefRangeEnd = 1435362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x0001E4B1 File Offset: 0x0001C6B1
		public ThrowStub(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004566 RID: 17766
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0;
	}
}
