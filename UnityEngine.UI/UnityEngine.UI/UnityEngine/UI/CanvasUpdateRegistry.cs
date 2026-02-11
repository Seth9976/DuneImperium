using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000007 RID: 7
	public class CanvasUpdateRegistry : Object
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00008100 File Offset: 0x00006300
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasUpdateRegistry()
		{
			Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "CanvasUpdateRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr);
			CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "s_Instance");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_PerformingLayoutUpdate");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_PerformingGraphicUpdate");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_CanvasUpdateProfilerStrings");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_CullingUpdateProfilerString");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_LayoutRebuildQueue");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_GraphicRebuildQueue");
			CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "s_SortLayoutFunction");
			CanvasUpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663329);
			CanvasUpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663330);
			CanvasUpdateRegistry.NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663331);
			CanvasUpdateRegistry.NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663332);
			CanvasUpdateRegistry.NativeMethodInfoPtr_PerformUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663333);
			CanvasUpdateRegistry.NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663334);
			CanvasUpdateRegistry.NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663335);
			CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663336);
			CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663337);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663338);
			CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663339);
			CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663340);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663341);
			CanvasUpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663342);
			CanvasUpdateRegistry.NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663343);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663344);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663345);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663346);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663347);
			CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663348);
			CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663349);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00008374 File Offset: 0x00006574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081093, RefRangeEnd = 1081094, XrefRangeStart = 1081052, XrefRangeEnd = 1081093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasUpdateRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000083B0 File Offset: 0x000065B0
		public unsafe static CanvasUpdateRegistry instance
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1081108, RefRangeEnd = 1081130, XrefRangeStart = 1081094, XrefRangeEnd = 1081108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasUpdateRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000083E4 File Offset: 0x000065E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081136, RefRangeEnd = 1081138, XrefRangeStart = 1081130, XrefRangeEnd = 1081136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValidForUpdate(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00008434 File Offset: 0x00006634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081164, RefRangeEnd = 1081165, XrefRangeStart = 1081138, XrefRangeEnd = 1081164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanInvalidItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00008468 File Offset: 0x00006668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081165, XrefRangeEnd = 1081238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_PerformUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000849C File Offset: 0x0000669C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081248, RefRangeEnd = 1081250, XrefRangeStart = 1081238, XrefRangeEnd = 1081248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParentCount(Transform child)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000084E0 File Offset: 0x000066E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081250, XrefRangeEnd = 1081260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00008534 File Offset: 0x00006734
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1081266, RefRangeEnd = 1081269, XrefRangeStart = 1081260, XrefRangeEnd = 1081266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000856C File Offset: 0x0000676C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081275, RefRangeEnd = 1081277, XrefRangeStart = 1081269, XrefRangeEnd = 1081275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000085B0 File Offset: 0x000067B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081283, RefRangeEnd = 1081285, XrefRangeStart = 1081277, XrefRangeEnd = 1081283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00008600 File Offset: 0x00006800
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1081291, RefRangeEnd = 1081309, XrefRangeStart = 1081285, XrefRangeEnd = 1081291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00008638 File Offset: 0x00006838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081309, XrefRangeEnd = 1081315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000867C File Offset: 0x0000687C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1081325, RefRangeEnd = 1081330, XrefRangeStart = 1081315, XrefRangeEnd = 1081325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000086CC File Offset: 0x000068CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1081381, RefRangeEnd = 1081386, XrefRangeStart = 1081330, XrefRangeEnd = 1081381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00008704 File Offset: 0x00006904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081427, RefRangeEnd = 1081429, XrefRangeStart = 1081386, XrefRangeEnd = 1081427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableCanvasElementForRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000873C File Offset: 0x0000693C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081429, XrefRangeEnd = 1081447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00008780 File Offset: 0x00006980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081447, XrefRangeEnd = 1081465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000087C4 File Offset: 0x000069C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081465, XrefRangeEnd = 1081483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00008808 File Offset: 0x00006A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081483, XrefRangeEnd = 1081501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000884C File Offset: 0x00006A4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1081505, RefRangeEnd = 1081511, XrefRangeStart = 1081501, XrefRangeEnd = 1081505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRebuildingLayout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000887C File Offset: 0x00006A7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1081515, RefRangeEnd = 1081518, XrefRangeStart = 1081511, XrefRangeEnd = 1081515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRebuildingGraphics()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002188 File Offset: 0x00000388
		public CanvasUpdateRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000088AC File Offset: 0x00006AAC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002191 File Offset: 0x00000391
		public unsafe static CanvasUpdateRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasUpdateRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000088D4 File Offset: 0x00006AD4
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000021A3 File Offset: 0x000003A3
		public unsafe bool m_PerformingLayoutUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000088FC File Offset: 0x00006AFC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000021BE File Offset: 0x000003BE
		public unsafe bool m_PerformingGraphicUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00008924 File Offset: 0x00006B24
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000021D9 File Offset: 0x000003D9
		public unsafe Il2CppStringArray m_CanvasUpdateProfilerStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00008954 File Offset: 0x00006B54
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000021F8 File Offset: 0x000003F8
		public unsafe static string m_CullingUpdateProfilerString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00008974 File Offset: 0x00006B74
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000220A File Offset: 0x0000040A
		public unsafe IndexedSet<ICanvasElement> m_LayoutRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedSet<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000089A4 File Offset: 0x00006BA4
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002229 File Offset: 0x00000429
		public unsafe IndexedSet<ICanvasElement> m_GraphicRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedSet<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000089D4 File Offset: 0x00006BD4
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002248 File Offset: 0x00000448
		public unsafe static Comparison<ICanvasElement> s_SortLayoutFunction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformingLayoutUpdate;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformingGraphicUpdate;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateProfilerString;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_s_SortLayoutFunction;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_PerformUpdate_Private_Void_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0;
	}
}
