using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200001A RID: 26
	public class IdentityFunction<TElement> : Object
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00014E6C File Offset: 0x0001306C
		// Note: this type is marked as 'beforefieldinit'.
		static IdentityFunction()
		{
			Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "IdentityFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr);
			IdentityFunction<TElement>.NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr, 100663721);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00014EEC File Offset: 0x000130EC
		public unsafe static Func<TElement, TElement> Instance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006255, RefRangeEnd = 1006256, XrefRangeStart = 1006234, XrefRangeEnd = 1006255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TElement, TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000022BB File Offset: 0x000004BB
		public IdentityFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0;

		// Token: 0x020001B4 RID: 436
		[ObfuscatedName("System.Linq.IdentityFunction`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060015B5 RID: 5557 RVA: 0x0006BE78 File Offset: 0x0006A078
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr);
				IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, "<>9");
				IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, "<>9__1_0");
				IdentityFunction<TElement>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, 100663723);
				IdentityFunction<TElement>.__c.NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, 100663724);
			}

			// Token: 0x060015B6 RID: 5558 RVA: 0x0006BF30 File Offset: 0x0006A130
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015B7 RID: 5559 RVA: 0x0006BF6C File Offset: 0x0006A16C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 351672, RefRangeEnd = 351676, XrefRangeStart = 351672, XrefRangeEnd = 351676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TElement _get_Instance_b__1_0(TElement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = x;
						intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.__c.NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr2, false, true);
				}
			}

			// Token: 0x060015B8 RID: 5560 RVA: 0x00009102 File Offset: 0x00007302
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0006BFEC File Offset: 0x0006A1EC
			// (set) Token: 0x060015BA RID: 5562 RVA: 0x0000910B File Offset: 0x0000730B
			public unsafe static IdentityFunction<TElement>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdentityFunction<TElement>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x060015BB RID: 5563 RVA: 0x0006C014 File Offset: 0x0006A214
			// (set) Token: 0x060015BC RID: 5564 RVA: 0x0000911D File Offset: 0x0000731D
			public unsafe static Func<TElement, TElement> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TElement, TElement>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F72 RID: 3954
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000F73 RID: 3955
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04000F74 RID: 3956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F75 RID: 3957
			private static readonly IntPtr NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0;
		}
	}
}
