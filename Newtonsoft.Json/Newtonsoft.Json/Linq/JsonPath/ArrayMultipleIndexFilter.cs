using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000CD RID: 205
	public class ArrayMultipleIndexFilter : PathFilter
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x000693B0 File Offset: 0x000675B0
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayMultipleIndexFilter()
		{
			Il2CppClassPointerStore<ArrayMultipleIndexFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "ArrayMultipleIndexFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayMultipleIndexFilter>.NativeClassPtr);
			ArrayMultipleIndexFilter.NativeFieldInfoPtr_Indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter>.NativeClassPtr, "Indexes");
			ArrayMultipleIndexFilter.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter>.NativeClassPtr, 100666881);
			ArrayMultipleIndexFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter>.NativeClassPtr, 100666882);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0006941C File Offset: 0x0006761C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayMultipleIndexFilter(List<int> indexes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayMultipleIndexFilter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00069468 File Offset: 0x00067668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762529, XrefRangeEnd = 762537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayMultipleIndexFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00007D6A File Offset: 0x00005F6A
		public ArrayMultipleIndexFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x000694E8 File Offset: 0x000676E8
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00007D73 File Offset: 0x00005F73
		public unsafe List<int> Indexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter.NativeFieldInfoPtr_Indexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter.NativeFieldInfoPtr_Indexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeFieldInfoPtr_Indexes;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0;

		// Token: 0x0200021A RID: 538
		[ObfuscatedName("Newtonsoft.Json.Linq.JsonPath.ArrayMultipleIndexFilter+<ExecuteFilter>d__2")]
		public sealed class _ExecuteFilter_d__2 : Object
		{
			// Token: 0x0600217C RID: 8572 RVA: 0x000959AC File Offset: 0x00093BAC
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteFilter_d__2()
			{
				Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayMultipleIndexFilter>.NativeClassPtr, "<ExecuteFilter>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>1__state");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>2__current");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>l__initialThreadId");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "current");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__current");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>4__this");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "settings");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__settings");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap1");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<t>5__3");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap3");
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666883);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666884);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666885);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666886);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666887);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666888);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666889);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666890);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666891);
				ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666892);
			}

			// Token: 0x0600217D RID: 8573 RVA: 0x00095B7C File Offset: 0x00093D7C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteFilter_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayMultipleIndexFilter._ExecuteFilter_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600217E RID: 8574 RVA: 0x00095BC4 File Offset: 0x00093DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762461, XrefRangeEnd = 762474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600217F RID: 8575 RVA: 0x00095BF8 File Offset: 0x00093DF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762474, XrefRangeEnd = 762508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002180 RID: 8576 RVA: 0x00095C34 File Offset: 0x00093E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762508, XrefRangeEnd = 762511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002181 RID: 8577 RVA: 0x00095C68 File Offset: 0x00093E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762511, XrefRangeEnd = 762514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700098F RID: 2447
			// (get) Token: 0x06002182 RID: 8578 RVA: 0x00095C9C File Offset: 0x00093E9C
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x06002183 RID: 8579 RVA: 0x00095CDC File Offset: 0x00093EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762514, XrefRangeEnd = 762519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000990 RID: 2448
			// (get) Token: 0x06002184 RID: 8580 RVA: 0x00095D10 File Offset: 0x00093F10
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002185 RID: 8581 RVA: 0x00095D50 File Offset: 0x00093F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762519, XrefRangeEnd = 762529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x06002186 RID: 8582 RVA: 0x00095D90 File Offset: 0x00093F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002187 RID: 8583 RVA: 0x00010EA0 File Offset: 0x0000F0A0
			public _ExecuteFilter_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000984 RID: 2436
			// (get) Token: 0x06002188 RID: 8584 RVA: 0x00095DD0 File Offset: 0x00093FD0
			// (set) Token: 0x06002189 RID: 8585 RVA: 0x00010EA9 File Offset: 0x0000F0A9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000985 RID: 2437
			// (get) Token: 0x0600218A RID: 8586 RVA: 0x00095DF8 File Offset: 0x00093FF8
			// (set) Token: 0x0600218B RID: 8587 RVA: 0x00010EC4 File Offset: 0x0000F0C4
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000986 RID: 2438
			// (get) Token: 0x0600218C RID: 8588 RVA: 0x00095E28 File Offset: 0x00094028
			// (set) Token: 0x0600218D RID: 8589 RVA: 0x00010EE3 File Offset: 0x0000F0E3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000987 RID: 2439
			// (get) Token: 0x0600218E RID: 8590 RVA: 0x00095E50 File Offset: 0x00094050
			// (set) Token: 0x0600218F RID: 8591 RVA: 0x00010EFE File Offset: 0x0000F0FE
			public unsafe IEnumerable<JToken> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000988 RID: 2440
			// (get) Token: 0x06002190 RID: 8592 RVA: 0x00095E80 File Offset: 0x00094080
			// (set) Token: 0x06002191 RID: 8593 RVA: 0x00010F1D File Offset: 0x0000F11D
			public unsafe IEnumerable<JToken> __3__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000989 RID: 2441
			// (get) Token: 0x06002192 RID: 8594 RVA: 0x00095EB0 File Offset: 0x000940B0
			// (set) Token: 0x06002193 RID: 8595 RVA: 0x00010F3C File Offset: 0x0000F13C
			public unsafe ArrayMultipleIndexFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayMultipleIndexFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098A RID: 2442
			// (get) Token: 0x06002194 RID: 8596 RVA: 0x00095EE0 File Offset: 0x000940E0
			// (set) Token: 0x06002195 RID: 8597 RVA: 0x00010F5B File Offset: 0x0000F15B
			public unsafe JsonSelectSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098B RID: 2443
			// (get) Token: 0x06002196 RID: 8598 RVA: 0x00095F10 File Offset: 0x00094110
			// (set) Token: 0x06002197 RID: 8599 RVA: 0x00010F7A File Offset: 0x0000F17A
			public unsafe JsonSelectSettings __3__settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098C RID: 2444
			// (get) Token: 0x06002198 RID: 8600 RVA: 0x00095F40 File Offset: 0x00094140
			// (set) Token: 0x06002199 RID: 8601 RVA: 0x00010F99 File Offset: 0x0000F199
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098D RID: 2445
			// (get) Token: 0x0600219A RID: 8602 RVA: 0x00095F70 File Offset: 0x00094170
			// (set) Token: 0x0600219B RID: 8603 RVA: 0x00010FB8 File Offset: 0x0000F1B8
			public unsafe JToken _t_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__t_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__t_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098E RID: 2446
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x00095FA0 File Offset: 0x000941A0
			// (set) Token: 0x0600219D RID: 8605 RVA: 0x00010FD7 File Offset: 0x0000F1D7
			public List<int>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap3);
					return new List<int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayMultipleIndexFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040017FB RID: 6139
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017FC RID: 6140
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017FD RID: 6141
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040017FE RID: 6142
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040017FF RID: 6143
			private static readonly IntPtr NativeFieldInfoPtr___3__current;

			// Token: 0x04001800 RID: 6144
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001801 RID: 6145
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04001802 RID: 6146
			private static readonly IntPtr NativeFieldInfoPtr___3__settings;

			// Token: 0x04001803 RID: 6147
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001804 RID: 6148
			private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x04001805 RID: 6149
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04001806 RID: 6150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001807 RID: 6151
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001808 RID: 6152
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001809 RID: 6153
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400180A RID: 6154
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x0400180B RID: 6155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x0400180C RID: 6156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400180D RID: 6157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400180E RID: 6158
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x0400180F RID: 6159
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
