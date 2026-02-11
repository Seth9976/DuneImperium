using System;
using dwd.core.ui.prompt.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using worm.match.data;

namespace worm.match.components
{
	// Token: 0x02000207 RID: 519
	public class WormPlayerInfoButton : MonoBehaviour
	{
		// Token: 0x060016F4 RID: 5876 RVA: 0x0005DB50 File Offset: 0x0005BD50
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerInfoButton()
		{
			Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormPlayerInfoButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr);
			WormPlayerInfoButton.NativeFieldInfoPtr_showPromptCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, "showPromptCommand");
			WormPlayerInfoButton.NativeFieldInfoPtr_playerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, "playerView");
			WormPlayerInfoButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, 100666484);
			WormPlayerInfoButton.NativeMethodInfoPtr_Event_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, 100666485);
			WormPlayerInfoButton.NativeMethodInfoPtr_Event_ShowDeck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, 100666486);
			WormPlayerInfoButton.NativeMethodInfoPtr_Event_ShowDiscard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, 100666487);
			WormPlayerInfoButton.NativeMethodInfoPtr_Event_ShowTech_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, 100666488);
			WormPlayerInfoButton.NativeMethodInfoPtr_Show_Private_Void_WormPlayerInfoViewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, 100666489);
			WormPlayerInfoButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr, 100666490);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0005DC34 File Offset: 0x0005BE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716985, XrefRangeEnd = 716989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0005DC68 File Offset: 0x0005BE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716989, XrefRangeEnd = 716990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoButton.NativeMethodInfoPtr_Event_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0005DC9C File Offset: 0x0005BE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716990, XrefRangeEnd = 716991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowDeck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoButton.NativeMethodInfoPtr_Event_ShowDeck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0005DCD0 File Offset: 0x0005BED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716991, XrefRangeEnd = 716992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowDiscard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoButton.NativeMethodInfoPtr_Event_ShowDiscard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0005DD04 File Offset: 0x0005BF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716992, XrefRangeEnd = 716993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowTech()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoButton.NativeMethodInfoPtr_Event_ShowTech_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0005DD38 File Offset: 0x0005BF38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 717033, RefRangeEnd = 717037, XrefRangeStart = 716993, XrefRangeEnd = 717033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(WormPlayerInfoViewType openView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref openView;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoButton.NativeMethodInfoPtr_Show_Private_Void_WormPlayerInfoViewType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0005DD78 File Offset: 0x0005BF78
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerInfoButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0000DC89 File Offset: 0x0000BE89
		public WormPlayerInfoButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x0005DDB4 File Offset: 0x0005BFB4
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x0000DC92 File Offset: 0x0000BE92
		public unsafe DisplayGenericPrompt showPromptCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoButton.NativeFieldInfoPtr_showPromptCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoButton.NativeFieldInfoPtr_showPromptCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x0005DDE4 File Offset: 0x0005BFE4
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x0000DCB1 File Offset: 0x0000BEB1
		public unsafe EntityView playerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoButton.NativeFieldInfoPtr_playerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoButton.NativeFieldInfoPtr_playerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeFieldInfoPtr_showPromptCommand;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeFieldInfoPtr_playerView;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_Event_Show_Public_Void_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowDeck_Public_Void_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowDiscard_Public_Void_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowTech_Public_Void_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_Show_Private_Void_WormPlayerInfoViewType_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
