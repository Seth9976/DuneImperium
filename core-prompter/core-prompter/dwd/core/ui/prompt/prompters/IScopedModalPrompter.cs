using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.ui.prompt.prompters
{
	// Token: 0x0200000E RID: 14
	public class IScopedModalPrompter<TScopes> : Il2CppObjectBase
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000597C File Offset: 0x00003B7C
		// Note: this type is marked as 'beforefieldinit'.
		static IScopedModalPrompter()
		{
			Il2CppClassPointerStore<IScopedModalPrompter<TScopes>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompters", "IScopedModalPrompter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScopes>.NativeClassPtr)) })).TypeHandle.value);
			IScopedModalPrompter<TScopes>.NativeMethodInfoPtr_HandlesScope_Public_Abstract_Virtual_New_Boolean_TScopes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScopedModalPrompter<TScopes>>.NativeClassPtr, 100663361);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000059F4 File Offset: 0x00003BF4
		[CallerCount(0)]
		public unsafe virtual bool HandlesScope(TScopes scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TScopes).IsValueType)
				{
					TScopes tscopes = scope;
					intPtr = ((tscopes is string) ? IL2CPP.ManagedStringToIl2Cpp(tscopes as string) : IL2CPP.Il2CppObjectBaseToPtr(tscopes as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref scope;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScopedModalPrompter<TScopes>.NativeMethodInfoPtr_HandlesScope_Public_Abstract_Virtual_New_Boolean_TScopes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000023B5 File Offset: 0x000005B5
		public IScopedModalPrompter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_HandlesScope_Public_Abstract_Virtual_New_Boolean_TScopes_0;
	}
}
