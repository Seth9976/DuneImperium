using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace CanisData.generation.templates
{
	// Token: 0x02000024 RID: 36
	public class ITransformsBuilder<BuilderType> : Il2CppObjectBase where BuilderType : ScriptBuilder, new()
	{
		// Token: 0x06000150 RID: 336 RVA: 0x000087B0 File Offset: 0x000069B0
		// Note: this type is marked as 'beforefieldinit'.
		static ITransformsBuilder()
		{
			Il2CppClassPointerStore<ITransformsBuilder<BuilderType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.templates", "ITransformsBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BuilderType>.NativeClassPtr)) })).TypeHandle.value);
			ITransformsBuilder<BuilderType>.NativeMethodInfoPtr_get_Builder_Public_Abstract_Virtual_New_get_BuilderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransformsBuilder<BuilderType>>.NativeClassPtr, 100663467);
			ITransformsBuilder<BuilderType>.NativeMethodInfoPtr_TransformText_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransformsBuilder<BuilderType>>.NativeClassPtr, 100663468);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000883C File Offset: 0x00006A3C
		public unsafe virtual BuilderType Builder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransformsBuilder<BuilderType>.NativeMethodInfoPtr_get_Builder_Public_Abstract_Virtual_New_get_BuilderType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<BuilderType>(intPtr, false, true);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00008880 File Offset: 0x00006A80
		[CallerCount(0)]
		public unsafe virtual string TransformText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransformsBuilder<BuilderType>.NativeMethodInfoPtr_TransformText_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002A81 File Offset: 0x00000C81
		public ITransformsBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_get_Builder_Public_Abstract_Virtual_New_get_BuilderType_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_TransformText_Public_Abstract_Virtual_New_String_0;
	}
}
