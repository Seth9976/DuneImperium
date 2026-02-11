using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000024 RID: 36
	public class IChoicePrompt<TChoice> : Il2CppObjectBase
	{
		// Token: 0x0600015B RID: 347 RVA: 0x000080E0 File Offset: 0x000062E0
		// Note: this type is marked as 'beforefieldinit'.
		static IChoicePrompt()
		{
			Il2CppClassPointerStore<IChoicePrompt<TChoice>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IChoicePrompt`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TChoice>.NativeClassPtr)) })).TypeHandle.value);
			IChoicePrompt<TChoice>.NativeMethodInfoPtr_get_ValidChoices_Public_Abstract_Virtual_New_get_IEnumerable_1_TChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChoicePrompt<TChoice>>.NativeClassPtr, 100663422);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00008158 File Offset: 0x00006358
		public unsafe virtual IEnumerable<TChoice> ValidChoices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChoicePrompt<TChoice>.NativeMethodInfoPtr_get_ValidChoices_Public_Abstract_Virtual_New_get_IEnumerable_1_TChoice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TChoice>>(intPtr3) : null;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002AFC File Offset: 0x00000CFC
		public IChoicePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidChoices_Public_Abstract_Virtual_New_get_IEnumerable_1_TChoice_0;
	}
}
