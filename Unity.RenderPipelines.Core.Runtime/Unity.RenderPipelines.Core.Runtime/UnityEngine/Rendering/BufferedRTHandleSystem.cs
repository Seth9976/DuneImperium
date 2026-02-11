using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B5 RID: 181
	public class BufferedRTHandleSystem : Object
	{
		// Token: 0x06000CCD RID: 3277 RVA: 0x0003AF9C File Offset: 0x0003919C
		// Note: this type is marked as 'beforefieldinit'.
		static BufferedRTHandleSystem()
		{
			Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BufferedRTHandleSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr);
			BufferedRTHandleSystem.NativeFieldInfoPtr_m_RTHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, "m_RTHandles");
			BufferedRTHandleSystem.NativeFieldInfoPtr_m_RTHandleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, "m_RTHandleSystem");
			BufferedRTHandleSystem.NativeFieldInfoPtr_m_DisposedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, "m_DisposedValue");
			BufferedRTHandleSystem.NativeMethodInfoPtr_get_maxWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665130);
			BufferedRTHandleSystem.NativeMethodInfoPtr_get_maxHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665131);
			BufferedRTHandleSystem.NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665132);
			BufferedRTHandleSystem.NativeMethodInfoPtr_GetFrameRT_Public_RTHandle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665133);
			BufferedRTHandleSystem.NativeMethodInfoPtr_AllocBuffer_Public_Void_Int32_Func_3_RTHandleSystem_Int32_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665134);
			BufferedRTHandleSystem.NativeMethodInfoPtr_ReleaseBuffer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665135);
			BufferedRTHandleSystem.NativeMethodInfoPtr_SwapAndSetReferenceSize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665136);
			BufferedRTHandleSystem.NativeMethodInfoPtr_ResetReferenceSize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665137);
			BufferedRTHandleSystem.NativeMethodInfoPtr_GetNumFramesAllocated_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665138);
			BufferedRTHandleSystem.NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665139);
			BufferedRTHandleSystem.NativeMethodInfoPtr_Swap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665140);
			BufferedRTHandleSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665141);
			BufferedRTHandleSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665142);
			BufferedRTHandleSystem.NativeMethodInfoPtr_ReleaseAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665143);
			BufferedRTHandleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr, 100665144);
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0003B134 File Offset: 0x00039334
		public unsafe int maxWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_get_maxWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0003B170 File Offset: 0x00039370
		public unsafe int maxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_get_maxHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0003B1AC File Offset: 0x000393AC
		public unsafe RTHandleProperties rtHandleProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003B1E8 File Offset: 0x000393E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971741, XrefRangeEnd = 971747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle GetFrameRT(int bufferId, int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_GetFrameRT_Public_RTHandle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0003B244 File Offset: 0x00039444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971747, XrefRangeEnd = 971764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocBuffer(int bufferId, Func<RTHandleSystem, int, RTHandle> allocator, int bufferCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allocator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_AllocBuffer_Public_Void_Int32_Func_3_RTHandleSystem_Int32_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0003B2A4 File Offset: 0x000394A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971764, XrefRangeEnd = 971772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseBuffer(int bufferId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_ReleaseBuffer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0003B2E4 File Offset: 0x000394E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971772, XrefRangeEnd = 971774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapAndSetReferenceSize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_SwapAndSetReferenceSize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0003B330 File Offset: 0x00039530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971774, XrefRangeEnd = 971775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetReferenceSize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_ResetReferenceSize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0003B37C File Offset: 0x0003957C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971775, XrefRangeEnd = 971781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumFramesAllocated(int bufferId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_GetNumFramesAllocated_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0003B3C8 File Offset: 0x000395C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971781, XrefRangeEnd = 971782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateRatioAgainstMaxSize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0003B420 File Offset: 0x00039620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 971812, RefRangeEnd = 971813, XrefRangeStart = 971782, XrefRangeEnd = 971812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Swap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_Swap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0003B454 File Offset: 0x00039654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971813, XrefRangeEnd = 971816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0003B494 File Offset: 0x00039694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971816, XrefRangeEnd = 971819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0003B4C8 File Offset: 0x000396C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 971838, RefRangeEnd = 971840, XrefRangeStart = 971819, XrefRangeEnd = 971838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr_ReleaseAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0003B4FC File Offset: 0x000396FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971840, XrefRangeEnd = 971853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferedRTHandleSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferedRTHandleSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedRTHandleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00007AFB File Offset: 0x00005CFB
		public BufferedRTHandleSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0003B538 File Offset: 0x00039738
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00007B04 File Offset: 0x00005D04
		public unsafe Dictionary<int, Il2CppReferenceArray<RTHandle>> m_RTHandles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedRTHandleSystem.NativeFieldInfoPtr_m_RTHandles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<RTHandle>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedRTHandleSystem.NativeFieldInfoPtr_m_RTHandles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0003B568 File Offset: 0x00039768
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00007B23 File Offset: 0x00005D23
		public unsafe RTHandleSystem m_RTHandleSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedRTHandleSystem.NativeFieldInfoPtr_m_RTHandleSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedRTHandleSystem.NativeFieldInfoPtr_m_RTHandleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0003B598 File Offset: 0x00039798
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00007B42 File Offset: 0x00005D42
		public unsafe bool m_DisposedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedRTHandleSystem.NativeFieldInfoPtr_m_DisposedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedRTHandleSystem.NativeFieldInfoPtr_m_DisposedValue)) = value;
			}
		}

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeFieldInfoPtr_m_RTHandles;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeFieldInfoPtr_m_RTHandleSystem;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeFieldInfoPtr_m_DisposedValue;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_get_maxWidth_Public_get_Int32_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_get_maxHeight_Public_get_Int32_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_GetFrameRT_Public_RTHandle_Int32_Int32_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_AllocBuffer_Public_Void_Int32_Func_3_RTHandleSystem_Int32_RTHandle_Int32_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBuffer_Public_Void_Int32_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_SwapAndSetReferenceSize_Public_Void_Int32_Int32_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_ResetReferenceSize_Public_Void_Int32_Int32_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_GetNumFramesAllocated_Public_Int32_Int32_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Vector2_Int32_Int32_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Void_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAll_Public_Void_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
