using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.entities;

namespace worm.canis.data.enums
{
	// Token: 0x020000CA RID: 202
	public static class EntityNames : Object
	{
		// Token: 0x06000D6D RID: 3437 RVA: 0x00096724 File Offset: 0x00094924
		// Note: this type is marked as 'beforefieldinit'.
		static EntityNames()
		{
			Il2CppClassPointerStore<EntityNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.enums", "EntityNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNames>.NativeClassPtr);
			EntityNames.NativeFieldInfoPtr_Playmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Playmat");
			EntityNames.NativeFieldInfoPtr_LogStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "LogStack");
			EntityNames.NativeFieldInfoPtr_UndoStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "UndoStack");
			EntityNames.NativeFieldInfoPtr_UndoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "UndoNode");
			EntityNames.NativeFieldInfoPtr_UndoAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "UndoAbility");
			EntityNames.NativeFieldInfoPtr_IntrigueDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "IntrigueDeck");
			EntityNames.NativeFieldInfoPtr_IntrigueDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "IntrigueDiscard");
			EntityNames.NativeFieldInfoPtr_ImperiumDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ImperiumDeck");
			EntityNames.NativeFieldInfoPtr_ImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ImperiumRow");
			EntityNames.NativeFieldInfoPtr_HelenaReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "HelenaReserve");
			EntityNames.NativeFieldInfoPtr_ReserveRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ReserveRow");
			EntityNames.NativeFieldInfoPtr_Trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Trash");
			EntityNames.NativeFieldInfoPtr_Box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Box");
			EntityNames.NativeFieldInfoPtr_HagalDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "HagalDeck");
			EntityNames.NativeFieldInfoPtr_HagalDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "HagalDiscard");
			EntityNames.NativeFieldInfoPtr_Board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Board");
			EntityNames.NativeFieldInfoPtr_ConflictDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ConflictDeck");
			EntityNames.NativeFieldInfoPtr_ConflictPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ConflictPile");
			EntityNames.NativeFieldInfoPtr_ConflictArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ConflictArea");
			EntityNames.NativeFieldInfoPtr_FactionTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "FactionTracks");
			EntityNames.NativeFieldInfoPtr_Garrison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Garrison");
			EntityNames.NativeFieldInfoPtr_Deployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Deployed");
			EntityNames.NativeFieldInfoPtr_Space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Space");
			EntityNames.NativeFieldInfoPtr_FactionTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "FactionTrack");
			EntityNames.NativeFieldInfoPtr_TrackSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TrackSpace");
			EntityNames.NativeFieldInfoPtr_AllianceToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "AllianceToken");
			EntityNames.NativeFieldInfoPtr_FactionInfluenceMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "FactionInfluenceMarker");
			EntityNames.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Player");
			EntityNames.NativeFieldInfoPtr_SelectionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "SelectionFilter");
			EntityNames.NativeFieldInfoPtr_PlayArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "PlayArea");
			EntityNames.NativeFieldInfoPtr_ActiveAgentArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ActiveAgentArea");
			EntityNames.NativeFieldInfoPtr_PermanentArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "PermanentArea");
			EntityNames.NativeFieldInfoPtr_Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Hand");
			EntityNames.NativeFieldInfoPtr_Deck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Deck");
			EntityNames.NativeFieldInfoPtr_Discard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Discard");
			EntityNames.NativeFieldInfoPtr_IntrigueHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "IntrigueHand");
			EntityNames.NativeFieldInfoPtr_Supply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Supply");
			EntityNames.NativeFieldInfoPtr_AllianceTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "AllianceTokens");
			EntityNames.NativeFieldInfoPtr_PrivateInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "PrivateInformation");
			EntityNames.NativeFieldInfoPtr_SetAside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "SetAside");
			EntityNames.NativeFieldInfoPtr_ControlMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ControlMarker");
			EntityNames.NativeFieldInfoPtr_Leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Leader");
			EntityNames.NativeFieldInfoPtr_AgentSupply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "AgentSupply");
			EntityNames.NativeFieldInfoPtr_HagalIntrigue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "HagalIntrigue");
			EntityNames.NativeFieldInfoPtr_HagalWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "HagalWater");
			EntityNames.NativeFieldInfoPtr_HagalSolari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "HagalSolari");
			EntityNames.NativeFieldInfoPtr_HagalSpice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "HagalSpice");
			EntityNames.NativeFieldInfoPtr_TheSpiceMustFlowVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TheSpiceMustFlowVP");
			EntityNames.NativeFieldInfoPtr_StartingVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "StartingVP");
			EntityNames.NativeFieldInfoPtr_ChallengeVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ChallengeVP");
			EntityNames.NativeFieldInfoPtr_ImperiumPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ImperiumPlayable");
			EntityNames.NativeFieldInfoPtr_ConflictPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ConflictPlayable");
			EntityNames.NativeFieldInfoPtr_IntriguePlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "IntriguePlayable");
			EntityNames.NativeFieldInfoPtr_HagalPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "HagalPlayable");
			EntityNames.NativeFieldInfoPtr_Troop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Troop");
			EntityNames.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Agent");
			EntityNames.NativeFieldInfoPtr_Mentat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Mentat");
			EntityNames.NativeFieldInfoPtr_Dreadnought = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Dreadnought");
			EntityNames.NativeFieldInfoPtr_ShippingMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ShippingMarker");
			EntityNames.NativeFieldInfoPtr_ShippingTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ShippingTrack");
			EntityNames.NativeFieldInfoPtr_TechTileStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TechTileStacks");
			EntityNames.NativeFieldInfoPtr_TechTileStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TechTileStack");
			EntityNames.NativeFieldInfoPtr_TechTileTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TechTileTop");
			EntityNames.NativeFieldInfoPtr_TechTileHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TechTileHidden");
			EntityNames.NativeFieldInfoPtr_TechTileArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TechTileArea");
			EntityNames.NativeFieldInfoPtr_TechTilePlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TechTilePlayable");
			EntityNames.NativeFieldInfoPtr_TechNegotiationArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TechNegotiationArea");
			EntityNames.NativeFieldInfoPtr_Negotiators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Negotiators");
			EntityNames.NativeFieldInfoPtr_TleilaxuMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TleilaxuMarker");
			EntityNames.NativeFieldInfoPtr_TleilaxuTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TleilaxuTrack");
			EntityNames.NativeFieldInfoPtr_TleilaxuDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TleilaxuDeck");
			EntityNames.NativeFieldInfoPtr_TleilaxuRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TleilaxuRow");
			EntityNames.NativeFieldInfoPtr_TleilaxuTank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "TleilaxuTank");
			EntityNames.NativeFieldInfoPtr_ResearchTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ResearchTrack");
			EntityNames.NativeFieldInfoPtr_Abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "Abilities");
			EntityNames.NativeFieldInfoPtr_ActiveAbilityStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ActiveAbilityStack");
			EntityNames.NativeFieldInfoPtr_ActiveAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "ActiveAbility");
			EntityNames.NativeMethodInfoPtr_WormPlayAreaDeser_Public_Static_WormPlayArea_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, 100665833);
			EntityNames.NativeMethodInfoPtr_WormLeaderDeser_Private_Static_WormLeader_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, 100665834);
			EntityNames.NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, 100665835);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00096D94 File Offset: 0x00094F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76035, XrefRangeEnd = 76039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormPlayArea WormPlayAreaDeser(SerializedEntity se, Match match, Entity parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.NativeMethodInfoPtr_WormPlayAreaDeser_Public_Static_WormPlayArea_SerializedEntity_Match_Entity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00096DFC File Offset: 0x00094FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76039, XrefRangeEnd = 76073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormLeader WormLeaderDeser(SerializedEntity se, Match match, Entity parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.NativeMethodInfoPtr_WormLeaderDeser_Private_Static_WormLeader_SerializedEntity_Match_Entity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormLeader>(intPtr3) : null;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00096E64 File Offset: 0x00095064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76111, RefRangeEnd = 76112, XrefRangeStart = 76073, XrefRangeEnd = 76111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEntityName Get(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntityName>(intPtr3) : null;
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0000716E File Offset: 0x0000536E
		public EntityNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00096EA8 File Offset: 0x000950A8
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x00007177 File Offset: 0x00005377
		public unsafe static EntityName Playmat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Playmat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Playmat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00096ED0 File Offset: 0x000950D0
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x00007189 File Offset: 0x00005389
		public unsafe static EntityNameForParent<WormPlaymat> LogStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_LogStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_LogStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00096EF8 File Offset: 0x000950F8
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x0000719B File Offset: 0x0000539B
		public unsafe static EntityNameForParent<WormPlaymat> UndoStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_UndoStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_UndoStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00096F20 File Offset: 0x00095120
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x000071AD File Offset: 0x000053AD
		public unsafe static EntityName UndoNode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_UndoNode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_UndoNode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00096F48 File Offset: 0x00095148
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x000071BF File Offset: 0x000053BF
		public unsafe static EntityNameForParent<WormPlaymat> UndoAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_UndoAbility, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_UndoAbility, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00096F70 File Offset: 0x00095170
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x000071D1 File Offset: 0x000053D1
		public unsafe static EntityNameForParent<WormPlaymat> IntrigueDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_IntrigueDeck, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_IntrigueDeck, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00096F98 File Offset: 0x00095198
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x000071E3 File Offset: 0x000053E3
		public unsafe static EntityNameForParent<WormPlaymat> IntrigueDiscard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_IntrigueDiscard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_IntrigueDiscard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00096FC0 File Offset: 0x000951C0
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x000071F5 File Offset: 0x000053F5
		public unsafe static EntityNameForParent<WormPlaymat> ImperiumDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ImperiumDeck, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ImperiumDeck, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00096FE8 File Offset: 0x000951E8
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00007207 File Offset: 0x00005407
		public unsafe static EntityNameForParent<WormPlaymat> ImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ImperiumRow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ImperiumRow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00097010 File Offset: 0x00095210
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00007219 File Offset: 0x00005419
		public unsafe static EntityNameForParent<WormPlaymat> HelenaReserve
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_HelenaReserve, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_HelenaReserve, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00097038 File Offset: 0x00095238
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x0000722B File Offset: 0x0000542B
		public unsafe static EntityNameForParent<WormPlaymat> ReserveRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ReserveRow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ReserveRow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00097060 File Offset: 0x00095260
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x0000723D File Offset: 0x0000543D
		public unsafe static EntityNameForParent<WormPlaymat> Trash
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Trash, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Trash, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00097088 File Offset: 0x00095288
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x0000724F File Offset: 0x0000544F
		public unsafe static EntityNameForParent<WormPlaymat> Box
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Box, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Box, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x000970B0 File Offset: 0x000952B0
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x00007261 File Offset: 0x00005461
		public unsafe static EntityNameForParent<WormPlaymat> HagalDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_HagalDeck, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_HagalDeck, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x000970D8 File Offset: 0x000952D8
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00007273 File Offset: 0x00005473
		public unsafe static EntityNameForParent<WormPlaymat> HagalDiscard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_HagalDiscard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_HagalDiscard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00097100 File Offset: 0x00095300
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00007285 File Offset: 0x00005485
		public unsafe static EntityNameForParent<WormPlaymat> Board
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Board, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Board, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00097128 File Offset: 0x00095328
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00007297 File Offset: 0x00005497
		public unsafe static EntityNameForParent<WormBoard> ConflictDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ConflictDeck, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ConflictDeck, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00097150 File Offset: 0x00095350
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x000072A9 File Offset: 0x000054A9
		public unsafe static EntityNameForParent<WormBoard> ConflictPile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ConflictPile, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ConflictPile, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00097178 File Offset: 0x00095378
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x000072BB File Offset: 0x000054BB
		public unsafe static EntityNameForParent<WormBoard> ConflictArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ConflictArea, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ConflictArea, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000971A0 File Offset: 0x000953A0
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x000072CD File Offset: 0x000054CD
		public unsafe static EntityNameForParent<WormBoard> FactionTracks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_FactionTracks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_FactionTracks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x000971C8 File Offset: 0x000953C8
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x000072DF File Offset: 0x000054DF
		public unsafe static EntityName Garrison
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Garrison, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Garrison, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000971F0 File Offset: 0x000953F0
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000072F1 File Offset: 0x000054F1
		public unsafe static EntityName Deployed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Deployed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Deployed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00097218 File Offset: 0x00095418
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00007303 File Offset: 0x00005503
		public unsafe static EntityName Space
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Space, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Space, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00097240 File Offset: 0x00095440
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00007315 File Offset: 0x00005515
		public unsafe static EntityName FactionTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_FactionTrack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_FactionTrack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00097268 File Offset: 0x00095468
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00007327 File Offset: 0x00005527
		public unsafe static EntityName TrackSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TrackSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TrackSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00097290 File Offset: 0x00095490
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00007339 File Offset: 0x00005539
		public unsafe static EntityName AllianceToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_AllianceToken, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_AllianceToken, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x000972B8 File Offset: 0x000954B8
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x0000734B File Offset: 0x0000554B
		public unsafe static EntityName FactionInfluenceMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_FactionInfluenceMarker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_FactionInfluenceMarker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x000972E0 File Offset: 0x000954E0
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x0000735D File Offset: 0x0000555D
		public unsafe static EntityName Player
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Player, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Player, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00097308 File Offset: 0x00095508
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x0000736F File Offset: 0x0000556F
		public unsafe static EntityNameForParent<WormPlayer> SelectionFilter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_SelectionFilter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_SelectionFilter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00097330 File Offset: 0x00095530
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00007381 File Offset: 0x00005581
		public unsafe static EntityNameForParent<WormPlayer> PlayArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_PlayArea, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_PlayArea, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x00097358 File Offset: 0x00095558
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x00007393 File Offset: 0x00005593
		public unsafe static EntityNameForParent<WormPlayer> ActiveAgentArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ActiveAgentArea, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ActiveAgentArea, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00097380 File Offset: 0x00095580
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x000073A5 File Offset: 0x000055A5
		public unsafe static EntityNameForParent<WormPlayer> PermanentArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_PermanentArea, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_PermanentArea, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x000973A8 File Offset: 0x000955A8
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x000073B7 File Offset: 0x000055B7
		public unsafe static EntityNameForParent<WormPlayer> Hand
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Hand, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Hand, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x000973D0 File Offset: 0x000955D0
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x000073C9 File Offset: 0x000055C9
		public unsafe static EntityNameForParent<WormPlayer> Deck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Deck, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Deck, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x000973F8 File Offset: 0x000955F8
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x000073DB File Offset: 0x000055DB
		public unsafe static EntityNameForParent<WormPlayer> Discard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Discard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Discard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00097420 File Offset: 0x00095620
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x000073ED File Offset: 0x000055ED
		public unsafe static EntityNameForParent<WormPlayer> IntrigueHand
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_IntrigueHand, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_IntrigueHand, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00097448 File Offset: 0x00095648
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x000073FF File Offset: 0x000055FF
		public unsafe static EntityNameForParent<WormPlayer> Supply
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Supply, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Supply, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00097470 File Offset: 0x00095670
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00007411 File Offset: 0x00005611
		public unsafe static EntityNameForParent<WormPlayer> AllianceTokens
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_AllianceTokens, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_AllianceTokens, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x00097498 File Offset: 0x00095698
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x00007423 File Offset: 0x00005623
		public unsafe static EntityNameForParent<WormPlayer> PrivateInformation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_PrivateInformation, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_PrivateInformation, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x000974C0 File Offset: 0x000956C0
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x00007435 File Offset: 0x00005635
		public unsafe static EntityNameForParent<WormPlayer> SetAside
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_SetAside, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_SetAside, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x000974E8 File Offset: 0x000956E8
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00007447 File Offset: 0x00005647
		public unsafe static EntityName ControlMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ControlMarker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ControlMarker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00097510 File Offset: 0x00095710
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00007459 File Offset: 0x00005659
		public unsafe static EntityNameForParent<WormPlayer> Leader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Leader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Leader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00097538 File Offset: 0x00095738
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x0000746B File Offset: 0x0000566B
		public unsafe static EntityNameForParent<WormLeader> AgentSupply
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_AgentSupply, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormLeader>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_AgentSupply, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00097560 File Offset: 0x00095760
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x0000747D File Offset: 0x0000567D
		public unsafe static EntityName HagalIntrigue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_HagalIntrigue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_HagalIntrigue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00097588 File Offset: 0x00095788
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x0000748F File Offset: 0x0000568F
		public unsafe static EntityName HagalWater
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_HagalWater, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_HagalWater, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x000975B0 File Offset: 0x000957B0
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x000074A1 File Offset: 0x000056A1
		public unsafe static EntityName HagalSolari
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_HagalSolari, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_HagalSolari, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x000975D8 File Offset: 0x000957D8
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x000074B3 File Offset: 0x000056B3
		public unsafe static EntityName HagalSpice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_HagalSpice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_HagalSpice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00097600 File Offset: 0x00095800
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x000074C5 File Offset: 0x000056C5
		public unsafe static EntityName TheSpiceMustFlowVP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TheSpiceMustFlowVP, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TheSpiceMustFlowVP, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00097628 File Offset: 0x00095828
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x000074D7 File Offset: 0x000056D7
		public unsafe static EntityName StartingVP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_StartingVP, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_StartingVP, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00097650 File Offset: 0x00095850
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x000074E9 File Offset: 0x000056E9
		public unsafe static EntityName ChallengeVP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ChallengeVP, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ChallengeVP, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00097678 File Offset: 0x00095878
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x000074FB File Offset: 0x000056FB
		public unsafe static EntityName ImperiumPlayable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ImperiumPlayable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ImperiumPlayable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000976A0 File Offset: 0x000958A0
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x0000750D File Offset: 0x0000570D
		public unsafe static EntityName ConflictPlayable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ConflictPlayable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ConflictPlayable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x000976C8 File Offset: 0x000958C8
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x0000751F File Offset: 0x0000571F
		public unsafe static EntityName IntriguePlayable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_IntriguePlayable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_IntriguePlayable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000976F0 File Offset: 0x000958F0
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00007531 File Offset: 0x00005731
		public unsafe static EntityName HagalPlayable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_HagalPlayable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_HagalPlayable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00097718 File Offset: 0x00095918
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00007543 File Offset: 0x00005743
		public unsafe static EntityName Troop
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Troop, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Troop, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00097740 File Offset: 0x00095940
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00007555 File Offset: 0x00005755
		public unsafe static EntityName Agent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Agent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Agent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00097768 File Offset: 0x00095968
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00007567 File Offset: 0x00005767
		public unsafe static EntityName Mentat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Mentat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Mentat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00097790 File Offset: 0x00095990
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00007579 File Offset: 0x00005779
		public unsafe static EntityName Dreadnought
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Dreadnought, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Dreadnought, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x000977B8 File Offset: 0x000959B8
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x0000758B File Offset: 0x0000578B
		public unsafe static EntityName ShippingMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ShippingMarker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ShippingMarker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x000977E0 File Offset: 0x000959E0
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0000759D File Offset: 0x0000579D
		public unsafe static EntityNameForParent<WormBoard> ShippingTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ShippingTrack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ShippingTrack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00097808 File Offset: 0x00095A08
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x000075AF File Offset: 0x000057AF
		public unsafe static EntityNameForParent<WormBoard> TechTileStacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TechTileStacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TechTileStacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00097830 File Offset: 0x00095A30
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x000075C1 File Offset: 0x000057C1
		public unsafe static EntityName TechTileStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TechTileStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TechTileStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00097858 File Offset: 0x00095A58
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x000075D3 File Offset: 0x000057D3
		public unsafe static EntityNameForParent<WormTechTileStack> TechTileTop
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TechTileTop, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormTechTileStack>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TechTileTop, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00097880 File Offset: 0x00095A80
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x000075E5 File Offset: 0x000057E5
		public unsafe static EntityNameForParent<WormTechTileStack> TechTileHidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TechTileHidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormTechTileStack>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TechTileHidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x000978A8 File Offset: 0x00095AA8
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x000075F7 File Offset: 0x000057F7
		public unsafe static EntityNameForParent<WormPlayer> TechTileArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TechTileArea, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TechTileArea, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x000978D0 File Offset: 0x00095AD0
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x00007609 File Offset: 0x00005809
		public unsafe static EntityName TechTilePlayable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TechTilePlayable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TechTilePlayable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x000978F8 File Offset: 0x00095AF8
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x0000761B File Offset: 0x0000581B
		public unsafe static EntityNameForParent<WormBoard> TechNegotiationArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TechNegotiationArea, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TechNegotiationArea, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00097920 File Offset: 0x00095B20
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x0000762D File Offset: 0x0000582D
		public unsafe static EntityName Negotiators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Negotiators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Negotiators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00097948 File Offset: 0x00095B48
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x0000763F File Offset: 0x0000583F
		public unsafe static EntityName TleilaxuMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TleilaxuMarker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TleilaxuMarker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00097970 File Offset: 0x00095B70
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00007651 File Offset: 0x00005851
		public unsafe static EntityNameForParent<WormBoard> TleilaxuTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TleilaxuTrack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TleilaxuTrack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00097998 File Offset: 0x00095B98
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x00007663 File Offset: 0x00005863
		public unsafe static EntityNameForParent<WormPlaymat> TleilaxuDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TleilaxuDeck, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TleilaxuDeck, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x000979C0 File Offset: 0x00095BC0
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00007675 File Offset: 0x00005875
		public unsafe static EntityNameForParent<WormPlaymat> TleilaxuRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TleilaxuRow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormPlaymat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TleilaxuRow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x000979E8 File Offset: 0x00095BE8
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00007687 File Offset: 0x00005887
		public unsafe static EntityNameForParent<WormBoard> TleilaxuTank
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_TleilaxuTank, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_TleilaxuTank, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00097A10 File Offset: 0x00095C10
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x00007699 File Offset: 0x00005899
		public unsafe static EntityNameForParent<WormBoard> ResearchTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ResearchTrack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<WormBoard>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ResearchTrack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00097A38 File Offset: 0x00095C38
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x000076AB File Offset: 0x000058AB
		public unsafe static EntityName Abilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_Abilities, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_Abilities, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00097A60 File Offset: 0x00095C60
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x000076BD File Offset: 0x000058BD
		public unsafe static EntityName ActiveAbilityStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ActiveAbilityStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ActiveAbilityStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x00097A88 File Offset: 0x00095C88
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x000076CF File Offset: 0x000058CF
		public unsafe static EntityName ActiveAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNames.NativeFieldInfoPtr_ActiveAbility, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNames.NativeFieldInfoPtr_ActiveAbility, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr_Playmat;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr_LogStack;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_UndoStack;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_UndoNode;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_UndoAbility;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueDeck;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueDiscard;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumDeck;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumRow;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_HelenaReserve;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_ReserveRow;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_Trash;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_Box;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_HagalDeck;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_HagalDiscard;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_Board;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_ConflictDeck;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr_ConflictPile;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_ConflictArea;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_FactionTracks;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_Garrison;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_Deployed;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_Space;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_FactionTrack;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_TrackSpace;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_AllianceToken;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_FactionInfluenceMarker;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_SelectionFilter;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_PlayArea;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAgentArea;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_PermanentArea;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_Hand;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_Deck;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_Discard;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueHand;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_Supply;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_AllianceTokens;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_PrivateInformation;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_SetAside;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_ControlMarker;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr_Leader;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_AgentSupply;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_HagalIntrigue;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeFieldInfoPtr_HagalWater;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_HagalSolari;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_HagalSpice;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_TheSpiceMustFlowVP;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_StartingVP;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_ChallengeVP;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumPlayable;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_ConflictPlayable;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_IntriguePlayable;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_HagalPlayable;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_Troop;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_Mentat;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr_Dreadnought;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr_ShippingMarker;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_ShippingTrack;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_TechTileStacks;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_TechTileStack;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_TechTileTop;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_TechTileHidden;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_TechTileArea;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_TechTilePlayable;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_TechNegotiationArea;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_Negotiators;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuMarker;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuTrack;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuDeck;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuRow;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuTank;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr_ResearchTrack;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_Abilities;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilityStack;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbility;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_WormPlayAreaDeser_Public_Static_WormPlayArea_SerializedEntity_Match_Entity_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_WormLeaderDeser_Private_Static_WormLeader_SerializedEntity_Match_Entity_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0;

		// Token: 0x02000628 RID: 1576
		[ObfuscatedName("worm.canis.data.enums.EntityNames+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004ED2 RID: 20178 RVA: 0x001A3954 File Offset: 0x001A1B54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityNames>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr);
				EntityNames.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, "<>9");
				EntityNames.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665838);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_0_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665839);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_1_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665840);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_2_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665841);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_3_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665842);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_4_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665843);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_5_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665844);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_6_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665845);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_7_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665846);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_8_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665847);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_9_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665848);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_10_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665849);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_11_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665850);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_12_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665851);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_13_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665852);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_14_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665853);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_15_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665854);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_16_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665855);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_17_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665856);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_18_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665857);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_19_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665858);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_20_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665859);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_21_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665860);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_22_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665861);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_23_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665862);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_24_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665863);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_25_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665864);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_26_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665865);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_27_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665866);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_28_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665867);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_29_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665868);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_30_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665869);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_31_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665870);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_32_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665871);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_33_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665872);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_34_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665873);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_35_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665874);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_36_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665875);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_37_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665876);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_38_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665877);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_39_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665878);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_40_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665879);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_41_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665880);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_42_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665881);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_43_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665882);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_44_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665883);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_45_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665884);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_46_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665885);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_47_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665886);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_48_Internal_Void_Entity_WormLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665887);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_49_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665888);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_50_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665889);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_51_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665890);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_52_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665891);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_53_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665892);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_54_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665893);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_55_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665894);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_56_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665895);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_57_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665896);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_58_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665897);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_59_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665898);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_60_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665899);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_61_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665900);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_62_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665901);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_63_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665902);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_64_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665903);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_65_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665904);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_66_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665905);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_67_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665906);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_68_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665907);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_69_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665908);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_70_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665909);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_71_Internal_Void_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665910);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_72_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665911);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_73_Internal_Void_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665912);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_74_Internal_Void_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665913);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_75_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665914);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_76_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665915);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_77_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665916);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_78_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665917);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_79_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665918);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_80_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665919);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_81_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665920);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_82_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665921);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_83_Internal_Void_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665922);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_84_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665923);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_85_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665924);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_86_Internal_Void_Entity_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665925);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_87_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665926);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_88_Internal_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665927);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_89_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665928);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_90_Internal_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665929);
				EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_91_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr, 100665930);
			}

			// Token: 0x06004ED3 RID: 20179 RVA: 0x001A40D8 File Offset: 0x001A22D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityNames.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ED4 RID: 20180 RVA: 0x001A4114 File Offset: 0x001A2314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75599, XrefRangeEnd = 75603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_0(SerializedEntity se, Match m, Entity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_0_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004ED5 RID: 20181 RVA: 0x001A4188 File Offset: 0x001A2388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75603, XrefRangeEnd = 75611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_1(Entity ent, WormPlaymat wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_1_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ED6 RID: 20182 RVA: 0x001A41DC File Offset: 0x001A23DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75611, XrefRangeEnd = 75613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_2(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_2_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ED7 RID: 20183 RVA: 0x001A4230 File Offset: 0x001A2430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75613, XrefRangeEnd = 75617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_3(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_3_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004ED8 RID: 20184 RVA: 0x001A42A4 File Offset: 0x001A24A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75617, XrefRangeEnd = 75625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_4(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_4_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004ED9 RID: 20185 RVA: 0x001A4318 File Offset: 0x001A2518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75625, XrefRangeEnd = 75633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_5(Entity ent, WormPlaymat tp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_5_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EDA RID: 20186 RVA: 0x001A436C File Offset: 0x001A256C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75633, XrefRangeEnd = 75638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_6(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_6_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EDB RID: 20187 RVA: 0x001A43C0 File Offset: 0x001A25C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75638, XrefRangeEnd = 75643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_7(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_7_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EDC RID: 20188 RVA: 0x001A4414 File Offset: 0x001A2614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75643, XrefRangeEnd = 75648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_8(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_8_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EDD RID: 20189 RVA: 0x001A4468 File Offset: 0x001A2668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75648, XrefRangeEnd = 75653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_9(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_9_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EDE RID: 20190 RVA: 0x001A44BC File Offset: 0x001A26BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75653, XrefRangeEnd = 75658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_10(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_10_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EDF RID: 20191 RVA: 0x001A4510 File Offset: 0x001A2710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75658, XrefRangeEnd = 75663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_11(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_11_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE0 RID: 20192 RVA: 0x001A4564 File Offset: 0x001A2764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75663, XrefRangeEnd = 75668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_12(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_12_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE1 RID: 20193 RVA: 0x001A45B8 File Offset: 0x001A27B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75668, XrefRangeEnd = 75673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_13(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_13_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE2 RID: 20194 RVA: 0x001A460C File Offset: 0x001A280C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75673, XrefRangeEnd = 75678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_14(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_14_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE3 RID: 20195 RVA: 0x001A4660 File Offset: 0x001A2860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75678, XrefRangeEnd = 75683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_15(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_15_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE4 RID: 20196 RVA: 0x001A46B4 File Offset: 0x001A28B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75683, XrefRangeEnd = 75687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_16(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_16_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EE5 RID: 20197 RVA: 0x001A4728 File Offset: 0x001A2928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75687, XrefRangeEnd = 75692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_17(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_17_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE6 RID: 20198 RVA: 0x001A477C File Offset: 0x001A297C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75692, XrefRangeEnd = 75696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_18(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_18_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EE7 RID: 20199 RVA: 0x001A47F0 File Offset: 0x001A29F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75696, XrefRangeEnd = 75701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_19(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_19_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE8 RID: 20200 RVA: 0x001A4844 File Offset: 0x001A2A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75701, XrefRangeEnd = 75705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_20(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_20_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EE9 RID: 20201 RVA: 0x001A48B8 File Offset: 0x001A2AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75705, XrefRangeEnd = 75710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_21(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_21_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EEA RID: 20202 RVA: 0x001A490C File Offset: 0x001A2B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75710, XrefRangeEnd = 75714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_22(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_22_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EEB RID: 20203 RVA: 0x001A4980 File Offset: 0x001A2B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75714, XrefRangeEnd = 75719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_23(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_23_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EEC RID: 20204 RVA: 0x001A49D4 File Offset: 0x001A2BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75719, XrefRangeEnd = 75723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_24(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_24_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EED RID: 20205 RVA: 0x001A4A48 File Offset: 0x001A2C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75723, XrefRangeEnd = 75728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_25(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_25_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EEE RID: 20206 RVA: 0x001A4A9C File Offset: 0x001A2C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75728, XrefRangeEnd = 75732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_26(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_26_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EEF RID: 20207 RVA: 0x001A4B10 File Offset: 0x001A2D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75732, XrefRangeEnd = 75736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_27(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_27_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EF0 RID: 20208 RVA: 0x001A4B84 File Offset: 0x001A2D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75736, XrefRangeEnd = 75740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_28(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_28_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EF1 RID: 20209 RVA: 0x001A4BF8 File Offset: 0x001A2DF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75740, XrefRangeEnd = 75744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_29(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_29_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EF2 RID: 20210 RVA: 0x001A4C6C File Offset: 0x001A2E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75744, XrefRangeEnd = 75748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_30(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_30_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EF3 RID: 20211 RVA: 0x001A4CE0 File Offset: 0x001A2EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75748, XrefRangeEnd = 75752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_31(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_31_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EF4 RID: 20212 RVA: 0x001A4D54 File Offset: 0x001A2F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75752, XrefRangeEnd = 75756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_32(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_32_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EF5 RID: 20213 RVA: 0x001A4DC8 File Offset: 0x001A2FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75756, XrefRangeEnd = 75760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_33(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_33_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004EF6 RID: 20214 RVA: 0x001A4E3C File Offset: 0x001A303C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75760, XrefRangeEnd = 75762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_34(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_34_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EF7 RID: 20215 RVA: 0x001A4E90 File Offset: 0x001A3090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75762, XrefRangeEnd = 75767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_35(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_35_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EF8 RID: 20216 RVA: 0x001A4EE4 File Offset: 0x001A30E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75767, XrefRangeEnd = 75772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_36(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_36_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EF9 RID: 20217 RVA: 0x001A4F38 File Offset: 0x001A3138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75772, XrefRangeEnd = 75777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_37(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_37_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFA RID: 20218 RVA: 0x001A4F8C File Offset: 0x001A318C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75777, XrefRangeEnd = 75782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_38(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_38_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFB RID: 20219 RVA: 0x001A4FE0 File Offset: 0x001A31E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75782, XrefRangeEnd = 75787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_39(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_39_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFC RID: 20220 RVA: 0x001A5034 File Offset: 0x001A3234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75787, XrefRangeEnd = 75792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_40(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_40_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFD RID: 20221 RVA: 0x001A5088 File Offset: 0x001A3288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75792, XrefRangeEnd = 75797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_41(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_41_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFE RID: 20222 RVA: 0x001A50DC File Offset: 0x001A32DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75797, XrefRangeEnd = 75802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_42(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_42_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EFF RID: 20223 RVA: 0x001A5130 File Offset: 0x001A3330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75802, XrefRangeEnd = 75807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_43(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_43_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F00 RID: 20224 RVA: 0x001A5184 File Offset: 0x001A3384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75807, XrefRangeEnd = 75812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_44(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_44_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F01 RID: 20225 RVA: 0x001A51D8 File Offset: 0x001A33D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75812, XrefRangeEnd = 75817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_45(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_45_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F02 RID: 20226 RVA: 0x001A522C File Offset: 0x001A342C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75817, XrefRangeEnd = 75821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_46(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_46_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F03 RID: 20227 RVA: 0x001A52A0 File Offset: 0x001A34A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75821, XrefRangeEnd = 75827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_47(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_47_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F04 RID: 20228 RVA: 0x001A52F4 File Offset: 0x001A34F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75827, XrefRangeEnd = 75832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_48(Entity ent, WormLeader wl)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_48_Internal_Void_Entity_WormLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F05 RID: 20229 RVA: 0x001A5348 File Offset: 0x001A3548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75832, XrefRangeEnd = 75836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_49(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_49_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F06 RID: 20230 RVA: 0x001A53BC File Offset: 0x001A35BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75836, XrefRangeEnd = 75840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_50(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_50_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F07 RID: 20231 RVA: 0x001A5430 File Offset: 0x001A3630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75840, XrefRangeEnd = 75844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_51(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_51_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F08 RID: 20232 RVA: 0x001A54A4 File Offset: 0x001A36A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75844, XrefRangeEnd = 75848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_52(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_52_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F09 RID: 20233 RVA: 0x001A5518 File Offset: 0x001A3718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75848, XrefRangeEnd = 75852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_53(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_53_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F0A RID: 20234 RVA: 0x001A558C File Offset: 0x001A378C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75852, XrefRangeEnd = 75856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_54(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_54_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F0B RID: 20235 RVA: 0x001A5600 File Offset: 0x001A3800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75856, XrefRangeEnd = 75860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_55(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_55_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F0C RID: 20236 RVA: 0x001A5674 File Offset: 0x001A3874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75860, XrefRangeEnd = 75866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_56(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_56_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F0D RID: 20237 RVA: 0x001A56E8 File Offset: 0x001A38E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75866, XrefRangeEnd = 75872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_57(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_57_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F0E RID: 20238 RVA: 0x001A575C File Offset: 0x001A395C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75872, XrefRangeEnd = 75878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_58(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_58_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F0F RID: 20239 RVA: 0x001A57D0 File Offset: 0x001A39D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75878, XrefRangeEnd = 75884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_59(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_59_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F10 RID: 20240 RVA: 0x001A5844 File Offset: 0x001A3A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75884, XrefRangeEnd = 75888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_60(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_60_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F11 RID: 20241 RVA: 0x001A58B8 File Offset: 0x001A3AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75888, XrefRangeEnd = 75892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_61(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_61_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F12 RID: 20242 RVA: 0x001A592C File Offset: 0x001A3B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75892, XrefRangeEnd = 75896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_62(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_62_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F13 RID: 20243 RVA: 0x001A59A0 File Offset: 0x001A3BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75896, XrefRangeEnd = 75900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_63(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_63_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F14 RID: 20244 RVA: 0x001A5A14 File Offset: 0x001A3C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75900, XrefRangeEnd = 75904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_64(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_64_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F15 RID: 20245 RVA: 0x001A5A88 File Offset: 0x001A3C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75904, XrefRangeEnd = 75908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_65(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_65_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F16 RID: 20246 RVA: 0x001A5AFC File Offset: 0x001A3CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75908, XrefRangeEnd = 75913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_66(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_66_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F17 RID: 20247 RVA: 0x001A5B50 File Offset: 0x001A3D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75913, XrefRangeEnd = 75917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_67(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_67_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F18 RID: 20248 RVA: 0x001A5BC4 File Offset: 0x001A3DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75917, XrefRangeEnd = 75922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_68(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_68_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F19 RID: 20249 RVA: 0x001A5C18 File Offset: 0x001A3E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75922, XrefRangeEnd = 75926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_69(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_69_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F1A RID: 20250 RVA: 0x001A5C8C File Offset: 0x001A3E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75926, XrefRangeEnd = 75930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_70(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_70_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F1B RID: 20251 RVA: 0x001A5D00 File Offset: 0x001A3F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75930, XrefRangeEnd = 75935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_71(Entity ent, WormTechTileStack wtts)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wtts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_71_Internal_Void_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F1C RID: 20252 RVA: 0x001A5D54 File Offset: 0x001A3F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75935, XrefRangeEnd = 75939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_72(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_72_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F1D RID: 20253 RVA: 0x001A5DC8 File Offset: 0x001A3FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75939, XrefRangeEnd = 75944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_73(Entity ent, WormTechTileStack wtts)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wtts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_73_Internal_Void_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F1E RID: 20254 RVA: 0x001A5E1C File Offset: 0x001A401C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75944, XrefRangeEnd = 75949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_74(Entity ent, WormPlayer wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_74_Internal_Void_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F1F RID: 20255 RVA: 0x001A5E70 File Offset: 0x001A4070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75949, XrefRangeEnd = 75955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_75(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_75_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F20 RID: 20256 RVA: 0x001A5EE4 File Offset: 0x001A40E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75955, XrefRangeEnd = 75959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_76(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_76_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F21 RID: 20257 RVA: 0x001A5F58 File Offset: 0x001A4158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75959, XrefRangeEnd = 75964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_77(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_77_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F22 RID: 20258 RVA: 0x001A5FAC File Offset: 0x001A41AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75964, XrefRangeEnd = 75968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_78(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_78_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F23 RID: 20259 RVA: 0x001A6020 File Offset: 0x001A4220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75968, XrefRangeEnd = 75972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_79(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_79_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F24 RID: 20260 RVA: 0x001A6094 File Offset: 0x001A4294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75972, XrefRangeEnd = 75976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_80(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_80_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F25 RID: 20261 RVA: 0x001A6108 File Offset: 0x001A4308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75976, XrefRangeEnd = 75981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_81(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_81_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F26 RID: 20262 RVA: 0x001A615C File Offset: 0x001A435C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75981, XrefRangeEnd = 75986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_82(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_82_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F27 RID: 20263 RVA: 0x001A61B0 File Offset: 0x001A43B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75986, XrefRangeEnd = 75991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_83(Entity ent, WormPlaymat p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_83_Internal_Void_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F28 RID: 20264 RVA: 0x001A6204 File Offset: 0x001A4404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75991, XrefRangeEnd = 75996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_84(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_84_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F29 RID: 20265 RVA: 0x001A6258 File Offset: 0x001A4458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75996, XrefRangeEnd = 76000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_85(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_85_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F2A RID: 20266 RVA: 0x001A62CC File Offset: 0x001A44CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76000, XrefRangeEnd = 76005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_86(Entity ent, WormBoard wb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_86_Internal_Void_Entity_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F2B RID: 20267 RVA: 0x001A6320 File Offset: 0x001A4520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76005, XrefRangeEnd = 76011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_87(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_87_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F2C RID: 20268 RVA: 0x001A6394 File Offset: 0x001A4594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76011, XrefRangeEnd = 76016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_88(Entity ent, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_88_Internal_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F2D RID: 20269 RVA: 0x001A63E8 File Offset: 0x001A45E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76016, XrefRangeEnd = 76022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_89(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_89_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F2E RID: 20270 RVA: 0x001A645C File Offset: 0x001A465C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76022, XrefRangeEnd = 76029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__80_90(Entity ent, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_90_Internal_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F2F RID: 20271 RVA: 0x001A64B0 File Offset: 0x001A46B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76029, XrefRangeEnd = 76035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__80_91(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNames.__c.NativeMethodInfoPtr___cctor_b__80_91_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06004F30 RID: 20272 RVA: 0x0001B39F File Offset: 0x0001959F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001366 RID: 4966
			// (get) Token: 0x06004F31 RID: 20273 RVA: 0x001A6524 File Offset: 0x001A4724
			// (set) Token: 0x06004F32 RID: 20274 RVA: 0x0001B3A8 File Offset: 0x000195A8
			public unsafe static EntityNames.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityNames.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNames.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityNames.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033A9 RID: 13225
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033AA RID: 13226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033AB RID: 13227
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_0_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033AC RID: 13228
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_1_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033AD RID: 13229
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_2_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033AE RID: 13230
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_3_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033AF RID: 13231
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_4_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033B0 RID: 13232
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_5_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B1 RID: 13233
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_6_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B2 RID: 13234
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_7_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B3 RID: 13235
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_8_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B4 RID: 13236
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_9_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B5 RID: 13237
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_10_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B6 RID: 13238
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_11_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B7 RID: 13239
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_12_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B8 RID: 13240
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_13_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033B9 RID: 13241
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_14_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033BA RID: 13242
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_15_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033BB RID: 13243
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_16_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033BC RID: 13244
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_17_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033BD RID: 13245
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_18_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033BE RID: 13246
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_19_Internal_Void_Entity_WormBoard_0;

			// Token: 0x040033BF RID: 13247
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_20_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033C0 RID: 13248
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_21_Internal_Void_Entity_WormBoard_0;

			// Token: 0x040033C1 RID: 13249
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_22_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033C2 RID: 13250
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_23_Internal_Void_Entity_WormBoard_0;

			// Token: 0x040033C3 RID: 13251
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_24_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033C4 RID: 13252
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_25_Internal_Void_Entity_WormBoard_0;

			// Token: 0x040033C5 RID: 13253
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_26_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033C6 RID: 13254
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_27_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033C7 RID: 13255
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_28_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033C8 RID: 13256
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_29_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033C9 RID: 13257
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_30_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033CA RID: 13258
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_31_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033CB RID: 13259
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_32_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033CC RID: 13260
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_33_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033CD RID: 13261
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_34_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033CE RID: 13262
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_35_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033CF RID: 13263
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_36_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D0 RID: 13264
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_37_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D1 RID: 13265
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_38_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D2 RID: 13266
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_39_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D3 RID: 13267
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_40_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D4 RID: 13268
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_41_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D5 RID: 13269
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_42_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D6 RID: 13270
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_43_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D7 RID: 13271
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_44_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D8 RID: 13272
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_45_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033D9 RID: 13273
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_46_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033DA RID: 13274
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_47_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033DB RID: 13275
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_48_Internal_Void_Entity_WormLeader_0;

			// Token: 0x040033DC RID: 13276
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_49_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033DD RID: 13277
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_50_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033DE RID: 13278
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_51_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033DF RID: 13279
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_52_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E0 RID: 13280
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_53_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E1 RID: 13281
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_54_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E2 RID: 13282
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_55_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E3 RID: 13283
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_56_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E4 RID: 13284
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_57_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E5 RID: 13285
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_58_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E6 RID: 13286
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_59_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E7 RID: 13287
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_60_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E8 RID: 13288
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_61_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033E9 RID: 13289
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_62_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033EA RID: 13290
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_63_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033EB RID: 13291
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_64_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033EC RID: 13292
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_65_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033ED RID: 13293
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_66_Internal_Void_Entity_WormBoard_0;

			// Token: 0x040033EE RID: 13294
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_67_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033EF RID: 13295
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_68_Internal_Void_Entity_WormBoard_0;

			// Token: 0x040033F0 RID: 13296
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_69_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033F1 RID: 13297
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_70_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033F2 RID: 13298
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_71_Internal_Void_Entity_WormTechTileStack_0;

			// Token: 0x040033F3 RID: 13299
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_72_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033F4 RID: 13300
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_73_Internal_Void_Entity_WormTechTileStack_0;

			// Token: 0x040033F5 RID: 13301
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_74_Internal_Void_Entity_WormPlayer_0;

			// Token: 0x040033F6 RID: 13302
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_75_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033F7 RID: 13303
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_76_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033F8 RID: 13304
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_77_Internal_Void_Entity_WormBoard_0;

			// Token: 0x040033F9 RID: 13305
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_78_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033FA RID: 13306
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_79_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033FB RID: 13307
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_80_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040033FC RID: 13308
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_81_Internal_Void_Entity_WormBoard_0;

			// Token: 0x040033FD RID: 13309
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_82_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033FE RID: 13310
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_83_Internal_Void_Entity_WormPlaymat_0;

			// Token: 0x040033FF RID: 13311
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_84_Internal_Void_Entity_WormBoard_0;

			// Token: 0x04003400 RID: 13312
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_85_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x04003401 RID: 13313
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_86_Internal_Void_Entity_WormBoard_0;

			// Token: 0x04003402 RID: 13314
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_87_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x04003403 RID: 13315
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_88_Internal_Void_Entity_Entity_0;

			// Token: 0x04003404 RID: 13316
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_89_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x04003405 RID: 13317
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_90_Internal_Void_Entity_Entity_0;

			// Token: 0x04003406 RID: 13318
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__80_91_Internal_Entity_SerializedEntity_Match_Entity_0;
		}
	}
}
