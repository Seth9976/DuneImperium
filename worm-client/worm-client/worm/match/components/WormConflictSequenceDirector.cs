using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001DD RID: 477
	public class WormConflictSequenceDirector : MonoBehaviour
	{
		// Token: 0x0600151D RID: 5405 RVA: 0x000582A0 File Offset: 0x000564A0
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictSequenceDirector()
		{
			Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormConflictSequenceDirector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr);
			WormConflictSequenceDirector.NativeFieldInfoPtr_conflictSequenceAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, "conflictSequenceAnimators");
			WormConflictSequenceDirector.NativeMethodInfoPtr_RegisterConflictSequenceAnimator_Public_Void_WormConflictSequenceAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, 100666192);
			WormConflictSequenceDirector.NativeMethodInfoPtr_get_Animators_Private_get_IEnumerable_1_WormConflictSequenceAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, 100666193);
			WormConflictSequenceDirector.NativeMethodInfoPtr_TriggerConflictIntro_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, 100666194);
			WormConflictSequenceDirector.NativeMethodInfoPtr_TriggerConflictOutro_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, 100666195);
			WormConflictSequenceDirector.NativeMethodInfoPtr_TriggerConflictResolution_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, 100666196);
			WormConflictSequenceDirector.NativeMethodInfoPtr_triggerAnimation_Private_IEnumerator_IEnumerable_1_YieldableAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, 100666197);
			WormConflictSequenceDirector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, 100666198);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00058370 File Offset: 0x00056570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714816, XrefRangeEnd = 714822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterConflictSequenceAnimator(WormConflictSequenceAnimator animator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.NativeMethodInfoPtr_RegisterConflictSequenceAnimator_Public_Void_WormConflictSequenceAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x000583B4 File Offset: 0x000565B4
		public unsafe IEnumerable<WormConflictSequenceAnimator> Animators
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 714840, RefRangeEnd = 714843, XrefRangeStart = 714822, XrefRangeEnd = 714840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.NativeMethodInfoPtr_get_Animators_Private_get_IEnumerable_1_WormConflictSequenceAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormConflictSequenceAnimator>>(intPtr3) : null;
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000583F4 File Offset: 0x000565F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714843, XrefRangeEnd = 714864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TriggerConflictIntro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.NativeMethodInfoPtr_TriggerConflictIntro_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00058434 File Offset: 0x00056634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 714885, RefRangeEnd = 714886, XrefRangeStart = 714864, XrefRangeEnd = 714885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TriggerConflictOutro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.NativeMethodInfoPtr_TriggerConflictOutro_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00058474 File Offset: 0x00056674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714886, XrefRangeEnd = 714907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TriggerConflictResolution()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.NativeMethodInfoPtr_TriggerConflictResolution_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000584B4 File Offset: 0x000566B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 714913, RefRangeEnd = 714916, XrefRangeStart = 714907, XrefRangeEnd = 714913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator triggerAnimation(IEnumerable<WormConflictSequenceAnimator.YieldableAnimation> animations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.NativeMethodInfoPtr_triggerAnimation_Private_IEnumerator_IEnumerable_1_YieldableAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00058504 File Offset: 0x00056704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714916, XrefRangeEnd = 714924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictSequenceDirector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0000CDFB File Offset: 0x0000AFFB
		public WormConflictSequenceDirector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x00058540 File Offset: 0x00056740
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x0000CE04 File Offset: 0x0000B004
		public unsafe List<WormConflictSequenceAnimator> conflictSequenceAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector.NativeFieldInfoPtr_conflictSequenceAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormConflictSequenceAnimator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector.NativeFieldInfoPtr_conflictSequenceAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeFieldInfoPtr_conflictSequenceAnimators;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConflictSequenceAnimator_Public_Void_WormConflictSequenceAnimator_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_get_Animators_Private_get_IEnumerable_1_WormConflictSequenceAnimator_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_TriggerConflictIntro_Public_IEnumerator_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_TriggerConflictOutro_Public_IEnumerator_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_TriggerConflictResolution_Public_IEnumerator_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_triggerAnimation_Private_IEnumerator_IEnumerable_1_YieldableAnimation_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003DD RID: 989
		[ObfuscatedName("worm.match.components.WormConflictSequenceDirector+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600281A RID: 10266 RVA: 0x00091ABC File Offset: 0x0008FCBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr);
				WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, "<>9");
				WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, "<>9__3_0");
				WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, "<>9__4_0");
				WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, "<>9__5_0");
				WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, "<>9__6_0");
				WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, "<>9__7_0");
				WormConflictSequenceDirector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, 100666200);
				WormConflictSequenceDirector.__c.NativeMethodInfoPtr__get_Animators_b__3_0_Internal_Boolean_WormConflictSequenceAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, 100666201);
				WormConflictSequenceDirector.__c.NativeMethodInfoPtr__TriggerConflictIntro_b__4_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, 100666202);
				WormConflictSequenceDirector.__c.NativeMethodInfoPtr__TriggerConflictOutro_b__5_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, 100666203);
				WormConflictSequenceDirector.__c.NativeMethodInfoPtr__TriggerConflictResolution_b__6_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, 100666204);
				WormConflictSequenceDirector.__c.NativeMethodInfoPtr__triggerAnimation_b__7_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr, 100666205);
			}

			// Token: 0x0600281B RID: 10267 RVA: 0x00091BD8 File Offset: 0x0008FDD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictSequenceDirector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600281C RID: 10268 RVA: 0x00091C14 File Offset: 0x0008FE14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714751, XrefRangeEnd = 714755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_Animators_b__3_0(WormConflictSequenceAnimator a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.__c.NativeMethodInfoPtr__get_Animators_b__3_0_Internal_Boolean_WormConflictSequenceAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600281D RID: 10269 RVA: 0x00091C64 File Offset: 0x0008FE64
			[CallerCount(0)]
			public unsafe WormConflictSequenceAnimator.YieldableAnimation _TriggerConflictIntro_b__4_0(WormConflictSequenceAnimator csa)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(csa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.__c.NativeMethodInfoPtr__TriggerConflictIntro_b__4_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceAnimator.YieldableAnimation>(intPtr3) : null;
				}
			}

			// Token: 0x0600281E RID: 10270 RVA: 0x00091CB4 File Offset: 0x0008FEB4
			[CallerCount(0)]
			public unsafe WormConflictSequenceAnimator.YieldableAnimation _TriggerConflictOutro_b__5_0(WormConflictSequenceAnimator csa)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(csa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.__c.NativeMethodInfoPtr__TriggerConflictOutro_b__5_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceAnimator.YieldableAnimation>(intPtr3) : null;
				}
			}

			// Token: 0x0600281F RID: 10271 RVA: 0x00091D04 File Offset: 0x0008FF04
			[CallerCount(0)]
			public unsafe WormConflictSequenceAnimator.YieldableAnimation _TriggerConflictResolution_b__6_0(WormConflictSequenceAnimator csa)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(csa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.__c.NativeMethodInfoPtr__TriggerConflictResolution_b__6_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceAnimator.YieldableAnimation>(intPtr3) : null;
				}
			}

			// Token: 0x06002820 RID: 10272 RVA: 0x00091D54 File Offset: 0x0008FF54
			[CallerCount(0)]
			public unsafe bool _triggerAnimation_b__7_0(Command trigger)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector.__c.NativeMethodInfoPtr__triggerAnimation_b__7_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002821 RID: 10273 RVA: 0x00016067 File Offset: 0x00014267
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x06002822 RID: 10274 RVA: 0x00091DA4 File Offset: 0x0008FFA4
			// (set) Token: 0x06002823 RID: 10275 RVA: 0x00016070 File Offset: 0x00014270
			public unsafe static WormConflictSequenceDirector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceDirector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x06002824 RID: 10276 RVA: 0x00091DCC File Offset: 0x0008FFCC
			// (set) Token: 0x06002825 RID: 10277 RVA: 0x00016082 File Offset: 0x00014282
			public unsafe static Predicate<WormConflictSequenceAnimator> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<WormConflictSequenceAnimator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x06002826 RID: 10278 RVA: 0x00091DF4 File Offset: 0x0008FFF4
			// (set) Token: 0x06002827 RID: 10279 RVA: 0x00016094 File Offset: 0x00014294
			public unsafe static Func<WormConflictSequenceAnimator, WormConflictSequenceAnimator.YieldableAnimation> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormConflictSequenceAnimator, WormConflictSequenceAnimator.YieldableAnimation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x06002828 RID: 10280 RVA: 0x00091E1C File Offset: 0x0009001C
			// (set) Token: 0x06002829 RID: 10281 RVA: 0x000160A6 File Offset: 0x000142A6
			public unsafe static Func<WormConflictSequenceAnimator, WormConflictSequenceAnimator.YieldableAnimation> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormConflictSequenceAnimator, WormConflictSequenceAnimator.YieldableAnimation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x0600282A RID: 10282 RVA: 0x00091E44 File Offset: 0x00090044
			// (set) Token: 0x0600282B RID: 10283 RVA: 0x000160B8 File Offset: 0x000142B8
			public unsafe static Func<WormConflictSequenceAnimator, WormConflictSequenceAnimator.YieldableAnimation> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormConflictSequenceAnimator, WormConflictSequenceAnimator.YieldableAnimation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x0600282C RID: 10284 RVA: 0x00091E6C File Offset: 0x0009006C
			// (set) Token: 0x0600282D RID: 10285 RVA: 0x000160CA File Offset: 0x000142CA
			public unsafe static Func<Command, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictSequenceDirector.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001718 RID: 5912
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001719 RID: 5913
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400171A RID: 5914
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400171B RID: 5915
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400171C RID: 5916
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400171D RID: 5917
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400171E RID: 5918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400171F RID: 5919
			private static readonly IntPtr NativeMethodInfoPtr__get_Animators_b__3_0_Internal_Boolean_WormConflictSequenceAnimator_0;

			// Token: 0x04001720 RID: 5920
			private static readonly IntPtr NativeMethodInfoPtr__TriggerConflictIntro_b__4_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0;

			// Token: 0x04001721 RID: 5921
			private static readonly IntPtr NativeMethodInfoPtr__TriggerConflictOutro_b__5_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0;

			// Token: 0x04001722 RID: 5922
			private static readonly IntPtr NativeMethodInfoPtr__TriggerConflictResolution_b__6_0_Internal_YieldableAnimation_WormConflictSequenceAnimator_0;

			// Token: 0x04001723 RID: 5923
			private static readonly IntPtr NativeMethodInfoPtr__triggerAnimation_b__7_0_Internal_Boolean_Command_0;
		}

		// Token: 0x020003DE RID: 990
		[ObfuscatedName("worm.match.components.WormConflictSequenceDirector+<triggerAnimation>d__7")]
		public sealed class _triggerAnimation_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x0600282E RID: 10286 RVA: 0x00091E94 File Offset: 0x00090094
			// Note: this type is marked as 'beforefieldinit'.
			static _triggerAnimation_d__7()
			{
				Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictSequenceDirector>.NativeClassPtr, "<triggerAnimation>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr);
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, "<>1__state");
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, "<>2__current");
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr_animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, "animations");
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, "<>4__this");
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr__triggersToWaitOn_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, "<triggersToWaitOn>5__2");
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, 100666206);
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, 100666207);
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, 100666208);
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, 100666209);
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, 100666210);
				WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr, 100666211);
			}

			// Token: 0x0600282F RID: 10287 RVA: 0x00091F9C File Offset: 0x0009019C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _triggerAnimation_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictSequenceDirector._triggerAnimation_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002830 RID: 10288 RVA: 0x00091FE4 File Offset: 0x000901E4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002831 RID: 10289 RVA: 0x00092018 File Offset: 0x00090218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714755, XrefRangeEnd = 714811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x06002832 RID: 10290 RVA: 0x00092054 File Offset: 0x00090254
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002833 RID: 10291 RVA: 0x00092094 File Offset: 0x00090294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714811, XrefRangeEnd = 714816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B43 RID: 2883
			// (get) Token: 0x06002834 RID: 10292 RVA: 0x000920C8 File Offset: 0x000902C8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictSequenceDirector._triggerAnimation_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002835 RID: 10293 RVA: 0x000160DC File Offset: 0x000142DC
			public _triggerAnimation_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x06002836 RID: 10294 RVA: 0x00092108 File Offset: 0x00090308
			// (set) Token: 0x06002837 RID: 10295 RVA: 0x000160E5 File Offset: 0x000142E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x06002838 RID: 10296 RVA: 0x00092130 File Offset: 0x00090330
			// (set) Token: 0x06002839 RID: 10297 RVA: 0x00016100 File Offset: 0x00014300
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x0600283A RID: 10298 RVA: 0x00092160 File Offset: 0x00090360
			// (set) Token: 0x0600283B RID: 10299 RVA: 0x0001611F File Offset: 0x0001431F
			public unsafe IEnumerable<WormConflictSequenceAnimator.YieldableAnimation> animations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr_animations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormConflictSequenceAnimator.YieldableAnimation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr_animations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x0600283C RID: 10300 RVA: 0x00092190 File Offset: 0x00090390
			// (set) Token: 0x0600283D RID: 10301 RVA: 0x0001613E File Offset: 0x0001433E
			public unsafe WormConflictSequenceDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictSequenceDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x0600283E RID: 10302 RVA: 0x000921C0 File Offset: 0x000903C0
			// (set) Token: 0x0600283F RID: 10303 RVA: 0x0001615D File Offset: 0x0001435D
			public unsafe List<Command> _triggersToWaitOn_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr__triggersToWaitOn_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictSequenceDirector._triggerAnimation_d__7.NativeFieldInfoPtr__triggersToWaitOn_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001724 RID: 5924
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001725 RID: 5925
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001726 RID: 5926
			private static readonly IntPtr NativeFieldInfoPtr_animations;

			// Token: 0x04001727 RID: 5927
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001728 RID: 5928
			private static readonly IntPtr NativeFieldInfoPtr__triggersToWaitOn_5__2;

			// Token: 0x04001729 RID: 5929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400172A RID: 5930
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400172B RID: 5931
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400172C RID: 5932
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400172D RID: 5933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400172E RID: 5934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
