using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.src.challenges.definitions
{
	// Token: 0x02000089 RID: 137
	public class WinCampaignGame : BaseChallengeDefinition
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x0002628C File Offset: 0x0002448C
		// Note: this type is marked as 'beforefieldinit'.
		static WinCampaignGame()
		{
			Il2CppClassPointerStore<WinCampaignGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges.definitions", "WinCampaignGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WinCampaignGame>.NativeClassPtr);
			WinCampaignGame.NativeFieldInfoPtr_Scenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinCampaignGame>.NativeClassPtr, "Scenario");
			WinCampaignGame.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinCampaignGame>.NativeClassPtr, 100664401);
			WinCampaignGame.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinCampaignGame>.NativeClassPtr, 100664402);
			WinCampaignGame.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinCampaignGame>.NativeClassPtr, 100664403);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0002630C File Offset: 0x0002450C
		[CallerCount(75)]
		[CachedScanResults(RefRangeStart = 989286, RefRangeEnd = 989361, XrefRangeStart = 989284, XrefRangeEnd = 989286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WinCampaignGame(int id, string locKey, string icon, int amount, string scenario)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WinCampaignGame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(icon);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scenario);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinCampaignGame.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00026398 File Offset: 0x00024598
		public unsafe override string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinCampaignGame.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000263DC File Offset: 0x000245DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989361, XrefRangeEnd = 989365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int scoreEvent(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinCampaignGame.NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000050AE File Offset: 0x000032AE
		public WinCampaignGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00026434 File Offset: 0x00024634
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x000050B7 File Offset: 0x000032B7
		public unsafe string Scenario
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinCampaignGame.NativeFieldInfoPtr_Scenario);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinCampaignGame.NativeFieldInfoPtr_Scenario), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_Scenario;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_String_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_scoreEvent_Protected_Virtual_Int32_Event_0;
	}
}
