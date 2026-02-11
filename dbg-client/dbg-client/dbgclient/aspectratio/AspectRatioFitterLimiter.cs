using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace dbgclient.aspectratio
{
	// Token: 0x020000DF RID: 223
	public class AspectRatioFitterLimiter : MonoBehaviour
	{
		// Token: 0x06000993 RID: 2451 RVA: 0x0003BBB8 File Offset: 0x00039DB8
		// Note: this type is marked as 'beforefieldinit'.
		static AspectRatioFitterLimiter()
		{
			Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.aspectratio", "AspectRatioFitterLimiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr);
			AspectRatioFitterLimiter.NativeFieldInfoPtr_respectSafeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "respectSafeArea");
			AspectRatioFitterLimiter.NativeFieldInfoPtr__configLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "_configLoader");
			AspectRatioFitterLimiter.NativeFieldInfoPtr__cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "_cachedVersion");
			AspectRatioFitterLimiter.NativeFieldInfoPtr__started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "_started");
			AspectRatioFitterLimiter.NativeFieldInfoPtr__fitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "_fitter");
			AspectRatioFitterLimiter.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "_rectTransform");
			AspectRatioFitterLimiter.NativeFieldInfoPtr__lastOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "_lastOrientation");
			AspectRatioFitterLimiter.NativeFieldInfoPtr__recalculateAfterSafeAreaChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "_recalculateAfterSafeAreaChange");
			AspectRatioFitterLimiter.NativeMethodInfoPtr_get_Fitter_Private_get_AspectRatioFitter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664698);
			AspectRatioFitterLimiter.NativeMethodInfoPtr_get_Rect_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664699);
			AspectRatioFitterLimiter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664700);
			AspectRatioFitterLimiter.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664701);
			AspectRatioFitterLimiter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664702);
			AspectRatioFitterLimiter.NativeMethodInfoPtr_RecalculateAndSetAspectRatio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664703);
			AspectRatioFitterLimiter.NativeMethodInfoPtr_UpdateSafeAreaNextFrame_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664704);
			AspectRatioFitterLimiter.NativeMethodInfoPtr_RecalculateAfterSafeAreaChange_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664705);
			AspectRatioFitterLimiter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, 100664706);
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0003BD3C File Offset: 0x00039F3C
		public unsafe AspectRatioFitter Fitter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506088, XrefRangeEnd = 506092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr_get_Fitter_Private_get_AspectRatioFitter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AspectRatioFitter>(intPtr3) : null;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0003BD7C File Offset: 0x00039F7C
		public unsafe RectTransform Rect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 506096, RefRangeEnd = 506098, XrefRangeStart = 506092, XrefRangeEnd = 506096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr_get_Rect_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0003BDBC File Offset: 0x00039FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506098, XrefRangeEnd = 506102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0003BDF0 File Offset: 0x00039FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506102, XrefRangeEnd = 506113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0003BE24 File Offset: 0x0003A024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506113, XrefRangeEnd = 506114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0003BE58 File Offset: 0x0003A058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 506154, RefRangeEnd = 506156, XrefRangeStart = 506114, XrefRangeEnd = 506154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateAndSetAspectRatio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr_RecalculateAndSetAspectRatio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0003BE8C File Offset: 0x0003A08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506156, XrefRangeEnd = 506161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateSafeAreaNextFrame(float targetRatio)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetRatio;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr_UpdateSafeAreaNextFrame_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0003BED8 File Offset: 0x0003A0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506161, XrefRangeEnd = 506166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RecalculateAfterSafeAreaChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr_RecalculateAfterSafeAreaChange_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0003BF18 File Offset: 0x0003A118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506167, RefRangeEnd = 506168, XrefRangeStart = 506166, XrefRangeEnd = 506167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AspectRatioFitterLimiter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000068B3 File Offset: 0x00004AB3
		public AspectRatioFitterLimiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0003BF54 File Offset: 0x0003A154
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x000068BC File Offset: 0x00004ABC
		public unsafe bool respectSafeArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr_respectSafeArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr_respectSafeArea)) = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0003BF7C File Offset: 0x0003A17C
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x000068D7 File Offset: 0x00004AD7
		public unsafe AspectRatioConfigurationLoader _configLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__configLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioConfigurationLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__configLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0003BFAC File Offset: 0x0003A1AC
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x000068F6 File Offset: 0x00004AF6
		public unsafe ulong _cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__cachedVersion)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0003BFD4 File Offset: 0x0003A1D4
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00006911 File Offset: 0x00004B11
		public unsafe bool _started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__started)) = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0003BFFC File Offset: 0x0003A1FC
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0000692C File Offset: 0x00004B2C
		public unsafe AspectRatioFitter _fitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__fitter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioFitter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__fitter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0003C02C File Offset: 0x0003A22C
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x0000694B File Offset: 0x00004B4B
		public unsafe RectTransform _rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0003C05C File Offset: 0x0003A25C
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x0000696A File Offset: 0x00004B6A
		public unsafe DeviceOrientation _lastOrientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__lastOrientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__lastOrientation)) = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0003C084 File Offset: 0x0003A284
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00006985 File Offset: 0x00004B85
		public unsafe Coroutine _recalculateAfterSafeAreaChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__recalculateAfterSafeAreaChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter.NativeFieldInfoPtr__recalculateAfterSafeAreaChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_respectSafeArea;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr__configLoader;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr__cachedVersion;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr__started;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr__fitter;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr__rectTransform;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr__lastOrientation;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr__recalculateAfterSafeAreaChange;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_Fitter_Private_get_AspectRatioFitter_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_get_Rect_Private_get_RectTransform_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Private_Void_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateAndSetAspectRatio_Private_Void_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSafeAreaNextFrame_Private_IEnumerator_Single_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateAfterSafeAreaChange_Private_IEnumerator_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000331 RID: 817
		[ObfuscatedName("dbgclient.aspectratio.AspectRatioFitterLimiter+<RecalculateAfterSafeAreaChange>d__17")]
		public sealed class _RecalculateAfterSafeAreaChange_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x06002698 RID: 9880 RVA: 0x0009BF40 File Offset: 0x0009A140
			// Note: this type is marked as 'beforefieldinit'.
			static _RecalculateAfterSafeAreaChange_d__17()
			{
				Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "<RecalculateAfterSafeAreaChange>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr);
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, "<>1__state");
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, "<>2__current");
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, "<>4__this");
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr__originalSafeArea_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, "<originalSafeArea>5__2");
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, 100664707);
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, 100664708);
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, 100664709);
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, 100664710);
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, 100664711);
				AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr, 100664712);
			}

			// Token: 0x06002699 RID: 9881 RVA: 0x0009C034 File Offset: 0x0009A234
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RecalculateAfterSafeAreaChange_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600269A RID: 9882 RVA: 0x0009C07C File Offset: 0x0009A27C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600269B RID: 9883 RVA: 0x0009C0B0 File Offset: 0x0009A2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506072, XrefRangeEnd = 506076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AB4 RID: 2740
			// (get) Token: 0x0600269C RID: 9884 RVA: 0x0009C0EC File Offset: 0x0009A2EC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600269D RID: 9885 RVA: 0x0009C12C File Offset: 0x0009A32C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506076, XrefRangeEnd = 506081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AB5 RID: 2741
			// (get) Token: 0x0600269E RID: 9886 RVA: 0x0009C160 File Offset: 0x0009A360
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600269F RID: 9887 RVA: 0x00013FFD File Offset: 0x000121FD
			public _RecalculateAfterSafeAreaChange_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB0 RID: 2736
			// (get) Token: 0x060026A0 RID: 9888 RVA: 0x0009C1A0 File Offset: 0x0009A3A0
			// (set) Token: 0x060026A1 RID: 9889 RVA: 0x00014006 File Offset: 0x00012206
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AB1 RID: 2737
			// (get) Token: 0x060026A2 RID: 9890 RVA: 0x0009C1C8 File Offset: 0x0009A3C8
			// (set) Token: 0x060026A3 RID: 9891 RVA: 0x00014021 File Offset: 0x00012221
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB2 RID: 2738
			// (get) Token: 0x060026A4 RID: 9892 RVA: 0x0009C1F8 File Offset: 0x0009A3F8
			// (set) Token: 0x060026A5 RID: 9893 RVA: 0x00014040 File Offset: 0x00012240
			public unsafe AspectRatioFitterLimiter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioFitterLimiter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB3 RID: 2739
			// (get) Token: 0x060026A6 RID: 9894 RVA: 0x0009C228 File Offset: 0x0009A428
			// (set) Token: 0x060026A7 RID: 9895 RVA: 0x0001405F File Offset: 0x0001225F
			public unsafe Rect _originalSafeArea_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr__originalSafeArea_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._RecalculateAfterSafeAreaChange_d__17.NativeFieldInfoPtr__originalSafeArea_5__2)) = value;
				}
			}

			// Token: 0x0400182F RID: 6191
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001830 RID: 6192
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001831 RID: 6193
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001832 RID: 6194
			private static readonly IntPtr NativeFieldInfoPtr__originalSafeArea_5__2;

			// Token: 0x04001833 RID: 6195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001834 RID: 6196
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001835 RID: 6197
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001836 RID: 6198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001837 RID: 6199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001838 RID: 6200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000332 RID: 818
		[ObfuscatedName("dbgclient.aspectratio.AspectRatioFitterLimiter+<UpdateSafeAreaNextFrame>d__16")]
		public sealed class _UpdateSafeAreaNextFrame_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x060026A8 RID: 9896 RVA: 0x0009C250 File Offset: 0x0009A450
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateSafeAreaNextFrame_d__16()
			{
				Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AspectRatioFitterLimiter>.NativeClassPtr, "<UpdateSafeAreaNextFrame>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr);
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, "<>1__state");
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, "<>2__current");
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, "<>4__this");
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr_targetRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, "targetRatio");
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, 100664713);
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, 100664714);
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, 100664715);
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, 100664716);
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, 100664717);
				AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr, 100664718);
			}

			// Token: 0x060026A9 RID: 9897 RVA: 0x0009C344 File Offset: 0x0009A544
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateSafeAreaNextFrame_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026AA RID: 9898 RVA: 0x0009C38C File Offset: 0x0009A58C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026AB RID: 9899 RVA: 0x0009C3C0 File Offset: 0x0009A5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506081, XrefRangeEnd = 506083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ABA RID: 2746
			// (get) Token: 0x060026AC RID: 9900 RVA: 0x0009C3FC File Offset: 0x0009A5FC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026AD RID: 9901 RVA: 0x0009C43C File Offset: 0x0009A63C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506083, XrefRangeEnd = 506088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ABB RID: 2747
			// (get) Token: 0x060026AE RID: 9902 RVA: 0x0009C470 File Offset: 0x0009A670
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026AF RID: 9903 RVA: 0x0001407A File Offset: 0x0001227A
			public _UpdateSafeAreaNextFrame_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB6 RID: 2742
			// (get) Token: 0x060026B0 RID: 9904 RVA: 0x0009C4B0 File Offset: 0x0009A6B0
			// (set) Token: 0x060026B1 RID: 9905 RVA: 0x00014083 File Offset: 0x00012283
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AB7 RID: 2743
			// (get) Token: 0x060026B2 RID: 9906 RVA: 0x0009C4D8 File Offset: 0x0009A6D8
			// (set) Token: 0x060026B3 RID: 9907 RVA: 0x0001409E File Offset: 0x0001229E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB8 RID: 2744
			// (get) Token: 0x060026B4 RID: 9908 RVA: 0x0009C508 File Offset: 0x0009A708
			// (set) Token: 0x060026B5 RID: 9909 RVA: 0x000140BD File Offset: 0x000122BD
			public unsafe AspectRatioFitterLimiter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioFitterLimiter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB9 RID: 2745
			// (get) Token: 0x060026B6 RID: 9910 RVA: 0x0009C538 File Offset: 0x0009A738
			// (set) Token: 0x060026B7 RID: 9911 RVA: 0x000140DC File Offset: 0x000122DC
			public unsafe float targetRatio
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr_targetRatio);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitterLimiter._UpdateSafeAreaNextFrame_d__16.NativeFieldInfoPtr_targetRatio)) = value;
				}
			}

			// Token: 0x04001839 RID: 6201
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400183A RID: 6202
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400183B RID: 6203
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400183C RID: 6204
			private static readonly IntPtr NativeFieldInfoPtr_targetRatio;

			// Token: 0x0400183D RID: 6205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400183E RID: 6206
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400183F RID: 6207
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001840 RID: 6208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001841 RID: 6209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001842 RID: 6210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
