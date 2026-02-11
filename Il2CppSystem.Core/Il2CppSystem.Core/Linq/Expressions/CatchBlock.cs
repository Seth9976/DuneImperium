using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000039 RID: 57
	public sealed class CatchBlock : Object
	{
		// Token: 0x0600035C RID: 860 RVA: 0x00020BD8 File Offset: 0x0001EDD8
		// Note: this type is marked as 'beforefieldinit'.
		static CatchBlock()
		{
			Il2CppClassPointerStore<CatchBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "CatchBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr);
			CatchBlock.NativeFieldInfoPtr__Variable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, "<Variable>k__BackingField");
			CatchBlock.NativeFieldInfoPtr__Test_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, "<Test>k__BackingField");
			CatchBlock.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, "<Body>k__BackingField");
			CatchBlock.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, "<Filter>k__BackingField");
			CatchBlock.NativeMethodInfoPtr__ctor_Internal_Void_Type_ParameterExpression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, 100664138);
			CatchBlock.NativeMethodInfoPtr_get_Variable_Public_get_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, 100664139);
			CatchBlock.NativeMethodInfoPtr_get_Test_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, 100664140);
			CatchBlock.NativeMethodInfoPtr_get_Body_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, 100664141);
			CatchBlock.NativeMethodInfoPtr_get_Filter_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, 100664142);
			CatchBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, 100664143);
			CatchBlock.NativeMethodInfoPtr_Update_Public_CatchBlock_ParameterExpression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr, 100664144);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00020CE4 File Offset: 0x0001EEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012071, RefRangeEnd = 1012072, XrefRangeStart = 1012066, XrefRangeEnd = 1012071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CatchBlock>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(test);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatchBlock.NativeMethodInfoPtr__ctor_Internal_Void_Type_ParameterExpression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00020D68 File Offset: 0x0001EF68
		public unsafe ParameterExpression Variable
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatchBlock.NativeMethodInfoPtr_get_Variable_Public_get_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		public unsafe Type Test
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatchBlock.NativeMethodInfoPtr_get_Test_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00020DE8 File Offset: 0x0001EFE8
		public unsafe Expression Body
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatchBlock.NativeMethodInfoPtr_get_Body_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00020E28 File Offset: 0x0001F028
		public unsafe Expression Filter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatchBlock.NativeMethodInfoPtr_get_Filter_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00020E68 File Offset: 0x0001F068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012072, XrefRangeEnd = 1012081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatchBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00020EA0 File Offset: 0x0001F0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012081, XrefRangeEnd = 1012086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CatchBlock Update(ParameterExpression variable, Expression filter, Expression body)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatchBlock.NativeMethodInfoPtr_Update_Public_CatchBlock_ParameterExpression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CatchBlock>(intPtr3) : null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002BFF File Offset: 0x00000DFF
		public CatchBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00020F14 File Offset: 0x0001F114
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00002C08 File Offset: 0x00000E08
		public unsafe ParameterExpression _Variable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CatchBlock.NativeFieldInfoPtr__Variable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CatchBlock.NativeFieldInfoPtr__Variable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00020F44 File Offset: 0x0001F144
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00002C27 File Offset: 0x00000E27
		public unsafe Type _Test_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CatchBlock.NativeFieldInfoPtr__Test_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CatchBlock.NativeFieldInfoPtr__Test_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00020F74 File Offset: 0x0001F174
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00002C46 File Offset: 0x00000E46
		public unsafe Expression _Body_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CatchBlock.NativeFieldInfoPtr__Body_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CatchBlock.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00002C65 File Offset: 0x00000E65
		public unsafe Expression _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CatchBlock.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CatchBlock.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr__Variable_k__BackingField;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr__Test_k__BackingField;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ParameterExpression_Expression_Expression_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_get_Variable_Public_get_ParameterExpression_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_get_Test_Public_get_Type_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Public_get_Expression_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_Expression_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_CatchBlock_ParameterExpression_Expression_Expression_0;
	}
}
