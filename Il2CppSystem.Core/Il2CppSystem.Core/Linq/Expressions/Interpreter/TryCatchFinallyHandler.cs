using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C9 RID: 201
	public sealed class TryCatchFinallyHandler : Object
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x000421B4 File Offset: 0x000403B4
		// Note: this type is marked as 'beforefieldinit'.
		static TryCatchFinallyHandler()
		{
			Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "TryCatchFinallyHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr);
			TryCatchFinallyHandler.NativeFieldInfoPtr_TryStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, "TryStartIndex");
			TryCatchFinallyHandler.NativeFieldInfoPtr_TryEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, "TryEndIndex");
			TryCatchFinallyHandler.NativeFieldInfoPtr_FinallyStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, "FinallyStartIndex");
			TryCatchFinallyHandler.NativeFieldInfoPtr_FinallyEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, "FinallyEndIndex");
			TryCatchFinallyHandler.NativeFieldInfoPtr_GotoEndTargetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, "GotoEndTargetIndex");
			TryCatchFinallyHandler.NativeFieldInfoPtr__handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, "_handlers");
			TryCatchFinallyHandler.NativeMethodInfoPtr_get_IsFinallyBlockExist_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, 100665521);
			TryCatchFinallyHandler.NativeMethodInfoPtr_get_Handlers_Internal_get_Il2CppReferenceArray_1_ExceptionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, 100665522);
			TryCatchFinallyHandler.NativeMethodInfoPtr_get_IsCatchBlockExist_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, 100665523);
			TryCatchFinallyHandler.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Il2CppReferenceArray_1_ExceptionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, 100665524);
			TryCatchFinallyHandler.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_ExceptionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, 100665525);
			TryCatchFinallyHandler.NativeMethodInfoPtr_HasHandler_Internal_Boolean_InterpretedFrame_Exception_byref_ExceptionHandler_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, 100665526);
			TryCatchFinallyHandler.NativeMethodInfoPtr_FilterPasses_Private_Static_Boolean_InterpretedFrame_byref_Object_ExceptionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr, 100665527);
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000422E8 File Offset: 0x000404E8
		public unsafe bool IsFinallyBlockExist
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1019999, RefRangeEnd = 1020000, XrefRangeStart = 1019999, XrefRangeEnd = 1019999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryCatchFinallyHandler.NativeMethodInfoPtr_get_IsFinallyBlockExist_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00042324 File Offset: 0x00040524
		public unsafe Il2CppReferenceArray<ExceptionHandler> Handlers
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryCatchFinallyHandler.NativeMethodInfoPtr_get_Handlers_Internal_get_Il2CppReferenceArray_1_ExceptionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExceptionHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00042364 File Offset: 0x00040564
		public unsafe bool IsCatchBlockExist
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1020000, RefRangeEnd = 1020001, XrefRangeStart = 1020000, XrefRangeEnd = 1020000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryCatchFinallyHandler.NativeMethodInfoPtr_get_IsCatchBlockExist_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000423A0 File Offset: 0x000405A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020001, XrefRangeEnd = 1020003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, Il2CppReferenceArray<ExceptionHandler> handlers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tryStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gotoEndTargetIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryCatchFinallyHandler.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Il2CppReferenceArray_1_ExceptionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00042418 File Offset: 0x00040618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020003, XrefRangeEnd = 1020005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, Il2CppReferenceArray<ExceptionHandler> handlers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TryCatchFinallyHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tryStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gotoEndLabelIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finallyStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finallyEnd;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryCatchFinallyHandler.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_ExceptionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000424AC File Offset: 0x000406AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020009, RefRangeEnd = 1020010, XrefRangeStart = 1020005, XrefRangeEnd = 1020009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out Object unwrappedException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TryCatchFinallyHandler.NativeMethodInfoPtr_HasHandler_Internal_Boolean_InterpretedFrame_Exception_byref_ExceptionHandler_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			handler = ((intPtr5 == 0) ? null : new ExceptionHandler(intPtr5));
			IntPtr intPtr6 = intPtr2;
			unwrappedException = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00042554 File Offset: 0x00040754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020010, XrefRangeEnd = 1020018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterPasses(InterpretedFrame frame, ref Object exception, ExceptionFilter filter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TryCatchFinallyHandler.NativeMethodInfoPtr_FilterPasses_Private_Static_Boolean_InterpretedFrame_byref_Object_ExceptionFilter_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			exception = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00005AF2 File Offset: 0x00003CF2
		public TryCatchFinallyHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x000425D0 File Offset: 0x000407D0
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00005AFB File Offset: 0x00003CFB
		public unsafe int TryStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_TryStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_TryStartIndex)) = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000425F8 File Offset: 0x000407F8
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x00005B16 File Offset: 0x00003D16
		public unsafe int TryEndIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_TryEndIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_TryEndIndex)) = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00042620 File Offset: 0x00040820
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00005B31 File Offset: 0x00003D31
		public unsafe int FinallyStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_FinallyStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_FinallyStartIndex)) = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00042648 File Offset: 0x00040848
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00005B4C File Offset: 0x00003D4C
		public unsafe int FinallyEndIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_FinallyEndIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_FinallyEndIndex)) = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00042670 File Offset: 0x00040870
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00005B67 File Offset: 0x00003D67
		public unsafe int GotoEndTargetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_GotoEndTargetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr_GotoEndTargetIndex)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00042698 File Offset: 0x00040898
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00005B82 File Offset: 0x00003D82
		public unsafe Il2CppReferenceArray<ExceptionHandler> _handlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr__handlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExceptionHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryCatchFinallyHandler.NativeFieldInfoPtr__handlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_TryStartIndex;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_TryEndIndex;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr_FinallyStartIndex;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_FinallyEndIndex;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_GotoEndTargetIndex;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr__handlers;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFinallyBlockExist_Internal_get_Boolean_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_get_Handlers_Internal_get_Il2CppReferenceArray_1_ExceptionHandler_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCatchBlockExist_Internal_get_Boolean_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Il2CppReferenceArray_1_ExceptionHandler_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_ExceptionHandler_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_HasHandler_Internal_Boolean_InterpretedFrame_Exception_byref_ExceptionHandler_byref_Object_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_FilterPasses_Private_Static_Boolean_InterpretedFrame_byref_Object_ExceptionFilter_0;
	}
}
