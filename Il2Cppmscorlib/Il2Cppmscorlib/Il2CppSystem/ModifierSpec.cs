using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x0200016F RID: 367
	public class ModifierSpec : Il2CppObjectBase
	{
		// Token: 0x060018CE RID: 6350 RVA: 0x0009AC9C File Offset: 0x00098E9C
		// Note: this type is marked as 'beforefieldinit'.
		static ModifierSpec()
		{
			Il2CppClassPointerStore<ModifierSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ModifierSpec");
			ModifierSpec.NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierSpec>.NativeClassPtr, 100667591);
			ModifierSpec.NativeMethodInfoPtr_Append_Public_Abstract_Virtual_New_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierSpec>.NativeClassPtr, 100667592);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0009ACEC File Offset: 0x00098EEC
		[CallerCount(0)]
		public unsafe virtual Type Resolve(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModifierSpec.NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0009AD48 File Offset: 0x00098F48
		[CallerCount(0)]
		public unsafe virtual StringBuilder Append(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModifierSpec.NativeMethodInfoPtr_Append_Public_Abstract_Virtual_New_StringBuilder_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00007FC6 File Offset: 0x000061C6
		public ModifierSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Type_Type_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Abstract_Virtual_New_StringBuilder_StringBuilder_0;
	}
}
