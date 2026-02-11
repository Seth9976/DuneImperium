using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D7 RID: 215
	public class QueryFilter : PathFilter
	{
		// Token: 0x0600135C RID: 4956 RVA: 0x0006AFDC File Offset: 0x000691DC
		// Note: this type is marked as 'beforefieldinit'.
		static QueryFilter()
		{
			Il2CppClassPointerStore<QueryFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "QueryFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryFilter>.NativeClassPtr);
			QueryFilter.NativeFieldInfoPtr_Expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter>.NativeClassPtr, "Expression");
			QueryFilter.NativeMethodInfoPtr__ctor_Public_Void_QueryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter>.NativeClassPtr, 100666979);
			QueryFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter>.NativeClassPtr, 100666980);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0006B048 File Offset: 0x00069248
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueryFilter(QueryExpression expression)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryFilter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter.NativeMethodInfoPtr__ctor_Public_Void_QueryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0006B094 File Offset: 0x00069294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763453, XrefRangeEnd = 763462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QueryFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00007F85 File Offset: 0x00006185
		public QueryFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0006B114 File Offset: 0x00069314
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x00007F8E File Offset: 0x0000618E
		public unsafe QueryExpression Expression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter.NativeFieldInfoPtr_Expression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QueryExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter.NativeFieldInfoPtr_Expression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeFieldInfoPtr_Expression;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_QueryExpression_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0;

		// Token: 0x0200021F RID: 543
		[ObfuscatedName("Newtonsoft.Json.Linq.JsonPath.QueryFilter+<ExecuteFilter>d__2")]
		public sealed class _ExecuteFilter_d__2 : Object
		{
			// Token: 0x06002211 RID: 8721 RVA: 0x000973E8 File Offset: 0x000955E8
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteFilter_d__2()
			{
				Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QueryFilter>.NativeClassPtr, "<ExecuteFilter>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr);
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>1__state");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>2__current");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>l__initialThreadId");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "current");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__current");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>4__this");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "root");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__root");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "settings");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__settings");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap1");
				QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap2");
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666981);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666982);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666983);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666984);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666985);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666986);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666987);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666988);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666989);
				QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666990);
			}

			// Token: 0x06002212 RID: 8722 RVA: 0x000975CC File Offset: 0x000957CC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteFilter_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryFilter._ExecuteFilter_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002213 RID: 8723 RVA: 0x00097614 File Offset: 0x00095814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763390, XrefRangeEnd = 763400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002214 RID: 8724 RVA: 0x00097648 File Offset: 0x00095848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763400, XrefRangeEnd = 763431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002215 RID: 8725 RVA: 0x00097684 File Offset: 0x00095884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763431, XrefRangeEnd = 763434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002216 RID: 8726 RVA: 0x000976B8 File Offset: 0x000958B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763434, XrefRangeEnd = 763437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x06002217 RID: 8727 RVA: 0x000976EC File Offset: 0x000958EC
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x06002218 RID: 8728 RVA: 0x0009772C File Offset: 0x0009592C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763437, XrefRangeEnd = 763442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x06002219 RID: 8729 RVA: 0x00097760 File Offset: 0x00095960
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600221A RID: 8730 RVA: 0x000977A0 File Offset: 0x000959A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763442, XrefRangeEnd = 763453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x0600221B RID: 8731 RVA: 0x000977E0 File Offset: 0x000959E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600221C RID: 8732 RVA: 0x00011490 File Offset: 0x0000F690
			public _ExecuteFilter_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009BD RID: 2493
			// (get) Token: 0x0600221D RID: 8733 RVA: 0x00097820 File Offset: 0x00095A20
			// (set) Token: 0x0600221E RID: 8734 RVA: 0x00011499 File Offset: 0x0000F699
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009BE RID: 2494
			// (get) Token: 0x0600221F RID: 8735 RVA: 0x00097848 File Offset: 0x00095A48
			// (set) Token: 0x06002220 RID: 8736 RVA: 0x000114B4 File Offset: 0x0000F6B4
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BF RID: 2495
			// (get) Token: 0x06002221 RID: 8737 RVA: 0x00097878 File Offset: 0x00095A78
			// (set) Token: 0x06002222 RID: 8738 RVA: 0x000114D3 File Offset: 0x0000F6D3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170009C0 RID: 2496
			// (get) Token: 0x06002223 RID: 8739 RVA: 0x000978A0 File Offset: 0x00095AA0
			// (set) Token: 0x06002224 RID: 8740 RVA: 0x000114EE File Offset: 0x0000F6EE
			public unsafe IEnumerable<JToken> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C1 RID: 2497
			// (get) Token: 0x06002225 RID: 8741 RVA: 0x000978D0 File Offset: 0x00095AD0
			// (set) Token: 0x06002226 RID: 8742 RVA: 0x0001150D File Offset: 0x0000F70D
			public unsafe IEnumerable<JToken> __3__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C2 RID: 2498
			// (get) Token: 0x06002227 RID: 8743 RVA: 0x00097900 File Offset: 0x00095B00
			// (set) Token: 0x06002228 RID: 8744 RVA: 0x0001152C File Offset: 0x0000F72C
			public unsafe QueryFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QueryFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C3 RID: 2499
			// (get) Token: 0x06002229 RID: 8745 RVA: 0x00097930 File Offset: 0x00095B30
			// (set) Token: 0x0600222A RID: 8746 RVA: 0x0001154B File Offset: 0x0000F74B
			public unsafe JToken root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C4 RID: 2500
			// (get) Token: 0x0600222B RID: 8747 RVA: 0x00097960 File Offset: 0x00095B60
			// (set) Token: 0x0600222C RID: 8748 RVA: 0x0001156A File Offset: 0x0000F76A
			public unsafe JToken __3__root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C5 RID: 2501
			// (get) Token: 0x0600222D RID: 8749 RVA: 0x00097990 File Offset: 0x00095B90
			// (set) Token: 0x0600222E RID: 8750 RVA: 0x00011589 File Offset: 0x0000F789
			public unsafe JsonSelectSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x0600222F RID: 8751 RVA: 0x000979C0 File Offset: 0x00095BC0
			// (set) Token: 0x06002230 RID: 8752 RVA: 0x000115A8 File Offset: 0x0000F7A8
			public unsafe JsonSelectSettings __3__settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x06002231 RID: 8753 RVA: 0x000979F0 File Offset: 0x00095BF0
			// (set) Token: 0x06002232 RID: 8754 RVA: 0x000115C7 File Offset: 0x0000F7C7
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x06002233 RID: 8755 RVA: 0x00097A20 File Offset: 0x00095C20
			// (set) Token: 0x06002234 RID: 8756 RVA: 0x000115E6 File Offset: 0x0000F7E6
			public unsafe IEnumerator<JToken> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueryFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001855 RID: 6229
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001856 RID: 6230
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001857 RID: 6231
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001858 RID: 6232
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04001859 RID: 6233
			private static readonly IntPtr NativeFieldInfoPtr___3__current;

			// Token: 0x0400185A RID: 6234
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400185B RID: 6235
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x0400185C RID: 6236
			private static readonly IntPtr NativeFieldInfoPtr___3__root;

			// Token: 0x0400185D RID: 6237
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x0400185E RID: 6238
			private static readonly IntPtr NativeFieldInfoPtr___3__settings;

			// Token: 0x0400185F RID: 6239
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001860 RID: 6240
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001861 RID: 6241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001862 RID: 6242
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001863 RID: 6243
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001864 RID: 6244
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001865 RID: 6245
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001866 RID: 6246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x04001867 RID: 6247
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001868 RID: 6248
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001869 RID: 6249
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x0400186A RID: 6250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
