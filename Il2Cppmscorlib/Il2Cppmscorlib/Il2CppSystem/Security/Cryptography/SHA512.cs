using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000263 RID: 611
	public class SHA512 : HashAlgorithm
	{
		// Token: 0x06002797 RID: 10135 RVA: 0x000D6F24 File Offset: 0x000D5124
		// Note: this type is marked as 'beforefieldinit'.
		static SHA512()
		{
			Il2CppClassPointerStore<SHA512>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA512");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA512>.NativeClassPtr);
			SHA512.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512>.NativeClassPtr, 100669831);
			SHA512.NativeMethodInfoPtr_Create_Public_Static_SHA512_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512>.NativeClassPtr, 100669832);
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000D6F7C File Offset: 0x000D517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373634, XrefRangeEnd = 1373635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA512()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA512>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000D6FB8 File Offset: 0x000D51B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1373639, RefRangeEnd = 1373642, XrefRangeStart = 1373635, XrefRangeEnd = 1373639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA512 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512.NativeMethodInfoPtr_Create_Public_Static_SHA512_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA512>(intPtr3) : null;
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x0000CF02 File Offset: 0x0000B102
		public SHA512(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA512_0;
	}
}
