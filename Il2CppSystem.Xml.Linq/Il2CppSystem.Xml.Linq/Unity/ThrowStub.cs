using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity
{
	// Token: 0x0200001F RID: 31
	public sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x0600016F RID: 367 RVA: 0x00002777 File Offset: 0x00000977
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowStub()
		{
			Il2CppClassPointerStore<ThrowStub>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "Unity", "ThrowStub");
			ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowStub>.NativeClassPtr, 100663542);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000890C File Offset: 0x00006B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238671, XrefRangeEnd = 1238676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000027A6 File Offset: 0x000009A6
		public ThrowStub(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0;
	}
}
