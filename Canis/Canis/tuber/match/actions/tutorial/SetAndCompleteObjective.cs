using System;
using Canis;
using Canis.actions;
using Canis.tutorialScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace tuber.match.actions.tutorial
{
	// Token: 0x02000016 RID: 22
	public class SetAndCompleteObjective : global::Canis.actions.Action
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0001C414 File Offset: 0x0001A614
		// Note: this type is marked as 'beforefieldinit'.
		static SetAndCompleteObjective()
		{
			Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "tuber.match.actions.tutorial", "SetAndCompleteObjective");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr);
			SetAndCompleteObjective.NativeFieldInfoPtr_objectiveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr, "objectiveID");
			SetAndCompleteObjective.NativeFieldInfoPtr_newAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr, "newAmount");
			SetAndCompleteObjective.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr, 100663398);
			SetAndCompleteObjective.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr, 100663399);
			SetAndCompleteObjective.NativeMethodInfoPtr_objectiveCompleted_Private_Boolean_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr, 100663400);
			SetAndCompleteObjective.NativeMethodInfoPtr_WrapSequence_Private_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr, 100663401);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001C4BC File Offset: 0x0001A6BC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 543530, RefRangeEnd = 543542, XrefRangeStart = 543530, XrefRangeEnd = 543542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAndCompleteObjective(int obj, int newAmount, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001C524 File Offset: 0x0001A724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543749, XrefRangeEnd = 543755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetAndCompleteObjective.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001C570 File Offset: 0x0001A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool objectiveCompleted(Il2CppStructArray<int> ids, int objID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective.NativeMethodInfoPtr_objectiveCompleted_Private_Boolean_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001C5CC File Offset: 0x0001A7CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 543776, RefRangeEnd = 543780, XrefRangeStart = 543755, XrefRangeEnd = 543776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::Canis.actions.Action WrapSequence(global::Canis.actions.Action inner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective.NativeMethodInfoPtr_WrapSequence_Private_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002643 File Offset: 0x00000843
		public SetAndCompleteObjective(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0001C61C File Offset: 0x0001A81C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000264C File Offset: 0x0000084C
		public unsafe int objectiveID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective.NativeFieldInfoPtr_objectiveID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective.NativeFieldInfoPtr_objectiveID)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0001C644 File Offset: 0x0001A844
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002667 File Offset: 0x00000867
		public unsafe int newAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective.NativeFieldInfoPtr_newAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective.NativeFieldInfoPtr_newAmount)) = value;
			}
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_objectiveID;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_newAmount;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_objectiveCompleted_Private_Boolean_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_WrapSequence_Private_Action_Action_0;

		// Token: 0x0200023D RID: 573
		[ObfuscatedName("tuber.match.actions.tutorial.SetAndCompleteObjective+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600180B RID: 6155 RVA: 0x00079374 File Offset: 0x00077574
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SetAndCompleteObjective.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAndCompleteObjective.__c__DisplayClass3_0>.NativeClassPtr);
				SetAndCompleteObjective.__c__DisplayClass3_0.NativeFieldInfoPtr_objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective.__c__DisplayClass3_0>.NativeClassPtr, "objective");
				SetAndCompleteObjective.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective.__c__DisplayClass3_0>.NativeClassPtr, 100663402);
				SetAndCompleteObjective.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective.__c__DisplayClass3_0>.NativeClassPtr, 100663403);
			}

			// Token: 0x0600180C RID: 6156 RVA: 0x000793DC File Offset: 0x000775DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAndCompleteObjective.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600180D RID: 6157 RVA: 0x00079418 File Offset: 0x00077618
			[CallerCount(0)]
			public unsafe bool _execute_b__0(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600180E RID: 6158 RVA: 0x0000B81B File Offset: 0x00009A1B
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700053B RID: 1339
			// (get) Token: 0x0600180F RID: 6159 RVA: 0x00079464 File Offset: 0x00077664
			// (set) Token: 0x06001810 RID: 6160 RVA: 0x0000B824 File Offset: 0x00009A24
			public unsafe Objective objective
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective.__c__DisplayClass3_0.NativeFieldInfoPtr_objective);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Objective>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective.__c__DisplayClass3_0.NativeFieldInfoPtr_objective), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F64 RID: 3940
			private static readonly IntPtr NativeFieldInfoPtr_objective;

			// Token: 0x04000F65 RID: 3941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F66 RID: 3942
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x0200023E RID: 574
		[ObfuscatedName("tuber.match.actions.tutorial.SetAndCompleteObjective+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06001811 RID: 6161 RVA: 0x00079494 File Offset: 0x00077694
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetAndCompleteObjective>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr);
				SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>1__state");
				SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>2__current");
				SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>4__this");
				SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>8__1");
				SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objectives_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, "<objectives>5__2");
				SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__completedObjectives_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, "<completedObjectives>5__3");
				SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663404);
				SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663405);
				SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663406);
				SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663407);
				SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663408);
				SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663409);
				SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663410);
				SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663411);
			}

			// Token: 0x06001812 RID: 6162 RVA: 0x000795EC File Offset: 0x000777EC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAndCompleteObjective._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001813 RID: 6163 RVA: 0x00079634 File Offset: 0x00077834
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x00079668 File Offset: 0x00077868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543589, XrefRangeEnd = 543742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000543 RID: 1347
			// (get) Token: 0x06001815 RID: 6165 RVA: 0x000796A4 File Offset: 0x000778A4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001816 RID: 6166 RVA: 0x000796E4 File Offset: 0x000778E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543742, XrefRangeEnd = 543747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000544 RID: 1348
			// (get) Token: 0x06001817 RID: 6167 RVA: 0x00079718 File Offset: 0x00077918
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001818 RID: 6168 RVA: 0x00079758 File Offset: 0x00077958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543747, XrefRangeEnd = 543749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001819 RID: 6169 RVA: 0x00079798 File Offset: 0x00077998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600181A RID: 6170 RVA: 0x0000B843 File Offset: 0x00009A43
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700053C RID: 1340
			// (get) Token: 0x0600181B RID: 6171 RVA: 0x000797D8 File Offset: 0x000779D8
			// (set) Token: 0x0600181C RID: 6172 RVA: 0x0000B84C File Offset: 0x00009A4C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700053D RID: 1341
			// (get) Token: 0x0600181D RID: 6173 RVA: 0x00079800 File Offset: 0x00077A00
			// (set) Token: 0x0600181E RID: 6174 RVA: 0x0000B867 File Offset: 0x00009A67
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700053E RID: 1342
			// (get) Token: 0x0600181F RID: 6175 RVA: 0x00079830 File Offset: 0x00077A30
			// (set) Token: 0x06001820 RID: 6176 RVA: 0x0000B886 File Offset: 0x00009A86
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700053F RID: 1343
			// (get) Token: 0x06001821 RID: 6177 RVA: 0x00079858 File Offset: 0x00077A58
			// (set) Token: 0x06001822 RID: 6178 RVA: 0x0000B8A1 File Offset: 0x00009AA1
			public unsafe SetAndCompleteObjective __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetAndCompleteObjective>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000540 RID: 1344
			// (get) Token: 0x06001823 RID: 6179 RVA: 0x00079888 File Offset: 0x00077A88
			// (set) Token: 0x06001824 RID: 6180 RVA: 0x0000B8C0 File Offset: 0x00009AC0
			public unsafe SetAndCompleteObjective.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetAndCompleteObjective.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000541 RID: 1345
			// (get) Token: 0x06001825 RID: 6181 RVA: 0x000798B8 File Offset: 0x00077AB8
			// (set) Token: 0x06001826 RID: 6182 RVA: 0x0000B8DF File Offset: 0x00009ADF
			public unsafe Il2CppReferenceArray<Objective> _objectives_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objectives_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Objective>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objectives_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000542 RID: 1346
			// (get) Token: 0x06001827 RID: 6183 RVA: 0x000798E8 File Offset: 0x00077AE8
			// (set) Token: 0x06001828 RID: 6184 RVA: 0x0000B8FE File Offset: 0x00009AFE
			public unsafe Il2CppStructArray<int> _completedObjectives_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__completedObjectives_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__completedObjectives_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F67 RID: 3943
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F68 RID: 3944
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F69 RID: 3945
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000F6A RID: 3946
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F6B RID: 3947
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04000F6C RID: 3948
			private static readonly IntPtr NativeFieldInfoPtr__objectives_5__2;

			// Token: 0x04000F6D RID: 3949
			private static readonly IntPtr NativeFieldInfoPtr__completedObjectives_5__3;

			// Token: 0x04000F6E RID: 3950
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F6F RID: 3951
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F70 RID: 3952
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F71 RID: 3953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04000F72 RID: 3954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F73 RID: 3955
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F74 RID: 3956
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04000F75 RID: 3957
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
