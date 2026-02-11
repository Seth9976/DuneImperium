using System;
using boardgames.ranked.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ranked.menus
{
	// Token: 0x0200001A RID: 26
	public class RankedDataUpdatedRankRenderer : Subscriber<RankedDataUpdatedRankData>
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00005524 File Offset: 0x00003724
		// Note: this type is marked as 'beforefieldinit'.
		static RankedDataUpdatedRankRenderer()
		{
			Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedDataUpdatedRankRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr);
			RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, "anim");
			RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_rankRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, "rankRenderer");
			RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_NeutralTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, "NeutralTrigger");
			RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_RankUpTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, "RankUpTrigger");
			RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_RankDownTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, "RankDownTrigger");
			RankedDataUpdatedRankRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, 100663333);
			RankedDataUpdatedRankRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, 100663334);
			RankedDataUpdatedRankRenderer.NativeMethodInfoPtr_Event_ShowNewRank_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, 100663335);
			RankedDataUpdatedRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr, 100663336);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005608 File Offset: 0x00003808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224850, XrefRangeEnd = 1224858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedDataUpdatedRankRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005644 File Offset: 0x00003844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224858, XrefRangeEnd = 1224866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedDataUpdatedRankRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005680 File Offset: 0x00003880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224866, XrefRangeEnd = 1224893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowNewRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedRankRenderer.NativeMethodInfoPtr_Event_ShowNewRank_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000056B4 File Offset: 0x000038B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224893, XrefRangeEnd = 1224896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedDataUpdatedRankRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedDataUpdatedRankRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002963 File Offset: 0x00000B63
		public RankedDataUpdatedRankRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000056F0 File Offset: 0x000038F0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000296C File Offset: 0x00000B6C
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00005720 File Offset: 0x00003920
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000298B File Offset: 0x00000B8B
		public unsafe RankedPlayRankRenderer rankRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_rankRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedPlayRankRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_rankRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005750 File Offset: 0x00003950
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000029AA File Offset: 0x00000BAA
		public unsafe static int NeutralTrigger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_NeutralTrigger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_NeutralTrigger, (void*)(&value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000576C File Offset: 0x0000396C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000029B8 File Offset: 0x00000BB8
		public unsafe static int RankUpTrigger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_RankUpTrigger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_RankUpTrigger, (void*)(&value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005788 File Offset: 0x00003988
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000029C6 File Offset: 0x00000BC6
		public unsafe static int RankDownTrigger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_RankDownTrigger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RankedDataUpdatedRankRenderer.NativeFieldInfoPtr_RankDownTrigger, (void*)(&value));
			}
		}

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_rankRenderer;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_NeutralTrigger;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_RankUpTrigger;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_RankDownTrigger;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowNewRank_Public_Void_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
