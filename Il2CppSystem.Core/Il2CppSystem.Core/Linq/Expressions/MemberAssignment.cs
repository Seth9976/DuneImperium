using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000063 RID: 99
	public sealed class MemberAssignment : MemberBinding
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x0002B3D8 File Offset: 0x000295D8
		// Note: this type is marked as 'beforefieldinit'.
		static MemberAssignment()
		{
			Il2CppClassPointerStore<MemberAssignment>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MemberAssignment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberAssignment>.NativeClassPtr);
			MemberAssignment.NativeFieldInfoPtr__expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberAssignment>.NativeClassPtr, "_expression");
			MemberAssignment.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberAssignment>.NativeClassPtr, 100664505);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0002B430 File Offset: 0x00029630
		public unsafe Expression Expression
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberAssignment.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000034D3 File Offset: 0x000016D3
		public MemberAssignment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0002B470 File Offset: 0x00029670
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x000034DC File Offset: 0x000016DC
		public unsafe Expression _expression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberAssignment.NativeFieldInfoPtr__expression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberAssignment.NativeFieldInfoPtr__expression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr__expression;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_get_Expression_Public_get_Expression_0;
	}
}
