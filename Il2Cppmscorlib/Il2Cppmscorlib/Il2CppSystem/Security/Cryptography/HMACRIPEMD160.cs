using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000247 RID: 583
	public class HMACRIPEMD160 : HMAC
	{
		// Token: 0x06002617 RID: 9751 RVA: 0x000D1568 File Offset: 0x000CF768
		// Note: this type is marked as 'beforefieldinit'.
		static HMACRIPEMD160()
		{
			Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACRIPEMD160");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr);
			HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr, 100669648);
			HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr, 100669649);
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x000D15C0 File Offset: 0x000CF7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372177, XrefRangeEnd = 1372193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACRIPEMD160()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x000D15FC File Offset: 0x000CF7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372193, XrefRangeEnd = 1372208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACRIPEMD160(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0000C5EB File Offset: 0x0000A7EB
		public HMACRIPEMD160(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
