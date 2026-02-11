using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000066 RID: 102
	public class MemberExpression : Expression
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x0002B5F4 File Offset: 0x000297F4
		// Note: this type is marked as 'beforefieldinit'.
		static MemberExpression()
		{
			Il2CppClassPointerStore<MemberExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MemberExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr);
			MemberExpression.NativeFieldInfoPtr__Expression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, "<Expression>k__BackingField");
			MemberExpression.NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664508);
			MemberExpression.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664509);
			MemberExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664510);
			MemberExpression.NativeMethodInfoPtr_Make_Internal_Static_PropertyExpression_Expression_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664511);
			MemberExpression.NativeMethodInfoPtr_Make_Internal_Static_FieldExpression_Expression_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664512);
			MemberExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664513);
			MemberExpression.NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664514);
			MemberExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664515);
			MemberExpression.NativeMethodInfoPtr_Update_Public_MemberExpression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr, 100664516);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0002B6EC File Offset: 0x000298EC
		public unsafe MemberInfo Member
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 868124, RefRangeEnd = 868148, XrefRangeStart = 868124, XrefRangeEnd = 868148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0002B72C File Offset: 0x0002992C
		public unsafe Expression Expression
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0002B76C File Offset: 0x0002996C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014219, XrefRangeEnd = 1014224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberExpression(Expression expression)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberExpression>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0002B7B8 File Offset: 0x000299B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014233, RefRangeEnd = 1014234, XrefRangeStart = 1014224, XrefRangeEnd = 1014233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyExpression Make(Expression expression, PropertyInfo property)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr_Make_Internal_Static_PropertyExpression_Expression_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyExpression>(intPtr3) : null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0002B810 File Offset: 0x00029A10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014243, RefRangeEnd = 1014244, XrefRangeStart = 1014234, XrefRangeEnd = 1014243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldExpression Make(Expression expression, FieldInfo field)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr_Make_Internal_Static_FieldExpression_Expression_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldExpression>(intPtr3) : null;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0002B868 File Offset: 0x00029A68
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002B8A4 File Offset: 0x00029AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014244, XrefRangeEnd = 1014247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MemberInfo GetMember()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberExpression.NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002B8F0 File Offset: 0x00029AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014247, XrefRangeEnd = 1014248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002B94C File Offset: 0x00029B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014248, XrefRangeEnd = 1014252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberExpression Update(Expression expression)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberExpression.NativeMethodInfoPtr_Update_Public_MemberExpression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberExpression>(intPtr3) : null;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000353E File Offset: 0x0000173E
		public MemberExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0002B99C File Offset: 0x00029B9C
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00003547 File Offset: 0x00001747
		public unsafe Expression _Expression_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberExpression.NativeFieldInfoPtr__Expression_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberExpression.NativeFieldInfoPtr__Expression_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr__Expression_k__BackingField;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_get_Member_Public_get_MemberInfo_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_get_Expression_Public_get_Expression_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_Make_Internal_Static_PropertyExpression_Expression_PropertyInfo_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_Make_Internal_Static_FieldExpression_Expression_FieldInfo_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Internal_Virtual_New_MemberInfo_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_MemberExpression_Expression_0;
	}
}
