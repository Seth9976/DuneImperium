using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000035 RID: 53
	public class MD4 : HashAlgorithm
	{
		// Token: 0x060002EA RID: 746 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		// Note: this type is marked as 'beforefieldinit'.
		static MD4()
		{
			Il2CppClassPointerStore<MD4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "MD4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD4>.NativeClassPtr);
			MD4.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663716);
			MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663717);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000F250 File Offset: 0x0000D450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD4>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000F28C File Offset: 0x0000D48C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1149755, RefRangeEnd = 1149758, XrefRangeStart = 1149734, XrefRangeEnd = 1149755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD4 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD4>(intPtr3) : null;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000033C9 File Offset: 0x000015C9
		public MD4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD4_0;
	}
}
