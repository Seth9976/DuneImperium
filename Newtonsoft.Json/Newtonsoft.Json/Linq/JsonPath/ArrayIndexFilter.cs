using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000CC RID: 204
	public class ArrayIndexFilter : PathFilter
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x000691B0 File Offset: 0x000673B0
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayIndexFilter()
		{
			Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "ArrayIndexFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr);
			ArrayIndexFilter.NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr, "<Index>k__BackingField");
			ArrayIndexFilter.NativeMethodInfoPtr_get_Index_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr, 100666867);
			ArrayIndexFilter.NativeMethodInfoPtr_set_Index_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr, 100666868);
			ArrayIndexFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr, 100666869);
			ArrayIndexFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr, 100666870);
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00069244 File Offset: 0x00067444
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x0006927C File Offset: 0x0006747C
		public unsafe Nullable<int> Index
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter.NativeMethodInfoPtr_get_Index_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter.NativeMethodInfoPtr_set_Index_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000692C4 File Offset: 0x000674C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762453, XrefRangeEnd = 762461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayIndexFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00069344 File Offset: 0x00067544
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayIndexFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00007D33 File Offset: 0x00005F33
		public ArrayIndexFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00069380 File Offset: 0x00067580
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00007D3C File Offset: 0x00005F3C
		public Nullable<int> _Index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter.NativeFieldInfoPtr__Index_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter.NativeFieldInfoPtr__Index_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeFieldInfoPtr__Index_k__BackingField;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_set_Index_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000219 RID: 537
		[ObfuscatedName("Newtonsoft.Json.Linq.JsonPath.ArrayIndexFilter+<ExecuteFilter>d__4")]
		public sealed class _ExecuteFilter_d__4 : Object
		{
			// Token: 0x0600215C RID: 8540 RVA: 0x000953CC File Offset: 0x000935CC
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteFilter_d__4()
			{
				Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayIndexFilter>.NativeClassPtr, "<ExecuteFilter>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "<>1__state");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "<>2__current");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "<>l__initialThreadId");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "current");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___3__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "<>3__current");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "<>4__this");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "settings");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___3__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "<>3__settings");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "<>7__wrap1");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, "<>7__wrap2");
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666871);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666872);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666873);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666874);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666875);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666876);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666877);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666878);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666879);
				ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr, 100666880);
			}

			// Token: 0x0600215D RID: 8541 RVA: 0x00095588 File Offset: 0x00093788
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteFilter_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayIndexFilter._ExecuteFilter_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600215E RID: 8542 RVA: 0x000955D0 File Offset: 0x000937D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762380, XrefRangeEnd = 762390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600215F RID: 8543 RVA: 0x00095604 File Offset: 0x00093804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762390, XrefRangeEnd = 762432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002160 RID: 8544 RVA: 0x00095640 File Offset: 0x00093840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762432, XrefRangeEnd = 762435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002161 RID: 8545 RVA: 0x00095674 File Offset: 0x00093874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762435, XrefRangeEnd = 762438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000982 RID: 2434
			// (get) Token: 0x06002162 RID: 8546 RVA: 0x000956A8 File Offset: 0x000938A8
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x06002163 RID: 8547 RVA: 0x000956E8 File Offset: 0x000938E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762438, XrefRangeEnd = 762443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000983 RID: 2435
			// (get) Token: 0x06002164 RID: 8548 RVA: 0x0009571C File Offset: 0x0009391C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002165 RID: 8549 RVA: 0x0009575C File Offset: 0x0009395C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762443, XrefRangeEnd = 762453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x06002166 RID: 8550 RVA: 0x0009579C File Offset: 0x0009399C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayIndexFilter._ExecuteFilter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002167 RID: 8551 RVA: 0x00010D69 File Offset: 0x0000EF69
			public _ExecuteFilter_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000978 RID: 2424
			// (get) Token: 0x06002168 RID: 8552 RVA: 0x000957DC File Offset: 0x000939DC
			// (set) Token: 0x06002169 RID: 8553 RVA: 0x00010D72 File Offset: 0x0000EF72
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000979 RID: 2425
			// (get) Token: 0x0600216A RID: 8554 RVA: 0x00095804 File Offset: 0x00093A04
			// (set) Token: 0x0600216B RID: 8555 RVA: 0x00010D8D File Offset: 0x0000EF8D
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x0600216C RID: 8556 RVA: 0x00095834 File Offset: 0x00093A34
			// (set) Token: 0x0600216D RID: 8557 RVA: 0x00010DAC File Offset: 0x0000EFAC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x0600216E RID: 8558 RVA: 0x0009585C File Offset: 0x00093A5C
			// (set) Token: 0x0600216F RID: 8559 RVA: 0x00010DC7 File Offset: 0x0000EFC7
			public unsafe IEnumerable<JToken> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x06002170 RID: 8560 RVA: 0x0009588C File Offset: 0x00093A8C
			// (set) Token: 0x06002171 RID: 8561 RVA: 0x00010DE6 File Offset: 0x0000EFE6
			public unsafe IEnumerable<JToken> __3__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___3__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___3__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x06002172 RID: 8562 RVA: 0x000958BC File Offset: 0x00093ABC
			// (set) Token: 0x06002173 RID: 8563 RVA: 0x00010E05 File Offset: 0x0000F005
			public unsafe ArrayIndexFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayIndexFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x06002174 RID: 8564 RVA: 0x000958EC File Offset: 0x00093AEC
			// (set) Token: 0x06002175 RID: 8565 RVA: 0x00010E24 File Offset: 0x0000F024
			public unsafe JsonSelectSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x06002176 RID: 8566 RVA: 0x0009591C File Offset: 0x00093B1C
			// (set) Token: 0x06002177 RID: 8567 RVA: 0x00010E43 File Offset: 0x0000F043
			public unsafe JsonSelectSettings __3__settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___3__settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___3__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000980 RID: 2432
			// (get) Token: 0x06002178 RID: 8568 RVA: 0x0009594C File Offset: 0x00093B4C
			// (set) Token: 0x06002179 RID: 8569 RVA: 0x00010E62 File Offset: 0x0000F062
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000981 RID: 2433
			// (get) Token: 0x0600217A RID: 8570 RVA: 0x0009597C File Offset: 0x00093B7C
			// (set) Token: 0x0600217B RID: 8571 RVA: 0x00010E81 File Offset: 0x0000F081
			public unsafe IEnumerator<JToken> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayIndexFilter._ExecuteFilter_d__4.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E7 RID: 6119
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017E8 RID: 6120
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017E9 RID: 6121
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040017EA RID: 6122
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040017EB RID: 6123
			private static readonly IntPtr NativeFieldInfoPtr___3__current;

			// Token: 0x040017EC RID: 6124
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017ED RID: 6125
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x040017EE RID: 6126
			private static readonly IntPtr NativeFieldInfoPtr___3__settings;

			// Token: 0x040017EF RID: 6127
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040017F0 RID: 6128
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040017F1 RID: 6129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017F2 RID: 6130
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017F3 RID: 6131
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017F4 RID: 6132
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040017F5 RID: 6133
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040017F6 RID: 6134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x040017F7 RID: 6135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017F8 RID: 6136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017F9 RID: 6137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x040017FA RID: 6138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
