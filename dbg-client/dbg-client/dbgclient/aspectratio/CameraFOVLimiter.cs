using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbgclient.aspectratio
{
	// Token: 0x020000E0 RID: 224
	public class CameraFOVLimiter : MonoBehaviour
	{
		// Token: 0x060009AE RID: 2478 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
		// Note: this type is marked as 'beforefieldinit'.
		static CameraFOVLimiter()
		{
			Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.aspectratio", "CameraFOVLimiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr);
			CameraFOVLimiter.NativeFieldInfoPtr_respectSafeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr, "respectSafeArea");
			CameraFOVLimiter.NativeFieldInfoPtr__configLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr, "_configLoader");
			CameraFOVLimiter.NativeFieldInfoPtr__cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr, "_cachedVersion");
			CameraFOVLimiter.NativeFieldInfoPtr__targetCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr, "_targetCamera");
			CameraFOVLimiter.NativeFieldInfoPtr__lastRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr, "_lastRatio");
			CameraFOVLimiter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr, 100664719);
			CameraFOVLimiter.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr, 100664720);
			CameraFOVLimiter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr, 100664721);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0003C184 File Offset: 0x0003A384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506168, XrefRangeEnd = 506172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFOVLimiter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0003C1B8 File Offset: 0x0003A3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506172, XrefRangeEnd = 506187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFOVLimiter.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0003C1EC File Offset: 0x0003A3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506167, RefRangeEnd = 506168, XrefRangeStart = 506167, XrefRangeEnd = 506168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraFOVLimiter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraFOVLimiter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraFOVLimiter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000069A4 File Offset: 0x00004BA4
		public CameraFOVLimiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0003C228 File Offset: 0x0003A428
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000069AD File Offset: 0x00004BAD
		public unsafe bool respectSafeArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr_respectSafeArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr_respectSafeArea)) = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0003C250 File Offset: 0x0003A450
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000069C8 File Offset: 0x00004BC8
		public unsafe AspectRatioConfigurationLoader _configLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr__configLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioConfigurationLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr__configLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0003C280 File Offset: 0x0003A480
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x000069E7 File Offset: 0x00004BE7
		public unsafe ulong _cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr__cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr__cachedVersion)) = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0003C2A8 File Offset: 0x0003A4A8
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00006A02 File Offset: 0x00004C02
		public unsafe Camera _targetCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr__targetCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr__targetCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00006A21 File Offset: 0x00004C21
		public unsafe float _lastRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr__lastRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraFOVLimiter.NativeFieldInfoPtr__lastRatio)) = value;
			}
		}

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeFieldInfoPtr_respectSafeArea;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeFieldInfoPtr__configLoader;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeFieldInfoPtr__cachedVersion;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeFieldInfoPtr__targetCamera;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeFieldInfoPtr__lastRatio;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
