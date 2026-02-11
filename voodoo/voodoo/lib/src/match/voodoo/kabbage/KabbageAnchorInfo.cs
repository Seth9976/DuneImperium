using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace lib.src.match.voodoo.kabbage
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public sealed class KabbageAnchorInfo : ValueType
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00009B74 File Offset: 0x00007D74
		// Note: this type is marked as 'beforefieldinit'.
		static KabbageAnchorInfo()
		{
			Il2CppClassPointerStore<KabbageAnchorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.src.match.voodoo.kabbage", "KabbageAnchorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KabbageAnchorInfo>.NativeClassPtr);
			KabbageAnchorInfo.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KabbageAnchorInfo>.NativeClassPtr, "fxName");
			KabbageAnchorInfo.NativeFieldInfoPtr_kabbageAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KabbageAnchorInfo>.NativeClassPtr, "kabbageAnchor");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021AB File Offset: 0x000003AB
		public KabbageAnchorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000021B4 File Offset: 0x000003B4
		public KabbageAnchorInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KabbageAnchorInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00009BCC File Offset: 0x00007DCC
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000021C6 File Offset: 0x000003C6
		public unsafe string fxName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KabbageAnchorInfo.NativeFieldInfoPtr_fxName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KabbageAnchorInfo.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00009BF4 File Offset: 0x00007DF4
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000021E5 File Offset: 0x000003E5
		public unsafe Transform kabbageAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KabbageAnchorInfo.NativeFieldInfoPtr_kabbageAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KabbageAnchorInfo.NativeFieldInfoPtr_kabbageAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_fxName;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_kabbageAnchor;
	}
}
