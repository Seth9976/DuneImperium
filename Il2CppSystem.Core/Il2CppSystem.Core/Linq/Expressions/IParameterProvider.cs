using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200004C RID: 76
	public class IParameterProvider : Il2CppObjectBase
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x000275D0 File Offset: 0x000257D0
		// Note: this type is marked as 'beforefieldinit'.
		static IParameterProvider()
		{
			Il2CppClassPointerStore<IParameterProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "IParameterProvider");
			IParameterProvider.NativeMethodInfoPtr_GetParameter_Public_Abstract_Virtual_New_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParameterProvider>.NativeClassPtr, 100664391);
			IParameterProvider.NativeMethodInfoPtr_get_ParameterCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParameterProvider>.NativeClassPtr, 100664392);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00027620 File Offset: 0x00025820
		[CallerCount(0)]
		public unsafe virtual ParameterExpression GetParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IParameterProvider.NativeMethodInfoPtr_GetParameter_Public_Abstract_Virtual_New_ParameterExpression_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00027678 File Offset: 0x00025878
		public unsafe virtual int ParameterCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IParameterProvider.NativeMethodInfoPtr_get_ParameterCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002F30 File Offset: 0x00001130
		public IParameterProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_GetParameter_Public_Abstract_Virtual_New_ParameterExpression_Int32_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterCount_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
