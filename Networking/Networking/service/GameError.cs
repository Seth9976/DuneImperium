using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.service
{
	// Token: 0x02000051 RID: 81
	public class GameError : NetworkMessageEvent
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0000C998 File Offset: 0x0000AB98
		// Note: this type is marked as 'beforefieldinit'.
		static GameError()
		{
			Il2CppClassPointerStore<GameError>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "GameError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameError>.NativeClassPtr);
			GameError.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameError>.NativeClassPtr, "Error");
			GameError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameError>.NativeClassPtr, 100663430);
			GameError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameError>.NativeClassPtr, 100663431);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000CA04 File Offset: 0x0000AC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193833, XrefRangeEnd = 1193838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000CA48 File Offset: 0x0000AC48
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00003B48 File Offset: 0x00001D48
		public GameError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000CA84 File Offset: 0x0000AC84
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003B51 File Offset: 0x00001D51
		public unsafe string Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameError.NativeFieldInfoPtr_Error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameError.NativeFieldInfoPtr_Error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
