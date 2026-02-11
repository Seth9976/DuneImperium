using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x0200003E RID: 62
	public class ResolvablePromptBehaviour<TResult> : PromptBehaviour<IResolvablePrompt<TResult>>
	{
		// Token: 0x0600024E RID: 590 RVA: 0x0000B5D4 File Offset: 0x000097D4
		// Note: this type is marked as 'beforefieldinit'.
		static ResolvablePromptBehaviour()
		{
			Il2CppClassPointerStore<ResolvablePromptBehaviour<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "ResolvablePromptBehaviour`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolvablePromptBehaviour<TResult>>.NativeClassPtr);
			ResolvablePromptBehaviour<TResult>.NativeMethodInfoPtr_Event_Resolve_Public_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolvablePromptBehaviour<TResult>>.NativeClassPtr, 100663575);
			ResolvablePromptBehaviour<TResult>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolvablePromptBehaviour<TResult>>.NativeClassPtr, 100663576);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000B668 File Offset: 0x00009868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214769, XrefRangeEnd = 1214788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Resolve(TResult result)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResolvablePromptBehaviour<TResult>.NativeMethodInfoPtr_Event_Resolve_Public_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000B6E0 File Offset: 0x000098E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1214789, RefRangeEnd = 1214792, XrefRangeStart = 1214788, XrefRangeEnd = 1214789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolvablePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolvablePromptBehaviour<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolvablePromptBehaviour<TResult>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000329A File Offset: 0x0000149A
		public ResolvablePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_Event_Resolve_Public_Void_TResult_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
