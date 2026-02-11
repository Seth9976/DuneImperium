using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000CF RID: 207
	public class FieldFilter : PathFilter
	{
		// Token: 0x0600130E RID: 4878 RVA: 0x0006996C File Offset: 0x00067B6C
		// Note: this type is marked as 'beforefieldinit'.
		static FieldFilter()
		{
			Il2CppClassPointerStore<FieldFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "FieldFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldFilter>.NativeClassPtr);
			FieldFilter.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter>.NativeClassPtr, "Name");
			FieldFilter.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter>.NativeClassPtr, 100666911);
			FieldFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter>.NativeClassPtr, 100666912);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000699D8 File Offset: 0x00067BD8
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldFilter(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldFilter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00069A24 File Offset: 0x00067C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762698, XrefRangeEnd = 762706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00007E25 File Offset: 0x00006025
		public FieldFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00069AA4 File Offset: 0x00067CA4
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00007E2E File Offset: 0x0000602E
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0;

		// Token: 0x0200021C RID: 540
		[ObfuscatedName("Newtonsoft.Json.Linq.JsonPath.FieldFilter+<ExecuteFilter>d__2")]
		public sealed class _ExecuteFilter_d__2 : Object
		{
			// Token: 0x060021C5 RID: 8645 RVA: 0x00096658 File Offset: 0x00094858
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteFilter_d__2()
			{
				Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FieldFilter>.NativeClassPtr, "<ExecuteFilter>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr);
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>1__state");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>2__current");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>l__initialThreadId");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "current");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__current");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>4__this");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "settings");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>3__settings");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap1");
				FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, "<>7__wrap2");
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666913);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666914);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666915);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666916);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666917);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666918);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666919);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666920);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666921);
				FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr, 100666922);
			}

			// Token: 0x060021C6 RID: 8646 RVA: 0x00096814 File Offset: 0x00094A14
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteFilter_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldFilter._ExecuteFilter_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021C7 RID: 8647 RVA: 0x0009685C File Offset: 0x00094A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762625, XrefRangeEnd = 762635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021C8 RID: 8648 RVA: 0x00096890 File Offset: 0x00094A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762635, XrefRangeEnd = 762677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060021C9 RID: 8649 RVA: 0x000968CC File Offset: 0x00094ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762677, XrefRangeEnd = 762680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021CA RID: 8650 RVA: 0x00096900 File Offset: 0x00094B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762680, XrefRangeEnd = 762683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009AB RID: 2475
			// (get) Token: 0x060021CB RID: 8651 RVA: 0x00096934 File Offset: 0x00094B34
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x060021CC RID: 8652 RVA: 0x00096974 File Offset: 0x00094B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762683, XrefRangeEnd = 762688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009AC RID: 2476
			// (get) Token: 0x060021CD RID: 8653 RVA: 0x000969A8 File Offset: 0x00094BA8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021CE RID: 8654 RVA: 0x000969E8 File Offset: 0x00094BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762688, XrefRangeEnd = 762698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x060021CF RID: 8655 RVA: 0x00096A28 File Offset: 0x00094C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldFilter._ExecuteFilter_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060021D0 RID: 8656 RVA: 0x000111A8 File Offset: 0x0000F3A8
			public _ExecuteFilter_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A1 RID: 2465
			// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00096A68 File Offset: 0x00094C68
			// (set) Token: 0x060021D2 RID: 8658 RVA: 0x000111B1 File Offset: 0x0000F3B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009A2 RID: 2466
			// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00096A90 File Offset: 0x00094C90
			// (set) Token: 0x060021D4 RID: 8660 RVA: 0x000111CC File Offset: 0x0000F3CC
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A3 RID: 2467
			// (get) Token: 0x060021D5 RID: 8661 RVA: 0x00096AC0 File Offset: 0x00094CC0
			// (set) Token: 0x060021D6 RID: 8662 RVA: 0x000111EB File Offset: 0x0000F3EB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170009A4 RID: 2468
			// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00096AE8 File Offset: 0x00094CE8
			// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00011206 File Offset: 0x0000F406
			public unsafe IEnumerable<JToken> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A5 RID: 2469
			// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00096B18 File Offset: 0x00094D18
			// (set) Token: 0x060021DA RID: 8666 RVA: 0x00011225 File Offset: 0x0000F425
			public unsafe IEnumerable<JToken> __3__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A6 RID: 2470
			// (get) Token: 0x060021DB RID: 8667 RVA: 0x00096B48 File Offset: 0x00094D48
			// (set) Token: 0x060021DC RID: 8668 RVA: 0x00011244 File Offset: 0x0000F444
			public unsafe FieldFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A7 RID: 2471
			// (get) Token: 0x060021DD RID: 8669 RVA: 0x00096B78 File Offset: 0x00094D78
			// (set) Token: 0x060021DE RID: 8670 RVA: 0x00011263 File Offset: 0x0000F463
			public unsafe JsonSelectSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A8 RID: 2472
			// (get) Token: 0x060021DF RID: 8671 RVA: 0x00096BA8 File Offset: 0x00094DA8
			// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00011282 File Offset: 0x0000F482
			public unsafe JsonSelectSettings __3__settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___3__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A9 RID: 2473
			// (get) Token: 0x060021E1 RID: 8673 RVA: 0x00096BD8 File Offset: 0x00094DD8
			// (set) Token: 0x060021E2 RID: 8674 RVA: 0x000112A1 File Offset: 0x0000F4A1
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AA RID: 2474
			// (get) Token: 0x060021E3 RID: 8675 RVA: 0x00096C08 File Offset: 0x00094E08
			// (set) Token: 0x060021E4 RID: 8676 RVA: 0x000112C0 File Offset: 0x0000F4C0
			public unsafe IEnumerator<KeyValuePair<string, JToken>> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, JToken>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldFilter._ExecuteFilter_d__2.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001827 RID: 6183
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001828 RID: 6184
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001829 RID: 6185
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400182A RID: 6186
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x0400182B RID: 6187
			private static readonly IntPtr NativeFieldInfoPtr___3__current;

			// Token: 0x0400182C RID: 6188
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400182D RID: 6189
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x0400182E RID: 6190
			private static readonly IntPtr NativeFieldInfoPtr___3__settings;

			// Token: 0x0400182F RID: 6191
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001830 RID: 6192
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001831 RID: 6193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001832 RID: 6194
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001833 RID: 6195
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001834 RID: 6196
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001835 RID: 6197
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001836 RID: 6198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x04001837 RID: 6199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001838 RID: 6200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001839 RID: 6201
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x0400183A RID: 6202
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
