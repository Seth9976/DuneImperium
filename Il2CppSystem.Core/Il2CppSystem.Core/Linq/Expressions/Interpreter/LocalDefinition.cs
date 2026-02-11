using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000E6 RID: 230
	public sealed class LocalDefinition : ValueType
	{
		// Token: 0x06000DD6 RID: 3542 RVA: 0x0004D55C File Offset: 0x0004B75C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDefinition()
		{
			Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LocalDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr);
			LocalDefinition.NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, "<Index>k__BackingField");
			LocalDefinition.NativeFieldInfoPtr__Parameter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, "<Parameter>k__BackingField");
			LocalDefinition.NativeMethodInfoPtr__ctor_Internal_Void_Int32_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, 100665839);
			LocalDefinition.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, 100665840);
			LocalDefinition.NativeMethodInfoPtr_get_Parameter_Public_get_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, 100665841);
			LocalDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, 100665842);
			LocalDefinition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr, 100665843);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0004D618 File Offset: 0x0004B818
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344943, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDefinition(int localIndex, ParameterExpression parameter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDefinition.NativeMethodInfoPtr__ctor_Internal_Void_Int32_ParameterExpression_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0004D678 File Offset: 0x0004B878
		public unsafe int Index
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDefinition.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0004D6BC File Offset: 0x0004B8BC
		public unsafe ParameterExpression Parameter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDefinition.NativeMethodInfoPtr_get_Parameter_Public_get_ParameterExpression_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0004D700 File Offset: 0x0004B900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024798, XrefRangeEnd = 1024801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0004D754 File Offset: 0x0004B954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024801, XrefRangeEnd = 1024802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDefinition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00006284 File Offset: 0x00004484
		public LocalDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0000628D File Offset: 0x0000448D
		public LocalDefinition()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDefinition>.NativeClassPtr))
		{
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0004D798 File Offset: 0x0004B998
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0000629F File Offset: 0x0000449F
		public unsafe int _Index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDefinition.NativeFieldInfoPtr__Index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDefinition.NativeFieldInfoPtr__Index_k__BackingField)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x000062BA File Offset: 0x000044BA
		public unsafe ParameterExpression _Parameter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDefinition.NativeFieldInfoPtr__Parameter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDefinition.NativeFieldInfoPtr__Parameter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr__Index_k__BackingField;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr__Parameter_k__BackingField;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_ParameterExpression_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_get_Parameter_Public_get_ParameterExpression_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
