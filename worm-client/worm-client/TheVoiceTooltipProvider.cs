using System;
using boardgames.moz;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class TheVoiceTooltipProvider : MonoBehaviour
{
	// Token: 0x06000039 RID: 57 RVA: 0x00019648 File Offset: 0x00017848
	// Note: this type is marked as 'beforefieldinit'.
	static TheVoiceTooltipProvider()
	{
		Il2CppClassPointerStore<TheVoiceTooltipProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "TheVoiceTooltipProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheVoiceTooltipProvider>.NativeClassPtr);
		TheVoiceTooltipProvider.NativeFieldInfoPtr_baseTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheVoiceTooltipProvider>.NativeClassPtr, "baseTooltip");
		TheVoiceTooltipProvider.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheVoiceTooltipProvider>.NativeClassPtr, 100663334);
		TheVoiceTooltipProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheVoiceTooltipProvider>.NativeClassPtr, 100663335);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000196B4 File Offset: 0x000178B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687075, XrefRangeEnd = 687095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetLocalizedTooltip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TheVoiceTooltipProvider.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000196EC File Offset: 0x000178EC
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TheVoiceTooltipProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheVoiceTooltipProvider>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TheVoiceTooltipProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000021BE File Offset: 0x000003BE
	public TheVoiceTooltipProvider(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600003D RID: 61 RVA: 0x00019728 File Offset: 0x00017928
	// (set) Token: 0x0600003E RID: 62 RVA: 0x000021C7 File Offset: 0x000003C7
	public unsafe DBGTooltip baseTooltip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TheVoiceTooltipProvider.NativeFieldInfoPtr_baseTooltip);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTooltip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TheVoiceTooltipProvider.NativeFieldInfoPtr_baseTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeFieldInfoPtr_baseTooltip;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
