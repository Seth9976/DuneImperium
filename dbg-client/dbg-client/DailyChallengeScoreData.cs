using System;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200000B RID: 11
public class DailyChallengeScoreData : DataComponent
{
	// Token: 0x0600004C RID: 76 RVA: 0x0001E5BC File Offset: 0x0001C7BC
	// Note: this type is marked as 'beforefieldinit'.
	static DailyChallengeScoreData()
	{
		Il2CppClassPointerStore<DailyChallengeScoreData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "DailyChallengeScoreData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeScoreData>.NativeClassPtr);
		DailyChallengeScoreData.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeScoreData>.NativeClassPtr, "Score");
		DailyChallengeScoreData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_LocalizableTextVariables_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeScoreData>.NativeClassPtr, 100663360);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0001E614 File Offset: 0x0001C814
	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495238, XrefRangeEnd = 495240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DailyChallengeScoreData(Dictionary<LocalizableTextVariables, int> score)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeScoreData>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(score);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeScoreData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_LocalizableTextVariables_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002208 File Offset: 0x00000408
	public DailyChallengeScoreData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600004F RID: 79 RVA: 0x0001E660 File Offset: 0x0001C860
	// (set) Token: 0x06000050 RID: 80 RVA: 0x00002211 File Offset: 0x00000411
	public unsafe Dictionary<LocalizableTextVariables, int> Score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeScoreData.NativeFieldInfoPtr_Score);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeScoreData.NativeFieldInfoPtr_Score), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeFieldInfoPtr_Score;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_LocalizableTextVariables_Int32_0;
}
