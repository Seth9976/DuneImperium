using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200031D RID: 797
	public class FormatterConverter : Object
	{
		// Token: 0x060030C3 RID: 12483 RVA: 0x000F8574 File Offset: 0x000F6774
		// Note: this type is marked as 'beforefieldinit'.
		static FormatterConverter()
		{
			Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FormatterConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr);
			FormatterConverter.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100670975);
			FormatterConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100670976);
			FormatterConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100670977);
			FormatterConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100670978);
			FormatterConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100670979);
			FormatterConverter.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100670980);
			FormatterConverter.NativeMethodInfoPtr_ThrowValueNullException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100670981);
			FormatterConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100670982);
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x000F8644 File Offset: 0x000F6844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384559, XrefRangeEnd = 1384568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Convert(Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x000F86A8 File Offset: 0x000F68A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384568, XrefRangeEnd = 1384577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x000F86F8 File Offset: 0x000F68F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384577, XrefRangeEnd = 1384586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000F8748 File Offset: 0x000F6948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384586, XrefRangeEnd = 1384595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x000F8798 File Offset: 0x000F6998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384595, XrefRangeEnd = 1384604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x000F87E8 File Offset: 0x000F69E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384604, XrefRangeEnd = 1384613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000F8830 File Offset: 0x000F6A30
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1384619, RefRangeEnd = 1384625, XrefRangeStart = 1384613, XrefRangeEnd = 1384619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowValueNullException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ThrowValueNullException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000F8858 File Offset: 0x000F6A58
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatterConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x00010C7C File Offset: 0x0000EE7C
		public FormatterConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400283A RID: 10298
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0;

		// Token: 0x0400283B RID: 10299
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0;

		// Token: 0x0400283C RID: 10300
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0;

		// Token: 0x0400283D RID: 10301
		private static readonly IntPtr NativeMethodInfoPtr_ThrowValueNullException_Private_Static_Void_0;

		// Token: 0x0400283E RID: 10302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
