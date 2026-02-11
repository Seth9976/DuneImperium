using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace localization
{
	// Token: 0x02000007 RID: 7
	public class Localization : Object
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002AE4 File Offset: 0x00000CE4
		// Note: this type is marked as 'beforefieldinit'.
		static Localization()
		{
			Il2CppClassPointerStore<Localization>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization.dll", "localization", "Localization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Localization>.NativeClassPtr);
			Localization.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "Key");
			Localization.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localization>.NativeClassPtr, "Value");
			Localization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localization>.NativeClassPtr, 100663305);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002B50 File Offset: 0x00000D50
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Localization()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Localization>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Localization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000212A File Offset: 0x0000032A
		public Localization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002B8C File Offset: 0x00000D8C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002133 File Offset: 0x00000333
		public unsafe string Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localization.NativeFieldInfoPtr_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localization.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002BB4 File Offset: 0x00000DB4
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localization.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Localization.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
