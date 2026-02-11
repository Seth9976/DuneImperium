using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000240 RID: 576
	public class GainAlliance : global::Canis.actions.Action
	{
		// Token: 0x06001914 RID: 6420 RVA: 0x000BA844 File Offset: 0x000B8A44
		// Note: this type is marked as 'beforefieldinit'.
		static GainAlliance()
		{
			Il2CppClassPointerStore<GainAlliance>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainAlliance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr);
			GainAlliance.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, "wormMatch");
			GainAlliance.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, 100667793);
			GainAlliance.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainAlliance_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, 100667794);
			GainAlliance.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, 100667795);
			GainAlliance.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, 100667796);
			GainAlliance.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, 100667797);
			GainAlliance.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, 100667798);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000BA900 File Offset: 0x000B8B00
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 135734, RefRangeEnd = 135759, XrefRangeStart = 135732, XrefRangeEnd = 135734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainAlliance(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000BA94C File Offset: 0x000B8B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135759, XrefRangeEnd = 135769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainAlliance(SerializedGainAlliance serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainAlliance_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000BA9AC File Offset: 0x000B8BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135769, XrefRangeEnd = 135775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAlliance.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000BA9F8 File Offset: 0x000B8BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135775, XrefRangeEnd = 135782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAlliance.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x000BAA54 File Offset: 0x000B8C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135782, XrefRangeEnd = 135784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAlliance.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000BAAA4 File Offset: 0x000B8CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135784, XrefRangeEnd = 135788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainAlliance.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0000AC98 File Offset: 0x00008E98
		public GainAlliance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x000BAB00 File Offset: 0x000B8D00
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0000ACA1 File Offset: 0x00008EA1
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedGainAlliance_Match_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200067C RID: 1660
		[ObfuscatedName("worm.canis.actions.GainAlliance+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005582 RID: 21890 RVA: 0x001B9850 File Offset: 0x001B7A50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GainAlliance.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAlliance.__c>.NativeClassPtr);
				GainAlliance.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance.__c>.NativeClassPtr, "<>9");
				GainAlliance.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance.__c>.NativeClassPtr, "<>9__3_0");
				GainAlliance.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance.__c>.NativeClassPtr, 100667800);
				GainAlliance.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance.__c>.NativeClassPtr, 100667801);
			}

			// Token: 0x06005583 RID: 21891 RVA: 0x001B98CC File Offset: 0x001B7ACC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAlliance.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005584 RID: 21892 RVA: 0x001B9908 File Offset: 0x001B7B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__3_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005585 RID: 21893 RVA: 0x0001E794 File Offset: 0x0001C994
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001581 RID: 5505
			// (get) Token: 0x06005586 RID: 21894 RVA: 0x001B9958 File Offset: 0x001B7B58
			// (set) Token: 0x06005587 RID: 21895 RVA: 0x0001E79D File Offset: 0x0001C99D
			public unsafe static GainAlliance.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainAlliance.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainAlliance.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainAlliance.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001582 RID: 5506
			// (get) Token: 0x06005588 RID: 21896 RVA: 0x001B9980 File Offset: 0x001B7B80
			// (set) Token: 0x06005589 RID: 21897 RVA: 0x0001E7AF File Offset: 0x0001C9AF
			public unsafe static Func<WormPlayer, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainAlliance.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainAlliance.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037DE RID: 14302
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040037DF RID: 14303
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040037E0 RID: 14304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040037E1 RID: 14305
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200067D RID: 1661
		[ObfuscatedName("worm.canis.actions.GainAlliance+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600558A RID: 21898 RVA: 0x001B99A8 File Offset: 0x001B7BA8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr);
				GainAlliance._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<>1__state");
				GainAlliance._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<>2__current");
				GainAlliance._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				GainAlliance._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<>4__this");
				GainAlliance._execute_d__3.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<player>5__2");
				GainAlliance._execute_d__3.NativeFieldInfoPtr__allianceToken_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<allianceToken>5__3");
				GainAlliance._execute_d__3.NativeFieldInfoPtr__logBuilder_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<logBuilder>5__4");
				GainAlliance._execute_d__3.NativeFieldInfoPtr__playerAllianceTokenVP_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<playerAllianceTokenVP>5__5");
				GainAlliance._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<sequenceHelper>5__6");
				GainAlliance._execute_d__3.NativeFieldInfoPtr__takenFromPlayer_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<takenFromPlayer>5__7");
				GainAlliance._execute_d__3.NativeFieldInfoPtr__childUndo_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<childUndo>5__8");
				GainAlliance._execute_d__3.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, "<>7__wrap8");
				GainAlliance._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667802);
				GainAlliance._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667803);
				GainAlliance._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667804);
				GainAlliance._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667805);
				GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667806);
				GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667807);
				GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667808);
				GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667809);
				GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr, 100667810);
			}

			// Token: 0x0600558B RID: 21899 RVA: 0x001B9B78 File Offset: 0x001B7D78
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAlliance._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600558C RID: 21900 RVA: 0x001B9BC0 File Offset: 0x001B7DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135275, XrefRangeEnd = 135280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600558D RID: 21901 RVA: 0x001B9BF4 File Offset: 0x001B7DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135280, XrefRangeEnd = 135672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600558E RID: 21902 RVA: 0x001B9C30 File Offset: 0x001B7E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135672, XrefRangeEnd = 135675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700158F RID: 5519
			// (get) Token: 0x0600558F RID: 21903 RVA: 0x001B9C64 File Offset: 0x001B7E64
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005590 RID: 21904 RVA: 0x001B9CA4 File Offset: 0x001B7EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135675, XrefRangeEnd = 135680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001590 RID: 5520
			// (get) Token: 0x06005591 RID: 21905 RVA: 0x001B9CD8 File Offset: 0x001B7ED8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005592 RID: 21906 RVA: 0x001B9D18 File Offset: 0x001B7F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135680, XrefRangeEnd = 135682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005593 RID: 21907 RVA: 0x001B9D58 File Offset: 0x001B7F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005594 RID: 21908 RVA: 0x0001E7C1 File Offset: 0x0001C9C1
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001583 RID: 5507
			// (get) Token: 0x06005595 RID: 21909 RVA: 0x001B9D98 File Offset: 0x001B7F98
			// (set) Token: 0x06005596 RID: 21910 RVA: 0x0001E7CA File Offset: 0x0001C9CA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001584 RID: 5508
			// (get) Token: 0x06005597 RID: 21911 RVA: 0x001B9DC0 File Offset: 0x001B7FC0
			// (set) Token: 0x06005598 RID: 21912 RVA: 0x0001E7E5 File Offset: 0x0001C9E5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001585 RID: 5509
			// (get) Token: 0x06005599 RID: 21913 RVA: 0x001B9DF0 File Offset: 0x001B7FF0
			// (set) Token: 0x0600559A RID: 21914 RVA: 0x0001E804 File Offset: 0x0001CA04
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001586 RID: 5510
			// (get) Token: 0x0600559B RID: 21915 RVA: 0x001B9E18 File Offset: 0x001B8018
			// (set) Token: 0x0600559C RID: 21916 RVA: 0x0001E81F File Offset: 0x0001CA1F
			public unsafe GainAlliance __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainAlliance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001587 RID: 5511
			// (get) Token: 0x0600559D RID: 21917 RVA: 0x001B9E48 File Offset: 0x001B8048
			// (set) Token: 0x0600559E RID: 21918 RVA: 0x0001E83E File Offset: 0x0001CA3E
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001588 RID: 5512
			// (get) Token: 0x0600559F RID: 21919 RVA: 0x001B9E78 File Offset: 0x001B8078
			// (set) Token: 0x060055A0 RID: 21920 RVA: 0x0001E85D File Offset: 0x0001CA5D
			public unsafe WormEntity _allianceToken_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__allianceToken_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__allianceToken_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001589 RID: 5513
			// (get) Token: 0x060055A1 RID: 21921 RVA: 0x001B9EA8 File Offset: 0x001B80A8
			// (set) Token: 0x060055A2 RID: 21922 RVA: 0x0001E87C File Offset: 0x0001CA7C
			public unsafe GameLogBuilder _logBuilder_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__logBuilder_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__logBuilder_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700158A RID: 5514
			// (get) Token: 0x060055A3 RID: 21923 RVA: 0x001B9ED8 File Offset: 0x001B80D8
			// (set) Token: 0x060055A4 RID: 21924 RVA: 0x0001E89B File Offset: 0x0001CA9B
			public unsafe int _playerAllianceTokenVP_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__playerAllianceTokenVP_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__playerAllianceTokenVP_5__5)) = value;
				}
			}

			// Token: 0x1700158B RID: 5515
			// (get) Token: 0x060055A5 RID: 21925 RVA: 0x001B9F00 File Offset: 0x001B8100
			// (set) Token: 0x060055A6 RID: 21926 RVA: 0x0001E8B6 File Offset: 0x0001CAB6
			public unsafe SequenceHelper _sequenceHelper_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700158C RID: 5516
			// (get) Token: 0x060055A7 RID: 21927 RVA: 0x001B9F30 File Offset: 0x001B8130
			// (set) Token: 0x060055A8 RID: 21928 RVA: 0x0001E8D5 File Offset: 0x0001CAD5
			public unsafe WormPlayer _takenFromPlayer_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__takenFromPlayer_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__takenFromPlayer_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700158D RID: 5517
			// (get) Token: 0x060055A9 RID: 21929 RVA: 0x001B9F60 File Offset: 0x001B8160
			// (set) Token: 0x060055AA RID: 21930 RVA: 0x0001E8F4 File Offset: 0x0001CAF4
			public unsafe UndoNode _childUndo_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__childUndo_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr__childUndo_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700158E RID: 5518
			// (get) Token: 0x060055AB RID: 21931 RVA: 0x001B9F90 File Offset: 0x001B8190
			// (set) Token: 0x060055AC RID: 21932 RVA: 0x0001E913 File Offset: 0x0001CB13
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._execute_d__3.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037E2 RID: 14306
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040037E3 RID: 14307
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040037E4 RID: 14308
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040037E5 RID: 14309
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040037E6 RID: 14310
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040037E7 RID: 14311
			private static readonly IntPtr NativeFieldInfoPtr__allianceToken_5__3;

			// Token: 0x040037E8 RID: 14312
			private static readonly IntPtr NativeFieldInfoPtr__logBuilder_5__4;

			// Token: 0x040037E9 RID: 14313
			private static readonly IntPtr NativeFieldInfoPtr__playerAllianceTokenVP_5__5;

			// Token: 0x040037EA RID: 14314
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__6;

			// Token: 0x040037EB RID: 14315
			private static readonly IntPtr NativeFieldInfoPtr__takenFromPlayer_5__7;

			// Token: 0x040037EC RID: 14316
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__8;

			// Token: 0x040037ED RID: 14317
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x040037EE RID: 14318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040037EF RID: 14319
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037F0 RID: 14320
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040037F1 RID: 14321
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040037F2 RID: 14322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040037F3 RID: 14323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037F4 RID: 14324
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040037F5 RID: 14325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040037F6 RID: 14326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200067E RID: 1662
		[ObfuscatedName("worm.canis.actions.GainAlliance+<undo>d__4")]
		public sealed class _undo_d__4 : Object
		{
			// Token: 0x060055AD RID: 21933 RVA: 0x001B9FC0 File Offset: 0x001B81C0
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__4()
			{
				Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainAlliance>.NativeClassPtr, "<undo>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr);
				GainAlliance._undo_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, "<>1__state");
				GainAlliance._undo_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, "<>2__current");
				GainAlliance._undo_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, "<>l__initialThreadId");
				GainAlliance._undo_d__4.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, "undoContext");
				GainAlliance._undo_d__4.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, "<>3__undoContext");
				GainAlliance._undo_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, "<>4__this");
				GainAlliance._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, 100667811);
				GainAlliance._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, 100667812);
				GainAlliance._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, 100667813);
				GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, 100667814);
				GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, 100667815);
				GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, 100667816);
				GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, 100667817);
				GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr, 100667818);
			}

			// Token: 0x060055AE RID: 21934 RVA: 0x001BA104 File Offset: 0x001B8304
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainAlliance._undo_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055AF RID: 21935 RVA: 0x001BA14C File Offset: 0x001B834C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055B0 RID: 21936 RVA: 0x001BA180 File Offset: 0x001B8380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135682, XrefRangeEnd = 135718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001597 RID: 5527
			// (get) Token: 0x060055B1 RID: 21937 RVA: 0x001BA1BC File Offset: 0x001B83BC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060055B2 RID: 21938 RVA: 0x001BA1FC File Offset: 0x001B83FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135718, XrefRangeEnd = 135723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001598 RID: 5528
			// (get) Token: 0x060055B3 RID: 21939 RVA: 0x001BA230 File Offset: 0x001B8430
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060055B4 RID: 21940 RVA: 0x001BA270 File Offset: 0x001B8470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135723, XrefRangeEnd = 135732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060055B5 RID: 21941 RVA: 0x001BA2B0 File Offset: 0x001B84B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainAlliance._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060055B6 RID: 21942 RVA: 0x0001E932 File Offset: 0x0001CB32
			public _undo_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001591 RID: 5521
			// (get) Token: 0x060055B7 RID: 21943 RVA: 0x001BA2F0 File Offset: 0x001B84F0
			// (set) Token: 0x060055B8 RID: 21944 RVA: 0x0001E93B File Offset: 0x0001CB3B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001592 RID: 5522
			// (get) Token: 0x060055B9 RID: 21945 RVA: 0x001BA318 File Offset: 0x001B8518
			// (set) Token: 0x060055BA RID: 21946 RVA: 0x0001E956 File Offset: 0x0001CB56
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001593 RID: 5523
			// (get) Token: 0x060055BB RID: 21947 RVA: 0x001BA348 File Offset: 0x001B8548
			// (set) Token: 0x060055BC RID: 21948 RVA: 0x0001E975 File Offset: 0x0001CB75
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001594 RID: 5524
			// (get) Token: 0x060055BD RID: 21949 RVA: 0x001BA370 File Offset: 0x001B8570
			// (set) Token: 0x060055BE RID: 21950 RVA: 0x0001E990 File Offset: 0x0001CB90
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001595 RID: 5525
			// (get) Token: 0x060055BF RID: 21951 RVA: 0x001BA3A0 File Offset: 0x001B85A0
			// (set) Token: 0x060055C0 RID: 21952 RVA: 0x0001E9AF File Offset: 0x0001CBAF
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001596 RID: 5526
			// (get) Token: 0x060055C1 RID: 21953 RVA: 0x001BA3D0 File Offset: 0x001B85D0
			// (set) Token: 0x060055C2 RID: 21954 RVA: 0x0001E9CE File Offset: 0x0001CBCE
			public unsafe GainAlliance __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainAlliance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainAlliance._undo_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037F7 RID: 14327
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040037F8 RID: 14328
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040037F9 RID: 14329
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040037FA RID: 14330
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x040037FB RID: 14331
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x040037FC RID: 14332
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040037FD RID: 14333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040037FE RID: 14334
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040037FF RID: 14335
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003800 RID: 14336
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003801 RID: 14337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003802 RID: 14338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003803 RID: 14339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003804 RID: 14340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
