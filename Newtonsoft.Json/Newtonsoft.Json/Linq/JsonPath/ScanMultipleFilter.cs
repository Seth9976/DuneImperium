using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000DB RID: 219
	public class ScanMultipleFilter : PathFilter
	{
		// Token: 0x06001374 RID: 4980 RVA: 0x0006B55C File Offset: 0x0006975C
		// Note: this type is marked as 'beforefieldinit'.
		static ScanMultipleFilter()
		{
			Il2CppClassPointerStore<ScanMultipleFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "ScanMultipleFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScanMultipleFilter>.NativeClassPtr);
			ScanMultipleFilter.NativeFieldInfoPtr__names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter>.NativeClassPtr, "_names");
			ScanMultipleFilter.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter>.NativeClassPtr, 100667017);
			ScanMultipleFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter>.NativeClassPtr, 100667018);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0006B5C8 File Offset: 0x000697C8
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScanMultipleFilter(List<string> names)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScanMultipleFilter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0006B614 File Offset: 0x00069814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763700, XrefRangeEnd = 763707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScanMultipleFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00008018 File Offset: 0x00006218
		public ScanMultipleFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x0006B694 File Offset: 0x00069894
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x00008021 File Offset: 0x00006221
		public unsafe List<string> _names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter.NativeFieldInfoPtr__names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter.NativeFieldInfoPtr__names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr__names;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0;

		// Token: 0x02000222 RID: 546
		[ObfuscatedName("Newtonsoft.Json.Linq.JsonPath.ScanMultipleFilter+<ExecuteFilter>d__2")]
		public sealed class _ExecuteFilter_d__2 : Object
		{
			// Token: 0x06002276 RID: 8822 RVA: 0x0009860C File Offset: 0x0009680C
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteFilter_d__2()
			{
				Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScanMultipleFilter>.NativeClassPtr, "<ExecuteFilter>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>1__state");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>2__current");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>l__initialThreadId");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "current");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__current");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>4__this");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap1");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__c_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<c>5__3");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__value_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<value>5__4");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__property_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<property>5__5");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap5");
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667019);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667020);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667021);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667022);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667023);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667024);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667025);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667026);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667027);
				ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100667028);
			}

			// Token: 0x06002277 RID: 8823 RVA: 0x000987DC File Offset: 0x000969DC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteFilter_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScanMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002278 RID: 8824 RVA: 0x00098824 File Offset: 0x00096A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763615, XrefRangeEnd = 763628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002279 RID: 8825 RVA: 0x00098858 File Offset: 0x00096A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763628, XrefRangeEnd = 763680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600227A RID: 8826 RVA: 0x00098894 File Offset: 0x00096A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763680, XrefRangeEnd = 763683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600227B RID: 8827 RVA: 0x000988C8 File Offset: 0x00096AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763683, XrefRangeEnd = 763686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009EF RID: 2543
			// (get) Token: 0x0600227C RID: 8828 RVA: 0x000988FC File Offset: 0x00096AFC
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x0600227D RID: 8829 RVA: 0x0009893C File Offset: 0x00096B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763686, XrefRangeEnd = 763691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009F0 RID: 2544
			// (get) Token: 0x0600227E RID: 8830 RVA: 0x00098970 File Offset: 0x00096B70
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600227F RID: 8831 RVA: 0x000989B0 File Offset: 0x00096BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763691, XrefRangeEnd = 763700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x06002280 RID: 8832 RVA: 0x000989F0 File Offset: 0x00096BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScanMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002281 RID: 8833 RVA: 0x00011892 File Offset: 0x0000FA92
			public _ExecuteFilter_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E4 RID: 2532
			// (get) Token: 0x06002282 RID: 8834 RVA: 0x00098A30 File Offset: 0x00096C30
			// (set) Token: 0x06002283 RID: 8835 RVA: 0x0001189B File Offset: 0x0000FA9B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009E5 RID: 2533
			// (get) Token: 0x06002284 RID: 8836 RVA: 0x00098A58 File Offset: 0x00096C58
			// (set) Token: 0x06002285 RID: 8837 RVA: 0x000118B6 File Offset: 0x0000FAB6
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E6 RID: 2534
			// (get) Token: 0x06002286 RID: 8838 RVA: 0x00098A88 File Offset: 0x00096C88
			// (set) Token: 0x06002287 RID: 8839 RVA: 0x000118D5 File Offset: 0x0000FAD5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x06002288 RID: 8840 RVA: 0x00098AB0 File Offset: 0x00096CB0
			// (set) Token: 0x06002289 RID: 8841 RVA: 0x000118F0 File Offset: 0x0000FAF0
			public unsafe IEnumerable<JToken> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x0600228A RID: 8842 RVA: 0x00098AE0 File Offset: 0x00096CE0
			// (set) Token: 0x0600228B RID: 8843 RVA: 0x0001190F File Offset: 0x0000FB0F
			public unsafe IEnumerable<JToken> __3__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x0600228C RID: 8844 RVA: 0x00098B10 File Offset: 0x00096D10
			// (set) Token: 0x0600228D RID: 8845 RVA: 0x0001192E File Offset: 0x0000FB2E
			public unsafe ScanMultipleFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScanMultipleFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EA RID: 2538
			// (get) Token: 0x0600228E RID: 8846 RVA: 0x00098B40 File Offset: 0x00096D40
			// (set) Token: 0x0600228F RID: 8847 RVA: 0x0001194D File Offset: 0x0000FB4D
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EB RID: 2539
			// (get) Token: 0x06002290 RID: 8848 RVA: 0x00098B70 File Offset: 0x00096D70
			// (set) Token: 0x06002291 RID: 8849 RVA: 0x0001196C File Offset: 0x0000FB6C
			public unsafe JToken _c_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__c_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__c_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EC RID: 2540
			// (get) Token: 0x06002292 RID: 8850 RVA: 0x00098BA0 File Offset: 0x00096DA0
			// (set) Token: 0x06002293 RID: 8851 RVA: 0x0001198B File Offset: 0x0000FB8B
			public unsafe JToken _value_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__value_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__value_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009ED RID: 2541
			// (get) Token: 0x06002294 RID: 8852 RVA: 0x00098BD0 File Offset: 0x00096DD0
			// (set) Token: 0x06002295 RID: 8853 RVA: 0x000119AA File Offset: 0x0000FBAA
			public unsafe JProperty _property_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__property_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__property_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EE RID: 2542
			// (get) Token: 0x06002296 RID: 8854 RVA: 0x00098C00 File Offset: 0x00096E00
			// (set) Token: 0x06002297 RID: 8855 RVA: 0x000119C9 File Offset: 0x0000FBC9
			public List<string>.Enumerator __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap5);
					return new List<string>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<string>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScanMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<string>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001893 RID: 6291
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001894 RID: 6292
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001895 RID: 6293
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001896 RID: 6294
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04001897 RID: 6295
			private static readonly IntPtr NativeFieldInfoPtr___3__current;

			// Token: 0x04001898 RID: 6296
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001899 RID: 6297
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400189A RID: 6298
			private static readonly IntPtr NativeFieldInfoPtr__c_5__3;

			// Token: 0x0400189B RID: 6299
			private static readonly IntPtr NativeFieldInfoPtr__value_5__4;

			// Token: 0x0400189C RID: 6300
			private static readonly IntPtr NativeFieldInfoPtr__property_5__5;

			// Token: 0x0400189D RID: 6301
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x0400189E RID: 6302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400189F RID: 6303
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018A0 RID: 6304
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018A1 RID: 6305
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040018A2 RID: 6306
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040018A3 RID: 6307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x040018A4 RID: 6308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018A5 RID: 6309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018A6 RID: 6310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x040018A7 RID: 6311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
