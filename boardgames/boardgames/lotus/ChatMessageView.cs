using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace lotus
{
	// Token: 0x020000AB RID: 171
	public class ChatMessageView : MonoBehaviour
	{
		// Token: 0x06000830 RID: 2096 RVA: 0x0002AD1C File Offset: 0x00028F1C
		// Note: this type is marked as 'beforefieldinit'.
		static ChatMessageView()
		{
			Il2CppClassPointerStore<ChatMessageView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ChatMessageView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageView>.NativeClassPtr);
			ChatMessageView.NativeFieldInfoPtr_messageField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageView>.NativeClassPtr, "messageField");
			ChatMessageView.NativeFieldInfoPtr_layoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageView>.NativeClassPtr, "layoutElement");
			ChatMessageView.NativeMethodInfoPtr_ConstructMessage_Public_Virtual_New_Void_ClientChatMessage_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageView>.NativeClassPtr, 100664587);
			ChatMessageView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageView>.NativeClassPtr, 100664588);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0002AD9C File Offset: 0x00028F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991402, XrefRangeEnd = 991430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConstructMessage(ClientChatMessage message, Color messageColor, Color userColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatMessageView.NativeMethodInfoPtr_ConstructMessage_Public_Virtual_New_Void_ClientChatMessage_Color_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0002AE08 File Offset: 0x00029008
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatMessageView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00005BBD File Offset: 0x00003DBD
		public ChatMessageView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x0002AE44 File Offset: 0x00029044
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00005BC6 File Offset: 0x00003DC6
		public unsafe TMP_Text messageField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageView.NativeFieldInfoPtr_messageField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageView.NativeFieldInfoPtr_messageField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x0002AE74 File Offset: 0x00029074
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00005BE5 File Offset: 0x00003DE5
		public unsafe LayoutElement layoutElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageView.NativeFieldInfoPtr_layoutElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageView.NativeFieldInfoPtr_layoutElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_messageField;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_layoutElement;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_ConstructMessage_Public_Virtual_New_Void_ClientChatMessage_Color_Color_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
