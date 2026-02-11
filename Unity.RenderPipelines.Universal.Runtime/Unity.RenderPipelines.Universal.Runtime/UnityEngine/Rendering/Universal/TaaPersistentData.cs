using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000D9 RID: 217
	public sealed class TaaPersistentData : Object
	{
		// Token: 0x060010B5 RID: 4277 RVA: 0x0004F960 File Offset: 0x0004DB60
		// Note: this type is marked as 'beforefieldinit'.
		static TaaPersistentData()
		{
			Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TaaPersistentData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr);
			TaaPersistentData.NativeFieldInfoPtr_formatList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, "formatList");
			TaaPersistentData.NativeFieldInfoPtr_m_RtDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, "m_RtDesc");
			TaaPersistentData.NativeFieldInfoPtr_m_AccumulationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, "m_AccumulationTexture");
			TaaPersistentData.NativeFieldInfoPtr_m_AccumulationTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, "m_AccumulationTexture2");
			TaaPersistentData.NativeFieldInfoPtr_m_LastAccumUpdateFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, "m_LastAccumUpdateFrameIndex");
			TaaPersistentData.NativeFieldInfoPtr_m_LastAccumUpdateFrameIndex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, "m_LastAccumUpdateFrameIndex2");
			TaaPersistentData.NativeMethodInfoPtr_get_rtd_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665426);
			TaaPersistentData.NativeMethodInfoPtr_accumulationTexture_Public_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665427);
			TaaPersistentData.NativeMethodInfoPtr_GetLastAccumFrameIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665428);
			TaaPersistentData.NativeMethodInfoPtr_SetLastAccumFrameIndex_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665429);
			TaaPersistentData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665430);
			TaaPersistentData.NativeMethodInfoPtr_Init_Public_Void_Int32_Int32_Int32_GraphicsFormat_VRTextureUsage_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665431);
			TaaPersistentData.NativeMethodInfoPtr_AllocateTargets_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665432);
			TaaPersistentData.NativeMethodInfoPtr_DeallocateTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665433);
			TaaPersistentData.NativeMethodInfoPtr_Method_Internal_Static_GraphicsFormat_GraphicsFormat_FormatUsage_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665435);
			TaaPersistentData.NativeMethodInfoPtr_Method_Internal_Static_GraphicsFormat_FormatUsage_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr, 100665436);
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x0004FAD0 File Offset: 0x0004DCD0
		public unsafe RenderTextureDescriptor rtd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_get_rtd_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0004FB0C File Offset: 0x0004DD0C
		[CallerCount(0)]
		public unsafe RTHandle accumulationTexture(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_accumulationTexture_Public_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0004FB58 File Offset: 0x0004DD58
		[CallerCount(0)]
		public unsafe int GetLastAccumFrameIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_GetLastAccumFrameIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0004FBA4 File Offset: 0x0004DDA4
		[CallerCount(0)]
		public unsafe void SetLastAccumFrameIndex(int index, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_SetLastAccumFrameIndex_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0004FBF0 File Offset: 0x0004DDF0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaaPersistentData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaaPersistentData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0004FC2C File Offset: 0x0004DE2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 617586, RefRangeEnd = 617588, XrefRangeStart = 617554, XrefRangeEnd = 617586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(int sizeX, int sizeY, int volumeDepth, GraphicsFormat format, VRTextureUsage vrUsage, TextureDimension texDim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sizeX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texDim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_Init_Public_Void_Int32_Int32_Int32_GraphicsFormat_VRTextureUsage_TextureDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0004FCB0 File Offset: 0x0004DEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617588, XrefRangeEnd = 617601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AllocateTargets(bool xrMultipassEnabled = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xrMultipassEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_AllocateTargets_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0004FCFC File Offset: 0x0004DEFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 617605, RefRangeEnd = 617609, XrefRangeStart = 617601, XrefRangeEnd = 617605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeallocateTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_DeallocateTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0004FD30 File Offset: 0x0004DF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617609, XrefRangeEnd = 617611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat Method_Internal_Static_GraphicsFormat_GraphicsFormat_FormatUsage_PDM_0(GraphicsFormat format, FormatUsage usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_Method_Internal_Static_GraphicsFormat_GraphicsFormat_FormatUsage_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0004FD7C File Offset: 0x0004DF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617611, XrefRangeEnd = 617622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat Method_Internal_Static_GraphicsFormat_FormatUsage_PDM_0(FormatUsage usage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref usage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaPersistentData.NativeMethodInfoPtr_Method_Internal_Static_GraphicsFormat_FormatUsage_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00009F2C File Offset: 0x0000812C
		public TaaPersistentData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x0004FDBC File Offset: 0x0004DFBC
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00009F35 File Offset: 0x00008135
		public unsafe static Il2CppStructArray<GraphicsFormat> formatList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaaPersistentData.NativeFieldInfoPtr_formatList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaaPersistentData.NativeFieldInfoPtr_formatList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0004FDE4 File Offset: 0x0004DFE4
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00009F47 File Offset: 0x00008147
		public unsafe RenderTextureDescriptor m_RtDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_RtDesc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_RtDesc)) = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0004FE0C File Offset: 0x0004E00C
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00009F62 File Offset: 0x00008162
		public unsafe RTHandle m_AccumulationTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_AccumulationTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_AccumulationTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0004FE3C File Offset: 0x0004E03C
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x00009F81 File Offset: 0x00008181
		public unsafe RTHandle m_AccumulationTexture2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_AccumulationTexture2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_AccumulationTexture2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0004FE6C File Offset: 0x0004E06C
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x00009FA0 File Offset: 0x000081A0
		public unsafe int m_LastAccumUpdateFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_LastAccumUpdateFrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_LastAccumUpdateFrameIndex)) = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0004FE94 File Offset: 0x0004E094
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x00009FBB File Offset: 0x000081BB
		public unsafe int m_LastAccumUpdateFrameIndex2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_LastAccumUpdateFrameIndex2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaPersistentData.NativeFieldInfoPtr_m_LastAccumUpdateFrameIndex2)) = value;
			}
		}

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeFieldInfoPtr_formatList;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeFieldInfoPtr_m_RtDesc;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeFieldInfoPtr_m_AccumulationTexture;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeFieldInfoPtr_m_AccumulationTexture2;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr_m_LastAccumUpdateFrameIndex;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeFieldInfoPtr_m_LastAccumUpdateFrameIndex2;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_get_rtd_Public_get_RenderTextureDescriptor_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_accumulationTexture_Public_RTHandle_Int32_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_GetLastAccumFrameIndex_Public_Int32_Int32_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_SetLastAccumFrameIndex_Public_Void_Int32_Int32_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Int32_Int32_Int32_GraphicsFormat_VRTextureUsage_TextureDimension_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_AllocateTargets_Public_Boolean_Boolean_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_DeallocateTargets_Public_Void_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_GraphicsFormat_GraphicsFormat_FormatUsage_PDM_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_GraphicsFormat_FormatUsage_PDM_0;
	}
}
