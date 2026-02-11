using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Buffers
{
	// Token: 0x02000514 RID: 1300
	public sealed class MemoryHandle : ValueType
	{
		// Token: 0x06004F89 RID: 20361 RVA: 0x001724F0 File Offset: 0x001706F0
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryHandle()
		{
			Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "MemoryHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr);
			MemoryHandle.NativeFieldInfoPtr__pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr, "_pointer");
			MemoryHandle.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr, "_handle");
			MemoryHandle.NativeFieldInfoPtr__pinnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr, "_pinnable");
			MemoryHandle.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_GCHandle_IPinnable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr, 100675296);
			MemoryHandle.NativeMethodInfoPtr_get_Pointer_Public_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr, 100675297);
			MemoryHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr, 100675298);
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x00172598 File Offset: 0x00170798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426525, RefRangeEnd = 1426526, XrefRangeStart = 1426524, XrefRangeEnd = 1426525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryHandle(void* pointer, GCHandle handle = default(GCHandle), IPinnable pinnable = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pinnable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryHandle.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_GCHandle_IPinnable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x00172604 File Offset: 0x00170804
		public unsafe void* Pointer
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryHandle.NativeMethodInfoPtr_get_Pointer_Public_get_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x0017263C File Offset: 0x0017083C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1426532, RefRangeEnd = 1426542, XrefRangeStart = 1426526, XrefRangeEnd = 1426532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x0001C8A9 File Offset: 0x0001AAA9
		public MemoryHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x0001C8B2 File Offset: 0x0001AAB2
		public MemoryHandle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryHandle>.NativeClassPtr))
		{
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x00172674 File Offset: 0x00170874
		// (set) Token: 0x06004F90 RID: 20368 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
		public unsafe void* _pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryHandle.NativeFieldInfoPtr__pointer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryHandle.NativeFieldInfoPtr__pointer)) = value;
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x00172698 File Offset: 0x00170898
		// (set) Token: 0x06004F92 RID: 20370 RVA: 0x0001C8DF File Offset: 0x0001AADF
		public unsafe GCHandle _handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryHandle.NativeFieldInfoPtr__handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryHandle.NativeFieldInfoPtr__handle)) = value;
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06004F93 RID: 20371 RVA: 0x001726C0 File Offset: 0x001708C0
		// (set) Token: 0x06004F94 RID: 20372 RVA: 0x0001C8FA File Offset: 0x0001AAFA
		public unsafe IPinnable _pinnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryHandle.NativeFieldInfoPtr__pinnable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPinnable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryHandle.NativeFieldInfoPtr__pinnable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040D8 RID: 16600
		private static readonly IntPtr NativeFieldInfoPtr__pointer;

		// Token: 0x040040D9 RID: 16601
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x040040DA RID: 16602
		private static readonly IntPtr NativeFieldInfoPtr__pinnable;

		// Token: 0x040040DB RID: 16603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_GCHandle_IPinnable_0;

		// Token: 0x040040DC RID: 16604
		private static readonly IntPtr NativeMethodInfoPtr_get_Pointer_Public_get_ptr_Void_0;

		// Token: 0x040040DD RID: 16605
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
