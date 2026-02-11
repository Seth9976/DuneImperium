using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000236 RID: 566
	public class AsymmetricSignatureFormatter : Object
	{
		// Token: 0x06002580 RID: 9600 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricSignatureFormatter()
		{
			Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "AsymmetricSignatureFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr);
			AsymmetricSignatureFormatter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr, 100669581);
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000CF3E8 File Offset: 0x000CD5E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricSignatureFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricSignatureFormatter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x0000C235 File Offset: 0x0000A435
		public AsymmetricSignatureFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
