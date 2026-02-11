using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using worm.canis.data.enums;

// Token: 0x0200000E RID: 14
public class WormDiscardFTTTrigger : WormTagBasedFTTTrigger
{
	// Token: 0x06000058 RID: 88 RVA: 0x00019BB0 File Offset: 0x00017DB0
	// Note: this type is marked as 'beforefieldinit'.
	static WormDiscardFTTTrigger()
	{
		Il2CppClassPointerStore<WormDiscardFTTTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormDiscardFTTTrigger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardFTTTrigger>.NativeClassPtr);
		WormDiscardFTTTrigger.NativeMethodInfoPtr_get_Tag_Protected_Virtual_get_CardTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardFTTTrigger>.NativeClassPtr, 100663351);
		WormDiscardFTTTrigger.NativeMethodInfoPtr_get_EventName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardFTTTrigger>.NativeClassPtr, 100663352);
		WormDiscardFTTTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardFTTTrigger>.NativeClassPtr, 100663353);
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000059 RID: 89 RVA: 0x00019C1C File Offset: 0x00017E1C
	public unsafe override CardTags Tag
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDiscardFTTTrigger.NativeMethodInfoPtr_get_Tag_Protected_Virtual_get_CardTags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600005A RID: 90 RVA: 0x00019C64 File Offset: 0x00017E64
	public unsafe override string EventName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687153, XrefRangeEnd = 687155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDiscardFTTTrigger.NativeMethodInfoPtr_get_EventName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00019CA8 File Offset: 0x00017EA8
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormDiscardFTTTrigger()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardFTTTrigger>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardFTTTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000022D5 File Offset: 0x000004D5
	public WormDiscardFTTTrigger(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Protected_Virtual_get_CardTags_0;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeMethodInfoPtr_get_EventName_Protected_Virtual_get_String_0;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
