using System;
using boardgames.ranked.data;
using boardgames.ranked.networking.responses;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ranked.menus
{
	// Token: 0x0200001B RID: 27
	public class RankedDataUpdatedStarsRenderer : Subscriber<RankedDataUpdatedStarsData>
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x000057A4 File Offset: 0x000039A4
		// Note: this type is marked as 'beforefieldinit'.
		static RankedDataUpdatedStarsRenderer()
		{
			Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedDataUpdatedStarsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr);
			RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_starPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, "starPrefab");
			RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_FilledParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, "FilledParam");
			RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_GainedParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, "GainedParam");
			RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_LostParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, "LostParam");
			RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, 100663338);
			RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_Event_ShowNewRank_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, 100663339);
			RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_SpawnStars_Private_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, 100663340);
			RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_GetRankData_Private_RankedDataUpdatedRankData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, 100663341);
			RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_StarsToAdvance_Private_Static_Int32_RankName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, 100663342);
			RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr, 100663343);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000589C File Offset: 0x00003A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224896, XrefRangeEnd = 1224915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000058D8 File Offset: 0x00003AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224915, XrefRangeEnd = 1224929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowNewRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_Event_ShowNewRank_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000590C File Offset: 0x00003B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1224946, RefRangeEnd = 1224948, XrefRangeStart = 1224929, XrefRangeEnd = 1224946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnStars(int count, int unchanged, int changed, int changedAnimParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unchanged;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changedAnimParam;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_SpawnStars_Private_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005974 File Offset: 0x00003B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224948, XrefRangeEnd = 1224953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedDataUpdatedRankData GetRankData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_GetRankData_Private_RankedDataUpdatedRankData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RankedDataUpdatedRankData>(intPtr3) : null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000059B4 File Offset: 0x00003BB4
		[CallerCount(0)]
		public unsafe static int StarsToAdvance(RankName rank)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr_StarsToAdvance_Private_Static_Int32_RankName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000059F4 File Offset: 0x00003BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224953, XrefRangeEnd = 1224956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedDataUpdatedStarsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedDataUpdatedStarsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedStarsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000029D4 File Offset: 0x00000BD4
		public RankedDataUpdatedStarsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005A30 File Offset: 0x00003C30
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000029DD File Offset: 0x00000BDD
		public unsafe Animator starPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_starPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_starPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005A60 File Offset: 0x00003C60
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000029FC File Offset: 0x00000BFC
		public unsafe static int FilledParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_FilledParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_FilledParam, (void*)(&value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005A7C File Offset: 0x00003C7C
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002A0A File Offset: 0x00000C0A
		public unsafe static int GainedParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_GainedParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_GainedParam, (void*)(&value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005A98 File Offset: 0x00003C98
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002A18 File Offset: 0x00000C18
		public unsafe static int LostParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_LostParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RankedDataUpdatedStarsRenderer.NativeFieldInfoPtr_LostParam, (void*)(&value));
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_starPrefab;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_FilledParam;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_GainedParam;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_LostParam;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowNewRank_Public_Void_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_SpawnStars_Private_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_GetRankData_Private_RankedDataUpdatedRankData_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_StarsToAdvance_Private_Static_Int32_RankName_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
