using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000019 RID: 25
	public sealed class RenderGraphLogIndent : ValueType
	{
		// Token: 0x06000278 RID: 632 RVA: 0x00016728 File Offset: 0x00014928
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphLogIndent()
		{
			Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphLogIndent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr);
			RenderGraphLogIndent.NativeFieldInfoPtr_m_Indentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr, "m_Indentation");
			RenderGraphLogIndent.NativeFieldInfoPtr_m_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr, "m_Logger");
			RenderGraphLogIndent.NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr, "m_Disposed");
			RenderGraphLogIndent.NativeMethodInfoPtr__ctor_Public_Void_RenderGraphLogger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr, 100663585);
			RenderGraphLogIndent.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr, 100663586);
			RenderGraphLogIndent.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr, 100663587);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000167D0 File Offset: 0x000149D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956856, XrefRangeEnd = 956860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphLogIndent(RenderGraphLogger logger, int indentation = 1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indentation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogIndent.NativeMethodInfoPtr__ctor_Public_Void_RenderGraphLogger_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00016830 File Offset: 0x00014A30
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 956864, RefRangeEnd = 956870, XrefRangeStart = 956860, XrefRangeEnd = 956864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogIndent.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00016868 File Offset: 0x00014A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956870, XrefRangeEnd = 956874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphLogIndent.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000030F2 File Offset: 0x000012F2
		public RenderGraphLogIndent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000030FB File Offset: 0x000012FB
		public RenderGraphLogIndent()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphLogIndent>.NativeClassPtr))
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600027E RID: 638 RVA: 0x000168AC File Offset: 0x00014AAC
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000310D File Offset: 0x0000130D
		public unsafe int m_Indentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogIndent.NativeFieldInfoPtr_m_Indentation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogIndent.NativeFieldInfoPtr_m_Indentation)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000168D4 File Offset: 0x00014AD4
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00003128 File Offset: 0x00001328
		public unsafe RenderGraphLogger m_Logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogIndent.NativeFieldInfoPtr_m_Logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphLogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogIndent.NativeFieldInfoPtr_m_Logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00016904 File Offset: 0x00014B04
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00003147 File Offset: 0x00001347
		public unsafe bool m_Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogIndent.NativeFieldInfoPtr_m_Disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphLogIndent.NativeFieldInfoPtr_m_Disposed)) = value;
			}
		}

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_m_Indentation;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_m_Logger;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_m_Disposed;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderGraphLogger_Int32_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;
	}
}
