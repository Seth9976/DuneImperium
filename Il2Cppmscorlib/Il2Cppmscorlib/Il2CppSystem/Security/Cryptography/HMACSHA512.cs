using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200024B RID: 587
	public class HMACSHA512 : HMAC
	{
		// Token: 0x0600262B RID: 9771 RVA: 0x000D19E4 File Offset: 0x000CFBE4
		// Note: this type is marked as 'beforefieldinit'.
		static HMACSHA512()
		{
			Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACSHA512");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr);
			HMACSHA512.NativeFieldInfoPtr_m_useLegacyBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr, "m_useLegacyBlockSize");
			HMACSHA512.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr, 100669658);
			HMACSHA512.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr, 100669659);
			HMACSHA512.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr, 100669660);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000D1A64 File Offset: 0x000CFC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372303, XrefRangeEnd = 1372320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA512()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA512.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000D1AA0 File Offset: 0x000CFCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372336, RefRangeEnd = 1372337, XrefRangeStart = 1372320, XrefRangeEnd = 1372336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA512(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA512.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x000D1AEC File Offset: 0x000CFCEC
		public unsafe int BlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA512.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0000C62A File Offset: 0x0000A82A
		public HMACSHA512(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x000D1B28 File Offset: 0x000CFD28
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x0000C633 File Offset: 0x0000A833
		public unsafe bool m_useLegacyBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA512.NativeFieldInfoPtr_m_useLegacyBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA512.NativeFieldInfoPtr_m_useLegacyBlockSize)) = value;
			}
		}

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeFieldInfoPtr_m_useLegacyBlockSize;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0;
	}
}
