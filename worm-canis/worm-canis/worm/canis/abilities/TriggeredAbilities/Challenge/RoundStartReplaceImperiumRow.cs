using System;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.abilities.TriggeredAbilities.Challenge
{
	// Token: 0x02000392 RID: 914
	public class RoundStartReplaceImperiumRow : ReplaceImperiumRow
	{
		// Token: 0x06002619 RID: 9753 RVA: 0x000F2BBC File Offset: 0x000F0DBC
		// Note: this type is marked as 'beforefieldinit'.
		static RoundStartReplaceImperiumRow()
		{
			Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge", "RoundStartReplaceImperiumRow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr);
			RoundStartReplaceImperiumRow.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr, "AbilityName");
			RoundStartReplaceImperiumRow.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr, "AbilityID");
			RoundStartReplaceImperiumRow.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr, 100673914);
			RoundStartReplaceImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr, 100673915);
			RoundStartReplaceImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr, 100673916);
			RoundStartReplaceImperiumRow.NativeMethodInfoPtr_get_TriggeringEvent_Protected_Virtual_get_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr, 100673917);
			RoundStartReplaceImperiumRow.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr, 100673918);
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x000F2C78 File Offset: 0x000F0E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191240, XrefRangeEnd = 191244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundStartReplaceImperiumRow.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x000F2CC4 File Offset: 0x000F0EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191244, XrefRangeEnd = 191247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundStartReplaceImperiumRow(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x000F2D10 File Offset: 0x000F0F10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundStartReplaceImperiumRow(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x000F2D80 File Offset: 0x000F0F80
		public unsafe override SerializableEvent TriggeringEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundStartReplaceImperiumRow.NativeMethodInfoPtr_get_TriggeringEvent_Protected_Virtual_get_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000F2DCC File Offset: 0x000F0FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191247, XrefRangeEnd = 191254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundStartReplaceImperiumRow.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x0000EA6A File Offset: 0x0000CC6A
		public RoundStartReplaceImperiumRow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x000F2E28 File Offset: 0x000F1028
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0000EA73 File Offset: 0x0000CC73
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RoundStartReplaceImperiumRow.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RoundStartReplaceImperiumRow.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000F2E48 File Offset: 0x000F1048
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x0000EA85 File Offset: 0x0000CC85
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RoundStartReplaceImperiumRow.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RoundStartReplaceImperiumRow.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_get_TriggeringEvent_Protected_Virtual_get_SerializableEvent_0;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x020008F1 RID: 2289
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.RoundStartReplaceImperiumRow+<IsValidFor>d__7")]
		public sealed class _IsValidFor_d__7 : Object
		{
			// Token: 0x06008777 RID: 34679 RVA: 0x00250608 File Offset: 0x0024E808
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__7()
			{
				Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundStartReplaceImperiumRow>.NativeClassPtr, "<IsValidFor>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr);
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, "<>1__state");
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, "<>2__current");
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, "<>l__initialThreadId");
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, "<>4__this");
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, "evt");
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, "<>3__evt");
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, 100673920);
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, 100673921);
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, 100673922);
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, 100673923);
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, 100673924);
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, 100673925);
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, 100673926);
				RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr, 100673927);
			}

			// Token: 0x06008778 RID: 34680 RVA: 0x0025074C File Offset: 0x0024E94C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundStartReplaceImperiumRow._IsValidFor_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008779 RID: 34681 RVA: 0x00250794 File Offset: 0x0024E994
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600877A RID: 34682 RVA: 0x002507C8 File Offset: 0x0024E9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191218, XrefRangeEnd = 191226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002725 RID: 10021
			// (get) Token: 0x0600877B RID: 34683 RVA: 0x00250804 File Offset: 0x0024EA04
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x0600877C RID: 34684 RVA: 0x00250844 File Offset: 0x0024EA44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191226, XrefRangeEnd = 191231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002726 RID: 10022
			// (get) Token: 0x0600877D RID: 34685 RVA: 0x00250878 File Offset: 0x0024EA78
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600877E RID: 34686 RVA: 0x002508B8 File Offset: 0x0024EAB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191231, XrefRangeEnd = 191240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x0600877F RID: 34687 RVA: 0x002508F8 File Offset: 0x0024EAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008780 RID: 34688 RVA: 0x0003960A File Offset: 0x0003780A
			public _IsValidFor_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700271F RID: 10015
			// (get) Token: 0x06008781 RID: 34689 RVA: 0x00250938 File Offset: 0x0024EB38
			// (set) Token: 0x06008782 RID: 34690 RVA: 0x00039613 File Offset: 0x00037813
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002720 RID: 10016
			// (get) Token: 0x06008783 RID: 34691 RVA: 0x00250960 File Offset: 0x0024EB60
			// (set) Token: 0x06008784 RID: 34692 RVA: 0x0003962E File Offset: 0x0003782E
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002721 RID: 10017
			// (get) Token: 0x06008785 RID: 34693 RVA: 0x00250990 File Offset: 0x0024EB90
			// (set) Token: 0x06008786 RID: 34694 RVA: 0x0003964D File Offset: 0x0003784D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002722 RID: 10018
			// (get) Token: 0x06008787 RID: 34695 RVA: 0x002509B8 File Offset: 0x0024EBB8
			// (set) Token: 0x06008788 RID: 34696 RVA: 0x00039668 File Offset: 0x00037868
			public unsafe RoundStartReplaceImperiumRow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundStartReplaceImperiumRow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002723 RID: 10019
			// (get) Token: 0x06008789 RID: 34697 RVA: 0x002509E8 File Offset: 0x0024EBE8
			// (set) Token: 0x0600878A RID: 34698 RVA: 0x00039687 File Offset: 0x00037887
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002724 RID: 10020
			// (get) Token: 0x0600878B RID: 34699 RVA: 0x00250A18 File Offset: 0x0024EC18
			// (set) Token: 0x0600878C RID: 34700 RVA: 0x000396A6 File Offset: 0x000378A6
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundStartReplaceImperiumRow._IsValidFor_d__7.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040056AB RID: 22187
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040056AC RID: 22188
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040056AD RID: 22189
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040056AE RID: 22190
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040056AF RID: 22191
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x040056B0 RID: 22192
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x040056B1 RID: 22193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040056B2 RID: 22194
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040056B3 RID: 22195
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040056B4 RID: 22196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x040056B5 RID: 22197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040056B6 RID: 22198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040056B7 RID: 22199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x040056B8 RID: 22200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
