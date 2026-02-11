using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001A2 RID: 418
	public class ClearUndoStack<MatchWithUndos> : Action where MatchWithUndos : Match
	{
		// Token: 0x0600121D RID: 4637 RVA: 0x00062C5C File Offset: 0x00060E5C
		// Note: this type is marked as 'beforefieldinit'.
		static ClearUndoStack()
		{
			Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ClearUndoStack`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MatchWithUndos>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>>.NativeClassPtr);
			ClearUndoStack<MatchWithUndos>.NativeFieldInfoPtr_matchWithUndos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>>.NativeClassPtr, "matchWithUndos");
			ClearUndoStack<MatchWithUndos>.NativeMethodInfoPtr__ctor_Public_Void_MatchWithUndos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>>.NativeClassPtr, 100667151);
			ClearUndoStack<MatchWithUndos>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>>.NativeClassPtr, 100667152);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00062D04 File Offset: 0x00060F04
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 135734, RefRangeEnd = 135759, XrefRangeStart = 135734, XrefRangeEnd = 135759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClearUndoStack(MatchWithUndos m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(MatchWithUndos).IsValueType)
				{
					MatchWithUndos matchWithUndos = m;
					intPtr = ((matchWithUndos is string) ? IL2CPP.ManagedStringToIl2Cpp(matchWithUndos as string) : IL2CPP.Il2CppObjectBaseToPtr(matchWithUndos as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref m;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>.NativeMethodInfoPtr__ctor_Public_Void_MatchWithUndos_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00062D88 File Offset: 0x00060F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585127, XrefRangeEnd = 585131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearUndoStack<MatchWithUndos>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00008F6D File Offset: 0x0000716D
		public ClearUndoStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x00062DD4 File Offset: 0x00060FD4
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x00062DFC File Offset: 0x00060FFC
		public unsafe MatchWithUndos matchWithUndos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>.NativeFieldInfoPtr_matchWithUndos);
				return IL2CPP.PointerToValueGeneric<MatchWithUndos>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>.NativeFieldInfoPtr_matchWithUndos);
				Type typeFromHandle = typeof(MatchWithUndos);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeFieldInfoPtr_matchWithUndos;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchWithUndos_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x020003E1 RID: 993
		[ObfuscatedName("Canis.actions.ClearUndoStack`1+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002A34 RID: 10804 RVA: 0x000B54F0 File Offset: 0x000B36F0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>>.NativeClassPtr, "<execute>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MatchWithUndos>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, "<>1__state");
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, "<>2__current");
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, "<>4__this");
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, "<>7__wrap1");
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667153);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667154);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667155);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667156);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667157);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667158);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667159);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667160);
				ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr, 100667161);
			}

			// Token: 0x06002A35 RID: 10805 RVA: 0x000B5670 File Offset: 0x000B3870
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearUndoStack<MatchWithUndos>._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A36 RID: 10806 RVA: 0x000B56B8 File Offset: 0x000B38B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585073, XrefRangeEnd = 585078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A37 RID: 10807 RVA: 0x000B56EC File Offset: 0x000B38EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585078, XrefRangeEnd = 585124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002A38 RID: 10808 RVA: 0x000B5728 File Offset: 0x000B3928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585124, XrefRangeEnd = 585127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AB5 RID: 2741
			// (get) Token: 0x06002A39 RID: 10809 RVA: 0x000B575C File Offset: 0x000B395C
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002A3A RID: 10810 RVA: 0x000B579C File Offset: 0x000B399C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AB6 RID: 2742
			// (get) Token: 0x06002A3B RID: 10811 RVA: 0x000B57D0 File Offset: 0x000B39D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A3C RID: 10812 RVA: 0x000B5810 File Offset: 0x000B3A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002A3D RID: 10813 RVA: 0x000B5850 File Offset: 0x000B3A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002A3E RID: 10814 RVA: 0x000142E6 File Offset: 0x000124E6
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB0 RID: 2736
			// (get) Token: 0x06002A3F RID: 10815 RVA: 0x000B5890 File Offset: 0x000B3A90
			// (set) Token: 0x06002A40 RID: 10816 RVA: 0x000142EF File Offset: 0x000124EF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AB1 RID: 2737
			// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000B58B8 File Offset: 0x000B3AB8
			// (set) Token: 0x06002A42 RID: 10818 RVA: 0x0001430A File Offset: 0x0001250A
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB2 RID: 2738
			// (get) Token: 0x06002A43 RID: 10819 RVA: 0x000B58E8 File Offset: 0x000B3AE8
			// (set) Token: 0x06002A44 RID: 10820 RVA: 0x00014329 File Offset: 0x00012529
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000AB3 RID: 2739
			// (get) Token: 0x06002A45 RID: 10821 RVA: 0x000B5910 File Offset: 0x000B3B10
			// (set) Token: 0x06002A46 RID: 10822 RVA: 0x00014344 File Offset: 0x00012544
			public unsafe ClearUndoStack<MatchWithUndos> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearUndoStack<MatchWithUndos>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB4 RID: 2740
			// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000B5940 File Offset: 0x000B3B40
			// (set) Token: 0x06002A48 RID: 10824 RVA: 0x00014363 File Offset: 0x00012563
			public List<UndoNode>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___7__wrap1);
					return new List<UndoNode>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<UndoNode>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearUndoStack<MatchWithUndos>._execute_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<UndoNode>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A5D RID: 6749
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A5E RID: 6750
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A5F RID: 6751
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001A60 RID: 6752
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A61 RID: 6753
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001A62 RID: 6754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A63 RID: 6755
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A64 RID: 6756
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A65 RID: 6757
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001A66 RID: 6758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001A67 RID: 6759
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A68 RID: 6760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A69 RID: 6761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001A6A RID: 6762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
