using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace worm.canis.actions
{
	// Token: 0x0200025B RID: 603
	public static class IHasActionLogModeDecorators : Object
	{
		// Token: 0x060019E6 RID: 6630 RVA: 0x0000B246 File Offset: 0x00009446
		// Note: this type is marked as 'beforefieldinit'.
		static IHasActionLogModeDecorators()
		{
			Il2CppClassPointerStore<IHasActionLogModeDecorators>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "IHasActionLogModeDecorators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IHasActionLogModeDecorators>.NativeClassPtr);
			IHasActionLogModeDecorators.NativeMethodInfoPtr_WithLoggingMode_Public_Static_TLoggingAction_TLoggingAction_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasActionLogModeDecorators>.NativeClassPtr, 100668065);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000BD968 File Offset: 0x000BBB68
		[CallerCount(280)]
		[CachedScanResults(RefRangeStart = 138395, RefRangeEnd = 138675, XrefRangeStart = 138392, XrefRangeEnd = 138395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TLoggingAction WithLoggingMode<TLoggingAction>(this TLoggingAction loggingAction, ActionLogModes logMode) where TLoggingAction : Canis.actions.Action
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TLoggingAction).IsValueType)
				{
					TLoggingAction tloggingAction = loggingAction;
					intPtr = ((tloggingAction is string) ? IL2CPP.ManagedStringToIl2Cpp(tloggingAction as string) : IL2CPP.Il2CppObjectBaseToPtr(tloggingAction as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref loggingAction;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logMode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IHasActionLogModeDecorators.MethodInfoStoreGeneric_WithLoggingMode_Public_Static_TLoggingAction_TLoggingAction_ActionLogModes_0<TLoggingAction>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TLoggingAction>(intPtr2, false, true);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0000B27F File Offset: 0x0000947F
		public IHasActionLogModeDecorators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_WithLoggingMode_Public_Static_TLoggingAction_TLoggingAction_ActionLogModes_0;

		// Token: 0x02000693 RID: 1683
		private sealed class MethodInfoStoreGeneric_WithLoggingMode_Public_Static_TLoggingAction_TLoggingAction_ActionLogModes_0<TLoggingAction>
		{
			// Token: 0x04003949 RID: 14665
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IHasActionLogModeDecorators.NativeMethodInfoPtr_WithLoggingMode_Public_Static_TLoggingAction_TLoggingAction_ActionLogModes_0, Il2CppClassPointerStore<IHasActionLogModeDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLoggingAction>.NativeClassPtr)) }))));
		}
	}
}
