using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200024A RID: 586
	public class HMACSHA384 : HMAC
	{
		// Token: 0x06002624 RID: 9764 RVA: 0x000D1878 File Offset: 0x000CFA78
		// Note: this type is marked as 'beforefieldinit'.
		static HMACSHA384()
		{
			Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACSHA384");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr);
			HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, "m_useLegacyBlockSize");
			HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100669655);
			HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100669656);
			HMACSHA384.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100669657);
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000D18F8 File Offset: 0x000CFAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372270, XrefRangeEnd = 1372287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA384()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000D1934 File Offset: 0x000CFB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372287, XrefRangeEnd = 1372303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA384(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x000D1980 File Offset: 0x000CFB80
		public unsafe int BlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0000C606 File Offset: 0x0000A806
		public HMACSHA384(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x000D19BC File Offset: 0x000CFBBC
		// (set) Token: 0x0600262A RID: 9770 RVA: 0x0000C60F File Offset: 0x0000A80F
		public unsafe bool m_useLegacyBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize)) = value;
			}
		}

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeFieldInfoPtr_m_useLegacyBlockSize;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0;
	}
}
