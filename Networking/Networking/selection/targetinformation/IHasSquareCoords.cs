using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200007A RID: 122
	public class IHasSquareCoords : Il2CppObjectBase
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00010BC4 File Offset: 0x0000EDC4
		// Note: this type is marked as 'beforefieldinit'.
		static IHasSquareCoords()
		{
			Il2CppClassPointerStore<IHasSquareCoords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "IHasSquareCoords");
			IHasSquareCoords.NativeMethodInfoPtr_At_Public_Abstract_Virtual_New_IEntity_SquareCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasSquareCoords>.NativeClassPtr, 100663557);
			IHasSquareCoords.NativeMethodInfoPtr_At_Public_Abstract_Virtual_New_IEntity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasSquareCoords>.NativeClassPtr, 100663558);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00010C14 File Offset: 0x0000EE14
		[CallerCount(0)]
		public unsafe virtual IEntity At(SquareCoords coords)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref coords;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasSquareCoords.NativeMethodInfoPtr_At_Public_Abstract_Virtual_New_IEntity_SquareCoords_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntity>(intPtr3) : null;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00010C6C File Offset: 0x0000EE6C
		[CallerCount(0)]
		public unsafe virtual IEntity At(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasSquareCoords.NativeMethodInfoPtr_At_Public_Abstract_Virtual_New_IEntity_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntity>(intPtr3) : null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000047FE File Offset: 0x000029FE
		public IHasSquareCoords(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_At_Public_Abstract_Virtual_New_IEntity_SquareCoords_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_At_Public_Abstract_Virtual_New_IEntity_Int32_Int32_0;
	}
}
