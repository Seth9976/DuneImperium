using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200001F RID: 31
	[StructLayout(2)]
	public struct ComputeBufferHandle
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x00018408 File Offset: 0x00016608
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeBufferHandle()
		{
			Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "ComputeBufferHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr);
			ComputeBufferHandle.NativeFieldInfoPtr_s_NullHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr, "s_NullHandle");
			ComputeBufferHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr, "handle");
			ComputeBufferHandle.NativeMethodInfoPtr_get_nullHandle_Public_Static_get_ComputeBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr, 100663656);
			ComputeBufferHandle.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr, 100663657);
			ComputeBufferHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_ComputeBuffer_ComputeBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr, 100663658);
			ComputeBufferHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr, 100663659);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000184B0 File Offset: 0x000166B0
		public unsafe static ComputeBufferHandle nullHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957351, XrefRangeEnd = 957355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferHandle.NativeMethodInfoPtr_get_nullHandle_Public_Static_get_ComputeBufferHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000184E0 File Offset: 0x000166E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957355, XrefRangeEnd = 957356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle(int handle, bool shared = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shared;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferHandle.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00018520 File Offset: 0x00016720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957356, XrefRangeEnd = 957366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ComputeBuffer(ComputeBufferHandle buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_ComputeBuffer_ComputeBufferHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00018560 File Offset: 0x00016760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957366, XrefRangeEnd = 957370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBufferHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000341B File Offset: 0x0000161B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ComputeBufferHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00018590 File Offset: 0x00016790
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000342D File Offset: 0x0000162D
		public unsafe static ComputeBufferHandle s_NullHandle
		{
			get
			{
				ComputeBufferHandle computeBufferHandle;
				IL2CPP.il2cpp_field_static_get_value(ComputeBufferHandle.NativeFieldInfoPtr_s_NullHandle, (void*)(&computeBufferHandle));
				return computeBufferHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeBufferHandle.NativeFieldInfoPtr_s_NullHandle, (void*)(&value));
			}
		}

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_s_NullHandle;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_nullHandle_Public_Static_get_ComputeBufferHandle_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ComputeBuffer_ComputeBufferHandle_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400020C RID: 524
		[FieldOffset(0)]
		public ResourceHandle handle;
	}
}
