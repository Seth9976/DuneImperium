using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C7 RID: 199
	public sealed class ExceptionFilter : Object
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x00041D9C File Offset: 0x0003FF9C
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionFilter()
		{
			Il2CppClassPointerStore<ExceptionFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ExceptionFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionFilter>.NativeClassPtr);
			ExceptionFilter.NativeFieldInfoPtr_LabelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionFilter>.NativeClassPtr, "LabelIndex");
			ExceptionFilter.NativeFieldInfoPtr_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionFilter>.NativeClassPtr, "StartIndex");
			ExceptionFilter.NativeFieldInfoPtr_EndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionFilter>.NativeClassPtr, "EndIndex");
			ExceptionFilter.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionFilter>.NativeClassPtr, 100665517);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00041E1C File Offset: 0x0004001C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 904096, RefRangeEnd = 904103, XrefRangeStart = 904096, XrefRangeEnd = 904103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionFilter(int labelIndex, int start, int end)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionFilter.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00005A00 File Offset: 0x00003C00
		public ExceptionFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00041E80 File Offset: 0x00040080
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x00005A09 File Offset: 0x00003C09
		public unsafe int LabelIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionFilter.NativeFieldInfoPtr_LabelIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionFilter.NativeFieldInfoPtr_LabelIndex)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00041EA8 File Offset: 0x000400A8
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x00005A24 File Offset: 0x00003C24
		public unsafe int StartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionFilter.NativeFieldInfoPtr_StartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionFilter.NativeFieldInfoPtr_StartIndex)) = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00041ED0 File Offset: 0x000400D0
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x00005A3F File Offset: 0x00003C3F
		public unsafe int EndIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionFilter.NativeFieldInfoPtr_EndIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionFilter.NativeFieldInfoPtr_EndIndex)) = value;
			}
		}

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_LabelIndex;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_StartIndex;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_EndIndex;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0;
	}
}
