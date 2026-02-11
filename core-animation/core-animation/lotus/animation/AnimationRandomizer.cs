using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus.animation
{
	// Token: 0x02000015 RID: 21
	public class AnimationRandomizer : MonoBehaviour
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x000054A4 File Offset: 0x000036A4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationRandomizer()
		{
			Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "lotus.animation", "AnimationRandomizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr);
			AnimationRandomizer.NativeFieldInfoPtr_randomizers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr, "randomizers");
			AnimationRandomizer.NativeFieldInfoPtr_rollRoutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr, "rollRoutines");
			AnimationRandomizer.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr, 100663398);
			AnimationRandomizer.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr, 100663399);
			AnimationRandomizer.NativeMethodInfoPtr_doRoll_Private_IEnumerator_AnimationRandomizerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr, 100663400);
			AnimationRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr, 100663401);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000554C File Offset: 0x0000374C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263739, XrefRangeEnd = 1263764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005580 File Offset: 0x00003780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263764, XrefRangeEnd = 1263781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000055B4 File Offset: 0x000037B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263781, XrefRangeEnd = 1263786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator doRoll(AnimationRandomizer.AnimationRandomizerData randomizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(randomizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer.NativeMethodInfoPtr_doRoll_Private_IEnumerator_AnimationRandomizerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005604 File Offset: 0x00003804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263786, XrefRangeEnd = 1263794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationRandomizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002742 File Offset: 0x00000942
		public AnimationRandomizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005640 File Offset: 0x00003840
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000274B File Offset: 0x0000094B
		public unsafe List<AnimationRandomizer.AnimationRandomizerData> randomizers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.NativeFieldInfoPtr_randomizers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AnimationRandomizer.AnimationRandomizerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.NativeFieldInfoPtr_randomizers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005670 File Offset: 0x00003870
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000276A File Offset: 0x0000096A
		public unsafe List<IEnumerator> rollRoutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.NativeFieldInfoPtr_rollRoutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IEnumerator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.NativeFieldInfoPtr_rollRoutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_randomizers;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_rollRoutines;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_doRoll_Private_IEnumerator_AnimationRandomizerData_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001C RID: 28
		[Serializable]
		public class AnimationRandomizerData : global::Il2CppSystem.Object
		{
			// Token: 0x0600013D RID: 317 RVA: 0x000064D0 File Offset: 0x000046D0
			// Note: this type is marked as 'beforefieldinit'.
			static AnimationRandomizerData()
			{
				Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr, "AnimationRandomizerData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr);
				AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr, "animator");
				AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr, "param");
				AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr, "interval");
				AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr, "min");
				AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr, "max");
				AnimationRandomizer.AnimationRandomizerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr, 100663402);
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00006574 File Offset: 0x00004774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263722, XrefRangeEnd = 1263727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AnimationRandomizerData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationRandomizer.AnimationRandomizerData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer.AnimationRandomizerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00002A4C File Offset: 0x00000C4C
			public AnimationRandomizerData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000140 RID: 320 RVA: 0x000065B0 File Offset: 0x000047B0
			// (set) Token: 0x06000141 RID: 321 RVA: 0x00002A55 File Offset: 0x00000C55
			public unsafe Animator animator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_animator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000142 RID: 322 RVA: 0x000065E0 File Offset: 0x000047E0
			// (set) Token: 0x06000143 RID: 323 RVA: 0x00002A74 File Offset: 0x00000C74
			public unsafe string param
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_param);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_param), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000144 RID: 324 RVA: 0x00006608 File Offset: 0x00004808
			// (set) Token: 0x06000145 RID: 325 RVA: 0x00002A93 File Offset: 0x00000C93
			public unsafe float interval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_interval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_interval)) = value;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00006630 File Offset: 0x00004830
			// (set) Token: 0x06000147 RID: 327 RVA: 0x00002AAE File Offset: 0x00000CAE
			public unsafe float min
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_min);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_min)) = value;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000148 RID: 328 RVA: 0x00006658 File Offset: 0x00004858
			// (set) Token: 0x06000149 RID: 329 RVA: 0x00002AC9 File Offset: 0x00000CC9
			public unsafe float max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_max);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer.AnimationRandomizerData.NativeFieldInfoPtr_max)) = value;
				}
			}

			// Token: 0x040000B9 RID: 185
			private static readonly IntPtr NativeFieldInfoPtr_animator;

			// Token: 0x040000BA RID: 186
			private static readonly IntPtr NativeFieldInfoPtr_param;

			// Token: 0x040000BB RID: 187
			private static readonly IntPtr NativeFieldInfoPtr_interval;

			// Token: 0x040000BC RID: 188
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x040000BD RID: 189
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x040000BE RID: 190
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200001D RID: 29
		[ObfuscatedName("lotus.animation.AnimationRandomizer+<doRoll>d__5")]
		public sealed class _doRoll_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x0600014A RID: 330 RVA: 0x00006680 File Offset: 0x00004880
			// Note: this type is marked as 'beforefieldinit'.
			static _doRoll_d__5()
			{
				Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationRandomizer>.NativeClassPtr, "<doRoll>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr);
				AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, "<>1__state");
				AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, "<>2__current");
				AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr_randomizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, "randomizer");
				AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, 100663403);
				AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, 100663404);
				AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, 100663405);
				AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, 100663406);
				AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, 100663407);
				AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr, 100663408);
			}

			// Token: 0x0600014B RID: 331 RVA: 0x00006760 File Offset: 0x00004960
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _doRoll_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationRandomizer._doRoll_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600014C RID: 332 RVA: 0x000067A8 File Offset: 0x000049A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600014D RID: 333 RVA: 0x000067DC File Offset: 0x000049DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263727, XrefRangeEnd = 1263734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600014E RID: 334 RVA: 0x00006818 File Offset: 0x00004A18
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600014F RID: 335 RVA: 0x00006858 File Offset: 0x00004A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263734, XrefRangeEnd = 1263739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000150 RID: 336 RVA: 0x0000688C File Offset: 0x00004A8C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationRandomizer._doRoll_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00002AE4 File Offset: 0x00000CE4
			public _doRoll_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000152 RID: 338 RVA: 0x000068CC File Offset: 0x00004ACC
			// (set) Token: 0x06000153 RID: 339 RVA: 0x00002AED File Offset: 0x00000CED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000154 RID: 340 RVA: 0x000068F4 File Offset: 0x00004AF4
			// (set) Token: 0x06000155 RID: 341 RVA: 0x00002B08 File Offset: 0x00000D08
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000156 RID: 342 RVA: 0x00006924 File Offset: 0x00004B24
			// (set) Token: 0x06000157 RID: 343 RVA: 0x00002B27 File Offset: 0x00000D27
			public unsafe AnimationRandomizer.AnimationRandomizerData randomizer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr_randomizer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationRandomizer.AnimationRandomizerData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationRandomizer._doRoll_d__5.NativeFieldInfoPtr_randomizer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000BF RID: 191
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000C0 RID: 192
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000C1 RID: 193
			private static readonly IntPtr NativeFieldInfoPtr_randomizer;

			// Token: 0x040000C2 RID: 194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000C3 RID: 195
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000C4 RID: 196
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000C5 RID: 197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000C6 RID: 198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000C7 RID: 199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
