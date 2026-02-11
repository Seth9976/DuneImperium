using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x02000046 RID: 70
	public static class SafeHandleCache<T> : Object where T : SafeHandle
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x00035078 File Offset: 0x00033278
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandleCache()
		{
			Il2CppClassPointerStore<SafeHandleCache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeHandleCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleCache<T>>.NativeClassPtr);
			SafeHandleCache<T>.NativeFieldInfoPtr_s_invalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandleCache<T>>.NativeClassPtr, "s_invalidHandle");
			SafeHandleCache<T>.NativeMethodInfoPtr_IsCachedInvalidHandle_Internal_Static_Boolean_SafeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleCache<T>>.NativeClassPtr, 100663884);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0003510C File Offset: 0x0003330C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281055, RefRangeEnd = 1281056, XrefRangeStart = 1281052, XrefRangeEnd = 1281055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCachedInvalidHandle(SafeHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandleCache<T>.NativeMethodInfoPtr_IsCachedInvalidHandle_Internal_Static_Boolean_SafeHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000377A File Offset: 0x0000197A
		public SafeHandleCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00035150 File Offset: 0x00033350
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00035174 File Offset: 0x00033374
		public unsafe static T s_invalidHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeHandleCache<T>.NativeFieldInfoPtr_s_invalidHandle, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_invalidHandle = SafeHandleCache<T>.NativeFieldInfoPtr_s_invalidHandle;
				ref T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_s_invalidHandle, (void*)(&ptr2));
			}
		}

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_s_invalidHandle;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_IsCachedInvalidHandle_Internal_Static_Boolean_SafeHandle_0;
	}
}
