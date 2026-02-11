using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000023 RID: 35
	public class IResolvablePrompt<TResult> : Il2CppObjectBase
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00007F8C File Offset: 0x0000618C
		// Note: this type is marked as 'beforefieldinit'.
		static IResolvablePrompt()
		{
			Il2CppClassPointerStore<IResolvablePrompt<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IResolvablePrompt`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IResolvablePrompt<TResult>.NativeMethodInfoPtr_get_Result_Public_Abstract_Virtual_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolvablePrompt<TResult>>.NativeClassPtr, 100663420);
			IResolvablePrompt<TResult>.NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolvablePrompt<TResult>>.NativeClassPtr, 100663421);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00008018 File Offset: 0x00006218
		public unsafe virtual TResult Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolvablePrompt<TResult>.NativeMethodInfoPtr_get_Result_Public_Abstract_Virtual_New_get_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000805C File Offset: 0x0000625C
		[CallerCount(0)]
		public unsafe virtual void Resolve(TResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolvablePrompt<TResult>.NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Void_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002AF3 File Offset: 0x00000CF3
		public IResolvablePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Abstract_Virtual_New_get_TResult_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Void_TResult_0;
	}
}
