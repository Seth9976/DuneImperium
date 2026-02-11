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
	// Token: 0x020001CD RID: 461
	public class ResumeAIPlayer<TMatch, TPlayer> : Action where TMatch : Match where TPlayer : PlayerEntity
	{
		// Token: 0x06001364 RID: 4964 RVA: 0x00067DCC File Offset: 0x00065FCC
		// Note: this type is marked as 'beforefieldinit'.
		static ResumeAIPlayer()
		{
			Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ResumeAIPlayer`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>>.NativeClassPtr);
			ResumeAIPlayer<TMatch, TPlayer>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>>.NativeClassPtr, "match");
			ResumeAIPlayer<TMatch, TPlayer>.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>>.NativeClassPtr, "player");
			ResumeAIPlayer<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_TPlayer_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>>.NativeClassPtr, 100667517);
			ResumeAIPlayer<TMatch, TPlayer>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>>.NativeClassPtr, 100667518);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00067E9C File Offset: 0x0006609C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 587041, RefRangeEnd = 587043, XrefRangeStart = 587041, XrefRangeEnd = 587043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResumeAIPlayer(TPlayer player, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TPlayer).IsValueType)
				{
					TPlayer tplayer = player;
					intPtr = ((tplayer is string) ? IL2CPP.ManagedStringToIl2Cpp(tplayer as string) : IL2CPP.Il2CppObjectBaseToPtr(tplayer as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref player;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_TPlayer_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00067F30 File Offset: 0x00066130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResumeAIPlayer<TMatch, TPlayer>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x000097B7 File Offset: 0x000079B7
		public ResumeAIPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x00067F7C File Offset: 0x0006617C
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x00067FA4 File Offset: 0x000661A4
		public unsafe TMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>.NativeFieldInfoPtr_match);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>.NativeFieldInfoPtr_match);
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0006804C File Offset: 0x0006624C
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x00068074 File Offset: 0x00066274
		public unsafe TPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>.NativeFieldInfoPtr_player);
				return IL2CPP.PointerToValueGeneric<TPlayer>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>.NativeFieldInfoPtr_player);
				Type typeFromHandle = typeof(TPlayer);
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

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TPlayer_Match_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000406 RID: 1030
		[ObfuscatedName("Canis.actions.ResumeAIPlayer`2+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002C8C RID: 11404 RVA: 0x000BCD8C File Offset: 0x000BAF8C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>>.NativeClassPtr, "<execute>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr);
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>1__state");
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>2__current");
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, "<>4__this");
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667519);
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667520);
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667521);
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667522);
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667523);
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667524);
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667525);
				ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr, 100667526);
			}

			// Token: 0x06002C8D RID: 11405 RVA: 0x000BCEF4 File Offset: 0x000BB0F4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumeAIPlayer<TMatch, TPlayer>._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C8E RID: 11406 RVA: 0x000BCF3C File Offset: 0x000BB13C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C8F RID: 11407 RVA: 0x000BCF70 File Offset: 0x000BB170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587074, XrefRangeEnd = 587079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x06002C90 RID: 11408 RVA: 0x000BCFAC File Offset: 0x000BB1AC
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002C91 RID: 11409 RVA: 0x000BCFEC File Offset: 0x000BB1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x06002C92 RID: 11410 RVA: 0x000BD020 File Offset: 0x000BB220
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C93 RID: 11411 RVA: 0x000BD060 File Offset: 0x000BB260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002C94 RID: 11412 RVA: 0x000BD0A0 File Offset: 0x000BB2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002C95 RID: 11413 RVA: 0x00015492 File Offset: 0x00013692
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x06002C96 RID: 11414 RVA: 0x000BD0E0 File Offset: 0x000BB2E0
			// (set) Token: 0x06002C97 RID: 11415 RVA: 0x0001549B File Offset: 0x0001369B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x06002C98 RID: 11416 RVA: 0x000BD108 File Offset: 0x000BB308
			// (set) Token: 0x06002C99 RID: 11417 RVA: 0x000154B6 File Offset: 0x000136B6
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x06002C9A RID: 11418 RVA: 0x000BD138 File Offset: 0x000BB338
			// (set) Token: 0x06002C9B RID: 11419 RVA: 0x000154D5 File Offset: 0x000136D5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x06002C9C RID: 11420 RVA: 0x000BD160 File Offset: 0x000BB360
			// (set) Token: 0x06002C9D RID: 11421 RVA: 0x000154F0 File Offset: 0x000136F0
			public unsafe ResumeAIPlayer<TMatch, TPlayer> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumeAIPlayer<TMatch, TPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeAIPlayer<TMatch, TPlayer>._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BD9 RID: 7129
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BDA RID: 7130
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BDB RID: 7131
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001BDC RID: 7132
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BDD RID: 7133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BDE RID: 7134
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BDF RID: 7135
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BE0 RID: 7136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001BE1 RID: 7137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BE2 RID: 7138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BE3 RID: 7139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001BE4 RID: 7140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
