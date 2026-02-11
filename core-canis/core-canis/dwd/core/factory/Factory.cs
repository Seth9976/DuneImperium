using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.factory
{
	// Token: 0x020001A8 RID: 424
	public static class Factory : Object
	{
		// Token: 0x06001817 RID: 6167 RVA: 0x00074464 File Offset: 0x00072664
		// Note: this type is marked as 'beforefieldinit'.
		static Factory()
		{
			Il2CppClassPointerStore<Factory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.factory", "Factory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Factory>.NativeClassPtr);
			Factory.NativeFieldInfoPtr__generatorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Factory>.NativeClassPtr, "_generatorMap");
			Factory.NativeMethodInfoPtr_Register_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Factory>.NativeClassPtr, 100667147);
			Factory.NativeMethodInfoPtr_Create_Public_Static_TInstance_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Factory>.NativeClassPtr, 100667148);
			Factory.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_byref_TInstance_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Factory>.NativeClassPtr, 100667149);
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x000744E4 File Offset: 0x000726E4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 880191, RefRangeEnd = 880201, XrefRangeStart = 880142, XrefRangeEnd = 880191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register<TParent, TInstance>(bool overwrite = false) where TInstance : TParent
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overwrite;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Factory.MethodInfoStoreGeneric_Register_Public_Static_Void_Boolean_0<TParent, TInstance>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00074518 File Offset: 0x00072718
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 880206, RefRangeEnd = 880218, XrefRangeStart = 880201, XrefRangeEnd = 880206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TInstance Create<TInstance>([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Factory.MethodInfoStoreGeneric_Create_Public_Static_TInstance_Il2CppReferenceArray_1_Object_0<TInstance>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TInstance>(intPtr, false, true);
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00074564 File Offset: 0x00072764
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 880230, RefRangeEnd = 880235, XrefRangeStart = 880218, XrefRangeEnd = 880230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate<TInstance>(out TInstance instance, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr2;
				if (!typeof(TInstance).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref instance;
				}
				ptr2 = intPtr2;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Factory.MethodInfoStoreGeneric_TryCreate_Public_Static_Boolean_byref_TInstance_Il2CppReferenceArray_1_Object_0<TInstance>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TInstance).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				instance = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TInstance>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0000A926 File Offset: 0x00008B26
		public static TInstance Create<TInstance>(params Object[] args)
		{
			return Factory.Create(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0000A933 File Offset: 0x00008B33
		public static bool TryCreate<TInstance>(out TInstance instance, params Object[] args)
		{
			return Factory.TryCreate(out instance, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0000A941 File Offset: 0x00008B41
		public Factory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x00074604 File Offset: 0x00072804
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x0000A94A File Offset: 0x00008B4A
		public unsafe static Dictionary<Type, Type> _generatorMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Factory.NativeFieldInfoPtr__generatorMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Factory.NativeFieldInfoPtr__generatorMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeFieldInfoPtr__generatorMap;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_Boolean_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TInstance_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_byref_TInstance_Il2CppReferenceArray_1_Object_0;

		// Token: 0x02000353 RID: 851
		private sealed class MethodInfoStoreGeneric_Register_Public_Static_Void_Boolean_0<TParent, TInstance>
		{
			// Token: 0x04001A8F RID: 6799
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Factory.NativeMethodInfoPtr_Register_Public_Static_Void_Boolean_0, Il2CppClassPointerStore<Factory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TParent>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000354 RID: 852
		private sealed class MethodInfoStoreGeneric_Create_Public_Static_TInstance_Il2CppReferenceArray_1_Object_0<TInstance>
		{
			// Token: 0x04001A90 RID: 6800
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Factory.NativeMethodInfoPtr_Create_Public_Static_TInstance_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<Factory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr)) }))));
		}

		// Token: 0x02000355 RID: 853
		private sealed class MethodInfoStoreGeneric_TryCreate_Public_Static_Boolean_byref_TInstance_Il2CppReferenceArray_1_Object_0<TInstance>
		{
			// Token: 0x04001A91 RID: 6801
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Factory.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_byref_TInstance_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<Factory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr)) }))));
		}
	}
}
