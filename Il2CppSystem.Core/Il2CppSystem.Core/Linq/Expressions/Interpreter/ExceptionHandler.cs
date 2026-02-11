using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C8 RID: 200
	public sealed class ExceptionHandler : Object
	{
		// Token: 0x06000C22 RID: 3106 RVA: 0x00041EF8 File Offset: 0x000400F8
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionHandler()
		{
			Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ExceptionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr);
			ExceptionHandler.NativeFieldInfoPtr__exceptionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr, "_exceptionType");
			ExceptionHandler.NativeFieldInfoPtr_LabelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr, "LabelIndex");
			ExceptionHandler.NativeFieldInfoPtr_HandlerStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr, "HandlerStartIndex");
			ExceptionHandler.NativeFieldInfoPtr_HandlerEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr, "HandlerEndIndex");
			ExceptionHandler.NativeFieldInfoPtr_Filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr, "Filter");
			ExceptionHandler.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Type_ExceptionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr, 100665518);
			ExceptionHandler.NativeMethodInfoPtr_Matches_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr, 100665519);
			ExceptionHandler.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr, 100665520);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00041FC8 File Offset: 0x000401C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1019985, RefRangeEnd = 1019986, XrefRangeStart = 1019982, XrefRangeEnd = 1019985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionHandler(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handlerStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handlerEndIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exceptionType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHandler.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Type_ExceptionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00042054 File Offset: 0x00040254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019986, XrefRangeEnd = 1019987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(Type exceptionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHandler.NativeMethodInfoPtr_Matches_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000420A4 File Offset: 0x000402A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019987, XrefRangeEnd = 1019999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHandler.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00005A5A File Offset: 0x00003C5A
		public ExceptionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000420DC File Offset: 0x000402DC
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00005A63 File Offset: 0x00003C63
		public unsafe Type _exceptionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr__exceptionType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr__exceptionType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0004210C File Offset: 0x0004030C
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00005A82 File Offset: 0x00003C82
		public unsafe int LabelIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr_LabelIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr_LabelIndex)) = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00042134 File Offset: 0x00040334
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00005A9D File Offset: 0x00003C9D
		public unsafe int HandlerStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr_HandlerStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr_HandlerStartIndex)) = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0004215C File Offset: 0x0004035C
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00005AB8 File Offset: 0x00003CB8
		public unsafe int HandlerEndIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr_HandlerEndIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr_HandlerEndIndex)) = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00042184 File Offset: 0x00040384
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00005AD3 File Offset: 0x00003CD3
		public unsafe ExceptionFilter Filter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr_Filter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandler.NativeFieldInfoPtr_Filter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr__exceptionType;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_LabelIndex;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_HandlerStartIndex;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_HandlerEndIndex;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_Filter;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Type_ExceptionFilter_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_Type_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
