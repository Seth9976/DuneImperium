using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200031F RID: 799
	public class ISurrogateSelector : Il2CppObjectBase
	{
		// Token: 0x060030D1 RID: 12497 RVA: 0x00010C8E File Offset: 0x0000EE8E
		// Note: this type is marked as 'beforefieldinit'.
		static ISurrogateSelector()
		{
			Il2CppClassPointerStore<ISurrogateSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISurrogateSelector");
			ISurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurrogateSelector>.NativeClassPtr, 100670985);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000F89F4 File Offset: 0x000F6BF4
		[CallerCount(0)]
		public unsafe virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			selector = ((intPtr4 == 0) ? null : new ISurrogateSelector(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr5) : null;
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x00010CBD File Offset: 0x0000EEBD
		public ISurrogateSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002841 RID: 10305
		private static readonly IntPtr NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0;
	}
}
