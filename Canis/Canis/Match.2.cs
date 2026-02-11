using System;
using Canis.actions;
using Canis.entities;
using Canis.messageRouters;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis
{
	// Token: 0x02000024 RID: 36
	public class Match<TPlayer> : Match where TPlayer : PlayerEntity
	{
		// Token: 0x0600024C RID: 588 RVA: 0x000230E4 File Offset: 0x000212E4
		// Note: this type is marked as 'beforefieldinit'.
		static Match()
		{
			Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "Match`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr);
			Match<TPlayer>.NativeFieldInfoPtr__Players_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, "<Players>k__BackingField");
			Match<TPlayer>.NativeFieldInfoPtr__PlayersMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, "<PlayersMap>k__BackingField");
			Match<TPlayer>.NativeMethodInfoPtr_get_Players_Public_get_List_1_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663870);
			Match<TPlayer>.NativeMethodInfoPtr_get_PlayersMap_Public_get_Dictionary_2_AccountID_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663871);
			Match<TPlayer>.NativeMethodInfoPtr_get_BasicPlayers_Public_Virtual_get_IEnumerable_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663872);
			Match<TPlayer>.NativeMethodInfoPtr_get_PlayersEnumerable_Public_Virtual_Final_New_get_IEnumerable_1_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663873);
			Match<TPlayer>.NativeMethodInfoPtr_GenTimerRouter_Protected_Virtual_New_MessageRouter_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663874);
			Match<TPlayer>.NativeMethodInfoPtr_ShouldSaveExecutionStack_Protected_Virtual_New_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663875);
			Match<TPlayer>.NativeMethodInfoPtr_GenPlaymat_Protected_Abstract_Virtual_New_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663876);
			Match<TPlayer>.NativeMethodInfoPtr_GenPlaymat_Protected_Abstract_Virtual_New_Entity_SerializedEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663877);
			Match<TPlayer>.NativeMethodInfoPtr_GenInitialAction_Protected_Abstract_Virtual_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663878);
			Match<TPlayer>.NativeMethodInfoPtr_GenResumeAction_Protected_Abstract_Virtual_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663879);
			Match<TPlayer>.NativeMethodInfoPtr_get_TimerMessages_Protected_Virtual_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663880);
			Match<TPlayer>.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663881);
			Match<TPlayer>.NativeMethodInfoPtr_StartNewMatch_Protected_Virtual_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663882);
			Match<TPlayer>.NativeMethodInfoPtr_DeserializeMatch_Protected_Virtual_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663883);
			Match<TPlayer>.NativeMethodInfoPtr_InitializeNewMatch_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663884);
			Match<TPlayer>.NativeMethodInfoPtr_ReinitializeMatch_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663885);
			Match<TPlayer>.NativeMethodInfoPtr_CreatePlayers_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663886);
			Match<TPlayer>.NativeMethodInfoPtr_InitializePlayers_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663887);
			Match<TPlayer>.NativeMethodInfoPtr_PlayerTutorialInit_Protected_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663888);
			Match<TPlayer>.NativeMethodInfoPtr_SetScenarioAction_Protected_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663889);
			Match<TPlayer>.NativeMethodInfoPtr_CacheAccountIDs_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663890);
			Match<TPlayer>.NativeMethodInfoPtr_SetAnalyticsGameData_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663891);
			Match<TPlayer>.NativeMethodInfoPtr_LogAnalyticsGameStart_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663892);
			Match<TPlayer>.NativeMethodInfoPtr_CleanupGameFailure_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663893);
			Match<TPlayer>.NativeMethodInfoPtr_AddPlayer_Public_Virtual_Void_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663894);
			Match<TPlayer>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr, 100663895);
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00023380 File Offset: 0x00021580
		public unsafe List<TPlayer> Players
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match<TPlayer>.NativeMethodInfoPtr_get_Players_Public_get_List_1_TPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000233C0 File Offset: 0x000215C0
		public unsafe Dictionary<AccountID, TPlayer> PlayersMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match<TPlayer>.NativeMethodInfoPtr_get_PlayersMap_Public_get_Dictionary_2_AccountID_TPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, TPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00023400 File Offset: 0x00021600
		public unsafe override IEnumerable<PlayerEntity> BasicPlayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_get_BasicPlayers_Public_Virtual_get_IEnumerable_1_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0002344C File Offset: 0x0002164C
		public unsafe virtual IEnumerable<TPlayer> PlayersEnumerable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match<TPlayer>.NativeMethodInfoPtr_get_PlayersEnumerable_Public_Virtual_Final_New_get_IEnumerable_1_TPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0002348C File Offset: 0x0002168C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548394, XrefRangeEnd = 548398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MessageRouter GenTimerRouter(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_GenTimerRouter_Protected_Virtual_New_MessageRouter_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageRouter>(intPtr3) : null;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000234E8 File Offset: 0x000216E8
		[CallerCount(0)]
		public unsafe virtual bool ShouldSaveExecutionStack(MatchInitData mid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_ShouldSaveExecutionStack_Protected_Virtual_New_Boolean_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00023540 File Offset: 0x00021740
		[CallerCount(0)]
		public unsafe virtual Entity GenPlaymat(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_GenPlaymat_Protected_Abstract_Virtual_New_Entity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0002359C File Offset: 0x0002179C
		[CallerCount(0)]
		public unsafe virtual Entity GenPlaymat(SerializedEntity entities, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_GenPlaymat_Protected_Abstract_Virtual_New_Entity_SerializedEntity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0002360C File Offset: 0x0002180C
		[CallerCount(0)]
		public unsafe virtual Canis.actions.Action GenInitialAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_GenInitialAction_Protected_Abstract_Virtual_New_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00023668 File Offset: 0x00021868
		[CallerCount(0)]
		public unsafe virtual Canis.actions.Action GenResumeAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_GenResumeAction_Protected_Abstract_Virtual_New_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000236C4 File Offset: 0x000218C4
		public unsafe virtual IEnumerable<string> TimerMessages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548398, XrefRangeEnd = 548413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_get_TimerMessages_Protected_Virtual_New_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00023710 File Offset: 0x00021910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548413, XrefRangeEnd = 548451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0002374C File Offset: 0x0002194C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548458, RefRangeEnd = 548459, XrefRangeStart = 548451, XrefRangeEnd = 548458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action StartNewMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_StartNewMatch_Protected_Virtual_New_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00023798 File Offset: 0x00021998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548459, XrefRangeEnd = 548500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action DeserializeMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_DeserializeMatch_Protected_Virtual_New_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000237E4 File Offset: 0x000219E4
		[CallerCount(0)]
		public unsafe virtual void InitializeNewMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_InitializeNewMatch_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00023820 File Offset: 0x00021A20
		[CallerCount(0)]
		public unsafe virtual void ReinitializeMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_ReinitializeMatch_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0002385C File Offset: 0x00021A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548502, RefRangeEnd = 548503, XrefRangeStart = 548500, XrefRangeEnd = 548502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreatePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_CreatePlayers_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00023898 File Offset: 0x00021A98
		[CallerCount(0)]
		public unsafe virtual void InitializePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_InitializePlayers_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000238D4 File Offset: 0x00021AD4
		[CallerCount(0)]
		public unsafe virtual void PlayerTutorialInit(bool isResume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isResume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_PlayerTutorialInit_Protected_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00023920 File Offset: 0x00021B20
		[CallerCount(0)]
		public unsafe virtual void SetScenarioAction(bool isResume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isResume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_SetScenarioAction_Protected_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0002396C File Offset: 0x00021B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548503, XrefRangeEnd = 548533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CacheAccountIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_CacheAccountIDs_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000239A8 File Offset: 0x00021BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548533, XrefRangeEnd = 548572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAnalyticsGameData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_SetAnalyticsGameData_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000239E4 File Offset: 0x00021BE4
		[CallerCount(0)]
		public unsafe virtual void LogAnalyticsGameStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_LogAnalyticsGameStart_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00023A20 File Offset: 0x00021C20
		[CallerCount(0)]
		public unsafe virtual void CleanupGameFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_CleanupGameFailure_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00023A5C File Offset: 0x00021C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548572, XrefRangeEnd = 548605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddPlayer(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match<TPlayer>.NativeMethodInfoPtr_AddPlayer_Public_Virtual_Void_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00023AAC File Offset: 0x00021CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548614, RefRangeEnd = 548615, XrefRangeStart = 548605, XrefRangeEnd = 548614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match<TPlayer>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match<TPlayer>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002EC2 File Offset: 0x000010C2
		public Match(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00023AE8 File Offset: 0x00021CE8
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002ECB File Offset: 0x000010CB
		public unsafe List<TPlayer> _Players_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match<TPlayer>.NativeFieldInfoPtr__Players_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TPlayer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match<TPlayer>.NativeFieldInfoPtr__Players_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00023B18 File Offset: 0x00021D18
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00002EEA File Offset: 0x000010EA
		public unsafe Dictionary<AccountID, TPlayer> _PlayersMap_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match<TPlayer>.NativeFieldInfoPtr__PlayersMap_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, TPlayer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match<TPlayer>.NativeFieldInfoPtr__PlayersMap_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr__Players_k__BackingField;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr__PlayersMap_k__BackingField;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_Players_Public_get_List_1_TPlayer_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayersMap_Public_get_Dictionary_2_AccountID_TPlayer_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_BasicPlayers_Public_Virtual_get_IEnumerable_1_PlayerEntity_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayersEnumerable_Public_Virtual_Final_New_get_IEnumerable_1_TPlayer_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_GenTimerRouter_Protected_Virtual_New_MessageRouter_Match_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSaveExecutionStack_Protected_Virtual_New_Boolean_MatchInitData_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_GenPlaymat_Protected_Abstract_Virtual_New_Entity_Match_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_GenPlaymat_Protected_Abstract_Virtual_New_Entity_SerializedEntity_Match_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_GenInitialAction_Protected_Abstract_Virtual_New_Action_Match_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_GenResumeAction_Protected_Abstract_Virtual_New_Action_Match_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerMessages_Protected_Virtual_New_get_IEnumerable_1_String_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_StartNewMatch_Protected_Virtual_New_Action_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeMatch_Protected_Virtual_New_Action_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_InitializeNewMatch_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_ReinitializeMatch_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayers_Protected_Virtual_New_Void_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_InitializePlayers_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_PlayerTutorialInit_Protected_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_SetScenarioAction_Protected_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_CacheAccountIDs_Protected_Virtual_New_Void_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_SetAnalyticsGameData_Protected_Virtual_New_Void_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_LogAnalyticsGameStart_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_CleanupGameFailure_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Virtual_Void_PlayerEntity_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
