using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000033 RID: 51
	public class MD2 : HashAlgorithm
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x0000ED10 File Offset: 0x0000CF10
		// Note: this type is marked as 'beforefieldinit'.
		static MD2()
		{
			Il2CppClassPointerStore<MD2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "MD2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2>.NativeClassPtr);
			MD2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663707);
			MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663708);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000ED68 File Offset: 0x0000CF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149672, XrefRangeEnd = 1149673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149673, XrefRangeEnd = 1149690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD2 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD2>(intPtr3) : null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000330E File Offset: 0x0000150E
		public MD2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD2_0;
	}
}
