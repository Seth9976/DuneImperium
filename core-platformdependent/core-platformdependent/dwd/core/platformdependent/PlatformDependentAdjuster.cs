using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x0200000C RID: 12
	public class PlatformDependentAdjuster : MonoBehaviour
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00003D84 File Offset: 0x00001F84
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentAdjuster()
		{
			Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr);
			PlatformDependentAdjuster.NativeFieldInfoPtr_Adjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr, "Adjustments");
			PlatformDependentAdjuster.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr, 100663330);
			PlatformDependentAdjuster.NativeMethodInfoPtr_SetTransformFromPlatformAdjustment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr, 100663331);
			PlatformDependentAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr, 100663332);
			PlatformDependentAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr, 100663333);
			PlatformDependentAdjuster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr, 100663334);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003E2C File Offset: 0x0000202C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238788, XrefRangeEnd = 1238789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentAdjuster.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003E60 File Offset: 0x00002060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238810, RefRangeEnd = 1238811, XrefRangeStart = 1238789, XrefRangeEnd = 1238810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformFromPlatformAdjustment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentAdjuster.NativeMethodInfoPtr_SetTransformFromPlatformAdjustment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003E94 File Offset: 0x00002094
		[CallerCount(0)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentAdjuster.NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003ED0 File Offset: 0x000020D0
		[CallerCount(0)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentAdjuster.NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003F0C File Offset: 0x0000210C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1238819, RefRangeEnd = 1238826, XrefRangeStart = 1238811, XrefRangeEnd = 1238819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentAdjuster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002236 File Offset: 0x00000436
		public PlatformDependentAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003F48 File Offset: 0x00002148
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000223F File Offset: 0x0000043F
		public unsafe Dictionary<uint, PlatformDependentAdjustment> Adjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentAdjuster.NativeFieldInfoPtr_Adjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, PlatformDependentAdjustment>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentAdjuster.NativeFieldInfoPtr_Adjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_Adjustments;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformFromPlatformAdjustment_Public_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
