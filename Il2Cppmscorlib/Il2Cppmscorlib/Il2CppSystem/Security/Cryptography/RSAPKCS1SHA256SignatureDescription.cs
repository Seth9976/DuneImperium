using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000268 RID: 616
	public class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060027CE RID: 10190 RVA: 0x0000D08D File Offset: 0x0000B28D
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA256SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA256SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA256SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr, 100669857);
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000D7B14 File Offset: 0x000D5D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373810, XrefRangeEnd = 1373815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA256SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA256SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x0000D0C6 File Offset: 0x0000B2C6
		public RSAPKCS1SHA256SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
