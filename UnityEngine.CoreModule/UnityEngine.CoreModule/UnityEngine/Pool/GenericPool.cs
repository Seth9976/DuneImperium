using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Pool
{
	// Token: 0x020001D1 RID: 465
	public class GenericPool<T> : Object where T : class, new()
	{
		// Token: 0x06002107 RID: 8455 RVA: 0x00091B94 File Offset: 0x0008FD94
		// Note: this type is marked as 'beforefieldinit'.
		static GenericPool()
		{
			Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "GenericPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr);
			GenericPool<T>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, "s_Pool");
			GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100667755);
			GenericPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100667756);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00091C3C File Offset: 0x0008FE3C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 680468, RefRangeEnd = 680518, XrefRangeStart = 680468, XrefRangeEnd = 680518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00091C6C File Offset: 0x0008FE6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680683, RefRangeEnd = 680684, XrefRangeStart = 680634, XrefRangeEnd = 680683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(T toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = toRelease;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref toRelease;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0000C9DF File Offset: 0x0000ABDF
		public GenericPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x00091CD8 File Offset: 0x0008FED8
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x0000C9E8 File Offset: 0x0000ABE8
		public unsafe static ObjectPool<T> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericPool<T>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericPool<T>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0000C9FA File Offset: 0x0000ABFA
		public static PooledObject<T> Get(out T value)
		{
			return GenericPool.s_Pool.Get(out value);
		}

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_T_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_T_0;

		// Token: 0x0200091A RID: 2330
		[ObfuscatedName("UnityEngine.Pool.GenericPool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003B36 RID: 15158 RVA: 0x000BDFDC File Offset: 0x000BC1DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr);
				GenericPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr, "<>9");
				GenericPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr, 100667759);
				GenericPool<T>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr, 100667760);
			}

			// Token: 0x06003B37 RID: 15159 RVA: 0x000BE080 File Offset: 0x000BC280
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B38 RID: 15160 RVA: 0x000BE0BC File Offset: 0x000BC2BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06003B39 RID: 15161 RVA: 0x00016301 File Offset: 0x00014501
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x06003B3A RID: 15162 RVA: 0x000BE0F8 File Offset: 0x000BC2F8
			// (set) Token: 0x06003B3B RID: 15163 RVA: 0x0001630A File Offset: 0x0001450A
			public unsafe static GenericPool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericPool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericPool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericPool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CFF RID: 11519
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D00 RID: 11520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D01 RID: 11521
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_T_0;
		}
	}
}
