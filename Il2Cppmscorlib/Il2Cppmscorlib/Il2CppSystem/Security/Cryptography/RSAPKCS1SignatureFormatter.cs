using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000277 RID: 631
	public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x060028BE RID: 10430 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SignatureFormatter()
		{
			Il2CppClassPointerStore<RSAPKCS1SignatureFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SignatureFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SignatureFormatter>.NativeClassPtr);
			RSAPKCS1SignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureFormatter>.NativeClassPtr, 100669970);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000DAFE0 File Offset: 0x000D91E0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SignatureFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SignatureFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0000D71D File Offset: 0x0000B91D
		public RSAPKCS1SignatureFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
