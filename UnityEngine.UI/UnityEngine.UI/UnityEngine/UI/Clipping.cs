using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200000A RID: 10
	public static class Clipping : Object
	{
		// Token: 0x06000082 RID: 130 RVA: 0x000022B4 File Offset: 0x000004B4
		// Note: this type is marked as 'beforefieldinit'.
		static Clipping()
		{
			Il2CppClassPointerStore<Clipping>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Clipping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clipping>.NativeClassPtr);
			Clipping.NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipping>.NativeClassPtr, 100663377);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000092D8 File Offset: 0x000074D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081618, RefRangeEnd = 1081619, XrefRangeStart = 1081605, XrefRangeEnd = 1081618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectMaskParents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipping.NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000022ED File Offset: 0x000004ED
		public Clipping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0;
	}
}
