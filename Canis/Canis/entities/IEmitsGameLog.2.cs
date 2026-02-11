using System;
using Canis.gameLogs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000E0 RID: 224
	public class IEmitsGameLog<TGameLogBuilderParam> : Il2CppObjectBase
	{
		// Token: 0x06000A3A RID: 2618 RVA: 0x00044CBC File Offset: 0x00042EBC
		// Note: this type is marked as 'beforefieldinit'.
		static IEmitsGameLog()
		{
			Il2CppClassPointerStore<IEmitsGameLog<TGameLogBuilderParam>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IEmitsGameLog`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameLogBuilderParam>.NativeClassPtr)) })).TypeHandle.value);
			IEmitsGameLog<TGameLogBuilderParam>.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_IHasUndoableGameLogsAndFactory_1_TGameLogBuilderParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEmitsGameLog<TGameLogBuilderParam>>.NativeClassPtr, 100665452);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00044D34 File Offset: 0x00042F34
		[CallerCount(0)]
		public unsafe virtual GameLogBuilder MakeGameLogBuilder(IHasUndoableGameLogsAndFactory<TGameLogBuilderParam> hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEmitsGameLog<TGameLogBuilderParam>.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_IHasUndoableGameLogsAndFactory_1_TGameLogBuilderParam_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public IEmitsGameLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_IHasUndoableGameLogsAndFactory_1_TGameLogBuilderParam_0;
	}
}
