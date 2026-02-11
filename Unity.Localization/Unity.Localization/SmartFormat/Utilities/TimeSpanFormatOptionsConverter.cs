using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	// Token: 0x02000040 RID: 64
	public static class TimeSpanFormatOptionsConverter : Object
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x000189F0 File Offset: 0x00016BF0
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanFormatOptionsConverter()
		{
			Il2CppClassPointerStore<TimeSpanFormatOptionsConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Utilities", "TimeSpanFormatOptionsConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter>.NativeClassPtr);
			TimeSpanFormatOptionsConverter.NativeFieldInfoPtr_parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter>.NativeClassPtr, "parser");
			TimeSpanFormatOptionsConverter.NativeMethodInfoPtr_Merge_Public_Static_TimeSpanFormatOptions_TimeSpanFormatOptions_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter>.NativeClassPtr, 100664048);
			TimeSpanFormatOptionsConverter.NativeMethodInfoPtr_Mask_Public_Static_TimeSpanFormatOptions_TimeSpanFormatOptions_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter>.NativeClassPtr, 100664049);
			TimeSpanFormatOptionsConverter.NativeMethodInfoPtr_AllFlags_Public_Static_IEnumerable_1_TimeSpanFormatOptions_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter>.NativeClassPtr, 100664050);
			TimeSpanFormatOptionsConverter.NativeMethodInfoPtr_Parse_Public_Static_TimeSpanFormatOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter>.NativeClassPtr, 100664051);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00018A84 File Offset: 0x00016C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1070606, RefRangeEnd = 1070608, XrefRangeStart = 1070599, XrefRangeEnd = 1070606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpanFormatOptions Merge(this TimeSpanFormatOptions left, TimeSpanFormatOptions right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter.NativeMethodInfoPtr_Merge_Public_Static_TimeSpanFormatOptions_TimeSpanFormatOptions_TimeSpanFormatOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00018AD0 File Offset: 0x00016CD0
		[CallerCount(0)]
		public unsafe static TimeSpanFormatOptions Mask(this TimeSpanFormatOptions timeSpanFormatOptions, TimeSpanFormatOptions mask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpanFormatOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter.NativeMethodInfoPtr_Mask_Public_Static_TimeSpanFormatOptions_TimeSpanFormatOptions_TimeSpanFormatOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00018B1C File Offset: 0x00016D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070608, XrefRangeEnd = 1070613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TimeSpanFormatOptions> AllFlags(this TimeSpanFormatOptions timeSpanFormatOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpanFormatOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter.NativeMethodInfoPtr_AllFlags_Public_Static_IEnumerable_1_TimeSpanFormatOptions_TimeSpanFormatOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TimeSpanFormatOptions>>(intPtr3) : null;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00018B5C File Offset: 0x00016D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1070742, RefRangeEnd = 1070743, XrefRangeStart = 1070613, XrefRangeEnd = 1070742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpanFormatOptions Parse(string formatOptionsString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(formatOptionsString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter.NativeMethodInfoPtr_Parse_Public_Static_TimeSpanFormatOptions_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000034F5 File Offset: 0x000016F5
		public TimeSpanFormatOptionsConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00018BA0 File Offset: 0x00016DA0
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000034FE File Offset: 0x000016FE
		public unsafe static Regex parser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeSpanFormatOptionsConverter.NativeFieldInfoPtr_parser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanFormatOptionsConverter.NativeFieldInfoPtr_parser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_parser;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Static_TimeSpanFormatOptions_TimeSpanFormatOptions_TimeSpanFormatOptions_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_Mask_Public_Static_TimeSpanFormatOptions_TimeSpanFormatOptions_TimeSpanFormatOptions_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_AllFlags_Public_Static_IEnumerable_1_TimeSpanFormatOptions_TimeSpanFormatOptions_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_TimeSpanFormatOptions_String_0;

		// Token: 0x0200013B RID: 315
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Utilities.TimeSpanFormatOptionsConverter+<AllFlags>d__3")]
		public sealed class _AllFlags_d__3 : Object
		{
			// Token: 0x06000DEE RID: 3566 RVA: 0x0003D2A8 File Offset: 0x0003B4A8
			// Note: this type is marked as 'beforefieldinit'.
			static _AllFlags_d__3()
			{
				Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter>.NativeClassPtr, "<AllFlags>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr);
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, "<>1__state");
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, "<>2__current");
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, "<>l__initialThreadId");
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr_timeSpanFormatOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, "timeSpanFormatOptions");
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___3__timeSpanFormatOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, "<>3__timeSpanFormatOptions");
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr__value_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, "<value>5__2");
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, 100664053);
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, 100664054);
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, 100664055);
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Localization_SmartFormat_Utilities_TimeSpanFormatOptions__get_Current_Private_Virtual_Final_New_get_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, 100664056);
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, 100664057);
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, 100664058);
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Localization_SmartFormat_Utilities_TimeSpanFormatOptions__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TimeSpanFormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, 100664059);
				TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr, 100664060);
			}

			// Token: 0x06000DEF RID: 3567 RVA: 0x0003D3EC File Offset: 0x0003B5EC
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286249, XrefRangeEnd = 286258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AllFlags_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanFormatOptionsConverter._AllFlags_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DF0 RID: 3568 RVA: 0x0003D434 File Offset: 0x0003B634
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DF1 RID: 3569 RVA: 0x0003D468 File Offset: 0x0003B668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070583, XrefRangeEnd = 1070584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0003D4A4 File Offset: 0x0003B6A4
			public unsafe TimeSpanFormatOptions System.Collections.Generic.IEnumerator<UnityEngine.Localization.SmartFormat.Utilities.TimeSpanFormatOptions>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Localization_SmartFormat_Utilities_TimeSpanFormatOptions__get_Current_Private_Virtual_Final_New_get_TimeSpanFormatOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000DF3 RID: 3571 RVA: 0x0003D4E0 File Offset: 0x0003B6E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070584, XrefRangeEnd = 1070589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0003D514 File Offset: 0x0003B714
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070589, XrefRangeEnd = 1070592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DF5 RID: 3573 RVA: 0x0003D554 File Offset: 0x0003B754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070592, XrefRangeEnd = 1070599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TimeSpanFormatOptions> System_Collections_Generic_IEnumerable_UnityEngine_Localization_SmartFormat_Utilities_TimeSpanFormatOptions__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Localization_SmartFormat_Utilities_TimeSpanFormatOptions__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TimeSpanFormatOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TimeSpanFormatOptions>>(intPtr3) : null;
			}

			// Token: 0x06000DF6 RID: 3574 RVA: 0x0003D594 File Offset: 0x0003B794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000DF7 RID: 3575 RVA: 0x00007C78 File Offset: 0x00005E78
			public _AllFlags_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003BA RID: 954
			// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0003D5D4 File Offset: 0x0003B7D4
			// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x00007C81 File Offset: 0x00005E81
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003BB RID: 955
			// (get) Token: 0x06000DFA RID: 3578 RVA: 0x0003D5FC File Offset: 0x0003B7FC
			// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00007C9C File Offset: 0x00005E9C
			public unsafe TimeSpanFormatOptions __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0003D624 File Offset: 0x0003B824
			// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00007CB7 File Offset: 0x00005EB7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x06000DFE RID: 3582 RVA: 0x0003D64C File Offset: 0x0003B84C
			// (set) Token: 0x06000DFF RID: 3583 RVA: 0x00007CD2 File Offset: 0x00005ED2
			public unsafe TimeSpanFormatOptions timeSpanFormatOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr_timeSpanFormatOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr_timeSpanFormatOptions)) = value;
				}
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06000E00 RID: 3584 RVA: 0x0003D674 File Offset: 0x0003B874
			// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00007CED File Offset: 0x00005EED
			public unsafe TimeSpanFormatOptions __3__timeSpanFormatOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___3__timeSpanFormatOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr___3__timeSpanFormatOptions)) = value;
				}
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0003D69C File Offset: 0x0003B89C
			// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00007D08 File Offset: 0x00005F08
			public unsafe uint _value_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr__value_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormatOptionsConverter._AllFlags_d__3.NativeFieldInfoPtr__value_5__2)) = value;
				}
			}

			// Token: 0x040009A1 RID: 2465
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009A2 RID: 2466
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009A3 RID: 2467
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040009A4 RID: 2468
			private static readonly IntPtr NativeFieldInfoPtr_timeSpanFormatOptions;

			// Token: 0x040009A5 RID: 2469
			private static readonly IntPtr NativeFieldInfoPtr___3__timeSpanFormatOptions;

			// Token: 0x040009A6 RID: 2470
			private static readonly IntPtr NativeFieldInfoPtr__value_5__2;

			// Token: 0x040009A7 RID: 2471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009A8 RID: 2472
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009A9 RID: 2473
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009AA RID: 2474
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Localization_SmartFormat_Utilities_TimeSpanFormatOptions__get_Current_Private_Virtual_Final_New_get_TimeSpanFormatOptions_0;

			// Token: 0x040009AB RID: 2475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009AC RID: 2476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009AD RID: 2477
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Localization_SmartFormat_Utilities_TimeSpanFormatOptions__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TimeSpanFormatOptions_0;

			// Token: 0x040009AE RID: 2478
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
