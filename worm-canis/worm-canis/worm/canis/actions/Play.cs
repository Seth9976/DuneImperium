using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using canis.archetypes;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200026E RID: 622
	public class Play : global::Canis.actions.Action
	{
		// Token: 0x06001A51 RID: 6737 RVA: 0x000BF2B4 File Offset: 0x000BD4B4
		// Note: this type is marked as 'beforefieldinit'.
		static Play()
		{
			Il2CppClassPointerStore<Play>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "Play");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Play>.NativeClassPtr);
			Play.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play>.NativeClassPtr, 100668278);
			Play.NativeMethodInfoPtr_MakeIntrigueAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play>.NativeClassPtr, 100668279);
			Play.NativeMethodInfoPtr_MakeRevealAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play>.NativeClassPtr, 100668280);
			Play.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play>.NativeClassPtr, 100668281);
			Play.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play>.NativeClassPtr, 100668282);
			Play.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play>.NativeClassPtr, 100668283);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000BF35C File Offset: 0x000BD55C
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Play(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Play>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000BF3A8 File Offset: 0x000BD5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141426, XrefRangeEnd = 141434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeIntrigueAnalyticsData(WormMatch wormMatch, WormPlayer player, WormIntriguePlayable intrigueCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(intrigueCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play.NativeMethodInfoPtr_MakeIntrigueAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x000BF41C File Offset: 0x000BD61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141434, XrefRangeEnd = 141442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeRevealAnalyticsData(WormMatch wormMatch, WormPlayer player, WormImperiumPlayable imperiumCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imperiumCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play.NativeMethodInfoPtr_MakeRevealAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x000BF490 File Offset: 0x000BD690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141442, XrefRangeEnd = 141448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Play.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x000BF4DC File Offset: 0x000BD6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141448, XrefRangeEnd = 141455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Play.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000BF538 File Offset: 0x000BD738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141455, XrefRangeEnd = 141459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Play.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0000B568 File Offset: 0x00009768
		public Play(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_MakeIntrigueAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormIntriguePlayable_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_MakeRevealAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormImperiumPlayable_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006AB RID: 1707
		[ObfuscatedName("worm.canis.actions.Play+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600599B RID: 22939 RVA: 0x001C5BA0 File Offset: 0x001C3DA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Play.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Play>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Play.__c>.NativeClassPtr);
				Play.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play.__c>.NativeClassPtr, "<>9");
				Play.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play.__c>.NativeClassPtr, "<>9__3_0");
				Play.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play.__c>.NativeClassPtr, 100668285);
				Play.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play.__c>.NativeClassPtr, 100668286);
			}

			// Token: 0x0600599C RID: 22940 RVA: 0x001C5C1C File Offset: 0x001C3E1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Play.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600599D RID: 22941 RVA: 0x001C5C58 File Offset: 0x001C3E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140566, XrefRangeEnd = 140567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__3_0(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600599E RID: 22942 RVA: 0x00020C36 File Offset: 0x0001EE36
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001701 RID: 5889
			// (get) Token: 0x0600599F RID: 22943 RVA: 0x001C5CA8 File Offset: 0x001C3EA8
			// (set) Token: 0x060059A0 RID: 22944 RVA: 0x00020C3F File Offset: 0x0001EE3F
			public unsafe static Play.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Play.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Play.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Play.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001702 RID: 5890
			// (get) Token: 0x060059A1 RID: 22945 RVA: 0x001C5CD0 File Offset: 0x001C3ED0
			// (set) Token: 0x060059A2 RID: 22946 RVA: 0x00020C51 File Offset: 0x0001EE51
			public unsafe static Func<WormAbilityDefinition, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Play.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Play.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A65 RID: 14949
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003A66 RID: 14950
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04003A67 RID: 14951
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A68 RID: 14952
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x020006AC RID: 1708
		[ObfuscatedName("worm.canis.actions.Play+<MakeIntrigueAnalyticsData>d__1")]
		public sealed class _MakeIntrigueAnalyticsData_d__1 : Object
		{
			// Token: 0x060059A3 RID: 22947 RVA: 0x001C5CF8 File Offset: 0x001C3EF8
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeIntrigueAnalyticsData_d__1()
			{
				Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Play>.NativeClassPtr, "<MakeIntrigueAnalyticsData>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr);
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "<>1__state");
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "<>2__current");
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "<>l__initialThreadId");
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_intrigueCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "intrigueCard");
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__intrigueCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "<>3__intrigueCard");
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "player");
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "<>3__player");
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "wormMatch");
				Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, "<>3__wormMatch");
				Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, 100668287);
				Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, 100668288);
				Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, 100668289);
				Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, 100668290);
				Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, 100668291);
				Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, 100668292);
				Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, 100668293);
				Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr, 100668294);
			}

			// Token: 0x060059A4 RID: 22948 RVA: 0x001C5E78 File Offset: 0x001C4078
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeIntrigueAnalyticsData_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Play._MakeIntrigueAnalyticsData_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060059A5 RID: 22949 RVA: 0x001C5EC0 File Offset: 0x001C40C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059A6 RID: 22950 RVA: 0x001C5EF4 File Offset: 0x001C40F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140567, XrefRangeEnd = 140581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700170C RID: 5900
			// (get) Token: 0x060059A7 RID: 22951 RVA: 0x001C5F30 File Offset: 0x001C4130
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060059A8 RID: 22952 RVA: 0x001C5F68 File Offset: 0x001C4168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140581, XrefRangeEnd = 140586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700170D RID: 5901
			// (get) Token: 0x060059A9 RID: 22953 RVA: 0x001C5F9C File Offset: 0x001C419C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140586, XrefRangeEnd = 140589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059AA RID: 22954 RVA: 0x001C5FDC File Offset: 0x001C41DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140589, XrefRangeEnd = 140599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x060059AB RID: 22955 RVA: 0x001C601C File Offset: 0x001C421C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeIntrigueAnalyticsData_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060059AC RID: 22956 RVA: 0x00020C63 File Offset: 0x0001EE63
			public _MakeIntrigueAnalyticsData_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001703 RID: 5891
			// (get) Token: 0x060059AD RID: 22957 RVA: 0x001C605C File Offset: 0x001C425C
			// (set) Token: 0x060059AE RID: 22958 RVA: 0x00020C6C File Offset: 0x0001EE6C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001704 RID: 5892
			// (get) Token: 0x060059AF RID: 22959 RVA: 0x001C6084 File Offset: 0x001C4284
			// (set) Token: 0x060059B0 RID: 22960 RVA: 0x00020C87 File Offset: 0x0001EE87
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001705 RID: 5893
			// (get) Token: 0x060059B1 RID: 22961 RVA: 0x001C60B4 File Offset: 0x001C42B4
			// (set) Token: 0x060059B2 RID: 22962 RVA: 0x00020CB5 File Offset: 0x0001EEB5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001706 RID: 5894
			// (get) Token: 0x060059B3 RID: 22963 RVA: 0x001C60DC File Offset: 0x001C42DC
			// (set) Token: 0x060059B4 RID: 22964 RVA: 0x00020CD0 File Offset: 0x0001EED0
			public unsafe WormIntriguePlayable intrigueCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_intrigueCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_intrigueCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001707 RID: 5895
			// (get) Token: 0x060059B5 RID: 22965 RVA: 0x001C610C File Offset: 0x001C430C
			// (set) Token: 0x060059B6 RID: 22966 RVA: 0x00020CEF File Offset: 0x0001EEEF
			public unsafe WormIntriguePlayable __3__intrigueCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__intrigueCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__intrigueCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001708 RID: 5896
			// (get) Token: 0x060059B7 RID: 22967 RVA: 0x001C613C File Offset: 0x001C433C
			// (set) Token: 0x060059B8 RID: 22968 RVA: 0x00020D0E File Offset: 0x0001EF0E
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001709 RID: 5897
			// (get) Token: 0x060059B9 RID: 22969 RVA: 0x001C616C File Offset: 0x001C436C
			// (set) Token: 0x060059BA RID: 22970 RVA: 0x00020D2D File Offset: 0x0001EF2D
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700170A RID: 5898
			// (get) Token: 0x060059BB RID: 22971 RVA: 0x001C619C File Offset: 0x001C439C
			// (set) Token: 0x060059BC RID: 22972 RVA: 0x00020D4C File Offset: 0x0001EF4C
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700170B RID: 5899
			// (get) Token: 0x060059BD RID: 22973 RVA: 0x001C61CC File Offset: 0x001C43CC
			// (set) Token: 0x060059BE RID: 22974 RVA: 0x00020D6B File Offset: 0x0001EF6B
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeIntrigueAnalyticsData_d__1.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A69 RID: 14953
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A6A RID: 14954
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A6B RID: 14955
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003A6C RID: 14956
			private static readonly IntPtr NativeFieldInfoPtr_intrigueCard;

			// Token: 0x04003A6D RID: 14957
			private static readonly IntPtr NativeFieldInfoPtr___3__intrigueCard;

			// Token: 0x04003A6E RID: 14958
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003A6F RID: 14959
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04003A70 RID: 14960
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003A71 RID: 14961
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003A72 RID: 14962
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003A73 RID: 14963
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A74 RID: 14964
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A75 RID: 14965
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04003A76 RID: 14966
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A77 RID: 14967
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A78 RID: 14968
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04003A79 RID: 14969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006AD RID: 1709
		[ObfuscatedName("worm.canis.actions.Play+<MakeRevealAnalyticsData>d__2")]
		public sealed class _MakeRevealAnalyticsData_d__2 : Object
		{
			// Token: 0x060059BF RID: 22975 RVA: 0x001C61FC File Offset: 0x001C43FC
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeRevealAnalyticsData_d__2()
			{
				Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Play>.NativeClassPtr, "<MakeRevealAnalyticsData>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr);
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "<>1__state");
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "<>2__current");
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "<>l__initialThreadId");
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_imperiumCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "imperiumCard");
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__imperiumCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "<>3__imperiumCard");
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "player");
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "<>3__player");
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "wormMatch");
				Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, "<>3__wormMatch");
				Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, 100668295);
				Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, 100668296);
				Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, 100668297);
				Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, 100668298);
				Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, 100668299);
				Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, 100668300);
				Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, 100668301);
				Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr, 100668302);
			}

			// Token: 0x060059C0 RID: 22976 RVA: 0x001C637C File Offset: 0x001C457C
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeRevealAnalyticsData_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Play._MakeRevealAnalyticsData_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060059C1 RID: 22977 RVA: 0x001C63C4 File Offset: 0x001C45C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059C2 RID: 22978 RVA: 0x001C63F8 File Offset: 0x001C45F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140599, XrefRangeEnd = 140611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001717 RID: 5911
			// (get) Token: 0x060059C3 RID: 22979 RVA: 0x001C6434 File Offset: 0x001C4634
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060059C4 RID: 22980 RVA: 0x001C646C File Offset: 0x001C466C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140611, XrefRangeEnd = 140616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001718 RID: 5912
			// (get) Token: 0x060059C5 RID: 22981 RVA: 0x001C64A0 File Offset: 0x001C46A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140616, XrefRangeEnd = 140619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059C6 RID: 22982 RVA: 0x001C64E0 File Offset: 0x001C46E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140619, XrefRangeEnd = 140629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x060059C7 RID: 22983 RVA: 0x001C6520 File Offset: 0x001C4720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._MakeRevealAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060059C8 RID: 22984 RVA: 0x00020D8A File Offset: 0x0001EF8A
			public _MakeRevealAnalyticsData_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700170E RID: 5902
			// (get) Token: 0x060059C9 RID: 22985 RVA: 0x001C6560 File Offset: 0x001C4760
			// (set) Token: 0x060059CA RID: 22986 RVA: 0x00020D93 File Offset: 0x0001EF93
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700170F RID: 5903
			// (get) Token: 0x060059CB RID: 22987 RVA: 0x001C6588 File Offset: 0x001C4788
			// (set) Token: 0x060059CC RID: 22988 RVA: 0x00020DAE File Offset: 0x0001EFAE
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001710 RID: 5904
			// (get) Token: 0x060059CD RID: 22989 RVA: 0x001C65B8 File Offset: 0x001C47B8
			// (set) Token: 0x060059CE RID: 22990 RVA: 0x00020DDC File Offset: 0x0001EFDC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001711 RID: 5905
			// (get) Token: 0x060059CF RID: 22991 RVA: 0x001C65E0 File Offset: 0x001C47E0
			// (set) Token: 0x060059D0 RID: 22992 RVA: 0x00020DF7 File Offset: 0x0001EFF7
			public unsafe WormImperiumPlayable imperiumCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_imperiumCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_imperiumCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001712 RID: 5906
			// (get) Token: 0x060059D1 RID: 22993 RVA: 0x001C6610 File Offset: 0x001C4810
			// (set) Token: 0x060059D2 RID: 22994 RVA: 0x00020E16 File Offset: 0x0001F016
			public unsafe WormImperiumPlayable __3__imperiumCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__imperiumCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__imperiumCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001713 RID: 5907
			// (get) Token: 0x060059D3 RID: 22995 RVA: 0x001C6640 File Offset: 0x001C4840
			// (set) Token: 0x060059D4 RID: 22996 RVA: 0x00020E35 File Offset: 0x0001F035
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001714 RID: 5908
			// (get) Token: 0x060059D5 RID: 22997 RVA: 0x001C6670 File Offset: 0x001C4870
			// (set) Token: 0x060059D6 RID: 22998 RVA: 0x00020E54 File Offset: 0x0001F054
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001715 RID: 5909
			// (get) Token: 0x060059D7 RID: 22999 RVA: 0x001C66A0 File Offset: 0x001C48A0
			// (set) Token: 0x060059D8 RID: 23000 RVA: 0x00020E73 File Offset: 0x0001F073
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001716 RID: 5910
			// (get) Token: 0x060059D9 RID: 23001 RVA: 0x001C66D0 File Offset: 0x001C48D0
			// (set) Token: 0x060059DA RID: 23002 RVA: 0x00020E92 File Offset: 0x0001F092
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._MakeRevealAnalyticsData_d__2.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A7A RID: 14970
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A7B RID: 14971
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A7C RID: 14972
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003A7D RID: 14973
			private static readonly IntPtr NativeFieldInfoPtr_imperiumCard;

			// Token: 0x04003A7E RID: 14974
			private static readonly IntPtr NativeFieldInfoPtr___3__imperiumCard;

			// Token: 0x04003A7F RID: 14975
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003A80 RID: 14976
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04003A81 RID: 14977
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003A82 RID: 14978
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003A83 RID: 14979
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003A84 RID: 14980
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A85 RID: 14981
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A86 RID: 14982
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04003A87 RID: 14983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A88 RID: 14984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A89 RID: 14985
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04003A8A RID: 14986
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006AE RID: 1710
		[ObfuscatedName("worm.canis.actions.Play+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x060059DB RID: 23003 RVA: 0x001C6700 File Offset: 0x001C4900
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Play>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr);
				Play._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<>1__state");
				Play._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<>2__current");
				Play._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				Play._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<>4__this");
				Play._execute_d__3.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<player>5__2");
				Play._execute_d__3.NativeFieldInfoPtr__card_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<card>5__3");
				Play._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<wormMatch>5__4");
				Play._execute_d__3.NativeFieldInfoPtr__graftedCard_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<graftedCard>5__5");
				Play._execute_d__3.NativeFieldInfoPtr__graftedOrigin_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<graftedOrigin>5__6");
				Play._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<sequenceHelper>5__7");
				Play._execute_d__3.NativeFieldInfoPtr__spaceID_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<spaceID>5__8");
				Play._execute_d__3.NativeFieldInfoPtr__origin_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<origin>5__9");
				Play._execute_d__3.NativeFieldInfoPtr__moveAction_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<moveAction>5__10");
				Play._execute_d__3.NativeFieldInfoPtr__childUndo_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, "<childUndo>5__11");
				Play._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, 100668303);
				Play._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, 100668304);
				Play._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, 100668305);
				Play._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, 100668306);
				Play._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, 100668307);
				Play._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, 100668308);
				Play._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, 100668309);
				Play._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr, 100668310);
			}

			// Token: 0x060059DC RID: 23004 RVA: 0x001C68E4 File Offset: 0x001C4AE4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Play._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060059DD RID: 23005 RVA: 0x001C692C File Offset: 0x001C4B2C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059DE RID: 23006 RVA: 0x001C6960 File Offset: 0x001C4B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140629, XrefRangeEnd = 141146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001727 RID: 5927
			// (get) Token: 0x060059DF RID: 23007 RVA: 0x001C699C File Offset: 0x001C4B9C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060059E0 RID: 23008 RVA: 0x001C69DC File Offset: 0x001C4BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141146, XrefRangeEnd = 141151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001728 RID: 5928
			// (get) Token: 0x060059E1 RID: 23009 RVA: 0x001C6A10 File Offset: 0x001C4C10
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059E2 RID: 23010 RVA: 0x001C6A50 File Offset: 0x001C4C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141151, XrefRangeEnd = 141153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060059E3 RID: 23011 RVA: 0x001C6A90 File Offset: 0x001C4C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060059E4 RID: 23012 RVA: 0x00020EB1 File Offset: 0x0001F0B1
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001719 RID: 5913
			// (get) Token: 0x060059E5 RID: 23013 RVA: 0x001C6AD0 File Offset: 0x001C4CD0
			// (set) Token: 0x060059E6 RID: 23014 RVA: 0x00020EBA File Offset: 0x0001F0BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700171A RID: 5914
			// (get) Token: 0x060059E7 RID: 23015 RVA: 0x001C6AF8 File Offset: 0x001C4CF8
			// (set) Token: 0x060059E8 RID: 23016 RVA: 0x00020ED5 File Offset: 0x0001F0D5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700171B RID: 5915
			// (get) Token: 0x060059E9 RID: 23017 RVA: 0x001C6B28 File Offset: 0x001C4D28
			// (set) Token: 0x060059EA RID: 23018 RVA: 0x00020EF4 File Offset: 0x0001F0F4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700171C RID: 5916
			// (get) Token: 0x060059EB RID: 23019 RVA: 0x001C6B50 File Offset: 0x001C4D50
			// (set) Token: 0x060059EC RID: 23020 RVA: 0x00020F0F File Offset: 0x0001F10F
			public unsafe Play __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Play>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700171D RID: 5917
			// (get) Token: 0x060059ED RID: 23021 RVA: 0x001C6B80 File Offset: 0x001C4D80
			// (set) Token: 0x060059EE RID: 23022 RVA: 0x00020F2E File Offset: 0x0001F12E
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700171E RID: 5918
			// (get) Token: 0x060059EF RID: 23023 RVA: 0x001C6BB0 File Offset: 0x001C4DB0
			// (set) Token: 0x060059F0 RID: 23024 RVA: 0x00020F4D File Offset: 0x0001F14D
			public unsafe WormPlayable _card_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__card_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__card_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700171F RID: 5919
			// (get) Token: 0x060059F1 RID: 23025 RVA: 0x001C6BE0 File Offset: 0x001C4DE0
			// (set) Token: 0x060059F2 RID: 23026 RVA: 0x00020F6C File Offset: 0x0001F16C
			public unsafe WormMatch _wormMatch_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001720 RID: 5920
			// (get) Token: 0x060059F3 RID: 23027 RVA: 0x001C6C10 File Offset: 0x001C4E10
			// (set) Token: 0x060059F4 RID: 23028 RVA: 0x00020F8B File Offset: 0x0001F18B
			public unsafe WormImperiumPlayable _graftedCard_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__graftedCard_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__graftedCard_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001721 RID: 5921
			// (get) Token: 0x060059F5 RID: 23029 RVA: 0x001C6C40 File Offset: 0x001C4E40
			// (set) Token: 0x060059F6 RID: 23030 RVA: 0x00020FAA File Offset: 0x0001F1AA
			public unsafe Entity _graftedOrigin_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__graftedOrigin_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__graftedOrigin_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001722 RID: 5922
			// (get) Token: 0x060059F7 RID: 23031 RVA: 0x001C6C70 File Offset: 0x001C4E70
			// (set) Token: 0x060059F8 RID: 23032 RVA: 0x00020FC9 File Offset: 0x0001F1C9
			public unsafe SequenceHelper _sequenceHelper_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001723 RID: 5923
			// (get) Token: 0x060059F9 RID: 23033 RVA: 0x001C6CA0 File Offset: 0x001C4EA0
			// (set) Token: 0x060059FA RID: 23034 RVA: 0x00020FE8 File Offset: 0x0001F1E8
			public unsafe ArchetypeID _spaceID_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__spaceID_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__spaceID_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001724 RID: 5924
			// (get) Token: 0x060059FB RID: 23035 RVA: 0x001C6CD0 File Offset: 0x001C4ED0
			// (set) Token: 0x060059FC RID: 23036 RVA: 0x00021007 File Offset: 0x0001F207
			public unsafe Entity _origin_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__origin_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__origin_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001725 RID: 5925
			// (get) Token: 0x060059FD RID: 23037 RVA: 0x001C6D00 File Offset: 0x001C4F00
			// (set) Token: 0x060059FE RID: 23038 RVA: 0x00021026 File Offset: 0x0001F226
			public unsafe Move _moveAction_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__moveAction_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Move>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__moveAction_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001726 RID: 5926
			// (get) Token: 0x060059FF RID: 23039 RVA: 0x001C6D30 File Offset: 0x001C4F30
			// (set) Token: 0x06005A00 RID: 23040 RVA: 0x00021045 File Offset: 0x0001F245
			public unsafe UndoNode _childUndo_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__childUndo_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._execute_d__3.NativeFieldInfoPtr__childUndo_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A8B RID: 14987
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A8C RID: 14988
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A8D RID: 14989
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003A8E RID: 14990
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003A8F RID: 14991
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003A90 RID: 14992
			private static readonly IntPtr NativeFieldInfoPtr__card_5__3;

			// Token: 0x04003A91 RID: 14993
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__4;

			// Token: 0x04003A92 RID: 14994
			private static readonly IntPtr NativeFieldInfoPtr__graftedCard_5__5;

			// Token: 0x04003A93 RID: 14995
			private static readonly IntPtr NativeFieldInfoPtr__graftedOrigin_5__6;

			// Token: 0x04003A94 RID: 14996
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__7;

			// Token: 0x04003A95 RID: 14997
			private static readonly IntPtr NativeFieldInfoPtr__spaceID_5__8;

			// Token: 0x04003A96 RID: 14998
			private static readonly IntPtr NativeFieldInfoPtr__origin_5__9;

			// Token: 0x04003A97 RID: 14999
			private static readonly IntPtr NativeFieldInfoPtr__moveAction_5__10;

			// Token: 0x04003A98 RID: 15000
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__11;

			// Token: 0x04003A99 RID: 15001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003A9A RID: 15002
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A9B RID: 15003
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A9C RID: 15004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003A9D RID: 15005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A9E RID: 15006
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A9F RID: 15007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003AA0 RID: 15008
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006AF RID: 1711
		[ObfuscatedName("worm.canis.actions.Play+<undo>d__4")]
		public sealed class _undo_d__4 : Object
		{
			// Token: 0x06005A01 RID: 23041 RVA: 0x001C6D60 File Offset: 0x001C4F60
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__4()
			{
				Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Play>.NativeClassPtr, "<undo>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr);
				Play._undo_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<>1__state");
				Play._undo_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<>2__current");
				Play._undo_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<>l__initialThreadId");
				Play._undo_d__4.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "undoContext");
				Play._undo_d__4.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<>3__undoContext");
				Play._undo_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<>4__this");
				Play._undo_d__4.NativeFieldInfoPtr__undoNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<undoNode>5__2");
				Play._undo_d__4.NativeFieldInfoPtr__origin_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<origin>5__3");
				Play._undo_d__4.NativeFieldInfoPtr__card_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<card>5__4");
				Play._undo_d__4.NativeFieldInfoPtr__player_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<player>5__5");
				Play._undo_d__4.NativeFieldInfoPtr__sequenceHelper_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<sequenceHelper>5__6");
				Play._undo_d__4.NativeFieldInfoPtr__turnPhase_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<turnPhase>5__7");
				Play._undo_d__4.NativeFieldInfoPtr__cardArchetype_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<cardArchetype>5__8");
				Play._undo_d__4.NativeFieldInfoPtr__tleilaxuAgent_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<tleilaxuAgent>5__9");
				Play._undo_d__4.NativeFieldInfoPtr__agentCard_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<agentCard>5__10");
				Play._undo_d__4.NativeFieldInfoPtr__conditionalIcons_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<conditionalIcons>5__11");
				Play._undo_d__4.NativeFieldInfoPtr__graftedCard_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, "<graftedCard>5__12");
				Play._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, 100668311);
				Play._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, 100668312);
				Play._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, 100668313);
				Play._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, 100668314);
				Play._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, 100668315);
				Play._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, 100668316);
				Play._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, 100668317);
				Play._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr, 100668318);
			}

			// Token: 0x06005A02 RID: 23042 RVA: 0x001C6F80 File Offset: 0x001C5180
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Play._undo_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005A03 RID: 23043 RVA: 0x001C6FC8 File Offset: 0x001C51C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A04 RID: 23044 RVA: 0x001C6FFC File Offset: 0x001C51FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141153, XrefRangeEnd = 141412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700173A RID: 5946
			// (get) Token: 0x06005A05 RID: 23045 RVA: 0x001C7038 File Offset: 0x001C5238
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005A06 RID: 23046 RVA: 0x001C7078 File Offset: 0x001C5278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141412, XrefRangeEnd = 141417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700173B RID: 5947
			// (get) Token: 0x06005A07 RID: 23047 RVA: 0x001C70AC File Offset: 0x001C52AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A08 RID: 23048 RVA: 0x001C70EC File Offset: 0x001C52EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141417, XrefRangeEnd = 141426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005A09 RID: 23049 RVA: 0x001C712C File Offset: 0x001C532C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Play._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005A0A RID: 23050 RVA: 0x00021064 File Offset: 0x0001F264
			public _undo_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001729 RID: 5929
			// (get) Token: 0x06005A0B RID: 23051 RVA: 0x001C716C File Offset: 0x001C536C
			// (set) Token: 0x06005A0C RID: 23052 RVA: 0x0002106D File Offset: 0x0001F26D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700172A RID: 5930
			// (get) Token: 0x06005A0D RID: 23053 RVA: 0x001C7194 File Offset: 0x001C5394
			// (set) Token: 0x06005A0E RID: 23054 RVA: 0x00021088 File Offset: 0x0001F288
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700172B RID: 5931
			// (get) Token: 0x06005A0F RID: 23055 RVA: 0x001C71C4 File Offset: 0x001C53C4
			// (set) Token: 0x06005A10 RID: 23056 RVA: 0x000210A7 File Offset: 0x0001F2A7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700172C RID: 5932
			// (get) Token: 0x06005A11 RID: 23057 RVA: 0x001C71EC File Offset: 0x001C53EC
			// (set) Token: 0x06005A12 RID: 23058 RVA: 0x000210C2 File Offset: 0x0001F2C2
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700172D RID: 5933
			// (get) Token: 0x06005A13 RID: 23059 RVA: 0x001C721C File Offset: 0x001C541C
			// (set) Token: 0x06005A14 RID: 23060 RVA: 0x000210E1 File Offset: 0x0001F2E1
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700172E RID: 5934
			// (get) Token: 0x06005A15 RID: 23061 RVA: 0x001C724C File Offset: 0x001C544C
			// (set) Token: 0x06005A16 RID: 23062 RVA: 0x00021100 File Offset: 0x0001F300
			public unsafe Play __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Play>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700172F RID: 5935
			// (get) Token: 0x06005A17 RID: 23063 RVA: 0x001C727C File Offset: 0x001C547C
			// (set) Token: 0x06005A18 RID: 23064 RVA: 0x0002111F File Offset: 0x0001F31F
			public unsafe UndoNode _undoNode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__undoNode_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__undoNode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001730 RID: 5936
			// (get) Token: 0x06005A19 RID: 23065 RVA: 0x001C72AC File Offset: 0x001C54AC
			// (set) Token: 0x06005A1A RID: 23066 RVA: 0x0002113E File Offset: 0x0001F33E
			public unsafe Entity _origin_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__origin_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__origin_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001731 RID: 5937
			// (get) Token: 0x06005A1B RID: 23067 RVA: 0x001C72DC File Offset: 0x001C54DC
			// (set) Token: 0x06005A1C RID: 23068 RVA: 0x0002115D File Offset: 0x0001F35D
			public unsafe WormPlayable _card_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__card_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__card_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001732 RID: 5938
			// (get) Token: 0x06005A1D RID: 23069 RVA: 0x001C730C File Offset: 0x001C550C
			// (set) Token: 0x06005A1E RID: 23070 RVA: 0x0002117C File Offset: 0x0001F37C
			public unsafe WormPlayer _player_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__player_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__player_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001733 RID: 5939
			// (get) Token: 0x06005A1F RID: 23071 RVA: 0x001C733C File Offset: 0x001C553C
			// (set) Token: 0x06005A20 RID: 23072 RVA: 0x0002119B File Offset: 0x0001F39B
			public unsafe SequenceHelper _sequenceHelper_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__sequenceHelper_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__sequenceHelper_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001734 RID: 5940
			// (get) Token: 0x06005A21 RID: 23073 RVA: 0x001C736C File Offset: 0x001C556C
			// (set) Token: 0x06005A22 RID: 23074 RVA: 0x000211BA File Offset: 0x0001F3BA
			public unsafe PlayerTurnTypes _turnPhase_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__turnPhase_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__turnPhase_5__7)) = value;
				}
			}

			// Token: 0x17001735 RID: 5941
			// (get) Token: 0x06005A23 RID: 23075 RVA: 0x001C7394 File Offset: 0x001C5594
			// (set) Token: 0x06005A24 RID: 23076 RVA: 0x000211D5 File Offset: 0x0001F3D5
			public unsafe Archetype _cardArchetype_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__cardArchetype_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__cardArchetype_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001736 RID: 5942
			// (get) Token: 0x06005A25 RID: 23077 RVA: 0x001C73C4 File Offset: 0x001C55C4
			// (set) Token: 0x06005A26 RID: 23078 RVA: 0x000211F4 File Offset: 0x0001F3F4
			public unsafe bool _tleilaxuAgent_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__tleilaxuAgent_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__tleilaxuAgent_5__9)) = value;
				}
			}

			// Token: 0x17001737 RID: 5943
			// (get) Token: 0x06005A27 RID: 23079 RVA: 0x001C73EC File Offset: 0x001C55EC
			// (set) Token: 0x06005A28 RID: 23080 RVA: 0x0002120F File Offset: 0x0001F40F
			public unsafe WormImperiumPlayable _agentCard_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__agentCard_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__agentCard_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001738 RID: 5944
			// (get) Token: 0x06005A29 RID: 23081 RVA: 0x001C741C File Offset: 0x001C561C
			// (set) Token: 0x06005A2A RID: 23082 RVA: 0x0002122E File Offset: 0x0001F42E
			public unsafe bool _conditionalIcons_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__conditionalIcons_5__11);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__conditionalIcons_5__11)) = value;
				}
			}

			// Token: 0x17001739 RID: 5945
			// (get) Token: 0x06005A2B RID: 23083 RVA: 0x001C7444 File Offset: 0x001C5644
			// (set) Token: 0x06005A2C RID: 23084 RVA: 0x00021249 File Offset: 0x0001F449
			public unsafe WormImperiumPlayable _graftedCard_5__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__graftedCard_5__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Play._undo_d__4.NativeFieldInfoPtr__graftedCard_5__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003AA1 RID: 15009
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003AA2 RID: 15010
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003AA3 RID: 15011
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003AA4 RID: 15012
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003AA5 RID: 15013
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003AA6 RID: 15014
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003AA7 RID: 15015
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__2;

			// Token: 0x04003AA8 RID: 15016
			private static readonly IntPtr NativeFieldInfoPtr__origin_5__3;

			// Token: 0x04003AA9 RID: 15017
			private static readonly IntPtr NativeFieldInfoPtr__card_5__4;

			// Token: 0x04003AAA RID: 15018
			private static readonly IntPtr NativeFieldInfoPtr__player_5__5;

			// Token: 0x04003AAB RID: 15019
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__6;

			// Token: 0x04003AAC RID: 15020
			private static readonly IntPtr NativeFieldInfoPtr__turnPhase_5__7;

			// Token: 0x04003AAD RID: 15021
			private static readonly IntPtr NativeFieldInfoPtr__cardArchetype_5__8;

			// Token: 0x04003AAE RID: 15022
			private static readonly IntPtr NativeFieldInfoPtr__tleilaxuAgent_5__9;

			// Token: 0x04003AAF RID: 15023
			private static readonly IntPtr NativeFieldInfoPtr__agentCard_5__10;

			// Token: 0x04003AB0 RID: 15024
			private static readonly IntPtr NativeFieldInfoPtr__conditionalIcons_5__11;

			// Token: 0x04003AB1 RID: 15025
			private static readonly IntPtr NativeFieldInfoPtr__graftedCard_5__12;

			// Token: 0x04003AB2 RID: 15026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003AB3 RID: 15027
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003AB4 RID: 15028
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003AB5 RID: 15029
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003AB6 RID: 15030
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003AB7 RID: 15031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003AB8 RID: 15032
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003AB9 RID: 15033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
