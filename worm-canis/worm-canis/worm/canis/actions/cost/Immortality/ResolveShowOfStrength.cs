using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions.cost.Immortality
{
	// Token: 0x02000318 RID: 792
	public class ResolveShowOfStrength : global::Canis.actions.Action
	{
		// Token: 0x06002046 RID: 8262 RVA: 0x000D74B4 File Offset: 0x000D56B4
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveShowOfStrength()
		{
			Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.Immortality", "ResolveShowOfStrength");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr);
			ResolveShowOfStrength.NativeFieldInfoPtr_intResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr, "intResponse");
			ResolveShowOfStrength.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr, "archID");
			ResolveShowOfStrength.NativeMethodInfoPtr__ctor_Public_Void_Match_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr, 100671194);
			ResolveShowOfStrength.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr, 100671195);
			ResolveShowOfStrength.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr, 100671196);
			ResolveShowOfStrength.NativeMethodInfoPtr_Deserialize_Public_Static_ResolveShowOfStrength_SerializedResolveShowOfStrength_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr, 100671197);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000D755C File Offset: 0x000D575C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175201, RefRangeEnd = 175204, XrefRangeStart = 175199, XrefRangeEnd = 175201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveShowOfStrength(Match m, ArchetypeID archID, int intResponse = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength.NativeMethodInfoPtr__ctor_Public_Void_Match_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000D75C8 File Offset: 0x000D57C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175204, XrefRangeEnd = 175210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveShowOfStrength.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000D7614 File Offset: 0x000D5814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175210, XrefRangeEnd = 175215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveShowOfStrength.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000D7670 File Offset: 0x000D5870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175215, XrefRangeEnd = 175224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResolveShowOfStrength Deserialize(SerializedResolveShowOfStrength serialized, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength.NativeMethodInfoPtr_Deserialize_Public_Static_ResolveShowOfStrength_SerializedResolveShowOfStrength_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResolveShowOfStrength>(intPtr3) : null;
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		public ResolveShowOfStrength(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x000D76C8 File Offset: 0x000D58C8
		// (set) Token: 0x0600204D RID: 8269 RVA: 0x0000D5A9 File Offset: 0x0000B7A9
		public unsafe int intResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength.NativeFieldInfoPtr_intResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength.NativeFieldInfoPtr_intResponse)) = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x000D76F0 File Offset: 0x000D58F0
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x0000D5C4 File Offset: 0x0000B7C4
		public unsafe ArchetypeID archID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength.NativeFieldInfoPtr_archID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr_intResponse;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_ArchetypeID_Int32_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_ResolveShowOfStrength_SerializedResolveShowOfStrength_Match_0;

		// Token: 0x020007D6 RID: 2006
		[ObfuscatedName("worm.canis.actions.cost.Immortality.ResolveShowOfStrength+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600718A RID: 29066 RVA: 0x0020F858 File Offset: 0x0020DA58
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveShowOfStrength>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr);
				ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, "<>1__state");
				ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, "<>2__current");
				ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, "<>4__this");
				ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, "<player>5__2");
				ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__wormMatch_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, "<wormMatch>5__3");
				ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__card_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, "<card>5__4");
				ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__toArea_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, "<toArea>5__5");
				ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, 100671198);
				ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, 100671199);
				ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, 100671200);
				ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, 100671201);
				ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, 100671202);
				ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, 100671203);
				ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, 100671204);
				ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr, 100671205);
			}

			// Token: 0x0600718B RID: 29067 RVA: 0x0020F9C4 File Offset: 0x0020DBC4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveShowOfStrength._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600718C RID: 29068 RVA: 0x0020FA0C File Offset: 0x0020DC0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600718D RID: 29069 RVA: 0x0020FA40 File Offset: 0x0020DC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175167, XrefRangeEnd = 175192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001F3E RID: 7998
			// (get) Token: 0x0600718E RID: 29070 RVA: 0x0020FA7C File Offset: 0x0020DC7C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600718F RID: 29071 RVA: 0x0020FABC File Offset: 0x0020DCBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175192, XrefRangeEnd = 175197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001F3F RID: 7999
			// (get) Token: 0x06007190 RID: 29072 RVA: 0x0020FAF0 File Offset: 0x0020DCF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007191 RID: 29073 RVA: 0x0020FB30 File Offset: 0x0020DD30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175197, XrefRangeEnd = 175199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007192 RID: 29074 RVA: 0x0020FB70 File Offset: 0x0020DD70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveShowOfStrength._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007193 RID: 29075 RVA: 0x0002D167 File Offset: 0x0002B367
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001F36 RID: 7990
			// (get) Token: 0x06007194 RID: 29076 RVA: 0x0020FBB0 File Offset: 0x0020DDB0
			// (set) Token: 0x06007195 RID: 29077 RVA: 0x0002D170 File Offset: 0x0002B370
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001F37 RID: 7991
			// (get) Token: 0x06007196 RID: 29078 RVA: 0x0020FBD8 File Offset: 0x0020DDD8
			// (set) Token: 0x06007197 RID: 29079 RVA: 0x0002D18B File Offset: 0x0002B38B
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F38 RID: 7992
			// (get) Token: 0x06007198 RID: 29080 RVA: 0x0020FC08 File Offset: 0x0020DE08
			// (set) Token: 0x06007199 RID: 29081 RVA: 0x0002D1AA File Offset: 0x0002B3AA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001F39 RID: 7993
			// (get) Token: 0x0600719A RID: 29082 RVA: 0x0020FC30 File Offset: 0x0020DE30
			// (set) Token: 0x0600719B RID: 29083 RVA: 0x0002D1C5 File Offset: 0x0002B3C5
			public unsafe ResolveShowOfStrength __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveShowOfStrength>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F3A RID: 7994
			// (get) Token: 0x0600719C RID: 29084 RVA: 0x0020FC60 File Offset: 0x0020DE60
			// (set) Token: 0x0600719D RID: 29085 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F3B RID: 7995
			// (get) Token: 0x0600719E RID: 29086 RVA: 0x0020FC90 File Offset: 0x0020DE90
			// (set) Token: 0x0600719F RID: 29087 RVA: 0x0002D203 File Offset: 0x0002B403
			public unsafe WormMatch _wormMatch_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__wormMatch_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__wormMatch_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F3C RID: 7996
			// (get) Token: 0x060071A0 RID: 29088 RVA: 0x0020FCC0 File Offset: 0x0020DEC0
			// (set) Token: 0x060071A1 RID: 29089 RVA: 0x0002D222 File Offset: 0x0002B422
			public unsafe Entity _card_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__card_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__card_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F3D RID: 7997
			// (get) Token: 0x060071A2 RID: 29090 RVA: 0x0020FCF0 File Offset: 0x0020DEF0
			// (set) Token: 0x060071A3 RID: 29091 RVA: 0x0002D241 File Offset: 0x0002B441
			public unsafe CardToAreas _toArea_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__toArea_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveShowOfStrength._execute_d__3.NativeFieldInfoPtr__toArea_5__5)) = value;
				}
			}

			// Token: 0x04004959 RID: 18777
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400495A RID: 18778
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400495B RID: 18779
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400495C RID: 18780
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400495D RID: 18781
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x0400495E RID: 18782
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__3;

			// Token: 0x0400495F RID: 18783
			private static readonly IntPtr NativeFieldInfoPtr__card_5__4;

			// Token: 0x04004960 RID: 18784
			private static readonly IntPtr NativeFieldInfoPtr__toArea_5__5;

			// Token: 0x04004961 RID: 18785
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004962 RID: 18786
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004963 RID: 18787
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004964 RID: 18788
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004965 RID: 18789
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004966 RID: 18790
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004967 RID: 18791
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004968 RID: 18792
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
