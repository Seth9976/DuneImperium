using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200026B RID: 619
	public class DSASignatureDescription : SignatureDescription
	{
		// Token: 0x060027D7 RID: 10199 RVA: 0x0000D153 File Offset: 0x0000B353
		// Note: this type is marked as 'beforefieldinit'.
		static DSASignatureDescription()
		{
			Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr);
			DSASignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr, 100669860);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000D7BC8 File Offset: 0x000D5DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373825, XrefRangeEnd = 1373838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0000D18C File Offset: 0x0000B38C
		public DSASignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
