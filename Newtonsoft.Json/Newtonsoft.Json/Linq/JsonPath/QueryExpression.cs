using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D4 RID: 212
	public class QueryExpression : Object
	{
		// Token: 0x06001340 RID: 4928 RVA: 0x0006A7E0 File Offset: 0x000689E0
		// Note: this type is marked as 'beforefieldinit'.
		static QueryExpression()
		{
			Il2CppClassPointerStore<QueryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "QueryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryExpression>.NativeClassPtr);
			QueryExpression.NativeFieldInfoPtr_Operator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryExpression>.NativeClassPtr, "Operator");
			QueryExpression.NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExpression>.NativeClassPtr, 100666965);
			QueryExpression.NativeMethodInfoPtr_IsMatch_Public_Boolean_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExpression>.NativeClassPtr, 100666966);
			QueryExpression.NativeMethodInfoPtr_IsMatch_Public_Abstract_Virtual_New_Boolean_JToken_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExpression>.NativeClassPtr, 100666967);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0006A860 File Offset: 0x00068A60
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueryExpression(QueryOperator @operator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryExpression>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref @operator;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryExpression.NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0006A8A8 File Offset: 0x00068AA8
		[CallerCount(0)]
		public unsafe bool IsMatch(JToken root, JToken t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryExpression.NativeMethodInfoPtr_IsMatch_Public_Boolean_JToken_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0006A908 File Offset: 0x00068B08
		[CallerCount(0)]
		public unsafe virtual bool IsMatch(JToken root, JToken t, JsonSelectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryExpression.NativeMethodInfoPtr_IsMatch_Public_Abstract_Virtual_New_Boolean_JToken_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00007EF2 File Offset: 0x000060F2
		public QueryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x0006A984 File Offset: 0x00068B84
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x00007EFB File Offset: 0x000060FB
		public unsafe QueryOperator Operator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryExpression.NativeFieldInfoPtr_Operator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryExpression.NativeFieldInfoPtr_Operator)) = value;
			}
		}

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeFieldInfoPtr_Operator;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_JToken_JToken_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Abstract_Virtual_New_Boolean_JToken_JToken_JsonSelectSettings_0;
	}
}
