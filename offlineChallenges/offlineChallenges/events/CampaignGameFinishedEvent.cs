using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace offlineChallenges.events
{
	// Token: 0x0200000E RID: 14
	public class CampaignGameFinishedEvent : OfflineChallenges.Event
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0000505C File Offset: 0x0000325C
		// Note: this type is marked as 'beforefieldinit'.
		static CampaignGameFinishedEvent()
		{
			Il2CppClassPointerStore<CampaignGameFinishedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.events", "CampaignGameFinishedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGameFinishedEvent>.NativeClassPtr);
			CampaignGameFinishedEvent.NativeFieldInfoPtr_youWon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGameFinishedEvent>.NativeClassPtr, "youWon");
			CampaignGameFinishedEvent.NativeFieldInfoPtr_scenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGameFinishedEvent>.NativeClassPtr, "scenario");
			CampaignGameFinishedEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGameFinishedEvent>.NativeClassPtr, 100663408);
			CampaignGameFinishedEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGameFinishedEvent>.NativeClassPtr, 100663409);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000050DC File Offset: 0x000032DC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1143830, RefRangeEnd = 1143849, XrefRangeStart = 1143830, XrefRangeEnd = 1143849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CampaignGameFinishedEvent(bool youwon, string scenario)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGameFinishedEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref youwon;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scenario);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CampaignGameFinishedEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005138 File Offset: 0x00003338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261170, XrefRangeEnd = 1261176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CampaignGameFinishedEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002495 File Offset: 0x00000695
		public CampaignGameFinishedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000517C File Offset: 0x0000337C
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000249E File Offset: 0x0000069E
		public unsafe bool youWon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CampaignGameFinishedEvent.NativeFieldInfoPtr_youWon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CampaignGameFinishedEvent.NativeFieldInfoPtr_youWon)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000051A4 File Offset: 0x000033A4
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000024B9 File Offset: 0x000006B9
		public unsafe string scenario
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CampaignGameFinishedEvent.NativeFieldInfoPtr_scenario);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CampaignGameFinishedEvent.NativeFieldInfoPtr_scenario), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_youWon;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_scenario;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
