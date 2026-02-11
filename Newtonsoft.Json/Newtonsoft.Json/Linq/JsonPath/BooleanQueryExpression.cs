using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D6 RID: 214
	public class BooleanQueryExpression : QueryExpression
	{
		// Token: 0x0600134F RID: 4943 RVA: 0x0006ABB8 File Offset: 0x00068DB8
		// Note: this type is marked as 'beforefieldinit'.
		static BooleanQueryExpression()
		{
			Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "BooleanQueryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr);
			BooleanQueryExpression.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, "Left");
			BooleanQueryExpression.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, "Right");
			BooleanQueryExpression.NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, 100666972);
			BooleanQueryExpression.NativeMethodInfoPtr_GetResult_Private_IEnumerable_1_JToken_JToken_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, 100666973);
			BooleanQueryExpression.NativeMethodInfoPtr_IsMatch_Public_Virtual_Boolean_JToken_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, 100666974);
			BooleanQueryExpression.NativeMethodInfoPtr_MatchTokens_Private_Boolean_JToken_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, 100666975);
			BooleanQueryExpression.NativeMethodInfoPtr_RegexEquals_Private_Static_Boolean_JValue_JValue_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, 100666976);
			BooleanQueryExpression.NativeMethodInfoPtr_EqualsWithStringCoercion_Internal_Static_Boolean_JValue_JValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, 100666977);
			BooleanQueryExpression.NativeMethodInfoPtr_EqualsWithStrictMatch_Internal_Static_Boolean_JValue_JValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr, 100666978);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0006AC9C File Offset: 0x00068E9C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 425621, RefRangeEnd = 425634, XrefRangeStart = 425621, XrefRangeEnd = 425634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BooleanQueryExpression(QueryOperator @operator, Object left, Object right)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BooleanQueryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref @operator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanQueryExpression.NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0006AD08 File Offset: 0x00068F08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 763299, RefRangeEnd = 763302, XrefRangeStart = 763276, XrefRangeEnd = 763299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> GetResult(JToken root, JToken t, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanQueryExpression.NativeMethodInfoPtr_GetResult_Private_IEnumerable_1_JToken_JToken_JToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0006AD7C File Offset: 0x00068F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763302, XrefRangeEnd = 763352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanQueryExpression.NativeMethodInfoPtr_IsMatch_Public_Virtual_Boolean_JToken_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0006ADF8 File Offset: 0x00068FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763357, RefRangeEnd = 763358, XrefRangeStart = 763352, XrefRangeEnd = 763357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchTokens(JToken leftResult, JToken rightResult, JsonSelectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightResult);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanQueryExpression.NativeMethodInfoPtr_MatchTokens_Private_Boolean_JToken_JToken_JsonSelectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0006AE6C File Offset: 0x0006906C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763358, XrefRangeEnd = 763376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegexEquals(JValue input, JValue pattern, JsonSelectSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanQueryExpression.NativeMethodInfoPtr_RegexEquals_Private_Static_Boolean_JValue_JValue_JsonSelectSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0006AED4 File Offset: 0x000690D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763388, RefRangeEnd = 763389, XrefRangeStart = 763376, XrefRangeEnd = 763388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualsWithStringCoercion(JValue value, JValue queryValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(queryValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanQueryExpression.NativeMethodInfoPtr_EqualsWithStringCoercion_Internal_Static_Boolean_JValue_JValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0006AF28 File Offset: 0x00069128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763389, XrefRangeEnd = 763390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualsWithStrictMatch(JValue value, JValue queryValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(queryValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanQueryExpression.NativeMethodInfoPtr_EqualsWithStrictMatch_Internal_Static_Boolean_JValue_JValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00007F3E File Offset: 0x0000613E
		public BooleanQueryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0006AF7C File Offset: 0x0006917C
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x00007F47 File Offset: 0x00006147
		public unsafe Object Left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanQueryExpression.NativeFieldInfoPtr_Left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanQueryExpression.NativeFieldInfoPtr_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0006AFAC File Offset: 0x000691AC
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x00007F66 File Offset: 0x00006166
		public unsafe Object Right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanQueryExpression.NativeFieldInfoPtr_Right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanQueryExpression.NativeFieldInfoPtr_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_QueryOperator_Object_Object_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Private_IEnumerable_1_JToken_JToken_JToken_Object_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Virtual_Boolean_JToken_JToken_JsonSelectSettings_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_MatchTokens_Private_Boolean_JToken_JToken_JsonSelectSettings_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_RegexEquals_Private_Static_Boolean_JValue_JValue_JsonSelectSettings_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_EqualsWithStringCoercion_Internal_Static_Boolean_JValue_JValue_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_EqualsWithStrictMatch_Internal_Static_Boolean_JValue_JValue_0;
	}
}
