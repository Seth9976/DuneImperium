using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.ui.prompt.prompters
{
	// Token: 0x0200000D RID: 13
	public class IModalPrompter<TPrompt> : Il2CppObjectBase
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00005870 File Offset: 0x00003A70
		// Note: this type is marked as 'beforefieldinit'.
		static IModalPrompter()
		{
			Il2CppClassPointerStore<IModalPrompter<TPrompt>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompters", "IModalPrompter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr)) })).TypeHandle.value);
			IModalPrompter<TPrompt>.NativeMethodInfoPtr_Prompt_Public_Abstract_Virtual_New_IEnumerator_TPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModalPrompter<TPrompt>>.NativeClassPtr, 100663360);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000058E8 File Offset: 0x00003AE8
		[CallerCount(0)]
		public unsafe virtual IEnumerator Prompt(TPrompt prompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TPrompt).IsValueType)
				{
					TPrompt tprompt = prompt;
					intPtr = ((tprompt is string) ? IL2CPP.ManagedStringToIl2Cpp(tprompt as string) : IL2CPP.Il2CppObjectBaseToPtr(tprompt as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref prompt;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IModalPrompter<TPrompt>.NativeMethodInfoPtr_Prompt_Public_Abstract_Virtual_New_IEnumerator_TPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000023AC File Offset: 0x000005AC
		public IModalPrompter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Prompt_Public_Abstract_Virtual_New_IEnumerator_TPrompt_0;
	}
}
