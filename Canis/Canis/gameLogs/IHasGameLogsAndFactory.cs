using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.gameLogs
{
	// Token: 0x020000A6 RID: 166
	public class IHasGameLogsAndFactory<TGameLogBuilderParam> : Il2CppObjectBase
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x00039A3C File Offset: 0x00037C3C
		// Note: this type is marked as 'beforefieldinit'.
		static IHasGameLogsAndFactory()
		{
			Il2CppClassPointerStore<IHasGameLogsAndFactory<TGameLogBuilderParam>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "IHasGameLogsAndFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameLogBuilderParam>.NativeClassPtr)) })).TypeHandle.value);
			IHasGameLogsAndFactory<TGameLogBuilderParam>.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_TGameLogBuilderParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasGameLogsAndFactory<TGameLogBuilderParam>>.NativeClassPtr, 100664928);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00039AB4 File Offset: 0x00037CB4
		[CallerCount(0)]
		public unsafe virtual GameLogBuilder MakeGameLogBuilder(string logToken, TGameLogBuilderParam param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logToken);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TGameLogBuilderParam).IsValueType)
			{
				TGameLogBuilderParam tgameLogBuilderParam = param;
				intPtr = ((tgameLogBuilderParam is string) ? IL2CPP.ManagedStringToIl2Cpp(tgameLogBuilderParam as string) : IL2CPP.Il2CppObjectBaseToPtr(tgameLogBuilderParam as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref param;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasGameLogsAndFactory<TGameLogBuilderParam>.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_TGameLogBuilderParam_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr4) : null;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000051E1 File Offset: 0x000033E1
		public IHasGameLogsAndFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_TGameLogBuilderParam_0;
	}
}
