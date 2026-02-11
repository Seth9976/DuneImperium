using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus
{
	// Token: 0x020000D7 RID: 215
	public class ISimpleEntityConfigurator : Il2CppObjectBase
	{
		// Token: 0x06000ACB RID: 2763 RVA: 0x00033728 File Offset: 0x00031928
		// Note: this type is marked as 'beforefieldinit'.
		static ISimpleEntityConfigurator()
		{
			Il2CppClassPointerStore<ISimpleEntityConfigurator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ISimpleEntityConfigurator");
			ISimpleEntityConfigurator.NativeMethodInfoPtr_ConfigurePlaymat_Public_Abstract_Virtual_New_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleEntityConfigurator>.NativeClassPtr, 100665036);
			ISimpleEntityConfigurator.NativeMethodInfoPtr_ConfigurePlayer_Public_Abstract_Virtual_New_Void_EntityComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleEntityConfigurator>.NativeClassPtr, 100665037);
			ISimpleEntityConfigurator.NativeMethodInfoPtr_ConfigureEntity_Public_Abstract_Virtual_New_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleEntityConfigurator>.NativeClassPtr, 100665038);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0003378C File Offset: 0x0003198C
		[CallerCount(0)]
		public unsafe virtual void ConfigurePlaymat(EntityComponent composition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleEntityConfigurator.NativeMethodInfoPtr_ConfigurePlaymat_Public_Abstract_Virtual_New_Void_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000337DC File Offset: 0x000319DC
		[CallerCount(0)]
		public unsafe virtual void ConfigurePlayer(EntityComponent composition, int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleEntityConfigurator.NativeMethodInfoPtr_ConfigurePlayer_Public_Abstract_Virtual_New_Void_EntityComponent_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00033838 File Offset: 0x00031A38
		[CallerCount(0)]
		public unsafe virtual void ConfigureEntity(EntityComponent composition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleEntityConfigurator.NativeMethodInfoPtr_ConfigureEntity_Public_Abstract_Virtual_New_Void_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00006F55 File Offset: 0x00005155
		public ISimpleEntityConfigurator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlaymat_Public_Abstract_Virtual_New_Void_EntityComponent_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayer_Public_Abstract_Virtual_New_Void_EntityComponent_Int32_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureEntity_Public_Abstract_Virtual_New_Void_EntityComponent_0;
	}
}
