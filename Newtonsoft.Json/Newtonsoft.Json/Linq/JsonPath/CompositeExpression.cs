using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D5 RID: 213
	public class CompositeExpression : QueryExpression
	{
		// Token: 0x06001347 RID: 4935 RVA: 0x0006A9AC File Offset: 0x00068BAC
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeExpression()
		{
			Il2CppClassPointerStore<CompositeExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "CompositeExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeExpression>.NativeClassPtr);
			CompositeExpression.NativeFieldInfoPtr__Expressions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeExpression>.NativeClassPtr, "<Expressions>k__BackingField");
			CompositeExpression.NativeMethodInfoPtr_get_Expressions_Public_get_List_1_QueryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeExpression>.NativeClassPtr, 100666968);
			CompositeExpression.NativeMethodInfoPtr_set_Expressions_Public_set_Void_List_1_QueryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeExpression>.NativeClassPtr, 100666969);
			CompositeExpression.NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeExpression>.NativeClassPtr, 100666970);
			CompositeExpression.NativeMethodInfoPtr_IsMatch_Public_Virtual_Boolean_JToken_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeExpression>.NativeClassPtr, 100666971);
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0006AA40 File Offset: 0x00068C40
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x0006AA80 File Offset: 0x00068C80
		public unsafe List<QueryExpression> Expressions
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeExpression.NativeMethodInfoPtr_get_Expressions_Public_get_List_1_QueryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<QueryExpression>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeExpression.NativeMethodInfoPtr_set_Expressions_Public_set_Void_List_1_QueryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0006AAC4 File Offset: 0x00068CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 763258, RefRangeEnd = 763260, XrefRangeStart = 763250, XrefRangeEnd = 763258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeExpression(QueryOperator @operator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeExpression>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref @operator;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeExpression.NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0006AB0C File Offset: 0x00068D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763260, XrefRangeEnd = 763276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsMatch(JToken root, JToken t, JsonSelectSettings settings)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeExpression.NativeMethodInfoPtr_IsMatch_Public_Virtual_Boolean_JToken_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00007F16 File Offset: 0x00006116
		public CompositeExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x0006AB88 File Offset: 0x00068D88
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x00007F1F File Offset: 0x0000611F
		public unsafe List<QueryExpression> _Expressions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeExpression.NativeFieldInfoPtr__Expressions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QueryExpression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeExpression.NativeFieldInfoPtr__Expressions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeFieldInfoPtr__Expressions_k__BackingField;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_get_Expressions_Public_get_List_1_QueryExpression_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_set_Expressions_Public_set_Void_List_1_QueryExpression_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Virtual_Boolean_JToken_JToken_JsonSelectSettings_0;
	}
}
