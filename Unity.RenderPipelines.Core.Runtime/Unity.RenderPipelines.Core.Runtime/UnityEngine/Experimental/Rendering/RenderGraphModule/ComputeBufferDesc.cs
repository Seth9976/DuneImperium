using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000020 RID: 32
	public sealed class ComputeBufferDesc : ValueType
	{
		// Token: 0x060002FC RID: 764 RVA: 0x000185AC File Offset: 0x000167AC
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeBufferDesc()
		{
			Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "ComputeBufferDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr);
			ComputeBufferDesc.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr, "count");
			ComputeBufferDesc.NativeFieldInfoPtr_stride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr, "stride");
			ComputeBufferDesc.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr, "type");
			ComputeBufferDesc.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr, "name");
			ComputeBufferDesc.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr, 100663661);
			ComputeBufferDesc.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr, 100663662);
			ComputeBufferDesc.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr, 100663663);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00018668 File Offset: 0x00016868
		[CallerCount(0)]
		public unsafe ComputeBufferDesc(int count, int stride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferDesc.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000186C4 File Offset: 0x000168C4
		[CallerCount(0)]
		public unsafe ComputeBufferDesc(int count, int stride, ComputeBufferType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferDesc.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001872C File Offset: 0x0001692C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957370, XrefRangeEnd = 957371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferDesc.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000343B File Offset: 0x0000163B
		public ComputeBufferDesc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00003444 File Offset: 0x00001644
		public ComputeBufferDesc()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBufferDesc>.NativeClassPtr))
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00018770 File Offset: 0x00016970
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00003456 File Offset: 0x00001656
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBufferDesc.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBufferDesc.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00018798 File Offset: 0x00016998
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00003471 File Offset: 0x00001671
		public unsafe int stride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBufferDesc.NativeFieldInfoPtr_stride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBufferDesc.NativeFieldInfoPtr_stride)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000187C0 File Offset: 0x000169C0
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000348C File Offset: 0x0000168C
		public unsafe ComputeBufferType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBufferDesc.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBufferDesc.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000187E8 File Offset: 0x000169E8
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000034A7 File Offset: 0x000016A7
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBufferDesc.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBufferDesc.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_stride;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
