using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000034 RID: 52
	public class Authenticated : TypedMessage
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000B108 File Offset: 0x00009308
		// Note: this type is marked as 'beforefieldinit'.
		static Authenticated()
		{
			Il2CppClassPointerStore<Authenticated>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "Authenticated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Authenticated>.NativeClassPtr);
			Authenticated.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authenticated>.NativeClassPtr, "AccountID");
			Authenticated.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authenticated>.NativeClassPtr, "Username");
			Authenticated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authenticated>.NativeClassPtr, 100663606);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000B174 File Offset: 0x00009374
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authenticated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Authenticated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authenticated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002D93 File Offset: 0x00000F93
		public Authenticated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000B1B0 File Offset: 0x000093B0
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002D9C File Offset: 0x00000F9C
		public unsafe string AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authenticated.NativeFieldInfoPtr_AccountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authenticated.NativeFieldInfoPtr_AccountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000B1D8 File Offset: 0x000093D8
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002DBB File Offset: 0x00000FBB
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authenticated.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authenticated.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
