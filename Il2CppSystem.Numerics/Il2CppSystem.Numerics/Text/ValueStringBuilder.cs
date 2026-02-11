using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000009 RID: 9
	[DefaultMember("Item")]
	public sealed class ValueStringBuilder : ValueType
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00005830 File Offset: 0x00003A30
		// Note: this type is marked as 'beforefieldinit'.
		static ValueStringBuilder()
		{
			Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Text", "ValueStringBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr);
			ValueStringBuilder.NativeFieldInfoPtr__arrayToReturnToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_arrayToReturnToPool");
			ValueStringBuilder.NativeFieldInfoPtr__chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_chars");
			ValueStringBuilder.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_pos");
			ValueStringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663438);
			ValueStringBuilder.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663439);
			ValueStringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663440);
			ValueStringBuilder.NativeMethodInfoPtr_TryCopyTo_Public_Boolean_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663441);
			ValueStringBuilder.NativeMethodInfoPtr_Insert_Public_Void_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663442);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663443);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663444);
			ValueStringBuilder.NativeMethodInfoPtr_AppendSlow_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663445);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663446);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663447);
			ValueStringBuilder.NativeMethodInfoPtr_AppendSpan_Public_Span_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663448);
			ValueStringBuilder.NativeMethodInfoPtr_GrowAndAppend_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663449);
			ValueStringBuilder.NativeMethodInfoPtr_Grow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663450);
			ValueStringBuilder.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663451);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000059B4 File Offset: 0x00003BB4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1236714, RefRangeEnd = 1236725, XrefRangeStart = 1236714, XrefRangeEnd = 1236714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00005A0C File Offset: 0x00003C0C
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

		// Token: 0x0600009D RID: 157 RVA: 0x00005A50 File Offset: 0x00003C50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1236734, RefRangeEnd = 1236736, XrefRangeStart = 1236725, XrefRangeEnd = 1236734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005A8C File Offset: 0x00003C8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1236746, RefRangeEnd = 1236747, XrefRangeStart = 1236736, XrefRangeEnd = 1236746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600009F RID: 159 RVA: 0x00005AF4 File Offset: 0x00003CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1236766, RefRangeEnd = 1236767, XrefRangeStart = 1236747, XrefRangeEnd = 1236766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, char value, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Insert_Public_Void_Int32_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005B54 File Offset: 0x00003D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236767, XrefRangeEnd = 1236769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000A1 RID: 161 RVA: 0x00005B98 File Offset: 0x00003D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236769, XrefRangeEnd = 1236771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000A2 RID: 162 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1236782, RefRangeEnd = 1236785, XrefRangeStart = 1236771, XrefRangeEnd = 1236782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000A3 RID: 163 RVA: 0x00005C28 File Offset: 0x00003E28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1236791, RefRangeEnd = 1236793, XrefRangeStart = 1236785, XrefRangeEnd = 1236791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000A4 RID: 164 RVA: 0x00005C7C File Offset: 0x00003E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1236799, RefRangeEnd = 1236801, XrefRangeStart = 1236793, XrefRangeEnd = 1236799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000A5 RID: 165 RVA: 0x00005CCC File Offset: 0x00003ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236801, XrefRangeEnd = 1236807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000A6 RID: 166 RVA: 0x00005D18 File Offset: 0x00003F18
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1236809, RefRangeEnd = 1236818, XrefRangeStart = 1236807, XrefRangeEnd = 1236809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000A7 RID: 167 RVA: 0x00005D5C File Offset: 0x00003F5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1236841, RefRangeEnd = 1236848, XrefRangeStart = 1236818, XrefRangeEnd = 1236841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000A8 RID: 168 RVA: 0x00005DA0 File Offset: 0x00003FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236848, XrefRangeEnd = 1236854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000021C3 File Offset: 0x000003C3
		public ValueStringBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000021CC File Offset: 0x000003CC
		public ValueStringBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00005DD8 File Offset: 0x00003FD8
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000021DE File Offset: 0x000003DE
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00005E08 File Offset: 0x00004008
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000021FD File Offset: 0x000003FD
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00005E38 File Offset: 0x00004038
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000222B File Offset: 0x0000042B
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

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr__arrayToReturnToPool;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr__chars;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr__pos;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Span_1_Char_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_TryCopyTo_Public_Boolean_Span_1_Char_byref_Int32_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_Char_Int32_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Char_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_AppendSlow_Private_Void_String_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Char_Int32_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_ptr_Char_Int32_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_AppendSpan_Public_Span_1_Char_Int32_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_GrowAndAppend_Private_Void_Char_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_Int32_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
	}
}
