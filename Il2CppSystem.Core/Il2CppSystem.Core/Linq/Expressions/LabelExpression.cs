using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000056 RID: 86
	public sealed class LabelExpression : Expression
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x000290EC File Offset: 0x000272EC
		// Note: this type is marked as 'beforefieldinit'.
		static LabelExpression()
		{
			Il2CppClassPointerStore<LabelExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "LabelExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr);
			LabelExpression.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, "<Target>k__BackingField");
			LabelExpression.NativeFieldInfoPtr__DefaultValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, "<DefaultValue>k__BackingField");
			LabelExpression.NativeMethodInfoPtr__ctor_Internal_Void_LabelTarget_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, 100664438);
			LabelExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, 100664439);
			LabelExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, 100664440);
			LabelExpression.NativeMethodInfoPtr_get_Target_Public_get_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, 100664441);
			LabelExpression.NativeMethodInfoPtr_get_DefaultValue_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, 100664442);
			LabelExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, 100664443);
			LabelExpression.NativeMethodInfoPtr_Update_Public_LabelExpression_LabelTarget_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr, 100664444);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000291D0 File Offset: 0x000273D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1013996, RefRangeEnd = 1013998, XrefRangeStart = 1013990, XrefRangeEnd = 1013996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelExpression(LabelTarget label, Expression defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelExpression.NativeMethodInfoPtr__ctor_Internal_Void_LabelTarget_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00029230 File Offset: 0x00027430
		public unsafe override Type Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00029270 File Offset: 0x00027470
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000292AC File Offset: 0x000274AC
		public unsafe LabelTarget Target
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelExpression.NativeMethodInfoPtr_get_Target_Public_get_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr3) : null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x000292EC File Offset: 0x000274EC
		public unsafe Expression DefaultValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelExpression.NativeMethodInfoPtr_get_DefaultValue_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0002932C File Offset: 0x0002752C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013998, XrefRangeEnd = 1013999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0002937C File Offset: 0x0002757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013999, XrefRangeEnd = 1014000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelExpression Update(LabelTarget target, Expression defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelExpression.NativeMethodInfoPtr_Update_Public_LabelExpression_LabelTarget_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelExpression>(intPtr3) : null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00003215 File Offset: 0x00001415
		public LabelExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000293E0 File Offset: 0x000275E0
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0000321E File Offset: 0x0000141E
		public unsafe LabelTarget _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelExpression.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelExpression.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00029410 File Offset: 0x00027610
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000323D File Offset: 0x0000143D
		public unsafe Expression _DefaultValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelExpression.NativeFieldInfoPtr__DefaultValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelExpression.NativeFieldInfoPtr__DefaultValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr__DefaultValue_k__BackingField;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LabelTarget_Expression_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_LabelTarget_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_Expression_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_LabelExpression_LabelTarget_Expression_0;
	}
}
