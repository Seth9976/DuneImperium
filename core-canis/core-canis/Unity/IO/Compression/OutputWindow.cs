using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x0200007C RID: 124
	public class OutputWindow : Object
	{
		// Token: 0x06000946 RID: 2374 RVA: 0x000377F8 File Offset: 0x000359F8
		// Note: this type is marked as 'beforefieldinit'.
		static OutputWindow()
		{
			Il2CppClassPointerStore<OutputWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "OutputWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr);
			OutputWindow.NativeFieldInfoPtr_WindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, "WindowSize");
			OutputWindow.NativeFieldInfoPtr_WindowMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, "WindowMask");
			OutputWindow.NativeFieldInfoPtr_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, "window");
			OutputWindow.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, "end");
			OutputWindow.NativeFieldInfoPtr_bytesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, "bytesUsed");
			OutputWindow.NativeMethodInfoPtr_Write_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, 100664598);
			OutputWindow.NativeMethodInfoPtr_WriteLengthDistance_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, 100664599);
			OutputWindow.NativeMethodInfoPtr_CopyFrom_Public_Int32_InputBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, 100664600);
			OutputWindow.NativeMethodInfoPtr_get_FreeBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, 100664601);
			OutputWindow.NativeMethodInfoPtr_get_AvailableBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, 100664602);
			OutputWindow.NativeMethodInfoPtr_CopyTo_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, 100664603);
			OutputWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr, 100664604);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00037918 File Offset: 0x00035B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 861736, RefRangeEnd = 861737, XrefRangeStart = 861736, XrefRangeEnd = 861736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(byte b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputWindow.NativeMethodInfoPtr_Write_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00037958 File Offset: 0x00035B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 861737, RefRangeEnd = 861738, XrefRangeStart = 861737, XrefRangeEnd = 861737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteLengthDistance(int length, int distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputWindow.NativeMethodInfoPtr_WriteLengthDistance_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000379A4 File Offset: 0x00035BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861738, XrefRangeEnd = 861747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CopyFrom(InputBuffer input, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputWindow.NativeMethodInfoPtr_CopyFrom_Public_Int32_InputBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00037A00 File Offset: 0x00035C00
		public unsafe int FreeBytes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputWindow.NativeMethodInfoPtr_get_FreeBytes_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00037A3C File Offset: 0x00035C3C
		public unsafe int AvailableBytes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputWindow.NativeMethodInfoPtr_get_AvailableBytes_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00037A78 File Offset: 0x00035C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861747, XrefRangeEnd = 861750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CopyTo(Il2CppStructArray<byte> output, int offset, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputWindow.NativeMethodInfoPtr_CopyTo_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00037AE4 File Offset: 0x00035CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861750, XrefRangeEnd = 861755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutputWindow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00005325 File Offset: 0x00003525
		public OutputWindow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00037B20 File Offset: 0x00035D20
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0000532E File Offset: 0x0000352E
		public unsafe static int WindowSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputWindow.NativeFieldInfoPtr_WindowSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputWindow.NativeFieldInfoPtr_WindowSize, (void*)(&value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00037B3C File Offset: 0x00035D3C
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0000533C File Offset: 0x0000353C
		public unsafe static int WindowMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputWindow.NativeFieldInfoPtr_WindowMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputWindow.NativeFieldInfoPtr_WindowMask, (void*)(&value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00037B58 File Offset: 0x00035D58
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0000534A File Offset: 0x0000354A
		public unsafe Il2CppStructArray<byte> window
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputWindow.NativeFieldInfoPtr_window);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputWindow.NativeFieldInfoPtr_window), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00037B88 File Offset: 0x00035D88
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00005369 File Offset: 0x00003569
		public unsafe int end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputWindow.NativeFieldInfoPtr_end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputWindow.NativeFieldInfoPtr_end)) = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00037BB0 File Offset: 0x00035DB0
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00005384 File Offset: 0x00003584
		public unsafe int bytesUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputWindow.NativeFieldInfoPtr_bytesUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputWindow.NativeFieldInfoPtr_bytesUsed)) = value;
			}
		}

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr_WindowSize;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_WindowMask;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr_window;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr_bytesUsed;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Byte_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_WriteLengthDistance_Public_Void_Int32_Int32_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Int32_InputBuffer_Int32_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeBytes_Public_get_Int32_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableBytes_Public_get_Int32_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
