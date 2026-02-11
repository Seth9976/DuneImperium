using System;
using Canis.actions.serialized;
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
	// Token: 0x020001E3 RID: 483
	public class SetObjective : Action
	{
		// Token: 0x06001487 RID: 5255 RVA: 0x0006C2E8 File Offset: 0x0006A4E8
		// Note: this type is marked as 'beforefieldinit'.
		static SetObjective()
		{
			Il2CppClassPointerStore<SetObjective>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SetObjective");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetObjective>.NativeClassPtr);
			SetObjective.NativeFieldInfoPtr_objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjective>.NativeClassPtr, "objective");
			SetObjective.NativeMethodInfoPtr__ctor_Public_Void_Match_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective>.NativeClassPtr, 100667797);
			SetObjective.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective>.NativeClassPtr, 100667798);
			SetObjective.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective>.NativeClassPtr, 100667799);
			SetObjective.NativeMethodInfoPtr__execute_b__2_0_Private_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective>.NativeClassPtr, 100667800);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0006C37C File Offset: 0x0006A57C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 133020, RefRangeEnd = 133047, XrefRangeStart = 133020, XrefRangeEnd = 133047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetObjective(Match m, Objective obj)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetObjective>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective.NativeMethodInfoPtr__ctor_Public_Void_Match_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0006C3DC File Offset: 0x0006A5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589563, XrefRangeEnd = 589569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetObjective.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0006C428 File Offset: 0x0006A628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589569, XrefRangeEnd = 589573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetObjective.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0006C484 File Offset: 0x0006A684
		[CallerCount(0)]
		public unsafe bool _execute_b__2_0(Objective _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective.NativeMethodInfoPtr__execute_b__2_0_Private_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00009FC9 File Offset: 0x000081C9
		public SetObjective(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0006C4D4 File Offset: 0x0006A6D4
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x00009FD2 File Offset: 0x000081D2
		public unsafe Objective objective
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective.NativeFieldInfoPtr_objective);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Objective>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective.NativeFieldInfoPtr_objective), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_objective;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Objective_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Private_Boolean_Objective_0;

		// Token: 0x0200041F RID: 1055
		[ObfuscatedName("Canis.actions.SetObjective+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002E30 RID: 11824 RVA: 0x000C2170 File Offset: 0x000C0370
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetObjective>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr);
				SetObjective._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, "<>1__state");
				SetObjective._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, "<>2__current");
				SetObjective._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				SetObjective._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, "<>4__this");
				SetObjective._execute_d__2.NativeFieldInfoPtr__newArray_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, "<newArray>5__2");
				SetObjective._execute_d__2.NativeFieldInfoPtr__sequence_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, "<sequence>5__3");
				SetObjective._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, 100667801);
				SetObjective._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, 100667802);
				SetObjective._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, 100667803);
				SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, 100667804);
				SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, 100667805);
				SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, 100667806);
				SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, 100667807);
				SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr, 100667808);
			}

			// Token: 0x06002E31 RID: 11825 RVA: 0x000C22B4 File Offset: 0x000C04B4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetObjective._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E32 RID: 11826 RVA: 0x000C22FC File Offset: 0x000C04FC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E33 RID: 11827 RVA: 0x000C2330 File Offset: 0x000C0530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589539, XrefRangeEnd = 589556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C0A RID: 3082
			// (get) Token: 0x06002E34 RID: 11828 RVA: 0x000C236C File Offset: 0x000C056C
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002E35 RID: 11829 RVA: 0x000C23AC File Offset: 0x000C05AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589556, XrefRangeEnd = 589561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C0B RID: 3083
			// (get) Token: 0x06002E36 RID: 11830 RVA: 0x000C23E0 File Offset: 0x000C05E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E37 RID: 11831 RVA: 0x000C2420 File Offset: 0x000C0620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589561, XrefRangeEnd = 589563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002E38 RID: 11832 RVA: 0x000C2460 File Offset: 0x000C0660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjective._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002E39 RID: 11833 RVA: 0x00016160 File Offset: 0x00014360
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C04 RID: 3076
			// (get) Token: 0x06002E3A RID: 11834 RVA: 0x000C24A0 File Offset: 0x000C06A0
			// (set) Token: 0x06002E3B RID: 11835 RVA: 0x00016169 File Offset: 0x00014369
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C05 RID: 3077
			// (get) Token: 0x06002E3C RID: 11836 RVA: 0x000C24C8 File Offset: 0x000C06C8
			// (set) Token: 0x06002E3D RID: 11837 RVA: 0x00016184 File Offset: 0x00014384
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C06 RID: 3078
			// (get) Token: 0x06002E3E RID: 11838 RVA: 0x000C24F8 File Offset: 0x000C06F8
			// (set) Token: 0x06002E3F RID: 11839 RVA: 0x000161A3 File Offset: 0x000143A3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000C07 RID: 3079
			// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000C2520 File Offset: 0x000C0720
			// (set) Token: 0x06002E41 RID: 11841 RVA: 0x000161BE File Offset: 0x000143BE
			public unsafe SetObjective __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetObjective>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C08 RID: 3080
			// (get) Token: 0x06002E42 RID: 11842 RVA: 0x000C2550 File Offset: 0x000C0750
			// (set) Token: 0x06002E43 RID: 11843 RVA: 0x000161DD File Offset: 0x000143DD
			public unsafe Il2CppReferenceArray<Objective> _newArray_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr__newArray_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Objective>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr__newArray_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C09 RID: 3081
			// (get) Token: 0x06002E44 RID: 11844 RVA: 0x000C2580 File Offset: 0x000C0780
			// (set) Token: 0x06002E45 RID: 11845 RVA: 0x000161FC File Offset: 0x000143FC
			public unsafe SequenceHelper _sequence_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr__sequence_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjective._execute_d__2.NativeFieldInfoPtr__sequence_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CF2 RID: 7410
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CF3 RID: 7411
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CF4 RID: 7412
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001CF5 RID: 7413
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CF6 RID: 7414
			private static readonly IntPtr NativeFieldInfoPtr__newArray_5__2;

			// Token: 0x04001CF7 RID: 7415
			private static readonly IntPtr NativeFieldInfoPtr__sequence_5__3;

			// Token: 0x04001CF8 RID: 7416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CF9 RID: 7417
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CFA RID: 7418
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CFB RID: 7419
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001CFC RID: 7420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CFD RID: 7421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CFE RID: 7422
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001CFF RID: 7423
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
