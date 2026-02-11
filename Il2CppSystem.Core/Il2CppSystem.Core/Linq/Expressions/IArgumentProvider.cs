using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200004B RID: 75
	public class IArgumentProvider : Il2CppObjectBase
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x000274E0 File Offset: 0x000256E0
		// Note: this type is marked as 'beforefieldinit'.
		static IArgumentProvider()
		{
			Il2CppClassPointerStore<IArgumentProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "IArgumentProvider");
			IArgumentProvider.NativeMethodInfoPtr_GetArgument_Public_Abstract_Virtual_New_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArgumentProvider>.NativeClassPtr, 100664389);
			IArgumentProvider.NativeMethodInfoPtr_get_ArgumentCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArgumentProvider>.NativeClassPtr, 100664390);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00027530 File Offset: 0x00025730
		[CallerCount(0)]
		public unsafe virtual Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IArgumentProvider.NativeMethodInfoPtr_GetArgument_Public_Abstract_Virtual_New_Expression_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00027588 File Offset: 0x00025788
		public unsafe virtual int ArgumentCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IArgumentProvider.NativeMethodInfoPtr_get_ArgumentCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002F27 File Offset: 0x00001127
		public IArgumentProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Abstract_Virtual_New_Expression_Int32_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
