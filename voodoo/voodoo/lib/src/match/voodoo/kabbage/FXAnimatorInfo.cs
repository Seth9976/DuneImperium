using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lib.src.match.voodoo.kabbage
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public sealed class FXAnimatorInfo : ValueType
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00009C24 File Offset: 0x00007E24
		// Note: this type is marked as 'beforefieldinit'.
		static FXAnimatorInfo()
		{
			Il2CppClassPointerStore<FXAnimatorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.src.match.voodoo.kabbage", "FXAnimatorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXAnimatorInfo>.NativeClassPtr);
			FXAnimatorInfo.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXAnimatorInfo>.NativeClassPtr, "fxName");
			FXAnimatorInfo.NativeFieldInfoPtr_fxAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXAnimatorInfo>.NativeClassPtr, "fxAnimators");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002204 File Offset: 0x00000404
		public FXAnimatorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000220D File Offset: 0x0000040D
		public FXAnimatorInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXAnimatorInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00009C7C File Offset: 0x00007E7C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000221F File Offset: 0x0000041F
		public unsafe string fxName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXAnimatorInfo.NativeFieldInfoPtr_fxName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXAnimatorInfo.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00009CA4 File Offset: 0x00007EA4
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000223E File Offset: 0x0000043E
		public unsafe Il2CppReferenceArray<AnimatorTrigger> fxAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXAnimatorInfo.NativeFieldInfoPtr_fxAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimatorTrigger>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXAnimatorInfo.NativeFieldInfoPtr_fxAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_fxName;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_fxAnimators;
	}
}
