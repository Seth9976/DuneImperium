using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000258 RID: 600
	public class RIPEMD160 : HashAlgorithm
	{
		// Token: 0x060026E3 RID: 9955 RVA: 0x000D43B4 File Offset: 0x000D25B4
		// Note: this type is marked as 'beforefieldinit'.
		static RIPEMD160()
		{
			Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RIPEMD160");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr);
			RIPEMD160.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr, 100669738);
			RIPEMD160.NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr, 100669739);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000D440C File Offset: 0x000D260C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372845, XrefRangeEnd = 1372846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RIPEMD160()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x000D4448 File Offset: 0x000D2648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372846, XrefRangeEnd = 1372850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RIPEMD160 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160.NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RIPEMD160>(intPtr3) : null;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0000CAD9 File Offset: 0x0000ACD9
		public RIPEMD160(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0;
	}
}
