using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Properties
{
	// Token: 0x0200001B RID: 27
	public class ITypeVisitor : Il2CppObjectBase
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x000026AC File Offset: 0x000008AC
		// Note: this type is marked as 'beforefieldinit'.
		static ITypeVisitor()
		{
			Il2CppClassPointerStore<ITypeVisitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "ITypeVisitor");
			ITypeVisitor.NativeMethodInfoPtr_Visit_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITypeVisitor>.NativeClassPtr, 100663383);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000605C File Offset: 0x0000425C
		[CallerCount(0)]
		public unsafe virtual void Visit<TContainer>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITypeVisitor.MethodInfoStoreGeneric_Visit_Public_Abstract_Virtual_New_Void_0<TContainer>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000026DB File Offset: 0x000008DB
		public ITypeVisitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Visit_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x02000066 RID: 102
		private sealed class MethodInfoStoreGeneric_Visit_Public_Abstract_Virtual_New_Void_0<TContainer>
		{
			// Token: 0x04000100 RID: 256
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ITypeVisitor.NativeMethodInfoPtr_Visit_Public_Abstract_Virtual_New_Void_0, Il2CppClassPointerStore<ITypeVisitor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) }))));
		}
	}
}
