using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000B7 RID: 183
	public class SelectEmoteEvent : MonoBehaviour
	{
		// Token: 0x06000936 RID: 2358 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		// Note: this type is marked as 'beforefieldinit'.
		static SelectEmoteEvent()
		{
			Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "SelectEmoteEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr);
			SelectEmoteEvent.NativeFieldInfoPtr_emoteMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr, "emoteMessage");
			SelectEmoteEvent.NativeFieldInfoPtr_emoteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr, "emoteType");
			SelectEmoteEvent.NativeFieldInfoPtr_emoteSelectPromptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr, "emoteSelectPromptBehaviour");
			SelectEmoteEvent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr, 100664739);
			SelectEmoteEvent.NativeMethodInfoPtr_Event_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr, 100664740);
			SelectEmoteEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr, 100664741);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0002E368 File Offset: 0x0002C568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992298, XrefRangeEnd = 992302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEmoteEvent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0002E39C File Offset: 0x0002C59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992302, XrefRangeEnd = 992305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEmoteEvent.NativeMethodInfoPtr_Event_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0002E3D0 File Offset: 0x0002C5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992305, XrefRangeEnd = 992311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectEmoteEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectEmoteEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectEmoteEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000063C4 File Offset: 0x000045C4
		public SelectEmoteEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0002E40C File Offset: 0x0002C60C
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x000063CD File Offset: 0x000045CD
		public unsafe string emoteMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEmoteEvent.NativeFieldInfoPtr_emoteMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEmoteEvent.NativeFieldInfoPtr_emoteMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0002E434 File Offset: 0x0002C634
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x000063EC File Offset: 0x000045EC
		public unsafe string emoteType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEmoteEvent.NativeFieldInfoPtr_emoteType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEmoteEvent.NativeFieldInfoPtr_emoteType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0002E45C File Offset: 0x0002C65C
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0000640B File Offset: 0x0000460B
		public unsafe EmoteSelectPromptBehaviour emoteSelectPromptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEmoteEvent.NativeFieldInfoPtr_emoteSelectPromptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmoteSelectPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectEmoteEvent.NativeFieldInfoPtr_emoteSelectPromptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_emoteMessage;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_emoteType;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_emoteSelectPromptBehaviour;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_Event_Select_Public_Void_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
