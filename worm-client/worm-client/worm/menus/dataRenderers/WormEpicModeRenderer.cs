using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000082 RID: 130
	public class WormEpicModeRenderer : VersionedSubscriber<PendingGameData>
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00028350 File Offset: 0x00026550
		// Note: this type is marked as 'beforefieldinit'.
		static WormEpicModeRenderer()
		{
			Il2CppClassPointerStore<WormEpicModeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEpicModeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEpicModeRenderer>.NativeClassPtr);
			WormEpicModeRenderer.NativeFieldInfoPtr_epicIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEpicModeRenderer>.NativeClassPtr, "epicIcon");
			WormEpicModeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEpicModeRenderer>.NativeClassPtr, 100664026);
			WormEpicModeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEpicModeRenderer>.NativeClassPtr, 100664027);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000283BC File Offset: 0x000265BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694658, XrefRangeEnd = 694669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEpicModeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000283F8 File Offset: 0x000265F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694669, XrefRangeEnd = 694672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEpicModeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEpicModeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEpicModeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000479D File Offset: 0x0000299D
		public WormEpicModeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00028434 File Offset: 0x00026634
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x000047A6 File Offset: 0x000029A6
		public unsafe GameObject epicIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEpicModeRenderer.NativeFieldInfoPtr_epicIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEpicModeRenderer.NativeFieldInfoPtr_epicIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_epicIcon;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
