using System;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.camera
{
	// Token: 0x020000A5 RID: 165
	public class ScreenBorders : VersionedModel
	{
		// Token: 0x06000B0E RID: 2830 RVA: 0x0003DA08 File Offset: 0x0003BC08
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenBorders()
		{
			Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.camera", "ScreenBorders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr);
			ScreenBorders.NativeFieldInfoPtr_unsafeCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "unsafeCamera");
			ScreenBorders.NativeFieldInfoPtr_unsafeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "unsafeLeft");
			ScreenBorders.NativeFieldInfoPtr_unsafeRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "unsafeRight");
			ScreenBorders.NativeFieldInfoPtr_unsafeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "unsafeTop");
			ScreenBorders.NativeFieldInfoPtr_unsafeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "unsafeBottom");
			ScreenBorders.NativeFieldInfoPtr_unsafeScreenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "unsafeScreenWidth");
			ScreenBorders.NativeFieldInfoPtr_unsafeScreenHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "unsafeScreenHeight");
			ScreenBorders.NativeFieldInfoPtr_unsafeCamRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "unsafeCamRect");
			ScreenBorders.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "rect");
			ScreenBorders.NativeFieldInfoPtr_cachedRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "cachedRect");
			ScreenBorders.NativeMethodInfoPtr_get_Camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664838);
			ScreenBorders.NativeMethodInfoPtr_set_Camera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664839);
			ScreenBorders.NativeMethodInfoPtr_get_Left_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664840);
			ScreenBorders.NativeMethodInfoPtr_set_Left_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664841);
			ScreenBorders.NativeMethodInfoPtr_get_Right_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664842);
			ScreenBorders.NativeMethodInfoPtr_set_Right_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664843);
			ScreenBorders.NativeMethodInfoPtr_get_Top_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664844);
			ScreenBorders.NativeMethodInfoPtr_set_Top_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664845);
			ScreenBorders.NativeMethodInfoPtr_get_Bottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664846);
			ScreenBorders.NativeMethodInfoPtr_set_Bottom_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664847);
			ScreenBorders.NativeMethodInfoPtr_get_screenWidth_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664848);
			ScreenBorders.NativeMethodInfoPtr_set_screenWidth_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664849);
			ScreenBorders.NativeMethodInfoPtr_get_screenHeight_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664850);
			ScreenBorders.NativeMethodInfoPtr_set_screenHeight_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664851);
			ScreenBorders.NativeMethodInfoPtr_get_camRect_Private_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664852);
			ScreenBorders.NativeMethodInfoPtr_set_camRect_Private_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664853);
			ScreenBorders.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664854);
			ScreenBorders.NativeMethodInfoPtr_get_Rect_Public_get_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664855);
			ScreenBorders.NativeMethodInfoPtr_recalculateRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664856);
			ScreenBorders.NativeMethodInfoPtr_DrawGizmos_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664857);
			ScreenBorders.NativeMethodInfoPtr_DrawGizmos_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664858);
			ScreenBorders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, 100664859);
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0003DCB8 File Offset: 0x0003BEB8
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x0003DCF8 File Offset: 0x0003BEF8
		public unsafe Camera Camera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_Camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863452, XrefRangeEnd = 863458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_set_Camera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0003DD3C File Offset: 0x0003BF3C
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x0003DD78 File Offset: 0x0003BF78
		public unsafe int Left
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_Left_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863458, XrefRangeEnd = 863459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_set_Left_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0003DDB8 File Offset: 0x0003BFB8
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x0003DDF4 File Offset: 0x0003BFF4
		public unsafe int Right
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_Right_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863459, XrefRangeEnd = 863460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_set_Right_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0003DE34 File Offset: 0x0003C034
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0003DE70 File Offset: 0x0003C070
		public unsafe int Top
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_Top_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863460, XrefRangeEnd = 863461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_set_Top_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0003DEB0 File Offset: 0x0003C0B0
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0003DEEC File Offset: 0x0003C0EC
		public unsafe int Bottom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_Bottom_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863461, XrefRangeEnd = 863462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_set_Bottom_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0003DF2C File Offset: 0x0003C12C
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0003DF68 File Offset: 0x0003C168
		public unsafe int screenWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_screenWidth_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863462, XrefRangeEnd = 863463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_set_screenWidth_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0003DFA8 File Offset: 0x0003C1A8
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0003DFE4 File Offset: 0x0003C1E4
		public unsafe int screenHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_screenHeight_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863463, XrefRangeEnd = 863464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_set_screenHeight_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0003E024 File Offset: 0x0003C224
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x0003E060 File Offset: 0x0003C260
		public unsafe Rect camRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_camRect_Private_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863464, XrefRangeEnd = 863465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_set_camRect_Private_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0003E0A0 File Offset: 0x0003C2A0
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863465, XrefRangeEnd = 863477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenBorders.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0003E0E8 File Offset: 0x0003C2E8
		public unsafe ScreenRect Rect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863477, XrefRangeEnd = 863478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_get_Rect_Public_get_ScreenRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0003E124 File Offset: 0x0003C324
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 863483, RefRangeEnd = 863487, XrefRangeStart = 863478, XrefRangeEnd = 863483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void recalculateRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_recalculateRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0003E158 File Offset: 0x0003C358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863487, XrefRangeEnd = 863488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawGizmos(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_DrawGizmos_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0003E198 File Offset: 0x0003C398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863527, RefRangeEnd = 863528, XrefRangeStart = 863488, XrefRangeEnd = 863527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawGizmos(Color color, float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr_DrawGizmos_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0003E1E4 File Offset: 0x0003C3E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862016, RefRangeEnd = 862018, XrefRangeStart = 862016, XrefRangeEnd = 862018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenBorders()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00005E8D File Offset: 0x0000408D
		public ScreenBorders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0003E220 File Offset: 0x0003C420
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00005E96 File Offset: 0x00004096
		public unsafe Camera unsafeCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0003E250 File Offset: 0x0003C450
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x00005EB5 File Offset: 0x000040B5
		public unsafe int unsafeLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeLeft)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0003E278 File Offset: 0x0003C478
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x00005ED0 File Offset: 0x000040D0
		public unsafe int unsafeRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeRight)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0003E2A0 File Offset: 0x0003C4A0
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x00005EEB File Offset: 0x000040EB
		public unsafe int unsafeTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeTop)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00005F06 File Offset: 0x00004106
		public unsafe int unsafeBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeBottom)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0003E2F0 File Offset: 0x0003C4F0
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00005F21 File Offset: 0x00004121
		public unsafe int unsafeScreenWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeScreenWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeScreenWidth)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0003E318 File Offset: 0x0003C518
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00005F3C File Offset: 0x0000413C
		public unsafe int unsafeScreenHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeScreenHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeScreenHeight)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0003E340 File Offset: 0x0003C540
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00005F57 File Offset: 0x00004157
		public unsafe Rect unsafeCamRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeCamRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_unsafeCamRect)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0003E368 File Offset: 0x0003C568
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00005F72 File Offset: 0x00004172
		public unsafe ScreenRect rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_rect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_rect)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0003E390 File Offset: 0x0003C590
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00005F8D File Offset: 0x0000418D
		public unsafe ulong cachedRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_cachedRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.NativeFieldInfoPtr_cachedRect)) = value;
			}
		}

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr_unsafeCamera;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeFieldInfoPtr_unsafeLeft;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr_unsafeRight;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_unsafeTop;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_unsafeBottom;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr_unsafeScreenWidth;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeFieldInfoPtr_unsafeScreenHeight;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeFieldInfoPtr_unsafeCamRect;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr_cachedRect;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Public_get_Camera_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_set_Camera_Public_set_Void_Camera_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_Int32_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_set_Left_Public_set_Void_Int32_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Int32_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_set_Right_Public_set_Void_Int32_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_get_Top_Public_get_Int32_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_set_Top_Public_set_Void_Int32_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_get_Bottom_Public_get_Int32_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_set_Bottom_Public_set_Void_Int32_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_get_screenWidth_Private_get_Int32_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_set_screenWidth_Private_set_Void_Int32_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_get_screenHeight_Private_get_Int32_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_set_screenHeight_Private_set_Void_Int32_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_get_camRect_Private_get_Rect_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_set_camRect_Private_set_Void_Rect_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_get_Rect_Public_get_ScreenRect_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_recalculateRect_Private_Void_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Public_Void_Color_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Public_Void_Color_Single_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000294 RID: 660
		[ObfuscatedName("dwd.core.camera.ScreenBorders+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001F73 RID: 8051 RVA: 0x0008EAEC File Offset: 0x0008CCEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<ScreenBorders.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenBorders>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenBorders.__c__DisplayClass40_0>.NativeClassPtr);
				ScreenBorders.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
				ScreenBorders.__c__DisplayClass40_0.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBorders.__c__DisplayClass40_0>.NativeClassPtr, "depth");
				ScreenBorders.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders.__c__DisplayClass40_0>.NativeClassPtr, 100664860);
				ScreenBorders.__c__DisplayClass40_0.NativeMethodInfoPtr__DrawGizmos_b__0_Internal_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBorders.__c__DisplayClass40_0>.NativeClassPtr, 100664861);
			}

			// Token: 0x06001F74 RID: 8052 RVA: 0x0008EB68 File Offset: 0x0008CD68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenBorders.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F75 RID: 8053 RVA: 0x0008EBA4 File Offset: 0x0008CDA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863450, XrefRangeEnd = 863452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DrawGizmos_b__0(Vector2 point)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref point;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenBorders.__c__DisplayClass40_0.NativeMethodInfoPtr__DrawGizmos_b__0_Internal_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F76 RID: 8054 RVA: 0x0000D68D File Offset: 0x0000B88D
			public __c__DisplayClass40_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x06001F77 RID: 8055 RVA: 0x0008EBF0 File Offset: 0x0008CDF0
			// (set) Token: 0x06001F78 RID: 8056 RVA: 0x0000D696 File Offset: 0x0000B896
			public unsafe ScreenBorders __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenBorders>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0008EC20 File Offset: 0x0008CE20
			// (set) Token: 0x06001F7A RID: 8058 RVA: 0x0000D6B5 File Offset: 0x0000B8B5
			public unsafe float depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.__c__DisplayClass40_0.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenBorders.__c__DisplayClass40_0.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x04001610 RID: 5648
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001611 RID: 5649
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x04001612 RID: 5650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001613 RID: 5651
			private static readonly IntPtr NativeMethodInfoPtr__DrawGizmos_b__0_Internal_Vector3_Vector2_0;
		}
	}
}
