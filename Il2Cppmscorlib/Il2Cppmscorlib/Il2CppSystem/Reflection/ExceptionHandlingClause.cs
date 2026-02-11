using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000440 RID: 1088
	public class ExceptionHandlingClause : Object
	{
		// Token: 0x06003ED2 RID: 16082 RVA: 0x0012D478 File Offset: 0x0012B678
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionHandlingClause()
		{
			Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ExceptionHandlingClause");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr);
			ExceptionHandlingClause.NativeFieldInfoPtr_catch_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "catch_type");
			ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "filter_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "flags");
			ExceptionHandlingClause.NativeFieldInfoPtr_try_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "try_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_try_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "try_length");
			ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "handler_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_handler_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "handler_length");
			ExceptionHandlingClause.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, 100672757);
			ExceptionHandlingClause.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, 100672758);
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0012D55C File Offset: 0x0012B75C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionHandlingClause()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHandlingClause.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x0012D598 File Offset: 0x0012B798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401101, XrefRangeEnd = 1401141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExceptionHandlingClause.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x00016ECB File Offset: 0x000150CB
		public ExceptionHandlingClause(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06003ED6 RID: 16086 RVA: 0x0012D5DC File Offset: 0x0012B7DC
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x00016ED4 File Offset: 0x000150D4
		public unsafe Type catch_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_catch_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_catch_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x0012D60C File Offset: 0x0012B80C
		// (set) Token: 0x06003ED9 RID: 16089 RVA: 0x00016EF3 File Offset: 0x000150F3
		public unsafe int filter_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset)) = value;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x0012D634 File Offset: 0x0012B834
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x00016F0E File Offset: 0x0001510E
		public unsafe ExceptionHandlingClauseOptions flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x0012D65C File Offset: 0x0012B85C
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x00016F29 File Offset: 0x00015129
		public unsafe int try_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_offset)) = value;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x0012D684 File Offset: 0x0012B884
		// (set) Token: 0x06003EDF RID: 16095 RVA: 0x00016F44 File Offset: 0x00015144
		public unsafe int try_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_length)) = value;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x0012D6AC File Offset: 0x0012B8AC
		// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x00016F5F File Offset: 0x0001515F
		public unsafe int handler_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset)) = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06003EE2 RID: 16098 RVA: 0x0012D6D4 File Offset: 0x0012B8D4
		// (set) Token: 0x06003EE3 RID: 16099 RVA: 0x00016F7A File Offset: 0x0001517A
		public unsafe int handler_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_length)) = value;
			}
		}

		// Token: 0x040033C6 RID: 13254
		private static readonly IntPtr NativeFieldInfoPtr_catch_type;

		// Token: 0x040033C7 RID: 13255
		private static readonly IntPtr NativeFieldInfoPtr_filter_offset;

		// Token: 0x040033C8 RID: 13256
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040033C9 RID: 13257
		private static readonly IntPtr NativeFieldInfoPtr_try_offset;

		// Token: 0x040033CA RID: 13258
		private static readonly IntPtr NativeFieldInfoPtr_try_length;

		// Token: 0x040033CB RID: 13259
		private static readonly IntPtr NativeFieldInfoPtr_handler_offset;

		// Token: 0x040033CC RID: 13260
		private static readonly IntPtr NativeFieldInfoPtr_handler_length;

		// Token: 0x040033CD RID: 13261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040033CE RID: 13262
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
