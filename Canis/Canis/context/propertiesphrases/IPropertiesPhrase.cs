using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000149 RID: 329
	public class IPropertiesPhrase : Il2CppObjectBase
	{
		// Token: 0x06000E9C RID: 3740 RVA: 0x000075BE File Offset: 0x000057BE
		// Note: this type is marked as 'beforefieldinit'.
		static IPropertiesPhrase()
		{
			Il2CppClassPointerStore<IPropertiesPhrase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "IPropertiesPhrase");
			IPropertiesPhrase.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertiesPhrase>.NativeClassPtr, 100666441);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00057110 File Offset: 0x00055310
		[CallerCount(0)]
		public unsafe virtual bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertiesPhrase.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000075ED File Offset: 0x000057ED
		public IPropertiesPhrase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_Context_0;
	}
}
