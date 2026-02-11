using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus.sequences
{
	// Token: 0x0200008E RID: 142
	public class ISequenceAttributeHandler : Il2CppObjectBase
	{
		// Token: 0x0600088E RID: 2190 RVA: 0x000062A6 File Offset: 0x000044A6
		// Note: this type is marked as 'beforefieldinit'.
		static ISequenceAttributeHandler()
		{
			Il2CppClassPointerStore<ISequenceAttributeHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus.sequences", "ISequenceAttributeHandler");
			ISequenceAttributeHandler.NativeMethodInfoPtr_HandleAttributes_Public_Abstract_Virtual_New_Void_String_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceAttributeHandler>.NativeClassPtr, 100664543);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00025EFC File Offset: 0x000240FC
		[CallerCount(0)]
		public unsafe virtual void HandleAttributes(string sequenceName, IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISequenceAttributeHandler.NativeMethodInfoPtr_HandleAttributes_Public_Abstract_Virtual_New_Void_String_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000062D5 File Offset: 0x000044D5
		public ISequenceAttributeHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_HandleAttributes_Public_Abstract_Virtual_New_Void_String_IHasAttributes_0;
	}
}
