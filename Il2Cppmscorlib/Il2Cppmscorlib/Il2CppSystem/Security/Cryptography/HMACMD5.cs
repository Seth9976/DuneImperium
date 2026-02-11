using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000246 RID: 582
	public class HMACMD5 : HMAC
	{
		// Token: 0x06002613 RID: 9747 RVA: 0x000D1488 File Offset: 0x000CF688
		// Note: this type is marked as 'beforefieldinit'.
		static HMACMD5()
		{
			Il2CppClassPointerStore<HMACMD5>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACMD5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr);
			HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr, 100669646);
			HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr, 100669647);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x000D14E0 File Offset: 0x000CF6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372159, RefRangeEnd = 1372160, XrefRangeStart = 1372143, XrefRangeEnd = 1372159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACMD5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x000D151C File Offset: 0x000CF71C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1372175, RefRangeEnd = 1372177, XrefRangeStart = 1372160, XrefRangeEnd = 1372175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACMD5(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x0000C5E2 File Offset: 0x0000A7E2
		public HMACMD5(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
