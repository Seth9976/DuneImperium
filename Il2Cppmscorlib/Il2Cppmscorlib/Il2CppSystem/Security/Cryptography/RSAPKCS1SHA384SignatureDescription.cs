using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000269 RID: 617
	public class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060027D1 RID: 10193 RVA: 0x0000D0CF File Offset: 0x0000B2CF
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA384SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA384SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA384SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr, 100669858);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000D7B50 File Offset: 0x000D5D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373815, XrefRangeEnd = 1373820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA384SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA384SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0000D108 File Offset: 0x0000B308
		public RSAPKCS1SHA384SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
