using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;
using Steamworks.Ugc;

namespace Steamworks
{
	// Token: 0x020000AF RID: 175
	public class SteamUGC : SteamSharedClass<SteamUGC>
	{
		// Token: 0x06000ADD RID: 2781 RVA: 0x0004C558 File Offset: 0x0004A758
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGC()
		{
			Il2CppClassPointerStore<SteamUGC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamUGC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr);
			SteamUGC.NativeFieldInfoPtr_OnDownloadItemResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "OnDownloadItemResult");
			SteamUGC.NativeFieldInfoPtr_OnItemSubscribed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "OnItemSubscribed");
			SteamUGC.NativeFieldInfoPtr_OnItemUnsubscribed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "OnItemUnsubscribed");
			SteamUGC.NativeFieldInfoPtr_OnItemInstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "OnItemInstalled");
			SteamUGC.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUGC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665950);
			SteamUGC.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665951);
			SteamUGC.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665952);
			SteamUGC.NativeMethodInfoPtr_add_OnDownloadItemResult_Public_Static_add_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665953);
			SteamUGC.NativeMethodInfoPtr_remove_OnDownloadItemResult_Public_Static_rem_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665954);
			SteamUGC.NativeMethodInfoPtr_add_OnItemSubscribed_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665955);
			SteamUGC.NativeMethodInfoPtr_remove_OnItemSubscribed_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665956);
			SteamUGC.NativeMethodInfoPtr_add_OnItemUnsubscribed_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665957);
			SteamUGC.NativeMethodInfoPtr_remove_OnItemUnsubscribed_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665958);
			SteamUGC.NativeMethodInfoPtr_add_OnItemInstalled_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665959);
			SteamUGC.NativeMethodInfoPtr_remove_OnItemInstalled_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665960);
			SteamUGC.NativeMethodInfoPtr_DeleteFileAsync_Public_Static_Task_1_Boolean_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665961);
			SteamUGC.NativeMethodInfoPtr_Download_Public_Static_Boolean_PublishedFileId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665962);
			SteamUGC.NativeMethodInfoPtr_DownloadAsync_Public_Static_Task_1_Boolean_PublishedFileId_Action_1_Single_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665963);
			SteamUGC.NativeMethodInfoPtr_QueryFileAsync_Public_Static_Task_1_Nullable_1_Item_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665964);
			SteamUGC.NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_Task_1_Boolean_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665965);
			SteamUGC.NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_Task_1_Boolean_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665966);
			SteamUGC.NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665967);
			SteamUGC.NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665968);
			SteamUGC.NativeMethodInfoPtr_ResumeDownloads_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665969);
			SteamUGC.NativeMethodInfoPtr_ShowWorkshopEula_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665970);
			SteamUGC.NativeMethodInfoPtr_GetWorkshopEulaStatus_Public_Static_Task_1_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665971);
			SteamUGC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100665972);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0004C7A4 File Offset: 0x0004A9A4
		public unsafe static ISteamUGC Internal
		{
			[CallerCount(78)]
			[CachedScanResults(RefRangeStart = 943570, RefRangeEnd = 943648, XrefRangeStart = 943566, XrefRangeEnd = 943570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUGC_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamUGC>(intPtr3) : null;
			}
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0004C7D8 File Offset: 0x0004A9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943648, XrefRangeEnd = 943653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamUGC.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0004C824 File Offset: 0x0004AA24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 943731, RefRangeEnd = 943732, XrefRangeStart = 943653, XrefRangeEnd = 943731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents(bool server)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0004C858 File Offset: 0x0004AA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943732, XrefRangeEnd = 943741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnDownloadItemResult(Action<Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_add_OnDownloadItemResult_Public_Static_add_Void_Action_1_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0004C890 File Offset: 0x0004AA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943741, XrefRangeEnd = 943750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnDownloadItemResult(Action<Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_remove_OnDownloadItemResult_Public_Static_rem_Void_Action_1_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0004C8C8 File Offset: 0x0004AAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943750, XrefRangeEnd = 943759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnItemSubscribed(Action<AppId, PublishedFileId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_add_OnItemSubscribed_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0004C900 File Offset: 0x0004AB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943759, XrefRangeEnd = 943768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnItemSubscribed(Action<AppId, PublishedFileId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_remove_OnItemSubscribed_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0004C938 File Offset: 0x0004AB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943768, XrefRangeEnd = 943777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnItemUnsubscribed(Action<AppId, PublishedFileId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_add_OnItemUnsubscribed_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0004C970 File Offset: 0x0004AB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943777, XrefRangeEnd = 943786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnItemUnsubscribed(Action<AppId, PublishedFileId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_remove_OnItemUnsubscribed_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0004C9A8 File Offset: 0x0004ABA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943786, XrefRangeEnd = 943795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnItemInstalled(Action<AppId, PublishedFileId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_add_OnItemInstalled_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0004C9E0 File Offset: 0x0004ABE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943795, XrefRangeEnd = 943804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnItemInstalled(Action<AppId, PublishedFileId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_remove_OnItemInstalled_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0004CA18 File Offset: 0x0004AC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943804, XrefRangeEnd = 943817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> DeleteFileAsync(PublishedFileId fileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_DeleteFileAsync_Public_Static_Task_1_Boolean_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0004CA58 File Offset: 0x0004AC58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 943820, RefRangeEnd = 943821, XrefRangeStart = 943817, XrefRangeEnd = 943820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Download(PublishedFileId fileId, bool highPriority = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_Download_Public_Static_Boolean_PublishedFileId_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0004CAA4 File Offset: 0x0004ACA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 943837, RefRangeEnd = 943838, XrefRangeStart = 943821, XrefRangeEnd = 943837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> DownloadAsync(PublishedFileId fileId, Action<float> progress = null, int milisecondsUpdateDelay = 60, CancellationToken ct = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref milisecondsUpdateDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_DownloadAsync_Public_Static_Task_1_Boolean_PublishedFileId_Action_1_Single_Int32_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0004CB1C File Offset: 0x0004AD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943838, XrefRangeEnd = 943851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Item>> QueryFileAsync(PublishedFileId fileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_QueryFileAsync_Public_Static_Task_1_Nullable_1_Item_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Item>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0004CB5C File Offset: 0x0004AD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943851, XrefRangeEnd = 943864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> StartPlaytimeTracking(PublishedFileId fileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_Task_1_Boolean_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0004CB9C File Offset: 0x0004AD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943864, XrefRangeEnd = 943877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> StopPlaytimeTracking(PublishedFileId fileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_Task_1_Boolean_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0004CBDC File Offset: 0x0004ADDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943877, XrefRangeEnd = 943890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> StopPlaytimeTrackingForAllItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_Task_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0004CC10 File Offset: 0x0004AE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943890, XrefRangeEnd = 943893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SuspendDownloads()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0004CC38 File Offset: 0x0004AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943893, XrefRangeEnd = 943896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResumeDownloads()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_ResumeDownloads_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0004CC60 File Offset: 0x0004AE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943896, XrefRangeEnd = 943899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShowWorkshopEula()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_ShowWorkshopEula_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0004CC90 File Offset: 0x0004AE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943899, XrefRangeEnd = 943912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<bool>> GetWorkshopEulaStatus()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetWorkshopEulaStatus_Public_Static_Task_1_Nullable_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<bool>>>(intPtr3) : null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0004CCC4 File Offset: 0x0004AEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943912, XrefRangeEnd = 943915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamUGC()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002C60 File Offset: 0x00000E60
		public SteamUGC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0004CD00 File Offset: 0x0004AF00
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00002C69 File Offset: 0x00000E69
		public unsafe static Action<Result> OnDownloadItemResult
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUGC.NativeFieldInfoPtr_OnDownloadItemResult, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGC.NativeFieldInfoPtr_OnDownloadItemResult, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0004CD28 File Offset: 0x0004AF28
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00002C7B File Offset: 0x00000E7B
		public unsafe static Action<AppId, PublishedFileId> OnItemSubscribed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUGC.NativeFieldInfoPtr_OnItemSubscribed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AppId, PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGC.NativeFieldInfoPtr_OnItemSubscribed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0004CD50 File Offset: 0x0004AF50
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00002C8D File Offset: 0x00000E8D
		public unsafe static Action<AppId, PublishedFileId> OnItemUnsubscribed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUGC.NativeFieldInfoPtr_OnItemUnsubscribed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AppId, PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGC.NativeFieldInfoPtr_OnItemUnsubscribed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0004CD78 File Offset: 0x0004AF78
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00002C9F File Offset: 0x00000E9F
		public unsafe static Action<AppId, PublishedFileId> OnItemInstalled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUGC.NativeFieldInfoPtr_OnItemInstalled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AppId, PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGC.NativeFieldInfoPtr_OnItemInstalled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeFieldInfoPtr_OnDownloadItemResult;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeFieldInfoPtr_OnItemSubscribed;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeFieldInfoPtr_OnItemUnsubscribed;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeFieldInfoPtr_OnItemInstalled;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUGC_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDownloadItemResult_Public_Static_add_Void_Action_1_Result_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDownloadItemResult_Public_Static_rem_Void_Action_1_Result_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_add_OnItemSubscribed_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnItemSubscribed_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_add_OnItemUnsubscribed_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnItemUnsubscribed_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_add_OnItemInstalled_Public_Static_add_Void_Action_2_AppId_PublishedFileId_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnItemInstalled_Public_Static_rem_Void_Action_2_AppId_PublishedFileId_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFileAsync_Public_Static_Task_1_Boolean_PublishedFileId_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_Download_Public_Static_Boolean_PublishedFileId_Boolean_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_DownloadAsync_Public_Static_Task_1_Boolean_PublishedFileId_Action_1_Single_Int32_CancellationToken_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_QueryFileAsync_Public_Static_Task_1_Nullable_1_Item_PublishedFileId_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_Task_1_Boolean_PublishedFileId_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_Task_1_Boolean_PublishedFileId_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_Task_1_Boolean_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_ResumeDownloads_Public_Static_Void_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_ShowWorkshopEula_Public_Static_Boolean_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkshopEulaStatus_Public_Static_Task_1_Nullable_1_Boolean_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000256 RID: 598
		[ObfuscatedName("Steamworks.SteamUGC+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E23 RID: 7715 RVA: 0x000892C4 File Offset: 0x000874C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr);
				SteamUGC.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, "<>9");
				SteamUGC.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, "<>9__3_0");
				SteamUGC.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, "<>9__3_1");
				SteamUGC.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, "<>9__3_2");
				SteamUGC.__c.NativeFieldInfoPtr___9__3_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, "<>9__3_3");
				SteamUGC.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, 100665974);
				SteamUGC.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_DownloadItemResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, 100665975);
				SteamUGC.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_RemoteStoragePublishedFileSubscribed_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, 100665976);
				SteamUGC.__c.NativeMethodInfoPtr__InstallEvents_b__3_2_Internal_Void_RemoteStoragePublishedFileUnsubscribed_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, 100665977);
				SteamUGC.__c.NativeMethodInfoPtr__InstallEvents_b__3_3_Internal_Void_ItemInstalled_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr, 100665978);
			}

			// Token: 0x06001E24 RID: 7716 RVA: 0x000893B8 File Offset: 0x000875B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E25 RID: 7717 RVA: 0x000893F4 File Offset: 0x000875F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943253, XrefRangeEnd = 943255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(DownloadItemResult_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_DownloadItemResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E26 RID: 7718 RVA: 0x00089434 File Offset: 0x00087634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943255, XrefRangeEnd = 943257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(RemoteStoragePublishedFileSubscribed_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_RemoteStoragePublishedFileSubscribed_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E27 RID: 7719 RVA: 0x00089474 File Offset: 0x00087674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943257, XrefRangeEnd = 943259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_2(RemoteStoragePublishedFileUnsubscribed_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.__c.NativeMethodInfoPtr__InstallEvents_b__3_2_Internal_Void_RemoteStoragePublishedFileUnsubscribed_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E28 RID: 7720 RVA: 0x000894B4 File Offset: 0x000876B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943259, XrefRangeEnd = 943261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_3(ItemInstalled_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.__c.NativeMethodInfoPtr__InstallEvents_b__3_3_Internal_Void_ItemInstalled_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E29 RID: 7721 RVA: 0x0000AC94 File Offset: 0x00008E94
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000894F4 File Offset: 0x000876F4
			// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0000AC9D File Offset: 0x00008E9D
			public unsafe static SteamUGC.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUGC.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamUGC.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUGC.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06001E2C RID: 7724 RVA: 0x0008951C File Offset: 0x0008771C
			// (set) Token: 0x06001E2D RID: 7725 RVA: 0x0000ACAF File Offset: 0x00008EAF
			public unsafe static Action<DownloadItemResult_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUGC.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DownloadItemResult_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUGC.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00089544 File Offset: 0x00087744
			// (set) Token: 0x06001E2F RID: 7727 RVA: 0x0000ACC1 File Offset: 0x00008EC1
			public unsafe static Action<RemoteStoragePublishedFileSubscribed_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUGC.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RemoteStoragePublishedFileSubscribed_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUGC.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06001E30 RID: 7728 RVA: 0x0008956C File Offset: 0x0008776C
			// (set) Token: 0x06001E31 RID: 7729 RVA: 0x0000ACD3 File Offset: 0x00008ED3
			public unsafe static Action<RemoteStoragePublishedFileUnsubscribed_t> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUGC.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RemoteStoragePublishedFileUnsubscribed_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUGC.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00089594 File Offset: 0x00087794
			// (set) Token: 0x06001E33 RID: 7731 RVA: 0x0000ACE5 File Offset: 0x00008EE5
			public unsafe static Action<ItemInstalled_t> __9__3_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUGC.__c.NativeFieldInfoPtr___9__3_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ItemInstalled_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUGC.__c.NativeFieldInfoPtr___9__3_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002190 RID: 8592
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002191 RID: 8593
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002192 RID: 8594
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04002193 RID: 8595
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x04002194 RID: 8596
			private static readonly IntPtr NativeFieldInfoPtr___9__3_3;

			// Token: 0x04002195 RID: 8597
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002196 RID: 8598
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_DownloadItemResult_t_0;

			// Token: 0x04002197 RID: 8599
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_RemoteStoragePublishedFileSubscribed_t_0;

			// Token: 0x04002198 RID: 8600
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_2_Internal_Void_RemoteStoragePublishedFileUnsubscribed_t_0;

			// Token: 0x04002199 RID: 8601
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_3_Internal_Void_ItemInstalled_t_0;
		}

		// Token: 0x02000257 RID: 599
		[ObfuscatedName("Steamworks.SteamUGC+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x06001E34 RID: 7732 RVA: 0x000895BC File Offset: 0x000877BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<SteamUGC.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC.__c__DisplayClass18_0>.NativeClassPtr);
				SteamUGC.__c__DisplayClass18_0.NativeFieldInfoPtr_downloadStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC.__c__DisplayClass18_0>.NativeClassPtr, "downloadStarted");
				SteamUGC.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC.__c__DisplayClass18_0>.NativeClassPtr, 100665979);
				SteamUGC.__c__DisplayClass18_0.NativeMethodInfoPtr__DownloadAsync_b__0_Internal_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC.__c__DisplayClass18_0>.NativeClassPtr, 100665980);
			}

			// Token: 0x06001E35 RID: 7733 RVA: 0x00089624 File Offset: 0x00087824
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E36 RID: 7734 RVA: 0x00089660 File Offset: 0x00087860
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DownloadAsync_b__0(Result r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.__c__DisplayClass18_0.NativeMethodInfoPtr__DownloadAsync_b__0_Internal_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E37 RID: 7735 RVA: 0x0000ACF7 File Offset: 0x00008EF7
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x06001E38 RID: 7736 RVA: 0x000896A0 File Offset: 0x000878A0
			// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0000AD00 File Offset: 0x00008F00
			public unsafe bool downloadStarted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC.__c__DisplayClass18_0.NativeFieldInfoPtr_downloadStarted);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC.__c__DisplayClass18_0.NativeFieldInfoPtr_downloadStarted)) = value;
				}
			}

			// Token: 0x0400219A RID: 8602
			private static readonly IntPtr NativeFieldInfoPtr_downloadStarted;

			// Token: 0x0400219B RID: 8603
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400219C RID: 8604
			private static readonly IntPtr NativeMethodInfoPtr__DownloadAsync_b__0_Internal_Void_Result_0;
		}

		// Token: 0x02000258 RID: 600
		[ObfuscatedName("Steamworks.SteamUGC+<DeleteFileAsync>d__16")]
		public sealed class _DeleteFileAsync_d__16 : ValueType
		{
			// Token: 0x06001E3A RID: 7738 RVA: 0x000896C8 File Offset: 0x000878C8
			// Note: this type is marked as 'beforefieldinit'.
			static _DeleteFileAsync_d__16()
			{
				Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<DeleteFileAsync>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr);
				SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr, "<>1__state");
				SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr, "<>t__builder");
				SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr_fileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr, "fileId");
				SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr, "<>u__1");
				SteamUGC._DeleteFileAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr, 100665981);
				SteamUGC._DeleteFileAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr, 100665982);
			}

			// Token: 0x06001E3B RID: 7739 RVA: 0x0008976C File Offset: 0x0008796C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943261, XrefRangeEnd = 943283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._DeleteFileAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E3C RID: 7740 RVA: 0x000897A4 File Offset: 0x000879A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943283, XrefRangeEnd = 943289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._DeleteFileAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E3D RID: 7741 RVA: 0x0000AD1B File Offset: 0x00008F1B
			public _DeleteFileAsync_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E3E RID: 7742 RVA: 0x0000AD24 File Offset: 0x00008F24
			public _DeleteFileAsync_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC._DeleteFileAsync_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x06001E3F RID: 7743 RVA: 0x000897EC File Offset: 0x000879EC
			// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0000AD36 File Offset: 0x00008F36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06001E41 RID: 7745 RVA: 0x00089814 File Offset: 0x00087A14
			// (set) Token: 0x06001E42 RID: 7746 RVA: 0x0000AD51 File Offset: 0x00008F51
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x06001E43 RID: 7747 RVA: 0x00089844 File Offset: 0x00087A44
			// (set) Token: 0x06001E44 RID: 7748 RVA: 0x0000AD7F File Offset: 0x00008F7F
			public unsafe PublishedFileId fileId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr_fileId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr_fileId)) = value;
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0008986C File Offset: 0x00087A6C
			// (set) Token: 0x06001E46 RID: 7750 RVA: 0x0000AD9A File Offset: 0x00008F9A
			public CallResult<DeleteItemResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___u__1);
					return new CallResult<DeleteItemResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<DeleteItemResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DeleteFileAsync_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<DeleteItemResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400219D RID: 8605
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400219E RID: 8606
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400219F RID: 8607
			private static readonly IntPtr NativeFieldInfoPtr_fileId;

			// Token: 0x040021A0 RID: 8608
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021A1 RID: 8609
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021A2 RID: 8610
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000259 RID: 601
		[ObfuscatedName("Steamworks.SteamUGC+<DownloadAsync>d__18")]
		public sealed class _DownloadAsync_d__18 : ValueType
		{
			// Token: 0x06001E47 RID: 7751 RVA: 0x0008989C File Offset: 0x00087A9C
			// Note: this type is marked as 'beforefieldinit'.
			static _DownloadAsync_d__18()
			{
				Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<DownloadAsync>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr);
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "<>1__state");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "<>t__builder");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_fileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "fileId");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_ct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "ct");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "progress");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_milisecondsUpdateDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "milisecondsUpdateDelay");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "<>8__1");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr__item_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "<item>5__2");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr__onDownloadStarted_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "<onDownloadStarted>5__3");
				SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, "<>u__1");
				SteamUGC._DownloadAsync_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, 100665983);
				SteamUGC._DownloadAsync_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr, 100665984);
			}

			// Token: 0x06001E48 RID: 7752 RVA: 0x000899B8 File Offset: 0x00087BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943289, XrefRangeEnd = 943392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._DownloadAsync_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E49 RID: 7753 RVA: 0x000899F0 File Offset: 0x00087BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943392, XrefRangeEnd = 943398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._DownloadAsync_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E4A RID: 7754 RVA: 0x0000ADC8 File Offset: 0x00008FC8
			public _DownloadAsync_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E4B RID: 7755 RVA: 0x0000ADD1 File Offset: 0x00008FD1
			public _DownloadAsync_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC._DownloadAsync_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00089A38 File Offset: 0x00087C38
			// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0000ADE3 File Offset: 0x00008FE3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00089A60 File Offset: 0x00087C60
			// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0000ADFE File Offset: 0x00008FFE
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00089A90 File Offset: 0x00087C90
			// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0000AE2C File Offset: 0x0000902C
			public unsafe PublishedFileId fileId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_fileId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_fileId)) = value;
				}
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00089AB8 File Offset: 0x00087CB8
			// (set) Token: 0x06001E53 RID: 7763 RVA: 0x0000AE47 File Offset: 0x00009047
			public CancellationToken ct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_ct);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_ct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00089AE8 File Offset: 0x00087CE8
			// (set) Token: 0x06001E55 RID: 7765 RVA: 0x0000AE75 File Offset: 0x00009075
			public unsafe Action<float> progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_progress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00089B18 File Offset: 0x00087D18
			// (set) Token: 0x06001E57 RID: 7767 RVA: 0x0000AE94 File Offset: 0x00009094
			public unsafe int milisecondsUpdateDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_milisecondsUpdateDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr_milisecondsUpdateDelay)) = value;
				}
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00089B40 File Offset: 0x00087D40
			// (set) Token: 0x06001E59 RID: 7769 RVA: 0x0000AEAF File Offset: 0x000090AF
			public unsafe SteamUGC.__c__DisplayClass18_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamUGC.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00089B70 File Offset: 0x00087D70
			// (set) Token: 0x06001E5B RID: 7771 RVA: 0x0000AECE File Offset: 0x000090CE
			public Item _item_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr__item_5__2);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr__item_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00089BA0 File Offset: 0x00087DA0
			// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0000AEFC File Offset: 0x000090FC
			public unsafe Action<Result> _onDownloadStarted_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr__onDownloadStarted_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr__onDownloadStarted_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00089BD0 File Offset: 0x00087DD0
			// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0000AF1B File Offset: 0x0000911B
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._DownloadAsync_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021A3 RID: 8611
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021A4 RID: 8612
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021A5 RID: 8613
			private static readonly IntPtr NativeFieldInfoPtr_fileId;

			// Token: 0x040021A6 RID: 8614
			private static readonly IntPtr NativeFieldInfoPtr_ct;

			// Token: 0x040021A7 RID: 8615
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x040021A8 RID: 8616
			private static readonly IntPtr NativeFieldInfoPtr_milisecondsUpdateDelay;

			// Token: 0x040021A9 RID: 8617
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040021AA RID: 8618
			private static readonly IntPtr NativeFieldInfoPtr__item_5__2;

			// Token: 0x040021AB RID: 8619
			private static readonly IntPtr NativeFieldInfoPtr__onDownloadStarted_5__3;

			// Token: 0x040021AC RID: 8620
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021AD RID: 8621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021AE RID: 8622
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200025A RID: 602
		[ObfuscatedName("Steamworks.SteamUGC+<GetWorkshopEulaStatus>d__26")]
		public sealed class _GetWorkshopEulaStatus_d__26 : ValueType
		{
			// Token: 0x06001E60 RID: 7776 RVA: 0x00089C00 File Offset: 0x00087E00
			// Note: this type is marked as 'beforefieldinit'.
			static _GetWorkshopEulaStatus_d__26()
			{
				Il2CppClassPointerStore<SteamUGC._GetWorkshopEulaStatus_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<GetWorkshopEulaStatus>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC._GetWorkshopEulaStatus_d__26>.NativeClassPtr);
				SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._GetWorkshopEulaStatus_d__26>.NativeClassPtr, "<>1__state");
				SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._GetWorkshopEulaStatus_d__26>.NativeClassPtr, "<>t__builder");
				SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._GetWorkshopEulaStatus_d__26>.NativeClassPtr, "<>u__1");
				SteamUGC._GetWorkshopEulaStatus_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._GetWorkshopEulaStatus_d__26>.NativeClassPtr, 100665985);
				SteamUGC._GetWorkshopEulaStatus_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._GetWorkshopEulaStatus_d__26>.NativeClassPtr, 100665986);
			}

			// Token: 0x06001E61 RID: 7777 RVA: 0x00089C90 File Offset: 0x00087E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943398, XrefRangeEnd = 943422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._GetWorkshopEulaStatus_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E62 RID: 7778 RVA: 0x00089CC8 File Offset: 0x00087EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943422, XrefRangeEnd = 943428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._GetWorkshopEulaStatus_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E63 RID: 7779 RVA: 0x0000AF49 File Offset: 0x00009149
			public _GetWorkshopEulaStatus_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E64 RID: 7780 RVA: 0x0000AF52 File Offset: 0x00009152
			public _GetWorkshopEulaStatus_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC._GetWorkshopEulaStatus_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00089D10 File Offset: 0x00087F10
			// (set) Token: 0x06001E66 RID: 7782 RVA: 0x0000AF64 File Offset: 0x00009164
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00089D38 File Offset: 0x00087F38
			// (set) Token: 0x06001E68 RID: 7784 RVA: 0x0000AF7F File Offset: 0x0000917F
			public AsyncTaskMethodBuilder<Nullable<bool>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<bool>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<bool>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<bool>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00089D68 File Offset: 0x00087F68
			// (set) Token: 0x06001E6A RID: 7786 RVA: 0x0000AFAD File Offset: 0x000091AD
			public CallResult<WorkshopEULAStatus_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___u__1);
					return new CallResult<WorkshopEULAStatus_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<WorkshopEULAStatus_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._GetWorkshopEulaStatus_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<WorkshopEULAStatus_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021AF RID: 8623
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021B0 RID: 8624
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021B1 RID: 8625
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021B2 RID: 8626
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021B3 RID: 8627
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200025B RID: 603
		[ObfuscatedName("Steamworks.SteamUGC+<QueryFileAsync>d__19")]
		public sealed class _QueryFileAsync_d__19 : ValueType
		{
			// Token: 0x06001E6B RID: 7787 RVA: 0x00089D98 File Offset: 0x00087F98
			// Note: this type is marked as 'beforefieldinit'.
			static _QueryFileAsync_d__19()
			{
				Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<QueryFileAsync>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr);
				SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr, "<>1__state");
				SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr, "<>t__builder");
				SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr_fileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr, "fileId");
				SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr, "<>u__1");
				SteamUGC._QueryFileAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr, 100665987);
				SteamUGC._QueryFileAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr, 100665988);
			}

			// Token: 0x06001E6C RID: 7788 RVA: 0x00089E3C File Offset: 0x0008803C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943428, XrefRangeEnd = 943470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._QueryFileAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E6D RID: 7789 RVA: 0x00089E74 File Offset: 0x00088074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943470, XrefRangeEnd = 943476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._QueryFileAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E6E RID: 7790 RVA: 0x0000AFDB File Offset: 0x000091DB
			public _QueryFileAsync_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E6F RID: 7791 RVA: 0x0000AFE4 File Offset: 0x000091E4
			public _QueryFileAsync_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC._QueryFileAsync_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x06001E70 RID: 7792 RVA: 0x00089EBC File Offset: 0x000880BC
			// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0000AFF6 File Offset: 0x000091F6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00089EE4 File Offset: 0x000880E4
			// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0000B011 File Offset: 0x00009211
			public AsyncTaskMethodBuilder<Nullable<Item>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Item>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Item>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Item>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00089F14 File Offset: 0x00088114
			// (set) Token: 0x06001E75 RID: 7797 RVA: 0x0000B03F File Offset: 0x0000923F
			public unsafe PublishedFileId fileId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr_fileId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr_fileId)) = value;
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00089F3C File Offset: 0x0008813C
			// (set) Token: 0x06001E77 RID: 7799 RVA: 0x0000B05A File Offset: 0x0000925A
			public TaskAwaiter<Nullable<ResultPage>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<ResultPage>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<ResultPage>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._QueryFileAsync_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<ResultPage>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021B4 RID: 8628
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021B5 RID: 8629
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021B6 RID: 8630
			private static readonly IntPtr NativeFieldInfoPtr_fileId;

			// Token: 0x040021B7 RID: 8631
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021B8 RID: 8632
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021B9 RID: 8633
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200025C RID: 604
		[ObfuscatedName("Steamworks.SteamUGC+<StartPlaytimeTracking>d__20")]
		public sealed class _StartPlaytimeTracking_d__20 : ValueType
		{
			// Token: 0x06001E78 RID: 7800 RVA: 0x00089F6C File Offset: 0x0008816C
			// Note: this type is marked as 'beforefieldinit'.
			static _StartPlaytimeTracking_d__20()
			{
				Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<StartPlaytimeTracking>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr);
				SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr, "<>1__state");
				SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr, "<>t__builder");
				SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr_fileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr, "fileId");
				SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr, "<>u__1");
				SteamUGC._StartPlaytimeTracking_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr, 100665989);
				SteamUGC._StartPlaytimeTracking_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr, 100665990);
			}

			// Token: 0x06001E79 RID: 7801 RVA: 0x0008A010 File Offset: 0x00088210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943476, XrefRangeEnd = 943501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._StartPlaytimeTracking_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E7A RID: 7802 RVA: 0x0008A048 File Offset: 0x00088248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943501, XrefRangeEnd = 943507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._StartPlaytimeTracking_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E7B RID: 7803 RVA: 0x0000B088 File Offset: 0x00009288
			public _StartPlaytimeTracking_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E7C RID: 7804 RVA: 0x0000B091 File Offset: 0x00009291
			public _StartPlaytimeTracking_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC._StartPlaytimeTracking_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x06001E7D RID: 7805 RVA: 0x0008A090 File Offset: 0x00088290
			// (set) Token: 0x06001E7E RID: 7806 RVA: 0x0000B0A3 File Offset: 0x000092A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0008A0B8 File Offset: 0x000882B8
			// (set) Token: 0x06001E80 RID: 7808 RVA: 0x0000B0BE File Offset: 0x000092BE
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x06001E81 RID: 7809 RVA: 0x0008A0E8 File Offset: 0x000882E8
			// (set) Token: 0x06001E82 RID: 7810 RVA: 0x0000B0EC File Offset: 0x000092EC
			public unsafe PublishedFileId fileId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr_fileId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr_fileId)) = value;
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x06001E83 RID: 7811 RVA: 0x0008A110 File Offset: 0x00088310
			// (set) Token: 0x06001E84 RID: 7812 RVA: 0x0000B107 File Offset: 0x00009307
			public CallResult<StartPlaytimeTrackingResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___u__1);
					return new CallResult<StartPlaytimeTrackingResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<StartPlaytimeTrackingResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StartPlaytimeTracking_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<StartPlaytimeTrackingResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021BA RID: 8634
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021BB RID: 8635
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021BC RID: 8636
			private static readonly IntPtr NativeFieldInfoPtr_fileId;

			// Token: 0x040021BD RID: 8637
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021BE RID: 8638
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021BF RID: 8639
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200025D RID: 605
		[ObfuscatedName("Steamworks.SteamUGC+<StopPlaytimeTracking>d__21")]
		public sealed class _StopPlaytimeTracking_d__21 : ValueType
		{
			// Token: 0x06001E85 RID: 7813 RVA: 0x0008A140 File Offset: 0x00088340
			// Note: this type is marked as 'beforefieldinit'.
			static _StopPlaytimeTracking_d__21()
			{
				Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<StopPlaytimeTracking>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr);
				SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr, "<>1__state");
				SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr, "<>t__builder");
				SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr_fileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr, "fileId");
				SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr, "<>u__1");
				SteamUGC._StopPlaytimeTracking_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr, 100665991);
				SteamUGC._StopPlaytimeTracking_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr, 100665992);
			}

			// Token: 0x06001E86 RID: 7814 RVA: 0x0008A1E4 File Offset: 0x000883E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943507, XrefRangeEnd = 943532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._StopPlaytimeTracking_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E87 RID: 7815 RVA: 0x0008A21C File Offset: 0x0008841C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943532, XrefRangeEnd = 943538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._StopPlaytimeTracking_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E88 RID: 7816 RVA: 0x0000B135 File Offset: 0x00009335
			public _StopPlaytimeTracking_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E89 RID: 7817 RVA: 0x0000B13E File Offset: 0x0000933E
			public _StopPlaytimeTracking_d__21()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTracking_d__21>.NativeClassPtr))
			{
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0008A264 File Offset: 0x00088464
			// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0000B150 File Offset: 0x00009350
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0008A28C File Offset: 0x0008848C
			// (set) Token: 0x06001E8D RID: 7821 RVA: 0x0000B16B File Offset: 0x0000936B
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x06001E8E RID: 7822 RVA: 0x0008A2BC File Offset: 0x000884BC
			// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0000B199 File Offset: 0x00009399
			public unsafe PublishedFileId fileId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr_fileId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr_fileId)) = value;
				}
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x06001E90 RID: 7824 RVA: 0x0008A2E4 File Offset: 0x000884E4
			// (set) Token: 0x06001E91 RID: 7825 RVA: 0x0000B1B4 File Offset: 0x000093B4
			public CallResult<StopPlaytimeTrackingResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___u__1);
					return new CallResult<StopPlaytimeTrackingResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<StopPlaytimeTrackingResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTracking_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<StopPlaytimeTrackingResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021C0 RID: 8640
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021C1 RID: 8641
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021C2 RID: 8642
			private static readonly IntPtr NativeFieldInfoPtr_fileId;

			// Token: 0x040021C3 RID: 8643
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021C4 RID: 8644
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021C5 RID: 8645
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200025E RID: 606
		[ObfuscatedName("Steamworks.SteamUGC+<StopPlaytimeTrackingForAllItems>d__22")]
		public sealed class _StopPlaytimeTrackingForAllItems_d__22 : ValueType
		{
			// Token: 0x06001E92 RID: 7826 RVA: 0x0008A314 File Offset: 0x00088514
			// Note: this type is marked as 'beforefieldinit'.
			static _StopPlaytimeTrackingForAllItems_d__22()
			{
				Il2CppClassPointerStore<SteamUGC._StopPlaytimeTrackingForAllItems_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, "<StopPlaytimeTrackingForAllItems>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTrackingForAllItems_d__22>.NativeClassPtr);
				SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTrackingForAllItems_d__22>.NativeClassPtr, "<>1__state");
				SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTrackingForAllItems_d__22>.NativeClassPtr, "<>t__builder");
				SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTrackingForAllItems_d__22>.NativeClassPtr, "<>u__1");
				SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTrackingForAllItems_d__22>.NativeClassPtr, 100665993);
				SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTrackingForAllItems_d__22>.NativeClassPtr, 100665994);
			}

			// Token: 0x06001E93 RID: 7827 RVA: 0x0008A3A4 File Offset: 0x000885A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943538, XrefRangeEnd = 943560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E94 RID: 7828 RVA: 0x0008A3DC File Offset: 0x000885DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943560, XrefRangeEnd = 943566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E95 RID: 7829 RVA: 0x0000B1E2 File Offset: 0x000093E2
			public _StopPlaytimeTrackingForAllItems_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E96 RID: 7830 RVA: 0x0000B1EB File Offset: 0x000093EB
			public _StopPlaytimeTrackingForAllItems_d__22()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGC._StopPlaytimeTrackingForAllItems_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x06001E97 RID: 7831 RVA: 0x0008A424 File Offset: 0x00088624
			// (set) Token: 0x06001E98 RID: 7832 RVA: 0x0000B1FD File Offset: 0x000093FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x06001E99 RID: 7833 RVA: 0x0008A44C File Offset: 0x0008864C
			// (set) Token: 0x06001E9A RID: 7834 RVA: 0x0000B218 File Offset: 0x00009418
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x06001E9B RID: 7835 RVA: 0x0008A47C File Offset: 0x0008867C
			// (set) Token: 0x06001E9C RID: 7836 RVA: 0x0000B246 File Offset: 0x00009446
			public CallResult<StopPlaytimeTrackingResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___u__1);
					return new CallResult<StopPlaytimeTrackingResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<StopPlaytimeTrackingResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGC._StopPlaytimeTrackingForAllItems_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<StopPlaytimeTrackingResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021C6 RID: 8646
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021C7 RID: 8647
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021C8 RID: 8648
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021C9 RID: 8649
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021CA RID: 8650
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
