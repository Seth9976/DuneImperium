using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using TMPro;

namespace worm.match.dataRenderers
{
	// Token: 0x02000175 RID: 373
	public class WormVersionedChildCountRenderer : VersionedView<ReadOnlyVersionedList<EntityComponent>>
	{
		// Token: 0x060010B7 RID: 4279 RVA: 0x0004A2BC File Offset: 0x000484BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormVersionedChildCountRenderer()
		{
			Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormVersionedChildCountRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr);
			WormVersionedChildCountRenderer.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr, "pileView");
			WormVersionedChildCountRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr, "text");
			WormVersionedChildCountRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr, 100665612);
			WormVersionedChildCountRenderer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr, 100665613);
			WormVersionedChildCountRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr, 100665614);
			WormVersionedChildCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr, 100665615);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0004A364 File Offset: 0x00048564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709930, XrefRangeEnd = 709937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVersionedChildCountRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0004A3A0 File Offset: 0x000485A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709937, XrefRangeEnd = 709940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVersionedChildCountRenderer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0004A3DC File Offset: 0x000485DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709940, XrefRangeEnd = 709947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVersionedChildCountRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0004A418 File Offset: 0x00048618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709947, XrefRangeEnd = 709950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVersionedChildCountRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVersionedChildCountRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVersionedChildCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0000AD0B File Offset: 0x00008F0B
		public WormVersionedChildCountRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x0004A454 File Offset: 0x00048654
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x0000AD14 File Offset: 0x00008F14
		public unsafe EntityView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVersionedChildCountRenderer.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVersionedChildCountRenderer.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0004A484 File Offset: 0x00048684
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x0000AD33 File Offset: 0x00008F33
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVersionedChildCountRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVersionedChildCountRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
