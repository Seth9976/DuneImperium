using System;
using boardgames.match;
using boardgames.match.behaviours;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000136 RID: 310
	public class WormHallOfOratoryRenderer : VersionedView<ReadOnlyVersionedList<EntityComponent>>
	{
		// Token: 0x06000DF7 RID: 3575 RVA: 0x00042458 File Offset: 0x00040658
		// Note: this type is marked as 'beforefieldinit'.
		static WormHallOfOratoryRenderer()
		{
			Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHallOfOratoryRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr);
			WormHallOfOratoryRenderer.NativeFieldInfoPtr_persuasionFXAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, "persuasionFXAnimator");
			WormHallOfOratoryRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, "entities");
			WormHallOfOratoryRenderer.NativeFieldInfoPtr_PersuasionFXParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, "PersuasionFXParam");
			WormHallOfOratoryRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, 100665180);
			WormHallOfOratoryRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, 100665181);
			WormHallOfOratoryRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, 100665182);
			WormHallOfOratoryRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, 100665183);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00042514 File Offset: 0x00040714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706121, XrefRangeEnd = 706135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHallOfOratoryRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00042550 File Offset: 0x00040750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706135, XrefRangeEnd = 706140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00042590 File Offset: 0x00040790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706140, XrefRangeEnd = 706160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHallOfOratoryRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000425CC File Offset: 0x000407CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706160, XrefRangeEnd = 706163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHallOfOratoryRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000095BB File Offset: 0x000077BB
		public WormHallOfOratoryRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00042608 File Offset: 0x00040808
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000095C4 File Offset: 0x000077C4
		public unsafe Animator persuasionFXAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer.NativeFieldInfoPtr_persuasionFXAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer.NativeFieldInfoPtr_persuasionFXAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00042638 File Offset: 0x00040838
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x000095E3 File Offset: 0x000077E3
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x00042668 File Offset: 0x00040868
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00009602 File Offset: 0x00007802
		public unsafe static int PersuasionFXParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormHallOfOratoryRenderer.NativeFieldInfoPtr_PersuasionFXParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormHallOfOratoryRenderer.NativeFieldInfoPtr_PersuasionFXParam, (void*)(&value));
			}
		}

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_persuasionFXAnimator;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr_PersuasionFXParam;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200038A RID: 906
		[ObfuscatedName("worm.match.dataRenderers.WormHallOfOratoryRenderer+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002459 RID: 9305 RVA: 0x00086078 File Offset: 0x00084278
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormHallOfOratoryRenderer.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHallOfOratoryRenderer.__c__DisplayClass5_0>.NativeClassPtr);
				WormHallOfOratoryRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_localPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer.__c__DisplayClass5_0>.NativeClassPtr, "localPlayerID");
				WormHallOfOratoryRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100665185);
				WormHallOfOratoryRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100665186);
			}

			// Token: 0x0600245A RID: 9306 RVA: 0x000860E0 File Offset: 0x000842E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHallOfOratoryRenderer.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600245B RID: 9307 RVA: 0x0008611C File Offset: 0x0008431C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706101, XrefRangeEnd = 706112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600245C RID: 9308 RVA: 0x000144A1 File Offset: 0x000126A1
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x0600245D RID: 9309 RVA: 0x0008616C File Offset: 0x0008436C
			// (set) Token: 0x0600245E RID: 9310 RVA: 0x000144AA File Offset: 0x000126AA
			public unsafe AccountID localPlayerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_localPlayerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_localPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014D9 RID: 5337
			private static readonly IntPtr NativeFieldInfoPtr_localPlayerID;

			// Token: 0x040014DA RID: 5338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014DB RID: 5339
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x0200038B RID: 907
		[ObfuscatedName("worm.match.dataRenderers.WormHallOfOratoryRenderer+<Init>d__4")]
		public sealed class _Init_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x0600245F RID: 9311 RVA: 0x0008619C File Offset: 0x0008439C
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__4()
			{
				Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHallOfOratoryRenderer>.NativeClassPtr, "<Init>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr);
				WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, "<>1__state");
				WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, "<>2__current");
				WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, "<>4__this");
				WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, "<entitiesProvider>5__2");
				WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr__view_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, "<view>5__3");
				WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, 100665187);
				WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, 100665188);
				WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, 100665189);
				WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, 100665190);
				WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, 100665191);
				WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr, 100665192);
			}

			// Token: 0x06002460 RID: 9312 RVA: 0x000862A4 File Offset: 0x000844A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHallOfOratoryRenderer._Init_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002461 RID: 9313 RVA: 0x000862EC File Offset: 0x000844EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002462 RID: 9314 RVA: 0x00086320 File Offset: 0x00084520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706112, XrefRangeEnd = 706116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x06002463 RID: 9315 RVA: 0x0008635C File Offset: 0x0008455C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002464 RID: 9316 RVA: 0x0008639C File Offset: 0x0008459C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706116, XrefRangeEnd = 706121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x06002465 RID: 9317 RVA: 0x000863D0 File Offset: 0x000845D0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHallOfOratoryRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002466 RID: 9318 RVA: 0x000144C9 File Offset: 0x000126C9
			public _Init_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x06002467 RID: 9319 RVA: 0x00086410 File Offset: 0x00084610
			// (set) Token: 0x06002468 RID: 9320 RVA: 0x000144D2 File Offset: 0x000126D2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x06002469 RID: 9321 RVA: 0x00086438 File Offset: 0x00084638
			// (set) Token: 0x0600246A RID: 9322 RVA: 0x000144ED File Offset: 0x000126ED
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x0600246B RID: 9323 RVA: 0x00086468 File Offset: 0x00084668
			// (set) Token: 0x0600246C RID: 9324 RVA: 0x0001450C File Offset: 0x0001270C
			public unsafe WormHallOfOratoryRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHallOfOratoryRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x0600246D RID: 9325 RVA: 0x00086498 File Offset: 0x00084698
			// (set) Token: 0x0600246E RID: 9326 RVA: 0x0001452B File Offset: 0x0001272B
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x0600246F RID: 9327 RVA: 0x000864C8 File Offset: 0x000846C8
			// (set) Token: 0x06002470 RID: 9328 RVA: 0x0001454A File Offset: 0x0001274A
			public unsafe EntityView _view_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr__view_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHallOfOratoryRenderer._Init_d__4.NativeFieldInfoPtr__view_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014DC RID: 5340
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014DD RID: 5341
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014DE RID: 5342
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014DF RID: 5343
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040014E0 RID: 5344
			private static readonly IntPtr NativeFieldInfoPtr__view_5__3;

			// Token: 0x040014E1 RID: 5345
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014E2 RID: 5346
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014E3 RID: 5347
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014E4 RID: 5348
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014E5 RID: 5349
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014E6 RID: 5350
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
