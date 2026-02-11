using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x02000011 RID: 17
	public class PassToPlayer : GameMessage
	{
		// Token: 0x06000095 RID: 149 RVA: 0x0000796C File Offset: 0x00005B6C
		// Note: this type is marked as 'beforefieldinit'.
		static PassToPlayer()
		{
			Il2CppClassPointerStore<PassToPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.actions", "PassToPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassToPlayer>.NativeClassPtr);
			PassToPlayer.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayer>.NativeClassPtr, "AccountID");
			PassToPlayer.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayer>.NativeClassPtr, "Username");
			PassToPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayer>.NativeClassPtr, 100663327);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000079D8 File Offset: 0x00005BD8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassToPlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassToPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000264A File Offset: 0x0000084A
		public PassToPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00007A14 File Offset: 0x00005C14
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002653 File Offset: 0x00000853
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayer.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayer.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00007A44 File Offset: 0x00005C44
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002672 File Offset: 0x00000872
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayer.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayer.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
