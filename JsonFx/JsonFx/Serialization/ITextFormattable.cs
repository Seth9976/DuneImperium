using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;

namespace JsonFx.Serialization
{
	// Token: 0x02000009 RID: 9
	public class ITextFormattable : Il2CppObjectBase
	{
		// Token: 0x0600004C RID: 76 RVA: 0x000021C5 File Offset: 0x000003C5
		// Note: this type is marked as 'beforefieldinit'.
		static ITextFormattable()
		{
			Il2CppClassPointerStore<ITextFormattable>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "ITextFormattable");
			ITextFormattable.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_Void_ITextFormatter_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextFormattable>.NativeClassPtr, 100663340);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004EC8 File Offset: 0x000030C8
		[CallerCount(0)]
		public unsafe virtual void Format(ITextFormatter formatter, TextWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextFormattable.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_Void_ITextFormatter_TextWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021F4 File Offset: 0x000003F4
		public ITextFormattable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_Void_ITextFormatter_TextWriter_0;
	}
}
