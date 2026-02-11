using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.ui
{
	// Token: 0x0200011C RID: 284
	public class IObfuscatedDataProvider : Il2CppObjectBase
	{
		// Token: 0x06000EC1 RID: 3777 RVA: 0x00008E69 File Offset: 0x00007069
		// Note: this type is marked as 'beforefieldinit'.
		static IObfuscatedDataProvider()
		{
			Il2CppClassPointerStore<IObfuscatedDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "IObfuscatedDataProvider");
			IObfuscatedDataProvider.NativeMethodInfoPtr_ChildCount_Public_Abstract_Virtual_New_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObfuscatedDataProvider>.NativeClassPtr, 100665403);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0003DDBC File Offset: 0x0003BFBC
		[CallerCount(0)]
		public unsafe virtual int ChildCount(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObfuscatedDataProvider.NativeMethodInfoPtr_ChildCount_Public_Abstract_Virtual_New_Int32_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00008E98 File Offset: 0x00007098
		public IObfuscatedDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr_ChildCount_Public_Abstract_Virtual_New_Int32_EntityComponent_0;
	}
}
