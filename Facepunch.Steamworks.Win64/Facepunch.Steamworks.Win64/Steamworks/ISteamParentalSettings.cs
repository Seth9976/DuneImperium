using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks
{
	// Token: 0x02000026 RID: 38
	public class ISteamParentalSettings : SteamInterface
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x000312B4 File Offset: 0x0002F4B4
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamParentalSettings()
		{
			Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamParentalSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr);
			ISteamParentalSettings.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664646);
			ISteamParentalSettings.NativeMethodInfoPtr_SteamAPI_SteamParentalSettings_v001_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664647);
			ISteamParentalSettings.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664648);
			ISteamParentalSettings.NativeMethodInfoPtr__BIsParentalLockEnabled_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664649);
			ISteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664650);
			ISteamParentalSettings.NativeMethodInfoPtr__BIsParentalLockLocked_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664651);
			ISteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockLocked_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664652);
			ISteamParentalSettings.NativeMethodInfoPtr__BIsAppBlocked_Private_Static_Boolean_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664653);
			ISteamParentalSettings.NativeMethodInfoPtr_BIsAppBlocked_Internal_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664654);
			ISteamParentalSettings.NativeMethodInfoPtr__BIsAppInBlockList_Private_Static_Boolean_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664655);
			ISteamParentalSettings.NativeMethodInfoPtr_BIsAppInBlockList_Internal_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664656);
			ISteamParentalSettings.NativeMethodInfoPtr__BIsFeatureBlocked_Private_Static_Boolean_IntPtr_ParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664657);
			ISteamParentalSettings.NativeMethodInfoPtr_BIsFeatureBlocked_Internal_Boolean_ParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664658);
			ISteamParentalSettings.NativeMethodInfoPtr__BIsFeatureInBlockList_Private_Static_Boolean_IntPtr_ParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664659);
			ISteamParentalSettings.NativeMethodInfoPtr_BIsFeatureInBlockList_Internal_Boolean_ParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr, 100664660);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00031410 File Offset: 0x0002F610
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamParentalSettings(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamParentalSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00031458 File Offset: 0x0002F658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934666, XrefRangeEnd = 934668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamParentalSettings_v001()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr_SteamAPI_SteamParentalSettings_v001_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00031488 File Offset: 0x0002F688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamParentalSettings.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000314D0 File Offset: 0x0002F6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934668, XrefRangeEnd = 934670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsParentalLockEnabled(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr__BIsParentalLockEnabled_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00031510 File Offset: 0x0002F710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934672, RefRangeEnd = 934673, XrefRangeStart = 934670, XrefRangeEnd = 934672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsParentalLockEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockEnabled_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0003154C File Offset: 0x0002F74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934673, XrefRangeEnd = 934675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsParentalLockLocked(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr__BIsParentalLockLocked_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0003158C File Offset: 0x0002F78C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934677, RefRangeEnd = 934678, XrefRangeStart = 934675, XrefRangeEnd = 934677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsParentalLockLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockLocked_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000315C8 File Offset: 0x0002F7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934678, XrefRangeEnd = 934680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsAppBlocked(IntPtr self, AppId nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr__BIsAppBlocked_Private_Static_Boolean_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00031614 File Offset: 0x0002F814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934682, RefRangeEnd = 934683, XrefRangeStart = 934680, XrefRangeEnd = 934682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsAppBlocked(AppId nAppID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr_BIsAppBlocked_Internal_Boolean_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00031660 File Offset: 0x0002F860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934683, XrefRangeEnd = 934685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsAppInBlockList(IntPtr self, AppId nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr__BIsAppInBlockList_Private_Static_Boolean_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000316AC File Offset: 0x0002F8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934687, RefRangeEnd = 934688, XrefRangeStart = 934685, XrefRangeEnd = 934687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsAppInBlockList(AppId nAppID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr_BIsAppInBlockList_Internal_Boolean_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000316F8 File Offset: 0x0002F8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934688, XrefRangeEnd = 934690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsFeatureBlocked(IntPtr self, ParentalFeature eFeature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eFeature;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr__BIsFeatureBlocked_Private_Static_Boolean_IntPtr_ParentalFeature_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00031744 File Offset: 0x0002F944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934692, RefRangeEnd = 934693, XrefRangeStart = 934690, XrefRangeEnd = 934692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsFeatureBlocked(ParentalFeature eFeature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eFeature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr_BIsFeatureBlocked_Internal_Boolean_ParentalFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00031790 File Offset: 0x0002F990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934693, XrefRangeEnd = 934695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsFeatureInBlockList(IntPtr self, ParentalFeature eFeature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eFeature;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr__BIsFeatureInBlockList_Private_Static_Boolean_IntPtr_ParentalFeature_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000317DC File Offset: 0x0002F9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 934697, RefRangeEnd = 934698, XrefRangeStart = 934695, XrefRangeEnd = 934697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsFeatureInBlockList(ParentalFeature eFeature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eFeature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamParentalSettings.NativeMethodInfoPtr_BIsFeatureInBlockList_Internal_Boolean_ParentalFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000023B4 File Offset: 0x000005B4
		public ISteamParentalSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamParentalSettings_v001_Internal_Static_IntPtr_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr__BIsParentalLockEnabled_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_BIsParentalLockEnabled_Internal_Boolean_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr__BIsParentalLockLocked_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_BIsParentalLockLocked_Internal_Boolean_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr__BIsAppBlocked_Private_Static_Boolean_IntPtr_AppId_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppBlocked_Internal_Boolean_AppId_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr__BIsAppInBlockList_Private_Static_Boolean_IntPtr_AppId_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppInBlockList_Internal_Boolean_AppId_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr__BIsFeatureBlocked_Private_Static_Boolean_IntPtr_ParentalFeature_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_BIsFeatureBlocked_Internal_Boolean_ParentalFeature_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr__BIsFeatureInBlockList_Private_Static_Boolean_IntPtr_ParentalFeature_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_BIsFeatureInBlockList_Internal_Boolean_ParentalFeature_0;
	}
}
