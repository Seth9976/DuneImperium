using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public sealed class GUIClip : Object
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00009218 File Offset: 0x00007418
		// Note: this type is marked as 'beforefieldinit'.
		static GUIClip()
		{
			Il2CppClassPointerStore<GUIClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIClip>.NativeClassPtr);
			GUIClip.NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663400);
			GUIClip.NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663401);
			GUIClip.NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663402);
			GUIClip.NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663403);
			GUIClip.NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663404);
			GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663405);
			GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Matrix4x4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663406);
			GUIClip.NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663407);
			GUIClip.NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663408);
			GUIClip.NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663409);
			GUIClip.NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663410);
			GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663411);
			GUIClip.get_enabledDelegateField = IL2CPP.ResolveICall<GUIClip.get_enabledDelegate>("UnityEngine.GUIClip::get_enabled");
			GUIClip.ReapplyDelegateField = IL2CPP.ResolveICall<GUIClip.ReapplyDelegate>("UnityEngine.GUIClip::Reapply");
			GUIClip.get_topmostRect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.get_topmostRect_InjectedDelegate>("UnityEngine.GUIClip::get_topmostRect_Injected");
			GUIClip.Internal_Push_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Internal_Push_InjectedDelegate>("UnityEngine.GUIClip::Internal_Push_Injected");
			GUIClip.GetTopRect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.GetTopRect_InjectedDelegate>("UnityEngine.GUIClip::GetTopRect_Injected");
			GUIClip.Unclip_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Unclip_Vector2_InjectedDelegate>("UnityEngine.GUIClip::Unclip_Vector2_Injected");
			GUIClip.Unclip_Rect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Unclip_Rect_InjectedDelegate>("UnityEngine.GUIClip::Unclip_Rect_Injected");
			GUIClip.Clip_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Clip_Vector2_InjectedDelegate>("UnityEngine.GUIClip::Clip_Vector2_Injected");
			GUIClip.Internal_Clip_Rect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Internal_Clip_Rect_InjectedDelegate>("UnityEngine.GUIClip::Internal_Clip_Rect_Injected");
			GUIClip.UnclipToWindow_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.UnclipToWindow_Vector2_InjectedDelegate>("UnityEngine.GUIClip::UnclipToWindow_Vector2_Injected");
			GUIClip.UnclipToWindow_Rect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.UnclipToWindow_Rect_InjectedDelegate>("UnityEngine.GUIClip::UnclipToWindow_Rect_Injected");
			GUIClip.ClipToWindow_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.ClipToWindow_Vector2_InjectedDelegate>("UnityEngine.GUIClip::ClipToWindow_Vector2_Injected");
			GUIClip.ClipToWindow_Rect_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.ClipToWindow_Rect_InjectedDelegate>("UnityEngine.GUIClip::ClipToWindow_Rect_Injected");
			GUIClip.Internal_GetAbsoluteMousePosition_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.Internal_GetAbsoluteMousePosition_InjectedDelegate>("UnityEngine.GUIClip::Internal_GetAbsoluteMousePosition_Injected");
			GUIClip.GetParentMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GUIClip.GetParentMatrix_InjectedDelegate>("UnityEngine.GUIClip::GetParentMatrix_Injected");
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000941C File Offset: 0x0000761C
		public unsafe static Rect visibleRect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185965, XrefRangeEnd = 1185967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000944C File Offset: 0x0000764C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1185969, RefRangeEnd = 1185970, XrefRangeStart = 1185967, XrefRangeEnd = 1185969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Pop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00009474 File Offset: 0x00007674
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1185972, RefRangeEnd = 1185976, XrefRangeStart = 1185970, XrefRangeEnd = 1185972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000094A4 File Offset: 0x000076A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185976, XrefRangeEnd = 1185978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetMatrix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000094D4 File Offset: 0x000076D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185978, XrefRangeEnd = 1185980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMatrix(Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009508 File Offset: 0x00007708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185980, XrefRangeEnd = 1185982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectTransform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00009548 File Offset: 0x00007748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185982, XrefRangeEnd = 1185984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTransform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputTransform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Matrix4x4_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00009598 File Offset: 0x00007798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185984, XrefRangeEnd = 1185986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_PopParentClip()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000095C0 File Offset: 0x000077C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185986, XrefRangeEnd = 1185988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_visibleRect_Injected(out Rect ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000095F4 File Offset: 0x000077F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185988, XrefRangeEnd = 1185990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetMatrix_Injected(out Matrix4x4 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00009628 File Offset: 0x00007828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185990, XrefRangeEnd = 1185992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMatrix_Injected(ref Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000965C File Offset: 0x0000785C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185992, XrefRangeEnd = 1185994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &renderTransform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &inputTransform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &clipRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000265D File Offset: 0x0000085D
		public GUIClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002666 File Offset: 0x00000866
		public static bool enabled
		{
			get
			{
				return GUIClip.get_enabledDelegateField();
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000096AC File Offset: 0x000078AC
		public static Rect topmostRect
		{
			get
			{
				Rect rect;
				GUIClip.get_topmostRect_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002672 File Offset: 0x00000872
		public static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.Internal_Push_Injected(ref screenRect, ref scrollOffset, ref renderOffset, resetOffset);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000096C4 File Offset: 0x000078C4
		public static Rect GetTopRect()
		{
			Rect rect;
			GUIClip.GetTopRect_Injected(out rect);
			return rect;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000096DC File Offset: 0x000078DC
		public static Vector2 Unclip_Vector2(Vector2 pos)
		{
			Vector2 vector;
			GUIClip.Unclip_Vector2_Injected(ref pos, out vector);
			return vector;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000096F4 File Offset: 0x000078F4
		public static Rect Unclip_Rect(Rect rect)
		{
			Rect rect2;
			GUIClip.Unclip_Rect_Injected(ref rect, out rect2);
			return rect2;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000970C File Offset: 0x0000790C
		public static Vector2 Clip_Vector2(Vector2 absolutePos)
		{
			Vector2 vector;
			GUIClip.Clip_Vector2_Injected(ref absolutePos, out vector);
			return vector;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00009724 File Offset: 0x00007924
		public static Rect Internal_Clip_Rect(Rect absoluteRect)
		{
			Rect rect;
			GUIClip.Internal_Clip_Rect_Injected(ref absoluteRect, out rect);
			return rect;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000973C File Offset: 0x0000793C
		public static Vector2 UnclipToWindow_Vector2(Vector2 pos)
		{
			Vector2 vector;
			GUIClip.UnclipToWindow_Vector2_Injected(ref pos, out vector);
			return vector;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00009754 File Offset: 0x00007954
		public static Rect UnclipToWindow_Rect(Rect rect)
		{
			Rect rect2;
			GUIClip.UnclipToWindow_Rect_Injected(ref rect, out rect2);
			return rect2;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000976C File Offset: 0x0000796C
		public static Vector2 ClipToWindow_Vector2(Vector2 absolutePos)
		{
			Vector2 vector;
			GUIClip.ClipToWindow_Vector2_Injected(ref absolutePos, out vector);
			return vector;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00009784 File Offset: 0x00007984
		public static Rect ClipToWindow_Rect(Rect absoluteRect)
		{
			Rect rect;
			GUIClip.ClipToWindow_Rect_Injected(ref absoluteRect, out rect);
			return rect;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000979C File Offset: 0x0000799C
		public static Vector2 Internal_GetAbsoluteMousePosition()
		{
			Vector2 vector;
			GUIClip.Internal_GetAbsoluteMousePosition_Injected(out vector);
			return vector;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002680 File Offset: 0x00000880
		public static void Reapply()
		{
			GUIClip.ReapplyDelegateField();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000097B4 File Offset: 0x000079B4
		public static Matrix4x4 GetParentMatrix()
		{
			Matrix4x4 matrix4x;
			GUIClip.GetParentMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000268C File Offset: 0x0000088C
		public static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.Internal_Push(screenRect, scrollOffset, renderOffset, resetOffset);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002699 File Offset: 0x00000899
		public static void Pop()
		{
			GUIClip.Internal_Pop();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000097CC File Offset: 0x000079CC
		public static Vector2 Unclip(Vector2 pos)
		{
			return GUIClip.Unclip_Vector2(pos);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000097E4 File Offset: 0x000079E4
		public static Rect Unclip(Rect rect)
		{
			return GUIClip.Unclip_Rect(rect);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000097FC File Offset: 0x000079FC
		public static Vector2 Clip(Vector2 absolutePos)
		{
			return GUIClip.Clip_Vector2(absolutePos);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00009814 File Offset: 0x00007A14
		public static Rect Clip(Rect absoluteRect)
		{
			return GUIClip.Internal_Clip_Rect(absoluteRect);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000982C File Offset: 0x00007A2C
		public static Vector2 UnclipToWindow(Vector2 pos)
		{
			return GUIClip.UnclipToWindow_Vector2(pos);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00009844 File Offset: 0x00007A44
		public static Rect UnclipToWindow(Rect rect)
		{
			return GUIClip.UnclipToWindow_Rect(rect);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000985C File Offset: 0x00007A5C
		public static Vector2 ClipToWindow(Vector2 absolutePos)
		{
			return GUIClip.ClipToWindow_Vector2(absolutePos);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00009874 File Offset: 0x00007A74
		public static Rect ClipToWindow(Rect absoluteRect)
		{
			return GUIClip.ClipToWindow_Rect(absoluteRect);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000988C File Offset: 0x00007A8C
		public static Vector2 GetAbsoluteMousePosition()
		{
			return GUIClip.Internal_GetAbsoluteMousePosition();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000026A2 File Offset: 0x000008A2
		public static void get_topmostRect_Injected(out Rect ret)
		{
			GUIClip.get_topmostRect_InjectedDelegateField(out ret);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000026AF File Offset: 0x000008AF
		public static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.Internal_Push_InjectedDelegateField(ref screenRect, ref scrollOffset, ref renderOffset, resetOffset);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000026BF File Offset: 0x000008BF
		public static void GetTopRect_Injected(out Rect ret)
		{
			GUIClip.GetTopRect_InjectedDelegateField(out ret);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000026CC File Offset: 0x000008CC
		public static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret)
		{
			GUIClip.Unclip_Vector2_InjectedDelegateField(ref pos, out ret);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000026DA File Offset: 0x000008DA
		public static void Unclip_Rect_Injected(ref Rect rect, out Rect ret)
		{
			GUIClip.Unclip_Rect_InjectedDelegateField(ref rect, out ret);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000026E8 File Offset: 0x000008E8
		public static void Clip_Vector2_Injected(ref Vector2 absolutePos, out Vector2 ret)
		{
			GUIClip.Clip_Vector2_InjectedDelegateField(ref absolutePos, out ret);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000026F6 File Offset: 0x000008F6
		public static void Internal_Clip_Rect_Injected(ref Rect absoluteRect, out Rect ret)
		{
			GUIClip.Internal_Clip_Rect_InjectedDelegateField(ref absoluteRect, out ret);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002704 File Offset: 0x00000904
		public static void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret)
		{
			GUIClip.UnclipToWindow_Vector2_InjectedDelegateField(ref pos, out ret);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002712 File Offset: 0x00000912
		public static void UnclipToWindow_Rect_Injected(ref Rect rect, out Rect ret)
		{
			GUIClip.UnclipToWindow_Rect_InjectedDelegateField(ref rect, out ret);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002720 File Offset: 0x00000920
		public static void ClipToWindow_Vector2_Injected(ref Vector2 absolutePos, out Vector2 ret)
		{
			GUIClip.ClipToWindow_Vector2_InjectedDelegateField(ref absolutePos, out ret);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000272E File Offset: 0x0000092E
		public static void ClipToWindow_Rect_Injected(ref Rect absoluteRect, out Rect ret)
		{
			GUIClip.ClipToWindow_Rect_InjectedDelegateField(ref absoluteRect, out ret);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000273C File Offset: 0x0000093C
		public static void Internal_GetAbsoluteMousePosition_Injected(out Vector2 ret)
		{
			GUIClip.Internal_GetAbsoluteMousePosition_InjectedDelegateField(out ret);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002749 File Offset: 0x00000949
		public static void GetParentMatrix_Injected(out Matrix4x4 ret)
		{
			GUIClip.GetParentMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Matrix4x4_Rect_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Rect_0;

		// Token: 0x040000E2 RID: 226
		private static readonly GUIClip.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly GUIClip.ReapplyDelegate ReapplyDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly GUIClip.get_topmostRect_InjectedDelegate get_topmostRect_InjectedDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly GUIClip.Internal_Push_InjectedDelegate Internal_Push_InjectedDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly GUIClip.GetTopRect_InjectedDelegate GetTopRect_InjectedDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly GUIClip.Unclip_Vector2_InjectedDelegate Unclip_Vector2_InjectedDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly GUIClip.Unclip_Rect_InjectedDelegate Unclip_Rect_InjectedDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly GUIClip.Clip_Vector2_InjectedDelegate Clip_Vector2_InjectedDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly GUIClip.Internal_Clip_Rect_InjectedDelegate Internal_Clip_Rect_InjectedDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly GUIClip.UnclipToWindow_Vector2_InjectedDelegate UnclipToWindow_Vector2_InjectedDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly GUIClip.UnclipToWindow_Rect_InjectedDelegate UnclipToWindow_Rect_InjectedDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly GUIClip.ClipToWindow_Vector2_InjectedDelegate ClipToWindow_Vector2_InjectedDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly GUIClip.ClipToWindow_Rect_InjectedDelegate ClipToWindow_Rect_InjectedDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly GUIClip.Internal_GetAbsoluteMousePosition_InjectedDelegate Internal_GetAbsoluteMousePosition_InjectedDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly GUIClip.GetParentMatrix_InjectedDelegate GetParentMatrix_InjectedDelegateField;

		// Token: 0x0200005A RID: 90
		[StructLayout(2)]
		public struct ParentClipScope
		{
			// Token: 0x060006DC RID: 1756 RVA: 0x000178B8 File Offset: 0x00015AB8
			// Note: this type is marked as 'beforefieldinit'.
			static ParentClipScope()
			{
				Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, "ParentClipScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr);
				GUIClip.ParentClipScope.NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr, "m_Disposed");
				GUIClip.ParentClipScope.NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr, 100663412);
				GUIClip.ParentClipScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr, 100663413);
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x00017920 File Offset: 0x00015B20
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1185957, RefRangeEnd = 1185959, XrefRangeStart = 1185955, XrefRangeEnd = 1185957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParentClipScope(Matrix4x4 objectTransform, Rect clipRect)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref objectTransform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.ParentClipScope.NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x00017960 File Offset: 0x00015B60
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1185961, RefRangeEnd = 1185965, XrefRangeStart = 1185959, XrefRangeEnd = 1185961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIClip.ParentClipScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x00004E37 File Offset: 0x00003037
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GUIClip.ParentClipScope>.NativeClassPtr, ref this));
			}

			// Token: 0x04000397 RID: 919
			private static readonly IntPtr NativeFieldInfoPtr_m_Disposed;

			// Token: 0x04000398 RID: 920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0;

			// Token: 0x04000399 RID: 921
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400039A RID: 922
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool m_Disposed;
		}

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060006E1 RID: 1761
		private delegate bool get_enabledDelegate();

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060006E3 RID: 1763
		private delegate void ReapplyDelegate();

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060006E5 RID: 1765
		private delegate void get_topmostRect_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060006E7 RID: 1767
		private delegate void Internal_Push_InjectedDelegate(IntPtr screenRect, IntPtr scrollOffset, IntPtr renderOffset, bool resetOffset);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060006E9 RID: 1769
		private delegate void GetTopRect_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060006EB RID: 1771
		private delegate void Unclip_Vector2_InjectedDelegate(IntPtr pos, [Out] IntPtr ret);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060006ED RID: 1773
		private delegate void Unclip_Rect_InjectedDelegate(IntPtr rect, [Out] IntPtr ret);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060006EF RID: 1775
		private delegate void Clip_Vector2_InjectedDelegate(IntPtr absolutePos, [Out] IntPtr ret);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060006F1 RID: 1777
		private delegate void Internal_Clip_Rect_InjectedDelegate(IntPtr absoluteRect, [Out] IntPtr ret);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060006F3 RID: 1779
		private delegate void UnclipToWindow_Vector2_InjectedDelegate(IntPtr pos, [Out] IntPtr ret);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060006F5 RID: 1781
		private delegate void UnclipToWindow_Rect_InjectedDelegate(IntPtr rect, [Out] IntPtr ret);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060006F7 RID: 1783
		private delegate void ClipToWindow_Vector2_InjectedDelegate(IntPtr absolutePos, [Out] IntPtr ret);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060006F9 RID: 1785
		private delegate void ClipToWindow_Rect_InjectedDelegate(IntPtr absoluteRect, [Out] IntPtr ret);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060006FB RID: 1787
		private delegate void Internal_GetAbsoluteMousePosition_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060006FD RID: 1789
		private delegate void GetParentMatrix_InjectedDelegate([Out] IntPtr ret);
	}
}
