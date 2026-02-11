using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000B6 RID: 182
	public class DailyChallengeScoreRenderer : Subscriber<DailyChallengeScoreData>
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00034E60 File Offset: 0x00033060
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeScoreRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeScoreRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "DailyChallengeScoreRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeScoreRenderer>.NativeClassPtr);
			DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeScoreRenderer>.NativeClassPtr, "scoreText");
			DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreTotalsFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeScoreRenderer>.NativeClassPtr, "scoreTotalsFields");
			DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreDetailsFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeScoreRenderer>.NativeClassPtr, "scoreDetailsFields");
			DailyChallengeScoreRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeScoreRenderer>.NativeClassPtr, 100664423);
			DailyChallengeScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeScoreRenderer>.NativeClassPtr, 100664424);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00034EF4 File Offset: 0x000330F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504212, XrefRangeEnd = 504264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeScoreRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00034F30 File Offset: 0x00033130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504264, XrefRangeEnd = 504267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeScoreRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeScoreRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00005757 File Offset: 0x00003957
		public DailyChallengeScoreRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00034F6C File Offset: 0x0003316C
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x00005760 File Offset: 0x00003960
		public unsafe TMP_Text scoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00034F9C File Offset: 0x0003319C
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x0000577F File Offset: 0x0000397F
		public unsafe List<TMP_Text> scoreTotalsFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreTotalsFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreTotalsFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00034FCC File Offset: 0x000331CC
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x0000579E File Offset: 0x0000399E
		public unsafe List<TMP_Text> scoreDetailsFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreDetailsFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeScoreRenderer.NativeFieldInfoPtr_scoreDetailsFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_scoreText;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_scoreTotalsFields;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_scoreDetailsFields;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
