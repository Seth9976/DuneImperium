using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.match.delorean
{
	// Token: 0x020000A0 RID: 160
	public class ISelectionModel : Il2CppObjectBase
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x00029440 File Offset: 0x00027640
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectionModel()
		{
			Il2CppClassPointerStore<ISelectionModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.match.delorean", "ISelectionModel");
			ISelectionModel.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionModel>.NativeClassPtr, 100664523);
			ISelectionModel.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_SerializedGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionModel>.NativeClassPtr, 100664524);
			ISelectionModel.NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionModel>.NativeClassPtr, 100664525);
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x000294A4 File Offset: 0x000276A4
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionModel.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000294EC File Offset: 0x000276EC
		[CallerCount(0)]
		public unsafe virtual void Initialize(SerializedGameState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionModel.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_SerializedGameState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0002953C File Offset: 0x0002773C
		[CallerCount(0)]
		public unsafe virtual void Apply(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionModel.NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_Void_IGameMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00005778 File Offset: 0x00003978
		public ISelectionModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_SerializedGameState_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_Void_IGameMessage_0;
	}
}
