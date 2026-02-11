using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace boardgames.data
{
	// Token: 0x02000141 RID: 321
	public class ILoadDataCommand : Il2CppObjectBase
	{
		// Token: 0x06001090 RID: 4240 RVA: 0x00043FA8 File Offset: 0x000421A8
		// Note: this type is marked as 'beforefieldinit'.
		static ILoadDataCommand()
		{
			Il2CppClassPointerStore<ILoadDataCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "ILoadDataCommand");
			ILoadDataCommand.NativeMethodInfoPtr_Result_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoadDataCommand>.NativeClassPtr, 100665722);
			ILoadDataCommand.NativeMethodInfoPtr_Create_Public_Static_ILoadDataCommand_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoadDataCommand>.NativeClassPtr, 100665723);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00043FF8 File Offset: 0x000421F8
		[CallerCount(0)]
		public unsafe virtual T Result<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILoadDataCommand.MethodInfoStoreGeneric_Result_Public_Abstract_Virtual_New_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0004403C File Offset: 0x0004223C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 999380, RefRangeEnd = 999383, XrefRangeStart = 999361, XrefRangeEnd = 999380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ILoadDataCommand Create(string path, Type loadType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILoadDataCommand.NativeMethodInfoPtr_Create_Public_Static_ILoadDataCommand_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILoadDataCommand>(intPtr3) : null;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00009ACA File Offset: 0x00007CCA
		public ILoadDataCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_Result_Public_Abstract_Virtual_New_T_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ILoadDataCommand_String_Type_0;

		// Token: 0x02000271 RID: 625
		private sealed class MethodInfoStoreGeneric_Result_Public_Abstract_Virtual_New_T_0<T>
		{
			// Token: 0x04001188 RID: 4488
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ILoadDataCommand.NativeMethodInfoPtr_Result_Public_Abstract_Virtual_New_T_0, Il2CppClassPointerStore<ILoadDataCommand>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
