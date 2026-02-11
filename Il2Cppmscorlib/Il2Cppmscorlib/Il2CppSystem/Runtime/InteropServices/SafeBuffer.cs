using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200037E RID: 894
	public class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06003780 RID: 14208 RVA: 0x0010F9F4 File Offset: 0x0010DBF4
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBuffer()
		{
			Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "SafeBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr);
			SafeBuffer.NativeFieldInfoPtr_Uninitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, "Uninitialized");
			SafeBuffer.NativeFieldInfoPtr__numBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, "_numBytes");
			SafeBuffer.NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100671616);
			SafeBuffer.NativeMethodInfoPtr_ReleasePointer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100671617);
			SafeBuffer.NativeMethodInfoPtr_NotInitialized_Private_Static_InvalidOperationException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100671618);
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x0010FA88 File Offset: 0x0010DC88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1391297, RefRangeEnd = 1391301, XrefRangeStart = 1391290, XrefRangeEnd = 1391297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquirePointer(ref byte* pointer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(pointer);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SafeBuffer.NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pointer = ((intPtr4 == 0) ? null : new byte*(intPtr4));
			}
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x0010FAE0 File Offset: 0x0010DCE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1391318, RefRangeEnd = 1391322, XrefRangeStart = 1391301, XrefRangeEnd = 1391318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBuffer.NativeMethodInfoPtr_ReleasePointer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x0010FB14 File Offset: 0x0010DD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391328, RefRangeEnd = 1391329, XrefRangeStart = 1391322, XrefRangeEnd = 1391328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InvalidOperationException NotInitialized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBuffer.NativeMethodInfoPtr_NotInitialized_Private_Static_InvalidOperationException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvalidOperationException>(intPtr3) : null;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00014468 File Offset: 0x00012668
		public SafeBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x0010FB48 File Offset: 0x0010DD48
		// (set) Token: 0x06003786 RID: 14214 RVA: 0x00014471 File Offset: 0x00012671
		public unsafe static UIntPtr Uninitialized
		{
			get
			{
				UIntPtr uintPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeBuffer.NativeFieldInfoPtr_Uninitialized, (void*)(&uintPtr));
				return uintPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeBuffer.NativeFieldInfoPtr_Uninitialized, (void*)(&value));
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x0010FB64 File Offset: 0x0010DD64
		// (set) Token: 0x06003788 RID: 14216 RVA: 0x0001447F File Offset: 0x0001267F
		public unsafe UIntPtr _numBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBuffer.NativeFieldInfoPtr__numBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBuffer.NativeFieldInfoPtr__numBytes)) = value;
			}
		}

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeFieldInfoPtr_Uninitialized;

		// Token: 0x04002D19 RID: 11545
		private static readonly IntPtr NativeFieldInfoPtr__numBytes;

		// Token: 0x04002D1A RID: 11546
		private static readonly IntPtr NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0;

		// Token: 0x04002D1B RID: 11547
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Void_0;

		// Token: 0x04002D1C RID: 11548
		private static readonly IntPtr NativeMethodInfoPtr_NotInitialized_Private_Static_InvalidOperationException_0;
	}
}
