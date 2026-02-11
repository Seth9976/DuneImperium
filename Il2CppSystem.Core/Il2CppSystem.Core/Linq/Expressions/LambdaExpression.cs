using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000058 RID: 88
	public class LambdaExpression : Expression
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x00029650 File Offset: 0x00027850
		// Note: this type is marked as 'beforefieldinit'.
		static LambdaExpression()
		{
			Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "LambdaExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr);
			LambdaExpression.NativeFieldInfoPtr__body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, "_body");
			LambdaExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664449);
			LambdaExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664450);
			LambdaExpression.NativeMethodInfoPtr_get_TypeCore_Internal_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664451);
			LambdaExpression.NativeMethodInfoPtr_get_PublicType_Internal_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664452);
			LambdaExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664453);
			LambdaExpression.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664454);
			LambdaExpression.NativeMethodInfoPtr_get_NameCore_Internal_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664455);
			LambdaExpression.NativeMethodInfoPtr_get_Body_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664456);
			LambdaExpression.NativeMethodInfoPtr_get_ReturnType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664457);
			LambdaExpression.NativeMethodInfoPtr_get_TailCall_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664458);
			LambdaExpression.NativeMethodInfoPtr_get_TailCallCore_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664459);
			LambdaExpression.NativeMethodInfoPtr_System_Linq_Expressions_IParameterProvider_GetParameter_Private_Virtual_Final_New_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664460);
			LambdaExpression.NativeMethodInfoPtr_GetParameter_Internal_Virtual_New_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664461);
			LambdaExpression.NativeMethodInfoPtr_System_Linq_Expressions_IParameterProvider_get_ParameterCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664462);
			LambdaExpression.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr, 100664463);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000297C0 File Offset: 0x000279C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014008, RefRangeEnd = 1014009, XrefRangeStart = 1014003, XrefRangeEnd = 1014008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LambdaExpression(Expression body)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LambdaExpression>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0002980C File Offset: 0x00027A0C
		public unsafe override Type Type
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1011778, RefRangeEnd = 1011786, XrefRangeStart = 1011778, XrefRangeEnd = 1011786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0002984C File Offset: 0x00027A4C
		public unsafe virtual Type TypeCore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LambdaExpression.NativeMethodInfoPtr_get_TypeCore_Internal_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00029898 File Offset: 0x00027A98
		public unsafe virtual Type PublicType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LambdaExpression.NativeMethodInfoPtr_get_PublicType_Internal_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000298E4 File Offset: 0x00027AE4
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00029920 File Offset: 0x00027B20
		public unsafe string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1014009, RefRangeEnd = 1014011, XrefRangeStart = 1014009, XrefRangeEnd = 1014009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00029958 File Offset: 0x00027B58
		public unsafe virtual string NameCore
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LambdaExpression.NativeMethodInfoPtr_get_NameCore_Internal_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0002999C File Offset: 0x00027B9C
		public unsafe Expression Body
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_get_Body_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000299DC File Offset: 0x00027BDC
		public unsafe Type ReturnType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1014023, RefRangeEnd = 1014024, XrefRangeStart = 1014011, XrefRangeEnd = 1014023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_get_ReturnType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00029A1C File Offset: 0x00027C1C
		public unsafe bool TailCall
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 992360, RefRangeEnd = 992361, XrefRangeStart = 992360, XrefRangeEnd = 992361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_get_TailCall_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00029A58 File Offset: 0x00027C58
		public unsafe virtual bool TailCallCore
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LambdaExpression.NativeMethodInfoPtr_get_TailCallCore_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00029AA0 File Offset: 0x00027CA0
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 466517, RefRangeEnd = 466545, XrefRangeStart = 466517, XrefRangeEnd = 466545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ParameterExpression System_Linq_Expressions_IParameterProvider_GetParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_System_Linq_Expressions_IParameterProvider_GetParameter_Private_Virtual_Final_New_ParameterExpression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00029AEC File Offset: 0x00027CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014024, XrefRangeEnd = 1014027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ParameterExpression GetParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LambdaExpression.NativeMethodInfoPtr_GetParameter_Internal_Virtual_New_ParameterExpression_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00029B44 File Offset: 0x00027D44
		public unsafe virtual int System.Linq.Expressions.IParameterProvider.ParameterCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LambdaExpression.NativeMethodInfoPtr_System_Linq_Expressions_IParameterProvider_get_ParameterCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00029B80 File Offset: 0x00027D80
		public unsafe virtual int ParameterCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014027, XrefRangeEnd = 1014030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LambdaExpression.NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000032A3 File Offset: 0x000014A3
		public LambdaExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00029BC8 File Offset: 0x00027DC8
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x000032AC File Offset: 0x000014AC
		public unsafe Expression _body
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LambdaExpression.NativeFieldInfoPtr__body);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LambdaExpression.NativeFieldInfoPtr__body), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr__body;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCore_Internal_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicType_Internal_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_get_NameCore_Internal_Virtual_New_get_String_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Public_get_Expression_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_get_Type_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_get_TailCall_Public_get_Boolean_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_get_TailCallCore_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_System_Linq_Expressions_IParameterProvider_GetParameter_Private_Virtual_Final_New_ParameterExpression_Int32_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Internal_Virtual_New_ParameterExpression_Int32_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_System_Linq_Expressions_IParameterProvider_get_ParameterCount_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterCount_Internal_Virtual_New_get_Int32_0;
	}
}
