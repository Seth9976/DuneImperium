using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.match.commands
{
	// Token: 0x0200016E RID: 366
	public class ClientEventCommandsConstructorAttribute : Attribute
	{
		// Token: 0x06001525 RID: 5413 RVA: 0x00068A8C File Offset: 0x00066C8C
		// Note: this type is marked as 'beforefieldinit'.
		static ClientEventCommandsConstructorAttribute()
		{
			Il2CppClassPointerStore<ClientEventCommandsConstructorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.commands", "ClientEventCommandsConstructorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventCommandsConstructorAttribute>.NativeClassPtr);
			ClientEventCommandsConstructorAttribute.NativeFieldInfoPtr_IsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventCommandsConstructorAttribute>.NativeClassPtr, "IsOverride");
			ClientEventCommandsConstructorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommandsConstructorAttribute>.NativeClassPtr, 100666493);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00068AE4 File Offset: 0x00066CE4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientEventCommandsConstructorAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventCommandsConstructorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommandsConstructorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0000957A File Offset: 0x0000777A
		public ClientEventCommandsConstructorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x00068B20 File Offset: 0x00066D20
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x00009583 File Offset: 0x00007783
		public unsafe bool IsOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommandsConstructorAttribute.NativeFieldInfoPtr_IsOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommandsConstructorAttribute.NativeFieldInfoPtr_IsOverride)) = value;
			}
		}

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr_IsOverride;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
