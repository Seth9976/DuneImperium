using System;
using boardgames.moz;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200000C RID: 12
public class WormCardMoz : CardMoz
{
	// Token: 0x06000043 RID: 67 RVA: 0x000021EF File Offset: 0x000003EF
	// Note: this type is marked as 'beforefieldinit'.
	static WormCardMoz()
	{
		Il2CppClassPointerStore<WormCardMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormCardMoz");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCardMoz>.NativeClassPtr);
		WormCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardMoz>.NativeClassPtr, 100663338);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00019820 File Offset: 0x00017A20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 510310, RefRangeEnd = 510311, XrefRangeStart = 510310, XrefRangeEnd = 510311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormCardMoz()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCardMoz>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002228 File Offset: 0x00000428
	public WormCardMoz(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
