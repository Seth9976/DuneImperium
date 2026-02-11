using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000249 RID: 585
	public class HMACSHA256 : HMAC
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x000D1798 File Offset: 0x000CF998
		// Note: this type is marked as 'beforefieldinit'.
		static HMACSHA256()
		{
			Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACSHA256");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr);
			HMACSHA256.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr, 100669653);
			HMACSHA256.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr, 100669654);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000D17F0 File Offset: 0x000CF9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372239, XrefRangeEnd = 1372255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA256()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA256.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000D182C File Offset: 0x000CFA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372255, XrefRangeEnd = 1372270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA256(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA256.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x0000C5FD File Offset: 0x0000A7FD
		public HMACSHA256(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
