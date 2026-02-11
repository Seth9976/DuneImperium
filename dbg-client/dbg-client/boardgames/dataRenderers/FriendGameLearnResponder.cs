using System;
using boardgames.prompts.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.datarenderers
{
	// Token: 0x02000172 RID: 370
	public class FriendGameLearnResponder : Subscriber
	{
		// Token: 0x06001064 RID: 4196 RVA: 0x000514E0 File Offset: 0x0004F6E0
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameLearnResponder()
		{
			Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "FriendGameLearnResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr);
			FriendGameLearnResponder.NativeFieldInfoPtr_learnButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr, "learnButton");
			FriendGameLearnResponder.NativeFieldInfoPtr_friendsListPromptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr, "friendsListPromptBehaviour");
			FriendGameLearnResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr, 100665595);
			FriendGameLearnResponder.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr, 100665596);
			FriendGameLearnResponder.NativeMethodInfoPtr_Event_InviteToLearn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr, 100665597);
			FriendGameLearnResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr, 100665598);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00051588 File Offset: 0x0004F788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514004, XrefRangeEnd = 514013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameLearnResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x000515C4 File Offset: 0x0004F7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514013, XrefRangeEnd = 514021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameLearnResponder.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00051600 File Offset: 0x0004F800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514021, XrefRangeEnd = 514023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_InviteToLearn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameLearnResponder.NativeMethodInfoPtr_Event_InviteToLearn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00051634 File Offset: 0x0004F834
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendGameLearnResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameLearnResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameLearnResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00009F48 File Offset: 0x00008148
		public FriendGameLearnResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00051670 File Offset: 0x0004F870
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x00009F51 File Offset: 0x00008151
		public unsafe GameObject learnButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameLearnResponder.NativeFieldInfoPtr_learnButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameLearnResponder.NativeFieldInfoPtr_learnButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x000516A0 File Offset: 0x0004F8A0
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x00009F70 File Offset: 0x00008170
		public unsafe FriendsListPromptBehaviour friendsListPromptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameLearnResponder.NativeFieldInfoPtr_friendsListPromptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameLearnResponder.NativeFieldInfoPtr_friendsListPromptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeFieldInfoPtr_learnButton;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeFieldInfoPtr_friendsListPromptBehaviour;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_Event_InviteToLearn_Public_Void_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
