using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008C RID: 140
	public class Display : Object
	{
		// Token: 0x060007D2 RID: 2002 RVA: 0x0002FC78 File Offset: 0x0002DE78
		// Note: this type is marked as 'beforefieldinit'.
		static Display()
		{
			Il2CppClassPointerStore<Display>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Display");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Display>.NativeClassPtr);
			Display.NativeFieldInfoPtr_nativeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "nativeDisplay");
			Display.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "displays");
			Display.NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "_mainDisplay");
			Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "m_ActiveEditorGameViewTarget");
			Display.NativeFieldInfoPtr_onDisplaysUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "onDisplaysUpdated");
			Display.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664257);
			Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664259);
			Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664260);
			Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664261);
			Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664262);
			Display.NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664263);
			Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664264);
			Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664265);
			Display.NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664266);
			Display.NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664267);
			Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664268);
			Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664269);
			Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664270);
			Display.NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664271);
			Display.GetRenderingBuffersImplDelegateField = IL2CPP.ResolveICall<Display.GetRenderingBuffersImplDelegate>("UnityEngine.Display::GetRenderingBuffersImpl");
			Display.SetRenderingResolutionImplDelegateField = IL2CPP.ResolveICall<Display.SetRenderingResolutionImplDelegate>("UnityEngine.Display::SetRenderingResolutionImpl");
			Display.SetParamsImplDelegateField = IL2CPP.ResolveICall<Display.SetParamsImplDelegate>("UnityEngine.Display::SetParamsImpl");
			Display.GetActiveImplDelegateField = IL2CPP.ResolveICall<Display.GetActiveImplDelegate>("UnityEngine.Display::GetActiveImpl");
			Display.RequiresBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<Display.RequiresBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresBlitToBackbufferImpl");
			Display.ActivateDisplayImpl_InjectedDelegateField = IL2CPP.ResolveICall<Display.ActivateDisplayImpl_InjectedDelegate>("UnityEngine.Display::ActivateDisplayImpl_Injected");
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0002FE80 File Offset: 0x0002E080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649296, XrefRangeEnd = 649298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Display()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0002FEBC File Offset: 0x0002E0BC
		public unsafe int renderingWidth
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 649303, RefRangeEnd = 649312, XrefRangeStart = 649298, XrefRangeEnd = 649303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		public unsafe int renderingHeight
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 649317, RefRangeEnd = 649327, XrefRangeStart = 649312, XrefRangeEnd = 649317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0002FF34 File Offset: 0x0002E134
		public unsafe int systemWidth
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 649332, RefRangeEnd = 649339, XrefRangeStart = 649327, XrefRangeEnd = 649332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0002FF70 File Offset: 0x0002E170
		public unsafe int systemHeight
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 649344, RefRangeEnd = 649355, XrefRangeStart = 649339, XrefRangeEnd = 649344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0002FFAC File Offset: 0x0002E1AC
		public unsafe bool requiresSrgbBlitToBackbuffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 649360, RefRangeEnd = 649361, XrefRangeStart = 649355, XrefRangeEnd = 649360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 649366, RefRangeEnd = 649371, XrefRangeStart = 649361, XrefRangeEnd = 649366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputMouseCoordinates;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00030028 File Offset: 0x0002E228
		public unsafe static Display main
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 649375, RefRangeEnd = 649377, XrefRangeStart = 649371, XrefRangeEnd = 649375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Display>(intPtr3) : null;
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0003005C File Offset: 0x0002E25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649377, XrefRangeEnd = 649398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecreateDisplayList(Il2CppStructArray<IntPtr> nativeDisplay)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nativeDisplay);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00030094 File Offset: 0x0002E294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649398, XrefRangeEnd = 649404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireDisplaysUpdated()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000300BC File Offset: 0x0002E2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649404, XrefRangeEnd = 649406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0003010C File Offset: 0x0002E30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649406, XrefRangeEnd = 649408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0003015C File Offset: 0x0002E35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649408, XrefRangeEnd = 649410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rx;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ry;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000301C4 File Offset: 0x0002E3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649410, XrefRangeEnd = 649437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00004F6D File Offset: 0x0000316D
		public Display(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00030204 File Offset: 0x0002E404
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00004F76 File Offset: 0x00003176
		public unsafe IntPtr nativeDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0003022C File Offset: 0x0002E42C
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00004F91 File Offset: 0x00003191
		public unsafe static Il2CppReferenceArray<Display> displays
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_displays, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Display>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_displays, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00030254 File Offset: 0x0002E454
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00004FA3 File Offset: 0x000031A3
		public unsafe static Display _mainDisplay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr__mainDisplay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Display>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr__mainDisplay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0003027C File Offset: 0x0002E47C
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00004FB5 File Offset: 0x000031B5
		public unsafe static int m_ActiveEditorGameViewTarget
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*)(&value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00030298 File Offset: 0x0002E498
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00004FC3 File Offset: 0x000031C3
		public unsafe static Display.DisplaysUpdatedDelegate onDisplaysUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Display.DisplaysUpdatedDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x000302C0 File Offset: 0x0002E4C0
		public RenderBuffer colorBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				RenderBuffer renderBuffer2;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out renderBuffer, out renderBuffer2);
				return renderBuffer;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x000302E4 File Offset: 0x0002E4E4
		public RenderBuffer depthBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				RenderBuffer renderBuffer2;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out renderBuffer, out renderBuffer2);
				return renderBuffer2;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00030308 File Offset: 0x0002E508
		public bool active
		{
			get
			{
				return Display.GetActiveImpl(this.nativeDisplay);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00004FD5 File Offset: 0x000031D5
		public bool requiresBlitToBackbuffer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00030328 File Offset: 0x0002E528
		public void Activate()
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, 0, 0, new RefreshRate
			{
				numerator = 60U,
				denominator = 1U
			});
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00004FE2 File Offset: 0x000031E2
		public void Activate(int width, int height, RefreshRate refreshRate)
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, width, height, refreshRate);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00030360 File Offset: 0x0002E560
		public void Activate(int width, int height, int refreshRate)
		{
			bool flag = refreshRate < 0;
			if (flag)
			{
				refreshRate = 0;
			}
			Display.ActivateDisplayImpl(this.nativeDisplay, width, height, new RefreshRate
			{
				numerator = (uint)refreshRate,
				denominator = 1U
			});
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00004FF4 File Offset: 0x000031F4
		public void SetParams(int width, int height, int x, int y)
		{
			Display.SetParamsImpl(this.nativeDisplay, width, height, x, y);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00005008 File Offset: 0x00003208
		public void SetRenderingResolution(int w, int h)
		{
			Display.SetRenderingResolutionImpl(this.nativeDisplay, w, h);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000303A0 File Offset: 0x0002E5A0
		public static bool MultiDisplayLicense()
		{
			return true;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x000303B4 File Offset: 0x0002E5B4
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00005019 File Offset: 0x00003219
		public static int activeEditorGameViewTarget
		{
			get
			{
				return Display.m_ActiveEditorGameViewTarget;
			}
			set
			{
				Display.m_ActiveEditorGameViewTarget = value;
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00005022 File Offset: 0x00003222
		public static void add_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0000502F File Offset: 0x0000322F
		public static void remove_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0000503C File Offset: 0x0000323C
		public static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth)
		{
			Display.GetRenderingBuffersImplDelegateField(nativeDisplay, out color, out depth);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0000504B File Offset: 0x0000324B
		public static void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h)
		{
			Display.SetRenderingResolutionImplDelegateField(nativeDisplay, w, h);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0000505A File Offset: 0x0000325A
		public static void ActivateDisplayImpl(IntPtr nativeDisplay, int width, int height, RefreshRate refreshRate)
		{
			Display.ActivateDisplayImpl_Injected(nativeDisplay, width, height, ref refreshRate);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00005066 File Offset: 0x00003266
		public static void SetParamsImpl(IntPtr nativeDisplay, int width, int height, int x, int y)
		{
			Display.SetParamsImplDelegateField(nativeDisplay, width, height, x, y);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00005078 File Offset: 0x00003278
		public static bool GetActiveImpl(IntPtr nativeDisplay)
		{
			return Display.GetActiveImplDelegateField(nativeDisplay);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00005085 File Offset: 0x00003285
		public static bool RequiresBlitToBackbufferImpl(IntPtr nativeDisplay)
		{
			return Display.RequiresBlitToBackbufferImplDelegateField(nativeDisplay);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00005092 File Offset: 0x00003292
		public static void ActivateDisplayImpl_Injected(IntPtr nativeDisplay, int width, int height, ref RefreshRate refreshRate)
		{
			Display.ActivateDisplayImpl_InjectedDelegateField(nativeDisplay, width, height, ref refreshRate);
		}

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_nativeDisplay;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_displays;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr__mainDisplay;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveEditorGameViewTarget;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr_onDisplaysUpdated;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Display_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04000674 RID: 1652
		private static readonly Display.GetRenderingBuffersImplDelegate GetRenderingBuffersImplDelegateField;

		// Token: 0x04000675 RID: 1653
		private static readonly Display.SetRenderingResolutionImplDelegate SetRenderingResolutionImplDelegateField;

		// Token: 0x04000676 RID: 1654
		private static readonly Display.SetParamsImplDelegate SetParamsImplDelegateField;

		// Token: 0x04000677 RID: 1655
		private static readonly Display.GetActiveImplDelegate GetActiveImplDelegateField;

		// Token: 0x04000678 RID: 1656
		private static readonly Display.RequiresBlitToBackbufferImplDelegate RequiresBlitToBackbufferImplDelegateField;

		// Token: 0x04000679 RID: 1657
		private static readonly Display.ActivateDisplayImpl_InjectedDelegate ActivateDisplayImpl_InjectedDelegateField;

		// Token: 0x020004BC RID: 1212
		public sealed class DisplaysUpdatedDelegate : MulticastDelegate
		{
			// Token: 0x06003283 RID: 12931 RVA: 0x00013D0F File Offset: 0x00011F0F
			// Note: this type is marked as 'beforefieldinit'.
			static DisplaysUpdatedDelegate()
			{
				Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Display>.NativeClassPtr, "DisplaysUpdatedDelegate");
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100664273);
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100664274);
			}

			// Token: 0x06003284 RID: 12932 RVA: 0x000B90C8 File Offset: 0x000B72C8
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisplaysUpdatedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003285 RID: 12933 RVA: 0x000B9124 File Offset: 0x000B7324
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003286 RID: 12934 RVA: 0x00013D4D File Offset: 0x00011F4D
			public DisplaysUpdatedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003287 RID: 12935 RVA: 0x00013D56 File Offset: 0x00011F56
			public static implicit operator Display.DisplaysUpdatedDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Display.DisplaysUpdatedDelegate>(A_0);
			}

			// Token: 0x06003288 RID: 12936 RVA: 0x00013D5E File Offset: 0x00011F5E
			public static Display.DisplaysUpdatedDelegate operator +(Display.DisplaysUpdatedDelegate A_0, Display.DisplaysUpdatedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Display.DisplaysUpdatedDelegate>();
			}

			// Token: 0x06003289 RID: 12937 RVA: 0x00013D6C File Offset: 0x00011F6C
			public static Display.DisplaysUpdatedDelegate operator -(Display.DisplaysUpdatedDelegate A_0, Display.DisplaysUpdatedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Display.DisplaysUpdatedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002B9D RID: 11165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B9E RID: 11166
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x020004BD RID: 1213
		// (Invoke) Token: 0x0600328B RID: 12939
		private delegate void GetRenderingBuffersImplDelegate(IntPtr nativeDisplay, [Out] IntPtr color, [Out] IntPtr depth);

		// Token: 0x020004BE RID: 1214
		// (Invoke) Token: 0x0600328D RID: 12941
		private delegate void SetRenderingResolutionImplDelegate(IntPtr nativeDisplay, int w, int h);

		// Token: 0x020004BF RID: 1215
		// (Invoke) Token: 0x0600328F RID: 12943
		private delegate void SetParamsImplDelegate(IntPtr nativeDisplay, int width, int height, int x, int y);

		// Token: 0x020004C0 RID: 1216
		// (Invoke) Token: 0x06003291 RID: 12945
		private delegate bool GetActiveImplDelegate(IntPtr nativeDisplay);

		// Token: 0x020004C1 RID: 1217
		// (Invoke) Token: 0x06003293 RID: 12947
		private delegate bool RequiresBlitToBackbufferImplDelegate(IntPtr nativeDisplay);

		// Token: 0x020004C2 RID: 1218
		// (Invoke) Token: 0x06003295 RID: 12949
		private delegate void ActivateDisplayImpl_InjectedDelegate(IntPtr nativeDisplay, int width, int height, IntPtr refreshRate);
	}
}
