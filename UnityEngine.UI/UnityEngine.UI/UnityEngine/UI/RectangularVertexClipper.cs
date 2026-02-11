using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200000D RID: 13
	public class RectangularVertexClipper : Object
	{
		// Token: 0x06000090 RID: 144 RVA: 0x000095D4 File Offset: 0x000077D4
		// Note: this type is marked as 'beforefieldinit'.
		static RectangularVertexClipper()
		{
			Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "RectangularVertexClipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr);
			RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, "m_WorldCorners");
			RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, "m_CanvasCorners");
			RectangularVertexClipper.NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, 100663385);
			RectangularVertexClipper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, 100663386);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009654 File Offset: 0x00007854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081628, RefRangeEnd = 1081629, XrefRangeStart = 1081619, XrefRangeEnd = 1081628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangularVertexClipper.NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000096B4 File Offset: 0x000078B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081637, RefRangeEnd = 1081638, XrefRangeStart = 1081629, XrefRangeEnd = 1081637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectangularVertexClipper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangularVertexClipper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002337 File Offset: 0x00000537
		public RectangularVertexClipper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000096F0 File Offset: 0x000078F0
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002340 File Offset: 0x00000540
		public unsafe Il2CppStructArray<Vector3> m_WorldCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00009720 File Offset: 0x00007920
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000235F File Offset: 0x0000055F
		public unsafe Il2CppStructArray<Vector3> m_CanvasCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldCorners;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasCorners;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
