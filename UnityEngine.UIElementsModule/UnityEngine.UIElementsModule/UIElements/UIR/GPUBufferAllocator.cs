using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200024C RID: 588
	public class GPUBufferAllocator : Object
	{
		// Token: 0x06002BAC RID: 11180 RVA: 0x000BCE48 File Offset: 0x000BB048
		// Note: this type is marked as 'beforefieldinit'.
		static GPUBufferAllocator()
		{
			Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "GPUBufferAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr);
			GPUBufferAllocator.NativeFieldInfoPtr_m_Low = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, "m_Low");
			GPUBufferAllocator.NativeFieldInfoPtr_m_High = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, "m_High");
			GPUBufferAllocator.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, 100669787);
			GPUBufferAllocator.NativeMethodInfoPtr_Allocate_Public_Alloc_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, 100669788);
			GPUBufferAllocator.NativeMethodInfoPtr_Free_Public_Void_Alloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, 100669789);
			GPUBufferAllocator.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, 100669790);
			GPUBufferAllocator.NativeMethodInfoPtr_HighLowCollide_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr, 100669791);
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x000BCF04 File Offset: 0x000BB104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349633, RefRangeEnd = 349634, XrefRangeStart = 349623, XrefRangeEnd = 349633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GPUBufferAllocator(uint maxSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUBufferAllocator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPUBufferAllocator.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000BCF4C File Offset: 0x000BB14C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 349640, RefRangeEnd = 349646, XrefRangeStart = 349634, XrefRangeEnd = 349640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alloc Allocate(uint size, bool shortLived)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shortLived;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPUBufferAllocator.NativeMethodInfoPtr_Allocate_Public_Alloc_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Alloc(intPtr);
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x000BCFA0 File Offset: 0x000BB1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349647, RefRangeEnd = 349648, XrefRangeStart = 349646, XrefRangeEnd = 349647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free(Alloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(alloc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPUBufferAllocator.NativeMethodInfoPtr_Free_Public_Void_Alloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000BCFE8 File Offset: 0x000BB1E8
		public unsafe bool isEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPUBufferAllocator.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x000BD024 File Offset: 0x000BB224
		[CallerCount(0)]
		public unsafe bool HighLowCollide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPUBufferAllocator.NativeMethodInfoPtr_HighLowCollide_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00011A92 File Offset: 0x0000FC92
		public GPUBufferAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x000BD060 File Offset: 0x000BB260
		// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x00011A9B File Offset: 0x0000FC9B
		public unsafe BestFitAllocator m_Low
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPUBufferAllocator.NativeFieldInfoPtr_m_Low);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPUBufferAllocator.NativeFieldInfoPtr_m_Low), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x000BD090 File Offset: 0x000BB290
		// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x00011ABA File Offset: 0x0000FCBA
		public unsafe BestFitAllocator m_High
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPUBufferAllocator.NativeFieldInfoPtr_m_High);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPUBufferAllocator.NativeFieldInfoPtr_m_High), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeFieldInfoPtr_m_Low;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeFieldInfoPtr_m_High;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_Alloc_UInt32_Boolean_0;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_Alloc_0;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeMethodInfoPtr_HighLowCollide_Private_Boolean_0;
	}
}
