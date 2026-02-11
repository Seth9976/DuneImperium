using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dbgclient.aspectratio
{
	// Token: 0x020000E1 RID: 225
	public class CanvasScalerRatioAdjuster : MonoBehaviour
	{
		// Token: 0x060009BD RID: 2493 RVA: 0x0003C300 File Offset: 0x0003A500
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScalerRatioAdjuster()
		{
			Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.aspectratio", "CanvasScalerRatioAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr);
			CanvasScalerRatioAdjuster.NativeFieldInfoPtr_respectSafeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr, "respectSafeArea");
			CanvasScalerRatioAdjuster.NativeFieldInfoPtr__configLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr, "_configLoader");
			CanvasScalerRatioAdjuster.NativeFieldInfoPtr__cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr, "_cachedVersion");
			CanvasScalerRatioAdjuster.NativeFieldInfoPtr__canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr, "_canvasScaler");
			CanvasScalerRatioAdjuster.NativeFieldInfoPtr__lastRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr, "_lastRatio");
			CanvasScalerRatioAdjuster.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr, 100664722);
			CanvasScalerRatioAdjuster.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr, 100664723);
			CanvasScalerRatioAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr, 100664724);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0003C3D0 File Offset: 0x0003A5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506187, XrefRangeEnd = 506191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerRatioAdjuster.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0003C404 File Offset: 0x0003A604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506191, XrefRangeEnd = 506203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerRatioAdjuster.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0003C438 File Offset: 0x0003A638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506167, RefRangeEnd = 506168, XrefRangeStart = 506167, XrefRangeEnd = 506168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScalerRatioAdjuster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScalerRatioAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerRatioAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00006A3C File Offset: 0x00004C3C
		public CanvasScalerRatioAdjuster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0003C474 File Offset: 0x0003A674
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00006A45 File Offset: 0x00004C45
		public unsafe bool respectSafeArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr_respectSafeArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr_respectSafeArea)) = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0003C49C File Offset: 0x0003A69C
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00006A60 File Offset: 0x00004C60
		public unsafe AspectRatioConfigurationLoader _configLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr__configLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioConfigurationLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr__configLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0003C4CC File Offset: 0x0003A6CC
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00006A7F File Offset: 0x00004C7F
		public unsafe ulong _cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr__cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr__cachedVersion)) = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0003C4F4 File Offset: 0x0003A6F4
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00006A9A File Offset: 0x00004C9A
		public unsafe CanvasScaler _canvasScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr__canvasScaler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasScaler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr__canvasScaler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0003C524 File Offset: 0x0003A724
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00006AB9 File Offset: 0x00004CB9
		public unsafe float _lastRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr__lastRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerRatioAdjuster.NativeFieldInfoPtr__lastRatio)) = value;
			}
		}

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_respectSafeArea;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr__configLoader;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr__cachedVersion;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr__canvasScaler;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr__lastRatio;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
