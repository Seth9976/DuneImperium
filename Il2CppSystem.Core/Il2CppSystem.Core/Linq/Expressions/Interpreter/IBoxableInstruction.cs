using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D7 RID: 215
	public class IBoxableInstruction : Il2CppObjectBase
	{
		// Token: 0x06000D71 RID: 3441 RVA: 0x00006117 File Offset: 0x00004317
		// Note: this type is marked as 'beforefieldinit'.
		static IBoxableInstruction()
		{
			Il2CppClassPointerStore<IBoxableInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "IBoxableInstruction");
			IBoxableInstruction.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Abstract_Virtual_New_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBoxableInstruction>.NativeClassPtr, 100665749);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0004BCE4 File Offset: 0x00049EE4
		[CallerCount(0)]
		public unsafe virtual Instruction BoxIfIndexMatches(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBoxableInstruction.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Abstract_Virtual_New_Instruction_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00006146 File Offset: 0x00004346
		public IBoxableInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_BoxIfIndexMatches_Public_Abstract_Virtual_New_Instruction_Int32_0;
	}
}
