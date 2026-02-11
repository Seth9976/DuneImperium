using System;
using dwd.core.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace core.input.util
{
	// Token: 0x0200000C RID: 12
	public class GameObjectInputUtil : Object
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00008024 File Offset: 0x00006224
		// Note: this type is marked as 'beforefieldinit'.
		static GameObjectInputUtil()
		{
			Il2CppClassPointerStore<GameObjectInputUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "core.input.util", "GameObjectInputUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectInputUtil>.NativeClassPtr);
			GameObjectInputUtil.NativeMethodInfoPtr_GetInterfaceFromSample_Public_Static_T_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectInputUtil>.NativeClassPtr, 100663333);
			GameObjectInputUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectInputUtil>.NativeClassPtr, 100663334);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000807C File Offset: 0x0000627C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119086, XrefRangeEnd = 1119106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetInterfaceFromSample<T>(InputSample sample) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sample));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectInputUtil.MethodInfoStoreGeneric_GetInterfaceFromSample_Public_Static_T_InputSample_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000080C0 File Offset: 0x000062C0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectInputUtil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectInputUtil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectInputUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000220D File Offset: 0x0000040D
		public GameObjectInputUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaceFromSample_Public_Static_T_InputSample_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B4 RID: 180
		private sealed class MethodInfoStoreGeneric_GetInterfaceFromSample_Public_Static_T_InputSample_0<T>
		{
			// Token: 0x040004F7 RID: 1271
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectInputUtil.NativeMethodInfoPtr_GetInterfaceFromSample_Public_Static_T_InputSample_0, Il2CppClassPointerStore<GameObjectInputUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
