using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class GUILayoutUtility : Object
	{
		// Token: 0x06000289 RID: 649 RVA: 0x0000AF84 File Offset: 0x00009184
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutUtility()
		{
			Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr);
			GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_StoredLayouts");
			GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_StoredWindows");
			GUILayoutUtility.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "current");
			GUILayoutUtility.NativeFieldInfoPtr_kDummyRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "kDummyRect");
			GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663429);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663430);
			GUILayoutUtility.NativeMethodInfoPtr_GetLayoutCache_Internal_Static_LayoutCache_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663431);
			GUILayoutUtility.NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663432);
			GUILayoutUtility.NativeMethodInfoPtr_RemoveSelectedIdList_Internal_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663433);
			GUILayoutUtility.NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663434);
			GUILayoutUtility.NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663435);
			GUILayoutUtility.NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663436);
			GUILayoutUtility.NativeMethodInfoPtr_Layout_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663437);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663438);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663439);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663440);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663441);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663443);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663444);
			GUILayoutUtility.GetWindowsBounds_InjectedDelegateField = IL2CPP.ResolveICall<GUILayoutUtility.GetWindowsBounds_InjectedDelegate>("UnityEngine.GUILayoutUtility::GetWindowsBounds_Injected");
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000B140 File Offset: 0x00009340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186119, XrefRangeEnd = 1186124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect Internal_GetWindowRect(int windowID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000B180 File Offset: 0x00009380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186124, XrefRangeEnd = 1186129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MoveWindow(int windowID, Rect r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186129, XrefRangeEnd = 1186139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_GetLayoutCache_Internal_Static_LayoutCache_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr3) : null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000B210 File Offset: 0x00009410
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1186173, RefRangeEnd = 1186178, XrefRangeStart = 1186139, XrefRangeEnd = 1186173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr3) : null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000B260 File Offset: 0x00009460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186178, XrefRangeEnd = 1186191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveSelectedIdList(int instanceID, bool isWindow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_RemoveSelectedIdList_Internal_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000B2A0 File Offset: 0x000094A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186208, RefRangeEnd = 1186209, XrefRangeStart = 1186191, XrefRangeEnd = 1186208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Begin(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000B2D4 File Offset: 0x000094D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186232, RefRangeEnd = 1186233, XrefRangeStart = 1186209, XrefRangeEnd = 1186232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContainer(GUILayoutUtility.LayoutCache cache)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000B30C File Offset: 0x0000950C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186250, RefRangeEnd = 1186251, XrefRangeStart = 1186233, XrefRangeEnd = 1186250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginWindow(int windowID, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000B364 File Offset: 0x00009564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1186261, RefRangeEnd = 1186263, XrefRangeStart = 1186251, XrefRangeEnd = 1186261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Layout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Layout_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000B38C File Offset: 0x0000958C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186274, RefRangeEnd = 1186275, XrefRangeStart = 1186263, XrefRangeEnd = 1186274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutFromEditorWindow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000B3B4 File Offset: 0x000095B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186285, RefRangeEnd = 1186286, XrefRangeStart = 1186275, XrefRangeEnd = 1186285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutFromContainer(float w, float h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref w;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000B3F4 File Offset: 0x000095F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186307, RefRangeEnd = 1186308, XrefRangeStart = 1186286, XrefRangeEnd = 1186307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toplevel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000B42C File Offset: 0x0000962C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1186321, RefRangeEnd = 1186323, XrefRangeStart = 1186308, XrefRangeEnd = 1186321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutSingleGroup(GUILayoutGroup i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000B464 File Offset: 0x00009664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186323, XrefRangeEnd = 1186325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_GetWindowRect_Injected(int windowID, out Rect ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000B4A4 File Offset: 0x000096A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186325, XrefRangeEnd = 1186327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MoveWindow_Injected(int windowID, ref Rect r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000030C5 File Offset: 0x000012C5
		public GUILayoutUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000B4E4 File Offset: 0x000096E4
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000030CE File Offset: 0x000012CE
		public unsafe static Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GUILayoutUtility.LayoutCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000B50C File Offset: 0x0000970C
		// (set) Token: 0x0600029D RID: 669 RVA: 0x000030E0 File Offset: 0x000012E0
		public unsafe static Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GUILayoutUtility.LayoutCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000B534 File Offset: 0x00009734
		// (set) Token: 0x0600029F RID: 671 RVA: 0x000030F2 File Offset: 0x000012F2
		public unsafe static GUILayoutUtility.LayoutCache current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000B55C File Offset: 0x0000975C
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00003104 File Offset: 0x00001304
		public unsafe static Rect kDummyRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_kDummyRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_kDummyRect, (void*)(&value));
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000B578 File Offset: 0x00009778
		public static Rect GetWindowsBounds()
		{
			Rect rect;
			GUILayoutUtility.GetWindowsBounds_Injected(out rect);
			return rect;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00003112 File Offset: 0x00001312
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000311F File Offset: 0x0000131F
		public static int unbalancedgroupscount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000312C File Offset: 0x0000132C
		public static void CleanupRoots()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00003139 File Offset: 0x00001339
		public static void BeginGroup(string GroupName)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000313C File Offset: 0x0000133C
		public static void EndGroup(string groupName)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000B590 File Offset: 0x00009790
		public static float LayoutFromInspector(float width)
		{
			bool flag = GUILayoutUtility.current.topLevel != null && GUILayoutUtility.current.topLevel.windowID == -1;
			float num;
			if (flag)
			{
				GUILayoutUtility.current.topLevel.CalcWidth();
				GUILayoutUtility.current.topLevel.SetHorizontal(0f, width);
				GUILayoutUtility.current.topLevel.CalcHeight();
				GUILayoutUtility.current.topLevel.SetVertical(0f, Mathf.Min((float)Screen.height / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxHeight));
				float minHeight = GUILayoutUtility.current.topLevel.minHeight;
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
				num = minHeight;
			}
			else
			{
				bool flag2 = GUILayoutUtility.current.topLevel != null;
				if (flag2)
				{
					GUILayoutUtility.LayoutSingleGroup(GUILayoutUtility.current.topLevel);
				}
				num = 0f;
			}
			return num;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000B680 File Offset: 0x00009880
		public static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			bool flag = !Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<GUILayoutGroup>()).IsAssignableFrom(LayoutType);
			if (flag)
			{
				throw new ArgumentException("LayoutType needs to be of type GUILayoutGroup", "LayoutType");
			}
			return Activator.CreateInstance(LayoutType).Cast<GUILayoutGroup>();
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000B6C4 File Offset: 0x000098C4
		public static GUILayoutGroup BeginLayoutGroup(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options, Type layoutType)
		{
			GUILayoutUtility.unbalancedgroupscount++;
			EventType type = Event.current.type;
			EventType eventType = type;
			GUILayoutGroup guilayoutGroup;
			if (eventType != EventType.Layout && eventType != EventType.Used)
			{
				guilayoutGroup = GUILayoutUtility.current.topLevel.GetNext().TryCast<GUILayoutGroup>();
				bool flag = guilayoutGroup == null;
				if (flag)
				{
					throw new ExitGUIException(String.Concat("GUILayout: Mismatched LayoutGroup.", Event.current.type.ToString()));
				}
				guilayoutGroup.ResetCursor();
			}
			else
			{
				guilayoutGroup = GUILayoutUtility.CreateGUILayoutGroupInstanceOfType(layoutType);
				guilayoutGroup.style = style;
				bool flag2 = options != null;
				if (flag2)
				{
					guilayoutGroup.ApplyOptions(options);
				}
				GUILayoutUtility.current.topLevel.Add(guilayoutGroup);
			}
			GUILayoutUtility.current.layoutGroups.Push(guilayoutGroup);
			GUILayoutUtility.current.topLevel = guilayoutGroup;
			return guilayoutGroup;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000B7A0 File Offset: 0x000099A0
		public static void EndLayoutGroup()
		{
			GUILayoutUtility.unbalancedgroupscount--;
			bool flag = GUILayoutUtility.current.layoutGroups.Count == 0;
			if (flag)
			{
				Debug.LogError("EndLayoutGroup: BeginLayoutGroup must be called first.");
			}
			else
			{
				GUILayoutUtility.current.layoutGroups.Pop();
				bool flag2 = 0 < GUILayoutUtility.current.layoutGroups.Count;
				if (flag2)
				{
					GUILayoutUtility.current.topLevel = GUILayoutUtility.current.layoutGroups.Peek().Cast<GUILayoutGroup>();
				}
				else
				{
					GUILayoutUtility.current.topLevel = new GUILayoutGroup();
				}
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000B834 File Offset: 0x00009A34
		public static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
		{
			GUILayoutUtility.unbalancedgroupscount++;
			EventType type = Event.current.type;
			EventType eventType = type;
			GUILayoutGroup guilayoutGroup;
			if (eventType != EventType.Layout && eventType != EventType.Used)
			{
				guilayoutGroup = GUILayoutUtility.current.windows.GetNext().TryCast<GUILayoutGroup>();
				bool flag = guilayoutGroup == null;
				if (flag)
				{
					throw new ExitGUIException(String.Concat("GUILayout: Mismatched LayoutGroup.", Event.current.type.ToString()));
				}
				guilayoutGroup.ResetCursor();
			}
			else
			{
				guilayoutGroup = GUILayoutUtility.CreateGUILayoutGroupInstanceOfType(layoutType);
				guilayoutGroup.style = style;
				GUILayoutUtility.current.windows.Add(guilayoutGroup);
			}
			GUILayoutUtility.current.layoutGroups.Push(guilayoutGroup);
			GUILayoutUtility.current.topLevel = guilayoutGroup;
			return guilayoutGroup;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000313F File Offset: 0x0000133F
		public static void EndLayoutArea()
		{
			GUILayoutUtility.unbalancedgroupscount--;
			GUILayoutUtility.current.layoutGroups.Pop();
			GUILayoutUtility.current.topLevel = GUILayoutUtility.current.layoutGroups.Peek().Cast<GUILayoutGroup>();
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000B900 File Offset: 0x00009B00
		public static GUILayoutGroup DoBeginLayoutArea(GUIStyle style, Type layoutType)
		{
			return GUILayoutUtility.BeginLayoutArea(style, layoutType);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000317D File Offset: 0x0000137D
		public static GUILayoutGroup topLevel
		{
			get
			{
				return GUILayoutUtility.current.topLevel;
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000B91C File Offset: 0x00009B1C
		public static Rect GetRect(GUIContent content, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(content, style, null);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000B938 File Offset: 0x00009B38
		public static Rect GetRect(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(content, style, options);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00003189 File Offset: 0x00001389
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003198 File Offset: 0x00001398
		public static Rect DoGetRect(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000B954 File Offset: 0x00009B54
		public static Rect GetRect(float width, float height)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, null);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000B978 File Offset: 0x00009B78
		public static Rect GetRect(float width, float height, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, style, null);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000B998 File Offset: 0x00009B98
		public static Rect GetRect(float width, float height, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, options);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000031A5 File Offset: 0x000013A5
		public static Rect GetRect(float width, float height, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(width, height, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000B9BC File Offset: 0x00009BBC
		public static Rect GetRect(float width, float height, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, style, options);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000031B4 File Offset: 0x000013B4
		public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(width, height, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000B9DC File Offset: 0x00009BDC
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, null);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000BA00 File Offset: 0x00009C00
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, null);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000BA20 File Offset: 0x00009C20
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, options);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000031C4 File Offset: 0x000013C4
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000BA44 File Offset: 0x00009C44
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, options);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000031D6 File Offset: 0x000013D6
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000BA64 File Offset: 0x00009C64
		public static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			EventType type = Event.current.type;
			EventType eventType = type;
			Rect rect;
			if (eventType != EventType.Layout)
			{
				if (eventType != EventType.Used)
				{
					rect = GUILayoutUtility.current.topLevel.GetNext().rect;
				}
				else
				{
					rect = GUILayoutUtility.kDummyRect;
				}
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUILayoutEntry(minWidth, maxWidth, minHeight, maxHeight, style, options));
				rect = new Rect(0f, 0f, maxWidth, maxHeight);
			}
			return rect;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		public static Rect GetLastRect()
		{
			EventType type = Event.current.type;
			EventType eventType = type;
			Rect rect;
			if (eventType != EventType.Layout && eventType != EventType.Used)
			{
				rect = GUILayoutUtility.current.topLevel.GetLast();
			}
			else
			{
				rect = GUILayoutUtility.kDummyRect;
			}
			return rect;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000BB24 File Offset: 0x00009D24
		public static Rect GetAspectRect(float aspect)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, null);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000BB40 File Offset: 0x00009D40
		public static Rect GetAspectRect(float aspect, GUIStyle style)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, null);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000BB5C File Offset: 0x00009D5C
		public static Rect GetAspectRect(float aspect, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, options);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000031EA File Offset: 0x000013EA
		public static Rect GetAspectRect(float aspect, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetAspectRect(aspect, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000BB78 File Offset: 0x00009D78
		public static Rect GetAspectRect(float aspect, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, options);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000031F8 File Offset: 0x000013F8
		public static Rect GetAspectRect(float aspect, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetAspectRect(aspect, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000BB94 File Offset: 0x00009D94
		public static Rect DoGetAspectRect(float aspect, Il2CppReferenceArray<GUILayoutOption> options)
		{
			EventType type = Event.current.type;
			EventType eventType = type;
			Rect rect;
			if (eventType != EventType.Layout)
			{
				if (eventType != EventType.Used)
				{
					rect = GUILayoutUtility.current.topLevel.GetNext().rect;
				}
				else
				{
					rect = GUILayoutUtility.kDummyRect;
				}
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUIAspectSizer(aspect, options));
				rect = GUILayoutUtility.kDummyRect;
			}
			return rect;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00003207 File Offset: 0x00001407
		public static GUIStyle spaceStyle
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003214 File Offset: 0x00001414
		public static void GetWindowsBounds_Injected(out Rect ret)
		{
			GUILayoutUtility.GetWindowsBounds_InjectedDelegateField(out ret);
		}

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_s_StoredLayouts;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_s_StoredWindows;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_kDummyRect;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutCache_Internal_Static_LayoutCache_Int32_Boolean_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSelectedIdList_Internal_Static_Void_Int32_Boolean_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Internal_Static_Void_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0;

		// Token: 0x04000124 RID: 292
		private static readonly GUILayoutUtility.GetWindowsBounds_InjectedDelegate GetWindowsBounds_InjectedDelegateField;

		// Token: 0x02000070 RID: 112
		public sealed class LayoutCache : Object
		{
			// Token: 0x060006FE RID: 1790 RVA: 0x00017988 File Offset: 0x00015B88
			// Note: this type is marked as 'beforefieldinit'.
			static LayoutCache()
			{
				Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "LayoutCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr);
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "<id>k__BackingField");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "topLevel");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "layoutGroups");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "windows");
				GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, 100663445);
				GUILayoutUtility.LayoutCache.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, 100663446);
				GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_ResetCursor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, 100663447);
			}

			// Token: 0x17000174 RID: 372
			// (set) Token: 0x060006FF RID: 1791 RVA: 0x00017A40 File Offset: 0x00015C40
			public unsafe int id
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000700 RID: 1792 RVA: 0x00017A80 File Offset: 0x00015C80
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1186101, RefRangeEnd = 1186103, XrefRangeStart = 1186085, XrefRangeEnd = 1186101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LayoutCache(int instanceID = -1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref instanceID;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.LayoutCache.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x00017AC8 File Offset: 0x00015CC8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1186118, RefRangeEnd = 1186119, XrefRangeStart = 1186103, XrefRangeEnd = 1186118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ResetCursor()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_ResetCursor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000702 RID: 1794 RVA: 0x00004E49 File Offset: 0x00003049
			public LayoutCache(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x06000703 RID: 1795 RVA: 0x00017AFC File Offset: 0x00015CFC
			// (set) Token: 0x06000704 RID: 1796 RVA: 0x00004E52 File Offset: 0x00003052
			public unsafe int _id_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField)) = value;
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x06000705 RID: 1797 RVA: 0x00017B24 File Offset: 0x00015D24
			// (set) Token: 0x06000706 RID: 1798 RVA: 0x00004E6D File Offset: 0x0000306D
			public unsafe GUILayoutGroup topLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x06000707 RID: 1799 RVA: 0x00017B54 File Offset: 0x00015D54
			// (set) Token: 0x06000708 RID: 1800 RVA: 0x00004E8C File Offset: 0x0000308C
			public unsafe GenericStack layoutGroups
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000709 RID: 1801 RVA: 0x00017B84 File Offset: 0x00015D84
			// (set) Token: 0x0600070A RID: 1802 RVA: 0x00004EAB File Offset: 0x000030AB
			public unsafe GUILayoutGroup windows
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003AA RID: 938
			private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

			// Token: 0x040003AB RID: 939
			private static readonly IntPtr NativeFieldInfoPtr_topLevel;

			// Token: 0x040003AC RID: 940
			private static readonly IntPtr NativeFieldInfoPtr_layoutGroups;

			// Token: 0x040003AD RID: 941
			private static readonly IntPtr NativeFieldInfoPtr_windows;

			// Token: 0x040003AE RID: 942
			private static readonly IntPtr NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0;

			// Token: 0x040003AF RID: 943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x040003B0 RID: 944
			private static readonly IntPtr NativeMethodInfoPtr_ResetCursor_Public_Void_0;
		}

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x0600070C RID: 1804
		private delegate void GetWindowsBounds_InjectedDelegate([Out] IntPtr ret);
	}
}
