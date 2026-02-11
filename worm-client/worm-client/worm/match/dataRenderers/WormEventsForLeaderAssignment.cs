using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x0200011D RID: 285
	public class WormEventsForLeaderAssignment : VersionedView<IAttribute<LeaderAssignmentMode>>
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForLeaderAssignment()
		{
			Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForLeaderAssignment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr);
			WormEventsForLeaderAssignment.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr, "mode");
			WormEventsForLeaderAssignment.NativeFieldInfoPtr_onIsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr, "onIsMode");
			WormEventsForLeaderAssignment.NativeFieldInfoPtr_onIsNotMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr, "onIsNotMode");
			WormEventsForLeaderAssignment.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr, 100665080);
			WormEventsForLeaderAssignment.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr, 100665081);
			WormEventsForLeaderAssignment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr, 100665082);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0003FA88 File Offset: 0x0003DC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705188, XrefRangeEnd = 705203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForLeaderAssignment.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0003FAC4 File Offset: 0x0003DCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705203, XrefRangeEnd = 705209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForLeaderAssignment.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0003FB00 File Offset: 0x0003DD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705209, XrefRangeEnd = 705221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForLeaderAssignment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForLeaderAssignment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForLeaderAssignment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00008E30 File Offset: 0x00007030
		public WormEventsForLeaderAssignment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0003FB3C File Offset: 0x0003DD3C
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00008E39 File Offset: 0x00007039
		public unsafe LeaderAssignmentMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderAssignment.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderAssignment.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0003FB64 File Offset: 0x0003DD64
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00008E54 File Offset: 0x00007054
		public unsafe UnityEvent onIsMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderAssignment.NativeFieldInfoPtr_onIsMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderAssignment.NativeFieldInfoPtr_onIsMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0003FB94 File Offset: 0x0003DD94
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00008E73 File Offset: 0x00007073
		public unsafe UnityEvent onIsNotMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderAssignment.NativeFieldInfoPtr_onIsNotMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderAssignment.NativeFieldInfoPtr_onIsNotMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_onIsMode;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_onIsNotMode;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
