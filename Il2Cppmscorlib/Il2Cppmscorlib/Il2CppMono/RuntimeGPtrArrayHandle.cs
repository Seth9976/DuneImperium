using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct RuntimeGPtrArrayHandle
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00026478 File Offset: 0x00024678
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeGPtrArrayHandle()
		{
			Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeGPtrArrayHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr);
			RuntimeGPtrArrayHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, "value");
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663407);
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663408);
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663409);
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663410);
			RuntimeGPtrArrayHandle.NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, 100663411);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00026520 File Offset: 0x00024720
		public unsafe int Length
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1275957, RefRangeEnd = 1275963, XrefRangeStart = 1275957, XrefRangeEnd = 1275957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000D RID: 13
		public unsafe IntPtr this[int i]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1275964, RefRangeEnd = 1275970, XrefRangeStart = 1275963, XrefRangeEnd = 1275964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00026590 File Offset: 0x00024790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275970, RefRangeEnd = 1275972, XrefRangeStart = 1275970, XrefRangeEnd = 1275970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Lookup(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000265D0 File Offset: 0x000247D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275972, XrefRangeEnd = 1275973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GPtrArrayFree(RuntimeStructs.GPtrArray* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00026604 File Offset: 0x00024804
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1275974, RefRangeEnd = 1275986, XrefRangeStart = 1275973, XrefRangeEnd = 1275974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyAndFree(ref RuntimeGPtrArrayHandle h)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &h;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeGPtrArrayHandle.NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000021F9 File Offset: 0x000003F9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeGPtrArrayHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Lookup_Internal_IntPtr_Int32_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_GPtrArrayFree_Private_Static_Void_ptr_GPtrArray_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAndFree_Internal_Static_Void_byref_RuntimeGPtrArrayHandle_0;

		// Token: 0x0400003B RID: 59
		[FieldOffset(0)]
		public IntPtr value;
	}
}
