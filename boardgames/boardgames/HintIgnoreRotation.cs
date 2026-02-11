using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class HintIgnoreRotation : MonoBehaviour
{
	// Token: 0x060000AA RID: 170 RVA: 0x00002412 File Offset: 0x00000612
	// Note: this type is marked as 'beforefieldinit'.
	static HintIgnoreRotation()
	{
		Il2CppClassPointerStore<HintIgnoreRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "HintIgnoreRotation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintIgnoreRotation>.NativeClassPtr);
		HintIgnoreRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintIgnoreRotation>.NativeClassPtr, 100663435);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00012D00 File Offset: 0x00010F00
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HintIgnoreRotation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintIgnoreRotation>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintIgnoreRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000244B File Offset: 0x0000064B
	public HintIgnoreRotation(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000077 RID: 119
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
