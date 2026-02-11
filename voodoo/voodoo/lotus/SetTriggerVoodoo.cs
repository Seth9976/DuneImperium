using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus
{
	// Token: 0x0200006A RID: 106
	public class SetTriggerVoodoo : EntityVoodoo
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x0001DFF4 File Offset: 0x0001C1F4
		// Note: this type is marked as 'beforefieldinit'.
		static SetTriggerVoodoo()
		{
			Il2CppClassPointerStore<SetTriggerVoodoo>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "SetTriggerVoodoo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTriggerVoodoo>.NativeClassPtr);
			SetTriggerVoodoo.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTriggerVoodoo>.NativeClassPtr, "trigger");
			SetTriggerVoodoo.NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTriggerVoodoo>.NativeClassPtr, 100664154);
			SetTriggerVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTriggerVoodoo>.NativeClassPtr, 100664155);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001E060 File Offset: 0x0001C260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112853, XrefRangeEnd = 1112855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnWaypointReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetTriggerVoodoo.NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001E09C File Offset: 0x0001C29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112855, XrefRangeEnd = 1112859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTriggerVoodoo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTriggerVoodoo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTriggerVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000050F0 File Offset: 0x000032F0
		public SetTriggerVoodoo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x000050F9 File Offset: 0x000032F9
		public unsafe string trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTriggerVoodoo.NativeFieldInfoPtr_trigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTriggerVoodoo.NativeFieldInfoPtr_trigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_trigger;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_Void_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
