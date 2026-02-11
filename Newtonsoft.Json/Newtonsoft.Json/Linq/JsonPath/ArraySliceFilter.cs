using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000CE RID: 206
	public class ArraySliceFilter : PathFilter
	{
		// Token: 0x060012FD RID: 4861 RVA: 0x00069518 File Offset: 0x00067718
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySliceFilter()
		{
			Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "ArraySliceFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr);
			ArraySliceFilter.NativeFieldInfoPtr__Start_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, "<Start>k__BackingField");
			ArraySliceFilter.NativeFieldInfoPtr__End_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, "<End>k__BackingField");
			ArraySliceFilter.NativeFieldInfoPtr__Step_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, "<Step>k__BackingField");
			ArraySliceFilter.NativeMethodInfoPtr_get_Start_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666893);
			ArraySliceFilter.NativeMethodInfoPtr_set_Start_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666894);
			ArraySliceFilter.NativeMethodInfoPtr_get_End_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666895);
			ArraySliceFilter.NativeMethodInfoPtr_set_End_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666896);
			ArraySliceFilter.NativeMethodInfoPtr_get_Step_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666897);
			ArraySliceFilter.NativeMethodInfoPtr_set_Step_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666898);
			ArraySliceFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666899);
			ArraySliceFilter.NativeMethodInfoPtr_IsValid_Private_Boolean_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666900);
			ArraySliceFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, 100666901);
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00069638 File Offset: 0x00067838
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00069670 File Offset: 0x00067870
		public unsafe Nullable<int> Start
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter.NativeMethodInfoPtr_get_Start_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter.NativeMethodInfoPtr_set_Start_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x000696B8 File Offset: 0x000678B8
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x000696F0 File Offset: 0x000678F0
		public unsafe Nullable<int> End
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter.NativeMethodInfoPtr_get_End_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter.NativeMethodInfoPtr_set_End_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00069738 File Offset: 0x00067938
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x00069770 File Offset: 0x00067970
		public unsafe Nullable<int> Step
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter.NativeMethodInfoPtr_get_Step_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter.NativeMethodInfoPtr_set_Step_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000697B8 File Offset: 0x000679B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762617, XrefRangeEnd = 762625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArraySliceFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00069838 File Offset: 0x00067A38
		[CallerCount(0)]
		public unsafe bool IsValid(int index, int stopIndex, bool positiveStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positiveStep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter.NativeMethodInfoPtr_IsValid_Private_Boolean_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000698A0 File Offset: 0x00067AA0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArraySliceFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00007D92 File Offset: 0x00005F92
		public ArraySliceFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x000698DC File Offset: 0x00067ADC
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x00007D9B File Offset: 0x00005F9B
		public Nullable<int> _Start_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter.NativeFieldInfoPtr__Start_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter.NativeFieldInfoPtr__Start_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0006990C File Offset: 0x00067B0C
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x00007DC9 File Offset: 0x00005FC9
		public Nullable<int> _End_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter.NativeFieldInfoPtr__End_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter.NativeFieldInfoPtr__End_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0006993C File Offset: 0x00067B3C
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x00007DF7 File Offset: 0x00005FF7
		public Nullable<int> _Step_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter.NativeFieldInfoPtr__Step_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter.NativeFieldInfoPtr__Step_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeFieldInfoPtr__Start_k__BackingField;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeFieldInfoPtr__End_k__BackingField;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeFieldInfoPtr__Step_k__BackingField;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_get_Start_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_set_Start_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_get_End_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_set_End_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_get_Step_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_set_Step_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Virtual_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Private_Boolean_Int32_Int32_Boolean_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021B RID: 539
		[ObfuscatedName("Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter+<ExecuteFilter>d__12")]
		public sealed class _ExecuteFilter_d__12 : Object
		{
			// Token: 0x0600219E RID: 8606 RVA: 0x00095FD0 File Offset: 0x000941D0
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteFilter_d__12()
			{
				Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArraySliceFilter>.NativeClassPtr, "<ExecuteFilter>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr);
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<>1__state");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<>2__current");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<>l__initialThreadId");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<>4__this");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "current");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___3__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<>3__current");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "settings");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___3__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<>3__settings");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<>7__wrap1");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__a_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<a>5__3");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__stepCount_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<stepCount>5__4");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__stopIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<stopIndex>5__5");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__positiveStep_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<positiveStep>5__6");
				ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__i_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, "<i>5__7");
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666902);
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666903);
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666904);
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666905);
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666906);
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666907);
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666908);
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666909);
				ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr, 100666910);
			}

			// Token: 0x0600219F RID: 8607 RVA: 0x000961C8 File Offset: 0x000943C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteFilter_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySliceFilter._ExecuteFilter_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021A0 RID: 8608 RVA: 0x00096210 File Offset: 0x00094410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762537, XrefRangeEnd = 762542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021A1 RID: 8609 RVA: 0x00096244 File Offset: 0x00094444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762542, XrefRangeEnd = 762599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060021A2 RID: 8610 RVA: 0x00096280 File Offset: 0x00094480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762599, XrefRangeEnd = 762602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700099F RID: 2463
			// (get) Token: 0x060021A3 RID: 8611 RVA: 0x000962B4 File Offset: 0x000944B4
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x060021A4 RID: 8612 RVA: 0x000962F4 File Offset: 0x000944F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762602, XrefRangeEnd = 762607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009A0 RID: 2464
			// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00096328 File Offset: 0x00094528
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021A6 RID: 8614 RVA: 0x00096368 File Offset: 0x00094568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762607, XrefRangeEnd = 762617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x060021A7 RID: 8615 RVA: 0x000963A8 File Offset: 0x000945A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceFilter._ExecuteFilter_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060021A8 RID: 8616 RVA: 0x00011005 File Offset: 0x0000F205
			public _ExecuteFilter_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000991 RID: 2449
			// (get) Token: 0x060021A9 RID: 8617 RVA: 0x000963E8 File Offset: 0x000945E8
			// (set) Token: 0x060021AA RID: 8618 RVA: 0x0001100E File Offset: 0x0000F20E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000992 RID: 2450
			// (get) Token: 0x060021AB RID: 8619 RVA: 0x00096410 File Offset: 0x00094610
			// (set) Token: 0x060021AC RID: 8620 RVA: 0x00011029 File Offset: 0x0000F229
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000993 RID: 2451
			// (get) Token: 0x060021AD RID: 8621 RVA: 0x00096440 File Offset: 0x00094640
			// (set) Token: 0x060021AE RID: 8622 RVA: 0x00011048 File Offset: 0x0000F248
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000994 RID: 2452
			// (get) Token: 0x060021AF RID: 8623 RVA: 0x00096468 File Offset: 0x00094668
			// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00011063 File Offset: 0x0000F263
			public unsafe ArraySliceFilter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArraySliceFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000995 RID: 2453
			// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00096498 File Offset: 0x00094698
			// (set) Token: 0x060021B2 RID: 8626 RVA: 0x00011082 File Offset: 0x0000F282
			public unsafe IEnumerable<JToken> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000996 RID: 2454
			// (get) Token: 0x060021B3 RID: 8627 RVA: 0x000964C8 File Offset: 0x000946C8
			// (set) Token: 0x060021B4 RID: 8628 RVA: 0x000110A1 File Offset: 0x0000F2A1
			public unsafe IEnumerable<JToken> __3__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___3__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___3__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000997 RID: 2455
			// (get) Token: 0x060021B5 RID: 8629 RVA: 0x000964F8 File Offset: 0x000946F8
			// (set) Token: 0x060021B6 RID: 8630 RVA: 0x000110C0 File Offset: 0x0000F2C0
			public unsafe JsonSelectSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000998 RID: 2456
			// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00096528 File Offset: 0x00094728
			// (set) Token: 0x060021B8 RID: 8632 RVA: 0x000110DF File Offset: 0x0000F2DF
			public unsafe JsonSelectSettings __3__settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___3__settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSelectSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___3__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000999 RID: 2457
			// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00096558 File Offset: 0x00094758
			// (set) Token: 0x060021BA RID: 8634 RVA: 0x000110FE File Offset: 0x0000F2FE
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099A RID: 2458
			// (get) Token: 0x060021BB RID: 8635 RVA: 0x00096588 File Offset: 0x00094788
			// (set) Token: 0x060021BC RID: 8636 RVA: 0x0001111D File Offset: 0x0000F31D
			public unsafe JArray _a_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__a_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__a_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099B RID: 2459
			// (get) Token: 0x060021BD RID: 8637 RVA: 0x000965B8 File Offset: 0x000947B8
			// (set) Token: 0x060021BE RID: 8638 RVA: 0x0001113C File Offset: 0x0000F33C
			public unsafe int _stepCount_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__stepCount_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__stepCount_5__4)) = value;
				}
			}

			// Token: 0x1700099C RID: 2460
			// (get) Token: 0x060021BF RID: 8639 RVA: 0x000965E0 File Offset: 0x000947E0
			// (set) Token: 0x060021C0 RID: 8640 RVA: 0x00011157 File Offset: 0x0000F357
			public unsafe int _stopIndex_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__stopIndex_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__stopIndex_5__5)) = value;
				}
			}

			// Token: 0x1700099D RID: 2461
			// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00096608 File Offset: 0x00094808
			// (set) Token: 0x060021C2 RID: 8642 RVA: 0x00011172 File Offset: 0x0000F372
			public unsafe bool _positiveStep_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__positiveStep_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__positiveStep_5__6)) = value;
				}
			}

			// Token: 0x1700099E RID: 2462
			// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00096630 File Offset: 0x00094830
			// (set) Token: 0x060021C4 RID: 8644 RVA: 0x0001118D File Offset: 0x0000F38D
			public unsafe int _i_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__i_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceFilter._ExecuteFilter_d__12.NativeFieldInfoPtr__i_5__7)) = value;
				}
			}

			// Token: 0x04001810 RID: 6160
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001811 RID: 6161
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001812 RID: 6162
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001813 RID: 6163
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001814 RID: 6164
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04001815 RID: 6165
			private static readonly IntPtr NativeFieldInfoPtr___3__current;

			// Token: 0x04001816 RID: 6166
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04001817 RID: 6167
			private static readonly IntPtr NativeFieldInfoPtr___3__settings;

			// Token: 0x04001818 RID: 6168
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001819 RID: 6169
			private static readonly IntPtr NativeFieldInfoPtr__a_5__3;

			// Token: 0x0400181A RID: 6170
			private static readonly IntPtr NativeFieldInfoPtr__stepCount_5__4;

			// Token: 0x0400181B RID: 6171
			private static readonly IntPtr NativeFieldInfoPtr__stopIndex_5__5;

			// Token: 0x0400181C RID: 6172
			private static readonly IntPtr NativeFieldInfoPtr__positiveStep_5__6;

			// Token: 0x0400181D RID: 6173
			private static readonly IntPtr NativeFieldInfoPtr__i_5__7;

			// Token: 0x0400181E RID: 6174
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400181F RID: 6175
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001820 RID: 6176
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001821 RID: 6177
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001822 RID: 6178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x04001823 RID: 6179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001824 RID: 6180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001825 RID: 6181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x04001826 RID: 6182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
