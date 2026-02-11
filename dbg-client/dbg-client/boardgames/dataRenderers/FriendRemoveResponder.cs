using System;
using boardgames.prompts.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.datarenderers
{
	// Token: 0x02000173 RID: 371
	public class FriendRemoveResponder : Subscriber
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x000516D0 File Offset: 0x0004F8D0
		// Note: this type is marked as 'beforefieldinit'.
		static FriendRemoveResponder()
		{
			Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "FriendRemoveResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr);
			FriendRemoveResponder.NativeFieldInfoPtr_removeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr, "removeButton");
			FriendRemoveResponder.NativeFieldInfoPtr_friendsListPromptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr, "friendsListPromptBehaviour");
			FriendRemoveResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr, 100665599);
			FriendRemoveResponder.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr, 100665600);
			FriendRemoveResponder.NativeMethodInfoPtr_Event_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr, 100665601);
			FriendRemoveResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr, 100665602);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00051778 File Offset: 0x0004F978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514023, XrefRangeEnd = 514032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendRemoveResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x000517B4 File Offset: 0x0004F9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514032, XrefRangeEnd = 514041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendRemoveResponder.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000517F0 File Offset: 0x0004F9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514041, XrefRangeEnd = 514043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendRemoveResponder.NativeMethodInfoPtr_Event_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00051824 File Offset: 0x0004FA24
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendRemoveResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendRemoveResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendRemoveResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00009F8F File Offset: 0x0000818F
		public FriendRemoveResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00051860 File Offset: 0x0004FA60
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x00009F98 File Offset: 0x00008198
		public unsafe GameObject removeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendRemoveResponder.NativeFieldInfoPtr_removeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendRemoveResponder.NativeFieldInfoPtr_removeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00051890 File Offset: 0x0004FA90
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x00009FB7 File Offset: 0x000081B7
		public unsafe FriendsListPromptBehaviour friendsListPromptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendRemoveResponder.NativeFieldInfoPtr_friendsListPromptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendRemoveResponder.NativeFieldInfoPtr_friendsListPromptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr_removeButton;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr_friendsListPromptBehaviour;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_Event_Remove_Public_Void_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
