using System;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.tutorialScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001B9 RID: 441
	public class ModifyObjectiveCount : Action
	{
		// Token: 0x060012B4 RID: 4788 RVA: 0x00065228 File Offset: 0x00063428
		// Note: this type is marked as 'beforefieldinit'.
		static ModifyObjectiveCount()
		{
			Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ModifyObjectiveCount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr);
			ModifyObjectiveCount.NativeFieldInfoPtr_deltaFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, "deltaFactory");
			ModifyObjectiveCount.NativeFieldInfoPtr_objectiveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, "objectiveID");
			ModifyObjectiveCount.NativeMethodInfoPtr__ctor_Public_Void_ObjectiveDeltaFactory_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, 100667300);
			ModifyObjectiveCount.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, 100667301);
			ModifyObjectiveCount.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, 100667302);
			ModifyObjectiveCount.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, 100667303);
			ModifyObjectiveCount.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, 100667304);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000652E4 File Offset: 0x000634E4
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 583044, RefRangeEnd = 583221, XrefRangeStart = 583044, XrefRangeEnd = 583221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModifyObjectiveCount(ObjectiveDeltaFactory deltaFactory, int objectiveID, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deltaFactory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectiveID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount.NativeMethodInfoPtr__ctor_Public_Void_ObjectiveDeltaFactory_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00065350 File Offset: 0x00063550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585770, XrefRangeEnd = 585777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModifyObjectiveCount(int delta, int objectiveID, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectiveID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000653B8 File Offset: 0x000635B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585777, XrefRangeEnd = 585783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModifyObjectiveCount.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00065404 File Offset: 0x00063604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585783, XrefRangeEnd = 585788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModifyObjectiveCount.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00065460 File Offset: 0x00063660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585788, XrefRangeEnd = 585795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModifyObjectiveCount.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000092C6 File Offset: 0x000074C6
		public ModifyObjectiveCount(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x000654BC File Offset: 0x000636BC
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x000092CF File Offset: 0x000074CF
		public unsafe ObjectiveDeltaFactory deltaFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount.NativeFieldInfoPtr_deltaFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectiveDeltaFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount.NativeFieldInfoPtr_deltaFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x000654EC File Offset: 0x000636EC
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x000092EE File Offset: 0x000074EE
		public unsafe int objectiveID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount.NativeFieldInfoPtr_objectiveID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount.NativeFieldInfoPtr_objectiveID)) = value;
			}
		}

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeFieldInfoPtr_deltaFactory;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeFieldInfoPtr_objectiveID;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectiveDeltaFactory_Int32_Match_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Match_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x020003EE RID: 1006
		[ObfuscatedName("Canis.actions.ModifyObjectiveCount+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002AFD RID: 11005 RVA: 0x000B7D9C File Offset: 0x000B5F9C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr);
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<>1__state");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<>2__current");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<>4__this");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__objectives_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<objectives>5__2");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__completedObjectives_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<completedObjectives>5__3");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__undo_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<undo>5__4");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__objective_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<objective>5__5");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__newAmount_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<newAmount>5__6");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__updateSeq_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<updateSeq>5__7");
				ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__completedSeq_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, "<completedSeq>5__8");
				ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, 100667305);
				ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, 100667306);
				ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, 100667307);
				ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, 100667308);
				ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, 100667309);
				ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, 100667310);
				ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, 100667311);
				ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr, 100667312);
			}

			// Token: 0x06002AFE RID: 11006 RVA: 0x000B7F44 File Offset: 0x000B6144
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyObjectiveCount._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AFF RID: 11007 RVA: 0x000B7F8C File Offset: 0x000B618C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B00 RID: 11008 RVA: 0x000B7FC0 File Offset: 0x000B61C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585574, XrefRangeEnd = 585731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000B7FFC File Offset: 0x000B61FC
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002B02 RID: 11010 RVA: 0x000B803C File Offset: 0x000B623C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585731, XrefRangeEnd = 585736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000B8070 File Offset: 0x000B6270
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B04 RID: 11012 RVA: 0x000B80B0 File Offset: 0x000B62B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585736, XrefRangeEnd = 585738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002B05 RID: 11013 RVA: 0x000B80F0 File Offset: 0x000B62F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002B06 RID: 11014 RVA: 0x000148B4 File Offset: 0x00012AB4
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000B8130 File Offset: 0x000B6330
			// (set) Token: 0x06002B08 RID: 11016 RVA: 0x000148BD File Offset: 0x00012ABD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AF2 RID: 2802
			// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000B8158 File Offset: 0x000B6358
			// (set) Token: 0x06002B0A RID: 11018 RVA: 0x000148D8 File Offset: 0x00012AD8
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000B8188 File Offset: 0x000B6388
			// (set) Token: 0x06002B0C RID: 11020 RVA: 0x000148F7 File Offset: 0x00012AF7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x06002B0D RID: 11021 RVA: 0x000B81B0 File Offset: 0x000B63B0
			// (set) Token: 0x06002B0E RID: 11022 RVA: 0x00014912 File Offset: 0x00012B12
			public unsafe ModifyObjectiveCount __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModifyObjectiveCount>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x06002B0F RID: 11023 RVA: 0x000B81E0 File Offset: 0x000B63E0
			// (set) Token: 0x06002B10 RID: 11024 RVA: 0x00014931 File Offset: 0x00012B31
			public unsafe Il2CppReferenceArray<Objective> _objectives_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__objectives_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Objective>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__objectives_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x06002B11 RID: 11025 RVA: 0x000B8210 File Offset: 0x000B6410
			// (set) Token: 0x06002B12 RID: 11026 RVA: 0x00014950 File Offset: 0x00012B50
			public unsafe Il2CppStructArray<int> _completedObjectives_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__completedObjectives_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__completedObjectives_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x06002B13 RID: 11027 RVA: 0x000B8240 File Offset: 0x000B6440
			// (set) Token: 0x06002B14 RID: 11028 RVA: 0x0001496F File Offset: 0x00012B6F
			public unsafe UndoNode _undo_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__undo_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__undo_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000B8270 File Offset: 0x000B6470
			// (set) Token: 0x06002B16 RID: 11030 RVA: 0x0001498E File Offset: 0x00012B8E
			public unsafe Objective _objective_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__objective_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Objective>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__objective_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x06002B17 RID: 11031 RVA: 0x000B82A0 File Offset: 0x000B64A0
			// (set) Token: 0x06002B18 RID: 11032 RVA: 0x000149AD File Offset: 0x00012BAD
			public unsafe int _newAmount_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__newAmount_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__newAmount_5__6)) = value;
				}
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x06002B19 RID: 11033 RVA: 0x000B82C8 File Offset: 0x000B64C8
			// (set) Token: 0x06002B1A RID: 11034 RVA: 0x000149C8 File Offset: 0x00012BC8
			public unsafe SequenceHelper _updateSeq_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__updateSeq_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__updateSeq_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x06002B1B RID: 11035 RVA: 0x000B82F8 File Offset: 0x000B64F8
			// (set) Token: 0x06002B1C RID: 11036 RVA: 0x000149E7 File Offset: 0x00012BE7
			public unsafe SequenceHelper _completedSeq_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__completedSeq_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._execute_d__4.NativeFieldInfoPtr__completedSeq_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001ADF RID: 6879
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AE0 RID: 6880
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AE1 RID: 6881
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001AE2 RID: 6882
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AE3 RID: 6883
			private static readonly IntPtr NativeFieldInfoPtr__objectives_5__2;

			// Token: 0x04001AE4 RID: 6884
			private static readonly IntPtr NativeFieldInfoPtr__completedObjectives_5__3;

			// Token: 0x04001AE5 RID: 6885
			private static readonly IntPtr NativeFieldInfoPtr__undo_5__4;

			// Token: 0x04001AE6 RID: 6886
			private static readonly IntPtr NativeFieldInfoPtr__objective_5__5;

			// Token: 0x04001AE7 RID: 6887
			private static readonly IntPtr NativeFieldInfoPtr__newAmount_5__6;

			// Token: 0x04001AE8 RID: 6888
			private static readonly IntPtr NativeFieldInfoPtr__updateSeq_5__7;

			// Token: 0x04001AE9 RID: 6889
			private static readonly IntPtr NativeFieldInfoPtr__completedSeq_5__8;

			// Token: 0x04001AEA RID: 6890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AEB RID: 6891
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AEC RID: 6892
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AED RID: 6893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001AEE RID: 6894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AEF RID: 6895
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AF0 RID: 6896
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001AF1 RID: 6897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020003EF RID: 1007
		[ObfuscatedName("Canis.actions.ModifyObjectiveCount+<undo>d__6")]
		public sealed class _undo_d__6 : Object
		{
			// Token: 0x06002B1D RID: 11037 RVA: 0x000B8328 File Offset: 0x000B6528
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__6()
			{
				Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyObjectiveCount>.NativeClassPtr, "<undo>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr);
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "<>1__state");
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "<>2__current");
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "<>l__initialThreadId");
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "undoContext");
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "<>3__undoContext");
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "<>4__this");
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__originalObjectives_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "<originalObjectives>5__2");
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__originalCompletedObjectives_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "<originalCompletedObjectives>5__3");
				ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__updateSeq_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, "<updateSeq>5__4");
				ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, 100667313);
				ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, 100667314);
				ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, 100667315);
				ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, 100667316);
				ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, 100667317);
				ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, 100667318);
				ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, 100667319);
				ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr, 100667320);
			}

			// Token: 0x06002B1E RID: 11038 RVA: 0x000B84A8 File Offset: 0x000B66A8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyObjectiveCount._undo_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B1F RID: 11039 RVA: 0x000B84F0 File Offset: 0x000B66F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B20 RID: 11040 RVA: 0x000B8524 File Offset: 0x000B6724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585738, XrefRangeEnd = 585756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000B8560 File Offset: 0x000B6760
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002B22 RID: 11042 RVA: 0x000B85A0 File Offset: 0x000B67A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585756, XrefRangeEnd = 585761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B08 RID: 2824
			// (get) Token: 0x06002B23 RID: 11043 RVA: 0x000B85D4 File Offset: 0x000B67D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B24 RID: 11044 RVA: 0x000B8614 File Offset: 0x000B6814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585761, XrefRangeEnd = 585770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002B25 RID: 11045 RVA: 0x000B8654 File Offset: 0x000B6854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifyObjectiveCount._undo_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002B26 RID: 11046 RVA: 0x00014A06 File Offset: 0x00012C06
			public _undo_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000B8694 File Offset: 0x000B6894
			// (set) Token: 0x06002B28 RID: 11048 RVA: 0x00014A0F File Offset: 0x00012C0F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x06002B29 RID: 11049 RVA: 0x000B86BC File Offset: 0x000B68BC
			// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00014A2A File Offset: 0x00012C2A
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000B86EC File Offset: 0x000B68EC
			// (set) Token: 0x06002B2C RID: 11052 RVA: 0x00014A49 File Offset: 0x00012C49
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000B8714 File Offset: 0x000B6914
			// (set) Token: 0x06002B2E RID: 11054 RVA: 0x00014A64 File Offset: 0x00012C64
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000B8744 File Offset: 0x000B6944
			// (set) Token: 0x06002B30 RID: 11056 RVA: 0x00014A83 File Offset: 0x00012C83
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B03 RID: 2819
			// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000B8774 File Offset: 0x000B6974
			// (set) Token: 0x06002B32 RID: 11058 RVA: 0x00014AA2 File Offset: 0x00012CA2
			public unsafe ModifyObjectiveCount __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModifyObjectiveCount>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000B87A4 File Offset: 0x000B69A4
			// (set) Token: 0x06002B34 RID: 11060 RVA: 0x00014AC1 File Offset: 0x00012CC1
			public unsafe Il2CppReferenceArray<Objective> _originalObjectives_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__originalObjectives_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Objective>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__originalObjectives_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000B87D4 File Offset: 0x000B69D4
			// (set) Token: 0x06002B36 RID: 11062 RVA: 0x00014AE0 File Offset: 0x00012CE0
			public unsafe Il2CppStructArray<int> _originalCompletedObjectives_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__originalCompletedObjectives_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__originalCompletedObjectives_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000B8804 File Offset: 0x000B6A04
			// (set) Token: 0x06002B38 RID: 11064 RVA: 0x00014AFF File Offset: 0x00012CFF
			public unsafe SequenceHelper _updateSeq_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__updateSeq_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifyObjectiveCount._undo_d__6.NativeFieldInfoPtr__updateSeq_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AF2 RID: 6898
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AF3 RID: 6899
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AF4 RID: 6900
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001AF5 RID: 6901
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04001AF6 RID: 6902
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04001AF7 RID: 6903
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AF8 RID: 6904
			private static readonly IntPtr NativeFieldInfoPtr__originalObjectives_5__2;

			// Token: 0x04001AF9 RID: 6905
			private static readonly IntPtr NativeFieldInfoPtr__originalCompletedObjectives_5__3;

			// Token: 0x04001AFA RID: 6906
			private static readonly IntPtr NativeFieldInfoPtr__updateSeq_5__4;

			// Token: 0x04001AFB RID: 6907
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AFC RID: 6908
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AFD RID: 6909
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AFE RID: 6910
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001AFF RID: 6911
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B00 RID: 6912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B01 RID: 6913
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001B02 RID: 6914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
