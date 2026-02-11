using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000081 RID: 129
	public class WormChallengeProgressStatusRenderer : VersionedSubscriber<ProgressionData>
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x0002812C File Offset: 0x0002632C
		// Note: this type is marked as 'beforefieldinit'.
		static WormChallengeProgressStatusRenderer()
		{
			Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormChallengeProgressStatusRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr);
			WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr, "lockedObject");
			WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedROIObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr, "lockedROIObject");
			WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedImmoObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr, "lockedImmoObject");
			WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_completedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr, "completedObject");
			WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr, "button");
			WormChallengeProgressStatusRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr, 100664024);
			WormChallengeProgressStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr, 100664025);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000281E8 File Offset: 0x000263E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694632, XrefRangeEnd = 694655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChallengeProgressStatusRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00028224 File Offset: 0x00026424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694655, XrefRangeEnd = 694658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChallengeProgressStatusRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengeProgressStatusRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000046F9 File Offset: 0x000028F9
		public WormChallengeProgressStatusRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00028260 File Offset: 0x00026460
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004702 File Offset: 0x00002902
		public unsafe GameObject lockedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00028290 File Offset: 0x00026490
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00004721 File Offset: 0x00002921
		public unsafe GameObject lockedROIObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedROIObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedROIObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000282C0 File Offset: 0x000264C0
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00004740 File Offset: 0x00002940
		public unsafe GameObject lockedImmoObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedImmoObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_lockedImmoObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000282F0 File Offset: 0x000264F0
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x0000475F File Offset: 0x0000295F
		public unsafe GameObject completedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_completedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_completedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00028320 File Offset: 0x00026520
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0000477E File Offset: 0x0000297E
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressStatusRenderer.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_lockedObject;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_lockedROIObject;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_lockedImmoObject;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_completedObject;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
