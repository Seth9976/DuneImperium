using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200001A RID: 26
public class CheckDefaultGraphicsBootSettings : MonoBehaviour
{
	// Token: 0x060000CF RID: 207 RVA: 0x00013320 File Offset: 0x00011520
	// Note: this type is marked as 'beforefieldinit'.
	static CheckDefaultGraphicsBootSettings()
	{
		Il2CppClassPointerStore<CheckDefaultGraphicsBootSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "CheckDefaultGraphicsBootSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckDefaultGraphicsBootSettings>.NativeClassPtr);
		CheckDefaultGraphicsBootSettings.NativeMethodInfoPtr_GetNvOptimusEnablement_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckDefaultGraphicsBootSettings>.NativeClassPtr, 100663465);
		CheckDefaultGraphicsBootSettings.NativeMethodInfoPtr_GetAmdPowerXpressRequest_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckDefaultGraphicsBootSettings>.NativeClassPtr, 100663466);
		CheckDefaultGraphicsBootSettings.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckDefaultGraphicsBootSettings>.NativeClassPtr, 100663467);
		CheckDefaultGraphicsBootSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckDefaultGraphicsBootSettings>.NativeClassPtr, 100663468);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x000133A0 File Offset: 0x000115A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982957, XrefRangeEnd = 982959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNvOptimusEnablement()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckDefaultGraphicsBootSettings.NativeMethodInfoPtr_GetNvOptimusEnablement_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x000133D0 File Offset: 0x000115D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982959, XrefRangeEnd = 982961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAmdPowerXpressRequest()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckDefaultGraphicsBootSettings.NativeMethodInfoPtr_GetAmdPowerXpressRequest_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00013400 File Offset: 0x00011600
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982961, XrefRangeEnd = 982983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckDefaultGraphicsBootSettings.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00013434 File Offset: 0x00011634
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CheckDefaultGraphicsBootSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckDefaultGraphicsBootSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckDefaultGraphicsBootSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000258B File Offset: 0x0000078B
	public CheckDefaultGraphicsBootSettings(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000089 RID: 137
	private static readonly IntPtr NativeMethodInfoPtr_GetNvOptimusEnablement_Public_Static_Int32_0;

	// Token: 0x0400008A RID: 138
	private static readonly IntPtr NativeMethodInfoPtr_GetAmdPowerXpressRequest_Public_Static_Int32_0;

	// Token: 0x0400008B RID: 139
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400008C RID: 140
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
