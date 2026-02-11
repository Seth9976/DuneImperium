using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000B1 RID: 177
	public class ISpanFormattable : Il2CppObjectBase
	{
		// Token: 0x06000BAC RID: 2988 RVA: 0x00004FB0 File Offset: 0x000031B0
		// Note: this type is marked as 'beforefieldinit'.
		static ISpanFormattable()
		{
			Il2CppClassPointerStore<ISpanFormattable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ISpanFormattable");
			ISpanFormattable.NativeMethodInfoPtr_TryFormat_Public_Abstract_Virtual_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpanFormattable>.NativeClassPtr, 100665324);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0005BA78 File Offset: 0x00059C78
		[CallerCount(0)]
		public unsafe virtual bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISpanFormattable.NativeMethodInfoPtr_TryFormat_Public_Abstract_Virtual_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00004FDF File Offset: 0x000031DF
		public ISpanFormattable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Public_Abstract_Virtual_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;
	}
}
