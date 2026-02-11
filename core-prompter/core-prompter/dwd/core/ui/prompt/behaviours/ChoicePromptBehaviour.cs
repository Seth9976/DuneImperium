using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000036 RID: 54
	public class ChoicePromptBehaviour<TChoice> : PromptBehaviour<IChoicePrompt<TChoice>>
	{
		// Token: 0x06000206 RID: 518 RVA: 0x0000A660 File Offset: 0x00008860
		// Note: this type is marked as 'beforefieldinit'.
		static ChoicePromptBehaviour()
		{
			Il2CppClassPointerStore<ChoicePromptBehaviour<TChoice>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "ChoicePromptBehaviour`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TChoice>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChoicePromptBehaviour<TChoice>>.NativeClassPtr);
			ChoicePromptBehaviour<TChoice>.NativeMethodInfoPtr_Event_Resolve_Public_Void_TChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoicePromptBehaviour<TChoice>>.NativeClassPtr, 100663527);
			ChoicePromptBehaviour<TChoice>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoicePromptBehaviour<TChoice>>.NativeClassPtr, 100663528);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000A6F4 File Offset: 0x000088F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214364, XrefRangeEnd = 1214373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Resolve(TChoice choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TChoice).IsValueType)
				{
					TChoice tchoice = choice;
					intPtr = ((tchoice is string) ? IL2CPP.ManagedStringToIl2Cpp(tchoice as string) : IL2CPP.Il2CppObjectBaseToPtr(tchoice as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref choice;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChoicePromptBehaviour<TChoice>.NativeMethodInfoPtr_Event_Resolve_Public_Void_TChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000A76C File Offset: 0x0000896C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1214374, RefRangeEnd = 1214377, XrefRangeStart = 1214373, XrefRangeEnd = 1214374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChoicePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChoicePromptBehaviour<TChoice>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChoicePromptBehaviour<TChoice>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000030BE File Offset: 0x000012BE
		public ChoicePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_Event_Resolve_Public_Void_TChoice_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
