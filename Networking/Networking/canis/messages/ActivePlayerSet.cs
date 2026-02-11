using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x02000018 RID: 24
	public class ActivePlayerSet : GameMessage
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00007F44 File Offset: 0x00006144
		// Note: this type is marked as 'beforefieldinit'.
		static ActivePlayerSet()
		{
			Il2CppClassPointerStore<ActivePlayerSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "ActivePlayerSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivePlayerSet>.NativeClassPtr);
			ActivePlayerSet.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivePlayerSet>.NativeClassPtr, "AccountID");
			ActivePlayerSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerSet>.NativeClassPtr, 100663335);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00007F9C File Offset: 0x0000619C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivePlayerSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivePlayerSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlayerSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000282D File Offset: 0x00000A2D
		public ActivePlayerSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00007FD8 File Offset: 0x000061D8
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002836 File Offset: 0x00000A36
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerSet.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerSet.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
