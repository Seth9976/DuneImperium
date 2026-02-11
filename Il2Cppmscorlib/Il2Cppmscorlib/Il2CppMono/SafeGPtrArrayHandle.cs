using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000019 RID: 25
	[StructLayout(2)]
	public struct SafeGPtrArrayHandle
	{
		// Token: 0x06000088 RID: 136 RVA: 0x000279C4 File Offset: 0x00025BC4
		// Note: this type is marked as 'beforefieldinit'.
		static SafeGPtrArrayHandle()
		{
			Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "SafeGPtrArrayHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr);
			SafeGPtrArrayHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, "handle");
			SafeGPtrArrayHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, 100663419);
			SafeGPtrArrayHandle.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, 100663420);
			SafeGPtrArrayHandle.NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, 100663421);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00027A44 File Offset: 0x00025C44
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1275974, RefRangeEnd = 1275986, XrefRangeStart = 1275974, XrefRangeEnd = 1275986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeGPtrArrayHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00027A6C File Offset: 0x00025C6C
		public unsafe int Length
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1275957, RefRangeEnd = 1275963, XrefRangeStart = 1275957, XrefRangeEnd = 1275963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeGPtrArrayHandle.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		public unsafe IntPtr this[int i]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1275964, RefRangeEnd = 1275970, XrefRangeStart = 1275964, XrefRangeEnd = 1275970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeGPtrArrayHandle.NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002312 File Offset: 0x00000512
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SafeGPtrArrayHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_IntPtr_Int32_0;

		// Token: 0x0400006F RID: 111
		[FieldOffset(0)]
		public RuntimeGPtrArrayHandle handle;
	}
}
