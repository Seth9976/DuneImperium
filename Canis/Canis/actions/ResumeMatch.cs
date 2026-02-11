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
	// Token: 0x020001CB RID: 459
	public class ResumeMatch<TMatch, TPlayer> : Action where TMatch : Match where TPlayer : PlayerEntity
	{
		// Token: 0x06001353 RID: 4947 RVA: 0x0006779C File Offset: 0x0006599C
		// Note: this type is marked as 'beforefieldinit'.
		static ResumeMatch()
		{
			Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ResumeMatch`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr);
			ResumeMatch<TMatch, TPlayer>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr, "match");
			ResumeMatch<TMatch, TPlayer>.NativeFieldInfoPtr_scenarioAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr, "scenarioAction");
			ResumeMatch<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_Match_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr, 100667484);
			ResumeMatch<TMatch, TPlayer>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr, 100667485);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0006786C File Offset: 0x00065A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 586964, RefRangeEnd = 586965, XrefRangeStart = 586954, XrefRangeEnd = 586964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResumeMatch(Match m, Action scenarioAction = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scenarioAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_Match_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000678CC File Offset: 0x00065ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResumeMatch<TMatch, TPlayer>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00009786 File Offset: 0x00007986
		public ResumeMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00067918 File Offset: 0x00065B18
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00067940 File Offset: 0x00065B40
		public unsafe TMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>.NativeFieldInfoPtr_match);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>.NativeFieldInfoPtr_match);
				Type typeFromHandle = typeof(TMatch);
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

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x000679E8 File Offset: 0x00065BE8
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x0000978F File Offset: 0x0000798F
		public unsafe Action scenarioAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>.NativeFieldInfoPtr_scenarioAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>.NativeFieldInfoPtr_scenarioAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_scenarioAction;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Action_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000400 RID: 1024
		[ObfuscatedName("Canis.actions.ResumeMatch`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002C42 RID: 11330 RVA: 0x000BBD60 File Offset: 0x000B9F60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr);
				ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr, "<>9");
				ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr, "<>9__3_0");
				ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr, "<>9__3_1");
				ResumeMatch<TMatch, TPlayer>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr, 100667487);
				ResumeMatch<TMatch, TPlayer>.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr, 100667488);
				ResumeMatch<TMatch, TPlayer>.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_Boolean_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr, 100667489);
			}

			// Token: 0x06002C43 RID: 11331 RVA: 0x000BBE50 File Offset: 0x000BA050
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C44 RID: 11332 RVA: 0x000BBE8C File Offset: 0x000BA08C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__3_0(TPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TPlayer).IsValueType)
					{
						TPlayer tplayer = _;
						intPtr = ((tplayer is string) ? IL2CPP.ManagedStringToIl2Cpp(tplayer as string) : IL2CPP.Il2CppObjectBaseToPtr(tplayer as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_TPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002C45 RID: 11333 RVA: 0x000BBF10 File Offset: 0x000BA110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__3_1(TPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TPlayer).IsValueType)
					{
						TPlayer tplayer = _;
						intPtr = ((tplayer is string) ? IL2CPP.ManagedStringToIl2Cpp(tplayer as string) : IL2CPP.Il2CppObjectBaseToPtr(tplayer as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_Boolean_TPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002C46 RID: 11334 RVA: 0x0001529D File Offset: 0x0001349D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x06002C47 RID: 11335 RVA: 0x000BBF94 File Offset: 0x000BA194
			// (set) Token: 0x06002C48 RID: 11336 RVA: 0x000152A6 File Offset: 0x000134A6
			public unsafe static ResumeMatch<TMatch, TPlayer>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumeMatch<TMatch, TPlayer>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x06002C49 RID: 11337 RVA: 0x000BBFBC File Offset: 0x000BA1BC
			// (set) Token: 0x06002C4A RID: 11338 RVA: 0x000152B8 File Offset: 0x000134B8
			public unsafe static Func<TPlayer, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000BBFE4 File Offset: 0x000BA1E4
			// (set) Token: 0x06002C4C RID: 11340 RVA: 0x000152CA File Offset: 0x000134CA
			public unsafe static Func<TPlayer, bool> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumeMatch<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BAD RID: 7085
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001BAE RID: 7086
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001BAF RID: 7087
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04001BB0 RID: 7088
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BB1 RID: 7089
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Internal_Boolean_TPlayer_0;

			// Token: 0x04001BB2 RID: 7090
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_1_Internal_Boolean_TPlayer_0;
		}

		// Token: 0x02000401 RID: 1025
		[ObfuscatedName("Canis.actions.ResumeMatch`2+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002C4D RID: 11341 RVA: 0x000BC00C File Offset: 0x000BA20C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>>.NativeClassPtr, "<execute>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>1__state");
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>2__current");
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>4__this");
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>7__wrap1");
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667490);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667491);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667492);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667493);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667494);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667495);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667496);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667497);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667498);
				ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667499);
			}

			// Token: 0x06002C4E RID: 11342 RVA: 0x000BC1B0 File Offset: 0x000BA3B0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumeMatch<TMatch, TPlayer>._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C4F RID: 11343 RVA: 0x000BC1F8 File Offset: 0x000BA3F8
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C50 RID: 11344 RVA: 0x000BC22C File Offset: 0x000BA42C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586863, XrefRangeEnd = 586947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002C51 RID: 11345 RVA: 0x000BC268 File Offset: 0x000BA468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586947, XrefRangeEnd = 586950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C52 RID: 11346 RVA: 0x000BC29C File Offset: 0x000BA49C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586950, XrefRangeEnd = 586953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x06002C53 RID: 11347 RVA: 0x000BC2D0 File Offset: 0x000BA4D0
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002C54 RID: 11348 RVA: 0x000BC310 File Offset: 0x000BA510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06002C55 RID: 11349 RVA: 0x000BC344 File Offset: 0x000BA544
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C56 RID: 11350 RVA: 0x000BC384 File Offset: 0x000BA584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002C57 RID: 11351 RVA: 0x000BC3C4 File Offset: 0x000BA5C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586953, XrefRangeEnd = 586954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002C58 RID: 11352 RVA: 0x000152DC File Offset: 0x000134DC
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x06002C59 RID: 11353 RVA: 0x000BC404 File Offset: 0x000BA604
			// (set) Token: 0x06002C5A RID: 11354 RVA: 0x000152E5 File Offset: 0x000134E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x06002C5B RID: 11355 RVA: 0x000BC42C File Offset: 0x000BA62C
			// (set) Token: 0x06002C5C RID: 11356 RVA: 0x00015300 File Offset: 0x00013500
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x06002C5D RID: 11357 RVA: 0x000BC45C File Offset: 0x000BA65C
			// (set) Token: 0x06002C5E RID: 11358 RVA: 0x0001531F File Offset: 0x0001351F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x06002C5F RID: 11359 RVA: 0x000BC484 File Offset: 0x000BA684
			// (set) Token: 0x06002C60 RID: 11360 RVA: 0x0001533A File Offset: 0x0001353A
			public unsafe ResumeMatch<TMatch, TPlayer> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumeMatch<TMatch, TPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x06002C61 RID: 11361 RVA: 0x000BC4B4 File Offset: 0x000BA6B4
			// (set) Token: 0x06002C62 RID: 11362 RVA: 0x00015359 File Offset: 0x00013559
			public unsafe IEnumerator<TPlayer> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeMatch<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BB3 RID: 7091
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BB4 RID: 7092
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BB5 RID: 7093
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001BB6 RID: 7094
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BB7 RID: 7095
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001BB8 RID: 7096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BB9 RID: 7097
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BBA RID: 7098
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BBB RID: 7099
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001BBC RID: 7100
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001BBD RID: 7101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001BBE RID: 7102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BBF RID: 7103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BC0 RID: 7104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001BC1 RID: 7105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
