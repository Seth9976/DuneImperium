using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace lotus
{
	// Token: 0x020000CB RID: 203
	public class CameraUpdateManager : MonoBehaviour
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00030B70 File Offset: 0x0002ED70
		// Note: this type is marked as 'beforefieldinit'.
		static CameraUpdateManager()
		{
			Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "CameraUpdateManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr);
			CameraUpdateManager.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr, "cam");
			CameraUpdateManager.NativeFieldInfoPtr_cachedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr, "cachedPosition");
			CameraUpdateManager.NativeFieldInfoPtr_cachedFieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr, "cachedFieldOfView");
			CameraUpdateManager.NativeFieldInfoPtr_onCameraUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr, "onCameraUpdate");
			CameraUpdateManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr, 100664911);
			CameraUpdateManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr, 100664912);
			CameraUpdateManager.NativeMethodInfoPtr_cameraUpdated_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr, 100664913);
			CameraUpdateManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr, 100664914);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00030C40 File Offset: 0x0002EE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993387, XrefRangeEnd = 993389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUpdateManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00030C74 File Offset: 0x0002EE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993389, XrefRangeEnd = 993400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUpdateManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00030CA8 File Offset: 0x0002EEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993400, XrefRangeEnd = 993403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool cameraUpdated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUpdateManager.NativeMethodInfoPtr_cameraUpdated_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00030CE4 File Offset: 0x0002EEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993403, XrefRangeEnd = 993409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraUpdateManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraUpdateManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUpdateManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000067D0 File Offset: 0x000049D0
		public CameraUpdateManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00030D20 File Offset: 0x0002EF20
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x000067D9 File Offset: 0x000049D9
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraUpdateManager.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraUpdateManager.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00030D50 File Offset: 0x0002EF50
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x000067F8 File Offset: 0x000049F8
		public unsafe Vector3 cachedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraUpdateManager.NativeFieldInfoPtr_cachedPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraUpdateManager.NativeFieldInfoPtr_cachedPosition)) = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00030D78 File Offset: 0x0002EF78
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00006813 File Offset: 0x00004A13
		public unsafe float cachedFieldOfView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraUpdateManager.NativeFieldInfoPtr_cachedFieldOfView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraUpdateManager.NativeFieldInfoPtr_cachedFieldOfView)) = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00030DA0 File Offset: 0x0002EFA0
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x0000682E File Offset: 0x00004A2E
		public unsafe UnityEvent onCameraUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraUpdateManager.NativeFieldInfoPtr_onCameraUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraUpdateManager.NativeFieldInfoPtr_onCameraUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_cachedPosition;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_cachedFieldOfView;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_onCameraUpdate;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_cameraUpdated_Private_Boolean_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
