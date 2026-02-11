using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002E RID: 46
	public class MD2 : HashAlgorithm
	{
		// Token: 0x06000253 RID: 595 RVA: 0x0002E8C8 File Offset: 0x0002CAC8
		// Note: this type is marked as 'beforefieldinit'.
		static MD2()
		{
			Il2CppClassPointerStore<MD2>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "MD2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2>.NativeClassPtr);
			MD2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663645);
			MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663646);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0002E920 File Offset: 0x0002CB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0002E95C File Offset: 0x0002CB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278245, RefRangeEnd = 1278246, XrefRangeStart = 1278228, XrefRangeEnd = 1278245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD2 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD2>(intPtr3) : null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002ED2 File Offset: 0x000010D2
		public MD2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD2_0;
	}
}
