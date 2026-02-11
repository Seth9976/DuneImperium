using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class WormHideImperiumRowScript : MonoBehaviour
{
	// Token: 0x060000A9 RID: 169 RVA: 0x0001AB80 File Offset: 0x00018D80
	// Note: this type is marked as 'beforefieldinit'.
	static WormHideImperiumRowScript()
	{
		Il2CppClassPointerStore<WormHideImperiumRowScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormHideImperiumRowScript");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHideImperiumRowScript>.NativeClassPtr);
		WormHideImperiumRowScript.NativeMethodInfoPtr_Event_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowScript>.NativeClassPtr, 100663401);
		WormHideImperiumRowScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideImperiumRowScript>.NativeClassPtr, 100663402);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x0001ABD8 File Offset: 0x00018DD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687500, XrefRangeEnd = 687504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowScript.NativeMethodInfoPtr_Event_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0001AC0C File Offset: 0x00018E0C
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormHideImperiumRowScript()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHideImperiumRowScript>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideImperiumRowScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000256B File Offset: 0x0000076B
	public WormHideImperiumRowScript(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000063 RID: 99
	private static readonly IntPtr NativeMethodInfoPtr_Event_Hide_Public_Void_0;

	// Token: 0x04000064 RID: 100
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
