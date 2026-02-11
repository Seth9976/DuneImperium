using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.ActivatedAbilities.RiseOfIx.TechTileAcquiredAbilities;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000282 RID: 642
	public class AcquireTechTile : global::Canis.actions.Action
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x000C17D4 File Offset: 0x000BF9D4
		// Note: this type is marked as 'beforefieldinit'.
		static AcquireTechTile()
		{
			Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "AcquireTechTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr);
			AcquireTechTile.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr, 100668538);
			AcquireTechTile.NativeMethodInfoPtr_MakeAnalyticsData_Private_Dictionary_2_String_Object_WormMatch_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr, 100668539);
			AcquireTechTile.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr, 100668540);
			AcquireTechTile.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr, 100668541);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x000C1854 File Offset: 0x000BFA54
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquireTechTile(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x000C18A0 File Offset: 0x000BFAA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145055, RefRangeEnd = 145056, XrefRangeStart = 144938, XrefRangeEnd = 145055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, Object> MakeAnalyticsData(WormMatch wormMatch, WormTechTilePlayable techTileToAcquire)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(techTileToAcquire);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile.NativeMethodInfoPtr_MakeAnalyticsData_Private_Dictionary_2_String_Object_WormMatch_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x000C1904 File Offset: 0x000BFB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145056, XrefRangeEnd = 145062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechTile.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000C1950 File Offset: 0x000BFB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145062, XrefRangeEnd = 145066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechTile.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0000B8AA File Offset: 0x00009AAA
		public AcquireTechTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_Dictionary_2_String_Object_WormMatch_WormTechTilePlayable_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006C9 RID: 1737
		[ObfuscatedName("worm.canis.actions.AcquireTechTile+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005C19 RID: 23577 RVA: 0x001CCE50 File Offset: 0x001CB050
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr);
				AcquireTechTile.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr, "<>9");
				AcquireTechTile.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr, "<>9__1_0");
				AcquireTechTile.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr, "<>9__1_1");
				AcquireTechTile.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr, "<>9__2_0");
				AcquireTechTile.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr, 100668543);
				AcquireTechTile.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__1_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr, 100668544);
				AcquireTechTile.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__1_1_Internal_ArchetypeID_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr, 100668545);
				AcquireTechTile.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr, 100668546);
			}

			// Token: 0x06005C1A RID: 23578 RVA: 0x001CCF1C File Offset: 0x001CB11C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireTechTile.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C1B RID: 23579 RVA: 0x001CCF58 File Offset: 0x001CB158
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _MakeAnalyticsData_b__1_0(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__1_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06005C1C RID: 23580 RVA: 0x001CCFA8 File Offset: 0x001CB1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _MakeAnalyticsData_b__1_1(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__1_1_Internal_ArchetypeID_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06005C1D RID: 23581 RVA: 0x001CCFF8 File Offset: 0x001CB1F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144544, XrefRangeEnd = 144549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, Object> _execute_b__2_0(KeyValuePair<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06005C1E RID: 23582 RVA: 0x000223FE File Offset: 0x000205FE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017EA RID: 6122
			// (get) Token: 0x06005C1F RID: 23583 RVA: 0x001CD048 File Offset: 0x001CB248
			// (set) Token: 0x06005C20 RID: 23584 RVA: 0x00022407 File Offset: 0x00020607
			public unsafe static AcquireTechTile.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AcquireTechTile.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AcquireTechTile.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AcquireTechTile.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017EB RID: 6123
			// (get) Token: 0x06005C21 RID: 23585 RVA: 0x001CD070 File Offset: 0x001CB270
			// (set) Token: 0x06005C22 RID: 23586 RVA: 0x00022419 File Offset: 0x00020619
			public unsafe static Func<WormTechTileStack, IEnumerable<Entity>> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AcquireTechTile.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AcquireTechTile.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017EC RID: 6124
			// (get) Token: 0x06005C23 RID: 23587 RVA: 0x001CD098 File Offset: 0x001CB298
			// (set) Token: 0x06005C24 RID: 23588 RVA: 0x0002242B File Offset: 0x0002062B
			public unsafe static Func<WormTechTilePlayable, ArchetypeID> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AcquireTechTile.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AcquireTechTile.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017ED RID: 6125
			// (get) Token: 0x06005C25 RID: 23589 RVA: 0x001CD0C0 File Offset: 0x001CB2C0
			// (set) Token: 0x06005C26 RID: 23590 RVA: 0x0002243D File Offset: 0x0002063D
			public unsafe static Func<KeyValuePair<string, Object>, ValueTuple<string, Object>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AcquireTechTile.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, ValueTuple<string, Object>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AcquireTechTile.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BE2 RID: 15330
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BE3 RID: 15331
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04003BE4 RID: 15332
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04003BE5 RID: 15333
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04003BE6 RID: 15334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BE7 RID: 15335
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__1_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0;

			// Token: 0x04003BE8 RID: 15336
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__1_1_Internal_ArchetypeID_WormTechTilePlayable_0;

			// Token: 0x04003BE9 RID: 15337
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0;
		}

		// Token: 0x020006CA RID: 1738
		[ObfuscatedName("worm.canis.actions.AcquireTechTile+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06005C27 RID: 23591 RVA: 0x001CD0E8 File Offset: 0x001CB2E8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AcquireTechTile>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr);
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<>1__state");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<>2__current");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<>4__this");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<player>5__2");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__techTileToAcquire_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<techTileToAcquire>5__3");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__wormMatch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<wormMatch>5__4");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__sequenceHelper_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<sequenceHelper>5__5");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__parentStack_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<parentStack>5__6");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__techTileStack_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<techTileStack>5__7");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__hasAcquiredAbility_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<hasAcquiredAbility>5__8");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<>7__wrap8");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__acquiredContext_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<acquiredContext>5__10");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<>7__wrap10");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<>7__wrap11");
				AcquireTechTile._execute_d__2.NativeFieldInfoPtr__acquireEffect_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, "<acquireEffect>5__13");
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668547);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668548);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668549);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668550);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668551);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668552);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668553);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668554);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668555);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668556);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668557);
				AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr, 100668558);
			}

			// Token: 0x06005C28 RID: 23592 RVA: 0x001CD344 File Offset: 0x001CB544
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireTechTile._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C29 RID: 23593 RVA: 0x001CD38C File Offset: 0x001CB58C
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C2A RID: 23594 RVA: 0x001CD3C0 File Offset: 0x001CB5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144549, XrefRangeEnd = 144917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005C2B RID: 23595 RVA: 0x001CD3FC File Offset: 0x001CB5FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144917, XrefRangeEnd = 144920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C2C RID: 23596 RVA: 0x001CD430 File Offset: 0x001CB630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144920, XrefRangeEnd = 144923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C2D RID: 23597 RVA: 0x001CD464 File Offset: 0x001CB664
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 144926, RefRangeEnd = 144927, XrefRangeStart = 144923, XrefRangeEnd = 144926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C2E RID: 23598 RVA: 0x001CD498 File Offset: 0x001CB698
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 144930, RefRangeEnd = 144931, XrefRangeStart = 144927, XrefRangeEnd = 144930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017FE RID: 6142
			// (get) Token: 0x06005C2F RID: 23599 RVA: 0x001CD4CC File Offset: 0x001CB6CC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005C30 RID: 23600 RVA: 0x001CD50C File Offset: 0x001CB70C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144931, XrefRangeEnd = 144936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017FF RID: 6143
			// (get) Token: 0x06005C31 RID: 23601 RVA: 0x001CD540 File Offset: 0x001CB740
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005C32 RID: 23602 RVA: 0x001CD580 File Offset: 0x001CB780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144936, XrefRangeEnd = 144938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005C33 RID: 23603 RVA: 0x001CD5C0 File Offset: 0x001CB7C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechTile._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005C34 RID: 23604 RVA: 0x0002244F File Offset: 0x0002064F
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017EE RID: 6126
			// (get) Token: 0x06005C35 RID: 23605 RVA: 0x001CD600 File Offset: 0x001CB800
			// (set) Token: 0x06005C36 RID: 23606 RVA: 0x00022458 File Offset: 0x00020658
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170017EF RID: 6127
			// (get) Token: 0x06005C37 RID: 23607 RVA: 0x001CD628 File Offset: 0x001CB828
			// (set) Token: 0x06005C38 RID: 23608 RVA: 0x00022473 File Offset: 0x00020673
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F0 RID: 6128
			// (get) Token: 0x06005C39 RID: 23609 RVA: 0x001CD658 File Offset: 0x001CB858
			// (set) Token: 0x06005C3A RID: 23610 RVA: 0x00022492 File Offset: 0x00020692
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170017F1 RID: 6129
			// (get) Token: 0x06005C3B RID: 23611 RVA: 0x001CD680 File Offset: 0x001CB880
			// (set) Token: 0x06005C3C RID: 23612 RVA: 0x000224AD File Offset: 0x000206AD
			public unsafe AcquireTechTile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AcquireTechTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F2 RID: 6130
			// (get) Token: 0x06005C3D RID: 23613 RVA: 0x001CD6B0 File Offset: 0x001CB8B0
			// (set) Token: 0x06005C3E RID: 23614 RVA: 0x000224CC File Offset: 0x000206CC
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F3 RID: 6131
			// (get) Token: 0x06005C3F RID: 23615 RVA: 0x001CD6E0 File Offset: 0x001CB8E0
			// (set) Token: 0x06005C40 RID: 23616 RVA: 0x000224EB File Offset: 0x000206EB
			public unsafe WormTechTilePlayable _techTileToAcquire_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__techTileToAcquire_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechTilePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__techTileToAcquire_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F4 RID: 6132
			// (get) Token: 0x06005C41 RID: 23617 RVA: 0x001CD710 File Offset: 0x001CB910
			// (set) Token: 0x06005C42 RID: 23618 RVA: 0x0002250A File Offset: 0x0002070A
			public unsafe WormMatch _wormMatch_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__wormMatch_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__wormMatch_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F5 RID: 6133
			// (get) Token: 0x06005C43 RID: 23619 RVA: 0x001CD740 File Offset: 0x001CB940
			// (set) Token: 0x06005C44 RID: 23620 RVA: 0x00022529 File Offset: 0x00020729
			public unsafe SequenceHelper _sequenceHelper_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__sequenceHelper_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__sequenceHelper_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F6 RID: 6134
			// (get) Token: 0x06005C45 RID: 23621 RVA: 0x001CD770 File Offset: 0x001CB970
			// (set) Token: 0x06005C46 RID: 23622 RVA: 0x00022548 File Offset: 0x00020748
			public unsafe Entity _parentStack_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__parentStack_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__parentStack_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F7 RID: 6135
			// (get) Token: 0x06005C47 RID: 23623 RVA: 0x001CD7A0 File Offset: 0x001CB9A0
			// (set) Token: 0x06005C48 RID: 23624 RVA: 0x00022567 File Offset: 0x00020767
			public unsafe WormTechTileStack _techTileStack_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__techTileStack_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechTileStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__techTileStack_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F8 RID: 6136
			// (get) Token: 0x06005C49 RID: 23625 RVA: 0x001CD7D0 File Offset: 0x001CB9D0
			// (set) Token: 0x06005C4A RID: 23626 RVA: 0x00022586 File Offset: 0x00020786
			public unsafe bool _hasAcquiredAbility_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__hasAcquiredAbility_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__hasAcquiredAbility_5__8)) = value;
				}
			}

			// Token: 0x170017F9 RID: 6137
			// (get) Token: 0x06005C4B RID: 23627 RVA: 0x001CD7F8 File Offset: 0x001CB9F8
			// (set) Token: 0x06005C4C RID: 23628 RVA: 0x000225A1 File Offset: 0x000207A1
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017FA RID: 6138
			// (get) Token: 0x06005C4D RID: 23629 RVA: 0x001CD828 File Offset: 0x001CBA28
			// (set) Token: 0x06005C4E RID: 23630 RVA: 0x000225C0 File Offset: 0x000207C0
			public unsafe Context _acquiredContext_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__acquiredContext_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__acquiredContext_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017FB RID: 6139
			// (get) Token: 0x06005C4F RID: 23631 RVA: 0x001CD858 File Offset: 0x001CBA58
			// (set) Token: 0x06005C50 RID: 23632 RVA: 0x000225DF File Offset: 0x000207DF
			public List<TechTileAcquiredAbility>.Enumerator __7__wrap10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap10);
					return new List<TechTileAcquiredAbility>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<TechTileAcquiredAbility>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<TechTileAcquiredAbility>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017FC RID: 6140
			// (get) Token: 0x06005C51 RID: 23633 RVA: 0x001CD888 File Offset: 0x001CBA88
			// (set) Token: 0x06005C52 RID: 23634 RVA: 0x0002260D File Offset: 0x0002080D
			public List<AcquireEffects>.Enumerator __7__wrap11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap11);
					return new List<AcquireEffects>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AcquireEffects>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr___7__wrap11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AcquireEffects>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017FD RID: 6141
			// (get) Token: 0x06005C53 RID: 23635 RVA: 0x001CD8B8 File Offset: 0x001CBAB8
			// (set) Token: 0x06005C54 RID: 23636 RVA: 0x0002263B File Offset: 0x0002083B
			public unsafe AcquireEffects _acquireEffect_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__acquireEffect_5__13);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AcquireTechTile._execute_d__2.NativeFieldInfoPtr__acquireEffect_5__13)) = value;
				}
			}

			// Token: 0x04003BEA RID: 15338
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003BEB RID: 15339
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003BEC RID: 15340
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003BED RID: 15341
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003BEE RID: 15342
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003BEF RID: 15343
			private static readonly IntPtr NativeFieldInfoPtr__techTileToAcquire_5__3;

			// Token: 0x04003BF0 RID: 15344
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__4;

			// Token: 0x04003BF1 RID: 15345
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__5;

			// Token: 0x04003BF2 RID: 15346
			private static readonly IntPtr NativeFieldInfoPtr__parentStack_5__6;

			// Token: 0x04003BF3 RID: 15347
			private static readonly IntPtr NativeFieldInfoPtr__techTileStack_5__7;

			// Token: 0x04003BF4 RID: 15348
			private static readonly IntPtr NativeFieldInfoPtr__hasAcquiredAbility_5__8;

			// Token: 0x04003BF5 RID: 15349
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x04003BF6 RID: 15350
			private static readonly IntPtr NativeFieldInfoPtr__acquiredContext_5__10;

			// Token: 0x04003BF7 RID: 15351
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap10;

			// Token: 0x04003BF8 RID: 15352
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap11;

			// Token: 0x04003BF9 RID: 15353
			private static readonly IntPtr NativeFieldInfoPtr__acquireEffect_5__13;

			// Token: 0x04003BFA RID: 15354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003BFB RID: 15355
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BFC RID: 15356
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003BFD RID: 15357
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003BFE RID: 15358
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003BFF RID: 15359
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04003C00 RID: 15360
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x04003C01 RID: 15361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003C02 RID: 15362
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C03 RID: 15363
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C04 RID: 15364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003C05 RID: 15365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
