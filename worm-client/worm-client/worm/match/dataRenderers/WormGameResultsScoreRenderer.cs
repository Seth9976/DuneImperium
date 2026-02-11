using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200012E RID: 302
	public class WormGameResultsScoreRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000DAC RID: 3500 RVA: 0x00041660 File Offset: 0x0003F860
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsScoreRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsScoreRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsScoreRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsScoreRenderer>.NativeClassPtr);
			WormGameResultsScoreRenderer.NativeFieldInfoPtr_scoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsScoreRenderer>.NativeClassPtr, "scoreText");
			WormGameResultsScoreRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsScoreRenderer>.NativeClassPtr, 100665151);
			WormGameResultsScoreRenderer.NativeMethodInfoPtr_Event_ShowSources_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsScoreRenderer>.NativeClassPtr, 100665152);
			WormGameResultsScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsScoreRenderer>.NativeClassPtr, 100665153);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000416E0 File Offset: 0x0003F8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705859, XrefRangeEnd = 705861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsScoreRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0004171C File Offset: 0x0003F91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705861, XrefRangeEnd = 705893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowSources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsScoreRenderer.NativeMethodInfoPtr_Event_ShowSources_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00041750 File Offset: 0x0003F950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705893, XrefRangeEnd = 705896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsScoreRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsScoreRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0000938B File Offset: 0x0000758B
		public WormGameResultsScoreRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0004178C File Offset: 0x0003F98C
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00009394 File Offset: 0x00007594
		public unsafe TMP_Text scoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsScoreRenderer.NativeFieldInfoPtr_scoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsScoreRenderer.NativeFieldInfoPtr_scoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr_scoreText;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowSources_Public_Void_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
