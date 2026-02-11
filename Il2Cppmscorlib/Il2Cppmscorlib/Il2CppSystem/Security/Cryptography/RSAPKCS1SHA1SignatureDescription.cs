using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000267 RID: 615
	public class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060027CB RID: 10187 RVA: 0x0000D04B File Offset: 0x0000B24B
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA1SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA1SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA1SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr, 100669856);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000D7AD8 File Offset: 0x000D5CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373805, XrefRangeEnd = 1373810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA1SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA1SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0000D084 File Offset: 0x0000B284
		public RSAPKCS1SHA1SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
