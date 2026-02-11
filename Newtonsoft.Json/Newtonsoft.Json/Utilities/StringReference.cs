using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000069 RID: 105
	public sealed class StringReference : ValueType
	{
		// Token: 0x06000936 RID: 2358 RVA: 0x0003D150 File Offset: 0x0003B350
		// Note: this type is marked as 'beforefieldinit'.
		static StringReference()
		{
			Il2CppClassPointerStore<StringReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "StringReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringReference>.NativeClassPtr);
			StringReference.NativeFieldInfoPtr__chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, "_chars");
			StringReference.NativeFieldInfoPtr__startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, "_startIndex");
			StringReference.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, "_length");
			StringReference.NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReference>.NativeClassPtr, 100665080);
			StringReference.NativeMethodInfoPtr_get_Chars_Public_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReference>.NativeClassPtr, 100665081);
			StringReference.NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReference>.NativeClassPtr, 100665082);
			StringReference.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReference>.NativeClassPtr, 100665083);
			StringReference.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReference>.NativeClassPtr, 100665084);
			StringReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReference>.NativeClassPtr, 100665085);
		}

		// Token: 0x17000245 RID: 581
		public unsafe char this[int i]
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 745909, RefRangeEnd = 745916, XrefRangeStart = 745909, XrefRangeEnd = 745909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReference.NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0003D284 File Offset: 0x0003B484
		public unsafe Il2CppStructArray<char> Chars
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReference.NativeMethodInfoPtr_get_Chars_Public_get_Il2CppStructArray_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0003D2C8 File Offset: 0x0003B4C8
		public unsafe int StartIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReference.NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0003D30C File Offset: 0x0003B50C
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReference.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0003D350 File Offset: 0x0003B550
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 745917, RefRangeEnd = 745928, XrefRangeStart = 745916, XrefRangeEnd = 745917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringReference(Il2CppStructArray<char> chars, int startIndex, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringReference>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReference.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0003D3BC File Offset: 0x0003B5BC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 745929, RefRangeEnd = 745948, XrefRangeStart = 745928, XrefRangeEnd = 745929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00004D6C File Offset: 0x00002F6C
		public StringReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00004D75 File Offset: 0x00002F75
		public StringReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringReference>.NativeClassPtr))
		{
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0003D3F8 File Offset: 0x0003B5F8
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00004D87 File Offset: 0x00002F87
		public unsafe Il2CppStructArray<char> _chars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr__chars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr__chars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0003D428 File Offset: 0x0003B628
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00004DA6 File Offset: 0x00002FA6
		public unsafe int _startIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr__startIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr__startIndex)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0003D450 File Offset: 0x0003B650
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00004DC1 File Offset: 0x00002FC1
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr__chars;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr__startIndex;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_get_Chars_Public_get_Il2CppStructArray_1_Char_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
