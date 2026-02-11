using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200025F RID: 607
	public class SHA256 : HashAlgorithm
	{
		// Token: 0x06002757 RID: 10071 RVA: 0x000D5F1C File Offset: 0x000D411C
		// Note: this type is marked as 'beforefieldinit'.
		static SHA256()
		{
			Il2CppClassPointerStore<SHA256>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA256");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA256>.NativeClassPtr);
			SHA256.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256>.NativeClassPtr, 100669793);
			SHA256.NativeMethodInfoPtr_Create_Public_Static_SHA256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256>.NativeClassPtr, 100669794);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000D5F74 File Offset: 0x000D4174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373324, XrefRangeEnd = 1373325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA256()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA256>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000D5FB0 File Offset: 0x000D41B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1373329, RefRangeEnd = 1373336, XrefRangeStart = 1373325, XrefRangeEnd = 1373329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA256 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256.NativeMethodInfoPtr_Create_Public_Static_SHA256_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA256>(intPtr3) : null;
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0000CDCA File Offset: 0x0000AFCA
		public SHA256(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA256_0;
	}
}
