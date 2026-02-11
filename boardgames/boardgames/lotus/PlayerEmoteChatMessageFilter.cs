using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000B6 RID: 182
	public class PlayerEmoteChatMessageFilter : MonoBehaviour
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x0002DF54 File Offset: 0x0002C154
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEmoteChatMessageFilter()
		{
			Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "PlayerEmoteChatMessageFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr);
			PlayerEmoteChatMessageFilter.NativeFieldInfoPtr_playerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, "playerView");
			PlayerEmoteChatMessageFilter.NativeFieldInfoPtr_muted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, "muted");
			PlayerEmoteChatMessageFilter.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, "<Version>k__BackingField");
			PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, 100664731);
			PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_IsValidMessage_Public_Virtual_Final_New_Boolean_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, 100664732);
			PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_Event_Mute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, 100664733);
			PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_Event_Unmute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, 100664734);
			PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_Event_ToggleMute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, 100664735);
			PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, 100664736);
			PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, 100664737);
			PlayerEmoteChatMessageFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr, 100664738);
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002E060 File Offset: 0x0002C260
		public unsafe bool Muted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0002E09C File Offset: 0x0002C29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992286, XrefRangeEnd = 992298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidMessage(ClientChatMessage chatMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_IsValidMessage_Public_Virtual_Final_New_Boolean_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0002E0EC File Offset: 0x0002C2EC
		[CallerCount(0)]
		public unsafe void Event_Mute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_Event_Mute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0002E120 File Offset: 0x0002C320
		[CallerCount(0)]
		public unsafe void Event_Unmute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_Event_Unmute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0002E154 File Offset: 0x0002C354
		[CallerCount(0)]
		public unsafe void Event_ToggleMute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_Event_ToggleMute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0002E188 File Offset: 0x0002C388
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
		public unsafe virtual ulong Version
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEmoteChatMessageFilter.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0002E204 File Offset: 0x0002C404
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEmoteChatMessageFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEmoteChatMessageFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEmoteChatMessageFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00006366 File Offset: 0x00004566
		public PlayerEmoteChatMessageFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0002E240 File Offset: 0x0002C440
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x0000636F File Offset: 0x0000456F
		public unsafe EntityView playerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEmoteChatMessageFilter.NativeFieldInfoPtr_playerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEmoteChatMessageFilter.NativeFieldInfoPtr_playerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002E270 File Offset: 0x0002C470
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x0000638E File Offset: 0x0000458E
		public unsafe bool muted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEmoteChatMessageFilter.NativeFieldInfoPtr_muted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEmoteChatMessageFilter.NativeFieldInfoPtr_muted)) = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002E298 File Offset: 0x0002C498
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x000063A9 File Offset: 0x000045A9
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEmoteChatMessageFilter.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEmoteChatMessageFilter.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_playerView;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_muted;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_IsValidMessage_Public_Virtual_Final_New_Boolean_ClientChatMessage_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_Event_Mute_Public_Void_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_Event_Unmute_Public_Void_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleMute_Public_Void_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
