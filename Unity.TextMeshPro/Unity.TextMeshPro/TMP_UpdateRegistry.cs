using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000073 RID: 115
	public class TMP_UpdateRegistry : Object
	{
		// Token: 0x06000E65 RID: 3685 RVA: 0x0003A654 File Offset: 0x00038854
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_UpdateRegistry()
		{
			Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_UpdateRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr);
			TMP_UpdateRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "s_Instance");
			TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "m_LayoutRebuildQueue");
			TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "m_LayoutQueueLookup");
			TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "m_GraphicRebuildQueue");
			TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "m_GraphicQueueLookup");
			TMP_UpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_UpdateRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664902);
			TMP_UpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664903);
			TMP_UpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664904);
			TMP_UpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664905);
			TMP_UpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664906);
			TMP_UpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664907);
			TMP_UpdateRegistry.NativeMethodInfoPtr_PerformUpdateForCanvasRendererObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664908);
			TMP_UpdateRegistry.NativeMethodInfoPtr_PerformUpdateForMeshRendererObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664909);
			TMP_UpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664910);
			TMP_UpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664911);
			TMP_UpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664912);
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0003A7C4 File Offset: 0x000389C4
		public unsafe static TMP_UpdateRegistry instance
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1050439, RefRangeEnd = 1050449, XrefRangeStart = 1050400, XrefRangeEnd = 1050439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_UpdateRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_UpdateRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0003A7F8 File Offset: 0x000389F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050449, XrefRangeEnd = 1050481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_UpdateRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0003A834 File Offset: 0x00038A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050481, XrefRangeEnd = 1050494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0003A86C File Offset: 0x00038A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050494, XrefRangeEnd = 1050506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0003A8BC File Offset: 0x00038ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050506, XrefRangeEnd = 1050519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0003A8F4 File Offset: 0x00038AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050519, XrefRangeEnd = 1050531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0003A944 File Offset: 0x00038B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050531, XrefRangeEnd = 1050556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformUpdateForCanvasRendererObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_PerformUpdateForCanvasRendererObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0003A978 File Offset: 0x00038B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050556, XrefRangeEnd = 1050562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformUpdateForMeshRendererObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_PerformUpdateForMeshRendererObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0003A9AC File Offset: 0x00038BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050562, XrefRangeEnd = 1050585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0003A9E4 File Offset: 0x00038BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050585, XrefRangeEnd = 1050596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0003AA28 File Offset: 0x00038C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050596, XrefRangeEnd = 1050607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00008C2F File Offset: 0x00006E2F
		public TMP_UpdateRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0003AA6C File Offset: 0x00038C6C
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00008C38 File Offset: 0x00006E38
		public unsafe static TMP_UpdateRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_UpdateRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0003AA94 File Offset: 0x00038C94
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00008C4A File Offset: 0x00006E4A
		public unsafe List<ICanvasElement> m_LayoutRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0003AAC4 File Offset: 0x00038CC4
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00008C69 File Offset: 0x00006E69
		public unsafe HashSet<int> m_LayoutQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0003AAF4 File Offset: 0x00038CF4
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00008C88 File Offset: 0x00006E88
		public unsafe List<ICanvasElement> m_GraphicRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0003AB24 File Offset: 0x00038D24
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00008CA7 File Offset: 0x00006EA7
		public unsafe HashSet<int> m_GraphicQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutQueueLookup;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicQueueLookup;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_UpdateRegistry_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_PerformUpdateForCanvasRendererObjects_Private_Void_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_PerformUpdateForMeshRendererObjects_Private_Void_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;
	}
}
