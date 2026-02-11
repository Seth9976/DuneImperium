using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000230 RID: 560
	public static class CryptographicOperations : Object
	{
		// Token: 0x06002532 RID: 9522 RVA: 0x0000C08E File Offset: 0x0000A28E
		// Note: this type is marked as 'beforefieldinit'.
		static CryptographicOperations()
		{
			Il2CppClassPointerStore<CryptographicOperations>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptographicOperations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptographicOperations>.NativeClassPtr);
			CryptographicOperations.NativeMethodInfoPtr_ZeroMemory_Public_Static_Void_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicOperations>.NativeClassPtr, 100669533);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000CDF68 File Offset: 0x000CC168
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1371310, RefRangeEnd = 1371328, XrefRangeStart = 1371307, XrefRangeEnd = 1371310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroMemory(Span<byte> buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicOperations.NativeMethodInfoPtr_ZeroMemory_Public_Static_Void_Span_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x0000C0C7 File Offset: 0x0000A2C7
		public CryptographicOperations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeMethodInfoPtr_ZeroMemory_Public_Static_Void_Span_1_Byte_0;
	}
}
