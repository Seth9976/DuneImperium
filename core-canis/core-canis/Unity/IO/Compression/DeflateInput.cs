using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000067 RID: 103
	public class DeflateInput : Object
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x00030704 File Offset: 0x0002E904
		// Note: this type is marked as 'beforefieldinit'.
		static DeflateInput()
		{
			Il2CppClassPointerStore<DeflateInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "DeflateInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr);
			DeflateInput.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, "buffer");
			DeflateInput.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, "count");
			DeflateInput.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, "startIndex");
			DeflateInput.NativeMethodInfoPtr_get_Buffer_Internal_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664388);
			DeflateInput.NativeMethodInfoPtr_set_Buffer_Internal_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664389);
			DeflateInput.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664390);
			DeflateInput.NativeMethodInfoPtr_set_Count_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664391);
			DeflateInput.NativeMethodInfoPtr_get_StartIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664392);
			DeflateInput.NativeMethodInfoPtr_set_StartIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664393);
			DeflateInput.NativeMethodInfoPtr_ConsumeBytes_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664394);
			DeflateInput.NativeMethodInfoPtr_DumpState_Internal_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664395);
			DeflateInput.NativeMethodInfoPtr_RestoreState_Internal_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664396);
			DeflateInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, 100664397);
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00030838 File Offset: 0x0002EA38
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x00030878 File Offset: 0x0002EA78
		public unsafe Il2CppStructArray<byte> Buffer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_get_Buffer_Internal_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_set_Buffer_Internal_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000308BC File Offset: 0x0002EABC
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x000308F8 File Offset: 0x0002EAF8
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_set_Count_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00030938 File Offset: 0x0002EB38
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00030974 File Offset: 0x0002EB74
		public unsafe int StartIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_get_StartIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_set_StartIndex_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000309B4 File Offset: 0x0002EBB4
		[CallerCount(0)]
		public unsafe void ConsumeBytes(int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_ConsumeBytes_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000309F4 File Offset: 0x0002EBF4
		[CallerCount(0)]
		public unsafe DeflateInput.InputState DumpState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_DumpState_Internal_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00030A30 File Offset: 0x0002EC30
		[CallerCount(0)]
		public unsafe void RestoreState(DeflateInput.InputState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr_RestoreState_Internal_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00030A70 File Offset: 0x0002EC70
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflateInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0000448E File Offset: 0x0000268E
		public DeflateInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00030AAC File Offset: 0x0002ECAC
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00004497 File Offset: 0x00002697
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateInput.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateInput.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00030ADC File Offset: 0x0002ECDC
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x000044B6 File Offset: 0x000026B6
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateInput.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateInput.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00030B04 File Offset: 0x0002ED04
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x000044D1 File Offset: 0x000026D1
		public unsafe int startIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateInput.NativeFieldInfoPtr_startIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateInput.NativeFieldInfoPtr_startIndex)) = value;
			}
		}

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_startIndex;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_get_Buffer_Internal_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_set_Buffer_Internal_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_set_Count_Internal_set_Void_Int32_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_get_StartIndex_Internal_get_Int32_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_set_StartIndex_Internal_set_Void_Int32_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeBytes_Internal_Void_Int32_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_DumpState_Internal_InputState_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_RestoreState_Internal_Void_InputState_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200027E RID: 638
		[StructLayout(2)]
		public struct InputState
		{
			// Token: 0x06001F08 RID: 7944 RVA: 0x0008D7B4 File Offset: 0x0008B9B4
			// Note: this type is marked as 'beforefieldinit'.
			static InputState()
			{
				Il2CppClassPointerStore<DeflateInput.InputState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateInput>.NativeClassPtr, "InputState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateInput.InputState>.NativeClassPtr);
				DeflateInput.InputState.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateInput.InputState>.NativeClassPtr, "count");
				DeflateInput.InputState.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateInput.InputState>.NativeClassPtr, "startIndex");
			}

			// Token: 0x06001F09 RID: 7945 RVA: 0x0000D382 File Offset: 0x0000B582
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeflateInput.InputState>.NativeClassPtr, ref this));
			}

			// Token: 0x040015A9 RID: 5545
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x040015AA RID: 5546
			private static readonly IntPtr NativeFieldInfoPtr_startIndex;

			// Token: 0x040015AB RID: 5547
			[FieldOffset(0)]
			public int count;

			// Token: 0x040015AC RID: 5548
			[FieldOffset(4)]
			public int startIndex;
		}
	}
}
