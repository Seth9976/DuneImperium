using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000045 RID: 69
	public static class BurstRuntime : Object
	{
		// Token: 0x06000274 RID: 628 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
		// Note: this type is marked as 'beforefieldinit'.
		static BurstRuntime()
		{
			Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "BurstRuntime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr);
			BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663512);
			BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663513);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0001CE1C File Offset: 0x0001B01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 643959, RefRangeEnd = 643960, XrefRangeStart = 643956, XrefRangeEnd = 643959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetHashCode64<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001CE4C File Offset: 0x0001B04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643960, XrefRangeEnd = 643962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long HashStringWithFNV1A64(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000339B File Offset: 0x0000159B
		public BurstRuntime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0;

		// Token: 0x020003CC RID: 972
		public sealed class HashCode64<T> : ValueType
		{
			// Token: 0x06003097 RID: 12439 RVA: 0x000B7664 File Offset: 0x000B5864
			// Note: this type is marked as 'beforefieldinit'.
			static HashCode64()
			{
				Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "HashCode64`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr);
				BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr, "Value");
			}

			// Token: 0x06003098 RID: 12440 RVA: 0x000138BA File Offset: 0x00011ABA
			public HashCode64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003099 RID: 12441 RVA: 0x000138C3 File Offset: 0x00011AC3
			public HashCode64()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A05 RID: 2565
			// (get) Token: 0x0600309A RID: 12442 RVA: 0x000B76E0 File Offset: 0x000B58E0
			// (set) Token: 0x0600309B RID: 12443 RVA: 0x000138D5 File Offset: 0x00011AD5
			public unsafe static long Value
			{
				get
				{
					long num;
					IL2CPP.il2cpp_field_static_get_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*)(&value));
				}
			}

			// Token: 0x04002AFF RID: 11007
			private static readonly IntPtr NativeFieldInfoPtr_Value;
		}

		// Token: 0x020003CD RID: 973
		private sealed class MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>
		{
			// Token: 0x04002B00 RID: 11008
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0, Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
