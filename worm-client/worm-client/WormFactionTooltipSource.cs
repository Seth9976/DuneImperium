using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

// Token: 0x02000010 RID: 16
public class WormFactionTooltipSource : Observer
{
	// Token: 0x0600007E RID: 126 RVA: 0x0001A304 File Offset: 0x00018504
	// Note: this type is marked as 'beforefieldinit'.
	static WormFactionTooltipSource()
	{
		Il2CppClassPointerStore<WormFactionTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormFactionTooltipSource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTooltipSource>.NativeClassPtr);
		WormFactionTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTooltipSource>.NativeClassPtr, 100663375);
		WormFactionTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTooltipSource>.NativeClassPtr, 100663376);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0001A35C File Offset: 0x0001855C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687308, XrefRangeEnd = 687330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetLocalizedTooltip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0001A394 File Offset: 0x00018594
	[CallerCount(197)]
	[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormFactionTooltipSource()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTooltipSource>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0000243C File Offset: 0x0000063C
	public WormFactionTooltipSource(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000048 RID: 72
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

	// Token: 0x04000049 RID: 73
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
