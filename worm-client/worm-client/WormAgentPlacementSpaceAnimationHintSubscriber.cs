using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using worm.match.data;

// Token: 0x0200001A RID: 26
public class WormAgentPlacementSpaceAnimationHintSubscriber : VersionedSubscriber<WormChosenEntityData>
{
	// Token: 0x060000FB RID: 251 RVA: 0x0001BC9C File Offset: 0x00019E9C
	// Note: this type is marked as 'beforefieldinit'.
	static WormAgentPlacementSpaceAnimationHintSubscriber()
	{
		Il2CppClassPointerStore<WormAgentPlacementSpaceAnimationHintSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormAgentPlacementSpaceAnimationHintSubscriber");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgentPlacementSpaceAnimationHintSubscriber>.NativeClassPtr);
		WormAgentPlacementSpaceAnimationHintSubscriber.NativeFieldInfoPtr_setTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentPlacementSpaceAnimationHintSubscriber>.NativeClassPtr, "setTrigger");
		WormAgentPlacementSpaceAnimationHintSubscriber.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentPlacementSpaceAnimationHintSubscriber>.NativeClassPtr, "viewManager");
		WormAgentPlacementSpaceAnimationHintSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentPlacementSpaceAnimationHintSubscriber>.NativeClassPtr, 100663441);
		WormAgentPlacementSpaceAnimationHintSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentPlacementSpaceAnimationHintSubscriber>.NativeClassPtr, 100663442);
		WormAgentPlacementSpaceAnimationHintSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentPlacementSpaceAnimationHintSubscriber>.NativeClassPtr, 100663443);
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0001BD30 File Offset: 0x00019F30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687710, XrefRangeEnd = 687713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAgentPlacementSpaceAnimationHintSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0001BD6C File Offset: 0x00019F6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687713, XrefRangeEnd = 687730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void dirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAgentPlacementSpaceAnimationHintSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0001BDA8 File Offset: 0x00019FA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687730, XrefRangeEnd = 687736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormAgentPlacementSpaceAnimationHintSubscriber()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgentPlacementSpaceAnimationHintSubscriber>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentPlacementSpaceAnimationHintSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000FF RID: 255 RVA: 0x000027A5 File Offset: 0x000009A5
	public WormAgentPlacementSpaceAnimationHintSubscriber(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000100 RID: 256 RVA: 0x0001BDE4 File Offset: 0x00019FE4
	// (set) Token: 0x06000101 RID: 257 RVA: 0x000027AE File Offset: 0x000009AE
	public unsafe string setTrigger
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentPlacementSpaceAnimationHintSubscriber.NativeFieldInfoPtr_setTrigger);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentPlacementSpaceAnimationHintSubscriber.NativeFieldInfoPtr_setTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000102 RID: 258 RVA: 0x0001BE0C File Offset: 0x0001A00C
	// (set) Token: 0x06000103 RID: 259 RVA: 0x000027CD File Offset: 0x000009CD
	public unsafe ViewManager viewManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentPlacementSpaceAnimationHintSubscriber.NativeFieldInfoPtr_viewManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentPlacementSpaceAnimationHintSubscriber.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000096 RID: 150
	private static readonly IntPtr NativeFieldInfoPtr_setTrigger;

	// Token: 0x04000097 RID: 151
	private static readonly IntPtr NativeFieldInfoPtr_viewManager;

	// Token: 0x04000098 RID: 152
	private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

	// Token: 0x04000099 RID: 153
	private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

	// Token: 0x0400009A RID: 154
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
