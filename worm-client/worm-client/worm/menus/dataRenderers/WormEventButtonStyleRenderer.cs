using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000085 RID: 133
	public class WormEventButtonStyleRenderer : Subscriber<WormEventData>
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x000287AC File Offset: 0x000269AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventButtonStyleRenderer()
		{
			Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventButtonStyleRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr);
			WormEventButtonStyleRenderer.NativeFieldInfoPtr_defaultStyleParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, "defaultStyleParent");
			WormEventButtonStyleRenderer.NativeFieldInfoPtr_warningStyleParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, "warningStyleParent");
			WormEventButtonStyleRenderer.NativeFieldInfoPtr_completedStyleParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, "completedStyleParent");
			WormEventButtonStyleRenderer.NativeFieldInfoPtr_activeStyleRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, "activeStyleRoot");
			WormEventButtonStyleRenderer.NativeFieldInfoPtr_selectedStyleParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, "selectedStyleParent");
			WormEventButtonStyleRenderer.NativeFieldInfoPtr_inWarningState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, "inWarningState");
			WormEventButtonStyleRenderer.NativeMethodInfoPtr_get_InWarningState_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, 100664047);
			WormEventButtonStyleRenderer.NativeMethodInfoPtr_set_InWarningState_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, 100664048);
			WormEventButtonStyleRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, 100664049);
			WormEventButtonStyleRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, 100664050);
			WormEventButtonStyleRenderer.NativeMethodInfoPtr_SetStyle_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, 100664051);
			WormEventButtonStyleRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr, 100664052);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x000288CC File Offset: 0x00026ACC
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00028908 File Offset: 0x00026B08
		public unsafe bool InWarningState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonStyleRenderer.NativeMethodInfoPtr_get_InWarningState_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694860, XrefRangeEnd = 694861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonStyleRenderer.NativeMethodInfoPtr_set_InWarningState_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00028948 File Offset: 0x00026B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694861, XrefRangeEnd = 694862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventButtonStyleRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00028984 File Offset: 0x00026B84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 694877, RefRangeEnd = 694879, XrefRangeStart = 694862, XrefRangeEnd = 694877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonStyleRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000289B8 File Offset: 0x00026BB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 694891, RefRangeEnd = 694894, XrefRangeStart = 694879, XrefRangeEnd = 694891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStyle(Transform styleParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(styleParent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonStyleRenderer.NativeMethodInfoPtr_SetStyle_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000289FC File Offset: 0x00026BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694894, XrefRangeEnd = 694897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventButtonStyleRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventButtonStyleRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonStyleRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00004853 File Offset: 0x00002A53
		public WormEventButtonStyleRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00028A38 File Offset: 0x00026C38
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0000485C File Offset: 0x00002A5C
		public unsafe Transform defaultStyleParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_defaultStyleParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_defaultStyleParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00028A68 File Offset: 0x00026C68
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x0000487B File Offset: 0x00002A7B
		public unsafe Transform warningStyleParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_warningStyleParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_warningStyleParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00028A98 File Offset: 0x00026C98
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x0000489A File Offset: 0x00002A9A
		public unsafe Transform completedStyleParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_completedStyleParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_completedStyleParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00028AC8 File Offset: 0x00026CC8
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000048B9 File Offset: 0x00002AB9
		public unsafe Transform activeStyleRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_activeStyleRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_activeStyleRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00028AF8 File Offset: 0x00026CF8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000048D8 File Offset: 0x00002AD8
		public unsafe Transform selectedStyleParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_selectedStyleParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_selectedStyleParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00028B28 File Offset: 0x00026D28
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000048F7 File Offset: 0x00002AF7
		public unsafe bool inWarningState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_inWarningState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonStyleRenderer.NativeFieldInfoPtr_inWarningState)) = value;
			}
		}

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_defaultStyleParent;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_warningStyleParent;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_completedStyleParent;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_activeStyleRoot;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_selectedStyleParent;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_inWarningState;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_InWarningState_Public_get_Boolean_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_set_InWarningState_Public_set_Void_Boolean_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_SetStyle_Private_Void_Transform_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
