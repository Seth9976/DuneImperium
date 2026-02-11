using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000254 RID: 596
	public class Rijndael : SymmetricAlgorithm
	{
		// Token: 0x0600268F RID: 9871 RVA: 0x000D318C File Offset: 0x000D138C
		// Note: this type is marked as 'beforefieldinit'.
		static Rijndael()
		{
			Il2CppClassPointerStore<Rijndael>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Rijndael");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rijndael>.NativeClassPtr);
			Rijndael.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, "s_legalBlockSizes");
			Rijndael.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, "s_legalKeySizes");
			Rijndael.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, 100669710);
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000D31F8 File Offset: 0x000D13F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372589, XrefRangeEnd = 1372597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rijndael()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rijndael>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rijndael.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0000C828 File Offset: 0x0000AA28
		public Rijndael(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x000D3234 File Offset: 0x000D1434
		// (set) Token: 0x06002693 RID: 9875 RVA: 0x0000C831 File Offset: 0x0000AA31
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Rijndael.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Rijndael.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x000D325C File Offset: 0x000D145C
		// (set) Token: 0x06002695 RID: 9877 RVA: 0x0000C843 File Offset: 0x0000AA43
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Rijndael.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Rijndael.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
