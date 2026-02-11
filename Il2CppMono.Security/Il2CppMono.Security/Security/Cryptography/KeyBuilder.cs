using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000032 RID: 50
	public sealed class KeyBuilder : Object
	{
		// Token: 0x060002CC RID: 716 RVA: 0x0000EC08 File Offset: 0x0000CE08
		// Note: this type is marked as 'beforefieldinit'.
		static KeyBuilder()
		{
			Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "KeyBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr);
			KeyBuilder.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, "rng");
			KeyBuilder.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, 100663705);
			KeyBuilder.NativeMethodInfoPtr_Key_Public_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBuilder>.NativeClassPtr, 100663706);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000EC74 File Offset: 0x0000CE74
		public unsafe static RandomNumberGenerator Rng
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149655, XrefRangeEnd = 1149662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002CE RID: 718 RVA: 0x0000ECA8 File Offset: 0x0000CEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149662, XrefRangeEnd = 1149672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002CF RID: 719 RVA: 0x000032F3 File Offset: 0x000014F3
		public KeyBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000032FC File Offset: 0x000014FC
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

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_Key_Public_Static_Il2CppStructArray_1_Byte_Int32_0;
	}
}
