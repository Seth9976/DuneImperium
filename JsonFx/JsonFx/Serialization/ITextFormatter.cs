using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace JsonFx.Serialization
{
	// Token: 0x0200000A RID: 10
	public class ITextFormatter : Il2CppObjectBase
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00004F28 File Offset: 0x00003128
		// Note: this type is marked as 'beforefieldinit'.
		static ITextFormatter()
		{
			Il2CppClassPointerStore<ITextFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "ITextFormatter");
			ITextFormatter.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_Void_IEnumerable_1_Token_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextFormatter>.NativeClassPtr, 100663341);
			ITextFormatter.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextFormatter>.NativeClassPtr, 100663342);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004F78 File Offset: 0x00003178
		[CallerCount(0)]
		public unsafe virtual void Format(IEnumerable<Token> tokens, TextWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextFormatter.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_Void_IEnumerable_1_Token_TextWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004FD8 File Offset: 0x000031D8
		[CallerCount(0)]
		public unsafe virtual string Format(IEnumerable<Token> tokens)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextFormatter.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_IEnumerable_1_Token_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000021FD File Offset: 0x000003FD
		public ITextFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_Void_IEnumerable_1_Token_TextWriter_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_IEnumerable_1_Token_0;
	}
}
