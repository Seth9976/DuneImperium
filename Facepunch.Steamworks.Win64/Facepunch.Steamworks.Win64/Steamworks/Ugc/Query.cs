using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	// Token: 0x020000D4 RID: 212
	public sealed class Query : ValueType
	{
		// Token: 0x06000DD3 RID: 3539 RVA: 0x00057D24 File Offset: 0x00055F24
		// Note: this type is marked as 'beforefieldinit'.
		static Query()
		{
			Il2CppClassPointerStore<Query>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Ugc", "Query");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Query>.NativeClassPtr);
			Query.NativeFieldInfoPtr_matchingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "matchingType");
			Query.NativeFieldInfoPtr_queryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "queryType");
			Query.NativeFieldInfoPtr_consumerApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "consumerApp");
			Query.NativeFieldInfoPtr_creatorApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "creatorApp");
			Query.NativeFieldInfoPtr_searchText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "searchText");
			Query.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "steamid");
			Query.NativeFieldInfoPtr_userType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "userType");
			Query.NativeFieldInfoPtr_userSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "userSort");
			Query.NativeFieldInfoPtr_Files = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "Files");
			Query.NativeFieldInfoPtr_maxCacheAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "maxCacheAge");
			Query.NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "language");
			Query.NativeFieldInfoPtr_trendDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "trendDays");
			Query.NativeFieldInfoPtr_requiredTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "requiredTags");
			Query.NativeFieldInfoPtr_matchAnyTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "matchAnyTag");
			Query.NativeFieldInfoPtr_excludedTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "excludedTags");
			Query.NativeFieldInfoPtr_requiredKv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "requiredKv");
			Query.NativeFieldInfoPtr_WantsReturnOnlyIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsReturnOnlyIDs");
			Query.NativeFieldInfoPtr_WantsReturnKeyValueTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsReturnKeyValueTags");
			Query.NativeFieldInfoPtr_WantsReturnLongDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsReturnLongDescription");
			Query.NativeFieldInfoPtr_WantsReturnMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsReturnMetadata");
			Query.NativeFieldInfoPtr_WantsReturnChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsReturnChildren");
			Query.NativeFieldInfoPtr_WantsReturnAdditionalPreviews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsReturnAdditionalPreviews");
			Query.NativeFieldInfoPtr_WantsReturnTotalOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsReturnTotalOnly");
			Query.NativeFieldInfoPtr_WantsReturnPlaytimeStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsReturnPlaytimeStats");
			Query.NativeFieldInfoPtr_WantsDefaultStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query>.NativeClassPtr, "WantsDefaultStats");
			Query.NativeMethodInfoPtr__ctor_Public_Void_UgcType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666597);
			Query.NativeMethodInfoPtr_get_All_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666598);
			Query.NativeMethodInfoPtr_get_Items_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666599);
			Query.NativeMethodInfoPtr_get_ItemsMtx_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666600);
			Query.NativeMethodInfoPtr_get_ItemsReadyToUse_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666601);
			Query.NativeMethodInfoPtr_get_Collections_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666602);
			Query.NativeMethodInfoPtr_get_Artwork_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666603);
			Query.NativeMethodInfoPtr_get_Videos_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666604);
			Query.NativeMethodInfoPtr_get_Screenshots_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666605);
			Query.NativeMethodInfoPtr_get_AllGuides_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666606);
			Query.NativeMethodInfoPtr_get_WebGuides_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666607);
			Query.NativeMethodInfoPtr_get_IntegratedGuides_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666608);
			Query.NativeMethodInfoPtr_get_UsableInGame_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666609);
			Query.NativeMethodInfoPtr_get_ControllerBindings_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666610);
			Query.NativeMethodInfoPtr_get_GameManagedItems_Public_Static_get_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666611);
			Query.NativeMethodInfoPtr_RankedByVote_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666612);
			Query.NativeMethodInfoPtr_RankedByPublicationDate_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666613);
			Query.NativeMethodInfoPtr_RankedByAcceptanceDate_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666614);
			Query.NativeMethodInfoPtr_RankedByTrend_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666615);
			Query.NativeMethodInfoPtr_FavoritedByFriends_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666616);
			Query.NativeMethodInfoPtr_CreatedByFriends_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666617);
			Query.NativeMethodInfoPtr_RankedByNumTimesReported_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666618);
			Query.NativeMethodInfoPtr_CreatedByFollowedUsers_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666619);
			Query.NativeMethodInfoPtr_NotYetRated_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666620);
			Query.NativeMethodInfoPtr_RankedByTotalVotesAsc_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666621);
			Query.NativeMethodInfoPtr_RankedByVotesUp_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666622);
			Query.NativeMethodInfoPtr_RankedByTextSearch_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666623);
			Query.NativeMethodInfoPtr_RankedByTotalUniqueSubscriptions_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666624);
			Query.NativeMethodInfoPtr_RankedByPlaytimeTrend_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666625);
			Query.NativeMethodInfoPtr_RankedByTotalPlaytime_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666626);
			Query.NativeMethodInfoPtr_RankedByAveragePlaytimeTrend_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666627);
			Query.NativeMethodInfoPtr_RankedByLifetimeAveragePlaytime_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666628);
			Query.NativeMethodInfoPtr_RankedByPlaytimeSessionsTrend_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666629);
			Query.NativeMethodInfoPtr_RankedByLifetimePlaytimeSessions_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666630);
			Query.NativeMethodInfoPtr_LimitUser_Internal_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666631);
			Query.NativeMethodInfoPtr_WhereUserPublished_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666632);
			Query.NativeMethodInfoPtr_WhereUserVotedOn_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666633);
			Query.NativeMethodInfoPtr_WhereUserVotedUp_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666634);
			Query.NativeMethodInfoPtr_WhereUserVotedDown_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666635);
			Query.NativeMethodInfoPtr_WhereUserWillVoteLater_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666636);
			Query.NativeMethodInfoPtr_WhereUserFavorited_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666637);
			Query.NativeMethodInfoPtr_WhereUserSubscribed_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666638);
			Query.NativeMethodInfoPtr_WhereUserUsedOrPlayed_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666639);
			Query.NativeMethodInfoPtr_WhereUserFollowed_Public_Query_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666640);
			Query.NativeMethodInfoPtr_SortByCreationDate_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666641);
			Query.NativeMethodInfoPtr_SortByCreationDateAsc_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666642);
			Query.NativeMethodInfoPtr_SortByTitleAsc_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666643);
			Query.NativeMethodInfoPtr_SortByUpdateDate_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666644);
			Query.NativeMethodInfoPtr_SortBySubscriptionDate_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666645);
			Query.NativeMethodInfoPtr_SortByVoteScore_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666646);
			Query.NativeMethodInfoPtr_SortByModeration_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666647);
			Query.NativeMethodInfoPtr_WhereSearchText_Public_Query_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666648);
			Query.NativeMethodInfoPtr_WithFileId_Public_Query_Il2CppStructArray_1_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666649);
			Query.NativeMethodInfoPtr_GetPageAsync_Public_Task_1_Nullable_1_ResultPage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666650);
			Query.NativeMethodInfoPtr_WithType_Public_Query_UgcType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666651);
			Query.NativeMethodInfoPtr_AllowCachedResponse_Public_Query_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666652);
			Query.NativeMethodInfoPtr_InLanguage_Public_Query_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666653);
			Query.NativeMethodInfoPtr_WithTrendDays_Public_Query_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666654);
			Query.NativeMethodInfoPtr_MatchAnyTag_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666655);
			Query.NativeMethodInfoPtr_MatchAllTags_Public_Query_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666656);
			Query.NativeMethodInfoPtr_WithTag_Public_Query_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666657);
			Query.NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Query_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666658);
			Query.NativeMethodInfoPtr_WithoutTag_Public_Query_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666659);
			Query.NativeMethodInfoPtr_ApplyConstraints_Private_Void_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666660);
			Query.NativeMethodInfoPtr_WithOnlyIDs_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666661);
			Query.NativeMethodInfoPtr_WithKeyValueTags_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666662);
			Query.NativeMethodInfoPtr_WithKeyValueTag_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666663);
			Query.NativeMethodInfoPtr_WithLongDescription_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666664);
			Query.NativeMethodInfoPtr_WithMetadata_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666665);
			Query.NativeMethodInfoPtr_WithChildren_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666666);
			Query.NativeMethodInfoPtr_WithAdditionalPreviews_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666667);
			Query.NativeMethodInfoPtr_WithTotalOnly_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666668);
			Query.NativeMethodInfoPtr_WithPlaytimeStats_Public_Query_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666669);
			Query.NativeMethodInfoPtr_ApplyReturns_Private_Void_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666670);
			Query.NativeMethodInfoPtr_WithDefaultStats_Public_Query_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query>.NativeClassPtr, 100666671);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00058524 File Offset: 0x00056724
		[CallerCount(0)]
		public unsafe Query(UgcType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Query>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr__ctor_Public_Void_UgcType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00058570 File Offset: 0x00056770
		public unsafe static Query All
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 949399, RefRangeEnd = 949400, XrefRangeStart = 949399, XrefRangeEnd = 949399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_All_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0005859C File Offset: 0x0005679C
		public unsafe static Query Items
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_Items_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000585C8 File Offset: 0x000567C8
		public unsafe static Query ItemsMtx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_ItemsMtx_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000585F4 File Offset: 0x000567F4
		public unsafe static Query ItemsReadyToUse
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_ItemsReadyToUse_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00058620 File Offset: 0x00056820
		public unsafe static Query Collections
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_Collections_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0005864C File Offset: 0x0005684C
		public unsafe static Query Artwork
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_Artwork_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00058678 File Offset: 0x00056878
		public unsafe static Query Videos
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_Videos_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000586A4 File Offset: 0x000568A4
		public unsafe static Query Screenshots
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_Screenshots_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x000586D0 File Offset: 0x000568D0
		public unsafe static Query AllGuides
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_AllGuides_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000586FC File Offset: 0x000568FC
		public unsafe static Query WebGuides
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_WebGuides_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00058728 File Offset: 0x00056928
		public unsafe static Query IntegratedGuides
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_IntegratedGuides_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00058754 File Offset: 0x00056954
		public unsafe static Query UsableInGame
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_UsableInGame_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x00058780 File Offset: 0x00056980
		public unsafe static Query ControllerBindings
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_ControllerBindings_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x000587AC File Offset: 0x000569AC
		public unsafe static Query GameManagedItems
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_get_GameManagedItems_Public_Static_get_Query_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000587D8 File Offset: 0x000569D8
		[CallerCount(0)]
		public unsafe Query RankedByVote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByVote_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00058814 File Offset: 0x00056A14
		[CallerCount(0)]
		public unsafe Query RankedByPublicationDate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByPublicationDate_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00058850 File Offset: 0x00056A50
		[CallerCount(0)]
		public unsafe Query RankedByAcceptanceDate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByAcceptanceDate_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0005888C File Offset: 0x00056A8C
		[CallerCount(0)]
		public unsafe Query RankedByTrend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByTrend_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000588C8 File Offset: 0x00056AC8
		[CallerCount(0)]
		public unsafe Query FavoritedByFriends()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_FavoritedByFriends_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00058904 File Offset: 0x00056B04
		[CallerCount(0)]
		public unsafe Query CreatedByFriends()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_CreatedByFriends_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00058940 File Offset: 0x00056B40
		[CallerCount(0)]
		public unsafe Query RankedByNumTimesReported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByNumTimesReported_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0005897C File Offset: 0x00056B7C
		[CallerCount(0)]
		public unsafe Query CreatedByFollowedUsers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_CreatedByFollowedUsers_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000589B8 File Offset: 0x00056BB8
		[CallerCount(0)]
		public unsafe Query NotYetRated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_NotYetRated_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000589F4 File Offset: 0x00056BF4
		[CallerCount(0)]
		public unsafe Query RankedByTotalVotesAsc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByTotalVotesAsc_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00058A30 File Offset: 0x00056C30
		[CallerCount(0)]
		public unsafe Query RankedByVotesUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByVotesUp_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00058A6C File Offset: 0x00056C6C
		[CallerCount(0)]
		public unsafe Query RankedByTextSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByTextSearch_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00058AA8 File Offset: 0x00056CA8
		[CallerCount(0)]
		public unsafe Query RankedByTotalUniqueSubscriptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByTotalUniqueSubscriptions_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00058AE4 File Offset: 0x00056CE4
		[CallerCount(0)]
		public unsafe Query RankedByPlaytimeTrend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByPlaytimeTrend_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00058B20 File Offset: 0x00056D20
		[CallerCount(0)]
		public unsafe Query RankedByTotalPlaytime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByTotalPlaytime_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00058B5C File Offset: 0x00056D5C
		[CallerCount(0)]
		public unsafe Query RankedByAveragePlaytimeTrend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByAveragePlaytimeTrend_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00058B98 File Offset: 0x00056D98
		[CallerCount(0)]
		public unsafe Query RankedByLifetimeAveragePlaytime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByLifetimeAveragePlaytime_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00058BD4 File Offset: 0x00056DD4
		[CallerCount(0)]
		public unsafe Query RankedByPlaytimeSessionsTrend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByPlaytimeSessionsTrend_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00058C10 File Offset: 0x00056E10
		[CallerCount(0)]
		public unsafe Query RankedByLifetimePlaytimeSessions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_RankedByLifetimePlaytimeSessions_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00058C4C File Offset: 0x00056E4C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 949407, RefRangeEnd = 949416, XrefRangeStart = 949400, XrefRangeEnd = 949407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query LimitUser(SteamId steamid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_LimitUser_Internal_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00058C98 File Offset: 0x00056E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949416, XrefRangeEnd = 949417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserPublished(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserPublished_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00058CE4 File Offset: 0x00056EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949417, XrefRangeEnd = 949418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserVotedOn(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserVotedOn_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00058D30 File Offset: 0x00056F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949418, XrefRangeEnd = 949419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserVotedUp(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserVotedUp_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00058D7C File Offset: 0x00056F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949419, XrefRangeEnd = 949420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserVotedDown(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserVotedDown_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00058DC8 File Offset: 0x00056FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949420, XrefRangeEnd = 949421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserWillVoteLater(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserWillVoteLater_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00058E14 File Offset: 0x00057014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949421, XrefRangeEnd = 949422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserFavorited(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserFavorited_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00058E60 File Offset: 0x00057060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949422, XrefRangeEnd = 949423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserSubscribed(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserSubscribed_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00058EAC File Offset: 0x000570AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949423, XrefRangeEnd = 949424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserUsedOrPlayed(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserUsedOrPlayed_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00058EF8 File Offset: 0x000570F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949424, XrefRangeEnd = 949425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereUserFollowed(SteamId user = default(SteamId))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref user;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereUserFollowed_Public_Query_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00058F44 File Offset: 0x00057144
		[CallerCount(0)]
		public unsafe Query SortByCreationDate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_SortByCreationDate_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00058F80 File Offset: 0x00057180
		[CallerCount(0)]
		public unsafe Query SortByCreationDateAsc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_SortByCreationDateAsc_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00058FBC File Offset: 0x000571BC
		[CallerCount(0)]
		public unsafe Query SortByTitleAsc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_SortByTitleAsc_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00058FF8 File Offset: 0x000571F8
		[CallerCount(0)]
		public unsafe Query SortByUpdateDate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_SortByUpdateDate_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00059034 File Offset: 0x00057234
		[CallerCount(0)]
		public unsafe Query SortBySubscriptionDate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_SortBySubscriptionDate_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00059070 File Offset: 0x00057270
		[CallerCount(0)]
		public unsafe Query SortByVoteScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_SortByVoteScore_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000590AC File Offset: 0x000572AC
		[CallerCount(0)]
		public unsafe Query SortByModeration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_SortByModeration_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x000590E8 File Offset: 0x000572E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949425, XrefRangeEnd = 949426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WhereSearchText(string searchText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WhereSearchText_Public_Query_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00059138 File Offset: 0x00057338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 949427, RefRangeEnd = 949428, XrefRangeStart = 949426, XrefRangeEnd = 949427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithFileId([Optional] Il2CppStructArray<PublishedFileId> files)
		{
			if (files == null)
			{
				files = new Il2CppStructArray<PublishedFileId>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(files);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithFileId_Public_Query_Il2CppStructArray_1_PublishedFileId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00059194 File Offset: 0x00057394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 949443, RefRangeEnd = 949445, XrefRangeStart = 949428, XrefRangeEnd = 949443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<ResultPage>> GetPageAsync(int page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref page;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_GetPageAsync_Public_Task_1_Nullable_1_ResultPage_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<ResultPage>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000591E8 File Offset: 0x000573E8
		[CallerCount(0)]
		public unsafe Query WithType(UgcType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithType_Public_Query_UgcType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00059234 File Offset: 0x00057434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949445, XrefRangeEnd = 949448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query AllowCachedResponse(int maxSecondsAge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxSecondsAge;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_AllowCachedResponse_Public_Query_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00059280 File Offset: 0x00057480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949448, XrefRangeEnd = 949449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query InLanguage(string lang)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lang);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_InLanguage_Public_Query_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000592D0 File Offset: 0x000574D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949449, XrefRangeEnd = 949452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithTrendDays(int days)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithTrendDays_Public_Query_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0005931C File Offset: 0x0005751C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949452, XrefRangeEnd = 949455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query MatchAnyTag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_MatchAnyTag_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00059358 File Offset: 0x00057558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949455, XrefRangeEnd = 949458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query MatchAllTags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_MatchAllTags_Public_Query_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00059394 File Offset: 0x00057594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949458, XrefRangeEnd = 949470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithTag_Public_Query_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000593E4 File Offset: 0x000575E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949470, XrefRangeEnd = 949480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query AddRequiredKeyValueTag(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Query_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Query(intPtr);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00059444 File Offset: 0x00057644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949480, XrefRangeEnd = 949492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithoutTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithoutTag_Public_Query_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00059494 File Offset: 0x00057694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 949553, RefRangeEnd = 949554, XrefRangeStart = 949492, XrefRangeEnd = 949553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyConstraints(UGCQueryHandle_t handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_ApplyConstraints_Private_Void_UGCQueryHandle_t_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000594D8 File Offset: 0x000576D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949554, XrefRangeEnd = 949557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithOnlyIDs(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithOnlyIDs_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00059524 File Offset: 0x00057724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949557, XrefRangeEnd = 949560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithKeyValueTags(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithKeyValueTags_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00059570 File Offset: 0x00057770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949560, XrefRangeEnd = 949563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithKeyValueTag(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithKeyValueTag_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000595BC File Offset: 0x000577BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949563, XrefRangeEnd = 949566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithLongDescription(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithLongDescription_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00059608 File Offset: 0x00057808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949566, XrefRangeEnd = 949569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithMetadata(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithMetadata_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00059654 File Offset: 0x00057854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949569, XrefRangeEnd = 949572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithChildren(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithChildren_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000596A0 File Offset: 0x000578A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949572, XrefRangeEnd = 949575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithAdditionalPreviews(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithAdditionalPreviews_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x000596EC File Offset: 0x000578EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949575, XrefRangeEnd = 949578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithTotalOnly(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithTotalOnly_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00059738 File Offset: 0x00057938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949578, XrefRangeEnd = 949581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithPlaytimeStats(uint unDays)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unDays;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithPlaytimeStats_Public_Query_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00059784 File Offset: 0x00057984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 949617, RefRangeEnd = 949618, XrefRangeStart = 949581, XrefRangeEnd = 949617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyReturns(UGCQueryHandle_t handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_ApplyReturns_Private_Void_UGCQueryHandle_t_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000597C8 File Offset: 0x000579C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949618, XrefRangeEnd = 949621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Query WithDefaultStats(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query.NativeMethodInfoPtr_WithDefaultStats_Public_Query_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Query(intPtr);
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0000396A File Offset: 0x00001B6A
		public Query WithFileId(params PublishedFileId[] files)
		{
			return this.WithFileId(new Il2CppStructArray<PublishedFileId>(files));
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00003978 File Offset: 0x00001B78
		public Query(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00003981 File Offset: 0x00001B81
		public Query()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Query>.NativeClassPtr))
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00059814 File Offset: 0x00057A14
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00003993 File Offset: 0x00001B93
		public unsafe UgcType matchingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_matchingType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_matchingType)) = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0005983C File Offset: 0x00057A3C
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x000039AE File Offset: 0x00001BAE
		public unsafe UGCQuery queryType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_queryType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_queryType)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00059864 File Offset: 0x00057A64
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x000039C9 File Offset: 0x00001BC9
		public unsafe AppId consumerApp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_consumerApp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_consumerApp)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0005988C File Offset: 0x00057A8C
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x000039E4 File Offset: 0x00001BE4
		public unsafe AppId creatorApp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_creatorApp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_creatorApp)) = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x000598B4 File Offset: 0x00057AB4
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x000039FF File Offset: 0x00001BFF
		public unsafe string searchText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_searchText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_searchText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000598DC File Offset: 0x00057ADC
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00003A1E File Offset: 0x00001C1E
		public Nullable<SteamId> steamid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_steamid);
				return new Nullable<SteamId>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SteamId>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_steamid), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SteamId>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0005990C File Offset: 0x00057B0C
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00003A4C File Offset: 0x00001C4C
		public unsafe UserUGCList userType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_userType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_userType)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00059934 File Offset: 0x00057B34
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00003A67 File Offset: 0x00001C67
		public unsafe UserUGCListSortOrder userSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_userSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_userSort)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0005995C File Offset: 0x00057B5C
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00003A82 File Offset: 0x00001C82
		public unsafe Il2CppStructArray<PublishedFileId> Files
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_Files);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_Files), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x0005998C File Offset: 0x00057B8C
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00003AA1 File Offset: 0x00001CA1
		public Nullable<int> maxCacheAge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_maxCacheAge);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_maxCacheAge), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x000599BC File Offset: 0x00057BBC
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00003ACF File Offset: 0x00001CCF
		public unsafe string language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x000599E4 File Offset: 0x00057BE4
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00003AEE File Offset: 0x00001CEE
		public Nullable<int> trendDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_trendDays);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_trendDays), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00059A14 File Offset: 0x00057C14
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00003B1C File Offset: 0x00001D1C
		public unsafe List<string> requiredTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_requiredTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_requiredTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00059A44 File Offset: 0x00057C44
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00003B3B File Offset: 0x00001D3B
		public Nullable<bool> matchAnyTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_matchAnyTag);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_matchAnyTag), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00059A74 File Offset: 0x00057C74
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00003B69 File Offset: 0x00001D69
		public unsafe List<string> excludedTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_excludedTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_excludedTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00059AA4 File Offset: 0x00057CA4
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00003B88 File Offset: 0x00001D88
		public unsafe Dictionary<string, string> requiredKv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_requiredKv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_requiredKv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00059AD4 File Offset: 0x00057CD4
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00003BA7 File Offset: 0x00001DA7
		public Nullable<bool> WantsReturnOnlyIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnOnlyIDs);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnOnlyIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00059B04 File Offset: 0x00057D04
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00003BD5 File Offset: 0x00001DD5
		public Nullable<bool> WantsReturnKeyValueTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnKeyValueTags);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnKeyValueTags), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00059B34 File Offset: 0x00057D34
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00003C03 File Offset: 0x00001E03
		public Nullable<bool> WantsReturnLongDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnLongDescription);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnLongDescription), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00059B64 File Offset: 0x00057D64
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00003C31 File Offset: 0x00001E31
		public Nullable<bool> WantsReturnMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnMetadata);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnMetadata), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00059B94 File Offset: 0x00057D94
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00003C5F File Offset: 0x00001E5F
		public Nullable<bool> WantsReturnChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnChildren);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnChildren), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00059BC4 File Offset: 0x00057DC4
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00003C8D File Offset: 0x00001E8D
		public Nullable<bool> WantsReturnAdditionalPreviews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnAdditionalPreviews);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnAdditionalPreviews), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00059BF4 File Offset: 0x00057DF4
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00003CBB File Offset: 0x00001EBB
		public Nullable<bool> WantsReturnTotalOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnTotalOnly);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnTotalOnly), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00059C24 File Offset: 0x00057E24
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public Nullable<uint> WantsReturnPlaytimeStats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnPlaytimeStats);
				return new Nullable<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<uint>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsReturnPlaytimeStats), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<uint>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00059C54 File Offset: 0x00057E54
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00003D17 File Offset: 0x00001F17
		public Nullable<bool> WantsDefaultStats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsDefaultStats);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query.NativeFieldInfoPtr_WantsDefaultStats), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeFieldInfoPtr_matchingType;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeFieldInfoPtr_queryType;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeFieldInfoPtr_consumerApp;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeFieldInfoPtr_creatorApp;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeFieldInfoPtr_searchText;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeFieldInfoPtr_steamid;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeFieldInfoPtr_userType;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeFieldInfoPtr_userSort;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeFieldInfoPtr_Files;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeFieldInfoPtr_maxCacheAge;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeFieldInfoPtr_language;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeFieldInfoPtr_trendDays;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeFieldInfoPtr_requiredTags;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeFieldInfoPtr_matchAnyTag;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr_excludedTags;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeFieldInfoPtr_requiredKv;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeFieldInfoPtr_WantsReturnOnlyIDs;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeFieldInfoPtr_WantsReturnKeyValueTags;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeFieldInfoPtr_WantsReturnLongDescription;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeFieldInfoPtr_WantsReturnMetadata;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeFieldInfoPtr_WantsReturnChildren;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeFieldInfoPtr_WantsReturnAdditionalPreviews;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeFieldInfoPtr_WantsReturnTotalOnly;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeFieldInfoPtr_WantsReturnPlaytimeStats;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeFieldInfoPtr_WantsDefaultStats;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UgcType_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_Query_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Static_get_Query_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemsMtx_Public_Static_get_Query_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemsReadyToUse_Public_Static_get_Query_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_get_Collections_Public_Static_get_Query_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_get_Artwork_Public_Static_get_Query_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_get_Videos_Public_Static_get_Query_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_get_Screenshots_Public_Static_get_Query_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_get_AllGuides_Public_Static_get_Query_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_get_WebGuides_Public_Static_get_Query_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_get_IntegratedGuides_Public_Static_get_Query_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_get_UsableInGame_Public_Static_get_Query_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_get_ControllerBindings_Public_Static_get_Query_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_get_GameManagedItems_Public_Static_get_Query_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_RankedByVote_Public_Query_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_RankedByPublicationDate_Public_Query_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_RankedByAcceptanceDate_Public_Query_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_RankedByTrend_Public_Query_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_FavoritedByFriends_Public_Query_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_CreatedByFriends_Public_Query_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_RankedByNumTimesReported_Public_Query_0;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_CreatedByFollowedUsers_Public_Query_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_NotYetRated_Public_Query_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_RankedByTotalVotesAsc_Public_Query_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_RankedByVotesUp_Public_Query_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_RankedByTextSearch_Public_Query_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_RankedByTotalUniqueSubscriptions_Public_Query_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_RankedByPlaytimeTrend_Public_Query_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_RankedByTotalPlaytime_Public_Query_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_RankedByAveragePlaytimeTrend_Public_Query_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_RankedByLifetimeAveragePlaytime_Public_Query_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_RankedByPlaytimeSessionsTrend_Public_Query_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr_RankedByLifetimePlaytimeSessions_Public_Query_0;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_LimitUser_Internal_Query_SteamId_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserPublished_Public_Query_SteamId_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserVotedOn_Public_Query_SteamId_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserVotedUp_Public_Query_SteamId_0;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserVotedDown_Public_Query_SteamId_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserWillVoteLater_Public_Query_SteamId_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserFavorited_Public_Query_SteamId_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserSubscribed_Public_Query_SteamId_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserUsedOrPlayed_Public_Query_SteamId_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_WhereUserFollowed_Public_Query_SteamId_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_SortByCreationDate_Public_Query_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_SortByCreationDateAsc_Public_Query_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_SortByTitleAsc_Public_Query_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_SortByUpdateDate_Public_Query_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_SortBySubscriptionDate_Public_Query_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_SortByVoteScore_Public_Query_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_SortByModeration_Public_Query_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_WhereSearchText_Public_Query_String_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_WithFileId_Public_Query_Il2CppStructArray_1_PublishedFileId_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_GetPageAsync_Public_Task_1_Nullable_1_ResultPage_Int32_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_WithType_Public_Query_UgcType_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_AllowCachedResponse_Public_Query_Int32_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_InLanguage_Public_Query_String_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_WithTrendDays_Public_Query_Int32_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_MatchAnyTag_Public_Query_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_MatchAllTags_Public_Query_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_WithTag_Public_Query_String_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Query_String_String_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_WithoutTag_Public_Query_String_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_ApplyConstraints_Private_Void_UGCQueryHandle_t_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_WithOnlyIDs_Public_Query_Boolean_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_WithKeyValueTags_Public_Query_Boolean_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_WithKeyValueTag_Public_Query_Boolean_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_WithLongDescription_Public_Query_Boolean_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_WithMetadata_Public_Query_Boolean_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_WithChildren_Public_Query_Boolean_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_WithAdditionalPreviews_Public_Query_Boolean_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_WithTotalOnly_Public_Query_Boolean_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_WithPlaytimeStats_Public_Query_UInt32_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_ApplyReturns_Private_Void_UGCQueryHandle_t_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_WithDefaultStats_Public_Query_Boolean_0;

		// Token: 0x02000297 RID: 663
		[ObfuscatedName("Steamworks.Ugc.Query+<GetPageAsync>d__76")]
		public sealed class _GetPageAsync_d__76 : ValueType
		{
			// Token: 0x060021A6 RID: 8614 RVA: 0x00091C5C File Offset: 0x0008FE5C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetPageAsync_d__76()
			{
				Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Query>.NativeClassPtr, "<GetPageAsync>d__76");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr);
				Query._GetPageAsync_d__76.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr, "<>1__state");
				Query._GetPageAsync_d__76.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr, "<>t__builder");
				Query._GetPageAsync_d__76.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr, "page");
				Query._GetPageAsync_d__76.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr, "<>4__this");
				Query._GetPageAsync_d__76.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr, "<>u__1");
				Query._GetPageAsync_d__76.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr, 100666672);
				Query._GetPageAsync_d__76.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr, 100666673);
			}

			// Token: 0x060021A7 RID: 8615 RVA: 0x00091D14 File Offset: 0x0008FF14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949325, XrefRangeEnd = 949393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query._GetPageAsync_d__76.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021A8 RID: 8616 RVA: 0x00091D4C File Offset: 0x0008FF4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949393, XrefRangeEnd = 949399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Query._GetPageAsync_d__76.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021A9 RID: 8617 RVA: 0x0000D677 File Offset: 0x0000B877
			public _GetPageAsync_d__76(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060021AA RID: 8618 RVA: 0x0000D680 File Offset: 0x0000B880
			public _GetPageAsync_d__76()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Query._GetPageAsync_d__76>.NativeClassPtr))
			{
			}

			// Token: 0x170008BE RID: 2238
			// (get) Token: 0x060021AB RID: 8619 RVA: 0x00091D94 File Offset: 0x0008FF94
			// (set) Token: 0x060021AC RID: 8620 RVA: 0x0000D692 File Offset: 0x0000B892
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x060021AD RID: 8621 RVA: 0x00091DBC File Offset: 0x0008FFBC
			// (set) Token: 0x060021AE RID: 8622 RVA: 0x0000D6AD File Offset: 0x0000B8AD
			public AsyncTaskMethodBuilder<Nullable<ResultPage>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<ResultPage>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<ResultPage>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<ResultPage>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x060021AF RID: 8623 RVA: 0x00091DEC File Offset: 0x0008FFEC
			// (set) Token: 0x060021B0 RID: 8624 RVA: 0x0000D6DB File Offset: 0x0000B8DB
			public unsafe int page
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr_page);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr_page)) = value;
				}
			}

			// Token: 0x170008C1 RID: 2241
			// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00091E14 File Offset: 0x00090014
			// (set) Token: 0x060021B2 RID: 8626 RVA: 0x0000D6F6 File Offset: 0x0000B8F6
			public Query __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr___4__this);
					return new Query(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Query>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Query>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00091E44 File Offset: 0x00090044
			// (set) Token: 0x060021B4 RID: 8628 RVA: 0x0000D724 File Offset: 0x0000B924
			public CallResult<SteamUGCQueryCompleted_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr___u__1);
					return new CallResult<SteamUGCQueryCompleted_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<SteamUGCQueryCompleted_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Query._GetPageAsync_d__76.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<SteamUGCQueryCompleted_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002360 RID: 9056
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002361 RID: 9057
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002362 RID: 9058
			private static readonly IntPtr NativeFieldInfoPtr_page;

			// Token: 0x04002363 RID: 9059
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002364 RID: 9060
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002365 RID: 9061
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002366 RID: 9062
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
