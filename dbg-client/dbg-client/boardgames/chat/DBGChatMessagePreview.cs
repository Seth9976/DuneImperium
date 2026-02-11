using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace boardgames.chat
{
	// Token: 0x02000241 RID: 577
	public class DBGChatMessagePreview : MonoBehaviour
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x000722BC File Offset: 0x000704BC
		// Note: this type is marked as 'beforefieldinit'.
		static DBGChatMessagePreview()
		{
			Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.chat", "DBGChatMessagePreview");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr);
			DBGChatMessagePreview.NativeFieldInfoPtr_ChatMessageShowParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, "ChatMessageShowParam");
			DBGChatMessagePreview.NativeFieldInfoPtr_ChatMessageHideParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, "ChatMessageHideParam");
			DBGChatMessagePreview.NativeFieldInfoPtr_messageView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, "messageView");
			DBGChatMessagePreview.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, "animator");
			DBGChatMessagePreview.NativeFieldInfoPtr_chatView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, "chatView");
			DBGChatMessagePreview.NativeMethodInfoPtr_Event_ShowMessage_Public_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, 100667446);
			DBGChatMessagePreview.NativeMethodInfoPtr_Event_HideMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, 100667447);
			DBGChatMessagePreview.NativeMethodInfoPtr_Event_ExpandChatView_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, 100667448);
			DBGChatMessagePreview.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr, 100667449);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000723A0 File Offset: 0x000705A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531223, XrefRangeEnd = 531230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowMessage(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGChatMessagePreview.NativeMethodInfoPtr_Event_ShowMessage_Public_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000723E4 File Offset: 0x000705E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531230, XrefRangeEnd = 531236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HideMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGChatMessagePreview.NativeMethodInfoPtr_Event_HideMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00072418 File Offset: 0x00070618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531236, XrefRangeEnd = 531238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ExpandChatView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGChatMessagePreview.NativeMethodInfoPtr_Event_ExpandChatView_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0007244C File Offset: 0x0007064C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGChatMessagePreview()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGChatMessagePreview>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGChatMessagePreview.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0000E3E7 File Offset: 0x0000C5E7
		public DBGChatMessagePreview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00072488 File Offset: 0x00070688
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
		public unsafe static int ChatMessageShowParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGChatMessagePreview.NativeFieldInfoPtr_ChatMessageShowParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGChatMessagePreview.NativeFieldInfoPtr_ChatMessageShowParam, (void*)(&value));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x000724A4 File Offset: 0x000706A4
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x0000E3FE File Offset: 0x0000C5FE
		public unsafe static int ChatMessageHideParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DBGChatMessagePreview.NativeFieldInfoPtr_ChatMessageHideParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGChatMessagePreview.NativeFieldInfoPtr_ChatMessageHideParam, (void*)(&value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x000724C0 File Offset: 0x000706C0
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x0000E40C File Offset: 0x0000C60C
		public unsafe DBGChatMessageView messageView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessagePreview.NativeFieldInfoPtr_messageView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGChatMessageView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessagePreview.NativeFieldInfoPtr_messageView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x000724F0 File Offset: 0x000706F0
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x0000E42B File Offset: 0x0000C62B
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessagePreview.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessagePreview.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00072520 File Offset: 0x00070720
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0000E44A File Offset: 0x0000C64A
		public unsafe ChatView chatView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessagePreview.NativeFieldInfoPtr_chatView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGChatMessagePreview.NativeFieldInfoPtr_chatView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr_ChatMessageShowParam;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr_ChatMessageHideParam;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr_messageView;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeFieldInfoPtr_chatView;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowMessage_Public_Void_ClientChatMessage_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_Event_HideMessage_Public_Void_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_Event_ExpandChatView_Public_Void_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
