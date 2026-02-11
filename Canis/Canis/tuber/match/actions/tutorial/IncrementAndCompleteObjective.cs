using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
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
	// Token: 0x02000014 RID: 20
	public class IncrementAndCompleteObjective : global::Canis.actions.Action
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0001BF74 File Offset: 0x0001A174
		// Note: this type is marked as 'beforefieldinit'.
		static IncrementAndCompleteObjective()
		{
			Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "tuber.match.actions.tutorial", "IncrementAndCompleteObjective");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr);
			IncrementAndCompleteObjective.NativeFieldInfoPtr_objectiveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, "objectiveID");
			IncrementAndCompleteObjective.NativeFieldInfoPtr_incrementAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, "incrementAmount");
			IncrementAndCompleteObjective.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, 100663371);
			IncrementAndCompleteObjective.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, 100663372);
			IncrementAndCompleteObjective.NativeMethodInfoPtr_objectiveCompleted_Private_Boolean_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, 100663373);
			IncrementAndCompleteObjective.NativeMethodInfoPtr_WrapSequence_Private_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, 100663374);
			IncrementAndCompleteObjective.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, 100663375);
			IncrementAndCompleteObjective.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, 100663376);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0001C044 File Offset: 0x0001A244
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 543530, RefRangeEnd = 543542, XrefRangeStart = 543529, XrefRangeEnd = 543530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncrementAndCompleteObjective(int obj, int incrementAmount, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref incrementAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543542, XrefRangeEnd = 543548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementAndCompleteObjective.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543548, XrefRangeEnd = 543549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective.NativeMethodInfoPtr_objectiveCompleted_Private_Boolean_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0001C154 File Offset: 0x0001A354
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 543570, RefRangeEnd = 543574, XrefRangeStart = 543549, XrefRangeEnd = 543570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::Canis.actions.Action WrapSequence(global::Canis.actions.Action inner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective.NativeMethodInfoPtr_WrapSequence_Private_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543574, XrefRangeEnd = 543581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementAndCompleteObjective.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0001C200 File Offset: 0x0001A400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543581, XrefRangeEnd = 543585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementAndCompleteObjective.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000025C5 File Offset: 0x000007C5
		public IncrementAndCompleteObjective(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0001C25C File Offset: 0x0001A45C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000025CE File Offset: 0x000007CE
		public unsafe int objectiveID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective.NativeFieldInfoPtr_objectiveID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective.NativeFieldInfoPtr_objectiveID)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0001C284 File Offset: 0x0001A484
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000025E9 File Offset: 0x000007E9
		public unsafe int incrementAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective.NativeFieldInfoPtr_incrementAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective.NativeFieldInfoPtr_incrementAmount)) = value;
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_objectiveID;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_incrementAmount;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_objectiveCompleted_Private_Boolean_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_WrapSequence_Private_Action_Action_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200023A RID: 570
		[ObfuscatedName("tuber.match.actions.tutorial.IncrementAndCompleteObjective+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060017CA RID: 6090 RVA: 0x000787B4 File Offset: 0x000769B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<IncrementAndCompleteObjective.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementAndCompleteObjective.__c__DisplayClass6_0>.NativeClassPtr);
				IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeFieldInfoPtr_objectiveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective.__c__DisplayClass6_0>.NativeClassPtr, "objectiveID");
				IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective.__c__DisplayClass6_0>.NativeClassPtr, 100663377);
				IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeMethodInfoPtr__undo_b__0_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective.__c__DisplayClass6_0>.NativeClassPtr, 100663378);
				IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeMethodInfoPtr__undo_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective.__c__DisplayClass6_0>.NativeClassPtr, 100663379);
			}

			// Token: 0x060017CB RID: 6091 RVA: 0x00078830 File Offset: 0x00076A30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementAndCompleteObjective.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017CC RID: 6092 RVA: 0x0007886C File Offset: 0x00076A6C
			[CallerCount(0)]
			public unsafe bool _undo_b__0(Objective _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeMethodInfoPtr__undo_b__0_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017CD RID: 6093 RVA: 0x000788BC File Offset: 0x00076ABC
			[CallerCount(0)]
			public unsafe bool _undo_b__1(int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeMethodInfoPtr__undo_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017CE RID: 6094 RVA: 0x0000B5B4 File Offset: 0x000097B4
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000523 RID: 1315
			// (get) Token: 0x060017CF RID: 6095 RVA: 0x00078908 File Offset: 0x00076B08
			// (set) Token: 0x060017D0 RID: 6096 RVA: 0x0000B5BD File Offset: 0x000097BD
			public unsafe int objectiveID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeFieldInfoPtr_objectiveID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective.__c__DisplayClass6_0.NativeFieldInfoPtr_objectiveID)) = value;
				}
			}

			// Token: 0x04000F3D RID: 3901
			private static readonly IntPtr NativeFieldInfoPtr_objectiveID;

			// Token: 0x04000F3E RID: 3902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F3F RID: 3903
			private static readonly IntPtr NativeMethodInfoPtr__undo_b__0_Internal_Boolean_Objective_0;

			// Token: 0x04000F40 RID: 3904
			private static readonly IntPtr NativeMethodInfoPtr__undo_b__1_Internal_Boolean_Int32_0;
		}

		// Token: 0x0200023B RID: 571
		[ObfuscatedName("tuber.match.actions.tutorial.IncrementAndCompleteObjective+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x060017D1 RID: 6097 RVA: 0x00078930 File Offset: 0x00076B30
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr);
				IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>1__state");
				IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>2__current");
				IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, "<>4__this");
				IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objectives_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, "<objectives>5__2");
				IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__completedObjectives_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, "<completedObjectives>5__3");
				IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objective_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, "<objective>5__4");
				IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__amt_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, "<amt>5__5");
				IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663380);
				IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663381);
				IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663382);
				IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663383);
				IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663384);
				IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663385);
				IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663386);
				IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr, 100663387);
			}

			// Token: 0x060017D2 RID: 6098 RVA: 0x00078A9C File Offset: 0x00076C9C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementAndCompleteObjective._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017D3 RID: 6099 RVA: 0x00078AE4 File Offset: 0x00076CE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017D4 RID: 6100 RVA: 0x00078B18 File Offset: 0x00076D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543303, XrefRangeEnd = 543453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700052C RID: 1324
			// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00078B54 File Offset: 0x00076D54
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060017D6 RID: 6102 RVA: 0x00078B94 File Offset: 0x00076D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543453, XrefRangeEnd = 543458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700052D RID: 1325
			// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00078BC8 File Offset: 0x00076DC8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017D8 RID: 6104 RVA: 0x00078C08 File Offset: 0x00076E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543458, XrefRangeEnd = 543460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060017D9 RID: 6105 RVA: 0x00078C48 File Offset: 0x00076E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060017DA RID: 6106 RVA: 0x0000B5D8 File Offset: 0x000097D8
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000524 RID: 1316
			// (get) Token: 0x060017DB RID: 6107 RVA: 0x00078C88 File Offset: 0x00076E88
			// (set) Token: 0x060017DC RID: 6108 RVA: 0x0000B5E1 File Offset: 0x000097E1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000525 RID: 1317
			// (get) Token: 0x060017DD RID: 6109 RVA: 0x00078CB0 File Offset: 0x00076EB0
			// (set) Token: 0x060017DE RID: 6110 RVA: 0x0000B5FC File Offset: 0x000097FC
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000526 RID: 1318
			// (get) Token: 0x060017DF RID: 6111 RVA: 0x00078CE0 File Offset: 0x00076EE0
			// (set) Token: 0x060017E0 RID: 6112 RVA: 0x0000B61B File Offset: 0x0000981B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000527 RID: 1319
			// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00078D08 File Offset: 0x00076F08
			// (set) Token: 0x060017E2 RID: 6114 RVA: 0x0000B636 File Offset: 0x00009836
			public unsafe IncrementAndCompleteObjective __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncrementAndCompleteObjective>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000528 RID: 1320
			// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00078D38 File Offset: 0x00076F38
			// (set) Token: 0x060017E4 RID: 6116 RVA: 0x0000B655 File Offset: 0x00009855
			public unsafe Il2CppReferenceArray<Objective> _objectives_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objectives_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Objective>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objectives_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000529 RID: 1321
			// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00078D68 File Offset: 0x00076F68
			// (set) Token: 0x060017E6 RID: 6118 RVA: 0x0000B674 File Offset: 0x00009874
			public unsafe Il2CppStructArray<int> _completedObjectives_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__completedObjectives_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__completedObjectives_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700052A RID: 1322
			// (get) Token: 0x060017E7 RID: 6119 RVA: 0x00078D98 File Offset: 0x00076F98
			// (set) Token: 0x060017E8 RID: 6120 RVA: 0x0000B693 File Offset: 0x00009893
			public unsafe Objective _objective_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objective_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Objective>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__objective_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700052B RID: 1323
			// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00078DC8 File Offset: 0x00076FC8
			// (set) Token: 0x060017EA RID: 6122 RVA: 0x0000B6B2 File Offset: 0x000098B2
			public unsafe int _amt_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__amt_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._execute_d__3.NativeFieldInfoPtr__amt_5__5)) = value;
				}
			}

			// Token: 0x04000F41 RID: 3905
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F42 RID: 3906
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F43 RID: 3907
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000F44 RID: 3908
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F45 RID: 3909
			private static readonly IntPtr NativeFieldInfoPtr__objectives_5__2;

			// Token: 0x04000F46 RID: 3910
			private static readonly IntPtr NativeFieldInfoPtr__completedObjectives_5__3;

			// Token: 0x04000F47 RID: 3911
			private static readonly IntPtr NativeFieldInfoPtr__objective_5__4;

			// Token: 0x04000F48 RID: 3912
			private static readonly IntPtr NativeFieldInfoPtr__amt_5__5;

			// Token: 0x04000F49 RID: 3913
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F4A RID: 3914
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F4B RID: 3915
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F4C RID: 3916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04000F4D RID: 3917
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F4E RID: 3918
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F4F RID: 3919
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04000F50 RID: 3920
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200023C RID: 572
		[ObfuscatedName("tuber.match.actions.tutorial.IncrementAndCompleteObjective+<undo>d__6")]
		public sealed class _undo_d__6 : Object
		{
			// Token: 0x060017EB RID: 6123 RVA: 0x00078DF0 File Offset: 0x00076FF0
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__6()
			{
				Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementAndCompleteObjective>.NativeClassPtr, "<undo>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr);
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<>1__state");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<>2__current");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<>l__initialThreadId");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "undoContext");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<>3__undoContext");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<>4__this");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<>8__1");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__incrementAmount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<incrementAmount>5__2");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__completedObjectives_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<completedObjectives>5__3");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__objective_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<objective>5__4");
				IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__amt_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, "<amt>5__5");
				IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, 100663388);
				IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, 100663389);
				IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, 100663390);
				IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, 100663391);
				IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, 100663392);
				IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, 100663393);
				IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, 100663394);
				IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr, 100663395);
			}

			// Token: 0x060017EC RID: 6124 RVA: 0x00078F98 File Offset: 0x00077198
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementAndCompleteObjective._undo_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017ED RID: 6125 RVA: 0x00078FE0 File Offset: 0x000771E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017EE RID: 6126 RVA: 0x00079014 File Offset: 0x00077214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543460, XrefRangeEnd = 543515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000539 RID: 1337
			// (get) Token: 0x060017EF RID: 6127 RVA: 0x00079050 File Offset: 0x00077250
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060017F0 RID: 6128 RVA: 0x00079090 File Offset: 0x00077290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543515, XrefRangeEnd = 543520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700053A RID: 1338
			// (get) Token: 0x060017F1 RID: 6129 RVA: 0x000790C4 File Offset: 0x000772C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060017F2 RID: 6130 RVA: 0x00079104 File Offset: 0x00077304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543520, XrefRangeEnd = 543529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060017F3 RID: 6131 RVA: 0x00079144 File Offset: 0x00077344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementAndCompleteObjective._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060017F4 RID: 6132 RVA: 0x0000B6CD File Offset: 0x000098CD
			public _undo_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700052E RID: 1326
			// (get) Token: 0x060017F5 RID: 6133 RVA: 0x00079184 File Offset: 0x00077384
			// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0000B6D6 File Offset: 0x000098D6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700052F RID: 1327
			// (get) Token: 0x060017F7 RID: 6135 RVA: 0x000791AC File Offset: 0x000773AC
			// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0000B6F1 File Offset: 0x000098F1
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000530 RID: 1328
			// (get) Token: 0x060017F9 RID: 6137 RVA: 0x000791DC File Offset: 0x000773DC
			// (set) Token: 0x060017FA RID: 6138 RVA: 0x0000B710 File Offset: 0x00009910
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000531 RID: 1329
			// (get) Token: 0x060017FB RID: 6139 RVA: 0x00079204 File Offset: 0x00077404
			// (set) Token: 0x060017FC RID: 6140 RVA: 0x0000B72B File Offset: 0x0000992B
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000532 RID: 1330
			// (get) Token: 0x060017FD RID: 6141 RVA: 0x00079234 File Offset: 0x00077434
			// (set) Token: 0x060017FE RID: 6142 RVA: 0x0000B74A File Offset: 0x0000994A
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000533 RID: 1331
			// (get) Token: 0x060017FF RID: 6143 RVA: 0x00079264 File Offset: 0x00077464
			// (set) Token: 0x06001800 RID: 6144 RVA: 0x0000B769 File Offset: 0x00009969
			public unsafe IncrementAndCompleteObjective __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncrementAndCompleteObjective>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000534 RID: 1332
			// (get) Token: 0x06001801 RID: 6145 RVA: 0x00079294 File Offset: 0x00077494
			// (set) Token: 0x06001802 RID: 6146 RVA: 0x0000B788 File Offset: 0x00009988
			public unsafe IncrementAndCompleteObjective.__c__DisplayClass6_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncrementAndCompleteObjective.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000535 RID: 1333
			// (get) Token: 0x06001803 RID: 6147 RVA: 0x000792C4 File Offset: 0x000774C4
			// (set) Token: 0x06001804 RID: 6148 RVA: 0x0000B7A7 File Offset: 0x000099A7
			public unsafe int _incrementAmount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__incrementAmount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__incrementAmount_5__2)) = value;
				}
			}

			// Token: 0x17000536 RID: 1334
			// (get) Token: 0x06001805 RID: 6149 RVA: 0x000792EC File Offset: 0x000774EC
			// (set) Token: 0x06001806 RID: 6150 RVA: 0x0000B7C2 File Offset: 0x000099C2
			public unsafe Il2CppStructArray<int> _completedObjectives_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__completedObjectives_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__completedObjectives_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000537 RID: 1335
			// (get) Token: 0x06001807 RID: 6151 RVA: 0x0007931C File Offset: 0x0007751C
			// (set) Token: 0x06001808 RID: 6152 RVA: 0x0000B7E1 File Offset: 0x000099E1
			public unsafe Objective _objective_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__objective_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Objective>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__objective_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000538 RID: 1336
			// (get) Token: 0x06001809 RID: 6153 RVA: 0x0007934C File Offset: 0x0007754C
			// (set) Token: 0x0600180A RID: 6154 RVA: 0x0000B800 File Offset: 0x00009A00
			public unsafe int _amt_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__amt_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncrementAndCompleteObjective._undo_d__6.NativeFieldInfoPtr__amt_5__5)) = value;
				}
			}

			// Token: 0x04000F51 RID: 3921
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F52 RID: 3922
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F53 RID: 3923
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000F54 RID: 3924
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04000F55 RID: 3925
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04000F56 RID: 3926
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F57 RID: 3927
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04000F58 RID: 3928
			private static readonly IntPtr NativeFieldInfoPtr__incrementAmount_5__2;

			// Token: 0x04000F59 RID: 3929
			private static readonly IntPtr NativeFieldInfoPtr__completedObjectives_5__3;

			// Token: 0x04000F5A RID: 3930
			private static readonly IntPtr NativeFieldInfoPtr__objective_5__4;

			// Token: 0x04000F5B RID: 3931
			private static readonly IntPtr NativeFieldInfoPtr__amt_5__5;

			// Token: 0x04000F5C RID: 3932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F5D RID: 3933
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F5E RID: 3934
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F5F RID: 3935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04000F60 RID: 3936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F61 RID: 3937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F62 RID: 3938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04000F63 RID: 3939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
