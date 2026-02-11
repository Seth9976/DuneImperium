using System;
using boardgames.match.selection;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001D6 RID: 470
	public class WormCardAnimatedPileAnimations : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x060014C0 RID: 5312 RVA: 0x00057198 File Offset: 0x00055398
		// Note: this type is marked as 'beforefieldinit'.
		static WormCardAnimatedPileAnimations()
		{
			Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormCardAnimatedPileAnimations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr);
			WormCardAnimatedPileAnimations.NativeFieldInfoPtr_intro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, "intro");
			WormCardAnimatedPileAnimations.NativeFieldInfoPtr_outro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, "outro");
			WormCardAnimatedPileAnimations.NativeFieldInfoPtr_selectedHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, "selectedHide");
			WormCardAnimatedPileAnimations.NativeFieldInfoPtr_justRanOutro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, "justRanOutro");
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr_get_Intro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666144);
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr_get_Outro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666145);
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666146);
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666147);
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666148);
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr_Event_Outro_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666149);
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666150);
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666151);
			WormCardAnimatedPileAnimations.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr, 100666152);
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x000572CC File Offset: 0x000554CC
		public unsafe virtual TriggeredBlockingAnimation Intro
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardAnimatedPileAnimations.NativeMethodInfoPtr_get_Intro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr3) : null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0005730C File Offset: 0x0005550C
		public unsafe virtual TriggeredBlockingAnimation Outro
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardAnimatedPileAnimations.NativeMethodInfoPtr_get_Outro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr3) : null;
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0005734C File Offset: 0x0005554C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714505, XrefRangeEnd = 714511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardAnimatedPileAnimations.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00057388 File Offset: 0x00055588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714511, XrefRangeEnd = 714515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardAnimatedPileAnimations.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x000573C4 File Offset: 0x000555C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714515, XrefRangeEnd = 714516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardAnimatedPileAnimations.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00057400 File Offset: 0x00055600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 500896, RefRangeEnd = 500897, XrefRangeStart = 500896, XrefRangeEnd = 500897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Outro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardAnimatedPileAnimations.NativeMethodInfoPtr_Event_Outro_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00057434 File Offset: 0x00055634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714516, XrefRangeEnd = 714519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCardAnimatedPileAnimations()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCardAnimatedPileAnimations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardAnimatedPileAnimations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00057470 File Offset: 0x00055670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject IGameObject_get_gameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardAnimatedPileAnimations.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x000574B0 File Offset: 0x000556B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform IGameObject_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardAnimatedPileAnimations.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0000CB02 File Offset: 0x0000AD02
		public WormCardAnimatedPileAnimations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x000574F0 File Offset: 0x000556F0
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x0000CB0B File Offset: 0x0000AD0B
		public unsafe TriggeredBlockingAnimation intro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardAnimatedPileAnimations.NativeFieldInfoPtr_intro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardAnimatedPileAnimations.NativeFieldInfoPtr_intro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00057520 File Offset: 0x00055720
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x0000CB2A File Offset: 0x0000AD2A
		public unsafe TriggeredBlockingAnimation outro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardAnimatedPileAnimations.NativeFieldInfoPtr_outro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardAnimatedPileAnimations.NativeFieldInfoPtr_outro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00057550 File Offset: 0x00055750
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0000CB49 File Offset: 0x0000AD49
		public unsafe TriggeredBlockingAnimation selectedHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardAnimatedPileAnimations.NativeFieldInfoPtr_selectedHide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardAnimatedPileAnimations.NativeFieldInfoPtr_selectedHide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00057580 File Offset: 0x00055780
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0000CB68 File Offset: 0x0000AD68
		public unsafe bool justRanOutro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardAnimatedPileAnimations.NativeFieldInfoPtr_justRanOutro);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardAnimatedPileAnimations.NativeFieldInfoPtr_justRanOutro)) = value;
			}
		}

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeFieldInfoPtr_intro;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr_outro;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_selectedHide;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_justRanOutro;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_get_Intro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_get_Outro_Public_Virtual_Final_New_get_TriggeredBlockingAnimation_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_Event_Outro_Public_Void_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;
	}
}
