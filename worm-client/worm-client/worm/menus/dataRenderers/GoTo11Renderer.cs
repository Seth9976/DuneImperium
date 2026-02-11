using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.menus.dataRenderers
{
	// Token: 0x0200007F RID: 127
	public class GoTo11Renderer : VersionedSubscriber<PendingGameData>
	{
		// Token: 0x060004EF RID: 1263 RVA: 0x00027F48 File Offset: 0x00026148
		// Note: this type is marked as 'beforefieldinit'.
		static GoTo11Renderer()
		{
			Il2CppClassPointerStore<GoTo11Renderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "GoTo11Renderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoTo11Renderer>.NativeClassPtr);
			GoTo11Renderer.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoTo11Renderer>.NativeClassPtr, "icon");
			GoTo11Renderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoTo11Renderer>.NativeClassPtr, 100664020);
			GoTo11Renderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoTo11Renderer>.NativeClassPtr, 100664021);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00027FB4 File Offset: 0x000261B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694527, XrefRangeEnd = 694533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoTo11Renderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00027FF0 File Offset: 0x000261F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694533, XrefRangeEnd = 694536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoTo11Renderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoTo11Renderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoTo11Renderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000046C8 File Offset: 0x000028C8
		public GoTo11Renderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0002802C File Offset: 0x0002622C
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000046D1 File Offset: 0x000028D1
		public unsafe GameObject icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoTo11Renderer.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoTo11Renderer.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
