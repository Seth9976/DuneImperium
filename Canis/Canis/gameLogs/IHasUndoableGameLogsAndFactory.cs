using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.gameLogs
{
	// Token: 0x020000A7 RID: 167
	public class IHasUndoableGameLogsAndFactory<TGameLogBuilderParam> : Il2CppObjectBase
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x00039B58 File Offset: 0x00037D58
		// Note: this type is marked as 'beforefieldinit'.
		static IHasUndoableGameLogsAndFactory()
		{
			Il2CppClassPointerStore<IHasUndoableGameLogsAndFactory<TGameLogBuilderParam>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "IHasUndoableGameLogsAndFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameLogBuilderParam>.NativeClassPtr)) })).TypeHandle.value);
			IHasUndoableGameLogsAndFactory<TGameLogBuilderParam>.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_TGameLogBuilderParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableGameLogsAndFactory<TGameLogBuilderParam>>.NativeClassPtr, 100664929);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00039BD0 File Offset: 0x00037DD0
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableGameLogsAndFactory<TGameLogBuilderParam>.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_TGameLogBuilderParam_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr4) : null;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000051EA File Offset: 0x000033EA
		public IHasUndoableGameLogsAndFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_TGameLogBuilderParam_0;
	}
}
