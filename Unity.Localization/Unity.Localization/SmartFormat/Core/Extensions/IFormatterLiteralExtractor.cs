using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.SmartFormat.Core.Extensions
{
	// Token: 0x0200008A RID: 138
	public class IFormatterLiteralExtractor : Il2CppObjectBase
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x0000497E File Offset: 0x00002B7E
		// Note: this type is marked as 'beforefieldinit'.
		static IFormatterLiteralExtractor()
		{
			Il2CppClassPointerStore<IFormatterLiteralExtractor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Extensions", "IFormatterLiteralExtractor");
			IFormatterLiteralExtractor.NativeMethodInfoPtr_WriteAllLiterals_Public_Abstract_Virtual_New_Void_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatterLiteralExtractor>.NativeClassPtr, 100664524);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00022F28 File Offset: 0x00021128
		[CallerCount(0)]
		public unsafe virtual void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatterLiteralExtractor.NativeMethodInfoPtr_WriteAllLiterals_Public_Abstract_Virtual_New_Void_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000049AD File Offset: 0x00002BAD
		public IFormatterLiteralExtractor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLiterals_Public_Abstract_Virtual_New_Void_IFormattingInfo_0;
	}
}
