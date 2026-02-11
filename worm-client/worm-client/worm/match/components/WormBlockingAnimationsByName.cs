using System;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001D5 RID: 469
	public class WormBlockingAnimationsByName : MonoBehaviour
	{
		// Token: 0x060014BA RID: 5306 RVA: 0x00057070 File Offset: 0x00055270
		// Note: this type is marked as 'beforefieldinit'.
		static WormBlockingAnimationsByName()
		{
			Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormBlockingAnimationsByName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr);
			WormBlockingAnimationsByName.NativeFieldInfoPtr_animationsByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr, "animationsByName");
			WormBlockingAnimationsByName.NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr, 100666133);
			WormBlockingAnimationsByName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr, 100666134);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000570DC File Offset: 0x000552DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714494, XrefRangeEnd = 714500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TriggerAndBlock(string animationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName.NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0005712C File Offset: 0x0005532C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714500, XrefRangeEnd = 714505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBlockingAnimationsByName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0000CADA File Offset: 0x0000ACDA
		public WormBlockingAnimationsByName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00057168 File Offset: 0x00055368
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x0000CAE3 File Offset: 0x0000ACE3
		public unsafe Il2CppReferenceArray<WormBlockingAnimationsByName.AnimationPair> animationsByName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName.NativeFieldInfoPtr_animationsByName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormBlockingAnimationsByName.AnimationPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName.NativeFieldInfoPtr_animationsByName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr_animationsByName;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_String_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D8 RID: 984
		[Serializable]
		public class AnimationPair : global::Il2CppSystem.Object
		{
			// Token: 0x060027DE RID: 10206 RVA: 0x0009103C File Offset: 0x0008F23C
			// Note: this type is marked as 'beforefieldinit'.
			static AnimationPair()
			{
				Il2CppClassPointerStore<WormBlockingAnimationsByName.AnimationPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr, "AnimationPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBlockingAnimationsByName.AnimationPair>.NativeClassPtr);
				WormBlockingAnimationsByName.AnimationPair.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName.AnimationPair>.NativeClassPtr, "name");
				WormBlockingAnimationsByName.AnimationPair.NativeFieldInfoPtr_animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName.AnimationPair>.NativeClassPtr, "animation");
				WormBlockingAnimationsByName.AnimationPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName.AnimationPair>.NativeClassPtr, 100666135);
			}

			// Token: 0x060027DF RID: 10207 RVA: 0x000910A4 File Offset: 0x0008F2A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714462, XrefRangeEnd = 714466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AnimationPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBlockingAnimationsByName.AnimationPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName.AnimationPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027E0 RID: 10208 RVA: 0x00015E6B File Offset: 0x0001406B
			public AnimationPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B23 RID: 2851
			// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000910E0 File Offset: 0x0008F2E0
			// (set) Token: 0x060027E2 RID: 10210 RVA: 0x00015E74 File Offset: 0x00014074
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName.AnimationPair.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName.AnimationPair.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B24 RID: 2852
			// (get) Token: 0x060027E3 RID: 10211 RVA: 0x00091108 File Offset: 0x0008F308
			// (set) Token: 0x060027E4 RID: 10212 RVA: 0x00015E93 File Offset: 0x00014093
			public unsafe TriggeredBlockingAnimation animation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName.AnimationPair.NativeFieldInfoPtr_animation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName.AnimationPair.NativeFieldInfoPtr_animation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016F6 RID: 5878
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040016F7 RID: 5879
			private static readonly IntPtr NativeFieldInfoPtr_animation;

			// Token: 0x040016F8 RID: 5880
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003D9 RID: 985
		[ObfuscatedName("worm.match.components.WormBlockingAnimationsByName+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060027E5 RID: 10213 RVA: 0x00091138 File Offset: 0x0008F338
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormBlockingAnimationsByName.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBlockingAnimationsByName.__c__DisplayClass2_0>.NativeClassPtr);
				WormBlockingAnimationsByName.__c__DisplayClass2_0.NativeFieldInfoPtr_animationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName.__c__DisplayClass2_0>.NativeClassPtr, "animationName");
				WormBlockingAnimationsByName.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName.__c__DisplayClass2_0>.NativeClassPtr, 100666136);
				WormBlockingAnimationsByName.__c__DisplayClass2_0.NativeMethodInfoPtr__TriggerAndBlock_b__0_Internal_Boolean_AnimationPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName.__c__DisplayClass2_0>.NativeClassPtr, 100666137);
			}

			// Token: 0x060027E6 RID: 10214 RVA: 0x000911A0 File Offset: 0x0008F3A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBlockingAnimationsByName.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027E7 RID: 10215 RVA: 0x000911DC File Offset: 0x0008F3DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TriggerAndBlock_b__0(WormBlockingAnimationsByName.AnimationPair a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName.__c__DisplayClass2_0.NativeMethodInfoPtr__TriggerAndBlock_b__0_Internal_Boolean_AnimationPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060027E8 RID: 10216 RVA: 0x00015EB2 File Offset: 0x000140B2
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B25 RID: 2853
			// (get) Token: 0x060027E9 RID: 10217 RVA: 0x0009122C File Offset: 0x0008F42C
			// (set) Token: 0x060027EA RID: 10218 RVA: 0x00015EBB File Offset: 0x000140BB
			public unsafe string animationName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName.__c__DisplayClass2_0.NativeFieldInfoPtr_animationName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName.__c__DisplayClass2_0.NativeFieldInfoPtr_animationName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040016F9 RID: 5881
			private static readonly IntPtr NativeFieldInfoPtr_animationName;

			// Token: 0x040016FA RID: 5882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016FB RID: 5883
			private static readonly IntPtr NativeMethodInfoPtr__TriggerAndBlock_b__0_Internal_Boolean_AnimationPair_0;
		}

		// Token: 0x020003DA RID: 986
		[ObfuscatedName("worm.match.components.WormBlockingAnimationsByName+<TriggerAndBlock>d__2")]
		public sealed class _TriggerAndBlock_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x060027EB RID: 10219 RVA: 0x00091254 File Offset: 0x0008F454
			// Note: this type is marked as 'beforefieldinit'.
			static _TriggerAndBlock_d__2()
			{
				Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBlockingAnimationsByName>.NativeClassPtr, "<TriggerAndBlock>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr);
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, "<>1__state");
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, "<>2__current");
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr_animationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, "animationName");
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, "<>4__this");
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr__block_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, "<block>5__2");
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, 100666138);
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, 100666139);
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, 100666140);
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, 100666141);
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, 100666142);
				WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr, 100666143);
			}

			// Token: 0x060027EC RID: 10220 RVA: 0x0009135C File Offset: 0x0008F55C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TriggerAndBlock_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBlockingAnimationsByName._TriggerAndBlock_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027ED RID: 10221 RVA: 0x000913A4 File Offset: 0x0008F5A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027EE RID: 10222 RVA: 0x000913D8 File Offset: 0x0008F5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714466, XrefRangeEnd = 714489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x060027EF RID: 10223 RVA: 0x00091414 File Offset: 0x0008F614
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027F0 RID: 10224 RVA: 0x00091454 File Offset: 0x0008F654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714489, XrefRangeEnd = 714494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x060027F1 RID: 10225 RVA: 0x00091488 File Offset: 0x0008F688
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027F2 RID: 10226 RVA: 0x00015EDA File Offset: 0x000140DA
			public _TriggerAndBlock_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x060027F3 RID: 10227 RVA: 0x000914C8 File Offset: 0x0008F6C8
			// (set) Token: 0x060027F4 RID: 10228 RVA: 0x00015EE3 File Offset: 0x000140E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B27 RID: 2855
			// (get) Token: 0x060027F5 RID: 10229 RVA: 0x000914F0 File Offset: 0x0008F6F0
			// (set) Token: 0x060027F6 RID: 10230 RVA: 0x00015EFE File Offset: 0x000140FE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x060027F7 RID: 10231 RVA: 0x00091520 File Offset: 0x0008F720
			// (set) Token: 0x060027F8 RID: 10232 RVA: 0x00015F1D File Offset: 0x0001411D
			public unsafe string animationName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr_animationName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr_animationName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x060027F9 RID: 10233 RVA: 0x00091548 File Offset: 0x0008F748
			// (set) Token: 0x060027FA RID: 10234 RVA: 0x00015F3C File Offset: 0x0001413C
			public unsafe WormBlockingAnimationsByName __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBlockingAnimationsByName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x060027FB RID: 10235 RVA: 0x00091578 File Offset: 0x0008F778
			// (set) Token: 0x060027FC RID: 10236 RVA: 0x00015F5B File Offset: 0x0001415B
			public unsafe IEnumerator _block_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr__block_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlockingAnimationsByName._TriggerAndBlock_d__2.NativeFieldInfoPtr__block_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016FC RID: 5884
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016FD RID: 5885
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016FE RID: 5886
			private static readonly IntPtr NativeFieldInfoPtr_animationName;

			// Token: 0x040016FF RID: 5887
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001700 RID: 5888
			private static readonly IntPtr NativeFieldInfoPtr__block_5__2;

			// Token: 0x04001701 RID: 5889
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001702 RID: 5890
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001703 RID: 5891
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001704 RID: 5892
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001705 RID: 5893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001706 RID: 5894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
