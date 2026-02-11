using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace TMPro
{
	// Token: 0x02000072 RID: 114
	public class TMP_UpdateManager : Object
	{
		// Token: 0x06000E36 RID: 3638 RVA: 0x00039D80 File Offset: 0x00037F80
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_UpdateManager()
		{
			Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_UpdateManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr);
			TMP_UpdateManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "s_Instance");
			TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_LayoutQueueLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_LayoutRebuildQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_GraphicQueueLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_GraphicRebuildQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_InternalUpdateLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_InternalUpdateQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_CullingUpdateLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_CullingUpdateQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextObjectForUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextElementForGraphicRebuildMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextElementForCullingUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_UnregisterTextObjectForUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_UnregisterTextElementForGraphicRebuildMarker");
			TMP_UpdateManager.NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664884);
			TMP_UpdateManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664885);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664886);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664887);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664888);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664889);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664890);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664891);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664892);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664893);
			TMP_UpdateManager.NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664894);
			TMP_UpdateManager.NativeMethodInfoPtr_DoRebuilds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664895);
			TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664896);
			TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664897);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664898);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664899);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664900);
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0003A01C File Offset: 0x0003821C
		public unsafe static TMP_UpdateManager instance
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1050116, RefRangeEnd = 1050124, XrefRangeStart = 1050102, XrefRangeEnd = 1050116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_UpdateManager>(intPtr3) : null;
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0003A050 File Offset: 0x00038250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050176, RefRangeEnd = 1050177, XrefRangeStart = 1050124, XrefRangeEnd = 1050176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_UpdateManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0003A08C File Offset: 0x0003828C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1050191, RefRangeEnd = 1050195, XrefRangeStart = 1050177, XrefRangeEnd = 1050191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextObjectForUpdate(TMP_Text textObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0003A0C4 File Offset: 0x000382C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050195, XrefRangeEnd = 1050205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0003A108 File Offset: 0x00038308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050219, RefRangeEnd = 1050220, XrefRangeStart = 1050205, XrefRangeEnd = 1050219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0003A140 File Offset: 0x00038340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050220, XrefRangeEnd = 1050230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0003A184 File Offset: 0x00038384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050244, RefRangeEnd = 1050245, XrefRangeStart = 1050230, XrefRangeEnd = 1050244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0003A1BC File Offset: 0x000383BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050245, XrefRangeEnd = 1050255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0003A200 File Offset: 0x00038400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050269, RefRangeEnd = 1050270, XrefRangeStart = 1050255, XrefRangeEnd = 1050269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForCullingUpdate(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0003A238 File Offset: 0x00038438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050270, XrefRangeEnd = 1050280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForCullingUpdate(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0003A27C File Offset: 0x0003847C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050280, XrefRangeEnd = 1050281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCameraPreCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0003A2B0 File Offset: 0x000384B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050306, RefRangeEnd = 1050307, XrefRangeStart = 1050281, XrefRangeEnd = 1050306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoRebuilds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_DoRebuilds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0003A2E4 File Offset: 0x000384E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1050340, RefRangeEnd = 1050346, XrefRangeStart = 1050307, XrefRangeEnd = 1050340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0003A31C File Offset: 0x0003851C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1050374, RefRangeEnd = 1050376, XrefRangeStart = 1050346, XrefRangeEnd = 1050374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterTextElementForRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0003A354 File Offset: 0x00038554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050376, XrefRangeEnd = 1050384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003A398 File Offset: 0x00038598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050384, XrefRangeEnd = 1050392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0003A3DC File Offset: 0x000385DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050392, XrefRangeEnd = 1050400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00008AD6 File Offset: 0x00006CD6
		public TMP_UpdateManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0003A420 File Offset: 0x00038620
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00008ADF File Offset: 0x00006CDF
		public unsafe static TMP_UpdateManager s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_UpdateManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0003A448 File Offset: 0x00038648
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x00008AF1 File Offset: 0x00006CF1
		public unsafe HashSet<int> m_LayoutQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0003A478 File Offset: 0x00038678
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00008B10 File Offset: 0x00006D10
		public unsafe List<TMP_Text> m_LayoutRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003A4A8 File Offset: 0x000386A8
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00008B2F File Offset: 0x00006D2F
		public unsafe HashSet<int> m_GraphicQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0003A4D8 File Offset: 0x000386D8
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00008B4E File Offset: 0x00006D4E
		public unsafe List<TMP_Text> m_GraphicRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0003A508 File Offset: 0x00038708
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00008B6D File Offset: 0x00006D6D
		public unsafe HashSet<int> m_InternalUpdateLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0003A538 File Offset: 0x00038738
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00008B8C File Offset: 0x00006D8C
		public unsafe List<TMP_Text> m_InternalUpdateQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0003A568 File Offset: 0x00038768
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00008BAB File Offset: 0x00006DAB
		public unsafe HashSet<int> m_CullingUpdateLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0003A598 File Offset: 0x00038798
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00008BCA File Offset: 0x00006DCA
		public unsafe List<TMP_Text> m_CullingUpdateQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0003A5C8 File Offset: 0x000387C8
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00008BE9 File Offset: 0x00006DE9
		public unsafe static ProfilerMarker k_RegisterTextObjectForUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0003A5E4 File Offset: 0x000387E4
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00008BF7 File Offset: 0x00006DF7
		public unsafe static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker, (void*)(&value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0003A600 File Offset: 0x00038800
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00008C05 File Offset: 0x00006E05
		public unsafe static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0003A61C File Offset: 0x0003881C
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00008C13 File Offset: 0x00006E13
		public unsafe static ProfilerMarker k_UnregisterTextObjectForUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0003A638 File Offset: 0x00038838
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00008C21 File Offset: 0x00006E21
		public unsafe static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker, (void*)(&value));
			}
		}

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutQueueLookup;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicQueueLookup;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalUpdateLookup;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalUpdateQueue;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateLookup;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateQueue;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_DoRebuilds_Private_Void_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0;
	}
}
