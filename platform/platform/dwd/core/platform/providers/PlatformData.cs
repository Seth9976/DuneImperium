using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.providers
{
	// Token: 0x02000047 RID: 71
	public class PlatformData : Object
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0000D02C File Offset: 0x0000B22C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformData()
		{
			Il2CppClassPointerStore<PlatformData>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.providers", "PlatformData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformData>.NativeClassPtr);
			PlatformData.NativeFieldInfoPtr_OnUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformData>.NativeClassPtr, "OnUpdated");
			PlatformData.NativeMethodInfoPtr_add_OnUpdated_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformData>.NativeClassPtr, 100663657);
			PlatformData.NativeMethodInfoPtr_remove_OnUpdated_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformData>.NativeClassPtr, 100663658);
			PlatformData.NativeMethodInfoPtr_notify_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformData>.NativeClassPtr, 100663659);
			PlatformData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformData>.NativeClassPtr, 100663660);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1168281, RefRangeEnd = 1168292, XrefRangeStart = 1168277, XrefRangeEnd = 1168281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnUpdated(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformData.NativeMethodInfoPtr_add_OnUpdated_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000D104 File Offset: 0x0000B304
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1168296, RefRangeEnd = 1168309, XrefRangeStart = 1168292, XrefRangeEnd = 1168296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnUpdated(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformData.NativeMethodInfoPtr_remove_OnUpdated_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000D148 File Offset: 0x0000B348
		[CallerCount(0)]
		public unsafe void notify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformData.NativeMethodInfoPtr_notify_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000D17C File Offset: 0x0000B37C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000033D5 File Offset: 0x000015D5
		public PlatformData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		// (set) Token: 0x0600027D RID: 637 RVA: 0x000033DE File Offset: 0x000015DE
		public unsafe Action OnUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformData.NativeFieldInfoPtr_OnUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformData.NativeFieldInfoPtr_OnUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_OnUpdated;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUpdated_Public_add_Void_Action_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpdated_Public_rem_Void_Action_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_notify_Protected_Void_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
