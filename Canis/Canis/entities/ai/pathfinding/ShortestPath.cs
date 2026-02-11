using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.entities.ai.pathfinding
{
	// Token: 0x02000116 RID: 278
	public static class ShortestPath : Object
	{
		// Token: 0x06000C97 RID: 3223 RVA: 0x0004FA48 File Offset: 0x0004DC48
		// Note: this type is marked as 'beforefieldinit'.
		static ShortestPath()
		{
			Il2CppClassPointerStore<ShortestPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai.pathfinding", "ShortestPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr);
			ShortestPath.NativeMethodInfoPtr_Find_Public_Static_Path_1_T_Node_1_T_Node_1_T_IHasPathCostFunctions_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, 100666161);
			ShortestPath.NativeMethodInfoPtr_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_NeighborFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, 100666162);
			ShortestPath.NativeMethodInfoPtr_Method_Internal_Static_Double_Node_1_T_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, 100666163);
			ShortestPath.NativeMethodInfoPtr_Method_Internal_Static_Double_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, 100666164);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0004FAC8 File Offset: 0x0004DCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574067, XrefRangeEnd = 574174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShortestPath.Path<T> Find<T>(ShortestPath.Node<T> origin, ShortestPath.Node<T> destination, ShortestPath.IHasPathCostFunctions<T> hasPathCostFunctions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(origin));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hasPathCostFunctions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.MethodInfoStoreGeneric_Find_Public_Static_Path_1_T_Node_1_T_Node_1_T_IHasPathCostFunctions_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShortestPath.Path<T>>(intPtr3) : null;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0004FB3C File Offset: 0x0004DD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574174, XrefRangeEnd = 574219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<ShortestPath.Node<T>> ConstructGraph<T>(IEnumerable<T> elements, ShortestPath.NeighborFunction<T> neighborFunc) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neighborFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.MethodInfoStoreGeneric_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_NeighborFunction_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<ShortestPath.Node<T>>(intPtr);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0004FB8C File Offset: 0x0004DD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574219, XrefRangeEnd = 574232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Method_Internal_Static_Double_Node_1_T_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0<T>(ShortestPath.Node<T> o, ShortestPath.Node<T> d, ref ShortestPath.__c__DisplayClass4_0<T> A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(o));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(d));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.MethodInfoStoreGeneric_Method_Internal_Static_Double_Node_1_T_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0004FBFC File Offset: 0x0004DDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574232, XrefRangeEnd = 574238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Method_Internal_Static_Double_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0<T>(ShortestPath.Node<T> node, ref ShortestPath.__c__DisplayClass4_0<T> A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(node));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.MethodInfoStoreGeneric_Method_Internal_Static_Double_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000066E4 File Offset: 0x000048E4
		public ShortestPath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Path_1_T_Node_1_T_Node_1_T_IHasPathCostFunctions_1_T_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_NeighborFunction_1_T_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Double_Node_1_T_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Double_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0;

		// Token: 0x02000372 RID: 882
		public class Path<T> : Object
		{
			// Token: 0x0600253B RID: 9531 RVA: 0x000A5050 File Offset: 0x000A3250
			// Note: this type is marked as 'beforefieldinit'.
			static Path()
			{
				Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, "Path`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr);
				ShortestPath.Path<T>.NativeFieldInfoPtr_steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, "steps");
				ShortestPath.Path<T>.NativeFieldInfoPtr_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, "Cost");
				ShortestPath.Path<T>.NativeMethodInfoPtr_get_Steps_Public_get_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, 100666165);
				ShortestPath.Path<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, 100666166);
				ShortestPath.Path<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Node_1_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, 100666167);
				ShortestPath.Path<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, 100666168);
				ShortestPath.Path<T>.NativeMethodInfoPtr_get_Start_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, 100666169);
				ShortestPath.Path<T>.NativeMethodInfoPtr_get_First_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, 100666170);
				ShortestPath.Path<T>.NativeMethodInfoPtr_get_Goal_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr, 100666171);
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x0600253C RID: 9532 RVA: 0x000A516C File Offset: 0x000A336C
			public unsafe IReadOnlyList<T> Steps
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Path<T>.NativeMethodInfoPtr_get_Steps_Public_get_IReadOnlyList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr3) : null;
				}
			}

			// Token: 0x0600253D RID: 9533 RVA: 0x000A51AC File Offset: 0x000A33AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573901, XrefRangeEnd = 573903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Path(IEnumerable<T> steps, double cost)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(steps);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cost;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Path<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600253E RID: 9534 RVA: 0x000A5208 File Offset: 0x000A3408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573903, XrefRangeEnd = 573931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Path(IEnumerable<ShortestPath.Node<T>> steps, double cost)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestPath.Path<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(steps);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cost;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Path<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Node_1_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600253F RID: 9535 RVA: 0x000A5264 File Offset: 0x000A3464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573931, XrefRangeEnd = 573961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShortestPath.Path<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x1700092F RID: 2351
			// (get) Token: 0x06002540 RID: 9536 RVA: 0x000A52A8 File Offset: 0x000A34A8
			public unsafe T Start
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573961, XrefRangeEnd = 573963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Path<T>.NativeMethodInfoPtr_get_Start_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x17000930 RID: 2352
			// (get) Token: 0x06002541 RID: 9537 RVA: 0x000A52E4 File Offset: 0x000A34E4
			public unsafe T First
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573963, XrefRangeEnd = 573967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Path<T>.NativeMethodInfoPtr_get_First_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x17000931 RID: 2353
			// (get) Token: 0x06002542 RID: 9538 RVA: 0x000A5320 File Offset: 0x000A3520
			public unsafe T Goal
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573967, XrefRangeEnd = 573969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Path<T>.NativeMethodInfoPtr_get_Goal_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002543 RID: 9539 RVA: 0x00011D36 File Offset: 0x0000FF36
			public Path(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x06002544 RID: 9540 RVA: 0x000A535C File Offset: 0x000A355C
			// (set) Token: 0x06002545 RID: 9541 RVA: 0x00011D3F File Offset: 0x0000FF3F
			public unsafe List<T> steps
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Path<T>.NativeFieldInfoPtr_steps);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Path<T>.NativeFieldInfoPtr_steps), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x06002546 RID: 9542 RVA: 0x000A538C File Offset: 0x000A358C
			// (set) Token: 0x06002547 RID: 9543 RVA: 0x00011D5E File Offset: 0x0000FF5E
			public unsafe double Cost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Path<T>.NativeFieldInfoPtr_Cost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Path<T>.NativeFieldInfoPtr_Cost)) = value;
				}
			}

			// Token: 0x0400174B RID: 5963
			private static readonly IntPtr NativeFieldInfoPtr_steps;

			// Token: 0x0400174C RID: 5964
			private static readonly IntPtr NativeFieldInfoPtr_Cost;

			// Token: 0x0400174D RID: 5965
			private static readonly IntPtr NativeMethodInfoPtr_get_Steps_Public_get_IReadOnlyList_1_T_0;

			// Token: 0x0400174E RID: 5966
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_Double_0;

			// Token: 0x0400174F RID: 5967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Node_1_T_Double_0;

			// Token: 0x04001750 RID: 5968
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04001751 RID: 5969
			private static readonly IntPtr NativeMethodInfoPtr_get_Start_Public_get_T_0;

			// Token: 0x04001752 RID: 5970
			private static readonly IntPtr NativeMethodInfoPtr_get_First_Public_get_T_0;

			// Token: 0x04001753 RID: 5971
			private static readonly IntPtr NativeMethodInfoPtr_get_Goal_Public_get_T_0;
		}

		// Token: 0x02000373 RID: 883
		public sealed class HeuristicFunction<T> : MulticastDelegate
		{
			// Token: 0x06002548 RID: 9544 RVA: 0x000A53B4 File Offset: 0x000A35B4
			// Note: this type is marked as 'beforefieldinit'.
			static HeuristicFunction()
			{
				Il2CppClassPointerStore<ShortestPath.HeuristicFunction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, "HeuristicFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ShortestPath.HeuristicFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.HeuristicFunction<T>>.NativeClassPtr, 100666172);
				ShortestPath.HeuristicFunction<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Double_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.HeuristicFunction<T>>.NativeClassPtr, 100666173);
				ShortestPath.HeuristicFunction<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.HeuristicFunction<T>>.NativeClassPtr, 100666174);
				ShortestPath.HeuristicFunction<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Double_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.HeuristicFunction<T>>.NativeClassPtr, 100666175);
			}

			// Token: 0x06002549 RID: 9545 RVA: 0x000A5460 File Offset: 0x000A3660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573969, XrefRangeEnd = 573978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HeuristicFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestPath.HeuristicFunction<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.HeuristicFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600254A RID: 9546 RVA: 0x000A54BC File Offset: 0x000A36BC
			[CallerCount(0)]
			public unsafe double Invoke(T origin)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = origin;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref origin;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortestPath.HeuristicFunction<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Double_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600254B RID: 9547 RVA: 0x000A5540 File Offset: 0x000A3740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573978, XrefRangeEnd = 573982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T origin, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = origin;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref origin;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortestPath.HeuristicFunction<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600254C RID: 9548 RVA: 0x000A55EC File Offset: 0x000A37EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.HeuristicFunction<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Double_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600254D RID: 9549 RVA: 0x00011D79 File Offset: 0x0000FF79
			public HeuristicFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600254E RID: 9550 RVA: 0x00011D82 File Offset: 0x0000FF82
			public static implicit operator ShortestPath.HeuristicFunction<T>(Func<T, double> A_0)
			{
				return DelegateSupport.ConvertDelegate<ShortestPath.HeuristicFunction<T>>(A_0);
			}

			// Token: 0x0600254F RID: 9551 RVA: 0x00011D8A File Offset: 0x0000FF8A
			public static ShortestPath.HeuristicFunction<T>operator +(ShortestPath.HeuristicFunction<T> A_0, ShortestPath.HeuristicFunction<T> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ShortestPath.HeuristicFunction<T>>();
			}

			// Token: 0x06002550 RID: 9552 RVA: 0x00011D98 File Offset: 0x0000FF98
			public static ShortestPath.HeuristicFunction<T>operator -(ShortestPath.HeuristicFunction<T> A_0, ShortestPath.HeuristicFunction<T> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ShortestPath.HeuristicFunction<T>>();
				}
				return delegate2;
			}

			// Token: 0x04001754 RID: 5972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001755 RID: 5973
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Double_T_0;

			// Token: 0x04001756 RID: 5974
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x04001757 RID: 5975
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Double_IAsyncResult_0;
		}

		// Token: 0x02000374 RID: 884
		public class IHasPathCostFunctions<T> : Il2CppObjectBase
		{
			// Token: 0x06002551 RID: 9553 RVA: 0x000A563C File Offset: 0x000A383C
			// Note: this type is marked as 'beforefieldinit'.
			static IHasPathCostFunctions()
			{
				Il2CppClassPointerStore<ShortestPath.IHasPathCostFunctions<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, "IHasPathCostFunctions`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ShortestPath.IHasPathCostFunctions<T>.NativeMethodInfoPtr_MakeHeuristicForDestination_Public_Abstract_Virtual_New_HeuristicFunction_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.IHasPathCostFunctions<T>>.NativeClassPtr, 100666176);
				ShortestPath.IHasPathCostFunctions<T>.NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_Double_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.IHasPathCostFunctions<T>>.NativeClassPtr, 100666177);
			}

			// Token: 0x06002552 RID: 9554 RVA: 0x000A56C0 File Offset: 0x000A38C0
			[CallerCount(0)]
			public unsafe virtual ShortestPath.HeuristicFunction<T> MakeHeuristicForDestination(T destination)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = destination;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref destination;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShortestPath.IHasPathCostFunctions<T>.NativeMethodInfoPtr_MakeHeuristicForDestination_Public_Abstract_Virtual_New_HeuristicFunction_1_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<ShortestPath.HeuristicFunction<T>>(intPtr4) : null;
				}
			}

			// Token: 0x06002553 RID: 9555 RVA: 0x000A5754 File Offset: 0x000A3954
			[CallerCount(0)]
			public unsafe virtual double Cost(T origin, T destination)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = origin;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref origin;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t2 = destination;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref destination;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShortestPath.IHasPathCostFunctions<T>.NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_Double_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06002554 RID: 9556 RVA: 0x00011DA9 File Offset: 0x0000FFA9
			public IHasPathCostFunctions(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001758 RID: 5976
			private static readonly IntPtr NativeMethodInfoPtr_MakeHeuristicForDestination_Public_Abstract_Virtual_New_HeuristicFunction_1_T_T_0;

			// Token: 0x04001759 RID: 5977
			private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_Double_T_T_0;
		}

		// Token: 0x02000375 RID: 885
		public sealed class Node<T> : ValueType
		{
			// Token: 0x06002555 RID: 9557 RVA: 0x000A582C File Offset: 0x000A3A2C
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, "Node`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr);
				ShortestPath.Node<T>.NativeFieldInfoPtr_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, "Element");
				ShortestPath.Node<T>.NativeFieldInfoPtr_neighbors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, "neighbors");
				ShortestPath.Node<T>.NativeMethodInfoPtr_get_Neighbors_Public_get_IReadOnlyList_1_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, 100666178);
				ShortestPath.Node<T>.NativeMethodInfoPtr_GetAllNodes_Public_IEnumerable_1_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, 100666179);
				ShortestPath.Node<T>.NativeMethodInfoPtr_TryFindNode_Public_Boolean_T_byref_Nullable_1_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, 100666180);
				ShortestPath.Node<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, 100666181);
				ShortestPath.Node<T>.NativeMethodInfoPtr_AddNeighbor_Public_Void_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, 100666182);
				ShortestPath.Node<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, 100666183);
				ShortestPath.Node<T>.NativeMethodInfoPtr_Equals_Public_Boolean_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, 100666184);
				ShortestPath.Node<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, 100666185);
			}

			// Token: 0x17000934 RID: 2356
			// (get) Token: 0x06002556 RID: 9558 RVA: 0x000A595C File Offset: 0x000A3B5C
			public unsafe IReadOnlyList<ShortestPath.Node<T>> Neighbors
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>.NativeMethodInfoPtr_get_Neighbors_Public_get_IReadOnlyList_1_Node_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ShortestPath.Node<T>>>(intPtr3) : null;
				}
			}

			// Token: 0x06002557 RID: 9559 RVA: 0x000A59A0 File Offset: 0x000A3BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574020, XrefRangeEnd = 574026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ShortestPath.Node<T>> GetAllNodes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>.NativeMethodInfoPtr_GetAllNodes_Public_IEnumerable_1_Node_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ShortestPath.Node<T>>>(intPtr3) : null;
			}

			// Token: 0x06002558 RID: 9560 RVA: 0x000A59E4 File Offset: 0x000A3BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574026, XrefRangeEnd = 574043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryFindNode(T element, out Nullable<ShortestPath.Node<T>> foundNode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = element;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref element;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>.NativeMethodInfoPtr_TryFindNode_Public_Boolean_T_byref_Nullable_1_Node_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr2;
				foundNode = ((intPtr5 == 0) ? null : new Nullable<ShortestPath.Node<T>>(intPtr5));
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06002559 RID: 9561 RVA: 0x000A5A90 File Offset: 0x000A3C90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 574052, RefRangeEnd = 574053, XrefRangeStart = 574043, XrefRangeEnd = 574052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(T element)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = element;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref element;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x0600255A RID: 9562 RVA: 0x000A5B18 File Offset: 0x000A3D18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 574055, RefRangeEnd = 574056, XrefRangeStart = 574053, XrefRangeEnd = 574055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddNeighbor(ShortestPath.Node<T> neighbor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(neighbor));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>.NativeMethodInfoPtr_AddNeighbor_Public_Void_Node_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600255B RID: 9563 RVA: 0x000A5B64 File Offset: 0x000A3D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574056, XrefRangeEnd = 574064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600255C RID: 9564 RVA: 0x000A5BB8 File Offset: 0x000A3DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574064, XrefRangeEnd = 574067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(ShortestPath.Node<T> other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>.NativeMethodInfoPtr_Equals_Public_Boolean_Node_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600255D RID: 9565 RVA: 0x000A5C10 File Offset: 0x000A3E10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600255E RID: 9566 RVA: 0x00011DB2 File Offset: 0x0000FFB2
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600255F RID: 9567 RVA: 0x00011DBB File Offset: 0x0000FFBB
			public Node()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000932 RID: 2354
			// (get) Token: 0x06002560 RID: 9568 RVA: 0x000A5C54 File Offset: 0x000A3E54
			// (set) Token: 0x06002561 RID: 9569 RVA: 0x000A5C7C File Offset: 0x000A3E7C
			public unsafe T Element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>.NativeFieldInfoPtr_Element);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>.NativeFieldInfoPtr_Element);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000933 RID: 2355
			// (get) Token: 0x06002562 RID: 9570 RVA: 0x000A5D24 File Offset: 0x000A3F24
			// (set) Token: 0x06002563 RID: 9571 RVA: 0x00011DCD File Offset: 0x0000FFCD
			public unsafe List<ShortestPath.Node<T>> neighbors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>.NativeFieldInfoPtr_neighbors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShortestPath.Node<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>.NativeFieldInfoPtr_neighbors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400175A RID: 5978
			private static readonly IntPtr NativeFieldInfoPtr_Element;

			// Token: 0x0400175B RID: 5979
			private static readonly IntPtr NativeFieldInfoPtr_neighbors;

			// Token: 0x0400175C RID: 5980
			private static readonly IntPtr NativeMethodInfoPtr_get_Neighbors_Public_get_IReadOnlyList_1_Node_1_T_0;

			// Token: 0x0400175D RID: 5981
			private static readonly IntPtr NativeMethodInfoPtr_GetAllNodes_Public_IEnumerable_1_Node_1_T_0;

			// Token: 0x0400175E RID: 5982
			private static readonly IntPtr NativeMethodInfoPtr_TryFindNode_Public_Boolean_T_byref_Nullable_1_Node_1_T_0;

			// Token: 0x0400175F RID: 5983
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

			// Token: 0x04001760 RID: 5984
			private static readonly IntPtr NativeMethodInfoPtr_AddNeighbor_Public_Void_Node_1_T_0;

			// Token: 0x04001761 RID: 5985
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04001762 RID: 5986
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Node_1_T_0;

			// Token: 0x04001763 RID: 5987
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x0200048E RID: 1166
			[ObfuscatedName("Canis.entities.ai.pathfinding.ShortestPath+Node`1+<GetAllNodes>d__4")]
			public sealed class _GetAllNodes_d__4 : Object
			{
				// Token: 0x0600350A RID: 13578 RVA: 0x000D6FE0 File Offset: 0x000D51E0
				// Note: this type is marked as 'beforefieldinit'.
				static _GetAllNodes_d__4()
				{
					Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, "<GetAllNodes>d__4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr);
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, "<>1__state");
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, "<>2__current");
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, "<>l__initialThreadId");
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, "<>4__this");
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, "<>3__<>4__this");
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__visited_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, "<visited>5__2");
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__remaining_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, "<remaining>5__3");
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__currentNode_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, "<currentNode>5__4");
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, 100666186);
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, 100666187);
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, 100666188);
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_ai_pathfinding_ShortestPath_Node_T___get_Current_Private_Virtual_Final_New_get_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, 100666189);
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, 100666190);
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, 100666191);
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_ai_pathfinding_ShortestPath_Node_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, 100666192);
					ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr, 100666193);
				}

				// Token: 0x0600350B RID: 13579 RVA: 0x000D7188 File Offset: 0x000D5388
				[CallerCount(21)]
				[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetAllNodes_d__4(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestPath.Node<T>._GetAllNodes_d__4>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600350C RID: 13580 RVA: 0x000D71D0 File Offset: 0x000D53D0
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600350D RID: 13581 RVA: 0x000D7204 File Offset: 0x000D5404
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573982, XrefRangeEnd = 574013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000E45 RID: 3653
				// (get) Token: 0x0600350E RID: 13582 RVA: 0x000D7240 File Offset: 0x000D5440
				public unsafe ShortestPath.Node<T> System.Collections.Generic.IEnumerator<Canis.entities.ai.pathfinding.ShortestPath.Node<T>>.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_ai_pathfinding_ShortestPath_Node_T___get_Current_Private_Virtual_Final_New_get_Node_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new ShortestPath.Node<T>(intPtr);
					}
				}

				// Token: 0x0600350F RID: 13583 RVA: 0x000D7278 File Offset: 0x000D5478
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000E46 RID: 3654
				// (get) Token: 0x06003510 RID: 13584 RVA: 0x000D72AC File Offset: 0x000D54AC
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06003511 RID: 13585 RVA: 0x000D72EC File Offset: 0x000D54EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<ShortestPath.Node<T>> System_Collections_Generic_IEnumerable_Canis_entities_ai_pathfinding_ShortestPath_Node_T___GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_ai_pathfinding_ShortestPath_Node_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Node_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ShortestPath.Node<T>>>(intPtr3) : null;
				}

				// Token: 0x06003512 RID: 13586 RVA: 0x000D732C File Offset: 0x000D552C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 574013, XrefRangeEnd = 574020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.Node<T>._GetAllNodes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x06003513 RID: 13587 RVA: 0x00019A7A File Offset: 0x00017C7A
				public _GetAllNodes_d__4(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E3D RID: 3645
				// (get) Token: 0x06003514 RID: 13588 RVA: 0x000D736C File Offset: 0x000D556C
				// (set) Token: 0x06003515 RID: 13589 RVA: 0x00019A83 File Offset: 0x00017C83
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000E3E RID: 3646
				// (get) Token: 0x06003516 RID: 13590 RVA: 0x000D7394 File Offset: 0x000D5594
				// (set) Token: 0x06003517 RID: 13591 RVA: 0x00019A9E File Offset: 0x00017C9E
				public ShortestPath.Node<T> __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___2__current);
						return new ShortestPath.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000E3F RID: 3647
				// (get) Token: 0x06003518 RID: 13592 RVA: 0x000D73C4 File Offset: 0x000D55C4
				// (set) Token: 0x06003519 RID: 13593 RVA: 0x00019ACC File Offset: 0x00017CCC
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17000E40 RID: 3648
				// (get) Token: 0x0600351A RID: 13594 RVA: 0x000D73EC File Offset: 0x000D55EC
				// (set) Token: 0x0600351B RID: 13595 RVA: 0x00019AE7 File Offset: 0x00017CE7
				public ShortestPath.Node<T> __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___4__this);
						return new ShortestPath.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000E41 RID: 3649
				// (get) Token: 0x0600351C RID: 13596 RVA: 0x000D741C File Offset: 0x000D561C
				// (set) Token: 0x0600351D RID: 13597 RVA: 0x00019B15 File Offset: 0x00017D15
				public ShortestPath.Node<T> __3____4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___3____4__this);
						return new ShortestPath.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000E42 RID: 3650
				// (get) Token: 0x0600351E RID: 13598 RVA: 0x000D744C File Offset: 0x000D564C
				// (set) Token: 0x0600351F RID: 13599 RVA: 0x00019B43 File Offset: 0x00017D43
				public unsafe HashSet<ShortestPath.Node<T>> _visited_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__visited_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ShortestPath.Node<T>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__visited_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E43 RID: 3651
				// (get) Token: 0x06003520 RID: 13600 RVA: 0x000D747C File Offset: 0x000D567C
				// (set) Token: 0x06003521 RID: 13601 RVA: 0x00019B62 File Offset: 0x00017D62
				public unsafe Stack<ShortestPath.Node<T>> _remaining_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__remaining_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ShortestPath.Node<T>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__remaining_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E44 RID: 3652
				// (get) Token: 0x06003522 RID: 13602 RVA: 0x000D74AC File Offset: 0x000D56AC
				// (set) Token: 0x06003523 RID: 13603 RVA: 0x00019B81 File Offset: 0x00017D81
				public ShortestPath.Node<T> _currentNode_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__currentNode_5__4);
						return new ShortestPath.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.Node<T>._GetAllNodes_d__4.NativeFieldInfoPtr__currentNode_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestPath.Node<T>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x04002117 RID: 8471
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04002118 RID: 8472
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04002119 RID: 8473
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x0400211A RID: 8474
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400211B RID: 8475
				private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

				// Token: 0x0400211C RID: 8476
				private static readonly IntPtr NativeFieldInfoPtr__visited_5__2;

				// Token: 0x0400211D RID: 8477
				private static readonly IntPtr NativeFieldInfoPtr__remaining_5__3;

				// Token: 0x0400211E RID: 8478
				private static readonly IntPtr NativeFieldInfoPtr__currentNode_5__4;

				// Token: 0x0400211F RID: 8479
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04002120 RID: 8480
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04002121 RID: 8481
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04002122 RID: 8482
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_ai_pathfinding_ShortestPath_Node_T___get_Current_Private_Virtual_Final_New_get_Node_1_T_0;

				// Token: 0x04002123 RID: 8483
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04002124 RID: 8484
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04002125 RID: 8485
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_ai_pathfinding_ShortestPath_Node_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Node_1_T_0;

				// Token: 0x04002126 RID: 8486
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x02000376 RID: 886
		public sealed class NeighborFunction<T> : MulticastDelegate
		{
			// Token: 0x06002564 RID: 9572 RVA: 0x000A5D54 File Offset: 0x000A3F54
			// Note: this type is marked as 'beforefieldinit'.
			static NeighborFunction()
			{
				Il2CppClassPointerStore<ShortestPath.NeighborFunction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, "NeighborFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ShortestPath.NeighborFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.NeighborFunction<T>>.NativeClassPtr, 100666194);
				ShortestPath.NeighborFunction<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.NeighborFunction<T>>.NativeClassPtr, 100666195);
				ShortestPath.NeighborFunction<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.NeighborFunction<T>>.NativeClassPtr, 100666196);
				ShortestPath.NeighborFunction<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestPath.NeighborFunction<T>>.NativeClassPtr, 100666197);
			}

			// Token: 0x06002565 RID: 9573 RVA: 0x000A5E00 File Offset: 0x000A4000
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 554431, RefRangeEnd = 554456, XrefRangeStart = 554431, XrefRangeEnd = 554456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NeighborFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestPath.NeighborFunction<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.NeighborFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002566 RID: 9574 RVA: 0x000A5E5C File Offset: 0x000A405C
			[CallerCount(0)]
			public unsafe IEnumerable<T> Invoke(T element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = element;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref element;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortestPath.NeighborFunction<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr4) : null;
				}
			}

			// Token: 0x06002567 RID: 9575 RVA: 0x000A5EE4 File Offset: 0x000A40E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T element, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = element;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref element;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortestPath.NeighborFunction<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06002568 RID: 9576 RVA: 0x000A5F90 File Offset: 0x000A4190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<T> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestPath.NeighborFunction<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
				}
			}

			// Token: 0x06002569 RID: 9577 RVA: 0x00011DEC File Offset: 0x0000FFEC
			public NeighborFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600256A RID: 9578 RVA: 0x00011DF5 File Offset: 0x0000FFF5
			public static implicit operator ShortestPath.NeighborFunction<T>(Func<T, IEnumerable<T>> A_0)
			{
				return DelegateSupport.ConvertDelegate<ShortestPath.NeighborFunction<T>>(A_0);
			}

			// Token: 0x0600256B RID: 9579 RVA: 0x00011DFD File Offset: 0x0000FFFD
			public static ShortestPath.NeighborFunction<T>operator +(ShortestPath.NeighborFunction<T> A_0, ShortestPath.NeighborFunction<T> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ShortestPath.NeighborFunction<T>>();
			}

			// Token: 0x0600256C RID: 9580 RVA: 0x00011E0B File Offset: 0x0001000B
			public static ShortestPath.NeighborFunction<T>operator -(ShortestPath.NeighborFunction<T> A_0, ShortestPath.NeighborFunction<T> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ShortestPath.NeighborFunction<T>>();
				}
				return delegate2;
			}

			// Token: 0x04001764 RID: 5988
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001765 RID: 5989
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_T_T_0;

			// Token: 0x04001766 RID: 5990
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x04001767 RID: 5991
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_T_IAsyncResult_0;
		}

		// Token: 0x02000377 RID: 887
		[ObfuscatedName("Canis.entities.ai.pathfinding.ShortestPath+<>c__DisplayClass4_0`1")]
		public sealed class __c__DisplayClass4_0<T> : ValueType
		{
			// Token: 0x0600256D RID: 9581 RVA: 0x000A5FE0 File Offset: 0x000A41E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ShortestPath.__c__DisplayClass4_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestPath>.NativeClassPtr, "<>c__DisplayClass4_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestPath.__c__DisplayClass4_0<T>>.NativeClassPtr);
				ShortestPath.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_hasPathCostFunctions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.__c__DisplayClass4_0<T>>.NativeClassPtr, "hasPathCostFunctions");
				ShortestPath.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_heuristicFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestPath.__c__DisplayClass4_0<T>>.NativeClassPtr, "heuristicFunction");
			}

			// Token: 0x0600256E RID: 9582 RVA: 0x00011E1C File Offset: 0x0001001C
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600256F RID: 9583 RVA: 0x00011E25 File Offset: 0x00010025
			public __c__DisplayClass4_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestPath.__c__DisplayClass4_0<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000935 RID: 2357
			// (get) Token: 0x06002570 RID: 9584 RVA: 0x000A6070 File Offset: 0x000A4270
			// (set) Token: 0x06002571 RID: 9585 RVA: 0x00011E37 File Offset: 0x00010037
			public unsafe ShortestPath.IHasPathCostFunctions<T> hasPathCostFunctions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_hasPathCostFunctions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShortestPath.IHasPathCostFunctions<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_hasPathCostFunctions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000936 RID: 2358
			// (get) Token: 0x06002572 RID: 9586 RVA: 0x000A60A0 File Offset: 0x000A42A0
			// (set) Token: 0x06002573 RID: 9587 RVA: 0x00011E56 File Offset: 0x00010056
			public unsafe ShortestPath.HeuristicFunction<T> heuristicFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_heuristicFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShortestPath.HeuristicFunction<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestPath.__c__DisplayClass4_0<T>.NativeFieldInfoPtr_heuristicFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001768 RID: 5992
			private static readonly IntPtr NativeFieldInfoPtr_hasPathCostFunctions;

			// Token: 0x04001769 RID: 5993
			private static readonly IntPtr NativeFieldInfoPtr_heuristicFunction;
		}

		// Token: 0x02000378 RID: 888
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_Path_1_T_Node_1_T_Node_1_T_IHasPathCostFunctions_1_T_0<T>
		{
			// Token: 0x0400176A RID: 5994
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ShortestPath.NativeMethodInfoPtr_Find_Public_Static_Path_1_T_Node_1_T_Node_1_T_IHasPathCostFunctions_1_T_0, Il2CppClassPointerStore<ShortestPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000379 RID: 889
		private sealed class MethodInfoStoreGeneric_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_NeighborFunction_1_T_0<T>
		{
			// Token: 0x0400176B RID: 5995
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ShortestPath.NativeMethodInfoPtr_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_NeighborFunction_1_T_0, Il2CppClassPointerStore<ShortestPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200037A RID: 890
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Double_Node_1_T_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0<T>
		{
			// Token: 0x0400176C RID: 5996
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ShortestPath.NativeMethodInfoPtr_Method_Internal_Static_Double_Node_1_T_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0, Il2CppClassPointerStore<ShortestPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200037B RID: 891
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Double_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0<T>
		{
			// Token: 0x0400176D RID: 5997
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ShortestPath.NativeMethodInfoPtr_Method_Internal_Static_Double_Node_1_T_byref___c__DisplayClass4_0_1_T_PDM_0, Il2CppClassPointerStore<ShortestPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
