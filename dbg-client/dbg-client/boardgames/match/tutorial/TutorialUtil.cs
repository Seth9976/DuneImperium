using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using offlineChallenges;

namespace boardgames.match.tutorial
{
	// Token: 0x0200025B RID: 603
	public static class TutorialUtil : Object
	{
		// Token: 0x06001BA1 RID: 7073 RVA: 0x0007843C File Offset: 0x0007663C
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialUtil()
		{
			Il2CppClassPointerStore<TutorialUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "TutorialUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialUtil>.NativeClassPtr);
			TutorialUtil.NativeMethodInfoPtr_HasSeenOneTimeEvent_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtil>.NativeClassPtr, 100667804);
			TutorialUtil.NativeMethodInfoPtr_MarkOneTimeEventSeen_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtil>.NativeClassPtr, 100667805);
			TutorialUtil.NativeMethodInfoPtr_HasCompletedTutorial_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtil>.NativeClassPtr, 100667806);
			TutorialUtil.NativeMethodInfoPtr_MarkTutorialComplete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtil>.NativeClassPtr, 100667807);
			TutorialUtil.NativeMethodInfoPtr_IsPrerequisiteMet_Public_Static_Boolean_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtil>.NativeClassPtr, 100667808);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000784D0 File Offset: 0x000766D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 534207, RefRangeEnd = 534213, XrefRangeStart = 534195, XrefRangeEnd = 534207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSeenOneTimeEvent(string eventName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtil.NativeMethodInfoPtr_HasSeenOneTimeEvent_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x00078514 File Offset: 0x00076714
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 534230, RefRangeEnd = 534233, XrefRangeStart = 534213, XrefRangeEnd = 534230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkOneTimeEventSeen(string eventName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtil.NativeMethodInfoPtr_MarkOneTimeEventSeen_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0007854C File Offset: 0x0007674C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 534234, RefRangeEnd = 534244, XrefRangeStart = 534233, XrefRangeEnd = 534234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasCompletedTutorial(string scenarioName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtil.NativeMethodInfoPtr_HasCompletedTutorial_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00078590 File Offset: 0x00076790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534272, RefRangeEnd = 534274, XrefRangeStart = 534244, XrefRangeEnd = 534272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkTutorialComplete(string scenarioName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtil.NativeMethodInfoPtr_MarkTutorialComplete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000785C8 File Offset: 0x000767C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534300, RefRangeEnd = 534301, XrefRangeStart = 534274, XrefRangeEnd = 534300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrerequisiteMet(IHasAttributes tutorialAttributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tutorialAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtil.NativeMethodInfoPtr_IsPrerequisiteMet_Public_Static_Boolean_IHasAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		public TutorialUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_HasSeenOneTimeEvent_Public_Static_Boolean_String_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_MarkOneTimeEventSeen_Public_Static_Void_String_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_HasCompletedTutorial_Public_Static_Boolean_String_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_MarkTutorialComplete_Public_Static_Void_String_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_IsPrerequisiteMet_Public_Static_Boolean_IHasAttributes_0;

		// Token: 0x02000455 RID: 1109
		[ObfuscatedName("boardgames.match.tutorial.TutorialUtil+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060034C8 RID: 13512 RVA: 0x000C5F3C File Offset: 0x000C413C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TutorialUtil.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialUtil>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialUtil.__c__DisplayClass3_0>.NativeClassPtr);
				TutorialUtil.__c__DisplayClass3_0.NativeFieldInfoPtr_scenarioName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialUtil.__c__DisplayClass3_0>.NativeClassPtr, "scenarioName");
				TutorialUtil.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtil.__c__DisplayClass3_0>.NativeClassPtr, 100667809);
				TutorialUtil.__c__DisplayClass3_0.NativeMethodInfoPtr__MarkTutorialComplete_b__0_Internal_Boolean_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtil.__c__DisplayClass3_0>.NativeClassPtr, 100667810);
			}

			// Token: 0x060034C9 RID: 13513 RVA: 0x000C5FA4 File Offset: 0x000C41A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialUtil.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtil.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060034CA RID: 13514 RVA: 0x000C5FE0 File Offset: 0x000C41E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534193, XrefRangeEnd = 534195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MarkTutorialComplete_b__0(ChallengeDefinition c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialUtil.__c__DisplayClass3_0.NativeMethodInfoPtr__MarkTutorialComplete_b__0_Internal_Boolean_ChallengeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060034CB RID: 13515 RVA: 0x0001B47B File Offset: 0x0001967B
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F7E RID: 3966
			// (get) Token: 0x060034CC RID: 13516 RVA: 0x000C6030 File Offset: 0x000C4230
			// (set) Token: 0x060034CD RID: 13517 RVA: 0x0001B484 File Offset: 0x00019684
			public unsafe string scenarioName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialUtil.__c__DisplayClass3_0.NativeFieldInfoPtr_scenarioName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialUtil.__c__DisplayClass3_0.NativeFieldInfoPtr_scenarioName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002089 RID: 8329
			private static readonly IntPtr NativeFieldInfoPtr_scenarioName;

			// Token: 0x0400208A RID: 8330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400208B RID: 8331
			private static readonly IntPtr NativeMethodInfoPtr__MarkTutorialComplete_b__0_Internal_Boolean_ChallengeDefinition_0;
		}
	}
}
