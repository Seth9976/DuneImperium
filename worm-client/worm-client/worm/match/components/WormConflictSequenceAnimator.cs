using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001DC RID: 476
	public class WormConflictSequenceAnimator : MonoBehaviour
	{
		// Token: 0x06001510 RID: 5392 RVA: 0x00058028 File Offset: 0x00056228
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictSequenceAnimator()
		{
			Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormConflictSequenceAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr);
			WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictIntroAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, "ConflictIntroAnimation");
			WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictOutroAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, "ConflictOutroAnimation");
			WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictResolutionAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, "ConflictResolutionAnimation");
			WormConflictSequenceAnimator.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, 100666171);
			WormConflictSequenceAnimator.NativeMethodInfoPtr_Event_EndConflictIntro_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, 100666172);
			WormConflictSequenceAnimator.NativeMethodInfoPtr_Event_EndConflictOutro_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, 100666173);
			WormConflictSequenceAnimator.NativeMethodInfoPtr_Event_EndConflictResolution_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, 100666174);
			WormConflictSequenceAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, 100666175);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000580F8 File Offset: 0x000562F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714746, XrefRangeEnd = 714751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00058138 File Offset: 0x00056338
		[CallerCount(0)]
		public unsafe void Event_EndConflictIntro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.NativeMethodInfoPtr_Event_EndConflictIntro_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0005816C File Offset: 0x0005636C
		[CallerCount(0)]
		public unsafe void Event_EndConflictOutro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.NativeMethodInfoPtr_Event_EndConflictOutro_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000581A0 File Offset: 0x000563A0
		[CallerCount(0)]
		public unsafe void Event_EndConflictResolution()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.NativeMethodInfoPtr_Event_EndConflictResolution_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000581D4 File Offset: 0x000563D4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictSequenceAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0000CD95 File Offset: 0x0000AF95
		public WormConflictSequenceAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00058210 File Offset: 0x00056410
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0000CD9E File Offset: 0x0000AF9E
		public unsafe WormConflictSequenceAnimator.YieldableAnimation ConflictIntroAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictIntroAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceAnimator.YieldableAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictIntroAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00058240 File Offset: 0x00056440
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000CDBD File Offset: 0x0000AFBD
		public unsafe WormConflictSequenceAnimator.YieldableAnimation ConflictOutroAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictOutroAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceAnimator.YieldableAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictOutroAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00058270 File Offset: 0x00056470
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0000CDDC File Offset: 0x0000AFDC
		public unsafe WormConflictSequenceAnimator.YieldableAnimation ConflictResolutionAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictResolutionAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceAnimator.YieldableAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.NativeFieldInfoPtr_ConflictResolutionAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeFieldInfoPtr_ConflictIntroAnimation;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeFieldInfoPtr_ConflictOutroAnimation;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeFieldInfoPtr_ConflictResolutionAnimation;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_Event_EndConflictIntro_Public_Void_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_Event_EndConflictOutro_Public_Void_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_Event_EndConflictResolution_Public_Void_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003DB RID: 987
		[Serializable]
		public class YieldableAnimation : global::Il2CppSystem.Object
		{
			// Token: 0x060027FD RID: 10237 RVA: 0x000915A8 File Offset: 0x0008F7A8
			// Note: this type is marked as 'beforefieldinit'.
			static YieldableAnimation()
			{
				Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, "YieldableAnimation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr);
				WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_animationTimeoutTimespan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, "animationTimeoutTimespan");
				WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_animators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, "animators");
				WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_AnimationParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, "AnimationParam");
				WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_YieldOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, "YieldOn");
				WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_finished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, "finished");
				WormConflictSequenceAnimator.YieldableAnimation.NativeMethodInfoPtr_Finish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, 100666176);
				WormConflictSequenceAnimator.YieldableAnimation.NativeMethodInfoPtr_TriggerAnimation_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, 100666177);
				WormConflictSequenceAnimator.YieldableAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, 100666178);
			}

			// Token: 0x060027FE RID: 10238 RVA: 0x00091674 File Offset: 0x0008F874
			[CallerCount(0)]
			public unsafe void Finish()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation.NativeMethodInfoPtr_Finish_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027FF RID: 10239 RVA: 0x000916A8 File Offset: 0x0008F8A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714724, XrefRangeEnd = 714729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator TriggerAnimation()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation.NativeMethodInfoPtr_TriggerAnimation_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002800 RID: 10240 RVA: 0x000916E8 File Offset: 0x0008F8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714729, XrefRangeEnd = 714737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YieldableAnimation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002801 RID: 10241 RVA: 0x00015F7A File Offset: 0x0001417A
			public YieldableAnimation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06002802 RID: 10242 RVA: 0x00091724 File Offset: 0x0008F924
			// (set) Token: 0x06002803 RID: 10243 RVA: 0x00015F83 File Offset: 0x00014183
			public unsafe static TimeSpan animationTimeoutTimespan
			{
				get
				{
					TimeSpan timeSpan;
					IL2CPP.il2cpp_field_static_get_value(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_animationTimeoutTimespan, (void*)(&timeSpan));
					return timeSpan;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_animationTimeoutTimespan, (void*)(&value));
				}
			}

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06002804 RID: 10244 RVA: 0x00091740 File Offset: 0x0008F940
			// (set) Token: 0x06002805 RID: 10245 RVA: 0x00015F91 File Offset: 0x00014191
			public unsafe Il2CppReferenceArray<Animator> animators
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_animators);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_animators), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06002806 RID: 10246 RVA: 0x00091770 File Offset: 0x0008F970
			// (set) Token: 0x06002807 RID: 10247 RVA: 0x00015FB0 File Offset: 0x000141B0
			public unsafe string AnimationParam
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_AnimationParam);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_AnimationParam), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B30 RID: 2864
			// (get) Token: 0x06002808 RID: 10248 RVA: 0x00091798 File Offset: 0x0008F998
			// (set) Token: 0x06002809 RID: 10249 RVA: 0x00015FCF File Offset: 0x000141CF
			public unsafe bool YieldOn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_YieldOn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_YieldOn)) = value;
				}
			}

			// Token: 0x17000B31 RID: 2865
			// (get) Token: 0x0600280A RID: 10250 RVA: 0x000917C0 File Offset: 0x0008F9C0
			// (set) Token: 0x0600280B RID: 10251 RVA: 0x00015FEA File Offset: 0x000141EA
			public unsafe bool finished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_finished);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation.NativeFieldInfoPtr_finished)) = value;
				}
			}

			// Token: 0x04001707 RID: 5895
			private static readonly IntPtr NativeFieldInfoPtr_animationTimeoutTimespan;

			// Token: 0x04001708 RID: 5896
			private static readonly IntPtr NativeFieldInfoPtr_animators;

			// Token: 0x04001709 RID: 5897
			private static readonly IntPtr NativeFieldInfoPtr_AnimationParam;

			// Token: 0x0400170A RID: 5898
			private static readonly IntPtr NativeFieldInfoPtr_YieldOn;

			// Token: 0x0400170B RID: 5899
			private static readonly IntPtr NativeFieldInfoPtr_finished;

			// Token: 0x0400170C RID: 5900
			private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_Void_0;

			// Token: 0x0400170D RID: 5901
			private static readonly IntPtr NativeMethodInfoPtr_TriggerAnimation_Public_IEnumerator_0;

			// Token: 0x0400170E RID: 5902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200044B RID: 1099
			[ObfuscatedName("worm.match.components.WormConflictSequenceAnimator+YieldableAnimation+<TriggerAnimation>d__6")]
			public sealed class _TriggerAnimation_d__6 : global::Il2CppSystem.Object
			{
				// Token: 0x06002D82 RID: 11650 RVA: 0x000A1DE0 File Offset: 0x0009FFE0
				// Note: this type is marked as 'beforefieldinit'.
				static _TriggerAnimation_d__6()
				{
					Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation>.NativeClassPtr, "<TriggerAnimation>d__6");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr);
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, "<>1__state");
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, "<>2__current");
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, "<>4__this");
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr__startTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, "<startTime>5__2");
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, 100666180);
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, 100666181);
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, 100666182);
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, 100666183);
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, 100666184);
					WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr, 100666185);
				}

				// Token: 0x06002D83 RID: 11651 RVA: 0x000A1ED4 File Offset: 0x000A00D4
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _TriggerAnimation_d__6(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002D84 RID: 11652 RVA: 0x000A1F1C File Offset: 0x000A011C
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002D85 RID: 11653 RVA: 0x000A1F50 File Offset: 0x000A0150
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714689, XrefRangeEnd = 714719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000D11 RID: 3345
				// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000A1F8C File Offset: 0x000A018C
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06002D87 RID: 11655 RVA: 0x000A1FCC File Offset: 0x000A01CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714719, XrefRangeEnd = 714724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000D12 RID: 3346
				// (get) Token: 0x06002D88 RID: 11656 RVA: 0x000A2000 File Offset: 0x000A0200
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06002D89 RID: 11657 RVA: 0x00018AA6 File Offset: 0x00016CA6
				public _TriggerAnimation_d__6(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D0D RID: 3341
				// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000A2040 File Offset: 0x000A0240
				// (set) Token: 0x06002D8B RID: 11659 RVA: 0x00018AAF File Offset: 0x00016CAF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000D0E RID: 3342
				// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000A2068 File Offset: 0x000A0268
				// (set) Token: 0x06002D8D RID: 11661 RVA: 0x00018ACA File Offset: 0x00016CCA
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D0F RID: 3343
				// (get) Token: 0x06002D8E RID: 11662 RVA: 0x000A2098 File Offset: 0x000A0298
				// (set) Token: 0x06002D8F RID: 11663 RVA: 0x00018AE9 File Offset: 0x00016CE9
				public unsafe WormConflictSequenceAnimator.YieldableAnimation __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceAnimator.YieldableAnimation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D10 RID: 3344
				// (get) Token: 0x06002D90 RID: 11664 RVA: 0x000A20C8 File Offset: 0x000A02C8
				// (set) Token: 0x06002D91 RID: 11665 RVA: 0x00018B08 File Offset: 0x00016D08
				public unsafe DateTime _startTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr__startTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator.YieldableAnimation._TriggerAnimation_d__6.NativeFieldInfoPtr__startTime_5__2)) = value;
					}
				}

				// Token: 0x04001A6F RID: 6767
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001A70 RID: 6768
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001A71 RID: 6769
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04001A72 RID: 6770
				private static readonly IntPtr NativeFieldInfoPtr__startTime_5__2;

				// Token: 0x04001A73 RID: 6771
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001A74 RID: 6772
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001A75 RID: 6773
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001A76 RID: 6774
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001A77 RID: 6775
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001A78 RID: 6776
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020003DC RID: 988
		[ObfuscatedName("worm.match.components.WormConflictSequenceAnimator+<Start>d__4")]
		public sealed class _Start_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x0600280C RID: 10252 RVA: 0x000917E8 File Offset: 0x0008F9E8
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__4()
			{
				Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictSequenceAnimator>.NativeClassPtr, "<Start>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr);
				WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, "<>1__state");
				WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, "<>2__current");
				WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, "<>4__this");
				WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, 100666186);
				WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, 100666187);
				WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, 100666188);
				WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, 100666189);
				WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, 100666190);
				WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr, 100666191);
			}

			// Token: 0x0600280D RID: 10253 RVA: 0x000918C8 File Offset: 0x0008FAC8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictSequenceAnimator._Start_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600280E RID: 10254 RVA: 0x00091910 File Offset: 0x0008FB10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600280F RID: 10255 RVA: 0x00091944 File Offset: 0x0008FB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714737, XrefRangeEnd = 714741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x06002810 RID: 10256 RVA: 0x00091980 File Offset: 0x0008FB80
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002811 RID: 10257 RVA: 0x000919C0 File Offset: 0x0008FBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714741, XrefRangeEnd = 714746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x06002812 RID: 10258 RVA: 0x000919F4 File Offset: 0x0008FBF4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceAnimator._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002813 RID: 10259 RVA: 0x00016005 File Offset: 0x00014205
			public _Start_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x06002814 RID: 10260 RVA: 0x00091A34 File Offset: 0x0008FC34
			// (set) Token: 0x06002815 RID: 10261 RVA: 0x0001600E File Offset: 0x0001420E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x06002816 RID: 10262 RVA: 0x00091A5C File Offset: 0x0008FC5C
			// (set) Token: 0x06002817 RID: 10263 RVA: 0x00016029 File Offset: 0x00014229
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B34 RID: 2868
			// (get) Token: 0x06002818 RID: 10264 RVA: 0x00091A8C File Offset: 0x0008FC8C
			// (set) Token: 0x06002819 RID: 10265 RVA: 0x00016048 File Offset: 0x00014248
			public unsafe WormConflictSequenceAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceAnimator._Start_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400170F RID: 5903
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001710 RID: 5904
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001711 RID: 5905
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001712 RID: 5906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001713 RID: 5907
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001714 RID: 5908
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001715 RID: 5909
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001716 RID: 5910
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001717 RID: 5911
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
