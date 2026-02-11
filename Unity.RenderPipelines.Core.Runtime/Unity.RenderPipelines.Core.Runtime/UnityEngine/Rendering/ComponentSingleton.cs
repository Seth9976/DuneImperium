using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000036 RID: 54
	public static class ComponentSingleton<TType> : Object where TType : Component
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
		// Note: this type is marked as 'beforefieldinit'.
		static ComponentSingleton()
		{
			Il2CppClassPointerStore<ComponentSingleton<TType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ComponentSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentSingleton<TType>>.NativeClassPtr);
			ComponentSingleton<TType>.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentSingleton<TType>>.NativeClassPtr, "s_Instance");
			ComponentSingleton<TType>.NativeMethodInfoPtr_get_instance_Public_Static_get_TType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<TType>>.NativeClassPtr, 100663854);
			ComponentSingleton<TType>.NativeMethodInfoPtr_Release_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<TType>>.NativeClassPtr, 100663855);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001E268 File Offset: 0x0001C468
		public unsafe static TType instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959030, XrefRangeEnd = 959062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<TType>.NativeMethodInfoPtr_get_instance_Public_Static_get_TType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TType>(intPtr, false, true);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001E298 File Offset: 0x0001C498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959062, XrefRangeEnd = 959077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<TType>.NativeMethodInfoPtr_Release_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00003F46 File Offset: 0x00002146
		public ComponentSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001E2C0 File Offset: 0x0001C4C0
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
		public unsafe static TType s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ComponentSingleton<TType>.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<TType>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_Instance = ComponentSingleton<TType>.NativeFieldInfoPtr_s_Instance;
				ref TType ptr2;
				if (!typeof(TType).IsValueType)
				{
					TType ttype = value;
					if (!(ttype is string))
					{
						ref TType ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ttype as Il2CppObjectBase));
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
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(ttype as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_s_Instance, (void*)(&ptr2));
			}
		}

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TType_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_0;
	}
}
