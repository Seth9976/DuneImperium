using System;
using boardgames.prompts;
using dwd.core.prefabs.prefabProvider;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbgclient
{
	// Token: 0x02000081 RID: 129
	public class TutorialGoalsPromptBehaviour : PromptBehaviour<TutorialPrompt>
	{
		// Token: 0x060004FC RID: 1276 RVA: 0x0002D1C0 File Offset: 0x0002B3C0
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialGoalsPromptBehaviour()
		{
			Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient", "TutorialGoalsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr);
			TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_providerInstantiator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, "providerInstantiator");
			TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, "model");
			TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, "cachedVersion");
			TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_minimizeAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, "minimizeAnimator");
			TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_minimized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, "minimized");
			TutorialGoalsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, 100664044);
			TutorialGoalsPromptBehaviour.NativeMethodInfoPtr_Event_ToggleMinimize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, 100664045);
			TutorialGoalsPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, 100664046);
			TutorialGoalsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr, 100664047);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002D2A4 File Offset: 0x0002B4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501311, XrefRangeEnd = 501320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialGoalsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0002D2E0 File Offset: 0x0002B4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501320, XrefRangeEnd = 501329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleMinimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialGoalsPromptBehaviour.NativeMethodInfoPtr_Event_ToggleMinimize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0002D314 File Offset: 0x0002B514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501329, XrefRangeEnd = 501339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialGoalsPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0002D348 File Offset: 0x0002B548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501339, XrefRangeEnd = 501342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialGoalsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialGoalsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialGoalsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004442 File Offset: 0x00002642
		public TutorialGoalsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0002D384 File Offset: 0x0002B584
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x0000444B File Offset: 0x0000264B
		public unsafe ProviderInstantiator providerInstantiator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_providerInstantiator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProviderInstantiator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_providerInstantiator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0002D3B4 File Offset: 0x0002B5B4
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x0000446A File Offset: 0x0000266A
		public unsafe ObjectivesListData model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectivesListData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0002D3E4 File Offset: 0x0002B5E4
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004489 File Offset: 0x00002689
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0002D40C File Offset: 0x0002B60C
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x000044A4 File Offset: 0x000026A4
		public unsafe Animator minimizeAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_minimizeAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_minimizeAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0002D43C File Offset: 0x0002B63C
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x000044C3 File Offset: 0x000026C3
		public unsafe bool minimized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_minimized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialGoalsPromptBehaviour.NativeFieldInfoPtr_minimized)) = value;
			}
		}

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_providerInstantiator;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_minimizeAnimator;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_minimized;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleMinimize_Public_Void_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
