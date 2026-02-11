using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace offlineChallenges
{
	// Token: 0x02000006 RID: 6
	public class ChallengeDefinition : Object
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002B68 File Offset: 0x00000D68
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeDefinition()
		{
			Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges", "ChallengeDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr);
			ChallengeDefinition.NativeFieldInfoPtr__Required_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, "<Required>k__BackingField");
			ChallengeDefinition.NativeFieldInfoPtr__TurnProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, "<TurnProgress>k__BackingField");
			ChallengeDefinition.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, "model");
			ChallengeDefinition.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, "tags");
			ChallengeDefinition.NativeFieldInfoPtr_GooglePlayHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, "GooglePlayHeader");
			ChallengeDefinition.NativeFieldInfoPtr_XboxHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, "XboxHeader");
			ChallengeDefinition.NativeMethodInfoPtr_get_ChallengeID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663303);
			ChallengeDefinition.NativeMethodInfoPtr_set_ChallengeID_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663304);
			ChallengeDefinition.NativeMethodInfoPtr_get_Required_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663305);
			ChallengeDefinition.NativeMethodInfoPtr_set_Required_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663306);
			ChallengeDefinition.NativeMethodInfoPtr_get_TurnProgress_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663307);
			ChallengeDefinition.NativeMethodInfoPtr_set_TurnProgress_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663308);
			ChallengeDefinition.NativeMethodInfoPtr_get_Progress_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663309);
			ChallengeDefinition.NativeMethodInfoPtr_set_Progress_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663310);
			ChallengeDefinition.NativeMethodInfoPtr_get_LastCheckedProgress_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663311);
			ChallengeDefinition.NativeMethodInfoPtr_set_LastCheckedProgress_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663312);
			ChallengeDefinition.NativeMethodInfoPtr_get_LastSyncedProgress_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663313);
			ChallengeDefinition.NativeMethodInfoPtr_set_LastSyncedProgress_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663314);
			ChallengeDefinition.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663315);
			ChallengeDefinition.NativeMethodInfoPtr_get_Icon_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663316);
			ChallengeDefinition.NativeMethodInfoPtr__ctor_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663317);
			ChallengeDefinition.NativeMethodInfoPtr_MarkProgressAsChecked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663318);
			ChallengeDefinition.NativeMethodInfoPtr_MarkProgressAsSynced_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663319);
			ChallengeDefinition.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663320);
			ChallengeDefinition.NativeMethodInfoPtr_Revert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663321);
			ChallengeDefinition.NativeMethodInfoPtr_scoreEvent_Protected_Abstract_Virtual_New_Int32_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663322);
			ChallengeDefinition.NativeMethodInfoPtr_Process_Public_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663323);
			ChallengeDefinition.NativeMethodInfoPtr_get_Completed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663324);
			ChallengeDefinition.NativeMethodInfoPtr_get_LastCheckedProgressCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663325);
			ChallengeDefinition.NativeMethodInfoPtr_get_HasBeenChecked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663326);
			ChallengeDefinition.NativeMethodInfoPtr_TaggedAs_Public_ChallengeDefinition_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663327);
			ChallengeDefinition.NativeMethodInfoPtr_GetModel_Public_ChallengeModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663328);
			ChallengeDefinition.NativeMethodInfoPtr_HasTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663329);
			ChallengeDefinition.NativeMethodInfoPtr_GetGooglePlayID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663330);
			ChallengeDefinition.NativeMethodInfoPtr_GetXboxID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663331);
			ChallengeDefinition.NativeMethodInfoPtr_LoadProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663332);
			ChallengeDefinition.NativeMethodInfoPtr_Load_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663333);
			ChallengeDefinition.NativeMethodInfoPtr_Load_Public_Void_ChallengeModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663334);
			ChallengeDefinition.NativeMethodInfoPtr_AugmentModelOnLoad_Protected_Virtual_New_ChallengeModel_ChallengeModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663335);
			ChallengeDefinition.NativeMethodInfoPtr_CombineProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663336);
			ChallengeDefinition.NativeMethodInfoPtr_MergedProgress_Protected_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663337);
			ChallengeDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr, 100663338);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002EE0 File Offset: 0x000010E0
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002F1C File Offset: 0x0000111C
		public unsafe int ChallengeID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1219050, RefRangeEnd = 1219054, XrefRangeStart = 1219050, XrefRangeEnd = 1219054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_ChallengeID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_set_ChallengeID_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002F5C File Offset: 0x0000115C
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002F98 File Offset: 0x00001198
		public unsafe int Required
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_Required_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_set_Required_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002FD8 File Offset: 0x000011D8
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00003014 File Offset: 0x00001214
		public unsafe int TurnProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_TurnProgress_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_set_TurnProgress_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003054 File Offset: 0x00001254
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003090 File Offset: 0x00001290
		public unsafe int Progress
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 428765, RefRangeEnd = 428767, XrefRangeStart = 428765, XrefRangeEnd = 428767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_Progress_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_set_Progress_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000030D0 File Offset: 0x000012D0
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000310C File Offset: 0x0000130C
		public unsafe int LastCheckedProgress
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 428718, RefRangeEnd = 428731, XrefRangeStart = 428718, XrefRangeEnd = 428731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_LastCheckedProgress_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_set_LastCheckedProgress_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000314C File Offset: 0x0000134C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003188 File Offset: 0x00001388
		public unsafe int LastSyncedProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_LastSyncedProgress_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_set_LastSyncedProgress_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000031C8 File Offset: 0x000013C8
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeDefinition.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000320C File Offset: 0x0000140C
		public unsafe virtual string Icon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeDefinition.NativeMethodInfoPtr_get_Icon_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003250 File Offset: 0x00001450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260151, RefRangeEnd = 1260152, XrefRangeStart = 1260138, XrefRangeEnd = 1260151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeDefinition(int id, int amount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr__ctor_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000032A8 File Offset: 0x000014A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1260152, RefRangeEnd = 1260156, XrefRangeStart = 1260152, XrefRangeEnd = 1260152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkProgressAsChecked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_MarkProgressAsChecked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000032DC File Offset: 0x000014DC
		[CallerCount(0)]
		public unsafe void MarkProgressAsSynced()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_MarkProgressAsSynced_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003310 File Offset: 0x00001510
		[CallerCount(0)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003344 File Offset: 0x00001544
		[CallerCount(0)]
		public unsafe void Revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_Revert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003378 File Offset: 0x00001578
		[CallerCount(0)]
		public unsafe virtual int scoreEvent(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeDefinition.NativeMethodInfoPtr_scoreEvent_Protected_Abstract_Virtual_New_Int32_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000033D0 File Offset: 0x000015D0
		[CallerCount(0)]
		public unsafe void Process(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_Process_Public_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003414 File Offset: 0x00001614
		public unsafe bool Completed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1260156, RefRangeEnd = 1260157, XrefRangeStart = 1260156, XrefRangeEnd = 1260156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_Completed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003450 File Offset: 0x00001650
		public unsafe bool LastCheckedProgressCompleted
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1260157, RefRangeEnd = 1260160, XrefRangeStart = 1260157, XrefRangeEnd = 1260157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_LastCheckedProgressCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000348C File Offset: 0x0000168C
		public unsafe bool HasBeenChecked
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1260160, RefRangeEnd = 1260161, XrefRangeStart = 1260160, XrefRangeEnd = 1260160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_get_HasBeenChecked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000034C8 File Offset: 0x000016C8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1260167, RefRangeEnd = 1260210, XrefRangeStart = 1260161, XrefRangeEnd = 1260167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeDefinition TaggedAs([Optional] Il2CppStringArray tags)
		{
			if (tags == null)
			{
				tags = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tags);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_TaggedAs_Public_ChallengeDefinition_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChallengeDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003528 File Offset: 0x00001728
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeModel GetModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_GetModel_Public_ChallengeModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChallengeModel>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003568 File Offset: 0x00001768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1260214, RefRangeEnd = 1260217, XrefRangeStart = 1260210, XrefRangeEnd = 1260214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_HasTag_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000035B8 File Offset: 0x000017B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260217, XrefRangeEnd = 1260233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGooglePlayID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_GetGooglePlayID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000035F0 File Offset: 0x000017F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260233, XrefRangeEnd = 1260249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetXboxID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_GetXboxID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003628 File Offset: 0x00001828
		[CallerCount(0)]
		public unsafe void LoadProgress(int progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref progress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_LoadProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003668 File Offset: 0x00001868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1260249, RefRangeEnd = 1260251, XrefRangeStart = 1260249, XrefRangeEnd = 1260249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(int progress, int lastChecked, int lastSynced)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref progress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastChecked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastSynced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_Load_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000036C4 File Offset: 0x000018C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260251, XrefRangeEnd = 1260252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ChallengeModel model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_Load_Public_Void_ChallengeModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003708 File Offset: 0x00001908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ChallengeModel AugmentModelOnLoad(ChallengeModel model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeDefinition.NativeMethodInfoPtr_AugmentModelOnLoad_Protected_Virtual_New_ChallengeModel_ChallengeModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChallengeModel>(intPtr3) : null;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003764 File Offset: 0x00001964
		[CallerCount(0)]
		public unsafe void CombineProgress(int delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDefinition.NativeMethodInfoPtr_CombineProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000037A4 File Offset: 0x000019A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260252, XrefRangeEnd = 1260258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int MergedProgress(int otherProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref otherProgress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeDefinition.NativeMethodInfoPtr_MergedProgress_Protected_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000037F8 File Offset: 0x000019F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260258, XrefRangeEnd = 1260286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020E7 File Offset: 0x000002E7
		public ChallengeDefinition TaggedAs(params string[] tags)
		{
			return this.TaggedAs(new Il2CppStringArray(tags));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000020F5 File Offset: 0x000002F5
		public ChallengeDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000383C File Offset: 0x00001A3C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000020FE File Offset: 0x000002FE
		public unsafe int _Required_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDefinition.NativeFieldInfoPtr__Required_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDefinition.NativeFieldInfoPtr__Required_k__BackingField)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003864 File Offset: 0x00001A64
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002119 File Offset: 0x00000319
		public unsafe int _TurnProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDefinition.NativeFieldInfoPtr__TurnProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDefinition.NativeFieldInfoPtr__TurnProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000388C File Offset: 0x00001A8C
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002134 File Offset: 0x00000334
		public unsafe ChallengeModel model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDefinition.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDefinition.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000038BC File Offset: 0x00001ABC
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002153 File Offset: 0x00000353
		public unsafe List<string> tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDefinition.NativeFieldInfoPtr_tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDefinition.NativeFieldInfoPtr_tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000038EC File Offset: 0x00001AEC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002172 File Offset: 0x00000372
		public unsafe static string GooglePlayHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeDefinition.NativeFieldInfoPtr_GooglePlayHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeDefinition.NativeFieldInfoPtr_GooglePlayHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000390C File Offset: 0x00001B0C
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002184 File Offset: 0x00000384
		public unsafe static string XboxHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeDefinition.NativeFieldInfoPtr_XboxHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeDefinition.NativeFieldInfoPtr_XboxHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr__Required_k__BackingField;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr__TurnProgress_k__BackingField;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_GooglePlayHeader;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_XboxHeader;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_ChallengeID_Public_get_Int32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_set_ChallengeID_Private_set_Void_Int32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_Required_Public_get_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_set_Required_Private_set_Void_Int32_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_TurnProgress_Private_get_Int32_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_TurnProgress_Private_set_Void_Int32_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Public_get_Int32_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_Progress_Private_set_Void_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_LastCheckedProgress_Public_get_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_set_LastCheckedProgress_Private_set_Void_Int32_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_LastSyncedProgress_Public_get_Int32_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_LastSyncedProgress_Private_set_Void_Int32_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_Int32_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_MarkProgressAsChecked_Public_Void_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_MarkProgressAsSynced_Public_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Void_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_scoreEvent_Protected_Abstract_Virtual_New_Int32_Event_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Void_Event_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_get_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_LastCheckedProgressCompleted_Public_get_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBeenChecked_Public_get_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_TaggedAs_Public_ChallengeDefinition_Il2CppStringArray_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_GetModel_Public_ChallengeModel_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_HasTag_Public_Boolean_String_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_GetGooglePlayID_Public_String_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_GetXboxID_Public_String_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_LoadProgress_Public_Void_Int32_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ChallengeModel_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_AugmentModelOnLoad_Protected_Virtual_New_ChallengeModel_ChallengeModel_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_CombineProgress_Public_Void_Int32_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_MergedProgress_Protected_Virtual_New_Int32_Int32_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
