using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200052E RID: 1326
	[Serializable]
	public class TextReader : MarshalByRefObject
	{
		// Token: 0x06005111 RID: 20753 RVA: 0x00179410 File Offset: 0x00177610
		// Note: this type is marked as 'beforefieldinit'.
		static TextReader()
		{
			Il2CppClassPointerStore<TextReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "TextReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader>.NativeClassPtr);
			TextReader.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "Null");
			TextReader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675575);
			TextReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675576);
			TextReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675577);
			TextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675578);
			TextReader.NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675579);
			TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675580);
			TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675581);
			TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675582);
			TextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675583);
			TextReader.NativeMethodInfoPtr_ReadBlock_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675584);
			TextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675585);
			TextReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675586);
			TextReader.NativeMethodInfoPtr_ReadAsyncInternal_Internal_Virtual_New_ValueTask_1_Int32_Memory_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675587);
			TextReader.NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader>.NativeClassPtr, 100675588);
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x0017956C File Offset: 0x0017776C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x001795A8 File Offset: 0x001777A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429350, XrefRangeEnd = 1429354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x001795E4 File Offset: 0x001777E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1429358, RefRangeEnd = 1429361, XrefRangeStart = 1429354, XrefRangeEnd = 1429358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00179618 File Offset: 0x00177818
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x00179664 File Offset: 0x00177864
		[CallerCount(0)]
		public unsafe virtual int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x001796AC File Offset: 0x001778AC
		[CallerCount(0)]
		public unsafe virtual int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x001796F4 File Offset: 0x001778F4
		[CallerCount(0)]
		public unsafe virtual int Read(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00179768 File Offset: 0x00177968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1429381, RefRangeEnd = 1429382, XrefRangeStart = 1429361, XrefRangeEnd = 1429381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Read(Span<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Span_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x001797C8 File Offset: 0x001779C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429382, XrefRangeEnd = 1429392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x0017980C File Offset: 0x00177A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1429392, RefRangeEnd = 1429393, XrefRangeStart = 1429392, XrefRangeEnd = 1429392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadBlock(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadBlock_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00179880 File Offset: 0x00177A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429393, XrefRangeEnd = 1429400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x001798C4 File Offset: 0x00177AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429400, XrefRangeEnd = 1429406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<int> ReadAsync(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x0017993C File Offset: 0x00177B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429406, XrefRangeEnd = 1429443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextReader.NativeMethodInfoPtr_ReadAsyncInternal_Internal_Virtual_New_ValueTask_1_Int32_Memory_1_Char_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask<int>(intPtr);
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x001799AC File Offset: 0x00177BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1429445, RefRangeEnd = 1429446, XrefRangeStart = 1429443, XrefRangeEnd = 1429445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextReader Synchronized(TextReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr3) : null;
			}
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x0001CF94 File Offset: 0x0001B194
		public TextReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06005121 RID: 20769 RVA: 0x001799F0 File Offset: 0x00177BF0
		// (set) Token: 0x06005122 RID: 20770 RVA: 0x0001CF9D File Offset: 0x0001B19D
		public unsafe static TextReader Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextReader.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextReader.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004220 RID: 16928
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04004221 RID: 16929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004222 RID: 16930
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04004223 RID: 16931
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04004224 RID: 16932
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04004225 RID: 16933
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_New_Int32_0;

		// Token: 0x04004226 RID: 16934
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

		// Token: 0x04004227 RID: 16935
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04004228 RID: 16936
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Span_1_Char_0;

		// Token: 0x04004229 RID: 16937
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_New_String_0;

		// Token: 0x0400422A RID: 16938
		private static readonly IntPtr NativeMethodInfoPtr_ReadBlock_Public_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400422B RID: 16939
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_New_String_0;

		// Token: 0x0400422C RID: 16940
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400422D RID: 16941
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncInternal_Internal_Virtual_New_ValueTask_1_Int32_Memory_1_Char_CancellationToken_0;

		// Token: 0x0400422E RID: 16942
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_TextReader_TextReader_0;

		// Token: 0x0200071D RID: 1821
		[Serializable]
		public sealed class NullTextReader : TextReader
		{
			// Token: 0x060060ED RID: 24813 RVA: 0x001B3BF4 File Offset: 0x001B1DF4
			// Note: this type is marked as 'beforefieldinit'.
			static NullTextReader()
			{
				Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "NullTextReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr);
				TextReader.NullTextReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100675590);
				TextReader.NullTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100675591);
				TextReader.NullTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr, 100675592);
			}

			// Token: 0x060060EE RID: 24814 RVA: 0x001B3C5C File Offset: 0x001B1E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429299, XrefRangeEnd = 1429303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullTextReader()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.NullTextReader>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060060EF RID: 24815 RVA: 0x001B3C98 File Offset: 0x001B1E98
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060060F0 RID: 24816 RVA: 0x001B3D04 File Offset: 0x001B1F04
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.NullTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060060F1 RID: 24817 RVA: 0x00023D0A File Offset: 0x00021F0A
			public NullTextReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004E7C RID: 20092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004E7D RID: 20093
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004E7E RID: 20094
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;
		}

		// Token: 0x0200071E RID: 1822
		[Serializable]
		public sealed class SyncTextReader : TextReader
		{
			// Token: 0x060060F2 RID: 24818 RVA: 0x001B3D3C File Offset: 0x001B1F3C
			// Note: this type is marked as 'beforefieldinit'.
			static SyncTextReader()
			{
				Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "SyncTextReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr);
				TextReader.SyncTextReader.NativeFieldInfoPtr__in = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, "_in");
				TextReader.SyncTextReader.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675593);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675594);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675595);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675596);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675597);
				TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675598);
				TextReader.SyncTextReader.NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675599);
				TextReader.SyncTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675600);
				TextReader.SyncTextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675601);
				TextReader.SyncTextReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr, 100675602);
			}

			// Token: 0x060060F3 RID: 24819 RVA: 0x001B3E44 File Offset: 0x001B2044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429303, XrefRangeEnd = 1429308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncTextReader(TextReader t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.SyncTextReader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060060F4 RID: 24820 RVA: 0x001B3E90 File Offset: 0x001B2090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060060F5 RID: 24821 RVA: 0x001B3EC4 File Offset: 0x001B20C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429308, XrefRangeEnd = 1429311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060060F6 RID: 24822 RVA: 0x001B3F04 File Offset: 0x001B2104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Peek()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060060F7 RID: 24823 RVA: 0x001B3F40 File Offset: 0x001B2140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429311, XrefRangeEnd = 1429312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060060F8 RID: 24824 RVA: 0x001B3F7C File Offset: 0x001B217C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429312, XrefRangeEnd = 1429313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060060F9 RID: 24825 RVA: 0x001B3FE8 File Offset: 0x001B21E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429313, XrefRangeEnd = 1429314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int ReadBlock(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060060FA RID: 24826 RVA: 0x001B4054 File Offset: 0x001B2254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429314, XrefRangeEnd = 1429315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060060FB RID: 24827 RVA: 0x001B408C File Offset: 0x001B228C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429315, XrefRangeEnd = 1429316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadToEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060060FC RID: 24828 RVA: 0x001B40C4 File Offset: 0x001B22C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429316, XrefRangeEnd = 1429343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task<int> ReadAsync(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.SyncTextReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
			}

			// Token: 0x060060FD RID: 24829 RVA: 0x00023D13 File Offset: 0x00021F13
			public SyncTextReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700192D RID: 6445
			// (get) Token: 0x060060FE RID: 24830 RVA: 0x001B4130 File Offset: 0x001B2330
			// (set) Token: 0x060060FF RID: 24831 RVA: 0x00023D1C File Offset: 0x00021F1C
			public unsafe TextReader _in
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReader.SyncTextReader.NativeFieldInfoPtr__in);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReader.SyncTextReader.NativeFieldInfoPtr__in), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E7F RID: 20095
			private static readonly IntPtr NativeFieldInfoPtr__in;

			// Token: 0x04004E80 RID: 20096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_0;

			// Token: 0x04004E81 RID: 20097
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

			// Token: 0x04004E82 RID: 20098
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004E83 RID: 20099
			private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

			// Token: 0x04004E84 RID: 20100
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

			// Token: 0x04004E85 RID: 20101
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004E86 RID: 20102
			private static readonly IntPtr NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004E87 RID: 20103
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

			// Token: 0x04004E88 RID: 20104
			private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

			// Token: 0x04004E89 RID: 20105
			private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;
		}

		// Token: 0x0200071F RID: 1823
		[ObfuscatedName("System.IO.TextReader+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006100 RID: 24832 RVA: 0x001B4160 File Offset: 0x001B2360
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextReader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr);
				TextReader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, "<>9");
				TextReader.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, "<>9__17_0");
				TextReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, 100675604);
				TextReader.__c.NativeMethodInfoPtr__ReadAsyncInternal_b__17_0_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr, 100675605);
			}

			// Token: 0x06006101 RID: 24833 RVA: 0x001B41DC File Offset: 0x001B23DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006102 RID: 24834 RVA: 0x001B4218 File Offset: 0x001B2418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429343, XrefRangeEnd = 1429350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ReadAsyncInternal_b__17_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReader.__c.NativeMethodInfoPtr__ReadAsyncInternal_b__17_0_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006103 RID: 24835 RVA: 0x00023D3B File Offset: 0x00021F3B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700192E RID: 6446
			// (get) Token: 0x06006104 RID: 24836 RVA: 0x001B4268 File Offset: 0x001B2468
			// (set) Token: 0x06006105 RID: 24837 RVA: 0x00023D44 File Offset: 0x00021F44
			public unsafe static TextReader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextReader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextReader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700192F RID: 6447
			// (get) Token: 0x06006106 RID: 24838 RVA: 0x001B4290 File Offset: 0x001B2490
			// (set) Token: 0x06006107 RID: 24839 RVA: 0x00023D56 File Offset: 0x00021F56
			public unsafe static Func<Object, int> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextReader.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextReader.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E8A RID: 20106
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004E8B RID: 20107
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04004E8C RID: 20108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004E8D RID: 20109
			private static readonly IntPtr NativeMethodInfoPtr__ReadAsyncInternal_b__17_0_Internal_Int32_Object_0;
		}
	}
}
