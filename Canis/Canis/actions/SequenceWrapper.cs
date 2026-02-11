using System;
using Canis.attributes;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.actions
{
	// Token: 0x020001E1 RID: 481
	public class SequenceWrapper<TAct> : Action where TAct : Action
	{
		// Token: 0x06001472 RID: 5234 RVA: 0x0006BCF4 File Offset: 0x00069EF4
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceWrapper()
		{
			Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SequenceWrapper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAct>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr);
			SequenceWrapper<TAct>.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr, "action");
			SequenceWrapper<TAct>.NativeFieldInfoPtr_sequenceHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr, "sequenceHelper");
			SequenceWrapper<TAct>.NativeFieldInfoPtr_forPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr, "forPlayer");
			SequenceWrapper<TAct>.NativeMethodInfoPtr__ctor_Public_Void_String_TAct_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr, 100667774);
			SequenceWrapper<TAct>.NativeMethodInfoPtr_Has_Public_SequenceWrapper_1_TAct_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr, 100667775);
			SequenceWrapper<TAct>.NativeMethodInfoPtr_ForPlayer_Public_SequenceWrapper_1_TAct_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr, 100667776);
			SequenceWrapper<TAct>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr, 100667777);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0006BDEC File Offset: 0x00069FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 589477, RefRangeEnd = 589478, XrefRangeStart = 589470, XrefRangeEnd = 589477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceWrapper(string sequenceName, TAct action, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TAct).IsValueType)
			{
				TAct tact = action;
				intPtr = ((tact is string) ? IL2CPP.ManagedStringToIl2Cpp(tact as string) : IL2CPP.Il2CppObjectBaseToPtr(tact as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref action;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>.NativeMethodInfoPtr__ctor_Public_Void_String_TAct_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0006BE94 File Offset: 0x0006A094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589478, XrefRangeEnd = 589481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceWrapper<TAct> Has<T>(AttributeDefinition<T> attribute, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<T>.MethodInfoStoreGeneric_Has_Public_SequenceWrapper_1_TAct_AttributeDefinition_1_T_T_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<SequenceWrapper<TAct>>(intPtr4) : null;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0006BF2C File Offset: 0x0006A12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceWrapper<TAct> ForPlayer(PlayerEntity forPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>.NativeMethodInfoPtr_ForPlayer_Public_SequenceWrapper_1_TAct_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceWrapper<TAct>>(intPtr3) : null;
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0006BF7C File Offset: 0x0006A17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceWrapper<TAct>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00009F3B File Offset: 0x0000813B
		public SequenceWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0006BFC8 File Offset: 0x0006A1C8
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x0006BFF0 File Offset: 0x0006A1F0
		public unsafe TAct action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>.NativeFieldInfoPtr_action);
				return IL2CPP.PointerToValueGeneric<TAct>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>.NativeFieldInfoPtr_action);
				Type typeFromHandle = typeof(TAct);
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0006C098 File Offset: 0x0006A298
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x00009F44 File Offset: 0x00008144
		public unsafe SequenceHelper sequenceHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>.NativeFieldInfoPtr_sequenceHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>.NativeFieldInfoPtr_sequenceHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0006C0C8 File Offset: 0x0006A2C8
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x00009F63 File Offset: 0x00008163
		public unsafe PlayerEntity forPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>.NativeFieldInfoPtr_forPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>.NativeFieldInfoPtr_forPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeFieldInfoPtr_sequenceHelper;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeFieldInfoPtr_forPlayer;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TAct_Match_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_SequenceWrapper_1_TAct_AttributeDefinition_1_T_T_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_ForPlayer_Public_SequenceWrapper_1_TAct_PlayerEntity_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0200041C RID: 1052
		[ObfuscatedName("Canis.actions.SequenceWrapper`1+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06002E0B RID: 11787 RVA: 0x000C1970 File Offset: 0x000BFB70
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceWrapper<TAct>>.NativeClassPtr, "<execute>d__6"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAct>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr);
				SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, "<>1__state");
				SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, "<>2__current");
				SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, "<>l__initialThreadId");
				SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, "<>4__this");
				SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, 100667778);
				SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, 100667779);
				SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, 100667780);
				SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, 100667781);
				SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, 100667782);
				SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, 100667783);
				SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, 100667784);
				SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr, 100667785);
			}

			// Token: 0x06002E0C RID: 11788 RVA: 0x000C1AC8 File Offset: 0x000BFCC8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceWrapper<TAct>._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E0D RID: 11789 RVA: 0x000C1B10 File Offset: 0x000BFD10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E0E RID: 11790 RVA: 0x000C1B44 File Offset: 0x000BFD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589468, XrefRangeEnd = 589470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BFC RID: 3068
			// (get) Token: 0x06002E0F RID: 11791 RVA: 0x000C1B80 File Offset: 0x000BFD80
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002E10 RID: 11792 RVA: 0x000C1BC0 File Offset: 0x000BFDC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BFD RID: 3069
			// (get) Token: 0x06002E11 RID: 11793 RVA: 0x000C1BF4 File Offset: 0x000BFDF4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E12 RID: 11794 RVA: 0x000C1C34 File Offset: 0x000BFE34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002E13 RID: 11795 RVA: 0x000C1C74 File Offset: 0x000BFE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceWrapper<TAct>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002E14 RID: 11796 RVA: 0x00016066 File Offset: 0x00014266
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF8 RID: 3064
			// (get) Token: 0x06002E15 RID: 11797 RVA: 0x000C1CB4 File Offset: 0x000BFEB4
			// (set) Token: 0x06002E16 RID: 11798 RVA: 0x0001606F File Offset: 0x0001426F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BF9 RID: 3065
			// (get) Token: 0x06002E17 RID: 11799 RVA: 0x000C1CDC File Offset: 0x000BFEDC
			// (set) Token: 0x06002E18 RID: 11800 RVA: 0x0001608A File Offset: 0x0001428A
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFA RID: 3066
			// (get) Token: 0x06002E19 RID: 11801 RVA: 0x000C1D0C File Offset: 0x000BFF0C
			// (set) Token: 0x06002E1A RID: 11802 RVA: 0x000160A9 File Offset: 0x000142A9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000BFB RID: 3067
			// (get) Token: 0x06002E1B RID: 11803 RVA: 0x000C1D34 File Offset: 0x000BFF34
			// (set) Token: 0x06002E1C RID: 11804 RVA: 0x000160C4 File Offset: 0x000142C4
			public unsafe SequenceWrapper<TAct> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceWrapper<TAct>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceWrapper<TAct>._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CD9 RID: 7385
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CDA RID: 7386
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CDB RID: 7387
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001CDC RID: 7388
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CDD RID: 7389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CDE RID: 7390
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CDF RID: 7391
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CE0 RID: 7392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001CE1 RID: 7393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CE2 RID: 7394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CE3 RID: 7395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001CE4 RID: 7396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200041D RID: 1053
		private sealed class MethodInfoStoreGeneric_Has_Public_SequenceWrapper_1_TAct_AttributeDefinition_1_T_T_0
		{
			// Token: 0x04001CE5 RID: 7397
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceWrapper<T>.NativeMethodInfoPtr_Has_Public_SequenceWrapper_1_TAct_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<SequenceWrapper<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
