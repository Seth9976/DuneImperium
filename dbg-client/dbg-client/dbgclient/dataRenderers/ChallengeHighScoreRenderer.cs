using System;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000B4 RID: 180
	public class ChallengeHighScoreRenderer : Subscriber<ChallengeHighScoreData>
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x00034760 File Offset: 0x00032960
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeHighScoreRenderer()
		{
			Il2CppClassPointerStore<ChallengeHighScoreRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "ChallengeHighScoreRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeHighScoreRenderer>.NativeClassPtr);
			ChallengeHighScoreRenderer.NativeFieldInfoPtr_scoreBacker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeHighScoreRenderer>.NativeClassPtr, "scoreBacker");
			ChallengeHighScoreRenderer.NativeFieldInfoPtr_scoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeHighScoreRenderer>.NativeClassPtr, "scoreText");
			ChallengeHighScoreRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeHighScoreRenderer>.NativeClassPtr, 100664411);
			ChallengeHighScoreRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeHighScoreRenderer>.NativeClassPtr, 100664412);
			ChallengeHighScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeHighScoreRenderer>.NativeClassPtr, 100664413);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000347F4 File Offset: 0x000329F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504160, XrefRangeEnd = 504162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeHighScoreRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00034830 File Offset: 0x00032A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504162, XrefRangeEnd = 504165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeHighScoreRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0003486C File Offset: 0x00032A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504165, XrefRangeEnd = 504168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeHighScoreRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeHighScoreRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeHighScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0000553C File Offset: 0x0000373C
		public ChallengeHighScoreRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000348A8 File Offset: 0x00032AA8
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00005545 File Offset: 0x00003745
		public unsafe GameObject scoreBacker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeHighScoreRenderer.NativeFieldInfoPtr_scoreBacker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeHighScoreRenderer.NativeFieldInfoPtr_scoreBacker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000348D8 File Offset: 0x00032AD8
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00005564 File Offset: 0x00003764
		public unsafe TMP_Text scoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeHighScoreRenderer.NativeFieldInfoPtr_scoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeHighScoreRenderer.NativeFieldInfoPtr_scoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_scoreBacker;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_scoreText;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
