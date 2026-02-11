using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity
{
	// Token: 0x0200000A RID: 10
	public sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002137 File Offset: 0x00000337
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowStub()
		{
			Il2CppClassPointerStore<ThrowStub>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "Unity", "ThrowStub");
			ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowStub>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000027BC File Offset: 0x000009BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275250, XrefRangeEnd = 1275255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002166 File Offset: 0x00000366
		public ThrowStub(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0;
	}
}
