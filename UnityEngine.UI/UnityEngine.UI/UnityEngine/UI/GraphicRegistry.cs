using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000014 RID: 20
	public class GraphicRegistry : Object
	{
		// Token: 0x060001DB RID: 475 RVA: 0x0000E3D4 File Offset: 0x0000C5D4
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicRegistry()
		{
			Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GraphicRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr);
			GraphicRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "s_Instance");
			GraphicRegistry.NativeFieldInfoPtr_m_Graphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "m_Graphics");
			GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "m_RaycastableGraphics");
			GraphicRegistry.NativeFieldInfoPtr_s_EmptyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "s_EmptyList");
			GraphicRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663601);
			GraphicRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663602);
			GraphicRegistry.NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663603);
			GraphicRegistry.NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663604);
			GraphicRegistry.NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663605);
			GraphicRegistry.NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663606);
			GraphicRegistry.NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663607);
			GraphicRegistry.NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663608);
			GraphicRegistry.NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663609);
			GraphicRegistry.NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663610);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000E51C File Offset: 0x0000C71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084716, XrefRangeEnd = 1084753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000E558 File Offset: 0x0000C758
		public unsafe static GraphicRegistry instance
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1084803, RefRangeEnd = 1084820, XrefRangeStart = 1084753, XrefRangeEnd = 1084803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000E58C File Offset: 0x0000C78C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1084851, RefRangeEnd = 1084855, XrefRangeStart = 1084820, XrefRangeEnd = 1084851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000E5D4 File Offset: 0x0000C7D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1084885, RefRangeEnd = 1084888, XrefRangeStart = 1084855, XrefRangeEnd = 1084885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000E61C File Offset: 0x0000C81C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1084917, RefRangeEnd = 1084923, XrefRangeStart = 1084888, XrefRangeEnd = 1084917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000E664 File Offset: 0x0000C864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1084947, RefRangeEnd = 1084949, XrefRangeStart = 1084923, XrefRangeEnd = 1084947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000E6AC File Offset: 0x0000C8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084997, RefRangeEnd = 1084998, XrefRangeStart = 1084949, XrefRangeEnd = 1084997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000E6F4 File Offset: 0x0000C8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084998, XrefRangeEnd = 1085021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000E73C File Offset: 0x0000C93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085021, XrefRangeEnd = 1085031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Graphic>>(intPtr3) : null;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000E780 File Offset: 0x0000C980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085031, XrefRangeEnd = 1085041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Graphic>>(intPtr3) : null;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002AA2 File Offset: 0x00000CA2
		public GraphicRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002AAB File Offset: 0x00000CAB
		public unsafe static GraphicRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002ABD File Offset: 0x00000CBD
		public unsafe Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_Graphics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Canvas, IndexedSet<Graphic>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_Graphics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000E81C File Offset: 0x0000CA1C
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002ADC File Offset: 0x00000CDC
		public unsafe Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Canvas, IndexedSet<Graphic>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000E84C File Offset: 0x0000CA4C
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002AFB File Offset: 0x00000CFB
		public unsafe static List<Graphic> s_EmptyList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRegistry.NativeFieldInfoPtr_s_EmptyList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRegistry.NativeFieldInfoPtr_s_EmptyList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_m_Graphics;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastableGraphics;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyList;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0;
	}
}
