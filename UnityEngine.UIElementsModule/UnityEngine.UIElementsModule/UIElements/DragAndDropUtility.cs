using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A1 RID: 161
	public static class DragAndDropUtility : Object
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x00055044 File Offset: 0x00053244
		// Note: this type is marked as 'beforefieldinit'.
		static DragAndDropUtility()
		{
			Il2CppClassPointerStore<DragAndDropUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DragAndDropUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragAndDropUtility>.NativeClassPtr);
			DragAndDropUtility.NativeFieldInfoPtr_s_MakeDragAndDropClientFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropUtility>.NativeClassPtr, "s_MakeDragAndDropClientFunc");
			DragAndDropUtility.NativeFieldInfoPtr_s_DragAndDropEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropUtility>.NativeClassPtr, "s_DragAndDropEditor");
			DragAndDropUtility.NativeFieldInfoPtr_s_DragAndDropPlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropUtility>.NativeClassPtr, "s_DragAndDropPlayMode");
			DragAndDropUtility.NativeMethodInfoPtr_GetDragAndDrop_Internal_Static_IDragAndDrop_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropUtility>.NativeClassPtr, 100665597);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x000550C4 File Offset: 0x000532C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 308705, RefRangeEnd = 308714, XrefRangeStart = 308692, XrefRangeEnd = 308705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDragAndDrop GetDragAndDrop(IPanel panel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragAndDropUtility.NativeMethodInfoPtr_GetDragAndDrop_Internal_Static_IDragAndDrop_IPanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDragAndDrop>(intPtr3) : null;
			}
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x000080FE File Offset: 0x000062FE
		public DragAndDropUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00055108 File Offset: 0x00053308
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00008107 File Offset: 0x00006307
		public unsafe static Func<IDragAndDrop> s_MakeDragAndDropClientFunc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DragAndDropUtility.NativeFieldInfoPtr_s_MakeDragAndDropClientFunc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IDragAndDrop>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DragAndDropUtility.NativeFieldInfoPtr_s_MakeDragAndDropClientFunc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00055130 File Offset: 0x00053330
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00008119 File Offset: 0x00006319
		public unsafe static IDragAndDrop s_DragAndDropEditor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DragAndDropUtility.NativeFieldInfoPtr_s_DragAndDropEditor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDragAndDrop>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DragAndDropUtility.NativeFieldInfoPtr_s_DragAndDropEditor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00055158 File Offset: 0x00053358
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x0000812B File Offset: 0x0000632B
		public unsafe static IDragAndDrop s_DragAndDropPlayMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DragAndDropUtility.NativeFieldInfoPtr_s_DragAndDropPlayMode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDragAndDrop>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DragAndDropUtility.NativeFieldInfoPtr_s_DragAndDropPlayMode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0000813D File Offset: 0x0000633D
		public static void RegisterMakeClientFunc(Func<IDragAndDrop> makeClient)
		{
			DragAndDropUtility.s_MakeDragAndDropClientFunc = makeClient;
			DragAndDropUtility.s_DragAndDropEditor = null;
		}

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeFieldInfoPtr_s_MakeDragAndDropClientFunc;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeFieldInfoPtr_s_DragAndDropEditor;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr_s_DragAndDropPlayMode;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_GetDragAndDrop_Internal_Static_IDragAndDrop_IPanel_0;
	}
}
