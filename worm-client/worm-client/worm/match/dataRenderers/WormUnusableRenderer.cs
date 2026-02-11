using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000170 RID: 368
	public class WormUnusableRenderer : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x0600105F RID: 4191 RVA: 0x000492D4 File Offset: 0x000474D4
		// Note: this type is marked as 'beforefieldinit'.
		static WormUnusableRenderer()
		{
			Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormUnusableRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr);
			WormUnusableRenderer.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr, "parent");
			WormUnusableRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr, "animator");
			WormUnusableRenderer.NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr, "Disabled");
			WormUnusableRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr, 100665507);
			WormUnusableRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr, 100665508);
			WormUnusableRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr, 100665509);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0004937C File Offset: 0x0004757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709197, XrefRangeEnd = 709212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormUnusableRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000493B8 File Offset: 0x000475B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709212, XrefRangeEnd = 709240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormUnusableRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000493F4 File Offset: 0x000475F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709240, XrefRangeEnd = 709243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormUnusableRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormUnusableRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUnusableRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0000A9D2 File Offset: 0x00008BD2
		public WormUnusableRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00049430 File Offset: 0x00047630
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x0000A9DB File Offset: 0x00008BDB
		public unsafe EntityView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUnusableRenderer.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUnusableRenderer.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00049460 File Offset: 0x00047660
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x0000A9FA File Offset: 0x00008BFA
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUnusableRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUnusableRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00049490 File Offset: 0x00047690
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x0000AA19 File Offset: 0x00008C19
		public unsafe static int Disabled
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormUnusableRenderer.NativeFieldInfoPtr_Disabled, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormUnusableRenderer.NativeFieldInfoPtr_Disabled, (void*)(&value));
			}
		}

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_Disabled;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
