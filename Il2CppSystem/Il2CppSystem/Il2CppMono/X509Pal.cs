using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000004 RID: 4
	public static class X509Pal : Object
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000020E9 File Offset: 0x000002E9
		// Note: this type is marked as 'beforefieldinit'.
		static X509Pal()
		{
			Il2CppClassPointerStore<X509Pal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono", "X509Pal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Pal>.NativeClassPtr);
			X509Pal.NativeMethodInfoPtr_get_Instance_Public_Static_get_X509PalImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Pal>.NativeClassPtr, 100663314);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0001AF08 File Offset: 0x00019108
		public unsafe static X509PalImpl Instance
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 426795, RefRangeEnd = 426798, XrefRangeStart = 426782, XrefRangeEnd = 426795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Pal.NativeMethodInfoPtr_get_Instance_Public_Static_get_X509PalImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002122 File Offset: 0x00000322
		public X509Pal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_X509PalImpl_0;
	}
}
