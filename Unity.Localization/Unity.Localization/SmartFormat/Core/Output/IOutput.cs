using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Core.Output
{
	// Token: 0x02000080 RID: 128
	public class IOutput : Il2CppObjectBase
	{
		// Token: 0x0600061E RID: 1566 RVA: 0x00020500 File Offset: 0x0001E700
		// Note: this type is marked as 'beforefieldinit'.
		static IOutput()
		{
			Il2CppClassPointerStore<IOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Output", "IOutput");
			IOutput.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOutput>.NativeClassPtr, 100664433);
			IOutput.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Int32_Int32_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOutput>.NativeClassPtr, 100664434);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00020550 File Offset: 0x0001E750
		[CallerCount(0)]
		public unsafe virtual void Write(string text, IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOutput.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000205B0 File Offset: 0x0001E7B0
		[CallerCount(0)]
		public unsafe virtual void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOutput.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Int32_Int32_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000045C4 File Offset: 0x000027C4
		public IOutput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_IFormattingInfo_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Int32_Int32_IFormattingInfo_0;
	}
}
