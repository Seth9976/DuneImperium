using System;
using Canis.utils.ids;
using dbgclient.data;
using dwd.core.data;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.prompts
{
	// Token: 0x02000094 RID: 148
	public class FriendGameInvitePrompt : ResolvablePrompt<FriendGameInviteData>
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x00030098 File Offset: 0x0002E298
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameInvitePrompt()
		{
			Il2CppClassPointerStore<FriendGameInvitePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts", "FriendGameInvitePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInvitePrompt>.NativeClassPtr);
			FriendGameInvitePrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			FriendGameInvitePrompt.NativeFieldInfoPtr__FriendsToLeaveOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePrompt>.NativeClassPtr, "<FriendsToLeaveOut>k__BackingField");
			FriendGameInvitePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePrompt>.NativeClassPtr, 100664200);
			FriendGameInvitePrompt.NativeMethodInfoPtr_get_FriendsToLeaveOut_Public_get_List_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePrompt>.NativeClassPtr, 100664201);
			FriendGameInvitePrompt.NativeMethodInfoPtr__ctor_Public_Void_ScrollPositionData_List_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePrompt>.NativeClassPtr, 100664202);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0003012C File Offset: 0x0002E32C
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0003016C File Offset: 0x0002E36C
		public unsafe List<AccountID> FriendsToLeaveOut
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePrompt.NativeMethodInfoPtr_get_FriendsToLeaveOut_Public_get_List_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr3) : null;
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000301AC File Offset: 0x0002E3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502424, XrefRangeEnd = 502449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendGameInvitePrompt(ScrollPositionData scrollData, List<AccountID> friendsToLeaveOut)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameInvitePrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scrollData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(friendsToLeaveOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePrompt.NativeMethodInfoPtr__ctor_Public_Void_ScrollPositionData_List_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00004959 File Offset: 0x00002B59
		public FriendGameInvitePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0003020C File Offset: 0x0002E40C
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00004962 File Offset: 0x00002B62
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0003023C File Offset: 0x0002E43C
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00004981 File Offset: 0x00002B81
		public unsafe List<AccountID> _FriendsToLeaveOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePrompt.NativeFieldInfoPtr__FriendsToLeaveOut_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePrompt.NativeFieldInfoPtr__FriendsToLeaveOut_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr__FriendsToLeaveOut_k__BackingField;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_get_FriendsToLeaveOut_Public_get_List_1_AccountID_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScrollPositionData_List_1_AccountID_0;
	}
}
