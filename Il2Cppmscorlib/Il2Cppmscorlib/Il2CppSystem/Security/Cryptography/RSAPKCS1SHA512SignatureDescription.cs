using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200026A RID: 618
	public class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060027D4 RID: 10196 RVA: 0x0000D111 File Offset: 0x0000B311
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA512SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA512SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA512SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr, 100669859);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000D7B8C File Offset: 0x000D5D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373820, XrefRangeEnd = 1373825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA512SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA512SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x0000D14A File Offset: 0x0000B34A
		public RSAPKCS1SHA512SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
