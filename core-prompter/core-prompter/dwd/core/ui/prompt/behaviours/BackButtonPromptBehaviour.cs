using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000033 RID: 51
	public class BackButtonPromptBehaviour : PromptBehaviour<IDynamicBackPrompt>
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x0000A3C8 File Offset: 0x000085C8
		// Note: this type is marked as 'beforefieldinit'.
		static BackButtonPromptBehaviour()
		{
			Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "BackButtonPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr);
			BackButtonPromptBehaviour.NativeFieldInfoPtr_backButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr, "backButton");
			BackButtonPromptBehaviour.NativeFieldInfoPtr_hideWhenNoBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr, "hideWhenNoBack");
			BackButtonPromptBehaviour.NativeFieldInfoPtr_cachedCanBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr, "cachedCanBack");
			BackButtonPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr, 100663521);
			BackButtonPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr, 100663522);
			BackButtonPromptBehaviour.NativeMethodInfoPtr_updateBackButton_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr, 100663523);
			BackButtonPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr, 100663524);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000A484 File Offset: 0x00008684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214320, XrefRangeEnd = 1214328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackButtonPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214328, XrefRangeEnd = 1214335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackButtonPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000A4EC File Offset: 0x000086EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1214353, RefRangeEnd = 1214355, XrefRangeStart = 1214335, XrefRangeEnd = 1214353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateBackButton(bool canBack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canBack;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackButtonPromptBehaviour.NativeMethodInfoPtr_updateBackButton_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000A52C File Offset: 0x0000872C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214355, XrefRangeEnd = 1214358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackButtonPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackButtonPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackButtonPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002FDC File Offset: 0x000011DC
		public BackButtonPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000A568 File Offset: 0x00008768
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002FE5 File Offset: 0x000011E5
		public unsafe GameObject backButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackButtonPromptBehaviour.NativeFieldInfoPtr_backButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackButtonPromptBehaviour.NativeFieldInfoPtr_backButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000A598 File Offset: 0x00008798
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00003004 File Offset: 0x00001204
		public unsafe bool hideWhenNoBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackButtonPromptBehaviour.NativeFieldInfoPtr_hideWhenNoBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackButtonPromptBehaviour.NativeFieldInfoPtr_hideWhenNoBack)) = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000A5C0 File Offset: 0x000087C0
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0000301F File Offset: 0x0000121F
		public unsafe bool cachedCanBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackButtonPromptBehaviour.NativeFieldInfoPtr_cachedCanBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackButtonPromptBehaviour.NativeFieldInfoPtr_cachedCanBack)) = value;
			}
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_backButton;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_hideWhenNoBack;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_cachedCanBack;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_updateBackButton_Private_Void_Boolean_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
