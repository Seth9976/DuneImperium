using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts
{
	// Token: 0x020001D1 RID: 465
	public class GamePasswordPromptBehaviour : PromptBehaviour<GamePasswordPrompt>
	{
		// Token: 0x06001546 RID: 5446 RVA: 0x000627D4 File Offset: 0x000609D4
		// Note: this type is marked as 'beforefieldinit'.
		static GamePasswordPromptBehaviour()
		{
			Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "GamePasswordPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr);
			GamePasswordPromptBehaviour.NativeFieldInfoPtr_passwordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr, "passwordField");
			GamePasswordPromptBehaviour.NativeFieldInfoPtr_invalidInputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr, "invalidInputIcon");
			GamePasswordPromptBehaviour.NativeFieldInfoPtr_joinGameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr, "joinGameButton");
			GamePasswordPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr, 100666423);
			GamePasswordPromptBehaviour.NativeMethodInfoPtr_Event_Join_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr, 100666424);
			GamePasswordPromptBehaviour.NativeMethodInfoPtr_Event_InputTextChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr, 100666425);
			GamePasswordPromptBehaviour.NativeMethodInfoPtr_updateValidity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr, 100666426);
			GamePasswordPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr, 100666427);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000628A4 File Offset: 0x00060AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522197, XrefRangeEnd = 522198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GamePasswordPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x000628E0 File Offset: 0x00060AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522198, XrefRangeEnd = 522202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Join()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePasswordPromptBehaviour.NativeMethodInfoPtr_Event_Join_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00062914 File Offset: 0x00060B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_InputTextChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePasswordPromptBehaviour.NativeMethodInfoPtr_Event_InputTextChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00062948 File Offset: 0x00060B48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 522209, RefRangeEnd = 522211, XrefRangeStart = 522202, XrefRangeEnd = 522209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateValidity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePasswordPromptBehaviour.NativeMethodInfoPtr_updateValidity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0006297C File Offset: 0x00060B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522211, XrefRangeEnd = 522214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamePasswordPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamePasswordPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePasswordPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0000C02D File Offset: 0x0000A22D
		public GamePasswordPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x000629B8 File Offset: 0x00060BB8
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x0000C036 File Offset: 0x0000A236
		public unsafe TMP_InputField passwordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePasswordPromptBehaviour.NativeFieldInfoPtr_passwordField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePasswordPromptBehaviour.NativeFieldInfoPtr_passwordField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x000629E8 File Offset: 0x00060BE8
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0000C055 File Offset: 0x0000A255
		public unsafe GameObject invalidInputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePasswordPromptBehaviour.NativeFieldInfoPtr_invalidInputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePasswordPromptBehaviour.NativeFieldInfoPtr_invalidInputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x00062A18 File Offset: 0x00060C18
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x0000C074 File Offset: 0x0000A274
		public unsafe Button joinGameButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePasswordPromptBehaviour.NativeFieldInfoPtr_joinGameButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamePasswordPromptBehaviour.NativeFieldInfoPtr_joinGameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeFieldInfoPtr_passwordField;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeFieldInfoPtr_invalidInputIcon;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeFieldInfoPtr_joinGameButton;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_Event_Join_Public_Void_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_Event_InputTextChanged_Public_Void_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_updateValidity_Private_Void_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
