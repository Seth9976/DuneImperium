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
	// Token: 0x02000115 RID: 277
	public static class ShortestDistances : Object
	{
		// Token: 0x06000C92 RID: 3218 RVA: 0x0004F8FC File Offset: 0x0004DAFC
		// Note: this type is marked as 'beforefieldinit'.
		static ShortestDistances()
		{
			Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai.pathfinding", "ShortestDistances");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr);
			ShortestDistances.NativeMethodInfoPtr_Make_Public_Static_Dictionary_2_T_Double_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr, 100666130);
			ShortestDistances.NativeMethodInfoPtr_Strip_Public_Static_Dictionary_2_T_Double_Dictionary_2_Node_1_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr, 100666131);
			ShortestDistances.NativeMethodInfoPtr_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_EdgeFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr, 100666132);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0004F968 File Offset: 0x0004DB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573750, XrefRangeEnd = 573833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<T, double> Make<T>(ShortestDistances.Node<T> origin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(origin));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.MethodInfoStoreGeneric_Make_Public_Static_Dictionary_2_T_Double_Node_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T, double>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0004F9B4 File Offset: 0x0004DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573833, XrefRangeEnd = 573856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<T, double> Strip<T>(this Dictionary<ShortestDistances.Node<T>, double> distances)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(distances);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.MethodInfoStoreGeneric_Strip_Public_Static_Dictionary_2_T_Double_Dictionary_2_Node_1_T_Double_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T, double>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0004F9F8 File Offset: 0x0004DBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573856, XrefRangeEnd = 573901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<ShortestDistances.Node<T>> ConstructGraph<T>(IEnumerable<T> elements, ShortestDistances.EdgeFunction<T> edgeFunc) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edgeFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.MethodInfoStoreGeneric_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_EdgeFunction_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<ShortestDistances.Node<T>>(intPtr);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000066DB File Offset: 0x000048DB
		public ShortestDistances(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_Make_Public_Static_Dictionary_2_T_Double_Node_1_T_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_Strip_Public_Static_Dictionary_2_T_Double_Dictionary_2_Node_1_T_Double_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_EdgeFunction_1_T_0;

		// Token: 0x0200036A RID: 874
		public sealed class Node<T> : ValueType
		{
			// Token: 0x06002505 RID: 9477 RVA: 0x000A4248 File Offset: 0x000A2448
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr, "Node`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr);
				ShortestDistances.Node<T>.NativeFieldInfoPtr_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, "Element");
				ShortestDistances.Node<T>.NativeFieldInfoPtr_neighbors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, "neighbors");
				ShortestDistances.Node<T>.NativeMethodInfoPtr_get_Neighbors_Public_get_IReadOnlyList_1_Edge_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, 100666133);
				ShortestDistances.Node<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, 100666134);
				ShortestDistances.Node<T>.NativeMethodInfoPtr_AddEdge_Public_Void_Node_1_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, 100666135);
				ShortestDistances.Node<T>.NativeMethodInfoPtr_GetAllNodes_Public_IEnumerable_1_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, 100666136);
				ShortestDistances.Node<T>.NativeMethodInfoPtr_TryFindNode_Public_Boolean_T_byref_Nullable_1_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, 100666137);
				ShortestDistances.Node<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, 100666138);
				ShortestDistances.Node<T>.NativeMethodInfoPtr_Equals_Public_Boolean_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, 100666139);
				ShortestDistances.Node<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, 100666140);
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x06002506 RID: 9478 RVA: 0x000A4378 File Offset: 0x000A2578
			public unsafe IReadOnlyList<ShortestDistances.Edge<T>> Neighbors
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>.NativeMethodInfoPtr_get_Neighbors_Public_get_IReadOnlyList_1_Edge_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ShortestDistances.Edge<T>>>(intPtr3) : null;
				}
			}

			// Token: 0x06002507 RID: 9479 RVA: 0x000A43BC File Offset: 0x000A25BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 573623, RefRangeEnd = 573624, XrefRangeStart = 573601, XrefRangeEnd = 573623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(T element)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr))
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06002508 RID: 9480 RVA: 0x000A4444 File Offset: 0x000A2644
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 573628, RefRangeEnd = 573629, XrefRangeStart = 573624, XrefRangeEnd = 573628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddEdge(ShortestDistances.Node<T> target, double weight)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(target));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>.NativeMethodInfoPtr_AddEdge_Public_Void_Node_1_T_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002509 RID: 9481 RVA: 0x000A44A0 File Offset: 0x000A26A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573629, XrefRangeEnd = 573635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ShortestDistances.Node<T>> GetAllNodes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>.NativeMethodInfoPtr_GetAllNodes_Public_IEnumerable_1_Node_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ShortestDistances.Node<T>>>(intPtr3) : null;
			}

			// Token: 0x0600250A RID: 9482 RVA: 0x000A44E4 File Offset: 0x000A26E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573635, XrefRangeEnd = 573652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryFindNode(T element, out Nullable<ShortestDistances.Node<T>> foundNode)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>.NativeMethodInfoPtr_TryFindNode_Public_Boolean_T_byref_Nullable_1_Node_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr2;
				foundNode = ((intPtr5 == 0) ? null : new Nullable<ShortestDistances.Node<T>>(intPtr5));
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x0600250B RID: 9483 RVA: 0x000A4590 File Offset: 0x000A2790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573652, XrefRangeEnd = 573660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600250C RID: 9484 RVA: 0x000A45E4 File Offset: 0x000A27E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573660, XrefRangeEnd = 573663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(ShortestDistances.Node<T> other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>.NativeMethodInfoPtr_Equals_Public_Boolean_Node_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600250D RID: 9485 RVA: 0x000A463C File Offset: 0x000A283C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573663, XrefRangeEnd = 573716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600250E RID: 9486 RVA: 0x00011BFC File Offset: 0x0000FDFC
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600250F RID: 9487 RVA: 0x00011C05 File Offset: 0x0000FE05
			public Node()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x06002510 RID: 9488 RVA: 0x000A4680 File Offset: 0x000A2880
			// (set) Token: 0x06002511 RID: 9489 RVA: 0x000A46A8 File Offset: 0x000A28A8
			public unsafe T Element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>.NativeFieldInfoPtr_Element);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>.NativeFieldInfoPtr_Element);
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

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x06002512 RID: 9490 RVA: 0x000A4750 File Offset: 0x000A2950
			// (set) Token: 0x06002513 RID: 9491 RVA: 0x00011C17 File Offset: 0x0000FE17
			public unsafe List<ShortestDistances.Edge<T>> neighbors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>.NativeFieldInfoPtr_neighbors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShortestDistances.Edge<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>.NativeFieldInfoPtr_neighbors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400172D RID: 5933
			private static readonly IntPtr NativeFieldInfoPtr_Element;

			// Token: 0x0400172E RID: 5934
			private static readonly IntPtr NativeFieldInfoPtr_neighbors;

			// Token: 0x0400172F RID: 5935
			private static readonly IntPtr NativeMethodInfoPtr_get_Neighbors_Public_get_IReadOnlyList_1_Edge_1_T_0;

			// Token: 0x04001730 RID: 5936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

			// Token: 0x04001731 RID: 5937
			private static readonly IntPtr NativeMethodInfoPtr_AddEdge_Public_Void_Node_1_T_Double_0;

			// Token: 0x04001732 RID: 5938
			private static readonly IntPtr NativeMethodInfoPtr_GetAllNodes_Public_IEnumerable_1_Node_1_T_0;

			// Token: 0x04001733 RID: 5939
			private static readonly IntPtr NativeMethodInfoPtr_TryFindNode_Public_Boolean_T_byref_Nullable_1_Node_1_T_0;

			// Token: 0x04001734 RID: 5940
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04001735 RID: 5941
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Node_1_T_0;

			// Token: 0x04001736 RID: 5942
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x0200048D RID: 1165
			[ObfuscatedName("Canis.entities.ai.pathfinding.ShortestDistances+Node`1+<GetAllNodes>d__6")]
			public sealed class _GetAllNodes_d__6 : Object
			{
				// Token: 0x060034F0 RID: 13552 RVA: 0x000D6AE4 File Offset: 0x000D4CE4
				// Note: this type is marked as 'beforefieldinit'.
				static _GetAllNodes_d__6()
				{
					Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, "<GetAllNodes>d__6"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr);
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, "<>1__state");
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, "<>2__current");
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, "<>l__initialThreadId");
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, "<>4__this");
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, "<>3__<>4__this");
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__visited_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, "<visited>5__2");
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__remaining_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, "<remaining>5__3");
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__currentNode_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, "<currentNode>5__4");
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, 100666141);
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, 100666142);
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, 100666143);
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_ai_pathfinding_ShortestDistances_Node_T___get_Current_Private_Virtual_Final_New_get_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, 100666144);
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, 100666145);
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, 100666146);
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_ai_pathfinding_ShortestDistances_Node_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, 100666147);
					ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr, 100666148);
				}

				// Token: 0x060034F1 RID: 13553 RVA: 0x000D6C8C File Offset: 0x000D4E8C
				[CallerCount(21)]
				[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetAllNodes_d__6(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestDistances.Node<T>._GetAllNodes_d__6>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060034F2 RID: 13554 RVA: 0x000D6CD4 File Offset: 0x000D4ED4
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034F3 RID: 13555 RVA: 0x000D6D08 File Offset: 0x000D4F08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573555, XrefRangeEnd = 573586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000E3B RID: 3643
				// (get) Token: 0x060034F4 RID: 13556 RVA: 0x000D6D44 File Offset: 0x000D4F44
				public unsafe ShortestDistances.Node<T> System.Collections.Generic.IEnumerator<Canis.entities.ai.pathfinding.ShortestDistances.Node<T>>.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_ai_pathfinding_ShortestDistances_Node_T___get_Current_Private_Virtual_Final_New_get_Node_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new ShortestDistances.Node<T>(intPtr);
					}
				}

				// Token: 0x060034F5 RID: 13557 RVA: 0x000D6D7C File Offset: 0x000D4F7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000E3C RID: 3644
				// (get) Token: 0x060034F6 RID: 13558 RVA: 0x000D6DB0 File Offset: 0x000D4FB0
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573586, XrefRangeEnd = 573587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060034F7 RID: 13559 RVA: 0x000D6DF0 File Offset: 0x000D4FF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573587, XrefRangeEnd = 573594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<ShortestDistances.Node<T>> System_Collections_Generic_IEnumerable_Canis_entities_ai_pathfinding_ShortestDistances_Node_T___GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_ai_pathfinding_ShortestDistances_Node_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Node_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ShortestDistances.Node<T>>>(intPtr3) : null;
				}

				// Token: 0x060034F8 RID: 13560 RVA: 0x000D6E30 File Offset: 0x000D5030
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573594, XrefRangeEnd = 573601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x060034F9 RID: 13561 RVA: 0x00019945 File Offset: 0x00017B45
				public _GetAllNodes_d__6(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E33 RID: 3635
				// (get) Token: 0x060034FA RID: 13562 RVA: 0x000D6E70 File Offset: 0x000D5070
				// (set) Token: 0x060034FB RID: 13563 RVA: 0x0001994E File Offset: 0x00017B4E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000E34 RID: 3636
				// (get) Token: 0x060034FC RID: 13564 RVA: 0x000D6E98 File Offset: 0x000D5098
				// (set) Token: 0x060034FD RID: 13565 RVA: 0x00019969 File Offset: 0x00017B69
				public ShortestDistances.Node<T> __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___2__current);
						return new ShortestDistances.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000E35 RID: 3637
				// (get) Token: 0x060034FE RID: 13566 RVA: 0x000D6EC8 File Offset: 0x000D50C8
				// (set) Token: 0x060034FF RID: 13567 RVA: 0x00019997 File Offset: 0x00017B97
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17000E36 RID: 3638
				// (get) Token: 0x06003500 RID: 13568 RVA: 0x000D6EF0 File Offset: 0x000D50F0
				// (set) Token: 0x06003501 RID: 13569 RVA: 0x000199B2 File Offset: 0x00017BB2
				public ShortestDistances.Node<T> __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___4__this);
						return new ShortestDistances.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000E37 RID: 3639
				// (get) Token: 0x06003502 RID: 13570 RVA: 0x000D6F20 File Offset: 0x000D5120
				// (set) Token: 0x06003503 RID: 13571 RVA: 0x000199E0 File Offset: 0x00017BE0
				public ShortestDistances.Node<T> __3____4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___3____4__this);
						return new ShortestDistances.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000E38 RID: 3640
				// (get) Token: 0x06003504 RID: 13572 RVA: 0x000D6F50 File Offset: 0x000D5150
				// (set) Token: 0x06003505 RID: 13573 RVA: 0x00019A0E File Offset: 0x00017C0E
				public unsafe HashSet<ShortestDistances.Node<T>> _visited_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__visited_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ShortestDistances.Node<T>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__visited_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E39 RID: 3641
				// (get) Token: 0x06003506 RID: 13574 RVA: 0x000D6F80 File Offset: 0x000D5180
				// (set) Token: 0x06003507 RID: 13575 RVA: 0x00019A2D File Offset: 0x00017C2D
				public unsafe Stack<ShortestDistances.Node<T>> _remaining_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__remaining_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ShortestDistances.Node<T>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__remaining_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E3A RID: 3642
				// (get) Token: 0x06003508 RID: 13576 RVA: 0x000D6FB0 File Offset: 0x000D51B0
				// (set) Token: 0x06003509 RID: 13577 RVA: 0x00019A4C File Offset: 0x00017C4C
				public ShortestDistances.Node<T> _currentNode_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__currentNode_5__4);
						return new ShortestDistances.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Node<T>._GetAllNodes_d__6.NativeFieldInfoPtr__currentNode_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x04002107 RID: 8455
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04002108 RID: 8456
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04002109 RID: 8457
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x0400210A RID: 8458
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400210B RID: 8459
				private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

				// Token: 0x0400210C RID: 8460
				private static readonly IntPtr NativeFieldInfoPtr__visited_5__2;

				// Token: 0x0400210D RID: 8461
				private static readonly IntPtr NativeFieldInfoPtr__remaining_5__3;

				// Token: 0x0400210E RID: 8462
				private static readonly IntPtr NativeFieldInfoPtr__currentNode_5__4;

				// Token: 0x0400210F RID: 8463
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04002110 RID: 8464
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04002111 RID: 8465
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04002112 RID: 8466
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_ai_pathfinding_ShortestDistances_Node_T___get_Current_Private_Virtual_Final_New_get_Node_1_T_0;

				// Token: 0x04002113 RID: 8467
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04002114 RID: 8468
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04002115 RID: 8469
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_ai_pathfinding_ShortestDistances_Node_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Node_1_T_0;

				// Token: 0x04002116 RID: 8470
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x0200036B RID: 875
		public sealed class Edge<T> : ValueType
		{
			// Token: 0x06002514 RID: 9492 RVA: 0x000A4780 File Offset: 0x000A2980
			// Note: this type is marked as 'beforefieldinit'.
			static Edge()
			{
				Il2CppClassPointerStore<ShortestDistances.Edge<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr, "Edge`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestDistances.Edge<T>>.NativeClassPtr);
				ShortestDistances.Edge<T>.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Edge<T>>.NativeClassPtr, "Target");
				ShortestDistances.Edge<T>.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.Edge<T>>.NativeClassPtr, "Weight");
				ShortestDistances.Edge<T>.NativeMethodInfoPtr__ctor_Public_Void_Node_1_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.Edge<T>>.NativeClassPtr, 100666149);
			}

			// Token: 0x06002515 RID: 9493 RVA: 0x000A4824 File Offset: 0x000A2A24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 573717, RefRangeEnd = 573718, XrefRangeStart = 573716, XrefRangeEnd = 573717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Edge(ShortestDistances.Node<T> target, double weight)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestDistances.Edge<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(target));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.Edge<T>.NativeMethodInfoPtr__ctor_Public_Void_Node_1_T_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002516 RID: 9494 RVA: 0x00011C36 File Offset: 0x0000FE36
			public Edge(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002517 RID: 9495 RVA: 0x00011C3F File Offset: 0x0000FE3F
			public Edge()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestDistances.Edge<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x06002518 RID: 9496 RVA: 0x000A4888 File Offset: 0x000A2A88
			// (set) Token: 0x06002519 RID: 9497 RVA: 0x00011C51 File Offset: 0x0000FE51
			public ShortestDistances.Node<T> Target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Edge<T>.NativeFieldInfoPtr_Target);
					return new ShortestDistances.Node<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Edge<T>.NativeFieldInfoPtr_Target), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortestDistances.Node<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x0600251A RID: 9498 RVA: 0x000A48B8 File Offset: 0x000A2AB8
			// (set) Token: 0x0600251B RID: 9499 RVA: 0x00011C7F File Offset: 0x0000FE7F
			public unsafe double Weight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Edge<T>.NativeFieldInfoPtr_Weight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortestDistances.Edge<T>.NativeFieldInfoPtr_Weight)) = value;
				}
			}

			// Token: 0x04001737 RID: 5943
			private static readonly IntPtr NativeFieldInfoPtr_Target;

			// Token: 0x04001738 RID: 5944
			private static readonly IntPtr NativeFieldInfoPtr_Weight;

			// Token: 0x04001739 RID: 5945
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Node_1_T_Double_0;
		}

		// Token: 0x0200036C RID: 876
		public sealed class EdgeFunction<T> : MulticastDelegate
		{
			// Token: 0x0600251C RID: 9500 RVA: 0x000A48E0 File Offset: 0x000A2AE0
			// Note: this type is marked as 'beforefieldinit'.
			static EdgeFunction()
			{
				Il2CppClassPointerStore<ShortestDistances.EdgeFunction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr, "EdgeFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ShortestDistances.EdgeFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.EdgeFunction<T>>.NativeClassPtr, 100666150);
				ShortestDistances.EdgeFunction<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_ValueTuple_2_T_Double_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.EdgeFunction<T>>.NativeClassPtr, 100666151);
				ShortestDistances.EdgeFunction<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.EdgeFunction<T>>.NativeClassPtr, 100666152);
				ShortestDistances.EdgeFunction<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_ValueTuple_2_T_Double_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.EdgeFunction<T>>.NativeClassPtr, 100666153);
			}

			// Token: 0x0600251D RID: 9501 RVA: 0x000A498C File Offset: 0x000A2B8C
			[CallerCount(1058)]
			[CachedScanResults(RefRangeStart = 340122, RefRangeEnd = 341180, XrefRangeStart = 340122, XrefRangeEnd = 341180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EdgeFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestDistances.EdgeFunction<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.EdgeFunction<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600251E RID: 9502 RVA: 0x000A49E8 File Offset: 0x000A2BE8
			[CallerCount(0)]
			public unsafe IEnumerable<ValueTuple<T, double>> Invoke(T element)
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.EdgeFunction<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_ValueTuple_2_T_Double_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<T, double>>>(intPtr4) : null;
				}
			}

			// Token: 0x0600251F RID: 9503 RVA: 0x000A4A70 File Offset: 0x000A2C70
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.EdgeFunction<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06002520 RID: 9504 RVA: 0x000A4B1C File Offset: 0x000A2D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ValueTuple<T, double>> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.EdgeFunction<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_ValueTuple_2_T_Double_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<T, double>>>(intPtr3) : null;
				}
			}

			// Token: 0x06002521 RID: 9505 RVA: 0x00011C9A File Offset: 0x0000FE9A
			public EdgeFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002522 RID: 9506 RVA: 0x00011CA3 File Offset: 0x0000FEA3
			public static implicit operator ShortestDistances.EdgeFunction<T>(Func<T, IEnumerable<ValueTuple<T, double>>> A_0)
			{
				return DelegateSupport.ConvertDelegate<ShortestDistances.EdgeFunction<T>>(A_0);
			}

			// Token: 0x06002523 RID: 9507 RVA: 0x00011CAB File Offset: 0x0000FEAB
			public static ShortestDistances.EdgeFunction<T>operator +(ShortestDistances.EdgeFunction<T> A_0, ShortestDistances.EdgeFunction<T> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ShortestDistances.EdgeFunction<T>>();
			}

			// Token: 0x06002524 RID: 9508 RVA: 0x00011CB9 File Offset: 0x0000FEB9
			public static ShortestDistances.EdgeFunction<T>operator -(ShortestDistances.EdgeFunction<T> A_0, ShortestDistances.EdgeFunction<T> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ShortestDistances.EdgeFunction<T>>();
				}
				return delegate2;
			}

			// Token: 0x0400173A RID: 5946
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400173B RID: 5947
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_ValueTuple_2_T_Double_T_0;

			// Token: 0x0400173C RID: 5948
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x0400173D RID: 5949
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_ValueTuple_2_T_Double_IAsyncResult_0;
		}

		// Token: 0x0200036D RID: 877
		[ObfuscatedName("Canis.entities.ai.pathfinding.ShortestDistances+<>c__2`1")]
		[Serializable]
		public sealed class __c__2<T> : Object
		{
			// Token: 0x06002525 RID: 9509 RVA: 0x000A4B6C File Offset: 0x000A2D6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__2()
			{
				Il2CppClassPointerStore<ShortestDistances.__c__2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr, "<>c__2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestDistances.__c__2<T>>.NativeClassPtr);
				ShortestDistances.__c__2<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.__c__2<T>>.NativeClassPtr, "<>9");
				ShortestDistances.__c__2<T>.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.__c__2<T>>.NativeClassPtr, "<>9__2_0");
				ShortestDistances.__c__2<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.__c__2<T>>.NativeClassPtr, 100666155);
				ShortestDistances.__c__2<T>.NativeMethodInfoPtr__Make_b__2_0_Internal_Int32_ValueTuple_2_Double_Node_1_T_ValueTuple_2_Double_Node_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.__c__2<T>>.NativeClassPtr, 100666156);
			}

			// Token: 0x06002526 RID: 9510 RVA: 0x000A4C24 File Offset: 0x000A2E24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestDistances.__c__2<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.__c__2<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002527 RID: 9511 RVA: 0x000A4C60 File Offset: 0x000A2E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573718, XrefRangeEnd = 573745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Make_b__2_0(ValueTuple<double, ShortestDistances.Node<T>> a, ValueTuple<double, ShortestDistances.Node<T>> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.__c__2<T>.NativeMethodInfoPtr__Make_b__2_0_Internal_Int32_ValueTuple_2_Double_Node_1_T_ValueTuple_2_Double_Node_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002528 RID: 9512 RVA: 0x00011CCA File Offset: 0x0000FECA
			public __c__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x06002529 RID: 9513 RVA: 0x000A4CCC File Offset: 0x000A2ECC
			// (set) Token: 0x0600252A RID: 9514 RVA: 0x00011CD3 File Offset: 0x0000FED3
			public unsafe static ShortestDistances.__c__2<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShortestDistances.__c__2<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShortestDistances.__c__2<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShortestDistances.__c__2<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000928 RID: 2344
			// (get) Token: 0x0600252B RID: 9515 RVA: 0x000A4CF4 File Offset: 0x000A2EF4
			// (set) Token: 0x0600252C RID: 9516 RVA: 0x00011CE5 File Offset: 0x0000FEE5
			public unsafe static Comparison<ValueTuple<double, ShortestDistances.Node<T>>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShortestDistances.__c__2<T>.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ValueTuple<double, ShortestDistances.Node<T>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShortestDistances.__c__2<T>.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400173E RID: 5950
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400173F RID: 5951
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001740 RID: 5952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001741 RID: 5953
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__2_0_Internal_Int32_ValueTuple_2_Double_Node_1_T_ValueTuple_2_Double_Node_1_T_0;
		}

		// Token: 0x0200036E RID: 878
		[ObfuscatedName("Canis.entities.ai.pathfinding.ShortestDistances+<>c__3`1")]
		[Serializable]
		public sealed class __c__3<T> : Object
		{
			// Token: 0x0600252D RID: 9517 RVA: 0x000A4D1C File Offset: 0x000A2F1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr, "<>c__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr);
				ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr, "<>9");
				ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr, "<>9__3_0");
				ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr, "<>9__3_1");
				ShortestDistances.__c__3<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr, 100666158);
				ShortestDistances.__c__3<T>.NativeMethodInfoPtr__Strip_b__3_0_Internal_T_KeyValuePair_2_Node_1_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr, 100666159);
				ShortestDistances.__c__3<T>.NativeMethodInfoPtr__Strip_b__3_1_Internal_Double_KeyValuePair_2_Node_1_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr, 100666160);
			}

			// Token: 0x0600252E RID: 9518 RVA: 0x000A4DFC File Offset: 0x000A2FFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortestDistances.__c__3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.__c__3<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600252F RID: 9519 RVA: 0x000A4E38 File Offset: 0x000A3038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573745, XrefRangeEnd = 573750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Strip_b__3_0(KeyValuePair<ShortestDistances.Node<T>, double> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.__c__3<T>.NativeMethodInfoPtr__Strip_b__3_0_Internal_T_KeyValuePair_2_Node_1_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002530 RID: 9520 RVA: 0x000A4E88 File Offset: 0x000A3088
			[CallerCount(0)]
			public unsafe double _Strip_b__3_1(KeyValuePair<ShortestDistances.Node<T>, double> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortestDistances.__c__3<T>.NativeMethodInfoPtr__Strip_b__3_1_Internal_Double_KeyValuePair_2_Node_1_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002531 RID: 9521 RVA: 0x00011CF7 File Offset: 0x0000FEF7
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000929 RID: 2345
			// (get) Token: 0x06002532 RID: 9522 RVA: 0x000A4EDC File Offset: 0x000A30DC
			// (set) Token: 0x06002533 RID: 9523 RVA: 0x00011D00 File Offset: 0x0000FF00
			public unsafe static ShortestDistances.__c__3<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShortestDistances.__c__3<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092A RID: 2346
			// (get) Token: 0x06002534 RID: 9524 RVA: 0x000A4F04 File Offset: 0x000A3104
			// (set) Token: 0x06002535 RID: 9525 RVA: 0x00011D12 File Offset: 0x0000FF12
			public unsafe static Func<KeyValuePair<ShortestDistances.Node<T>, double>, T> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ShortestDistances.Node<T>, double>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092B RID: 2347
			// (get) Token: 0x06002536 RID: 9526 RVA: 0x000A4F2C File Offset: 0x000A312C
			// (set) Token: 0x06002537 RID: 9527 RVA: 0x00011D24 File Offset: 0x0000FF24
			public unsafe static Func<KeyValuePair<ShortestDistances.Node<T>, double>, double> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ShortestDistances.Node<T>, double>, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShortestDistances.__c__3<T>.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001742 RID: 5954
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001743 RID: 5955
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001744 RID: 5956
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04001745 RID: 5957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001746 RID: 5958
			private static readonly IntPtr NativeMethodInfoPtr__Strip_b__3_0_Internal_T_KeyValuePair_2_Node_1_T_Double_0;

			// Token: 0x04001747 RID: 5959
			private static readonly IntPtr NativeMethodInfoPtr__Strip_b__3_1_Internal_Double_KeyValuePair_2_Node_1_T_Double_0;
		}

		// Token: 0x0200036F RID: 879
		private sealed class MethodInfoStoreGeneric_Make_Public_Static_Dictionary_2_T_Double_Node_1_T_0<T>
		{
			// Token: 0x04001748 RID: 5960
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ShortestDistances.NativeMethodInfoPtr_Make_Public_Static_Dictionary_2_T_Double_Node_1_T_0, Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000370 RID: 880
		private sealed class MethodInfoStoreGeneric_Strip_Public_Static_Dictionary_2_T_Double_Dictionary_2_Node_1_T_Double_0<T>
		{
			// Token: 0x04001749 RID: 5961
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ShortestDistances.NativeMethodInfoPtr_Strip_Public_Static_Dictionary_2_T_Double_Dictionary_2_Node_1_T_Double_0, Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000371 RID: 881
		private sealed class MethodInfoStoreGeneric_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_EdgeFunction_1_T_0<T>
		{
			// Token: 0x0400174A RID: 5962
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ShortestDistances.NativeMethodInfoPtr_ConstructGraph_Public_Static_Nullable_1_Node_1_T_IEnumerable_1_T_EdgeFunction_1_T_0, Il2CppClassPointerStore<ShortestDistances>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
