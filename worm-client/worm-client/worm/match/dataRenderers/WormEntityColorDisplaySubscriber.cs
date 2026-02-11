using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000116 RID: 278
	public class WormEntityColorDisplaySubscriber : VersionedSubscriber<WormColorData>
	{
		// Token: 0x06000CD0 RID: 3280 RVA: 0x0003F00C File Offset: 0x0003D20C
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntityColorDisplaySubscriber()
		{
			Il2CppClassPointerStore<WormEntityColorDisplaySubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEntityColorDisplaySubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityColorDisplaySubscriber>.NativeClassPtr);
			WormEntityColorDisplaySubscriber.NativeFieldInfoPtr_colorDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityColorDisplaySubscriber>.NativeClassPtr, "colorDisplay");
			WormEntityColorDisplaySubscriber.NativeFieldInfoPtr_parentEntityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityColorDisplaySubscriber>.NativeClassPtr, "parentEntityView");
			WormEntityColorDisplaySubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityColorDisplaySubscriber>.NativeClassPtr, 100665054);
			WormEntityColorDisplaySubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityColorDisplaySubscriber>.NativeClassPtr, 100665055);
			WormEntityColorDisplaySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityColorDisplaySubscriber>.NativeClassPtr, 100665056);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003F0A0 File Offset: 0x0003D2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704942, XrefRangeEnd = 704946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityColorDisplaySubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0003F0DC File Offset: 0x0003D2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704946, XrefRangeEnd = 704964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityColorDisplaySubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0003F118 File Offset: 0x0003D318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704964, XrefRangeEnd = 704967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntityColorDisplaySubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntityColorDisplaySubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityColorDisplaySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00008C5F File Offset: 0x00006E5F
		public WormEntityColorDisplaySubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0003F154 File Offset: 0x0003D354
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00008C68 File Offset: 0x00006E68
		public unsafe GameObject colorDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityColorDisplaySubscriber.NativeFieldInfoPtr_colorDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityColorDisplaySubscriber.NativeFieldInfoPtr_colorDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0003F184 File Offset: 0x0003D384
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x00008C87 File Offset: 0x00006E87
		public unsafe EntityView parentEntityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityColorDisplaySubscriber.NativeFieldInfoPtr_parentEntityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityColorDisplaySubscriber.NativeFieldInfoPtr_parentEntityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplay;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr_parentEntityView;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
