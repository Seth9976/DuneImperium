using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	// Token: 0x02000043 RID: 67
	public static class TupleExtensions : Object
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x000193F0 File Offset: 0x000175F0
		// Note: this type is marked as 'beforefieldinit'.
		static TupleExtensions()
		{
			Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Utilities", "TupleExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr);
			TupleExtensions.NativeFieldInfoPtr_ValueTupleTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, "ValueTupleTypes");
			TupleExtensions.NativeMethodInfoPtr_IsValueTuple_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, 100664071);
			TupleExtensions.NativeMethodInfoPtr_IsValueTupleType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, 100664072);
			TupleExtensions.NativeMethodInfoPtr_GetValueTupleItemObjects_Public_Static_IEnumerable_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, 100664073);
			TupleExtensions.NativeMethodInfoPtr_GetValueTupleItemTypes_Public_Static_IEnumerable_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, 100664074);
			TupleExtensions.NativeMethodInfoPtr_GetValueTupleItemFields_Public_Static_List_1_FieldInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, 100664075);
			TupleExtensions.NativeMethodInfoPtr_GetValueTupleItemObjectsFlattened_Public_Static_IEnumerable_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, 100664076);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000194AC File Offset: 0x000176AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1071049, RefRangeEnd = 1071051, XrefRangeStart = 1071042, XrefRangeEnd = 1071049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueTuple(this Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.NativeMethodInfoPtr_IsValueTuple_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000194F0 File Offset: 0x000176F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071051, XrefRangeEnd = 1071054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueTupleType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.NativeMethodInfoPtr_IsValueTupleType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00019534 File Offset: 0x00017734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071054, XrefRangeEnd = 1071074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Object> GetValueTupleItemObjects(this Object tuple)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tuple);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.NativeMethodInfoPtr_GetValueTupleItemObjects_Public_Static_IEnumerable_1_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00019578 File Offset: 0x00017778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071074, XrefRangeEnd = 1071096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetValueTupleItemTypes(this Type tupleType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tupleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.NativeMethodInfoPtr_GetValueTupleItemTypes_Public_Static_IEnumerable_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000195BC File Offset: 0x000177BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1071121, RefRangeEnd = 1071124, XrefRangeStart = 1071096, XrefRangeEnd = 1071121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<FieldInfo> GetValueTupleItemFields(this Type tupleType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tupleType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.NativeMethodInfoPtr_GetValueTupleItemFields_Public_Static_List_1_FieldInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00019600 File Offset: 0x00017800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1071130, RefRangeEnd = 1071132, XrefRangeStart = 1071124, XrefRangeEnd = 1071130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Object> GetValueTupleItemObjectsFlattened(this Object tuple)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tuple);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.NativeMethodInfoPtr_GetValueTupleItemObjectsFlattened_Public_Static_IEnumerable_1_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000036D4 File Offset: 0x000018D4
		public TupleExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00019644 File Offset: 0x00017844
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000036DD File Offset: 0x000018DD
		public unsafe static HashSet<Type> ValueTupleTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TupleExtensions.NativeFieldInfoPtr_ValueTupleTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TupleExtensions.NativeFieldInfoPtr_ValueTupleTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_ValueTupleTypes;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_IsValueTuple_Public_Static_Boolean_Object_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_IsValueTupleType_Public_Static_Boolean_Type_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_GetValueTupleItemObjects_Public_Static_IEnumerable_1_Object_Object_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_GetValueTupleItemTypes_Public_Static_IEnumerable_1_Type_Type_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_GetValueTupleItemFields_Public_Static_List_1_FieldInfo_Type_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_GetValueTupleItemObjectsFlattened_Public_Static_IEnumerable_1_Object_Object_0;

		// Token: 0x0200013D RID: 317
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Utilities.TupleExtensions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000E0C RID: 3596 RVA: 0x0003D824 File Offset: 0x0003BA24
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TupleExtensions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleExtensions.__c>.NativeClassPtr);
				TupleExtensions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions.__c>.NativeClassPtr, "<>9");
				TupleExtensions.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions.__c>.NativeClassPtr, "<>9__4_0");
				TupleExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions.__c>.NativeClassPtr, 100664079);
				TupleExtensions.__c.NativeMethodInfoPtr__GetValueTupleItemTypes_b__4_0_Internal_Type_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions.__c>.NativeClassPtr, 100664080);
			}

			// Token: 0x06000E0D RID: 3597 RVA: 0x0003D8A0 File Offset: 0x0003BAA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TupleExtensions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E0E RID: 3598 RVA: 0x0003D8DC File Offset: 0x0003BADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type _GetValueTupleItemTypes_b__4_0(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.__c.NativeMethodInfoPtr__GetValueTupleItemTypes_b__4_0_Internal_Type_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06000E0F RID: 3599 RVA: 0x00007D50 File Offset: 0x00005F50
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003C4 RID: 964
			// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0003D92C File Offset: 0x0003BB2C
			// (set) Token: 0x06000E11 RID: 3601 RVA: 0x00007D59 File Offset: 0x00005F59
			public unsafe static TupleExtensions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TupleExtensions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TupleExtensions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TupleExtensions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003C5 RID: 965
			// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0003D954 File Offset: 0x0003BB54
			// (set) Token: 0x06000E13 RID: 3603 RVA: 0x00007D6B File Offset: 0x00005F6B
			public unsafe static Func<FieldInfo, Type> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TupleExtensions.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TupleExtensions.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009B3 RID: 2483
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009B4 RID: 2484
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040009B5 RID: 2485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009B6 RID: 2486
			private static readonly IntPtr NativeMethodInfoPtr__GetValueTupleItemTypes_b__4_0_Internal_Type_FieldInfo_0;
		}

		// Token: 0x0200013E RID: 318
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Utilities.TupleExtensions+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06000E14 RID: 3604 RVA: 0x0003D97C File Offset: 0x0003BB7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TupleExtensions.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleExtensions.__c__DisplayClass3_0>.NativeClassPtr);
				TupleExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_tuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions.__c__DisplayClass3_0>.NativeClassPtr, "tuple");
				TupleExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100664081);
				TupleExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__GetValueTupleItemObjects_b__0_Internal_Object_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100664082);
			}

			// Token: 0x06000E15 RID: 3605 RVA: 0x0003D9E4 File Offset: 0x0003BBE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TupleExtensions.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E16 RID: 3606 RVA: 0x0003DA20 File Offset: 0x0003BC20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070950, XrefRangeEnd = 1070951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetValueTupleItemObjects_b__0(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__GetValueTupleItemObjects_b__0_Internal_Object_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E17 RID: 3607 RVA: 0x00007D7D File Offset: 0x00005F7D
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003C6 RID: 966
			// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0003DA70 File Offset: 0x0003BC70
			// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00007D86 File Offset: 0x00005F86
			public unsafe Object tuple
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_tuple);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_tuple), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009B7 RID: 2487
			private static readonly IntPtr NativeFieldInfoPtr_tuple;

			// Token: 0x040009B8 RID: 2488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009B9 RID: 2489
			private static readonly IntPtr NativeMethodInfoPtr__GetValueTupleItemObjects_b__0_Internal_Object_FieldInfo_0;
		}

		// Token: 0x0200013F RID: 319
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Utilities.TupleExtensions+<GetValueTupleItemObjectsFlattened>d__6")]
		public sealed class _GetValueTupleItemObjectsFlattened_d__6 : Object
		{
			// Token: 0x06000E1A RID: 3610 RVA: 0x0003DAA0 File Offset: 0x0003BCA0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetValueTupleItemObjectsFlattened_d__6()
			{
				Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, "<GetValueTupleItemObjectsFlattened>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, "<>1__state");
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, "<>2__current");
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, "<>l__initialThreadId");
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr_tuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, "tuple");
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___3__tuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, "<>3__tuple");
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, "<>7__wrap1");
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, "<>7__wrap2");
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664083);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664084);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664085);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664086);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664087);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664088);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664089);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664090);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664091);
				TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr, 100664092);
			}

			// Token: 0x06000E1B RID: 3611 RVA: 0x0003DC20 File Offset: 0x0003BE20
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetValueTupleItemObjectsFlattened_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TupleExtensions._GetValueTupleItemObjectsFlattened_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E1C RID: 3612 RVA: 0x0003DC68 File Offset: 0x0003BE68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070951, XrefRangeEnd = 1070961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E1D RID: 3613 RVA: 0x0003DC9C File Offset: 0x0003BE9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070961, XrefRangeEnd = 1071023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E1E RID: 3614 RVA: 0x0003DCD8 File Offset: 0x0003BED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071023, XrefRangeEnd = 1071026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E1F RID: 3615 RVA: 0x0003DD0C File Offset: 0x0003BF0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071026, XrefRangeEnd = 1071029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0003DD40 File Offset: 0x0003BF40
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E21 RID: 3617 RVA: 0x0003DD80 File Offset: 0x0003BF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071029, XrefRangeEnd = 1071034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0003DDB4 File Offset: 0x0003BFB4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E23 RID: 3619 RVA: 0x0003DDF4 File Offset: 0x0003BFF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071034, XrefRangeEnd = 1071042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Object> System_Collections_Generic_IEnumerable_System_Object__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr3) : null;
			}

			// Token: 0x06000E24 RID: 3620 RVA: 0x0003DE34 File Offset: 0x0003C034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000E25 RID: 3621 RVA: 0x00007DA5 File Offset: 0x00005FA5
			public _GetValueTupleItemObjectsFlattened_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06000E26 RID: 3622 RVA: 0x0003DE74 File Offset: 0x0003C074
			// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00007DAE File Offset: 0x00005FAE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0003DE9C File Offset: 0x0003C09C
			// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00007DC9 File Offset: 0x00005FC9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0003DECC File Offset: 0x0003C0CC
			// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00007DE8 File Offset: 0x00005FE8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170003CA RID: 970
			// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0003DEF4 File Offset: 0x0003C0F4
			// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00007E03 File Offset: 0x00006003
			public unsafe Object tuple
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr_tuple);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr_tuple), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0003DF24 File Offset: 0x0003C124
			// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00007E22 File Offset: 0x00006022
			public unsafe Object __3__tuple
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___3__tuple);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___3__tuple), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0003DF54 File Offset: 0x0003C154
			// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00007E41 File Offset: 0x00006041
			public unsafe IEnumerator<Object> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0003DF84 File Offset: 0x0003C184
			// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00007E60 File Offset: 0x00006060
			public unsafe IEnumerator<Object> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleExtensions._GetValueTupleItemObjectsFlattened_d__6.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009BA RID: 2490
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009BB RID: 2491
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009BC RID: 2492
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040009BD RID: 2493
			private static readonly IntPtr NativeFieldInfoPtr_tuple;

			// Token: 0x040009BE RID: 2494
			private static readonly IntPtr NativeFieldInfoPtr___3__tuple;

			// Token: 0x040009BF RID: 2495
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040009C0 RID: 2496
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040009C1 RID: 2497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009C2 RID: 2498
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009C3 RID: 2499
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009C4 RID: 2500
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040009C5 RID: 2501
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040009C6 RID: 2502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009C7 RID: 2503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009C8 RID: 2504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009C9 RID: 2505
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0;

			// Token: 0x040009CA RID: 2506
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
