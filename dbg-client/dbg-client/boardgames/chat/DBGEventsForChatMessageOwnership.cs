using System;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.chat
{
	// Token: 0x02000243 RID: 579
	public class DBGEventsForChatMessageOwnership : MonoBehaviour
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x00072820 File Offset: 0x00070A20
		// Note: this type is marked as 'beforefieldinit'.
		static DBGEventsForChatMessageOwnership()
		{
			Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.chat", "DBGEventsForChatMessageOwnership");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr);
			DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedExpandedSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, "onChatReceivedExpandedSelf");
			DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedExpandedOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, "onChatReceivedExpandedOther");
			DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedCollapsedSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, "onChatReceivedCollapsedSelf");
			DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedCollapsedOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, "onChatReceivedCollapsedOther");
			DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, "accountProvider");
			DBGEventsForChatMessageOwnership.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, 100667454);
			DBGEventsForChatMessageOwnership.NativeMethodInfoPtr_Event_OnChatReceivedExpanded_Public_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, 100667455);
			DBGEventsForChatMessageOwnership.NativeMethodInfoPtr_Event_OnChatReceivedCollapsed_Public_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, 100667456);
			DBGEventsForChatMessageOwnership.NativeMethodInfoPtr_FromSelf_Private_Boolean_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, 100667457);
			DBGEventsForChatMessageOwnership.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr, 100667458);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00072918 File Offset: 0x00070B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531349, XrefRangeEnd = 531352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEventsForChatMessageOwnership.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0007294C File Offset: 0x00070B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531352, XrefRangeEnd = 531358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnChatReceivedExpanded(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEventsForChatMessageOwnership.NativeMethodInfoPtr_Event_OnChatReceivedExpanded_Public_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00072990 File Offset: 0x00070B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531358, XrefRangeEnd = 531364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnChatReceivedCollapsed(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEventsForChatMessageOwnership.NativeMethodInfoPtr_Event_OnChatReceivedCollapsed_Public_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000729D4 File Offset: 0x00070BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 531373, RefRangeEnd = 531375, XrefRangeStart = 531364, XrefRangeEnd = 531373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FromSelf(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEventsForChatMessageOwnership.NativeMethodInfoPtr_FromSelf_Private_Boolean_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00072A24 File Offset: 0x00070C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531375, XrefRangeEnd = 531398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGEventsForChatMessageOwnership()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEventsForChatMessageOwnership>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEventsForChatMessageOwnership.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0000E524 File Offset: 0x0000C724
		public DBGEventsForChatMessageOwnership(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x00072A60 File Offset: 0x00070C60
		// (set) Token: 0x06001A2E RID: 6702 RVA: 0x0000E52D File Offset: 0x0000C72D
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedExpandedSelf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedExpandedSelf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedExpandedSelf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00072A90 File Offset: 0x00070C90
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x0000E54C File Offset: 0x0000C74C
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedExpandedOther
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedExpandedOther);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedExpandedOther), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00072AC0 File Offset: 0x00070CC0
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0000E56B File Offset: 0x0000C76B
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedCollapsedSelf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedCollapsedSelf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedCollapsedSelf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00072AF0 File Offset: 0x00070CF0
		// (set) Token: 0x06001A34 RID: 6708 RVA: 0x0000E58A File Offset: 0x0000C78A
		public unsafe UnityEvent<ClientChatMessage> onChatReceivedCollapsedOther
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedCollapsedOther);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ClientChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_onChatReceivedCollapsedOther), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00072B20 File Offset: 0x00070D20
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x0000E5A9 File Offset: 0x0000C7A9
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEventsForChatMessageOwnership.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedExpandedSelf;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedExpandedOther;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedCollapsedSelf;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr_onChatReceivedCollapsedOther;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnChatReceivedExpanded_Public_Void_ClientChatMessage_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnChatReceivedCollapsed_Public_Void_ClientChatMessage_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_FromSelf_Private_Boolean_ClientChatMessage_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
