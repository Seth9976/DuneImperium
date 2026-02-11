using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200025D RID: 605
	public class SHA1 : HashAlgorithm
	{
		// Token: 0x06002740 RID: 10048 RVA: 0x000D59E4 File Offset: 0x000D3BE4
		// Note: this type is marked as 'beforefieldinit'.
		static SHA1()
		{
			Il2CppClassPointerStore<SHA1>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA1>.NativeClassPtr);
			SHA1.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1>.NativeClassPtr, 100669782);
			SHA1.NativeMethodInfoPtr_Create_Public_Static_SHA1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1>.NativeClassPtr, 100669783);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000D5A3C File Offset: 0x000D3C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373260, RefRangeEnd = 1373261, XrefRangeStart = 1373259, XrefRangeEnd = 1373260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000D5A78 File Offset: 0x000D3C78
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1373265, RefRangeEnd = 1373274, XrefRangeStart = 1373261, XrefRangeEnd = 1373265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA1 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1.NativeMethodInfoPtr_Create_Public_Static_SHA1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA1>(intPtr3) : null;
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0000CD40 File Offset: 0x0000AF40
		public SHA1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA1_0;
	}
}
