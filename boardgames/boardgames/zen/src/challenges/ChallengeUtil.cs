using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using offlineChallenges;

namespace zen.src.challenges
{
	// Token: 0x02000082 RID: 130
	public static class ChallengeUtil : Object
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x000256D4 File Offset: 0x000238D4
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeUtil()
		{
			Il2CppClassPointerStore<ChallengeUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges", "ChallengeUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeUtil>.NativeClassPtr);
			ChallengeUtil.NativeMethodInfoPtr_HasCompletedChallenge_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeUtil>.NativeClassPtr, 100664379);
			ChallengeUtil.NativeMethodInfoPtr_MarkChallengeComplete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeUtil>.NativeClassPtr, 100664380);
			ChallengeUtil.NativeMethodInfoPtr_MarkAllChallengesComplete_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeUtil>.NativeClassPtr, 100664381);
			ChallengeUtil.NativeMethodInfoPtr_GetChallengeHighScore_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeUtil>.NativeClassPtr, 100664382);
			ChallengeUtil.NativeMethodInfoPtr_SetChallengeHighScore_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeUtil>.NativeClassPtr, 100664383);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00025768 File Offset: 0x00023968
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 989094, RefRangeEnd = 989112, XrefRangeStart = 989090, XrefRangeEnd = 989094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasCompletedChallenge(string scenarioName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeUtil.NativeMethodInfoPtr_HasCompletedChallenge_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000257AC File Offset: 0x000239AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 989140, RefRangeEnd = 989141, XrefRangeStart = 989112, XrefRangeEnd = 989140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkChallengeComplete(string scenarioName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeUtil.NativeMethodInfoPtr_MarkChallengeComplete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000257E4 File Offset: 0x000239E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989141, XrefRangeEnd = 989175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkAllChallengesComplete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeUtil.NativeMethodInfoPtr_MarkAllChallengesComplete_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0002580C File Offset: 0x00023A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 989180, RefRangeEnd = 989181, XrefRangeStart = 989175, XrefRangeEnd = 989180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetChallengeHighScore(string scenarioName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeUtil.NativeMethodInfoPtr_GetChallengeHighScore_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00025850 File Offset: 0x00023A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989181, XrefRangeEnd = 989186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetChallengeHighScore(string scenarioName, int score)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeUtil.NativeMethodInfoPtr_SetChallengeHighScore_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00004F4D File Offset: 0x0000314D
		public ChallengeUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_HasCompletedChallenge_Public_Static_Boolean_String_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_MarkChallengeComplete_Public_Static_Void_String_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_MarkAllChallengesComplete_Public_Static_Void_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_GetChallengeHighScore_Public_Static_Int32_String_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_SetChallengeHighScore_Public_Static_Void_String_Int32_0;

		// Token: 0x0200020E RID: 526
		[ObfuscatedName("zen.src.challenges.ChallengeUtil+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001827 RID: 6183 RVA: 0x0005C094 File Offset: 0x0005A294
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ChallengeUtil.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeUtil>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeUtil.__c__DisplayClass1_0>.NativeClassPtr);
				ChallengeUtil.__c__DisplayClass1_0.NativeFieldInfoPtr_scenarioName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeUtil.__c__DisplayClass1_0>.NativeClassPtr, "scenarioName");
				ChallengeUtil.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeUtil.__c__DisplayClass1_0>.NativeClassPtr, 100664384);
				ChallengeUtil.__c__DisplayClass1_0.NativeMethodInfoPtr__MarkChallengeComplete_b__0_Internal_Boolean_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeUtil.__c__DisplayClass1_0>.NativeClassPtr, 100664385);
			}

			// Token: 0x06001828 RID: 6184 RVA: 0x0005C0FC File Offset: 0x0005A2FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeUtil.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeUtil.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001829 RID: 6185 RVA: 0x0005C138 File Offset: 0x0005A338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MarkChallengeComplete_b__0(ChallengeDefinition c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeUtil.__c__DisplayClass1_0.NativeMethodInfoPtr__MarkChallengeComplete_b__0_Internal_Boolean_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600182A RID: 6186 RVA: 0x0000D38A File Offset: 0x0000B58A
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x0600182B RID: 6187 RVA: 0x0005C188 File Offset: 0x0005A388
			// (set) Token: 0x0600182C RID: 6188 RVA: 0x0000D393 File Offset: 0x0000B593
			public unsafe string scenarioName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeUtil.__c__DisplayClass1_0.NativeFieldInfoPtr_scenarioName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeUtil.__c__DisplayClass1_0.NativeFieldInfoPtr_scenarioName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000EA5 RID: 3749
			private static readonly IntPtr NativeFieldInfoPtr_scenarioName;

			// Token: 0x04000EA6 RID: 3750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000EA7 RID: 3751
			private static readonly IntPtr NativeMethodInfoPtr__MarkChallengeComplete_b__0_Internal_Boolean_ChallengeDefinition_0;
		}
	}
}
