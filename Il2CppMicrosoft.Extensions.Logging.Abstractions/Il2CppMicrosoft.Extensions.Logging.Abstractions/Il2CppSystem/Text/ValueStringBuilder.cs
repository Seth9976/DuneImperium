using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200000C RID: 12
	[DefaultMember("Item")]
	public sealed class ValueStringBuilder : ValueType
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002DB8 File Offset: 0x00000FB8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueStringBuilder()
		{
			Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "System.Text", "ValueStringBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr);
			ValueStringBuilder.NativeFieldInfoPtr__arrayToReturnToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_arrayToReturnToPool");
			ValueStringBuilder.NativeFieldInfoPtr__chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_chars");
			ValueStringBuilder.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, "_pos");
			ValueStringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663309);
			ValueStringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663310);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663311);
			ValueStringBuilder.NativeMethodInfoPtr_AppendSlow_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663312);
			ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663313);
			ValueStringBuilder.NativeMethodInfoPtr_Grow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663314);
			ValueStringBuilder.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr, 100663315);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002EB0 File Offset: 0x000010B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264455, RefRangeEnd = 1264456, XrefRangeStart = 1264454, XrefRangeEnd = 1264455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600002F RID: 47 RVA: 0x00002F08 File Offset: 0x00001108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264464, RefRangeEnd = 1264465, XrefRangeStart = 1264456, XrefRangeEnd = 1264464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002F44 File Offset: 0x00001144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264465, XrefRangeEnd = 1264467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000031 RID: 49 RVA: 0x00002F8C File Offset: 0x0000118C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264478, RefRangeEnd = 1264480, XrefRangeStart = 1264467, XrefRangeEnd = 1264478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000032 RID: 50 RVA: 0x00002FD4 File Offset: 0x000011D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264490, RefRangeEnd = 1264492, XrefRangeStart = 1264480, XrefRangeEnd = 1264490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(ReadOnlySpan<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Append_Public_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003020 File Offset: 0x00001220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264521, RefRangeEnd = 1264523, XrefRangeStart = 1264492, XrefRangeEnd = 1264521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow(int additionalCapacityBeyondPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref additionalCapacityBeyondPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Grow_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003064 File Offset: 0x00001264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264523, XrefRangeEnd = 1264529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueStringBuilder.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000021FF File Offset: 0x000003FF
		public ValueStringBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002208 File Offset: 0x00000408
		public ValueStringBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueStringBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000309C File Offset: 0x0000129C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000221A File Offset: 0x0000041A
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000030CC File Offset: 0x000012CC
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002239 File Offset: 0x00000439
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000030FC File Offset: 0x000012FC
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002267 File Offset: 0x00000467
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

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr__arrayToReturnToPool;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr__chars;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__pos;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Span_1_Char_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_AppendSlow_Private_Void_String_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_ReadOnlySpan_1_Char_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_Int32_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
	}
}
