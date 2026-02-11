using System;
using dwd.core.endorsement;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200001D RID: 29
public class ExitApplicationRequest : Request
{
	// Token: 0x060000E8 RID: 232 RVA: 0x00002657 File Offset: 0x00000857
	// Note: this type is marked as 'beforefieldinit'.
	static ExitApplicationRequest()
	{
		Il2CppClassPointerStore<ExitApplicationRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "ExitApplicationRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitApplicationRequest>.NativeClassPtr);
		ExitApplicationRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationRequest>.NativeClassPtr, 100663488);
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00013844 File Offset: 0x00011A44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983180, XrefRangeEnd = 983181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExitApplicationRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitApplicationRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00002690 File Offset: 0x00000890
	public ExitApplicationRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000098 RID: 152
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
