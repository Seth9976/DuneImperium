using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000214 RID: 532
	public sealed class ValueStringBuilder : ValueType
	{
		// Token: 0x060022BD RID: 8893 RVA: 0x000C50E8 File Offset: 0x000C32E8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueStringBuilder()
		{
			Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "ValueStringBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr);
			ValueStringBuilder.NativeFieldInfoPtr__arrayToReturnToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_arrayToReturnToPool");
			ValueStringBuilder.NativeFieldInfoPtr__chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_chars");
			ValueStringBuilder.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_pos");
			ValueStringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669195);
			ValueStringBuilder.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669196);
			ValueStringBuilder.NativeMethodInfoPtr_get_Item_Public_get_byref_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669197);
			ValueStringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669198);
			ValueStringBuilder.NativeMethodInfoPtr_TryCopyTo_Public_Boolean_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669199);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669200);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669201);
			ValueStringBuilder.NativeMethodInfoPtr_AppendSlow_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669202);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669203);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669204);
			ValueStringBuilder.NativeMethodInfoPtr_AppendSpan_Public_Span_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669205);
			ValueStringBuilder.NativeMethodInfoPtr_GrowAndAppend_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669206);
			ValueStringBuilder.NativeMethodInfoPtr_Grow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669207);
			ValueStringBuilder.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100669208);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000C526C File Offset: 0x000C346C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1236714, RefRangeEnd = 1236725, XrefRangeStart = 1236714, XrefRangeEnd = 1236725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueStringBuilder(Span<char> initialBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(initialBuffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Span_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000C52C4 File Offset: 0x000C34C4
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B8 RID: 1720
		public unsafe ref char this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1367743, RefRangeEnd = 1367744, XrefRangeStart = 1367743, XrefRangeEnd = 1367743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_get_Item_Public_get_byref_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000C534C File Offset: 0x000C354C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1367753, RefRangeEnd = 1367761, XrefRangeStart = 1367744, XrefRangeEnd = 1367753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000C5388 File Offset: 0x000C3588
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1367771, RefRangeEnd = 1367776, XrefRangeStart = 1367761, XrefRangeEnd = 1367771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryCopyTo(Span<char> destination, out int charsWritten)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_TryCopyTo_Public_Boolean_Span_1_Char_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000C53F0 File Offset: 0x000C35F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367776, XrefRangeEnd = 1367778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000C5434 File Offset: 0x000C3634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367778, XrefRangeEnd = 1367780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000C547C File Offset: 0x000C367C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1367791, RefRangeEnd = 1367794, XrefRangeStart = 1367780, XrefRangeEnd = 1367791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendSlow(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_AppendSlow_Private_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000C54C4 File Offset: 0x000C36C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1367800, RefRangeEnd = 1367801, XrefRangeStart = 1367794, XrefRangeEnd = 1367800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(char c, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000C5518 File Offset: 0x000C3718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1367807, RefRangeEnd = 1367808, XrefRangeStart = 1367801, XrefRangeEnd = 1367807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(char* value, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_ptr_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000C5568 File Offset: 0x000C3768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367808, XrefRangeEnd = 1367814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Span<char> AppendSpan(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_AppendSpan_Public_Span_1_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Span<char>(intPtr);
			}
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000C55B4 File Offset: 0x000C37B4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1367816, RefRangeEnd = 1367829, XrefRangeStart = 1367814, XrefRangeEnd = 1367816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowAndAppend(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_GrowAndAppend_Private_Void_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000C55F8 File Offset: 0x000C37F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1367852, RefRangeEnd = 1367858, XrefRangeStart = 1367829, XrefRangeEnd = 1367852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow(int requiredAdditionalCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requiredAdditionalCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Grow_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000C563C File Offset: 0x000C383C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367858, XrefRangeEnd = 1367864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0000B1A3 File Offset: 0x000093A3
		public ValueStringBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0000B1AC File Offset: 0x000093AC
		public ValueStringBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x000C5674 File Offset: 0x000C3874
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x0000B1BE File Offset: 0x000093BE
		public unsafe Il2CppStructArray<char> _arrayToReturnToPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueStringBuilder.NativeFieldInfoPtr__arrayToReturnToPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueStringBuilder.NativeFieldInfoPtr__arrayToReturnToPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x000C56A4 File Offset: 0x000C38A4
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x0000B1DD File Offset: 0x000093DD
		public Span<char> _chars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueStringBuilder.NativeFieldInfoPtr__chars);
				return new Span<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Span<char>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueStringBuilder.NativeFieldInfoPtr__chars), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Span<char>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x000C56D4 File Offset: 0x000C38D4
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x0000B20B File Offset: 0x0000940B
		public unsafe int _pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueStringBuilder.NativeFieldInfoPtr__pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueStringBuilder.NativeFieldInfoPtr__pos)) = value;
			}
		}

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeFieldInfoPtr__arrayToReturnToPool;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeFieldInfoPtr__chars;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeFieldInfoPtr__pos;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Span_1_Char_0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_Char_Int32_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_TryCopyTo_Public_Boolean_Span_1_Char_byref_Int32_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Char_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_String_0;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeMethodInfoPtr_AppendSlow_Private_Void_String_0;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Char_Int32_0;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_ptr_Char_Int32_0;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeMethodInfoPtr_AppendSpan_Public_Span_1_Char_Int32_0;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeMethodInfoPtr_GrowAndAppend_Private_Void_Char_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_Int32_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
	}
}
