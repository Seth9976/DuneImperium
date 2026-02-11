using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.utils
{
	// Token: 0x02000008 RID: 8
	public class IVersionedModel : Il2CppObjectBase
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002140 File Offset: 0x00000340
		// Note: this type is marked as 'beforefieldinit'.
		static IVersionedModel()
		{
			Il2CppClassPointerStore<IVersionedModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils", "IVersionedModel");
			IVersionedModel.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVersionedModel>.NativeClassPtr, 100663310);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00004AD8 File Offset: 0x00002CD8
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVersionedModel.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000216F File Offset: 0x0000036F
		public IVersionedModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0;
	}
}
