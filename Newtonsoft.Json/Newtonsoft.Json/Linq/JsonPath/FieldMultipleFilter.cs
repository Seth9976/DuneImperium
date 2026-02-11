using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D0 RID: 208
	public class FieldMultipleFilter : PathFilter
	{
		// Token: 0x06001314 RID: 4884 RVA: 0x00069ACC File Offset: 0x00067CCC
		// Note: this type is marked as 'beforefieldinit'.
		static FieldMultipleFilter()
		{
			Il2CppClassPointerStore<FieldMultipleFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "FieldMultipleFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldMultipleFilter>.NativeClassPtr);
			FieldMultipleFilter.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter>.NativeClassPtr, "Names");
			FieldMultipleFilter.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter>.NativeClassPtr, 100666923);
			FieldMultipleFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter>.NativeClassPtr, 100666924);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00069B38 File Offset: 0x00067D38
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldMultipleFilter(List<string> names)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMultipleFilter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00069B84 File Offset: 0x00067D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762786, XrefRangeEnd = 762794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldMultipleFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00007E4D File Offset: 0x0000604D
		public FieldMultipleFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00069C04 File Offset: 0x00067E04
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00007E56 File Offset: 0x00006056
		public unsafe List<string> Names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter.NativeFieldInfoPtr_Names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter.NativeFieldInfoPtr_Names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeFieldInfoPtr_Names;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0;

		// Token: 0x0200021D RID: 541
		[ObfuscatedName("Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060021E5 RID: 8677 RVA: 0x00096C38 File Offset: 0x00094E38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FieldMultipleFilter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FieldMultipleFilter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldMultipleFilter.__c>.NativeClassPtr);
				FieldMultipleFilter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter.__c>.NativeClassPtr, "<>9");
				FieldMultipleFilter.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter.__c>.NativeClassPtr, "<>9__2_0");
				FieldMultipleFilter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter.__c>.NativeClassPtr, 100666926);
				FieldMultipleFilter.__c.NativeMethodInfoPtr__ExecuteFilter_b__2_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter.__c>.NativeClassPtr, 100666927);
			}

			// Token: 0x060021E6 RID: 8678 RVA: 0x00096CB4 File Offset: 0x00094EB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMultipleFilter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E7 RID: 8679 RVA: 0x00096CF0 File Offset: 0x00094EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762706, XrefRangeEnd = 762709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ExecuteFilter_b__2_0(string n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter.__c.NativeMethodInfoPtr__ExecuteFilter_b__2_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060021E8 RID: 8680 RVA: 0x000112DF File Offset: 0x0000F4DF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009AD RID: 2477
			// (get) Token: 0x060021E9 RID: 8681 RVA: 0x00096D38 File Offset: 0x00094F38
			// (set) Token: 0x060021EA RID: 8682 RVA: 0x000112E8 File Offset: 0x0000F4E8
			public unsafe static FieldMultipleFilter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FieldMultipleFilter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldMultipleFilter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FieldMultipleFilter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AE RID: 2478
			// (get) Token: 0x060021EB RID: 8683 RVA: 0x00096D60 File Offset: 0x00094F60
			// (set) Token: 0x060021EC RID: 8684 RVA: 0x000112FA File Offset: 0x0000F4FA
			public unsafe static Func<string, string> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FieldMultipleFilter.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FieldMultipleFilter.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400183B RID: 6203
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400183C RID: 6204
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400183D RID: 6205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400183E RID: 6206
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteFilter_b__2_0_Internal_String_String_0;
		}

		// Token: 0x0200021E RID: 542
		[ObfuscatedName("Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter+<ExecuteFilter>d__2")]
		public sealed class _ExecuteFilter_d__2 : Object
		{
			// Token: 0x060021ED RID: 8685 RVA: 0x00096D88 File Offset: 0x00094F88
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteFilter_d__2()
			{
				Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FieldMultipleFilter>.NativeClassPtr, "<ExecuteFilter>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>1__state");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>2__current");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>l__initialThreadId");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "current");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__current");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>4__this");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "settings");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__settings");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap1");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__o_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<o>5__3");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap3");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__name_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, "<name>5__5");
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666928);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666929);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666930);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666931);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666932);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666933);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666934);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666935);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666936);
				FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666937);
			}

			// Token: 0x060021EE RID: 8686 RVA: 0x00096F6C File Offset: 0x0009516C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteFilter_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMultipleFilter._ExecuteFilter_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021EF RID: 8687 RVA: 0x00096FB4 File Offset: 0x000951B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762709, XrefRangeEnd = 762722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021F0 RID: 8688 RVA: 0x00096FE8 File Offset: 0x000951E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762722, XrefRangeEnd = 762765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060021F1 RID: 8689 RVA: 0x00097024 File Offset: 0x00095224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762765, XrefRangeEnd = 762768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021F2 RID: 8690 RVA: 0x00097058 File Offset: 0x00095258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762768, XrefRangeEnd = 762771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009BB RID: 2491
			// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0009708C File Offset: 0x0009528C
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x060021F4 RID: 8692 RVA: 0x000970CC File Offset: 0x000952CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762771, XrefRangeEnd = 762776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009BC RID: 2492
			// (get) Token: 0x060021F5 RID: 8693 RVA: 0x00097100 File Offset: 0x00095300
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021F6 RID: 8694 RVA: 0x00097140 File Offset: 0x00095340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762776, XrefRangeEnd = 762786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x060021F7 RID: 8695 RVA: 0x00097180 File Offset: 0x00095380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMultipleFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060021F8 RID: 8696 RVA: 0x0001130C File Offset: 0x0000F50C
			public _ExecuteFilter_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009AF RID: 2479
			// (get) Token: 0x060021F9 RID: 8697 RVA: 0x000971C0 File Offset: 0x000953C0
			// (set) Token: 0x060021FA RID: 8698 RVA: 0x00011315 File Offset: 0x0000F515
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009B0 RID: 2480
			// (get) Token: 0x060021FB RID: 8699 RVA: 0x000971E8 File Offset: 0x000953E8
			// (set) Token: 0x060021FC RID: 8700 RVA: 0x00011330 File Offset: 0x0000F530
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B1 RID: 2481
			// (get) Token: 0x060021FD RID: 8701 RVA: 0x00097218 File Offset: 0x00095418
			// (set) Token: 0x060021FE RID: 8702 RVA: 0x0001134F File Offset: 0x0000F54F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170009B2 RID: 2482
			// (get) Token: 0x060021FF RID: 8703 RVA: 0x00097240 File Offset: 0x00095440
			// (set) Token: 0x06002200 RID: 8704 RVA: 0x0001136A File Offset: 0x0000F56A
			public unsafe IEnumerable<JToken> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B3 RID: 2483
			// (get) Token: 0x06002201 RID: 8705 RVA: 0x00097270 File Offset: 0x00095470
			// (set) Token: 0x06002202 RID: 8706 RVA: 0x00011389 File Offset: 0x0000F589
			public unsafe IEnumerable<JToken> __3__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x06002203 RID: 8707 RVA: 0x000972A0 File Offset: 0x000954A0
			// (set) Token: 0x06002204 RID: 8708 RVA: 0x000113A8 File Offset: 0x0000F5A8
			public unsafe FieldMultipleFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldMultipleFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x06002205 RID: 8709 RVA: 0x000972D0 File Offset: 0x000954D0
			// (set) Token: 0x06002206 RID: 8710 RVA: 0x000113C7 File Offset: 0x0000F5C7
			public unsafe JsonSelectSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B6 RID: 2486
			// (get) Token: 0x06002207 RID: 8711 RVA: 0x00097300 File Offset: 0x00095500
			// (set) Token: 0x06002208 RID: 8712 RVA: 0x000113E6 File Offset: 0x0000F5E6
			public unsafe JsonSelectSettings __3__settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B7 RID: 2487
			// (get) Token: 0x06002209 RID: 8713 RVA: 0x00097330 File Offset: 0x00095530
			// (set) Token: 0x0600220A RID: 8714 RVA: 0x00011405 File Offset: 0x0000F605
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B8 RID: 2488
			// (get) Token: 0x0600220B RID: 8715 RVA: 0x00097360 File Offset: 0x00095560
			// (set) Token: 0x0600220C RID: 8716 RVA: 0x00011424 File Offset: 0x0000F624
			public unsafe JObject _o_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__o_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__o_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B9 RID: 2489
			// (get) Token: 0x0600220D RID: 8717 RVA: 0x00097390 File Offset: 0x00095590
			// (set) Token: 0x0600220E RID: 8718 RVA: 0x00011443 File Offset: 0x0000F643
			public List<string>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap3);
					return new List<string>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<string>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<string>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170009BA RID: 2490
			// (get) Token: 0x0600220F RID: 8719 RVA: 0x000973C0 File Offset: 0x000955C0
			// (set) Token: 0x06002210 RID: 8720 RVA: 0x00011471 File Offset: 0x0000F671
			public unsafe string _name_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__name_5__5);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMultipleFilter._ExecuteFilter_d__2.NativeFieldInfoPtr__name_5__5), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400183F RID: 6207
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001840 RID: 6208
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001841 RID: 6209
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001842 RID: 6210
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04001843 RID: 6211
			private static readonly IntPtr NativeFieldInfoPtr___3__current;

			// Token: 0x04001844 RID: 6212
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001845 RID: 6213
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04001846 RID: 6214
			private static readonly IntPtr NativeFieldInfoPtr___3__settings;

			// Token: 0x04001847 RID: 6215
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001848 RID: 6216
			private static readonly IntPtr NativeFieldInfoPtr__o_5__3;

			// Token: 0x04001849 RID: 6217
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400184A RID: 6218
			private static readonly IntPtr NativeFieldInfoPtr__name_5__5;

			// Token: 0x0400184B RID: 6219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400184C RID: 6220
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400184D RID: 6221
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400184E RID: 6222
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400184F RID: 6223
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001850 RID: 6224
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x04001851 RID: 6225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001852 RID: 6226
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001853 RID: 6227
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x04001854 RID: 6228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
