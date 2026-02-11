using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000044 RID: 68
	public static class TMP_ListPool<T> : Object
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x00024040 File Offset: 0x00022240
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ListPool()
		{
			Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr);
			TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, "s_ListPool");
			TMP_ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, 100664200);
			TMP_ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, 100664201);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000240E8 File Offset: 0x000222E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1043824, RefRangeEnd = 1043831, XrefRangeStart = 1043815, XrefRangeEnd = 1043824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.NativeMethodInfoPtr_Get_Public_Static_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002411C File Offset: 0x0002231C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1043844, RefRangeEnd = 1043851, XrefRangeStart = 1043831, XrefRangeEnd = 1043844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<T> toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000059CD File Offset: 0x00003BCD
		public TMP_ListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00024154 File Offset: 0x00022354
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x000059D6 File Offset: 0x00003BD6
		public unsafe static TMP_ObjectPool<List<T>> s_ListPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ObjectPool<List<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ListPool<T>.NativeFieldInfoPtr_s_ListPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_s_ListPool;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_T_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_T_0;

		// Token: 0x0200009F RID: 159
		[ObfuscatedName("TMPro.TMP_ListPool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F91 RID: 3985 RVA: 0x0003DD78 File Offset: 0x0003BF78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_ListPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr);
				TMP_ListPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, "<>9");
				TMP_ListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, 100664204);
				TMP_ListPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr, 100664205);
			}

			// Token: 0x06000F92 RID: 3986 RVA: 0x0003DE1C File Offset: 0x0003C01C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ListPool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F93 RID: 3987 RVA: 0x0003DE58 File Offset: 0x0003C058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043814, XrefRangeEnd = 1043815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__3_0(List<T> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ListPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F94 RID: 3988 RVA: 0x00009628 File Offset: 0x00007828
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0003DE9C File Offset: 0x0003C09C
			// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00009631 File Offset: 0x00007831
			public unsafe static TMP_ListPool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_ListPool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ListPool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_ListPool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C46 RID: 3142
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C47 RID: 3143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C48 RID: 3144
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_0_Internal_Void_List_1_T_0;
		}
	}
}
