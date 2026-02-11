using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	// Token: 0x020000D3 RID: 211
	public sealed class Item : ValueType
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x0005597C File Offset: 0x00053B7C
		// Note: this type is marked as 'beforefieldinit'.
		static Item()
		{
			Il2CppClassPointerStore<Item>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Ugc", "Item");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item>.NativeClassPtr);
			Item.NativeFieldInfoPtr_details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "details");
			Item.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "_id");
			Item.NativeFieldInfoPtr__Title_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<Title>k__BackingField");
			Item.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<Description>k__BackingField");
			Item.NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<Tags>k__BackingField");
			Item.NativeFieldInfoPtr__KeyValueTags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<KeyValueTags>k__BackingField");
			Item.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "Children");
			Item.NativeFieldInfoPtr__AdditionalPreviews_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<AdditionalPreviews>k__BackingField");
			Item.NativeFieldInfoPtr__NumSubscriptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumSubscriptions>k__BackingField");
			Item.NativeFieldInfoPtr__NumFavorites_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumFavorites>k__BackingField");
			Item.NativeFieldInfoPtr__NumFollowers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumFollowers>k__BackingField");
			Item.NativeFieldInfoPtr__NumUniqueSubscriptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumUniqueSubscriptions>k__BackingField");
			Item.NativeFieldInfoPtr__NumUniqueFavorites_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumUniqueFavorites>k__BackingField");
			Item.NativeFieldInfoPtr__NumUniqueFollowers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumUniqueFollowers>k__BackingField");
			Item.NativeFieldInfoPtr__NumUniqueWebsiteViews_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumUniqueWebsiteViews>k__BackingField");
			Item.NativeFieldInfoPtr__ReportScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<ReportScore>k__BackingField");
			Item.NativeFieldInfoPtr__NumSecondsPlayed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumSecondsPlayed>k__BackingField");
			Item.NativeFieldInfoPtr__NumPlaytimeSessions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumPlaytimeSessions>k__BackingField");
			Item.NativeFieldInfoPtr__NumComments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumComments>k__BackingField");
			Item.NativeFieldInfoPtr__NumSecondsPlayedDuringTimePeriod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumSecondsPlayedDuringTimePeriod>k__BackingField");
			Item.NativeFieldInfoPtr__NumPlaytimeSessionsDuringTimePeriod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<NumPlaytimeSessionsDuringTimePeriod>k__BackingField");
			Item.NativeFieldInfoPtr__PreviewImageUrl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<PreviewImageUrl>k__BackingField");
			Item.NativeFieldInfoPtr__Metadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "<Metadata>k__BackingField");
			Item.NativeMethodInfoPtr__ctor_Public_Void_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666491);
			Item.NativeMethodInfoPtr_get_Id_Public_get_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666492);
			Item.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666493);
			Item.NativeMethodInfoPtr_set_Title_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666494);
			Item.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666495);
			Item.NativeMethodInfoPtr_set_Description_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666496);
			Item.NativeMethodInfoPtr_get_Tags_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666497);
			Item.NativeMethodInfoPtr_set_Tags_Internal_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666498);
			Item.NativeMethodInfoPtr_get_KeyValueTags_Public_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666499);
			Item.NativeMethodInfoPtr_set_KeyValueTags_Internal_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666500);
			Item.NativeMethodInfoPtr_get_CreatorApp_Public_get_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666501);
			Item.NativeMethodInfoPtr_get_ConsumerApp_Public_get_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666502);
			Item.NativeMethodInfoPtr_get_Owner_Public_get_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666503);
			Item.NativeMethodInfoPtr_get_Score_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666504);
			Item.NativeMethodInfoPtr_get_Created_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666505);
			Item.NativeMethodInfoPtr_get_Updated_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666506);
			Item.NativeMethodInfoPtr_get_IsPublic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666507);
			Item.NativeMethodInfoPtr_get_IsFriendsOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666508);
			Item.NativeMethodInfoPtr_get_IsPrivate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666509);
			Item.NativeMethodInfoPtr_get_IsBanned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666510);
			Item.NativeMethodInfoPtr_get_IsAcceptedForUse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666511);
			Item.NativeMethodInfoPtr_get_VotesUp_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666512);
			Item.NativeMethodInfoPtr_get_VotesDown_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666513);
			Item.NativeMethodInfoPtr_get_AdditionalPreviews_Public_get_Il2CppReferenceArray_1_UgcAdditionalPreview_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666514);
			Item.NativeMethodInfoPtr_set_AdditionalPreviews_Internal_set_Void_Il2CppReferenceArray_1_UgcAdditionalPreview_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666515);
			Item.NativeMethodInfoPtr_get_IsInstalled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666516);
			Item.NativeMethodInfoPtr_get_IsDownloading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666517);
			Item.NativeMethodInfoPtr_get_IsDownloadPending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666518);
			Item.NativeMethodInfoPtr_get_IsSubscribed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666519);
			Item.NativeMethodInfoPtr_get_NeedsUpdate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666520);
			Item.NativeMethodInfoPtr_get_Directory_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666521);
			Item.NativeMethodInfoPtr_Download_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666522);
			Item.NativeMethodInfoPtr_get_DownloadBytesTotal_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666523);
			Item.NativeMethodInfoPtr_get_DownloadBytesDownloaded_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666524);
			Item.NativeMethodInfoPtr_get_SizeBytes_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666525);
			Item.NativeMethodInfoPtr_get_DownloadAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666526);
			Item.NativeMethodInfoPtr_get_State_Private_get_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666527);
			Item.NativeMethodInfoPtr_GetAsync_Public_Static_Task_1_Nullable_1_Item_PublishedFileId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666528);
			Item.NativeMethodInfoPtr_From_Internal_Static_Item_SteamUGCDetails_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666529);
			Item.NativeMethodInfoPtr_HasTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666530);
			Item.NativeMethodInfoPtr_Subscribe_Public_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666531);
			Item.NativeMethodInfoPtr_DownloadAsync_Public_Task_1_Boolean_Action_1_Single_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666532);
			Item.NativeMethodInfoPtr_Unsubscribe_Public_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666533);
			Item.NativeMethodInfoPtr_AddFavorite_Public_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666534);
			Item.NativeMethodInfoPtr_RemoveFavorite_Public_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666535);
			Item.NativeMethodInfoPtr_Vote_Public_Task_1_Nullable_1_Result_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666536);
			Item.NativeMethodInfoPtr_GetUserVote_Public_Task_1_Nullable_1_UserItemVote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666537);
			Item.NativeMethodInfoPtr_get_Url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666538);
			Item.NativeMethodInfoPtr_get_ChangelogUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666539);
			Item.NativeMethodInfoPtr_get_CommentsUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666540);
			Item.NativeMethodInfoPtr_get_DiscussUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666541);
			Item.NativeMethodInfoPtr_get_StatsUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666542);
			Item.NativeMethodInfoPtr_get_NumSubscriptions_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666543);
			Item.NativeMethodInfoPtr_set_NumSubscriptions_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666544);
			Item.NativeMethodInfoPtr_get_NumFavorites_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666545);
			Item.NativeMethodInfoPtr_set_NumFavorites_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666546);
			Item.NativeMethodInfoPtr_get_NumFollowers_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666547);
			Item.NativeMethodInfoPtr_set_NumFollowers_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666548);
			Item.NativeMethodInfoPtr_get_NumUniqueSubscriptions_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666549);
			Item.NativeMethodInfoPtr_set_NumUniqueSubscriptions_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666550);
			Item.NativeMethodInfoPtr_get_NumUniqueFavorites_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666551);
			Item.NativeMethodInfoPtr_set_NumUniqueFavorites_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666552);
			Item.NativeMethodInfoPtr_get_NumUniqueFollowers_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666553);
			Item.NativeMethodInfoPtr_set_NumUniqueFollowers_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666554);
			Item.NativeMethodInfoPtr_get_NumUniqueWebsiteViews_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666555);
			Item.NativeMethodInfoPtr_set_NumUniqueWebsiteViews_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666556);
			Item.NativeMethodInfoPtr_get_ReportScore_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666557);
			Item.NativeMethodInfoPtr_set_ReportScore_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666558);
			Item.NativeMethodInfoPtr_get_NumSecondsPlayed_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666559);
			Item.NativeMethodInfoPtr_set_NumSecondsPlayed_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666560);
			Item.NativeMethodInfoPtr_get_NumPlaytimeSessions_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666561);
			Item.NativeMethodInfoPtr_set_NumPlaytimeSessions_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666562);
			Item.NativeMethodInfoPtr_get_NumComments_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666563);
			Item.NativeMethodInfoPtr_set_NumComments_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666564);
			Item.NativeMethodInfoPtr_get_NumSecondsPlayedDuringTimePeriod_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666565);
			Item.NativeMethodInfoPtr_set_NumSecondsPlayedDuringTimePeriod_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666566);
			Item.NativeMethodInfoPtr_get_NumPlaytimeSessionsDuringTimePeriod_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666567);
			Item.NativeMethodInfoPtr_set_NumPlaytimeSessionsDuringTimePeriod_Internal_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666568);
			Item.NativeMethodInfoPtr_get_PreviewImageUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666569);
			Item.NativeMethodInfoPtr_set_PreviewImageUrl_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666570);
			Item.NativeMethodInfoPtr_get_Metadata_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666571);
			Item.NativeMethodInfoPtr_set_Metadata_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666572);
			Item.NativeMethodInfoPtr_Edit_Public_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666573);
			Item.NativeMethodInfoPtr_AddDependency_Public_Task_1_Boolean_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666574);
			Item.NativeMethodInfoPtr_RemoveDependency_Public_Task_1_Boolean_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666575);
			Item.NativeMethodInfoPtr_get_Result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100666576);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00056230 File Offset: 0x00054430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 949064, RefRangeEnd = 949065, XrefRangeStart = 949063, XrefRangeEnd = 949064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Item(PublishedFileId id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr__ctor_Public_Void_PublishedFileId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0005627C File Offset: 0x0005447C
		public unsafe PublishedFileId Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Id_Public_get_PublishedFileId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000562C0 File Offset: 0x000544C0
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x000562FC File Offset: 0x000544FC
		public unsafe string Title
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_Title_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00056344 File Offset: 0x00054544
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00056380 File Offset: 0x00054580
		public unsafe string Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_Description_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x000563C8 File Offset: 0x000545C8
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0005640C File Offset: 0x0005460C
		public unsafe Il2CppStringArray Tags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Tags_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_Tags_Internal_set_Void_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00056454 File Offset: 0x00054654
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00056498 File Offset: 0x00054698
		public unsafe Dictionary<string, string> KeyValueTags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_KeyValueTags_Public_get_Dictionary_2_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_KeyValueTags_Internal_set_Void_Dictionary_2_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000564E0 File Offset: 0x000546E0
		public unsafe AppId CreatorApp
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_CreatorApp_Public_get_AppId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00056524 File Offset: 0x00054724
		public unsafe AppId ConsumerApp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_ConsumerApp_Public_get_AppId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00056568 File Offset: 0x00054768
		public unsafe Friend Owner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949065, XrefRangeEnd = 949066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Owner_Public_get_Friend_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x000565AC File Offset: 0x000547AC
		public unsafe float Score
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Score_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000565F0 File Offset: 0x000547F0
		public unsafe DateTime Created
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949066, XrefRangeEnd = 949074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Created_Public_get_DateTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00056634 File Offset: 0x00054834
		public unsafe DateTime Updated
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949074, XrefRangeEnd = 949082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Updated_Public_get_DateTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00056678 File Offset: 0x00054878
		public unsafe bool IsPublic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsPublic_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x000566BC File Offset: 0x000548BC
		public unsafe bool IsFriendsOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsFriendsOnly_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00056700 File Offset: 0x00054900
		public unsafe bool IsPrivate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsPrivate_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00056744 File Offset: 0x00054944
		public unsafe bool IsBanned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsBanned_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00056788 File Offset: 0x00054988
		public unsafe bool IsAcceptedForUse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsAcceptedForUse_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x000567CC File Offset: 0x000549CC
		public unsafe uint VotesUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_VotesUp_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00056810 File Offset: 0x00054A10
		public unsafe uint VotesDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_VotesDown_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00056854 File Offset: 0x00054A54
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x00056898 File Offset: 0x00054A98
		public unsafe Il2CppReferenceArray<UgcAdditionalPreview> AdditionalPreviews
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_AdditionalPreviews_Public_get_Il2CppReferenceArray_1_UgcAdditionalPreview_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UgcAdditionalPreview>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_AdditionalPreviews_Internal_set_Void_Il2CppReferenceArray_1_UgcAdditionalPreview_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x000568E0 File Offset: 0x00054AE0
		public unsafe bool IsInstalled
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 949084, RefRangeEnd = 949087, XrefRangeStart = 949082, XrefRangeEnd = 949084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsInstalled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00056924 File Offset: 0x00054B24
		public unsafe bool IsDownloading
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 949089, RefRangeEnd = 949090, XrefRangeStart = 949087, XrefRangeEnd = 949089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsDownloading_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00056968 File Offset: 0x00054B68
		public unsafe bool IsDownloadPending
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949090, XrefRangeEnd = 949092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsDownloadPending_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x000569AC File Offset: 0x00054BAC
		public unsafe bool IsSubscribed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949092, XrefRangeEnd = 949094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsSubscribed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x000569F0 File Offset: 0x00054BF0
		public unsafe bool NeedsUpdate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949094, XrefRangeEnd = 949096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NeedsUpdate_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00056A34 File Offset: 0x00054C34
		public unsafe string Directory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949096, XrefRangeEnd = 949098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Directory_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00056A70 File Offset: 0x00054C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949098, XrefRangeEnd = 949099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Download(bool highPriority = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highPriority;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_Download_Public_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00056AC0 File Offset: 0x00054CC0
		public unsafe long DownloadBytesTotal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949099, XrefRangeEnd = 949103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_DownloadBytesTotal_Public_get_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00056B04 File Offset: 0x00054D04
		public unsafe long DownloadBytesDownloaded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949103, XrefRangeEnd = 949107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_DownloadBytesDownloaded_Public_get_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00056B48 File Offset: 0x00054D48
		public unsafe long SizeBytes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949107, XrefRangeEnd = 949111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_SizeBytes_Public_get_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00056B8C File Offset: 0x00054D8C
		public unsafe float DownloadAmount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 949116, RefRangeEnd = 949117, XrefRangeStart = 949111, XrefRangeEnd = 949116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_DownloadAmount_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00056BD0 File Offset: 0x00054DD0
		public unsafe ItemState State
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949117, XrefRangeEnd = 949120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_State_Private_get_ItemState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00056C14 File Offset: 0x00054E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949120, XrefRangeEnd = 949133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Item>> GetAsync(PublishedFileId id, int maxageseconds = 1800)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxageseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_GetAsync_Public_Static_Task_1_Nullable_1_Item_PublishedFileId_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Item>>>(intPtr3) : null;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00056C64 File Offset: 0x00054E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 949146, RefRangeEnd = 949147, XrefRangeStart = 949133, XrefRangeEnd = 949146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Item From(SteamUGCDetails_t details)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(details));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_From_Internal_Static_Item_SteamUGCDetails_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Item(intPtr);
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00056CA8 File Offset: 0x00054EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949147, XrefRangeEnd = 949157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTag(string find)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(find);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_HasTag_Public_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00056CFC File Offset: 0x00054EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949157, XrefRangeEnd = 949172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_Subscribe_Public_Task_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00056D40 File Offset: 0x00054F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949172, XrefRangeEnd = 949189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> DownloadAsync(Action<float> progress = null, int milisecondsUpdateDelay = 60, CancellationToken ct = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(progress);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref milisecondsUpdateDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_DownloadAsync_Public_Task_1_Boolean_Action_1_Single_Int32_CancellationToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00056DBC File Offset: 0x00054FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949189, XrefRangeEnd = 949204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> Unsubscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_Unsubscribe_Public_Task_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00056E00 File Offset: 0x00055000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949204, XrefRangeEnd = 949219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> AddFavorite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_AddFavorite_Public_Task_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00056E44 File Offset: 0x00055044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949219, XrefRangeEnd = 949234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> RemoveFavorite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_RemoveFavorite_Public_Task_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00056E88 File Offset: 0x00055088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949234, XrefRangeEnd = 949249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<Result>> Vote(bool up)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref up;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_Vote_Public_Task_1_Nullable_1_Result_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Result>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00056EDC File Offset: 0x000550DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949249, XrefRangeEnd = 949264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<UserItemVote>> GetUserVote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_GetUserVote_Public_Task_1_Nullable_1_UserItemVote_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<UserItemVote>>>(intPtr3) : null;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00056F20 File Offset: 0x00055120
		public unsafe string Url
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949264, XrefRangeEnd = 949270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Url_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00056F5C File Offset: 0x0005515C
		public unsafe string ChangelogUrl
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949270, XrefRangeEnd = 949276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_ChangelogUrl_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00056F98 File Offset: 0x00055198
		public unsafe string CommentsUrl
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949276, XrefRangeEnd = 949282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_CommentsUrl_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00056FD4 File Offset: 0x000551D4
		public unsafe string DiscussUrl
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949282, XrefRangeEnd = 949288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_DiscussUrl_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00057010 File Offset: 0x00055210
		public unsafe string StatsUrl
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949288, XrefRangeEnd = 949294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_StatsUrl_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0005704C File Offset: 0x0005524C
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x00057090 File Offset: 0x00055290
		public unsafe ulong NumSubscriptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumSubscriptions_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumSubscriptions_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x000570D4 File Offset: 0x000552D4
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00057118 File Offset: 0x00055318
		public unsafe ulong NumFavorites
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumFavorites_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumFavorites_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0005715C File Offset: 0x0005535C
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x000571A0 File Offset: 0x000553A0
		public unsafe ulong NumFollowers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumFollowers_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumFollowers_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000571E4 File Offset: 0x000553E4
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00057228 File Offset: 0x00055428
		public unsafe ulong NumUniqueSubscriptions
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumUniqueSubscriptions_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumUniqueSubscriptions_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x0005726C File Offset: 0x0005546C
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x000572B0 File Offset: 0x000554B0
		public unsafe ulong NumUniqueFavorites
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumUniqueFavorites_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumUniqueFavorites_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x000572F4 File Offset: 0x000554F4
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x00057338 File Offset: 0x00055538
		public unsafe ulong NumUniqueFollowers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumUniqueFollowers_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumUniqueFollowers_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0005737C File Offset: 0x0005557C
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x000573C0 File Offset: 0x000555C0
		public unsafe ulong NumUniqueWebsiteViews
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumUniqueWebsiteViews_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumUniqueWebsiteViews_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00057404 File Offset: 0x00055604
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x00057448 File Offset: 0x00055648
		public unsafe ulong ReportScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_ReportScore_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_ReportScore_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0005748C File Offset: 0x0005568C
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x000574D0 File Offset: 0x000556D0
		public unsafe ulong NumSecondsPlayed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumSecondsPlayed_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumSecondsPlayed_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00057514 File Offset: 0x00055714
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00057558 File Offset: 0x00055758
		public unsafe ulong NumPlaytimeSessions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumPlaytimeSessions_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumPlaytimeSessions_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0005759C File Offset: 0x0005579C
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x000575E0 File Offset: 0x000557E0
		public unsafe ulong NumComments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumComments_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumComments_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00057624 File Offset: 0x00055824
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00057668 File Offset: 0x00055868
		public unsafe ulong NumSecondsPlayedDuringTimePeriod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumSecondsPlayedDuringTimePeriod_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumSecondsPlayedDuringTimePeriod_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x000576AC File Offset: 0x000558AC
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x000576F0 File Offset: 0x000558F0
		public unsafe ulong NumPlaytimeSessionsDuringTimePeriod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_NumPlaytimeSessionsDuringTimePeriod_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_NumPlaytimeSessionsDuringTimePeriod_Internal_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00057734 File Offset: 0x00055934
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00057770 File Offset: 0x00055970
		public unsafe string PreviewImageUrl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_PreviewImageUrl_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_PreviewImageUrl_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x000577B8 File Offset: 0x000559B8
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x000577F4 File Offset: 0x000559F4
		public unsafe string Metadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Metadata_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_set_Metadata_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0005783C File Offset: 0x00055A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949294, XrefRangeEnd = 949295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor Edit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_Edit_Public_Editor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Editor(intPtr);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00057878 File Offset: 0x00055A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949295, XrefRangeEnd = 949310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> AddDependency(PublishedFileId child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref child;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_AddDependency_Public_Task_1_Boolean_PublishedFileId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000578CC File Offset: 0x00055ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949310, XrefRangeEnd = 949325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> RemoveDependency(PublishedFileId child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref child;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_RemoveDependency_Public_Task_1_Boolean_PublishedFileId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00057920 File Offset: 0x00055B20
		public unsafe Result Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_Result_Public_get_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000036AF File Offset: 0x000018AF
		public Item(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000036B8 File Offset: 0x000018B8
		public Item()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
		{
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00057964 File Offset: 0x00055B64
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x000036CA File Offset: 0x000018CA
		public SteamUGCDetails_t details
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr_details);
				return new SteamUGCDetails_t(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr_details), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00057994 File Offset: 0x00055B94
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x000036F8 File Offset: 0x000018F8
		public unsafe PublishedFileId _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x000579BC File Offset: 0x00055BBC
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x00003713 File Offset: 0x00001913
		public unsafe string _Title_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__Title_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__Title_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x000579E4 File Offset: 0x00055BE4
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x00003732 File Offset: 0x00001932
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00057A0C File Offset: 0x00055C0C
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x00003751 File Offset: 0x00001951
		public unsafe Il2CppStringArray _Tags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__Tags_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__Tags_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00057A3C File Offset: 0x00055C3C
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x00003770 File Offset: 0x00001970
		public unsafe Dictionary<string, string> _KeyValueTags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__KeyValueTags_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__KeyValueTags_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00057A6C File Offset: 0x00055C6C
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x0000378F File Offset: 0x0000198F
		public unsafe Il2CppStructArray<PublishedFileId> Children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr_Children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr_Children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00057A9C File Offset: 0x00055C9C
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x000037AE File Offset: 0x000019AE
		public unsafe Il2CppReferenceArray<UgcAdditionalPreview> _AdditionalPreviews_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__AdditionalPreviews_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UgcAdditionalPreview>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__AdditionalPreviews_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00057ACC File Offset: 0x00055CCC
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x000037CD File Offset: 0x000019CD
		public unsafe ulong _NumSubscriptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumSubscriptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumSubscriptions_k__BackingField)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00057AF4 File Offset: 0x00055CF4
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x000037E8 File Offset: 0x000019E8
		public unsafe ulong _NumFavorites_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumFavorites_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumFavorites_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00057B1C File Offset: 0x00055D1C
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x00003803 File Offset: 0x00001A03
		public unsafe ulong _NumFollowers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumFollowers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumFollowers_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x00057B44 File Offset: 0x00055D44
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x0000381E File Offset: 0x00001A1E
		public unsafe ulong _NumUniqueSubscriptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumUniqueSubscriptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumUniqueSubscriptions_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00057B6C File Offset: 0x00055D6C
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00003839 File Offset: 0x00001A39
		public unsafe ulong _NumUniqueFavorites_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumUniqueFavorites_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumUniqueFavorites_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00057B94 File Offset: 0x00055D94
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00003854 File Offset: 0x00001A54
		public unsafe ulong _NumUniqueFollowers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumUniqueFollowers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumUniqueFollowers_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00057BBC File Offset: 0x00055DBC
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x0000386F File Offset: 0x00001A6F
		public unsafe ulong _NumUniqueWebsiteViews_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumUniqueWebsiteViews_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumUniqueWebsiteViews_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00057BE4 File Offset: 0x00055DE4
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0000388A File Offset: 0x00001A8A
		public unsafe ulong _ReportScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__ReportScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__ReportScore_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00057C0C File Offset: 0x00055E0C
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x000038A5 File Offset: 0x00001AA5
		public unsafe ulong _NumSecondsPlayed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumSecondsPlayed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumSecondsPlayed_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00057C34 File Offset: 0x00055E34
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x000038C0 File Offset: 0x00001AC0
		public unsafe ulong _NumPlaytimeSessions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumPlaytimeSessions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumPlaytimeSessions_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00057C5C File Offset: 0x00055E5C
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x000038DB File Offset: 0x00001ADB
		public unsafe ulong _NumComments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumComments_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumComments_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00057C84 File Offset: 0x00055E84
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000038F6 File Offset: 0x00001AF6
		public unsafe ulong _NumSecondsPlayedDuringTimePeriod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumSecondsPlayedDuringTimePeriod_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumSecondsPlayedDuringTimePeriod_k__BackingField)) = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00057CAC File Offset: 0x00055EAC
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00003911 File Offset: 0x00001B11
		public unsafe ulong _NumPlaytimeSessionsDuringTimePeriod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumPlaytimeSessionsDuringTimePeriod_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__NumPlaytimeSessionsDuringTimePeriod_k__BackingField)) = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00057CD4 File Offset: 0x00055ED4
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x0000392C File Offset: 0x00001B2C
		public unsafe string _PreviewImageUrl_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__PreviewImageUrl_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__PreviewImageUrl_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00057CFC File Offset: 0x00055EFC
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x0000394B File Offset: 0x00001B4B
		public unsafe string _Metadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__Metadata_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item.NativeFieldInfoPtr__Metadata_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeFieldInfoPtr_details;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeFieldInfoPtr__Title_k__BackingField;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr__KeyValueTags_k__BackingField;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_Children;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr__AdditionalPreviews_k__BackingField;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeFieldInfoPtr__NumSubscriptions_k__BackingField;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeFieldInfoPtr__NumFavorites_k__BackingField;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeFieldInfoPtr__NumFollowers_k__BackingField;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeFieldInfoPtr__NumUniqueSubscriptions_k__BackingField;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeFieldInfoPtr__NumUniqueFavorites_k__BackingField;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeFieldInfoPtr__NumUniqueFollowers_k__BackingField;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeFieldInfoPtr__NumUniqueWebsiteViews_k__BackingField;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeFieldInfoPtr__ReportScore_k__BackingField;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeFieldInfoPtr__NumSecondsPlayed_k__BackingField;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeFieldInfoPtr__NumPlaytimeSessions_k__BackingField;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeFieldInfoPtr__NumComments_k__BackingField;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeFieldInfoPtr__NumSecondsPlayedDuringTimePeriod_k__BackingField;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeFieldInfoPtr__NumPlaytimeSessionsDuringTimePeriod_k__BackingField;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeFieldInfoPtr__PreviewImageUrl_k__BackingField;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeFieldInfoPtr__Metadata_k__BackingField;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PublishedFileId_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_PublishedFileId_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_set_Title_Internal_set_Void_String_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_set_Description_Internal_set_Void_String_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_Il2CppStringArray_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_set_Tags_Internal_set_Void_Il2CppStringArray_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyValueTags_Public_get_Dictionary_2_String_String_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyValueTags_Internal_set_Void_Dictionary_2_String_String_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatorApp_Public_get_AppId_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumerApp_Public_get_AppId_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_Friend_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_get_Score_Public_get_Single_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_get_Created_Public_get_DateTime_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_get_Updated_Public_get_DateTime_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPublic_Public_get_Boolean_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFriendsOnly_Public_get_Boolean_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrivate_Public_get_Boolean_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBanned_Public_get_Boolean_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptedForUse_Public_get_Boolean_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr_get_VotesUp_Public_get_UInt32_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr_get_VotesDown_Public_get_UInt32_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalPreviews_Public_get_Il2CppReferenceArray_1_UgcAdditionalPreview_0;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalPreviews_Internal_set_Void_Il2CppReferenceArray_1_UgcAdditionalPreview_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInstalled_Public_get_Boolean_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDownloading_Public_get_Boolean_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDownloadPending_Public_get_Boolean_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSubscribed_Public_get_Boolean_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedsUpdate_Public_get_Boolean_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_get_Directory_Public_get_String_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_Download_Public_Boolean_Boolean_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_get_DownloadBytesTotal_Public_get_Int64_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_get_DownloadBytesDownloaded_Public_get_Int64_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeBytes_Public_get_Int64_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_get_DownloadAmount_Public_get_Single_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Private_get_ItemState_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_GetAsync_Public_Static_Task_1_Nullable_1_Item_PublishedFileId_Int32_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_From_Internal_Static_Item_SteamUGCDetails_t_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_HasTag_Public_Boolean_String_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Task_1_Boolean_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_DownloadAsync_Public_Task_1_Boolean_Action_1_Single_Int32_CancellationToken_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Task_1_Boolean_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_AddFavorite_Public_Task_1_Boolean_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFavorite_Public_Task_1_Boolean_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_Vote_Public_Task_1_Nullable_1_Result_Boolean_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_GetUserVote_Public_Task_1_Nullable_1_UserItemVote_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_get_Url_Public_get_String_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_get_ChangelogUrl_Public_get_String_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_get_CommentsUrl_Public_get_String_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_get_DiscussUrl_Public_get_String_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_get_StatsUrl_Public_get_String_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_get_NumSubscriptions_Public_get_UInt64_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_set_NumSubscriptions_Internal_set_Void_UInt64_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_get_NumFavorites_Public_get_UInt64_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_set_NumFavorites_Internal_set_Void_UInt64_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_get_NumFollowers_Public_get_UInt64_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_set_NumFollowers_Internal_set_Void_UInt64_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUniqueSubscriptions_Public_get_UInt64_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_set_NumUniqueSubscriptions_Internal_set_Void_UInt64_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUniqueFavorites_Public_get_UInt64_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_set_NumUniqueFavorites_Internal_set_Void_UInt64_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUniqueFollowers_Public_get_UInt64_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_set_NumUniqueFollowers_Internal_set_Void_UInt64_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_get_NumUniqueWebsiteViews_Public_get_UInt64_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_set_NumUniqueWebsiteViews_Internal_set_Void_UInt64_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_get_ReportScore_Public_get_UInt64_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_set_ReportScore_Internal_set_Void_UInt64_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_get_NumSecondsPlayed_Public_get_UInt64_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_set_NumSecondsPlayed_Internal_set_Void_UInt64_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_get_NumPlaytimeSessions_Public_get_UInt64_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_set_NumPlaytimeSessions_Internal_set_Void_UInt64_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_get_NumComments_Public_get_UInt64_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_set_NumComments_Internal_set_Void_UInt64_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_get_NumSecondsPlayedDuringTimePeriod_Public_get_UInt64_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_set_NumSecondsPlayedDuringTimePeriod_Internal_set_Void_UInt64_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_get_NumPlaytimeSessionsDuringTimePeriod_Public_get_UInt64_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_set_NumPlaytimeSessionsDuringTimePeriod_Internal_set_Void_UInt64_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviewImageUrl_Public_get_String_0;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr_set_PreviewImageUrl_Internal_set_Void_String_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_get_String_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_set_Metadata_Internal_set_Void_String_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_Edit_Public_Editor_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_AddDependency_Public_Task_1_Boolean_PublishedFileId_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDependency_Public_Task_1_Boolean_PublishedFileId_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Result_0;

		// Token: 0x0200028D RID: 653
		[ObfuscatedName("Steamworks.Ugc.Item+<AddDependency>d__156")]
		public sealed class _AddDependency_d__156 : ValueType
		{
			// Token: 0x06002118 RID: 8472 RVA: 0x00090854 File Offset: 0x0008EA54
			// Note: this type is marked as 'beforefieldinit'.
			static _AddDependency_d__156()
			{
				Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<AddDependency>d__156");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr);
				Item._AddDependency_d__156.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr, "<>1__state");
				Item._AddDependency_d__156.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr, "<>t__builder");
				Item._AddDependency_d__156.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr, "<>4__this");
				Item._AddDependency_d__156.NativeFieldInfoPtr_child = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr, "child");
				Item._AddDependency_d__156.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr, "<>u__1");
				Item._AddDependency_d__156.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr, 100666577);
				Item._AddDependency_d__156.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr, 100666578);
			}

			// Token: 0x06002119 RID: 8473 RVA: 0x0009090C File Offset: 0x0008EB0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948753, XrefRangeEnd = 948774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._AddDependency_d__156.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600211A RID: 8474 RVA: 0x00090944 File Offset: 0x0008EB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948774, XrefRangeEnd = 948780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._AddDependency_d__156.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600211B RID: 8475 RVA: 0x0000CE51 File Offset: 0x0000B051
			public _AddDependency_d__156(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600211C RID: 8476 RVA: 0x0000CE5A File Offset: 0x0000B05A
			public _AddDependency_d__156()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._AddDependency_d__156>.NativeClassPtr))
			{
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x0600211D RID: 8477 RVA: 0x0009098C File Offset: 0x0008EB8C
			// (set) Token: 0x0600211E RID: 8478 RVA: 0x0000CE6C File Offset: 0x0000B06C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x0600211F RID: 8479 RVA: 0x000909B4 File Offset: 0x0008EBB4
			// (set) Token: 0x06002120 RID: 8480 RVA: 0x0000CE87 File Offset: 0x0000B087
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06002121 RID: 8481 RVA: 0x000909E4 File Offset: 0x0008EBE4
			// (set) Token: 0x06002122 RID: 8482 RVA: 0x0000CEB5 File Offset: 0x0000B0B5
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x06002123 RID: 8483 RVA: 0x00090A14 File Offset: 0x0008EC14
			// (set) Token: 0x06002124 RID: 8484 RVA: 0x0000CEE3 File Offset: 0x0000B0E3
			public unsafe PublishedFileId child
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr_child);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr_child)) = value;
				}
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06002125 RID: 8485 RVA: 0x00090A3C File Offset: 0x0008EC3C
			// (set) Token: 0x06002126 RID: 8486 RVA: 0x0000CEFE File Offset: 0x0000B0FE
			public CallResult<AddUGCDependencyResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr___u__1);
					return new CallResult<AddUGCDependencyResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<AddUGCDependencyResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddDependency_d__156.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<AddUGCDependencyResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400231E RID: 8990
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400231F RID: 8991
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002320 RID: 8992
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002321 RID: 8993
			private static readonly IntPtr NativeFieldInfoPtr_child;

			// Token: 0x04002322 RID: 8994
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002323 RID: 8995
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002324 RID: 8996
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200028E RID: 654
		[ObfuscatedName("Steamworks.Ugc.Item+<AddFavorite>d__81")]
		public sealed class _AddFavorite_d__81 : ValueType
		{
			// Token: 0x06002127 RID: 8487 RVA: 0x00090A6C File Offset: 0x0008EC6C
			// Note: this type is marked as 'beforefieldinit'.
			static _AddFavorite_d__81()
			{
				Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<AddFavorite>d__81");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr);
				Item._AddFavorite_d__81.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr, "<>1__state");
				Item._AddFavorite_d__81.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr, "<>t__builder");
				Item._AddFavorite_d__81.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr, "<>4__this");
				Item._AddFavorite_d__81.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr, "<>u__1");
				Item._AddFavorite_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr, 100666579);
				Item._AddFavorite_d__81.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr, 100666580);
			}

			// Token: 0x06002128 RID: 8488 RVA: 0x00090B10 File Offset: 0x0008ED10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948780, XrefRangeEnd = 948801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._AddFavorite_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002129 RID: 8489 RVA: 0x00090B48 File Offset: 0x0008ED48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948801, XrefRangeEnd = 948807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._AddFavorite_d__81.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600212A RID: 8490 RVA: 0x0000CF2C File Offset: 0x0000B12C
			public _AddFavorite_d__81(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600212B RID: 8491 RVA: 0x0000CF35 File Offset: 0x0000B135
			public _AddFavorite_d__81()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._AddFavorite_d__81>.NativeClassPtr))
			{
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x0600212C RID: 8492 RVA: 0x00090B90 File Offset: 0x0008ED90
			// (set) Token: 0x0600212D RID: 8493 RVA: 0x0000CF47 File Offset: 0x0000B147
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddFavorite_d__81.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddFavorite_d__81.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x0600212E RID: 8494 RVA: 0x00090BB8 File Offset: 0x0008EDB8
			// (set) Token: 0x0600212F RID: 8495 RVA: 0x0000CF62 File Offset: 0x0000B162
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddFavorite_d__81.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddFavorite_d__81.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06002130 RID: 8496 RVA: 0x00090BE8 File Offset: 0x0008EDE8
			// (set) Token: 0x06002131 RID: 8497 RVA: 0x0000CF90 File Offset: 0x0000B190
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddFavorite_d__81.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddFavorite_d__81.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06002132 RID: 8498 RVA: 0x00090C18 File Offset: 0x0008EE18
			// (set) Token: 0x06002133 RID: 8499 RVA: 0x0000CFBE File Offset: 0x0000B1BE
			public CallResult<UserFavoriteItemsListChanged_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddFavorite_d__81.NativeFieldInfoPtr___u__1);
					return new CallResult<UserFavoriteItemsListChanged_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<UserFavoriteItemsListChanged_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._AddFavorite_d__81.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<UserFavoriteItemsListChanged_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002325 RID: 8997
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002326 RID: 8998
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002327 RID: 8999
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002328 RID: 9000
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002329 RID: 9001
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400232A RID: 9002
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200028F RID: 655
		[ObfuscatedName("Steamworks.Ugc.Item+<DownloadAsync>d__79")]
		public sealed class _DownloadAsync_d__79 : ValueType
		{
			// Token: 0x06002134 RID: 8500 RVA: 0x00090C48 File Offset: 0x0008EE48
			// Note: this type is marked as 'beforefieldinit'.
			static _DownloadAsync_d__79()
			{
				Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<DownloadAsync>d__79");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr);
				Item._DownloadAsync_d__79.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, "<>1__state");
				Item._DownloadAsync_d__79.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, "<>t__builder");
				Item._DownloadAsync_d__79.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, "<>4__this");
				Item._DownloadAsync_d__79.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, "progress");
				Item._DownloadAsync_d__79.NativeFieldInfoPtr_milisecondsUpdateDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, "milisecondsUpdateDelay");
				Item._DownloadAsync_d__79.NativeFieldInfoPtr_ct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, "ct");
				Item._DownloadAsync_d__79.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, "<>u__1");
				Item._DownloadAsync_d__79.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, 100666581);
				Item._DownloadAsync_d__79.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr, 100666582);
			}

			// Token: 0x06002135 RID: 8501 RVA: 0x00090D28 File Offset: 0x0008EF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948807, XrefRangeEnd = 948825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._DownloadAsync_d__79.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002136 RID: 8502 RVA: 0x00090D60 File Offset: 0x0008EF60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948825, XrefRangeEnd = 948831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._DownloadAsync_d__79.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002137 RID: 8503 RVA: 0x0000CFEC File Offset: 0x0000B1EC
			public _DownloadAsync_d__79(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002138 RID: 8504 RVA: 0x0000CFF5 File Offset: 0x0000B1F5
			public _DownloadAsync_d__79()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._DownloadAsync_d__79>.NativeClassPtr))
			{
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06002139 RID: 8505 RVA: 0x00090DA8 File Offset: 0x0008EFA8
			// (set) Token: 0x0600213A RID: 8506 RVA: 0x0000D007 File Offset: 0x0000B207
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x0600213B RID: 8507 RVA: 0x00090DD0 File Offset: 0x0008EFD0
			// (set) Token: 0x0600213C RID: 8508 RVA: 0x0000D022 File Offset: 0x0000B222
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x0600213D RID: 8509 RVA: 0x00090E00 File Offset: 0x0008F000
			// (set) Token: 0x0600213E RID: 8510 RVA: 0x0000D050 File Offset: 0x0000B250
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x0600213F RID: 8511 RVA: 0x00090E30 File Offset: 0x0008F030
			// (set) Token: 0x06002140 RID: 8512 RVA: 0x0000D07E File Offset: 0x0000B27E
			public unsafe Action<float> progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr_progress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06002141 RID: 8513 RVA: 0x00090E60 File Offset: 0x0008F060
			// (set) Token: 0x06002142 RID: 8514 RVA: 0x0000D09D File Offset: 0x0000B29D
			public unsafe int milisecondsUpdateDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr_milisecondsUpdateDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr_milisecondsUpdateDelay)) = value;
				}
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06002143 RID: 8515 RVA: 0x00090E88 File Offset: 0x0008F088
			// (set) Token: 0x06002144 RID: 8516 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
			public CancellationToken ct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr_ct);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr_ct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x06002145 RID: 8517 RVA: 0x00090EB8 File Offset: 0x0008F0B8
			// (set) Token: 0x06002146 RID: 8518 RVA: 0x0000D0E6 File Offset: 0x0000B2E6
			public TaskAwaiter<bool> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._DownloadAsync_d__79.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400232B RID: 9003
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400232C RID: 9004
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400232D RID: 9005
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400232E RID: 9006
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x0400232F RID: 9007
			private static readonly IntPtr NativeFieldInfoPtr_milisecondsUpdateDelay;

			// Token: 0x04002330 RID: 9008
			private static readonly IntPtr NativeFieldInfoPtr_ct;

			// Token: 0x04002331 RID: 9009
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002332 RID: 9010
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002333 RID: 9011
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000290 RID: 656
		[ObfuscatedName("Steamworks.Ugc.Item+<GetAsync>d__75")]
		public sealed class _GetAsync_d__75 : ValueType
		{
			// Token: 0x06002147 RID: 8519 RVA: 0x00090EE8 File Offset: 0x0008F0E8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAsync_d__75()
			{
				Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<GetAsync>d__75");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr);
				Item._GetAsync_d__75.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr, "<>1__state");
				Item._GetAsync_d__75.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr, "<>t__builder");
				Item._GetAsync_d__75.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr, "id");
				Item._GetAsync_d__75.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr, "<>u__1");
				Item._GetAsync_d__75.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr, 100666583);
				Item._GetAsync_d__75.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr, 100666584);
			}

			// Token: 0x06002148 RID: 8520 RVA: 0x00090F8C File Offset: 0x0008F18C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948831, XrefRangeEnd = 948884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._GetAsync_d__75.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002149 RID: 8521 RVA: 0x00090FC4 File Offset: 0x0008F1C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948884, XrefRangeEnd = 948890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._GetAsync_d__75.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600214A RID: 8522 RVA: 0x0000D114 File Offset: 0x0000B314
			public _GetAsync_d__75(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600214B RID: 8523 RVA: 0x0000D11D File Offset: 0x0000B31D
			public _GetAsync_d__75()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._GetAsync_d__75>.NativeClassPtr))
			{
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x0600214C RID: 8524 RVA: 0x0009100C File Offset: 0x0008F20C
			// (set) Token: 0x0600214D RID: 8525 RVA: 0x0000D12F File Offset: 0x0000B32F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetAsync_d__75.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetAsync_d__75.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008A1 RID: 2209
			// (get) Token: 0x0600214E RID: 8526 RVA: 0x00091034 File Offset: 0x0008F234
			// (set) Token: 0x0600214F RID: 8527 RVA: 0x0000D14A File Offset: 0x0000B34A
			public AsyncTaskMethodBuilder<Nullable<Item>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetAsync_d__75.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Item>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Item>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetAsync_d__75.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Item>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06002150 RID: 8528 RVA: 0x00091064 File Offset: 0x0008F264
			// (set) Token: 0x06002151 RID: 8529 RVA: 0x0000D178 File Offset: 0x0000B378
			public unsafe PublishedFileId id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetAsync_d__75.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetAsync_d__75.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06002152 RID: 8530 RVA: 0x0009108C File Offset: 0x0008F28C
			// (set) Token: 0x06002153 RID: 8531 RVA: 0x0000D193 File Offset: 0x0000B393
			public TaskAwaiter<Nullable<ResultPage>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetAsync_d__75.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<ResultPage>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<ResultPage>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetAsync_d__75.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<ResultPage>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002334 RID: 9012
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002335 RID: 9013
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002336 RID: 9014
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04002337 RID: 9015
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002338 RID: 9016
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002339 RID: 9017
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000291 RID: 657
		[ObfuscatedName("Steamworks.Ugc.Item+<GetUserVote>d__84")]
		public sealed class _GetUserVote_d__84 : ValueType
		{
			// Token: 0x06002154 RID: 8532 RVA: 0x000910BC File Offset: 0x0008F2BC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetUserVote_d__84()
			{
				Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<GetUserVote>d__84");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr);
				Item._GetUserVote_d__84.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr, "<>1__state");
				Item._GetUserVote_d__84.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr, "<>t__builder");
				Item._GetUserVote_d__84.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr, "<>4__this");
				Item._GetUserVote_d__84.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr, "<>u__1");
				Item._GetUserVote_d__84.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr, 100666585);
				Item._GetUserVote_d__84.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr, 100666586);
			}

			// Token: 0x06002155 RID: 8533 RVA: 0x00091160 File Offset: 0x0008F360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948890, XrefRangeEnd = 948917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._GetUserVote_d__84.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002156 RID: 8534 RVA: 0x00091198 File Offset: 0x0008F398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948917, XrefRangeEnd = 948923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._GetUserVote_d__84.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002157 RID: 8535 RVA: 0x0000D1C1 File Offset: 0x0000B3C1
			public _GetUserVote_d__84(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002158 RID: 8536 RVA: 0x0000D1CA File Offset: 0x0000B3CA
			public _GetUserVote_d__84()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._GetUserVote_d__84>.NativeClassPtr))
			{
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06002159 RID: 8537 RVA: 0x000911E0 File Offset: 0x0008F3E0
			// (set) Token: 0x0600215A RID: 8538 RVA: 0x0000D1DC File Offset: 0x0000B3DC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetUserVote_d__84.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetUserVote_d__84.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x0600215B RID: 8539 RVA: 0x00091208 File Offset: 0x0008F408
			// (set) Token: 0x0600215C RID: 8540 RVA: 0x0000D1F7 File Offset: 0x0000B3F7
			public AsyncTaskMethodBuilder<Nullable<UserItemVote>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetUserVote_d__84.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<UserItemVote>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<UserItemVote>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetUserVote_d__84.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<UserItemVote>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x0600215D RID: 8541 RVA: 0x00091238 File Offset: 0x0008F438
			// (set) Token: 0x0600215E RID: 8542 RVA: 0x0000D225 File Offset: 0x0000B425
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetUserVote_d__84.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetUserVote_d__84.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x0600215F RID: 8543 RVA: 0x00091268 File Offset: 0x0008F468
			// (set) Token: 0x06002160 RID: 8544 RVA: 0x0000D253 File Offset: 0x0000B453
			public CallResult<GetUserItemVoteResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetUserVote_d__84.NativeFieldInfoPtr___u__1);
					return new CallResult<GetUserItemVoteResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<GetUserItemVoteResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._GetUserVote_d__84.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<GetUserItemVoteResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400233A RID: 9018
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400233B RID: 9019
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400233C RID: 9020
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400233D RID: 9021
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400233E RID: 9022
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400233F RID: 9023
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000292 RID: 658
		[ObfuscatedName("Steamworks.Ugc.Item+<RemoveDependency>d__157")]
		public sealed class _RemoveDependency_d__157 : ValueType
		{
			// Token: 0x06002161 RID: 8545 RVA: 0x00091298 File Offset: 0x0008F498
			// Note: this type is marked as 'beforefieldinit'.
			static _RemoveDependency_d__157()
			{
				Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<RemoveDependency>d__157");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr);
				Item._RemoveDependency_d__157.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr, "<>1__state");
				Item._RemoveDependency_d__157.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr, "<>t__builder");
				Item._RemoveDependency_d__157.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr, "<>4__this");
				Item._RemoveDependency_d__157.NativeFieldInfoPtr_child = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr, "child");
				Item._RemoveDependency_d__157.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr, "<>u__1");
				Item._RemoveDependency_d__157.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr, 100666587);
				Item._RemoveDependency_d__157.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr, 100666588);
			}

			// Token: 0x06002162 RID: 8546 RVA: 0x00091350 File Offset: 0x0008F550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948923, XrefRangeEnd = 948944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._RemoveDependency_d__157.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002163 RID: 8547 RVA: 0x00091388 File Offset: 0x0008F588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948944, XrefRangeEnd = 948950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._RemoveDependency_d__157.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002164 RID: 8548 RVA: 0x0000D281 File Offset: 0x0000B481
			public _RemoveDependency_d__157(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002165 RID: 8549 RVA: 0x0000D28A File Offset: 0x0000B48A
			public _RemoveDependency_d__157()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._RemoveDependency_d__157>.NativeClassPtr))
			{
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06002166 RID: 8550 RVA: 0x000913D0 File Offset: 0x0008F5D0
			// (set) Token: 0x06002167 RID: 8551 RVA: 0x0000D29C File Offset: 0x0000B49C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06002168 RID: 8552 RVA: 0x000913F8 File Offset: 0x0008F5F8
			// (set) Token: 0x06002169 RID: 8553 RVA: 0x0000D2B7 File Offset: 0x0000B4B7
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x0600216A RID: 8554 RVA: 0x00091428 File Offset: 0x0008F628
			// (set) Token: 0x0600216B RID: 8555 RVA: 0x0000D2E5 File Offset: 0x0000B4E5
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x0600216C RID: 8556 RVA: 0x00091458 File Offset: 0x0008F658
			// (set) Token: 0x0600216D RID: 8557 RVA: 0x0000D313 File Offset: 0x0000B513
			public unsafe PublishedFileId child
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr_child);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr_child)) = value;
				}
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x0600216E RID: 8558 RVA: 0x00091480 File Offset: 0x0008F680
			// (set) Token: 0x0600216F RID: 8559 RVA: 0x0000D32E File Offset: 0x0000B52E
			public CallResult<RemoveUGCDependencyResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr___u__1);
					return new CallResult<RemoveUGCDependencyResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<RemoveUGCDependencyResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveDependency_d__157.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<RemoveUGCDependencyResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002340 RID: 9024
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002341 RID: 9025
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002342 RID: 9026
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002343 RID: 9027
			private static readonly IntPtr NativeFieldInfoPtr_child;

			// Token: 0x04002344 RID: 9028
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002345 RID: 9029
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002346 RID: 9030
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000293 RID: 659
		[ObfuscatedName("Steamworks.Ugc.Item+<RemoveFavorite>d__82")]
		public sealed class _RemoveFavorite_d__82 : ValueType
		{
			// Token: 0x06002170 RID: 8560 RVA: 0x000914B0 File Offset: 0x0008F6B0
			// Note: this type is marked as 'beforefieldinit'.
			static _RemoveFavorite_d__82()
			{
				Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<RemoveFavorite>d__82");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr);
				Item._RemoveFavorite_d__82.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr, "<>1__state");
				Item._RemoveFavorite_d__82.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr, "<>t__builder");
				Item._RemoveFavorite_d__82.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr, "<>4__this");
				Item._RemoveFavorite_d__82.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr, "<>u__1");
				Item._RemoveFavorite_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr, 100666589);
				Item._RemoveFavorite_d__82.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr, 100666590);
			}

			// Token: 0x06002171 RID: 8561 RVA: 0x00091554 File Offset: 0x0008F754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948950, XrefRangeEnd = 948971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._RemoveFavorite_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002172 RID: 8562 RVA: 0x0009158C File Offset: 0x0008F78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948971, XrefRangeEnd = 948977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._RemoveFavorite_d__82.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002173 RID: 8563 RVA: 0x0000D35C File Offset: 0x0000B55C
			public _RemoveFavorite_d__82(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002174 RID: 8564 RVA: 0x0000D365 File Offset: 0x0000B565
			public _RemoveFavorite_d__82()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._RemoveFavorite_d__82>.NativeClassPtr))
			{
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06002175 RID: 8565 RVA: 0x000915D4 File Offset: 0x0008F7D4
			// (set) Token: 0x06002176 RID: 8566 RVA: 0x0000D377 File Offset: 0x0000B577
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveFavorite_d__82.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveFavorite_d__82.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06002177 RID: 8567 RVA: 0x000915FC File Offset: 0x0008F7FC
			// (set) Token: 0x06002178 RID: 8568 RVA: 0x0000D392 File Offset: 0x0000B592
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveFavorite_d__82.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveFavorite_d__82.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06002179 RID: 8569 RVA: 0x0009162C File Offset: 0x0008F82C
			// (set) Token: 0x0600217A RID: 8570 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveFavorite_d__82.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveFavorite_d__82.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x0600217B RID: 8571 RVA: 0x0009165C File Offset: 0x0008F85C
			// (set) Token: 0x0600217C RID: 8572 RVA: 0x0000D3EE File Offset: 0x0000B5EE
			public CallResult<UserFavoriteItemsListChanged_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveFavorite_d__82.NativeFieldInfoPtr___u__1);
					return new CallResult<UserFavoriteItemsListChanged_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<UserFavoriteItemsListChanged_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._RemoveFavorite_d__82.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<UserFavoriteItemsListChanged_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002347 RID: 9031
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002348 RID: 9032
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002349 RID: 9033
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400234A RID: 9034
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400234B RID: 9035
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400234C RID: 9036
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000294 RID: 660
		[ObfuscatedName("Steamworks.Ugc.Item+<Subscribe>d__78")]
		public sealed class _Subscribe_d__78 : ValueType
		{
			// Token: 0x0600217D RID: 8573 RVA: 0x0009168C File Offset: 0x0008F88C
			// Note: this type is marked as 'beforefieldinit'.
			static _Subscribe_d__78()
			{
				Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<Subscribe>d__78");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr);
				Item._Subscribe_d__78.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr, "<>1__state");
				Item._Subscribe_d__78.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr, "<>t__builder");
				Item._Subscribe_d__78.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr, "<>4__this");
				Item._Subscribe_d__78.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr, "<>u__1");
				Item._Subscribe_d__78.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr, 100666591);
				Item._Subscribe_d__78.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr, 100666592);
			}

			// Token: 0x0600217E RID: 8574 RVA: 0x00091730 File Offset: 0x0008F930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948977, XrefRangeEnd = 948999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._Subscribe_d__78.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600217F RID: 8575 RVA: 0x00091768 File Offset: 0x0008F968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948999, XrefRangeEnd = 949005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._Subscribe_d__78.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002180 RID: 8576 RVA: 0x0000D41C File Offset: 0x0000B61C
			public _Subscribe_d__78(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002181 RID: 8577 RVA: 0x0000D425 File Offset: 0x0000B625
			public _Subscribe_d__78()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._Subscribe_d__78>.NativeClassPtr))
			{
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x06002182 RID: 8578 RVA: 0x000917B0 File Offset: 0x0008F9B0
			// (set) Token: 0x06002183 RID: 8579 RVA: 0x0000D437 File Offset: 0x0000B637
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Subscribe_d__78.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Subscribe_d__78.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06002184 RID: 8580 RVA: 0x000917D8 File Offset: 0x0008F9D8
			// (set) Token: 0x06002185 RID: 8581 RVA: 0x0000D452 File Offset: 0x0000B652
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Subscribe_d__78.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Subscribe_d__78.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06002186 RID: 8582 RVA: 0x00091808 File Offset: 0x0008FA08
			// (set) Token: 0x06002187 RID: 8583 RVA: 0x0000D480 File Offset: 0x0000B680
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Subscribe_d__78.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Subscribe_d__78.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06002188 RID: 8584 RVA: 0x00091838 File Offset: 0x0008FA38
			// (set) Token: 0x06002189 RID: 8585 RVA: 0x0000D4AE File Offset: 0x0000B6AE
			public CallResult<RemoteStorageSubscribePublishedFileResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Subscribe_d__78.NativeFieldInfoPtr___u__1);
					return new CallResult<RemoteStorageSubscribePublishedFileResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<RemoteStorageSubscribePublishedFileResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Subscribe_d__78.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<RemoteStorageSubscribePublishedFileResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400234D RID: 9037
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400234E RID: 9038
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400234F RID: 9039
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002350 RID: 9040
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002351 RID: 9041
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002352 RID: 9042
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000295 RID: 661
		[ObfuscatedName("Steamworks.Ugc.Item+<Unsubscribe>d__80")]
		public sealed class _Unsubscribe_d__80 : ValueType
		{
			// Token: 0x0600218A RID: 8586 RVA: 0x00091868 File Offset: 0x0008FA68
			// Note: this type is marked as 'beforefieldinit'.
			static _Unsubscribe_d__80()
			{
				Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<Unsubscribe>d__80");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr);
				Item._Unsubscribe_d__80.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr, "<>1__state");
				Item._Unsubscribe_d__80.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr, "<>t__builder");
				Item._Unsubscribe_d__80.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr, "<>4__this");
				Item._Unsubscribe_d__80.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr, "<>u__1");
				Item._Unsubscribe_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr, 100666593);
				Item._Unsubscribe_d__80.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr, 100666594);
			}

			// Token: 0x0600218B RID: 8587 RVA: 0x0009190C File Offset: 0x0008FB0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949005, XrefRangeEnd = 949027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._Unsubscribe_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600218C RID: 8588 RVA: 0x00091944 File Offset: 0x0008FB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949027, XrefRangeEnd = 949033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._Unsubscribe_d__80.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600218D RID: 8589 RVA: 0x0000D4DC File Offset: 0x0000B6DC
			public _Unsubscribe_d__80(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600218E RID: 8590 RVA: 0x0000D4E5 File Offset: 0x0000B6E5
			public _Unsubscribe_d__80()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._Unsubscribe_d__80>.NativeClassPtr))
			{
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x0600218F RID: 8591 RVA: 0x0009198C File Offset: 0x0008FB8C
			// (set) Token: 0x06002190 RID: 8592 RVA: 0x0000D4F7 File Offset: 0x0000B6F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Unsubscribe_d__80.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Unsubscribe_d__80.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x06002191 RID: 8593 RVA: 0x000919B4 File Offset: 0x0008FBB4
			// (set) Token: 0x06002192 RID: 8594 RVA: 0x0000D512 File Offset: 0x0000B712
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Unsubscribe_d__80.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Unsubscribe_d__80.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x06002193 RID: 8595 RVA: 0x000919E4 File Offset: 0x0008FBE4
			// (set) Token: 0x06002194 RID: 8596 RVA: 0x0000D540 File Offset: 0x0000B740
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Unsubscribe_d__80.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Unsubscribe_d__80.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x06002195 RID: 8597 RVA: 0x00091A14 File Offset: 0x0008FC14
			// (set) Token: 0x06002196 RID: 8598 RVA: 0x0000D56E File Offset: 0x0000B76E
			public CallResult<RemoteStorageUnsubscribePublishedFileResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Unsubscribe_d__80.NativeFieldInfoPtr___u__1);
					return new CallResult<RemoteStorageUnsubscribePublishedFileResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<RemoteStorageUnsubscribePublishedFileResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Unsubscribe_d__80.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<RemoteStorageUnsubscribePublishedFileResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002353 RID: 9043
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002354 RID: 9044
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002355 RID: 9045
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002356 RID: 9046
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002357 RID: 9047
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002358 RID: 9048
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000296 RID: 662
		[ObfuscatedName("Steamworks.Ugc.Item+<Vote>d__83")]
		public sealed class _Vote_d__83 : ValueType
		{
			// Token: 0x06002197 RID: 8599 RVA: 0x00091A44 File Offset: 0x0008FC44
			// Note: this type is marked as 'beforefieldinit'.
			static _Vote_d__83()
			{
				Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Item>.NativeClassPtr, "<Vote>d__83");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr);
				Item._Vote_d__83.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr, "<>1__state");
				Item._Vote_d__83.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr, "<>t__builder");
				Item._Vote_d__83.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr, "<>4__this");
				Item._Vote_d__83.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr, "up");
				Item._Vote_d__83.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr, "<>u__1");
				Item._Vote_d__83.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr, 100666595);
				Item._Vote_d__83.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr, 100666596);
			}

			// Token: 0x06002198 RID: 8600 RVA: 0x00091AFC File Offset: 0x0008FCFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949033, XrefRangeEnd = 949057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._Vote_d__83.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002199 RID: 8601 RVA: 0x00091B34 File Offset: 0x0008FD34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949057, XrefRangeEnd = 949063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item._Vote_d__83.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600219A RID: 8602 RVA: 0x0000D59C File Offset: 0x0000B79C
			public _Vote_d__83(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600219B RID: 8603 RVA: 0x0000D5A5 File Offset: 0x0000B7A5
			public _Vote_d__83()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item._Vote_d__83>.NativeClassPtr))
			{
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x00091B7C File Offset: 0x0008FD7C
			// (set) Token: 0x0600219D RID: 8605 RVA: 0x0000D5B7 File Offset: 0x0000B7B7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x0600219E RID: 8606 RVA: 0x00091BA4 File Offset: 0x0008FDA4
			// (set) Token: 0x0600219F RID: 8607 RVA: 0x0000D5D2 File Offset: 0x0000B7D2
			public AsyncTaskMethodBuilder<Nullable<Result>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Result>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Result>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Result>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x060021A0 RID: 8608 RVA: 0x00091BD4 File Offset: 0x0008FDD4
			// (set) Token: 0x060021A1 RID: 8609 RVA: 0x0000D600 File Offset: 0x0000B800
			public Item __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr___4__this);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00091C04 File Offset: 0x0008FE04
			// (set) Token: 0x060021A3 RID: 8611 RVA: 0x0000D62E File Offset: 0x0000B82E
			public unsafe bool up
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr_up);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr_up)) = value;
				}
			}

			// Token: 0x170008BD RID: 2237
			// (get) Token: 0x060021A4 RID: 8612 RVA: 0x00091C2C File Offset: 0x0008FE2C
			// (set) Token: 0x060021A5 RID: 8613 RVA: 0x0000D649 File Offset: 0x0000B849
			public CallResult<SetUserItemVoteResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr___u__1);
					return new CallResult<SetUserItemVoteResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<SetUserItemVoteResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Item._Vote_d__83.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<SetUserItemVoteResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002359 RID: 9049
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400235A RID: 9050
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400235B RID: 9051
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400235C RID: 9052
			private static readonly IntPtr NativeFieldInfoPtr_up;

			// Token: 0x0400235D RID: 9053
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400235E RID: 9054
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400235F RID: 9055
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
