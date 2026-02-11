using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Properties.Internal
{
	// Token: 0x02000033 RID: 51
	public class ReflectedPropertyBag<TContainer> : ContainerPropertyBag<TContainer>
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00007980 File Offset: 0x00005B80
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectedPropertyBag()
		{
			Il2CppClassPointerStore<ReflectedPropertyBag<TContainer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "ReflectedPropertyBag`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectedPropertyBag<TContainer>>.NativeClassPtr);
			ReflectedPropertyBag<TContainer>.NativeMethodInfoPtr_AddProperty_Internal_Void_Property_2_TContainer_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBag<TContainer>>.NativeClassPtr, 100663533);
			ReflectedPropertyBag<TContainer>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBag<TContainer>>.NativeClassPtr, 100663534);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007A14 File Offset: 0x00005C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232739, XrefRangeEnd = 1232753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void AddProperty<TValue>(Property<TContainer, TValue> property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBag<TValue>.MethodInfoStoreGeneric_AddProperty_Internal_Void_Property_2_TContainer_TValue_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007A58 File Offset: 0x00005C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232753, XrefRangeEnd = 1232755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectedPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedPropertyBag<TContainer>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBag<TContainer>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002D04 File Offset: 0x00000F04
		public ReflectedPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_AddProperty_Internal_Void_Property_2_TContainer_TValue_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A0 RID: 160
		private sealed class MethodInfoStoreGeneric_AddProperty_Internal_Void_Property_2_TContainer_TValue_0
		{
			// Token: 0x04000170 RID: 368
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBag<TValue>.NativeMethodInfoPtr_AddProperty_Internal_Void_Property_2_TContainer_TValue_0, Il2CppClassPointerStore<ReflectedPropertyBag<TValue>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
		}
	}
}
