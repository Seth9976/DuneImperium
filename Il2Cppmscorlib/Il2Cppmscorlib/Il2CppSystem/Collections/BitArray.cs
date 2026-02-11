using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004CD RID: 1229
	[Serializable]
	public sealed class BitArray : Object
	{
		// Token: 0x06004B5B RID: 19291 RVA: 0x0015C1E0 File Offset: 0x0015A3E0
		// Note: this type is marked as 'beforefieldinit'.
		static BitArray()
		{
			Il2CppClassPointerStore<BitArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "BitArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArray>.NativeClassPtr);
			BitArray.NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray>.NativeClassPtr, "m_array");
			BitArray.NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray>.NativeClassPtr, "m_length");
			BitArray.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray>.NativeClassPtr, "_version");
			BitArray.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray>.NativeClassPtr, "_syncRoot");
			BitArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674358);
			BitArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674359);
			BitArray.NativeMethodInfoPtr__ctor_Public_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674360);
			BitArray.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674361);
			BitArray.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674362);
			BitArray.NativeMethodInfoPtr_Get_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674363);
			BitArray.NativeMethodInfoPtr_Set_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674364);
			BitArray.NativeMethodInfoPtr_SetAll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674365);
			BitArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674366);
			BitArray.NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674367);
			BitArray.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674368);
			BitArray.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674369);
			BitArray.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674370);
			BitArray.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674371);
			BitArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674372);
			BitArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674373);
			BitArray.NativeMethodInfoPtr_GetArrayLength_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray>.NativeClassPtr, 100674374);
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x0015C3B4 File Offset: 0x0015A5B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1415765, RefRangeEnd = 1415768, XrefRangeStart = 1415758, XrefRangeEnd = 1415765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray(int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x0015C3FC File Offset: 0x0015A5FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1415775, RefRangeEnd = 1415776, XrefRangeStart = 1415768, XrefRangeEnd = 1415775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray(int length, bool defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x0015C454 File Offset: 0x0015A654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415776, XrefRangeEnd = 1415783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray(BitArray bits)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr__ctor_Public_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001359 RID: 4953
		public unsafe bool this[int index]
		{
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 1415783, RefRangeEnd = 1415865, XrefRangeStart = 1415783, XrefRangeEnd = 1415783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1415865, RefRangeEnd = 1415870, XrefRangeStart = 1415865, XrefRangeEnd = 1415865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x0015C538 File Offset: 0x0015A738
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 1415783, RefRangeEnd = 1415865, XrefRangeStart = 1415783, XrefRangeEnd = 1415865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_Get_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x0015C584 File Offset: 0x0015A784
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 1415870, RefRangeEnd = 1415931, XrefRangeStart = 1415870, XrefRangeEnd = 1415870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int index, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_Set_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x0015C5D0 File Offset: 0x0015A7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1415931, RefRangeEnd = 1415932, XrefRangeStart = 1415931, XrefRangeEnd = 1415931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAll(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_SetAll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x0015C610 File Offset: 0x0015A810
		// (set) Token: 0x06004B65 RID: 19301 RVA: 0x0015C64C File Offset: 0x0015A84C
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1415938, RefRangeEnd = 1415939, XrefRangeStart = 1415932, XrefRangeEnd = 1415938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x0015C68C File Offset: 0x0015A88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415939, XrefRangeEnd = 1415952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06004B67 RID: 19303 RVA: 0x0015C6DC File Offset: 0x0015A8DC
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06004B68 RID: 19304 RVA: 0x0015C718 File Offset: 0x0015A918
		public unsafe Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415952, XrefRangeEnd = 1415957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06004B69 RID: 19305 RVA: 0x0015C758 File Offset: 0x0015A958
		public unsafe bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x0015C794 File Offset: 0x0015A994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415957, XrefRangeEnd = 1415967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x0015C7D4 File Offset: 0x0015A9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415967, XrefRangeEnd = 1415971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x0015C814 File Offset: 0x0015AA14
		[CallerCount(0)]
		public unsafe static int GetArrayLength(int n, int div)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref div;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.NativeMethodInfoPtr_GetArrayLength_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x0001B904 File Offset: 0x00019B04
		public BitArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06004B6E RID: 19310 RVA: 0x0015C860 File Offset: 0x0015AA60
		// (set) Token: 0x06004B6F RID: 19311 RVA: 0x0001B90D File Offset: 0x00019B0D
		public unsafe Il2CppStructArray<int> m_array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.NativeFieldInfoPtr_m_array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.NativeFieldInfoPtr_m_array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x0015C890 File Offset: 0x0015AA90
		// (set) Token: 0x06004B71 RID: 19313 RVA: 0x0001B92C File Offset: 0x00019B2C
		public unsafe int m_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.NativeFieldInfoPtr_m_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.NativeFieldInfoPtr_m_length)) = value;
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06004B72 RID: 19314 RVA: 0x0015C8B8 File Offset: 0x0015AAB8
		// (set) Token: 0x06004B73 RID: 19315 RVA: 0x0001B947 File Offset: 0x00019B47
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x0015C8E0 File Offset: 0x0015AAE0
		// (set) Token: 0x06004B75 RID: 19317 RVA: 0x0001B962 File Offset: 0x00019B62
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DAE RID: 15790
		private static readonly IntPtr NativeFieldInfoPtr_m_array;

		// Token: 0x04003DAF RID: 15791
		private static readonly IntPtr NativeFieldInfoPtr_m_length;

		// Token: 0x04003DB0 RID: 15792
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003DB1 RID: 15793
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003DB2 RID: 15794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003DB3 RID: 15795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04003DB4 RID: 15796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BitArray_0;

		// Token: 0x04003DB5 RID: 15797
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Boolean_Int32_0;

		// Token: 0x04003DB6 RID: 15798
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04003DB7 RID: 15799
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Boolean_Int32_0;

		// Token: 0x04003DB8 RID: 15800
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_Boolean_0;

		// Token: 0x04003DB9 RID: 15801
		private static readonly IntPtr NativeMethodInfoPtr_SetAll_Public_Void_Boolean_0;

		// Token: 0x04003DBA RID: 15802
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04003DBB RID: 15803
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0;

		// Token: 0x04003DBC RID: 15804
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003DBD RID: 15805
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003DBE RID: 15806
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04003DBF RID: 15807
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003DC0 RID: 15808
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04003DC1 RID: 15809
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003DC2 RID: 15810
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayLength_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x020006EC RID: 1772
		[Serializable]
		public class BitArrayEnumeratorSimple : Object
		{
			// Token: 0x06005E15 RID: 24085 RVA: 0x001A9418 File Offset: 0x001A7618
			// Note: this type is marked as 'beforefieldinit'.
			static BitArrayEnumeratorSimple()
			{
				Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BitArray>.NativeClassPtr, "BitArrayEnumeratorSimple");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr);
				BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_bitarray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, "bitarray");
				BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, "index");
				BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, "version");
				BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, "currentElement");
				BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, 100674375);
				BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, 100674376);
				BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, 100674377);
				BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, 100674378);
				BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr, 100674379);
			}

			// Token: 0x06005E16 RID: 24086 RVA: 0x001A94F8 File Offset: 0x001A76F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1415746, RefRangeEnd = 1415747, XrefRangeStart = 1415744, XrefRangeEnd = 1415746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BitArrayEnumeratorSimple(BitArray bitarray)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitArray.BitArrayEnumeratorSimple>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bitarray);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E17 RID: 24087 RVA: 0x001A9544 File Offset: 0x001A7744
			[CallerCount(105)]
			[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005E18 RID: 24088 RVA: 0x001A9584 File Offset: 0x001A7784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415747, XrefRangeEnd = 1415752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700182F RID: 6191
			// (get) Token: 0x06005E19 RID: 24089 RVA: 0x001A95CC File Offset: 0x001A77CC
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415752, XrefRangeEnd = 1415758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E1A RID: 24090 RVA: 0x001A9618 File Offset: 0x001A7818
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray.BitArrayEnumeratorSimple.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E1B RID: 24091 RVA: 0x0002262F File Offset: 0x0002082F
			public BitArrayEnumeratorSimple(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700182B RID: 6187
			// (get) Token: 0x06005E1C RID: 24092 RVA: 0x001A964C File Offset: 0x001A784C
			// (set) Token: 0x06005E1D RID: 24093 RVA: 0x00022638 File Offset: 0x00020838
			public unsafe BitArray bitarray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_bitarray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_bitarray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700182C RID: 6188
			// (get) Token: 0x06005E1E RID: 24094 RVA: 0x001A967C File Offset: 0x001A787C
			// (set) Token: 0x06005E1F RID: 24095 RVA: 0x00022657 File Offset: 0x00020857
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700182D RID: 6189
			// (get) Token: 0x06005E20 RID: 24096 RVA: 0x001A96A4 File Offset: 0x001A78A4
			// (set) Token: 0x06005E21 RID: 24097 RVA: 0x00022672 File Offset: 0x00020872
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x1700182E RID: 6190
			// (get) Token: 0x06005E22 RID: 24098 RVA: 0x001A96CC File Offset: 0x001A78CC
			// (set) Token: 0x06005E23 RID: 24099 RVA: 0x0002268D File Offset: 0x0002088D
			public unsafe bool currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_currentElement);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitArray.BitArrayEnumeratorSimple.NativeFieldInfoPtr_currentElement)) = value;
				}
			}

			// Token: 0x04004CAE RID: 19630
			private static readonly IntPtr NativeFieldInfoPtr_bitarray;

			// Token: 0x04004CAF RID: 19631
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04004CB0 RID: 19632
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04004CB1 RID: 19633
			private static readonly IntPtr NativeFieldInfoPtr_currentElement;

			// Token: 0x04004CB2 RID: 19634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0;

			// Token: 0x04004CB3 RID: 19635
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004CB4 RID: 19636
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x04004CB5 RID: 19637
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x04004CB6 RID: 19638
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}
	}
}
