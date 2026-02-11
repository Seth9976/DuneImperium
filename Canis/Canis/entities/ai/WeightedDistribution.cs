using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x02000114 RID: 276
	public class WeightedDistribution<T> : Object
	{
		// Token: 0x06000C85 RID: 3205 RVA: 0x0004F590 File Offset: 0x0004D790
		// Note: this type is marked as 'beforefieldinit'.
		static WeightedDistribution()
		{
			Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "WeightedDistribution`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr);
			WeightedDistribution<T>.NativeFieldInfoPtr_weights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, "weights");
			WeightedDistribution<T>.NativeFieldInfoPtr_totalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, "totalWeight");
			WeightedDistribution<T>.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, 100666110);
			WeightedDistribution<T>.NativeMethodInfoPtr_Roll_Public_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, 100666111);
			WeightedDistribution<T>.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, 100666112);
			WeightedDistribution<T>.NativeMethodInfoPtr_Map_Public_WeightedDistribution_1_T_Func_2_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, 100666113);
			WeightedDistribution<T>.NativeMethodInfoPtr_Filtered_Public_WeightedDistribution_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, 100666114);
			WeightedDistribution<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, 100666115);
			WeightedDistribution<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, 100666116);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0004F6B0 File Offset: 0x0004D8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573491, XrefRangeEnd = 573494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeightedDistribution(Dictionary<T, int> weights)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(weights);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0004F6FC File Offset: 0x0004D8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573494, XrefRangeEnd = 573519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.NativeMethodInfoPtr_Roll_Public_T_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0004F748 File Offset: 0x0004D948
		[CallerCount(0)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0004F784 File Offset: 0x0004D984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573519, XrefRangeEnd = 573521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeightedDistribution<T> Map(Func<Dictionary<T, int>, Dictionary<T, int>> mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapping);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.NativeMethodInfoPtr_Map_Public_WeightedDistribution_1_T_Func_2_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeightedDistribution<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0004F7D4 File Offset: 0x0004D9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573521, XrefRangeEnd = 573550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeightedDistribution<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.NativeMethodInfoPtr_Filtered_Public_WeightedDistribution_1_T_Func_2_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeightedDistribution<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0004F824 File Offset: 0x0004DA24
		[CallerCount(0)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0004F864 File Offset: 0x0004DA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573550, XrefRangeEnd = 573555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<T, int>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<T, int>>>(intPtr3) : null;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00006698 File Offset: 0x00004898
		public WeightedDistribution(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0004F8A4 File Offset: 0x0004DAA4
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x000066A1 File Offset: 0x000048A1
		public unsafe Dictionary<T, int> weights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>.NativeFieldInfoPtr_weights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>.NativeFieldInfoPtr_weights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0004F8D4 File Offset: 0x0004DAD4
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x000066C0 File Offset: 0x000048C0
		public unsafe int totalWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>.NativeFieldInfoPtr_totalWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>.NativeFieldInfoPtr_totalWeight)) = value;
			}
		}

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeFieldInfoPtr_weights;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_totalWeight;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_T_Int32_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_T_Random_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_Map_Public_WeightedDistribution_1_T_Func_2_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_WeightedDistribution_1_T_Func_2_T_Boolean_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_T_Int32_0;

		// Token: 0x02000367 RID: 871
		[ObfuscatedName("Canis.entities.ai.WeightedDistribution`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060024E3 RID: 9443 RVA: 0x000A3B18 File Offset: 0x000A1D18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr);
				WeightedDistribution<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr, "<>9");
				WeightedDistribution<T>.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr, "<>9__6_1");
				WeightedDistribution<T>.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr, "<>9__6_2");
				WeightedDistribution<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr, 100666118);
				WeightedDistribution<T>.__c.NativeMethodInfoPtr__Filtered_b__6_1_Internal_T_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr, 100666119);
				WeightedDistribution<T>.__c.NativeMethodInfoPtr__Filtered_b__6_2_Internal_Int32_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr, 100666120);
			}

			// Token: 0x060024E4 RID: 9444 RVA: 0x000A3BF8 File Offset: 0x000A1DF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeightedDistribution<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024E5 RID: 9445 RVA: 0x000A3C34 File Offset: 0x000A1E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573398, XrefRangeEnd = 573400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Filtered_b__6_1(KeyValuePair<T, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.__c.NativeMethodInfoPtr__Filtered_b__6_1_Internal_T_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060024E6 RID: 9446 RVA: 0x000A3C84 File Offset: 0x000A1E84
			[CallerCount(0)]
			public unsafe int _Filtered_b__6_2(KeyValuePair<T, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.__c.NativeMethodInfoPtr__Filtered_b__6_2_Internal_Int32_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024E7 RID: 9447 RVA: 0x00011AF6 File Offset: 0x0000FCF6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000A3CD8 File Offset: 0x000A1ED8
			// (set) Token: 0x060024E9 RID: 9449 RVA: 0x00011AFF File Offset: 0x0000FCFF
			public unsafe static WeightedDistribution<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeightedDistribution<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeightedDistribution<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeightedDistribution<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x060024EA RID: 9450 RVA: 0x000A3D00 File Offset: 0x000A1F00
			// (set) Token: 0x060024EB RID: 9451 RVA: 0x00011B11 File Offset: 0x0000FD11
			public unsafe static Func<KeyValuePair<T, int>, T> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeightedDistribution<T>.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeightedDistribution<T>.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x060024EC RID: 9452 RVA: 0x000A3D28 File Offset: 0x000A1F28
			// (set) Token: 0x060024ED RID: 9453 RVA: 0x00011B23 File Offset: 0x0000FD23
			public unsafe static Func<KeyValuePair<T, int>, int> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeightedDistribution<T>.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeightedDistribution<T>.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001719 RID: 5913
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400171A RID: 5914
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x0400171B RID: 5915
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x0400171C RID: 5916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400171D RID: 5917
			private static readonly IntPtr NativeMethodInfoPtr__Filtered_b__6_1_Internal_T_KeyValuePair_2_T_Int32_0;

			// Token: 0x0400171E RID: 5918
			private static readonly IntPtr NativeMethodInfoPtr__Filtered_b__6_2_Internal_Int32_KeyValuePair_2_T_Int32_0;
		}

		// Token: 0x02000368 RID: 872
		[ObfuscatedName("Canis.entities.ai.WeightedDistribution`1+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060024EE RID: 9454 RVA: 0x000A3D50 File Offset: 0x000A1F50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WeightedDistribution<T>.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, "<>c__DisplayClass6_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightedDistribution<T>.__c__DisplayClass6_0>.NativeClassPtr);
				WeightedDistribution<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>.__c__DisplayClass6_0>.NativeClassPtr, "predicate");
				WeightedDistribution<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>.__c__DisplayClass6_0>.NativeClassPtr, 100666121);
				WeightedDistribution<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__Filtered_b__0_Internal_Boolean_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>.__c__DisplayClass6_0>.NativeClassPtr, 100666122);
			}

			// Token: 0x060024EF RID: 9455 RVA: 0x000A3DF4 File Offset: 0x000A1FF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeightedDistribution<T>.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024F0 RID: 9456 RVA: 0x000A3E30 File Offset: 0x000A2030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573400, XrefRangeEnd = 573401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Filtered_b__0(KeyValuePair<T, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__Filtered_b__0_Internal_Boolean_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024F1 RID: 9457 RVA: 0x00011B35 File Offset: 0x0000FD35
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000A3E84 File Offset: 0x000A2084
			// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00011B3E File Offset: 0x0000FD3E
			public unsafe Func<T, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400171F RID: 5919
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04001720 RID: 5920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001721 RID: 5921
			private static readonly IntPtr NativeMethodInfoPtr__Filtered_b__0_Internal_Boolean_KeyValuePair_2_T_Int32_0;
		}

		// Token: 0x02000369 RID: 873
		[ObfuscatedName("Canis.entities.ai.WeightedDistribution`1+<GetEnumerator>d__8")]
		public sealed class _GetEnumerator_d__8 : Object
		{
			// Token: 0x060024F4 RID: 9460 RVA: 0x000A3EB4 File Offset: 0x000A20B4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__8()
			{
				Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeightedDistribution<T>>.NativeClassPtr, "<GetEnumerator>d__8"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr);
				WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, "<>1__state");
				WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, "<>2__current");
				WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, "<>4__this");
				WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, "<>7__wrap1");
				WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, 100666123);
				WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, 100666124);
				WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, 100666125);
				WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, 100666126);
				WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, 100666127);
				WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, 100666128);
				WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr, 100666129);
			}

			// Token: 0x060024F5 RID: 9461 RVA: 0x000A3FF8 File Offset: 0x000A21F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573401, XrefRangeEnd = 573444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeightedDistribution<T>._GetEnumerator_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024F6 RID: 9462 RVA: 0x000A4040 File Offset: 0x000A2240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024F7 RID: 9463 RVA: 0x000A4074 File Offset: 0x000A2274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573444, XrefRangeEnd = 573475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060024F8 RID: 9464 RVA: 0x000A40B0 File Offset: 0x000A22B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573475, XrefRangeEnd = 573483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000A40E4 File Offset: 0x000A22E4
			public unsafe KeyValuePair<T, int> prop_KeyValuePair_2_T_Int32_0
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573483, XrefRangeEnd = 573487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<T, int>(intPtr);
				}
			}

			// Token: 0x060024FA RID: 9466 RVA: 0x000A411C File Offset: 0x000A231C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x060024FB RID: 9467 RVA: 0x000A4150 File Offset: 0x000A2350
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573487, XrefRangeEnd = 573491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedDistribution<T>._GetEnumerator_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024FC RID: 9468 RVA: 0x00011B5D File Offset: 0x0000FD5D
			public _GetEnumerator_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x060024FD RID: 9469 RVA: 0x000A4190 File Offset: 0x000A2390
			// (set) Token: 0x060024FE RID: 9470 RVA: 0x00011B66 File Offset: 0x0000FD66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x060024FF RID: 9471 RVA: 0x000A41B8 File Offset: 0x000A23B8
			// (set) Token: 0x06002500 RID: 9472 RVA: 0x00011B81 File Offset: 0x0000FD81
			public KeyValuePair<T, int> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<T, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<T, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<T, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x06002501 RID: 9473 RVA: 0x000A41E8 File Offset: 0x000A23E8
			// (set) Token: 0x06002502 RID: 9474 RVA: 0x00011BAF File Offset: 0x0000FDAF
			public unsafe WeightedDistribution<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeightedDistribution<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x06002503 RID: 9475 RVA: 0x000A4218 File Offset: 0x000A2418
			// (set) Token: 0x06002504 RID: 9476 RVA: 0x00011BCE File Offset: 0x0000FDCE
			public Dictionary<T, int>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<T, int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<T, int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedDistribution<T>._GetEnumerator_d__8.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<T, int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001722 RID: 5922
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001723 RID: 5923
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001724 RID: 5924
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001725 RID: 5925
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001726 RID: 5926
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001727 RID: 5927
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001728 RID: 5928
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001729 RID: 5929
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400172A RID: 5930
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_T_Int32_0;

			// Token: 0x0400172B RID: 5931
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400172C RID: 5932
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
