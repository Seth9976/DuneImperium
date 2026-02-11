using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x02000108 RID: 264
	public class Dict<TValue> : Object where TValue : class
	{
		// Token: 0x06001629 RID: 5673 RVA: 0x0005EF18 File Offset: 0x0005D118
		// Note: this type is marked as 'beforefieldinit'.
		static Dict()
		{
			Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "Dict`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr);
			Dict<TValue>.NativeFieldInfoPtr__leq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, "_leq");
			Dict<TValue>.NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, "_head");
			Dict<TValue>.NativeMethodInfoPtr__ctor_Public_Void_LessOrEqual_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, 100665849);
			Dict<TValue>.NativeMethodInfoPtr_Insert_Public_Node_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, 100665850);
			Dict<TValue>.NativeMethodInfoPtr_InsertBefore_Public_Node_TValue_Node_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, 100665851);
			Dict<TValue>.NativeMethodInfoPtr_Find_Public_Node_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, 100665852);
			Dict<TValue>.NativeMethodInfoPtr_Min_Public_Node_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, 100665853);
			Dict<TValue>.NativeMethodInfoPtr_Remove_Public_Void_Node_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, 100665854);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0005F024 File Offset: 0x0005D224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 622968, RefRangeEnd = 622970, XrefRangeStart = 622959, XrefRangeEnd = 622968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dict(Dict<TValue>.LessOrEqual leq)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.NativeMethodInfoPtr__ctor_Public_Void_LessOrEqual_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0005F070 File Offset: 0x0005D270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622978, RefRangeEnd = 622979, XrefRangeStart = 622970, XrefRangeEnd = 622978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dict<TValue>.Node Insert(TValue key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = key;
					intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.NativeMethodInfoPtr_Insert_Public_Node_TValue_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr4) : null;
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 622987, RefRangeEnd = 622993, XrefRangeStart = 622979, XrefRangeEnd = 622987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dict<TValue>.Node InsertBefore(Dict<TValue>.Node node, TValue key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = key;
				intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.NativeMethodInfoPtr_InsertBefore_Public_Node_TValue_Node_TValue_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr4) : null;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0005F190 File Offset: 0x0005D390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 622993, RefRangeEnd = 622995, XrefRangeStart = 622993, XrefRangeEnd = 622993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dict<TValue>.Node Find(TValue key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = key;
					intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.NativeMethodInfoPtr_Find_Public_Node_TValue_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr4) : null;
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0005F218 File Offset: 0x0005D418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373348, RefRangeEnd = 373350, XrefRangeStart = 373348, XrefRangeEnd = 373350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dict<TValue>.Node Min()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.NativeMethodInfoPtr_Min_Public_Node_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr3) : null;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0005F258 File Offset: 0x0005D458
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 622998, RefRangeEnd = 623007, XrefRangeStart = 622995, XrefRangeEnd = 622998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Dict<TValue>.Node node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.NativeMethodInfoPtr_Remove_Public_Void_Node_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0000CE62 File Offset: 0x0000B062
		public Dict(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x0005F29C File Offset: 0x0005D49C
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x0000CE6B File Offset: 0x0000B06B
		public unsafe Dict<TValue>.LessOrEqual _leq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.NativeFieldInfoPtr__leq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.LessOrEqual>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.NativeFieldInfoPtr__leq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0005F2CC File Offset: 0x0005D4CC
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x0000CE8A File Offset: 0x0000B08A
		public unsafe Dict<TValue>.Node _head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.NativeFieldInfoPtr__head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.NativeFieldInfoPtr__head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeFieldInfoPtr__leq;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeFieldInfoPtr__head;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LessOrEqual_TValue_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Node_TValue_TValue_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_InsertBefore_Public_Node_TValue_Node_TValue_TValue_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Node_TValue_TValue_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Node_TValue_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Node_TValue_0;

		// Token: 0x020001D7 RID: 471
		public class Node : Object
		{
			// Token: 0x060020ED RID: 8429 RVA: 0x0007FC88 File Offset: 0x0007DE88
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, "Node"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr);
				Dict<TValue>.Node.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr, "_key");
				Dict<TValue>.Node.NativeFieldInfoPtr__prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr, "_prev");
				Dict<TValue>.Node.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr, "_next");
				Dict<TValue>.Node.NativeMethodInfoPtr_get_Key_Public_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr, 100665855);
				Dict<TValue>.Node.NativeMethodInfoPtr_get_Prev_Public_get_Node_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr, 100665856);
				Dict<TValue>.Node.NativeMethodInfoPtr_get_Next_Public_get_Node_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr, 100665857);
				Dict<TValue>.Node.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr, 100665858);
			}

			// Token: 0x17000BDD RID: 3037
			// (get) Token: 0x060020EE RID: 8430 RVA: 0x0007FD7C File Offset: 0x0007DF7C
			public unsafe TValue Key
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.Node.NativeMethodInfoPtr_get_Key_Public_get_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}

			// Token: 0x17000BDE RID: 3038
			// (get) Token: 0x060020EF RID: 8431 RVA: 0x0007FDB8 File Offset: 0x0007DFB8
			public unsafe Dict<TValue>.Node Prev
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.Node.NativeMethodInfoPtr_get_Prev_Public_get_Node_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr3) : null;
				}
			}

			// Token: 0x17000BDF RID: 3039
			// (get) Token: 0x060020F0 RID: 8432 RVA: 0x0007FDF8 File Offset: 0x0007DFF8
			public unsafe Dict<TValue>.Node Next
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.Node.NativeMethodInfoPtr_get_Next_Public_get_Node_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr3) : null;
				}
			}

			// Token: 0x060020F1 RID: 8433 RVA: 0x0007FE38 File Offset: 0x0007E038
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dict<TValue>.Node>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.Node.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F2 RID: 8434 RVA: 0x00012E1F File Offset: 0x0001101F
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BDA RID: 3034
			// (get) Token: 0x060020F3 RID: 8435 RVA: 0x0007FE74 File Offset: 0x0007E074
			// (set) Token: 0x060020F4 RID: 8436 RVA: 0x0007FE9C File Offset: 0x0007E09C
			public unsafe TValue _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.Node.NativeFieldInfoPtr__key);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.Node.NativeFieldInfoPtr__key);
					Type typeFromHandle = typeof(TValue);
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

			// Token: 0x17000BDB RID: 3035
			// (get) Token: 0x060020F5 RID: 8437 RVA: 0x0007FF44 File Offset: 0x0007E144
			// (set) Token: 0x060020F6 RID: 8438 RVA: 0x00012E28 File Offset: 0x00011028
			public unsafe Dict<TValue>.Node _prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.Node.NativeFieldInfoPtr__prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.Node.NativeFieldInfoPtr__prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDC RID: 3036
			// (get) Token: 0x060020F7 RID: 8439 RVA: 0x0007FF74 File Offset: 0x0007E174
			// (set) Token: 0x060020F8 RID: 8440 RVA: 0x00012E47 File Offset: 0x00011047
			public unsafe Dict<TValue>.Node _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.Node.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dict<TValue>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dict<TValue>.Node.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001768 RID: 5992
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04001769 RID: 5993
			private static readonly IntPtr NativeFieldInfoPtr__prev;

			// Token: 0x0400176A RID: 5994
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x0400176B RID: 5995
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_TValue_0;

			// Token: 0x0400176C RID: 5996
			private static readonly IntPtr NativeMethodInfoPtr_get_Prev_Public_get_Node_TValue_0;

			// Token: 0x0400176D RID: 5997
			private static readonly IntPtr NativeMethodInfoPtr_get_Next_Public_get_Node_TValue_0;

			// Token: 0x0400176E RID: 5998
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001D8 RID: 472
		public sealed class LessOrEqual : MulticastDelegate
		{
			// Token: 0x060020F9 RID: 8441 RVA: 0x0007FFA4 File Offset: 0x0007E1A4
			// Note: this type is marked as 'beforefieldinit'.
			static LessOrEqual()
			{
				Il2CppClassPointerStore<Dict<TValue>.LessOrEqual>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dict<TValue>>.NativeClassPtr, "LessOrEqual"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				Dict<TValue>.LessOrEqual.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>.LessOrEqual>.NativeClassPtr, 100665859);
				Dict<TValue>.LessOrEqual.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>.LessOrEqual>.NativeClassPtr, 100665860);
				Dict<TValue>.LessOrEqual.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TValue_TValue_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>.LessOrEqual>.NativeClassPtr, 100665861);
				Dict<TValue>.LessOrEqual.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dict<TValue>.LessOrEqual>.NativeClassPtr, 100665862);
			}

			// Token: 0x060020FA RID: 8442 RVA: 0x00080050 File Offset: 0x0007E250
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 622948, RefRangeEnd = 622956, XrefRangeStart = 622939, XrefRangeEnd = 622948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessOrEqual(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dict<TValue>.LessOrEqual>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.LessOrEqual.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020FB RID: 8443 RVA: 0x000800AC File Offset: 0x0007E2AC
			[CallerCount(0)]
			public unsafe bool Invoke(TValue lhs, TValue rhs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = lhs;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref lhs;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue2 = rhs;
					intPtr2 = ((tvalue2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref rhs;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.LessOrEqual.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_TValue_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060020FC RID: 8444 RVA: 0x00080178 File Offset: 0x0007E378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622956, XrefRangeEnd = 622957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TValue lhs, TValue rhs, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = lhs;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref lhs;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue2 = rhs;
					intPtr2 = ((tvalue2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref rhs;
				}
				ptr3 = intPtr2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.LessOrEqual.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TValue_TValue_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr3;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x060020FD RID: 8445 RVA: 0x0008026C File Offset: 0x0007E46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622957, XrefRangeEnd = 622959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dict<TValue>.LessOrEqual.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020FE RID: 8446 RVA: 0x00012E66 File Offset: 0x00011066
			public LessOrEqual(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020FF RID: 8447 RVA: 0x00012E6F File Offset: 0x0001106F
			public static implicit operator Dict<TValue>.LessOrEqual(Func<TValue, TValue, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<Dict<TValue>.LessOrEqual>(A_0);
			}

			// Token: 0x06002100 RID: 8448 RVA: 0x00012E77 File Offset: 0x00011077
			public static Dict<TValue>.LessOrEqual operator +(Dict<TValue>.LessOrEqual A_0, Dict<TValue>.LessOrEqual A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Dict<TValue>.LessOrEqual>();
			}

			// Token: 0x06002101 RID: 8449 RVA: 0x00012E85 File Offset: 0x00011085
			public static Dict<TValue>.LessOrEqual operator -(Dict<TValue>.LessOrEqual A_0, Dict<TValue>.LessOrEqual A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Dict<TValue>.LessOrEqual>();
				}
				return delegate2;
			}

			// Token: 0x0400176F RID: 5999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001770 RID: 6000
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_TValue_TValue_0;

			// Token: 0x04001771 RID: 6001
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TValue_TValue_AsyncCallback_Object_0;

			// Token: 0x04001772 RID: 6002
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}
	}
}
