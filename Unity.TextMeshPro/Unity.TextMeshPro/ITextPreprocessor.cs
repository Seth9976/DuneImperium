using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace TMPro
{
	// Token: 0x02000007 RID: 7
	public class ITextPreprocessor : Il2CppObjectBase
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002175 File Offset: 0x00000375
		// Note: this type is marked as 'beforefieldinit'.
		static ITextPreprocessor()
		{
			Il2CppClassPointerStore<ITextPreprocessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ITextPreprocessor");
			ITextPreprocessor.NativeMethodInfoPtr_PreprocessText_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextPreprocessor>.NativeClassPtr, 100663315);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000A9C0 File Offset: 0x00008BC0
		[CallerCount(0)]
		public unsafe virtual string PreprocessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextPreprocessor.NativeMethodInfoPtr_PreprocessText_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021A4 File Offset: 0x000003A4
		public ITextPreprocessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessText_Public_Abstract_Virtual_New_String_String_0;
	}
}
