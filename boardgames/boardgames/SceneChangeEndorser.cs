using System;
using dwd.core.endorsement;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200001E RID: 30
public class SceneChangeEndorser : SubscribableEndorser<SceneChangeRequest>
{
	// Token: 0x060000EB RID: 235 RVA: 0x00002699 File Offset: 0x00000899
	// Note: this type is marked as 'beforefieldinit'.
	static SceneChangeEndorser()
	{
		Il2CppClassPointerStore<SceneChangeEndorser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "SceneChangeEndorser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneChangeEndorser>.NativeClassPtr);
		SceneChangeEndorser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeEndorser>.NativeClassPtr, 100663489);
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00013880 File Offset: 0x00011A80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983181, XrefRangeEnd = 983184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneChangeEndorser()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneChangeEndorser>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeEndorser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x000026D2 File Offset: 0x000008D2
	public SceneChangeEndorser(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000099 RID: 153
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
