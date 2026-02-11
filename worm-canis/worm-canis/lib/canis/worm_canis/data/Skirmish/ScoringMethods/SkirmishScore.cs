using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis;
using worm.canis.entities;

namespace lib.canis.worm_canis.data.Skirmish.ScoringMethods
{
	// Token: 0x02000007 RID: 7
	public class SkirmishScore : Object
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000690F4 File Offset: 0x000672F4
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishScore()
		{
			Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "lib.canis.worm_canis.data.Skirmish.ScoringMethods", "SkirmishScore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr);
			SkirmishScore.NativeMethodInfoPtr_GetSkirmishScore_Public_Static_List_1_SkirmishScoreItem_WormMatch_WormPlayer_Il2CppReferenceArray_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr, 100663303);
			SkirmishScore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0006914C File Offset: 0x0006734C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 3043, RefRangeEnd = 3044, XrefRangeStart = 3017, XrefRangeEnd = 3043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SkirmishScoreItem> GetSkirmishScore(WormMatch wormMatch, WormPlayer wormPlayer, [Optional] Il2CppReferenceArray<SkirmishScoringMethod> methods)
		{
			if (methods == null)
			{
				methods = new Il2CppReferenceArray<SkirmishScoringMethod>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methods);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScore.NativeMethodInfoPtr_GetSkirmishScore_Public_Static_List_1_SkirmishScoreItem_WormMatch_WormPlayer_Il2CppReferenceArray_1_SkirmishScoringMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkirmishScoreItem>>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000691C4 File Offset: 0x000673C4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishScore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishScore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
		public static List<SkirmishScoreItem> GetSkirmishScore(WormMatch wormMatch, WormPlayer wormPlayer, params SkirmishScoringMethod[] methods)
		{
			return SkirmishScore.GetSkirmishScore(wormMatch, wormPlayer, new Il2CppReferenceArray<SkirmishScoringMethod>(methods));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020F6 File Offset: 0x000002F6
		public SkirmishScore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_GetSkirmishScore_Public_Static_List_1_SkirmishScoreItem_WormMatch_WormPlayer_Il2CppReferenceArray_1_SkirmishScoringMethod_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
