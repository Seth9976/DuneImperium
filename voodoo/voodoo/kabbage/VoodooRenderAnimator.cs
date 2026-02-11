using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x02000028 RID: 40
	public class VoodooRenderAnimator : PathAnimator
	{
		// Token: 0x06000167 RID: 359 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooRenderAnimator()
		{
			Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "VoodooRenderAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr);
			VoodooRenderAnimator.NativeFieldInfoPtr__UnitView_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "<UnitView>k__BackingField");
			VoodooRenderAnimator.NativeFieldInfoPtr__UnitPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "<UnitPosition>k__BackingField");
			VoodooRenderAnimator.NativeFieldInfoPtr_parentToDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "parentToDestination");
			VoodooRenderAnimator.NativeFieldInfoPtr_normalizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "normalizeScale");
			VoodooRenderAnimator.NativeFieldInfoPtr_worldspaceStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "worldspaceStartPosition");
			VoodooRenderAnimator.NativeFieldInfoPtr_worldspaceDestinationPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "worldspaceDestinationPosition");
			VoodooRenderAnimator.NativeFieldInfoPtr_maxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "maxDuration");
			VoodooRenderAnimator.NativeFieldInfoPtr_destTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "destTransform");
			VoodooRenderAnimator.NativeFieldInfoPtr_destRelativeTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "destRelativeTransform");
			VoodooRenderAnimator.NativeFieldInfoPtr_initialDestGlobalTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "initialDestGlobalTransform");
			VoodooRenderAnimator.NativeFieldInfoPtr_startTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "startTransform");
			VoodooRenderAnimator.NativeFieldInfoPtr_startRelativeTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "startRelativeTransform");
			VoodooRenderAnimator.NativeFieldInfoPtr_initialStartGlobalTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "initialStartGlobalTransform");
			VoodooRenderAnimator.NativeFieldInfoPtr_scratchConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "scratchConfig");
			VoodooRenderAnimator.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "root");
			VoodooRenderAnimator.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "playing");
			VoodooRenderAnimator.NativeFieldInfoPtr_complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "complete");
			VoodooRenderAnimator.NativeFieldInfoPtr_unblocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "unblocked");
			VoodooRenderAnimator.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, "currentTime");
			VoodooRenderAnimator.NativeMethodInfoPtr_get_UnitView_Public_get_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663466);
			VoodooRenderAnimator.NativeMethodInfoPtr_set_UnitView_Private_set_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663467);
			VoodooRenderAnimator.NativeMethodInfoPtr_get_UnitPosition_Public_get_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663468);
			VoodooRenderAnimator.NativeMethodInfoPtr_set_UnitPosition_Private_set_Void_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663469);
			VoodooRenderAnimator.NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663470);
			VoodooRenderAnimator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663471);
			VoodooRenderAnimator.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663472);
			VoodooRenderAnimator.NativeMethodInfoPtr_Event_Unblock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663473);
			VoodooRenderAnimator.NativeMethodInfoPtr_Event_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663474);
			VoodooRenderAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr, 100663475);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000DA38 File Offset: 0x0000BC38
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000DA78 File Offset: 0x0000BC78
		public unsafe UnitView UnitView
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderAnimator.NativeMethodInfoPtr_get_UnitView_Public_get_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderAnimator.NativeMethodInfoPtr_set_UnitView_Private_set_Void_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000DABC File Offset: 0x0000BCBC
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		public unsafe UnitPosition UnitPosition
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderAnimator.NativeMethodInfoPtr_get_UnitPosition_Public_get_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderAnimator.NativeMethodInfoPtr_set_UnitPosition_Private_set_Void_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000DB40 File Offset: 0x0000BD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107466, XrefRangeEnd = 1107498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitWithContext(UnitView unitView, UnitPosition unitPosition, LocalTransform destLocalTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unitView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unitPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLocalTransform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooRenderAnimator.NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107573, RefRangeEnd = 1107574, XrefRangeStart = 1107498, XrefRangeEnd = 1107573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderAnimator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107574, XrefRangeEnd = 1107579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooRenderAnimator.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107579, XrefRangeEnd = 1107580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Unblock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderAnimator.NativeMethodInfoPtr_Event_Unblock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000DC54 File Offset: 0x0000BE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107580, XrefRangeEnd = 1107582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderAnimator.NativeMethodInfoPtr_Event_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000DC88 File Offset: 0x0000BE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107582, XrefRangeEnd = 1107583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooRenderAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooRenderAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooRenderAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002C54 File Offset: 0x00000E54
		public VoodooRenderAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002C5D File Offset: 0x00000E5D
		public unsafe UnitView _UnitView_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr__UnitView_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr__UnitView_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002C7C File Offset: 0x00000E7C
		public unsafe UnitPosition _UnitPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr__UnitPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr__UnitPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000DD24 File Offset: 0x0000BF24
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002C9B File Offset: 0x00000E9B
		public unsafe bool parentToDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_parentToDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_parentToDestination)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002CB6 File Offset: 0x00000EB6
		public unsafe bool normalizeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_normalizeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_normalizeScale)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000DD74 File Offset: 0x0000BF74
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002CD1 File Offset: 0x00000ED1
		public unsafe bool worldspaceStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_worldspaceStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_worldspaceStartPosition)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002CEC File Offset: 0x00000EEC
		public unsafe bool worldspaceDestinationPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_worldspaceDestinationPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_worldspaceDestinationPosition)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000DDC4 File Offset: 0x0000BFC4
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002D07 File Offset: 0x00000F07
		public unsafe float maxDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_maxDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_maxDuration)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002D22 File Offset: 0x00000F22
		public unsafe Transform destTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_destTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_destTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000DE1C File Offset: 0x0000C01C
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002D41 File Offset: 0x00000F41
		public unsafe LocalTransform destRelativeTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_destRelativeTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_destRelativeTransform)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000DE44 File Offset: 0x0000C044
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002D5C File Offset: 0x00000F5C
		public unsafe GlobalTransform initialDestGlobalTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_initialDestGlobalTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_initialDestGlobalTransform)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000DE6C File Offset: 0x0000C06C
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002D77 File Offset: 0x00000F77
		public unsafe Transform startTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_startTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_startTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000DE9C File Offset: 0x0000C09C
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002D96 File Offset: 0x00000F96
		public unsafe LocalTransform startRelativeTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_startRelativeTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_startRelativeTransform)) = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002DB1 File Offset: 0x00000FB1
		public unsafe GlobalTransform initialStartGlobalTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_initialStartGlobalTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_initialStartGlobalTransform)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002DCC File Offset: 0x00000FCC
		public unsafe VisibilityConfiguration scratchConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_scratchConfig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_scratchConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000DF1C File Offset: 0x0000C11C
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002DEB File Offset: 0x00000FEB
		public unsafe VoodooRenderRoot root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooRenderRoot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000DF4C File Offset: 0x0000C14C
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002E0A File Offset: 0x0000100A
		public unsafe bool playing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_playing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_playing)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000DF74 File Offset: 0x0000C174
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002E25 File Offset: 0x00001025
		public unsafe bool complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_complete)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000DF9C File Offset: 0x0000C19C
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002E40 File Offset: 0x00001040
		public unsafe bool unblocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_unblocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_unblocked)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002E5B File Offset: 0x0000105B
		public unsafe float currentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_currentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooRenderAnimator.NativeFieldInfoPtr_currentTime)) = value;
			}
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr__UnitView_k__BackingField;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr__UnitPosition_k__BackingField;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_parentToDestination;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_normalizeScale;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_worldspaceStartPosition;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_worldspaceDestinationPosition;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_maxDuration;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_destTransform;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_destRelativeTransform;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_initialDestGlobalTransform;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_startTransform;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_startRelativeTransform;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_initialStartGlobalTransform;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_scratchConfig;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_playing;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_complete;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_unblocked;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_currentTime;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitView_Public_get_UnitView_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_set_UnitView_Private_set_Void_UnitView_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitPosition_Public_get_UnitPosition_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_set_UnitPosition_Private_set_Void_UnitPosition_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Event_Unblock_Public_Void_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_Event_Complete_Public_Void_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
