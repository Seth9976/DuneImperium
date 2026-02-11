using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000289 RID: 649
	[StructLayout(2)]
	public struct MatchResultInfo
	{
		// Token: 0x060030B6 RID: 12470 RVA: 0x000CEDC0 File Offset: 0x000CCFC0
		// Note: this type is marked as 'beforefieldinit'.
		static MatchResultInfo()
		{
			Il2CppClassPointerStore<MatchResultInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "MatchResultInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchResultInfo>.NativeClassPtr);
			MatchResultInfo.NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchResultInfo>.NativeClassPtr, "success");
			MatchResultInfo.NativeFieldInfoPtr_triggerPseudoMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchResultInfo>.NativeClassPtr, "triggerPseudoMask");
			MatchResultInfo.NativeFieldInfoPtr_dependencyPseudoMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchResultInfo>.NativeClassPtr, "dependencyPseudoMask");
			MatchResultInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_PseudoStates_PseudoStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchResultInfo>.NativeClassPtr, 100670369);
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x000CEE40 File Offset: 0x000CD040
		[CallerCount(0)]
		public unsafe MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerPseudoMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependencyPseudoMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchResultInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_PseudoStates_PseudoStates_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00013E77 File Offset: 0x00012077
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MatchResultInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeFieldInfoPtr_success;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeFieldInfoPtr_triggerPseudoMask;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeFieldInfoPtr_dependencyPseudoMask;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_PseudoStates_PseudoStates_0;

		// Token: 0x04002393 RID: 9107
		[FieldOffset(0)]
		[MarshalAs(4)]
		public readonly bool success;

		// Token: 0x04002394 RID: 9108
		[FieldOffset(4)]
		public readonly PseudoStates triggerPseudoMask;

		// Token: 0x04002395 RID: 9109
		[FieldOffset(8)]
		public readonly PseudoStates dependencyPseudoMask;
	}
}
