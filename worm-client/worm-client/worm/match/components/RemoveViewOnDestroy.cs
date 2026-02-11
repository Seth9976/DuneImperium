using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.components
{
	// Token: 0x020001BC RID: 444
	public class RemoveViewOnDestroy : Observer
	{
		// Token: 0x06001392 RID: 5010 RVA: 0x0005392C File Offset: 0x00051B2C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveViewOnDestroy()
		{
			Il2CppClassPointerStore<RemoveViewOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "RemoveViewOnDestroy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveViewOnDestroy>.NativeClassPtr);
			RemoveViewOnDestroy.NativeFieldInfoPtr_viewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveViewOnDestroy>.NativeClassPtr, "viewLayer");
			RemoveViewOnDestroy.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveViewOnDestroy>.NativeClassPtr, "entityID");
			RemoveViewOnDestroy.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveViewOnDestroy>.NativeClassPtr, 100665977);
			RemoveViewOnDestroy.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveViewOnDestroy>.NativeClassPtr, 100665978);
			RemoveViewOnDestroy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveViewOnDestroy>.NativeClassPtr, 100665979);
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x000539C0 File Offset: 0x00051BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713189, XrefRangeEnd = 713194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemoveViewOnDestroy.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x000539FC File Offset: 0x00051BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713194, XrefRangeEnd = 713202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveViewOnDestroy.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00053A30 File Offset: 0x00051C30
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveViewOnDestroy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveViewOnDestroy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveViewOnDestroy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0000C145 File Offset: 0x0000A345
		public RemoveViewOnDestroy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00053A6C File Offset: 0x00051C6C
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x0000C14E File Offset: 0x0000A34E
		public unsafe int viewLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveViewOnDestroy.NativeFieldInfoPtr_viewLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveViewOnDestroy.NativeFieldInfoPtr_viewLayer)) = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00053A94 File Offset: 0x00051C94
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x0000C169 File Offset: 0x0000A369
		public unsafe EntityID entityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveViewOnDestroy.NativeFieldInfoPtr_entityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveViewOnDestroy.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_viewLayer;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr_entityID;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
