using System;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using UnityEngine.Events;

namespace worm.match.components
{
	// Token: 0x020001EF RID: 495
	public class WormEventsForChatReceived : MonoBehaviour
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x0005AA58 File Offset: 0x00058C58
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForChatReceived()
		{
			Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormEventsForChatReceived");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr);
			WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedExpandedSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, "onChatReceivedExpandedSelf");
			WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedExpandedOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, "onChatReceivedExpandedOther");
			WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedCollapsedSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, "onChatReceivedCollapsedSelf");
			WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedCollapsedOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, "onChatReceivedCollapsedOther");
			WormEventsForChatReceived.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, "accountProvider");
			WormEventsForChatReceived.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, 100666321);
			WormEventsForChatReceived.NativeMethodInfoPtr_Event_OnChatReceivedExpanded_Public_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, 100666322);
			WormEventsForChatReceived.NativeMethodInfoPtr_Event_OnChatReceivedCollapsed_Public_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, 100666323);
			WormEventsForChatReceived.NativeMethodInfoPtr_FromSelf_Private_Boolean_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, 100666324);
			WormEventsForChatReceived.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr, 100666325);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0005AB50 File Offset: 0x00058D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715928, XrefRangeEnd = 715931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForChatReceived.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0005AB84 File Offset: 0x00058D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715931, XrefRangeEnd = 715937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnChatReceivedExpanded(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForChatReceived.NativeMethodInfoPtr_Event_OnChatReceivedExpanded_Public_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0005ABC8 File Offset: 0x00058DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715937, XrefRangeEnd = 715943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnChatReceivedCollapsed(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForChatReceived.NativeMethodInfoPtr_Event_OnChatReceivedCollapsed_Public_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0005AC0C File Offset: 0x00058E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 715952, RefRangeEnd = 715954, XrefRangeStart = 715943, XrefRangeEnd = 715952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FromSelf(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForChatReceived.NativeMethodInfoPtr_FromSelf_Private_Boolean_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0005AC5C File Offset: 0x00058E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715954, XrefRangeEnd = 715977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForChatReceived()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForChatReceived>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForChatReceived.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0000D38B File Offset: 0x0000B58B
		public WormEventsForChatReceived(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x0005AC98 File Offset: 0x00058E98
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x0000D394 File Offset: 0x0000B594
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedExpandedSelf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedExpandedSelf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedExpandedSelf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x0005ACC8 File Offset: 0x00058EC8
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000D3B3 File Offset: 0x0000B5B3
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedExpandedOther
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedExpandedOther);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedExpandedOther), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x0005ACF8 File Offset: 0x00058EF8
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000D3D2 File Offset: 0x0000B5D2
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedCollapsedSelf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedCollapsedSelf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedCollapsedSelf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0005AD28 File Offset: 0x00058F28
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000D3F1 File Offset: 0x0000B5F1
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedCollapsedOther
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedCollapsedOther);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_onChatReceivedCollapsedOther), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0005AD58 File Offset: 0x00058F58
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0000D410 File Offset: 0x0000B610
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForChatReceived.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedExpandedSelf;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedExpandedOther;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedCollapsedSelf;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedCollapsedOther;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnChatReceivedExpanded_Public_Void_ClientChatMessage_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnChatReceivedCollapsed_Public_Void_ClientChatMessage_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_FromSelf_Private_Boolean_ClientChatMessage_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
