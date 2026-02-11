using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000030 RID: 48
	public class MD4 : HashAlgorithm
	{
		// Token: 0x0600026B RID: 619 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
		// Note: this type is marked as 'beforefieldinit'.
		static MD4()
		{
			Il2CppClassPointerStore<MD4>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "MD4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD4>.NativeClassPtr);
			MD4.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663654);
			MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663655);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0002EE08 File Offset: 0x0002D008
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

		// Token: 0x0600026D RID: 621 RVA: 0x0002EE44 File Offset: 0x0002D044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278286, XrefRangeEnd = 1278307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD4 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD4>(intPtr3) : null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002F8D File Offset: 0x0000118D
		public MD4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD4_0;
	}
}
