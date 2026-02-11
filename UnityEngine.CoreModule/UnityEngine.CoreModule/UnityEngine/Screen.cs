using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008F RID: 143
	public sealed class Screen : Object
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x00030550 File Offset: 0x0002E750
		// Note: this type is marked as 'beforefieldinit'.
		static Screen()
		{
			Il2CppClassPointerStore<Screen>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Screen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Screen>.NativeClassPtr);
			Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664279);
			Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664280);
			Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664281);
			Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664282);
			Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664283);
			Screen.NativeMethodInfoPtr_set_sleepTimeout_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664284);
			Screen.NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664285);
			Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664286);
			Screen.NativeMethodInfoPtr_get_safeArea_Public_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664287);
			Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664288);
			Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664289);
			Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664290);
			Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664291);
			Screen.NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664292);
			Screen.NativeMethodInfoPtr_get_safeArea_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664293);
			Screen.NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664294);
			Screen.RequestOrientationDelegateField = IL2CPP.ResolveICall<Screen.RequestOrientationDelegate>("UnityEngine.Screen::RequestOrientation");
			Screen.get_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.get_sleepTimeoutDelegate>("UnityEngine.Screen::get_sleepTimeout");
			Screen.IsOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.IsOrientationEnabledDelegate>("UnityEngine.Screen::IsOrientationEnabled");
			Screen.SetOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.SetOrientationEnabledDelegate>("UnityEngine.Screen::SetOrientationEnabled");
			Screen.set_fullScreenDelegateField = IL2CPP.ResolveICall<Screen.set_fullScreenDelegate>("UnityEngine.Screen::set_fullScreen");
			Screen.get_fullScreenModeDelegateField = IL2CPP.ResolveICall<Screen.get_fullScreenModeDelegate>("UnityEngine.Screen::get_fullScreenMode");
			Screen.set_fullScreenModeDelegateField = IL2CPP.ResolveICall<Screen.set_fullScreenModeDelegate>("UnityEngine.Screen::set_fullScreenMode");
			Screen.get_cutoutsDelegateField = IL2CPP.ResolveICall<Screen.get_cutoutsDelegate>("UnityEngine.Screen::get_cutouts");
			Screen.get_brightnessDelegateField = IL2CPP.ResolveICall<Screen.get_brightnessDelegate>("UnityEngine.Screen::get_brightness");
			Screen.set_brightnessDelegateField = IL2CPP.ResolveICall<Screen.set_brightnessDelegate>("UnityEngine.Screen::set_brightness");
			Screen.GetMainWindowPosition_InjectedDelegateField = IL2CPP.ResolveICall<Screen.GetMainWindowPosition_InjectedDelegate>("UnityEngine.Screen::GetMainWindowPosition_Injected");
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00030768 File Offset: 0x0002E968
		public unsafe static int width
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 649445, RefRangeEnd = 649509, XrefRangeStart = 649443, XrefRangeEnd = 649445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00030798 File Offset: 0x0002E998
		public unsafe static int height
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 649511, RefRangeEnd = 649576, XrefRangeStart = 649509, XrefRangeEnd = 649511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x000307C8 File Offset: 0x0002E9C8
		public unsafe static float dpi
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 649578, RefRangeEnd = 649589, XrefRangeStart = 649576, XrefRangeEnd = 649578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000307F8 File Offset: 0x0002E9F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 649591, RefRangeEnd = 649594, XrefRangeStart = 649589, XrefRangeEnd = 649591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenOrientation GetScreenOrientation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00030828 File Offset: 0x0002EA28
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00030B1C File Offset: 0x0002ED1C
		public unsafe static ScreenOrientation orientation
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 649591, RefRangeEnd = 649594, XrefRangeStart = 649591, XrefRangeEnd = 649594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value == ScreenOrientation.Unknown;
				if (flag)
				{
					Debug.Log("ScreenOrientation.Unknown is deprecated. Please use ScreenOrientation.AutoRotation");
					value = ScreenOrientation.AutoRotation;
				}
				Screen.RequestOrientation(value);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000050CA File Offset: 0x000032CA
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00030858 File Offset: 0x0002EA58
		public unsafe static int sleepTimeout
		{
			get
			{
				return Screen.get_sleepTimeoutDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 649596, RefRangeEnd = 649597, XrefRangeStart = 649594, XrefRangeEnd = 649596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_set_sleepTimeout_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0003088C File Offset: 0x0002EA8C
		public unsafe static Resolution currentResolution
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 649599, RefRangeEnd = 649601, XrefRangeStart = 649597, XrefRangeEnd = 649599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x000308BC File Offset: 0x0002EABC
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x0000511D File Offset: 0x0000331D
		public unsafe static bool fullScreen
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 649603, RefRangeEnd = 649613, XrefRangeStart = 649601, XrefRangeEnd = 649603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Screen.set_fullScreenDelegateField(value);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x000308EC File Offset: 0x0002EAEC
		public unsafe static Rect safeArea
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 649615, RefRangeEnd = 649627, XrefRangeStart = 649613, XrefRangeEnd = 649615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_safeArea_Public_Static_get_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0003091C File Offset: 0x0002EB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649627, XrefRangeEnd = 649629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreenMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preferredRefreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00030978 File Offset: 0x0002EB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649629, XrefRangeEnd = 649631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preferredRefreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000309D4 File Offset: 0x0002EBD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649633, RefRangeEnd = 649634, XrefRangeStart = 649631, XrefRangeEnd = 649633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution(int width, int height, bool fullscreen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00030A24 File Offset: 0x0002EC24
		public unsafe static Il2CppStructArray<Resolution> resolutions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 649636, RefRangeEnd = 649638, XrefRangeStart = 649634, XrefRangeEnd = 649636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr3) : null;
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00030A58 File Offset: 0x0002EC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649638, XrefRangeEnd = 649640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_currentResolution_Injected(out Resolution ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00030A8C File Offset: 0x0002EC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649640, XrefRangeEnd = 649642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_safeArea_Injected(out Rect ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_safeArea_Injected_Private_Static_Void_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00030AC0 File Offset: 0x0002ECC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649642, XrefRangeEnd = 649644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreenMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &preferredRefreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000050B4 File Offset: 0x000032B4
		public Screen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000050BD File Offset: 0x000032BD
		public static void RequestOrientation(ScreenOrientation orient)
		{
			Screen.RequestOrientationDelegateField(orient);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000050D6 File Offset: 0x000032D6
		public static bool IsOrientationEnabled(EnabledOrientation orient)
		{
			return Screen.IsOrientationEnabledDelegateField(orient);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000050E3 File Offset: 0x000032E3
		public static void SetOrientationEnabled(EnabledOrientation orient, bool enabled)
		{
			Screen.SetOrientationEnabledDelegateField(orient, enabled);
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00030B4C File Offset: 0x0002ED4C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x000050F1 File Offset: 0x000032F1
		public static bool autorotateToPortrait
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortrait);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortrait, value);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00030B64 File Offset: 0x0002ED64
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x000050FC File Offset: 0x000032FC
		public static bool autorotateToPortraitUpsideDown
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown, value);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00030B7C File Offset: 0x0002ED7C
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x00005107 File Offset: 0x00003307
		public static bool autorotateToLandscapeLeft
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft, value);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00030B94 File Offset: 0x0002ED94
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00005112 File Offset: 0x00003312
		public static bool autorotateToLandscapeRight
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight, value);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0000512A File Offset: 0x0000332A
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00005136 File Offset: 0x00003336
		public static FullScreenMode fullScreenMode
		{
			get
			{
				return Screen.get_fullScreenModeDelegateField();
			}
			set
			{
				Screen.set_fullScreenModeDelegateField(value);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00030BAC File Offset: 0x0002EDAC
		public static Il2CppStructArray<Rect> cutouts
		{
			get
			{
				IntPtr intPtr = Screen.get_cutoutsDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00030BD4 File Offset: 0x0002EDD4
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
		{
			bool flag = preferredRefreshRate < 0;
			if (flag)
			{
				preferredRefreshRate = 0;
			}
			Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
			{
				numerator = (uint)preferredRefreshRate,
				denominator = 1U
			});
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00030C10 File Offset: 0x0002EE10
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
			{
				numerator = 0U,
				denominator = 1U
			});
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00030C40 File Offset: 0x0002EE40
		public static Vector2Int mainWindowPosition
		{
			get
			{
				return Screen.GetMainWindowPosition();
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00030C58 File Offset: 0x0002EE58
		public static Vector2Int GetMainWindowPosition()
		{
			Vector2Int vector2Int;
			Screen.GetMainWindowPosition_Injected(out vector2Int);
			return vector2Int;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00005143 File Offset: 0x00003343
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x0000514F File Offset: 0x0000334F
		public static float brightness
		{
			get
			{
				return Screen.get_brightnessDelegateField();
			}
			set
			{
				Screen.set_brightnessDelegateField(value);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00030C70 File Offset: 0x0002EE70
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00030C8C File Offset: 0x0002EE8C
		public static bool lockCursor
		{
			get
			{
				return CursorLockMode.Locked == Cursor.lockState;
			}
			set
			{
				if (value)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
				else
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0000515C File Offset: 0x0000335C
		public static void GetMainWindowPosition_Injected(out Vector2Int ret)
		{
			Screen.GetMainWindowPosition_InjectedDelegateField(out ret);
		}

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_set_sleepTimeout_Public_Static_set_Void_Int32_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_get_safeArea_Public_Static_get_Rect_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_get_safeArea_Injected_Private_Static_Void_byref_Rect_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0;

		// Token: 0x04000697 RID: 1687
		private static readonly Screen.RequestOrientationDelegate RequestOrientationDelegateField;

		// Token: 0x04000698 RID: 1688
		private static readonly Screen.get_sleepTimeoutDelegate get_sleepTimeoutDelegateField;

		// Token: 0x04000699 RID: 1689
		private static readonly Screen.IsOrientationEnabledDelegate IsOrientationEnabledDelegateField;

		// Token: 0x0400069A RID: 1690
		private static readonly Screen.SetOrientationEnabledDelegate SetOrientationEnabledDelegateField;

		// Token: 0x0400069B RID: 1691
		private static readonly Screen.set_fullScreenDelegate set_fullScreenDelegateField;

		// Token: 0x0400069C RID: 1692
		private static readonly Screen.get_fullScreenModeDelegate get_fullScreenModeDelegateField;

		// Token: 0x0400069D RID: 1693
		private static readonly Screen.set_fullScreenModeDelegate set_fullScreenModeDelegateField;

		// Token: 0x0400069E RID: 1694
		private static readonly Screen.get_cutoutsDelegate get_cutoutsDelegateField;

		// Token: 0x0400069F RID: 1695
		private static readonly Screen.get_brightnessDelegate get_brightnessDelegateField;

		// Token: 0x040006A0 RID: 1696
		private static readonly Screen.set_brightnessDelegate set_brightnessDelegateField;

		// Token: 0x040006A1 RID: 1697
		private static readonly Screen.GetMainWindowPosition_InjectedDelegate GetMainWindowPosition_InjectedDelegateField;

		// Token: 0x020004C3 RID: 1219
		// (Invoke) Token: 0x06003297 RID: 12951
		private delegate void RequestOrientationDelegate(ScreenOrientation orient);

		// Token: 0x020004C4 RID: 1220
		// (Invoke) Token: 0x06003299 RID: 12953
		private delegate int get_sleepTimeoutDelegate();

		// Token: 0x020004C5 RID: 1221
		// (Invoke) Token: 0x0600329B RID: 12955
		private delegate bool IsOrientationEnabledDelegate(EnabledOrientation orient);

		// Token: 0x020004C6 RID: 1222
		// (Invoke) Token: 0x0600329D RID: 12957
		private delegate void SetOrientationEnabledDelegate(EnabledOrientation orient, bool enabled);

		// Token: 0x020004C7 RID: 1223
		// (Invoke) Token: 0x0600329F RID: 12959
		private delegate void set_fullScreenDelegate(bool value);

		// Token: 0x020004C8 RID: 1224
		// (Invoke) Token: 0x060032A1 RID: 12961
		private delegate FullScreenMode get_fullScreenModeDelegate();

		// Token: 0x020004C9 RID: 1225
		// (Invoke) Token: 0x060032A3 RID: 12963
		private delegate void set_fullScreenModeDelegate(FullScreenMode value);

		// Token: 0x020004CA RID: 1226
		// (Invoke) Token: 0x060032A5 RID: 12965
		private delegate IntPtr get_cutoutsDelegate();

		// Token: 0x020004CB RID: 1227
		// (Invoke) Token: 0x060032A7 RID: 12967
		private delegate float get_brightnessDelegate();

		// Token: 0x020004CC RID: 1228
		// (Invoke) Token: 0x060032A9 RID: 12969
		private delegate void set_brightnessDelegate(float value);

		// Token: 0x020004CD RID: 1229
		// (Invoke) Token: 0x060032AB RID: 12971
		private delegate void GetMainWindowPosition_InjectedDelegate([Out] IntPtr ret);
	}
}
