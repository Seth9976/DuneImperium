using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000068 RID: 104
	public sealed class StringBuffer : ValueType
	{
		// Token: 0x06000923 RID: 2339 RVA: 0x0003CBEC File Offset: 0x0003ADEC
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuffer()
		{
			Il2CppClassPointerStore<StringBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "StringBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr);
			StringBuffer.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, "_buffer");
			StringBuffer.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, "_position");
			StringBuffer.NativeMethodInfoPtr_get_Position_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665068);
			StringBuffer.NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665069);
			StringBuffer.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665070);
			StringBuffer.NativeMethodInfoPtr__ctor_Public_Void_IArrayPool_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665071);
			StringBuffer.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665072);
			StringBuffer.NativeMethodInfoPtr_Append_Public_Void_IArrayPool_1_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665073);
			StringBuffer.NativeMethodInfoPtr_Append_Public_Void_IArrayPool_1_Char_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665074);
			StringBuffer.NativeMethodInfoPtr_Clear_Public_Void_IArrayPool_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665075);
			StringBuffer.NativeMethodInfoPtr_EnsureSize_Private_Void_IArrayPool_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665076);
			StringBuffer.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665077);
			StringBuffer.NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665078);
			StringBuffer.NativeMethodInfoPtr_get_InternalBuffer_Public_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, 100665079);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0003CD34 File Offset: 0x0003AF34
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x0003CD78 File Offset: 0x0003AF78
		public unsafe int Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_get_Position_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0003CDBC File Offset: 0x0003AFBC
		public unsafe bool IsEmpty
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 745863, RefRangeEnd = 745876, XrefRangeStart = 745863, XrefRangeEnd = 745863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0003CE00 File Offset: 0x0003B000
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 745878, RefRangeEnd = 745882, XrefRangeStart = 745876, XrefRangeEnd = 745878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuffer(IArrayPool<char> bufferPool, int initalSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initalSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr__ctor_Public_Void_IArrayPool_1_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0003CE60 File Offset: 0x0003B060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745882, XrefRangeEnd = 745883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuffer(Il2CppStructArray<char> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 745887, RefRangeEnd = 745890, XrefRangeStart = 745883, XrefRangeEnd = 745887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(IArrayPool<char> bufferPool, char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_Append_Public_Void_IArrayPool_1_Char_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0003CF08 File Offset: 0x0003B108
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 745895, RefRangeEnd = 745900, XrefRangeStart = 745890, XrefRangeEnd = 745895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(IArrayPool<char> bufferPool, Il2CppStructArray<char> buffer, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_Append_Public_Void_IArrayPool_1_Char_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0003CF80 File Offset: 0x0003B180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745902, RefRangeEnd = 745903, XrefRangeStart = 745900, XrefRangeEnd = 745902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(IArrayPool<char> bufferPool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_Clear_Public_Void_IArrayPool_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0003CFC8 File Offset: 0x0003B1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745903, XrefRangeEnd = 745907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_EnsureSize_Private_Void_IArrayPool_1_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0003D020 File Offset: 0x0003B220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745907, XrefRangeEnd = 745908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0003D05C File Offset: 0x0003B25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745908, XrefRangeEnd = 745909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
		public unsafe Il2CppStructArray<char> InternalBuffer
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuffer.NativeMethodInfoPtr_get_InternalBuffer_Public_get_Il2CppStructArray_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00004D17 File Offset: 0x00002F17
		public StringBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00004D20 File Offset: 0x00002F20
		public StringBuffer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr))
		{
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0003D0F8 File Offset: 0x0003B2F8
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00004D32 File Offset: 0x00002F32
		public unsafe Il2CppStructArray<char> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuffer.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuffer.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0003D128 File Offset: 0x0003B328
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00004D51 File Offset: 0x00002F51
		public unsafe int _position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuffer.NativeFieldInfoPtr__position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuffer.NativeFieldInfoPtr__position)) = value;
			}
		}

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeFieldInfoPtr__position;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Int32_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Int32_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IArrayPool_1_Char_Int32_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_IArrayPool_1_Char_Char_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_IArrayPool_1_Char_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_IArrayPool_1_Char_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSize_Private_Void_IArrayPool_1_Char_Int32_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalBuffer_Public_get_Il2CppStructArray_1_Char_0;
	}
}
