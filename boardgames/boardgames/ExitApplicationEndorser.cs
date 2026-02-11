using System;
using dwd.core.endorsement;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200001C RID: 28
public class ExitApplicationEndorser : SubscribableEndorser<ExitApplicationRequest>
{
	// Token: 0x060000E5 RID: 229 RVA: 0x00002615 File Offset: 0x00000815
	// Note: this type is marked as 'beforefieldinit'.
	static ExitApplicationEndorser()
	{
		Il2CppClassPointerStore<ExitApplicationEndorser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "ExitApplicationEndorser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitApplicationEndorser>.NativeClassPtr);
		ExitApplicationEndorser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationEndorser>.NativeClassPtr, 100663487);
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00013808 File Offset: 0x00011A08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983177, XrefRangeEnd = 983180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExitApplicationEndorser()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitApplicationEndorser>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationEndorser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0000264E File Offset: 0x0000084E
	public ExitApplicationEndorser(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000097 RID: 151
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
