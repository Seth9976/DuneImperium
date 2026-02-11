using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002C RID: 44
	public sealed class KeyBuilder : Object
	{
		// Token: 0x0600021C RID: 540 RVA: 0x0002DC3C File Offset: 0x0002BE3C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyBuilder()
		{
			Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "KeyBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr);
			KeyBuilder.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, "rng");
			KeyBuilder.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, 100663613);
			KeyBuilder.NativeMethodInfoPtr_Key_Public_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, 100663614);
			KeyBuilder.NativeMethodInfoPtr_IV_Public_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, 100663615);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		public unsafe static RandomNumberGenerator Rng
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1277876, RefRangeEnd = 1277878, XrefRangeStart = 1277869, XrefRangeEnd = 1277876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBuilder.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1277882, RefRangeEnd = 1277888, XrefRangeStart = 1277878, XrefRangeEnd = 1277882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Key(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBuilder.NativeMethodInfoPtr_Key_Public_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0002DD30 File Offset: 0x0002BF30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277892, RefRangeEnd = 1277894, XrefRangeStart = 1277888, XrefRangeEnd = 1277892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> IV(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBuilder.NativeMethodInfoPtr_IV_Public_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public KeyBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0002DD70 File Offset: 0x0002BF70
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002DE9 File Offset: 0x00000FE9
		public unsafe static RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyBuilder.NativeFieldInfoPtr_rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyBuilder.NativeFieldInfoPtr_rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_Key_Public_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_IV_Public_Static_Il2CppStructArray_1_Byte_Int32_0;
	}
}
