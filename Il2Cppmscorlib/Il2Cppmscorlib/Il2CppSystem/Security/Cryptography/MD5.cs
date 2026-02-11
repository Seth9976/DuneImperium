using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000250 RID: 592
	public class MD5 : HashAlgorithm
	{
		// Token: 0x0600266B RID: 9835 RVA: 0x000D295C File Offset: 0x000D0B5C
		// Note: this type is marked as 'beforefieldinit'.
		static MD5()
		{
			Il2CppClassPointerStore<MD5>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MD5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD5>.NativeClassPtr);
			MD5.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5>.NativeClassPtr, 100669690);
			MD5.NativeMethodInfoPtr_Create_Public_Static_MD5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5>.NativeClassPtr, 100669691);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000D29B4 File Offset: 0x000D0BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372480, RefRangeEnd = 1372481, XrefRangeStart = 1372479, XrefRangeEnd = 1372480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD5>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x000D29F0 File Offset: 0x000D0BF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1372485, RefRangeEnd = 1372489, XrefRangeStart = 1372481, XrefRangeEnd = 1372485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD5 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5.NativeMethodInfoPtr_Create_Public_Static_MD5_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD5>(intPtr3) : null;
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x0000C798 File Offset: 0x0000A998
		public MD5(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD5_0;
	}
}
