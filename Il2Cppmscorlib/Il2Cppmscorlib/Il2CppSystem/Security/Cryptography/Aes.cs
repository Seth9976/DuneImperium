using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000233 RID: 563
	public class Aes : SymmetricAlgorithm
	{
		// Token: 0x06002565 RID: 9573 RVA: 0x000CEDB4 File Offset: 0x000CCFB4
		// Note: this type is marked as 'beforefieldinit'.
		static Aes()
		{
			Il2CppClassPointerStore<Aes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Aes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Aes>.NativeClassPtr);
			Aes.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aes>.NativeClassPtr, "s_legalBlockSizes");
			Aes.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aes>.NativeClassPtr, "s_legalKeySizes");
			Aes.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aes>.NativeClassPtr, 100669567);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000CEE20 File Offset: 0x000CD020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371550, RefRangeEnd = 1371552, XrefRangeStart = 1371542, XrefRangeEnd = 1371550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Aes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Aes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Aes.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0000C183 File Offset: 0x0000A383
		public Aes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000CEE5C File Offset: 0x000CD05C
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x0000C18C File Offset: 0x0000A38C
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Aes.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Aes.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000CEE84 File Offset: 0x000CD084
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x0000C19E File Offset: 0x0000A39E
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Aes.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Aes.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
