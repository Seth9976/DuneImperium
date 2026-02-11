using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core
{
	// Token: 0x02000025 RID: 37
	public sealed class ErrorInfo : ValueType
	{
		// Token: 0x06000175 RID: 373 RVA: 0x0000A328 File Offset: 0x00008528
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorInfo()
		{
			Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core", "ErrorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr);
			ErrorInfo.NativeFieldInfoPtr_NONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, "NONE");
			ErrorInfo.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, "Code");
			ErrorInfo.NativeFieldInfoPtr_Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, "Exception");
			ErrorInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, 100663528);
			ErrorInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_ErrorInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, 100663529);
			ErrorInfo.NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, 100663530);
			ErrorInfo.NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, 100663531);
			ErrorInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_ErrorInfo_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, 100663532);
			ErrorInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, 100663533);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000A40C File Offset: 0x0000860C
		[CallerCount(0)]
		public unsafe bool Equals(ErrorInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ErrorInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000A464 File Offset: 0x00008664
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1063958, RefRangeEnd = 1063977, XrefRangeStart = 1063958, XrefRangeEnd = 1063977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator ErrorInfo(int code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_ErrorInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000A49C File Offset: 0x0000869C
		public unsafe bool Succeeded
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1181163, RefRangeEnd = 1181181, XrefRangeStart = 1181159, XrefRangeEnd = 1181163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorInfo.NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000A4E0 File Offset: 0x000086E0
		public unsafe bool Failed
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 1181185, RefRangeEnd = 1181224, XrefRangeStart = 1181181, XrefRangeEnd = 1181185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorInfo.NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000A524 File Offset: 0x00008724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181224, XrefRangeEnd = 1181233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ErrorInfo(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_ErrorInfo_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000A560 File Offset: 0x00008760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1181240, RefRangeEnd = 1181242, XrefRangeStart = 1181233, XrefRangeEnd = 1181240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002673 File Offset: 0x00000873
		public ErrorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000267C File Offset: 0x0000087C
		public ErrorInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000A59C File Offset: 0x0000879C
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0000268E File Offset: 0x0000088E
		public unsafe static ErrorInfo NONE
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ErrorInfo.NativeFieldInfoPtr_NONE, intPtr);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ErrorInfo.NativeFieldInfoPtr_NONE, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000A5D8 File Offset: 0x000087D8
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000026A5 File Offset: 0x000008A5
		public unsafe int Code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorInfo.NativeFieldInfoPtr_Code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorInfo.NativeFieldInfoPtr_Code)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000A600 File Offset: 0x00008800
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000026C0 File Offset: 0x000008C0
		public unsafe Exception Exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorInfo.NativeFieldInfoPtr_Exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorInfo.NativeFieldInfoPtr_Exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_NONE;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_Code;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_Exception;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ErrorInfo_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ErrorInfo_Int32_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ErrorInfo_Exception_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
