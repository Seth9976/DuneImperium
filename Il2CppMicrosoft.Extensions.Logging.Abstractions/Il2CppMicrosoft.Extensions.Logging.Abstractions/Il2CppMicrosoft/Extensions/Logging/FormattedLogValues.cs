using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200000F RID: 15
	public sealed class FormattedLogValues : ValueType
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00003724 File Offset: 0x00001924
		// Note: this type is marked as 'beforefieldinit'.
		static FormattedLogValues()
		{
			Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "FormattedLogValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr);
			FormattedLogValues.NativeFieldInfoPtr_s_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, "s_count");
			FormattedLogValues.NativeFieldInfoPtr_s_formatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, "s_formatters");
			FormattedLogValues.NativeFieldInfoPtr__formatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, "_formatter");
			FormattedLogValues.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, "_values");
			FormattedLogValues.NativeFieldInfoPtr__originalMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, "_originalMessage");
			FormattedLogValues.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, 100663334);
			FormattedLogValues.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_KeyValuePair_2_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, 100663335);
			FormattedLogValues.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, 100663336);
			FormattedLogValues.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, 100663337);
			FormattedLogValues.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, 100663338);
			FormattedLogValues.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, 100663339);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003830 File Offset: 0x00001A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264659, RefRangeEnd = 1264661, XrefRangeStart = 1264616, XrefRangeEnd = 1264659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormattedLogValues(string format, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000014 RID: 20
		public unsafe KeyValuePair<string, Object> this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1264682, RefRangeEnd = 1264683, XrefRangeStart = 1264661, XrefRangeEnd = 1264682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_KeyValuePair_2_String_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, Object>(intPtr);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000038EC File Offset: 0x00001AEC
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264683, XrefRangeEnd = 1264684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003930 File Offset: 0x00001B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264689, RefRangeEnd = 1264690, XrefRangeStart = 1264684, XrefRangeEnd = 1264689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<KeyValuePair<string, Object>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003974 File Offset: 0x00001B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264690, XrefRangeEnd = 1264691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000039B0 File Offset: 0x00001BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264691, XrefRangeEnd = 1264695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000022F2 File Offset: 0x000004F2
		public FormattedLogValues(string format, params Object[] values)
			: this(format, new Il2CppReferenceArray<Object>(values))
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002301 File Offset: 0x00000501
		public FormattedLogValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000230A File Offset: 0x0000050A
		public FormattedLogValues()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr))
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000039F4 File Offset: 0x00001BF4
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000231C File Offset: 0x0000051C
		public unsafe static int s_count
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FormattedLogValues.NativeFieldInfoPtr_s_count, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormattedLogValues.NativeFieldInfoPtr_s_count, (void*)(&value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00003A10 File Offset: 0x00001C10
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000232A File Offset: 0x0000052A
		public unsafe static ConcurrentDictionary<string, LogValuesFormatter> s_formatters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormattedLogValues.NativeFieldInfoPtr_s_formatters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, LogValuesFormatter>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormattedLogValues.NativeFieldInfoPtr_s_formatters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000233C File Offset: 0x0000053C
		public unsafe LogValuesFormatter _formatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues.NativeFieldInfoPtr__formatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogValuesFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues.NativeFieldInfoPtr__formatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003A68 File Offset: 0x00001C68
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000235B File Offset: 0x0000055B
		public unsafe Il2CppReferenceArray<Object> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003A98 File Offset: 0x00001C98
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000237A File Offset: 0x0000057A
		public unsafe string _originalMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues.NativeFieldInfoPtr__originalMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues.NativeFieldInfoPtr__originalMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_s_count;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_s_formatters;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr__formatter;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__originalMessage;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_KeyValuePair_2_String_Object_Int32_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200001C RID: 28
		[ObfuscatedName("Microsoft.Extensions.Logging.FormattedLogValues+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060000AE RID: 174 RVA: 0x00004AD4 File Offset: 0x00002CD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FormattedLogValues.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattedLogValues.__c>.NativeClassPtr);
				FormattedLogValues.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues.__c>.NativeClassPtr, "<>9");
				FormattedLogValues.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues.__c>.NativeClassPtr, "<>9__9_0");
				FormattedLogValues.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues.__c>.NativeClassPtr, 100663342);
				FormattedLogValues.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_LogValuesFormatter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues.__c>.NativeClassPtr, 100663343);
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00004B50 File Offset: 0x00002D50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattedLogValues.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x00004B8C File Offset: 0x00002D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264589, XrefRangeEnd = 1264598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogValuesFormatter __ctor_b__9_0(string f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_LogValuesFormatter_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogValuesFormatter>(intPtr3) : null;
				}
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00002647 File Offset: 0x00000847
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00004BDC File Offset: 0x00002DDC
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002650 File Offset: 0x00000850
			public unsafe static FormattedLogValues.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormattedLogValues.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormattedLogValues.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormattedLogValues.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x00004C04 File Offset: 0x00002E04
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002662 File Offset: 0x00000862
			public unsafe static Func<string, LogValuesFormatter> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormattedLogValues.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, LogValuesFormatter>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormattedLogValues.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400006B RID: 107
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400006C RID: 108
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400006D RID: 109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_0_Internal_LogValuesFormatter_String_0;
		}

		// Token: 0x0200001D RID: 29
		[ObfuscatedName("Microsoft.Extensions.Logging.FormattedLogValues+<GetEnumerator>d__14")]
		public sealed class _GetEnumerator_d__14 : Object
		{
			// Token: 0x060000B6 RID: 182 RVA: 0x00004C2C File Offset: 0x00002E2C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__14()
			{
				Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, "<GetEnumerator>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr);
				FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, "<>1__state");
				FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, "<>2__current");
				FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, "<>4__this");
				FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, "<i>5__2");
				FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, 100663344);
				FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, 100663345);
				FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, 100663346);
				FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, 100663347);
				FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, 100663348);
				FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr, 100663349);
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00004D20 File Offset: 0x00002F20
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattedLogValues._GetEnumerator_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00004D68 File Offset: 0x00002F68
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00004D9C File Offset: 0x00002F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264598, XrefRangeEnd = 1264608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000BA RID: 186 RVA: 0x00004DD8 File Offset: 0x00002FD8
			public unsafe KeyValuePair<string, Object> prop_KeyValuePair_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, Object>(intPtr);
				}
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00004E10 File Offset: 0x00003010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264608, XrefRangeEnd = 1264613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000BC RID: 188 RVA: 0x00004E44 File Offset: 0x00003044
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264613, XrefRangeEnd = 1264616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattedLogValues._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000BD RID: 189 RVA: 0x00002674 File Offset: 0x00000874
			public _GetEnumerator_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000BE RID: 190 RVA: 0x00004E84 File Offset: 0x00003084
			// (set) Token: 0x060000BF RID: 191 RVA: 0x0000267D File Offset: 0x0000087D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004EAC File Offset: 0x000030AC
			// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002698 File Offset: 0x00000898
			public KeyValuePair<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004EDC File Offset: 0x000030DC
			// (set) Token: 0x060000C3 RID: 195 RVA: 0x000026C6 File Offset: 0x000008C6
			public FormattedLogValues __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___4__this);
					return new FormattedLogValues(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FormattedLogValues>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004F0C File Offset: 0x0000310C
			// (set) Token: 0x060000C5 RID: 197 RVA: 0x000026F4 File Offset: 0x000008F4
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattedLogValues._GetEnumerator_d__14.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04000073 RID: 115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000076 RID: 118
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0;

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000078 RID: 120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
