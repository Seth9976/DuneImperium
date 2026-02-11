using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x02000543 RID: 1347
	[Serializable]
	public class StringWriter : TextWriter
	{
		// Token: 0x060052C4 RID: 21188 RVA: 0x00181728 File Offset: 0x0017F928
		// Note: this type is marked as 'beforefieldinit'.
		static StringWriter()
		{
			Il2CppClassPointerStore<StringWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StringWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringWriter>.NativeClassPtr);
			StringWriter.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, "m_encoding");
			StringWriter.NativeFieldInfoPtr__sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, "_sb");
			StringWriter.NativeFieldInfoPtr__isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, "_isOpen");
			StringWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675987);
			StringWriter.NativeMethodInfoPtr__ctor_Public_Void_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675988);
			StringWriter.NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675989);
			StringWriter.NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675990);
			StringWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675991);
			StringWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675992);
			StringWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675993);
			StringWriter.NativeMethodInfoPtr_GetStringBuilder_Public_Virtual_New_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675994);
			StringWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675995);
			StringWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675996);
			StringWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675997);
			StringWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675998);
			StringWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100675999);
			StringWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100676000);
			StringWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100676001);
			StringWriter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringWriter>.NativeClassPtr, 100676002);
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x001818D4 File Offset: 0x0017FAD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1432398, RefRangeEnd = 1432400, XrefRangeStart = 1432385, XrefRangeEnd = 1432398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00181910 File Offset: 0x0017FB10
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1432409, RefRangeEnd = 1432438, XrefRangeStart = 1432400, XrefRangeEnd = 1432409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringWriter(IFormatProvider formatProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringWriter.NativeMethodInfoPtr__ctor_Public_Void_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x0018195C File Offset: 0x0017FB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432438, XrefRangeEnd = 1432447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringWriter(StringBuilder sb)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringWriter.NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x001819A8 File Offset: 0x0017FBA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1432452, RefRangeEnd = 1432455, XrefRangeStart = 1432447, XrefRangeEnd = 1432452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringWriter(StringBuilder sb, IFormatProvider formatProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringWriter.NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00181A08 File Offset: 0x0017FC08
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00181A44 File Offset: 0x0017FC44
		[CallerCount(0)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060052CB RID: 21195 RVA: 0x00181A90 File Offset: 0x0017FC90
		public unsafe override Encoding Encoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432455, XrefRangeEnd = 1432468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00181ADC File Offset: 0x0017FCDC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual StringBuilder GetStringBuilder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_GetStringBuilder_Public_Virtual_New_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00181B28 File Offset: 0x0017FD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432468, XrefRangeEnd = 1432471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00181B74 File Offset: 0x0017FD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432471, XrefRangeEnd = 1432505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00181BE0 File Offset: 0x0017FDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432505, XrefRangeEnd = 1432506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00181C30 File Offset: 0x0017FE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432506, XrefRangeEnd = 1432514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00181C88 File Offset: 0x0017FE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432514, XrefRangeEnd = 1432522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00181CE4 File Offset: 0x0017FEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432522, XrefRangeEnd = 1432530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00181D5C File Offset: 0x0017FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432530, XrefRangeEnd = 1432538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task FlushAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00181DA8 File Offset: 0x0017FFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432538, XrefRangeEnd = 1432539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringWriter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x0001D5E6 File Offset: 0x0001B7E6
		public StringWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x00181DEC File Offset: 0x0017FFEC
		// (set) Token: 0x060052D7 RID: 21207 RVA: 0x0001D5EF File Offset: 0x0001B7EF
		public unsafe static UnicodeEncoding m_encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringWriter.NativeFieldInfoPtr_m_encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnicodeEncoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringWriter.NativeFieldInfoPtr_m_encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x00181E14 File Offset: 0x00180014
		// (set) Token: 0x060052D9 RID: 21209 RVA: 0x0001D601 File Offset: 0x0001B801
		public unsafe StringBuilder _sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringWriter.NativeFieldInfoPtr__sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringWriter.NativeFieldInfoPtr__sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060052DA RID: 21210 RVA: 0x00181E44 File Offset: 0x00180044
		// (set) Token: 0x060052DB RID: 21211 RVA: 0x0001D620 File Offset: 0x0001B820
		public unsafe bool _isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringWriter.NativeFieldInfoPtr__isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringWriter.NativeFieldInfoPtr__isOpen)) = value;
			}
		}

		// Token: 0x0400439C RID: 17308
		private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

		// Token: 0x0400439D RID: 17309
		private static readonly IntPtr NativeFieldInfoPtr__sb;

		// Token: 0x0400439E RID: 17310
		private static readonly IntPtr NativeFieldInfoPtr__isOpen;

		// Token: 0x0400439F RID: 17311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040043A0 RID: 17312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFormatProvider_0;

		// Token: 0x040043A1 RID: 17313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_0;

		// Token: 0x040043A2 RID: 17314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_IFormatProvider_0;

		// Token: 0x040043A3 RID: 17315
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040043A4 RID: 17316
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040043A5 RID: 17317
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0;

		// Token: 0x040043A6 RID: 17318
		private static readonly IntPtr NativeMethodInfoPtr_GetStringBuilder_Public_Virtual_New_StringBuilder_0;

		// Token: 0x040043A7 RID: 17319
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

		// Token: 0x040043A8 RID: 17320
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040043A9 RID: 17321
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

		// Token: 0x040043AA RID: 17322
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0;

		// Token: 0x040043AB RID: 17323
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0;

		// Token: 0x040043AC RID: 17324
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040043AD RID: 17325
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0;

		// Token: 0x040043AE RID: 17326
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
